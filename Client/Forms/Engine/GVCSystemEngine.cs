using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Services;
using System.Reflection;
using System.ServiceModel;
using System.Windows.Forms;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Client.Forms.Forms;
using it.dedagroup.GVC.Repository.Common.Configurations;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace it.dedagroup.GVC.Client.Forms.Engine
{
    public delegate ServiceResult GenericDelegate<ServiceResult>();

    public class GVCSystemEngine
    {

		#region Fields (6) 

        private static ICooperatives cooperatives;
        private static String entryAssemblyVersion = String.Empty;
        private static GVCSystemEngine instance = null;
        private static DizionarioFDT[] listDizionari = null;
        private static UtenteFDT user = null;
        private static IUsers users;

		#endregion Fields 

		#region Constructors (1) 

        /// <summary>
        /// Initializes a new instance of the <see cref="MajaSystemEngine"/> class.
        /// </summary>
        public GVCSystemEngine()
        {
            //Log("Created GVCSystemEngine");
            //Log(String.Concat("User logged: ", System.Threading.Thread.CurrentPrincipal.Identity.Name));

            GetListDictionaries();
        }

		#endregion Constructors 

		#region Properties (5) 

        public ICooperatives Cooperatives
        {
            get
            {
                if (cooperatives == null)
                    cooperatives = CreateChannel<ICooperatives>();
                return cooperatives;
            }
        }

        /// <summary>
        /// Gets the entry assembly version.
        /// </summary>
        public static String EntryAssemblyVersion
        {
            get
            {
                if (String.IsNullOrEmpty(entryAssemblyVersion))
                {
                    System.Reflection.Assembly assembly = System.Reflection.Assembly.GetEntryAssembly();
                    if (assembly != null)
                    {
                        entryAssemblyVersion = assembly.GetName().Version.ToString();
                    }
                }
                return entryAssemblyVersion;
            }
        }

        public static GVCSystemEngine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GVCSystemEngine();
                }
                return instance;
            }
        }

        /// <summary>
        /// Gets the current logged in user.
        /// </summary>
        public UtenteFDT User
        {
            get
            {
                return user;
            }
        }

        public IUsers Users
        {
            get
            {
                if (users == null)
                users = CreateChannel<IUsers>();
                return users;
            }
        }

		#endregion Properties 

		#region Methods (5) 


		// Public Methods (3) 

        /// <summary>
        /// Changes the user password.
        /// </summary>
        /// <param name="owner">The owner.</param>
        public void ChangePassword(IWin32Window owner)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            if (changePasswordForm.ShowDialog(owner) == DialogResult.OK)
            {
                try
                {
                    if (!Users.ChangePassword(User.UserName, changePasswordForm.NewPassword.Text))
                        throw new ArgumentNullException("Password");

                    OeF.Forms.OeFMessageBox.Show(
                        String.Format(string.Concat("Cambio della password eseguito correttamente.",
                                                    Environment.NewLine,
                                                    "Riavviare il client.")),
                        "GVC Client",
                        MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    OeF.Forms.OeFMessageBox.Show(
                        String.Format("Errore durante il cambio della password."),
                        "GVC Client",
                        ex.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Invokes the remote service.
        /// </summary>
        /// <typeparam name="ServiceType">The type of the service.</typeparam>
        /// <typeparam name="ServiceResult">The type of the service result.</typeparam>
        /// <param name="invokeMethod">The invoke method.</param>
        /// <param name="allowRetry">if set to <c>true</c> the system if the service is null or there is an error, displays a message for retry.</param>
        /// <returns></returns>
        public ServiceResult InvokeService<ServiceType, ServiceResult>(GenericDelegate<ServiceResult> invokeMethod, Boolean allowRetry)
        {
            ServiceResult result = default(ServiceResult);

            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return result;
            try
            {
                Boolean goOn = false;
                do
                {
                    try
                    {
                        result = invokeMethod.Invoke();

                        goOn = true;
                    }
                    catch (CommunicationException cex)
                    {
                        System.Diagnostics.Debug.WriteLine(cex.Message);
                        ExceptionPolicy.HandleException(cex, ExceptionsPolicies.UserTier);
                        if (Login() == null)
                            goOn = false;
                        goOn = true;
                    }
                    catch (Exception ex)
                    {
                        // Forse retry for method without try catch block
                        if (!allowRetry)
                        {
                            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(true);
                            for (int i = 0; i < stackTrace.FrameCount; i++)
                            {
                                if (i == 1)
                                {
                                    System.Diagnostics.StackFrame sf = stackTrace.GetFrame(i);
                                    MethodBase method = sf.GetMethod();
                                    MethodBody methodBody = method.GetMethodBody();
                                    if (methodBody.ExceptionHandlingClauses.Count == 0)
                                        allowRetry = true;
                                    break;
                                }

                            }
                        }

                        if (allowRetry)
                        {
                            if (OeF.Forms.OeFMessageBox.Show(
                                String.Format("Errore nella chiamata al servizio! Riprovare?",
                                String.Empty),
                                "GVC Client",
                                String.Concat(ex.Message, " ", (ex.InnerException != null ? ex.InnerException.Message : String.Empty)),
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                goOn = false;
                            }
                            else
                            {
                                goOn = true;
                            }
                        }
                        else
                        {
                            throw ex;
                        }
                    }
                }
                while (goOn == false);
                return result;
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex, ExceptionsPolicies.UserTier);
                throw ex;
            }
        }

        /// <summary>
        /// Logins the user.
        /// </summary>
        /// <returns></returns>
        public static UtenteFDT Login()
        {
            UtenteFDT userValue = null;
            Login login = null;
            DebugLogin debugLogin = null;
            System.DirectoryServices.ActiveDirectory.Domain domain = null;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                try
                {
                    //domain = System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain();
                }
                catch (Exception ex)
                {
                    ExceptionPolicy.HandleException(ex, ExceptionsPolicies.UserTier);
                }
            }
            while (true)
            {
                String userName = String.Empty;
                String password = String.Empty;

                if (System.Diagnostics.Debugger.IsAttached &&
                    domain != null &&
                    domain.Name.ToLower().StartsWith("deltadator"))
                {
                    debugLogin = new DebugLogin();
                    debugLogin.AddRoles(UserRoles.GetList());
                    if (debugLogin.ShowDialog() == DialogResult.OK)
                    {
                        userName = debugLogin.UserName;
                        password = "workbz";
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (login == null ||
                        login.IsDisposed)
                        login = new Login();
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        userName = login.Username.Text;
                        password = login.Password.Text;
                    }
                    else
                    {
                        break;
                    }
                }

                Application.DoEvents();
                try
                {
                    users = CreateChannel<IUsers>(userName, password);
                    userValue = user = users.GetExtended();

                    if (!users.IsClientAllowed(EntryAssemblyVersion))
                    {
                        userValue = null;
                        //OeF.Forms.OeFMessageBox.Show(
                        //    String.Format("Attenzione! \r\nNon è possibile accedere al server con un client di versione '{0}'.",
                        //    EntryAssemblyVersion),
                        //    "GVC Client",
                        //    MessageBoxButtons.OK,
                        //    MessageBoxIcon.Warning);

                        ClientVersionMessage cvm = new ClientVersionMessage(EntryAssemblyVersion);
                        cvm.ShowDialog();
                    }
                    else if (user != null &&
                        (user.Ruoli == null ||
                        user.Ruoli.Length == 0))
                    {
                        userValue = null;
                        OeF.Forms.OeFMessageBox.Show(
                            String.Format("Attenzione! \r\nNon è possibile accedere al sistema perchè non è stato configurato alcun ruolo per l'utente '{0}'.",
                            userName),
                            "GVC Client",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    break;
                }
                catch (System.ServiceModel.Security.MessageSecurityException msex)
                {
                    ExceptionPolicy.HandleException(msex, ExceptionsPolicies.UserTier);
                    if (login != null)
                    {
                        login.ErrorProvider.SetError(login.Username, "Username e/o password non corretti!");
                    }
                }
                catch (CommunicationException cex)
                {
                    ExceptionPolicy.HandleException(cex, ExceptionsPolicies.UserTier);
                    login.ErrorProvider.SetError(login.Username, cex.Message);
                }
                catch (Exception ex)
                {
                    ExceptionPolicy.HandleException(ex, ExceptionsPolicies.UserTier);
                    login.ErrorProvider.SetError(login.Username, ex.Message);
                }
            }

            return userValue;
        }

		// Private Methods (2) 

        private static ServiceType CreateChannel<ServiceType>(String userName, String password)
        {
            try
            {
                ChannelFactory<ServiceType> factory = null;
                factory = new ChannelFactory<ServiceType>(String.Concat("CustomBinding_", typeof(ServiceType).Name.Substring(1)));
                if (!String.IsNullOrEmpty(userName))
                    factory.Credentials.UserName.UserName = userName;
                if (!String.IsNullOrEmpty(password))
                    factory.Credentials.UserName.Password = password;
                return factory.CreateChannel();
            }
            catch
            {
                return default(ServiceType);
            }
        }

        private static ServiceType CreateChannel<ServiceType>()
        {
            return CreateChannel<ServiceType>(null, null);
        }

        public String RemoveDiacritics(String s)
        {
            String toReturn = String.Empty;

            s = s.Replace("'", "''");
            String normalizedString = s.Normalize(NormalizationForm.FormD);

            StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 0; i < normalizedString.Length; i++)
            //{
            //    Char c = normalizedString[i];

            //    if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c) !=
            //        System.Globalization.UnicodeCategory.NonSpacingMark)
            //    {
            //        stringBuilder.Append(c);
            //    }
            //    else
            //    {
            //        stringBuilder.Append("''");
            //    }
            //}

            if (stringBuilder.Length >0)
            {
                toReturn = stringBuilder.ToString();
            }
            else
            {
                toReturn = s;
            }

            return toReturn;

        }

		#endregion Methods 


        #region Dizionari

        private Dictionary<string, DizionarioFDT[]> corrispondenceTypeDictionary = 
            new Dictionary<string, DizionarioFDT[]>();

        public DizionarioFDT[] AddEmptyElement(DizionarioFDT[] listAll)
        {
            DizionarioFDT[] toReturn = null;
            List<DizionarioFDT> listReturn = new List<DizionarioFDT>();

            if (listAll != null &&
                listAll.Length > 0)
            {
                //vuoto
                DizionarioFDT newVuoto = new DizionarioFDT();
                newVuoto.IdElemento = 0;
                newVuoto.Descrizione = " Tutti";

                listReturn.Add(newVuoto);

                foreach (DizionarioFDT diz in listAll)
                {
                    listReturn.Add(diz);
                }
            }

            if (listReturn.Count > 0)
                toReturn = listReturn.ToArray();

            return toReturn;
        }

        public DizionarioFDT[] RemoveEmptyElement(DizionarioFDT[] listAll)
        {
            DizionarioFDT[] toReturn = null;
            List<DizionarioFDT> listReturn = new List<DizionarioFDT>();

            if (listAll != null &&
                listAll.Length > 0)
            {
                foreach (DizionarioFDT diz in listAll)
                {
                    if (!String.IsNullOrEmpty(diz.Descrizione.Trim()))
                    {
                        listReturn.Add(diz);
                    }
                }
            }

            if (listReturn.Count > 0)
                toReturn = listReturn.ToArray();

            return toReturn;
        }

        public DizionarioFDT[] OrderActiveElement(DizionarioFDT[] listAll)
        {
            DizionarioFDT[] toReturn = null;
            List<DizionarioFDT> listNotActive = new List<DizionarioFDT>();
            List<DizionarioFDT> listReturn = new List<DizionarioFDT>();

            if (listAll != null &&
                listAll.Length > 0)
            {
                foreach (DizionarioFDT diz in listAll)
                {
                    if (!String.IsNullOrEmpty(diz.Descrizione.Trim()))
                    {
                        if (diz.Attivo == false)
                        {
                            listNotActive.Add(diz);
                        }
                        else
                        {
                            listReturn.Add(diz);
                        }
                    }
                }
            }

            if (listNotActive.Count > 0)
                listReturn.AddRange(listNotActive);

            if (listReturn.Count > 0)
                toReturn = listReturn.ToArray();

            return toReturn;
        }

        public void ResetDizionari()
        {
            listDizionari = null;
            corrispondenceTypeDictionary = new Dictionary<string, DizionarioFDT[]>();
        }

        private void GetListDictionaries()
        {
            if (listDizionari == null)
            {
                listDizionari = this.InvokeService<ICooperatives, DizionarioFDT[]>(
                                        delegate() { return Cooperatives.GetAllDictionaries(); },
                                        false);

                CompleteTheDictionaries();

                InitializeDictionaries();
            }
        }

        private void InitializeDictionaries()
        {
            if (listDizionari != null)
            {
                string type = string.Empty;
                List<DizionarioFDT> listTmp = null;
                foreach (DizionarioFDT item in listDizionari)
                {
                    type = item.Tipo;
                    
                    if (corrispondenceTypeDictionary.ContainsKey(type))
                    {
                        listTmp = new List<DizionarioFDT>(corrispondenceTypeDictionary[type]);
                        corrispondenceTypeDictionary.Remove(type);
                    }
                    else
                    {
                        listTmp = new List<DizionarioFDT>();
                    }
                    listTmp.Add(item);
                    corrispondenceTypeDictionary.Add(type, listTmp.ToArray());
                }
            }
        }

        public DizionarioFDT[] GetDizionarioByType(string type)
        {
            List<DizionarioFDT> toReturn = new List<DizionarioFDT>();
            if (corrispondenceTypeDictionary.Count == 0)
            {
                GetListDictionaries();
            }

            if (listDizionari != null)
            {
                if (corrispondenceTypeDictionary.ContainsKey(type))
                {
                    toReturn = new List<DizionarioFDT>(corrispondenceTypeDictionary[type]);
                }
                else
                {
                    foreach (DizionarioFDT item in listDizionari)
                    {
                        if (item.Tipo.Equals(type))
                        {
                            toReturn.Add(item);
                        }
                    }

                    corrispondenceTypeDictionary.Add(type, toReturn.ToArray());
                }
            }
            else
            {
               // return GetListDictionariesInternal(type, 1);
            }
            return toReturn.ToArray();
        }

        public DizionarioFDT[] GetListDictionariesInternal(string type, int index)
        {
            if (index == 5) return null;

            if (listDizionari == null)
            {
                GetListDictionaries();
            }
            List<DizionarioFDT> toReturn = new List<DizionarioFDT>();
            if (listDizionari != null)
            {
                if (corrispondenceTypeDictionary.ContainsKey(type))
                {
                    toReturn = new List<DizionarioFDT>(corrispondenceTypeDictionary[type]);
                }
                else
                {
                    foreach (DizionarioFDT item in listDizionari)
                    {
                        if (item.Tipo.Equals(type))
                        {
                            toReturn.Add(item);
                        }
                    }

                    corrispondenceTypeDictionary.Add(type, toReturn.ToArray());
                }
            }
            else
            {
                return GetListDictionariesInternal(type, index++);
            }
            return toReturn.ToArray();
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="eventID">The event ID.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        public void Log(int eventID, int priority, string message, string category)
        {
            try
            {
                LogEntry logEntry = new LogEntry();
                logEntry.EventId = eventID;
                logEntry.Priority = priority;
                logEntry.Message = message;
                logEntry.Categories.Clear();
                logEntry.Categories.Add(category);
                Logger.Write(logEntry);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        public void Log(string message, string category)
        {
            Log(0, 0, message, category);
        }

        /// <summary>
        /// Logs a message in the general category.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Log(string message)
        {
            Log(0, 0, message, LoggingCategories.General);
        }

        private void CompleteTheDictionaries()
        {
            if (corrispondenceTypeDictionary != null)
            {
                #region Sezione

                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.SEZIONE))
                {
                    List<DizionarioFDT> listSezioni = new List<DizionarioFDT>();

                    DizionarioFDT sez0 = new DizionarioFDT();
                    sez0.IdElemento = -1;
                    sez0.Descrizione = " ";
                    listSezioni.Add(sez0);

                    DizionarioFDT sez = new DizionarioFDT();
                    sez.IdElemento = 1;
                    sez.Descrizione = "PREVALENTE";
                    listSezioni.Add(sez);

                    DizionarioFDT sez2 = new DizionarioFDT();
                    sez2.IdElemento = 2;
                    sez2.Descrizione = "DIVERSE";
                    listSezioni.Add(sez2);

                    DizionarioFDT sez3 = new DizionarioFDT();
                    sez3.IdElemento = 3;
                    sez3.Descrizione = "MUTUO SOCCORSO";
                    listSezioni.Add(sez3);

                    corrispondenceTypeDictionary.Add(
                       it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.SEZIONE,
                       listSezioni.ToArray());
                }
        
                #endregion Sezione
                #region Sotto sezione (di sezione 1)
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.SOTTO_SEZIONE_UNO))
                {
                    List<DizionarioFDT> listSottoSezioni = new List<DizionarioFDT>();

                    DizionarioFDT ssez0 = new DizionarioFDT();
                    ssez0.IdElemento = -1;
                    ssez0.Descrizione = " ";
                    listSottoSezioni.Add(ssez0);

                    DizionarioFDT ssez = new DizionarioFDT();
                    ssez.IdElemento = 1;
                    ssez.Descrizione = "Sempre (di diritto)";
                    listSottoSezioni.Add(ssez);

                    DizionarioFDT ssez2 = new DizionarioFDT();
                    ssez2.IdElemento = 2;
                    ssez2.Descrizione = "A verifica annuale";
                    listSottoSezioni.Add(ssez2);

                    corrispondenceTypeDictionary.Add(
                       it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.SOTTO_SEZIONE_UNO,
                       listSottoSezioni.ToArray());
                }
                #endregion Sotto sezione (di sezione 1)
                #region Sotto sezione (di sezione 2)
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.SOTTO_SEZIONE_DUE))
                {
                    List<DizionarioFDT> listSottoSezioni = new List<DizionarioFDT>();

                    DizionarioFDT ssez0 = new DizionarioFDT();
                    ssez0.IdElemento = -1;
                    ssez0.Descrizione = " ";
                    listSottoSezioni.Add(ssez0);

                    DizionarioFDT ssez3 = new DizionarioFDT();
                    ssez3.IdElemento = 1;
                    ssez3.Descrizione = "Non prevalente";
                    listSottoSezioni.Add(ssez3);

                    DizionarioFDT ssez4 = new DizionarioFDT();
                    ssez4.IdElemento = 2;
                    ssez4.Descrizione = "Non soggette";
                    listSottoSezioni.Add(ssez4);

                    corrispondenceTypeDictionary.Add(
                       it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.SOTTO_SEZIONE_DUE,
                       listSottoSezioni.ToArray());
                }
                #endregion Sotto sezione (di sezione 2)
                #region Categoria sociale
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.CATEGORIA_SOCIALE))
                {
                    List<DizionarioFDT> listCategoriaSociale = new List<DizionarioFDT>();

                    DizionarioFDT d = new DizionarioFDT();
                    d.IdElemento = 0;
                    d.Descrizione = " ";
                    listCategoriaSociale.Add(d);

                    DizionarioFDT d1 = new DizionarioFDT();
                    d1.IdElemento = 1;
                    d1.Descrizione = "Sociale";
                    listCategoriaSociale.Add(d1);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.CATEGORIA_SOCIALE,
                        listCategoriaSociale.ToArray());
                }

                #endregion Categoria sociale
                #region Tipi durata
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_DURATA))
                {
                    List<DizionarioFDT> listCategoriaSociale = new List<DizionarioFDT>();

                    DizionarioFDT d = new DizionarioFDT();
                    d.IdElemento = 0;
                    d.Descrizione = "Illimitata";
                    listCategoriaSociale.Add(d);

                    DizionarioFDT d1 = new DizionarioFDT();
                    d1.IdElemento = 1;
                    d1.Descrizione = "Indeterminata";
                    listCategoriaSociale.Add(d1);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_DURATA,
                        listCategoriaSociale.ToArray());
                }

                #endregion Tipi durata
                #region Tipi cancellazione
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_CANCELLAZIONE))
                {
                    List<DizionarioFDT> listCancellazioni = new List<DizionarioFDT>();

                    DizionarioFDT c1 = new DizionarioFDT();
                    c1.IdElemento = 1;
                    c1.Descrizione = "Registro imprese";
                    listCancellazioni.Add(c1);

                    DizionarioFDT c2 = new DizionarioFDT();
                    c2.IdElemento = 2;
                    c2.Descrizione = "Registro cooperative";
                    listCancellazioni.Add(c2);

                    DizionarioFDT c3 = new DizionarioFDT();
                    c3.IdElemento = 3;
                    c3.Descrizione = "Albo nazionale enti cooperativi";
                    listCancellazioni.Add(c3);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_CANCELLAZIONE,
                        listCancellazioni.ToArray());
                }
                #endregion Tipi cancellazione
                #region Conferimento capitale
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.CONFERIMENTO_CAPITALE))
                {
                    List<DizionarioFDT> listConferimenti = new List<DizionarioFDT>();

                    DizionarioFDT cc1 = new DizionarioFDT();
                    cc1.IdElemento = 1;
                    cc1.Descrizione = "Quote";
                    listConferimenti.Add(cc1);

                    DizionarioFDT cc2 = new DizionarioFDT();
                    cc2.IdElemento = 0;
                    cc2.Descrizione = "Azioni";
                    listConferimenti.Add(cc2);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.CONFERIMENTO_CAPITALE,
                        listConferimenti.ToArray());
                }
                #endregion Conferimento capitale
                #region Tipi iscrizione header

                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_ISCRIZIONE_HEADER))
                {
                    List<DizionarioFDT> listIscrizione = new List<DizionarioFDT>();

                    DizionarioFDT sez = new DizionarioFDT();
                    sez.IdElemento = TipoIscrizioneHeader.Iscritta;
                    sez.Descrizione = "ISCRITTA";
                    listIscrizione.Add(sez);

                    DizionarioFDT sez2 = new DizionarioFDT();
                    sez2.IdElemento = TipoIscrizioneHeader.NonIscritta;
                    sez2.Descrizione = "NON ISCRITTA";
                    listIscrizione.Add(sez2);

                    DizionarioFDT sez3 = new DizionarioFDT();
                    sez3.IdElemento = TipoIscrizioneHeader.Cancellata;
                    sez3.Descrizione = "CANCELLATA";
                    listIscrizione.Add(sez3);

                    corrispondenceTypeDictionary.Add(
                       it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_ISCRIZIONE_HEADER,
                       listIscrizione.ToArray());
                }

                #endregion Tipi iscrizione header
                #region Tipi esito fallimento
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_ESITO_FALLIMENTI))
                {
                    List<DizionarioFDT> listEsiti = new List<DizionarioFDT>();

                    DizionarioFDT esito1 = new DizionarioFDT();
                    esito1.IdElemento = 1;
                    esito1.Descrizione = "Concluso";
                    listEsiti.Add(esito1);

                    DizionarioFDT esito2 = new DizionarioFDT();
                    esito2.IdElemento = 2;
                    esito2.Descrizione = "Revocato";
                    listEsiti.Add(esito2);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_ESITO_FALLIMENTI,
                        listEsiti.ToArray());
                }
                #endregion Tipi esito fallimento
                #region Tipi contributo liquidazione

                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_CONTRIBUTO))
                {
                    List<DizionarioFDT> listContributi = new List<DizionarioFDT>();

                    DizionarioFDT contributo = new DizionarioFDT();
                    contributo.IdElemento = 1;
                    contributo.Descrizione = "Anticipo";
                    listContributi.Add(contributo);

                    DizionarioFDT contributo2 = new DizionarioFDT();
                    contributo2.IdElemento = 2;
                    contributo2.Descrizione = "Saldo";
                    listContributi.Add(contributo2);

                    corrispondenceTypeDictionary.Add(
                       it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_CONTRIBUTO,
                       listContributi.ToArray());
                }

                #endregion Tipi contributo liquidazione
                #region Tipi contributo compenso

                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_CONTRIBUTO_COMPENSO))
                {
                    List<DizionarioFDT> listContributiC = new List<DizionarioFDT>();

                    DizionarioFDT contributoC = new DizionarioFDT();
                    contributoC.IdElemento = 1;
                    contributoC.Descrizione = "Acconto";
                    listContributiC.Add(contributoC);

                    DizionarioFDT contributoC2 = new DizionarioFDT();
                    contributoC2.IdElemento = 2;
                    contributoC2.Descrizione = "Saldo";
                    listContributiC.Add(contributoC2);

                    corrispondenceTypeDictionary.Add(
                       it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_CONTRIBUTO_COMPENSO,
                       listContributiC.ToArray());
                }

                #endregion Tipi contributo liquidazione
                #region Tipi requisiti prevalenza
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.REQUISITI_PREVALENZA))
                {
                    List<DizionarioFDT> listRequisitiPrevalenza = new List<DizionarioFDT>();

                    DizionarioFDT d = new DizionarioFDT();
                    d.IdElemento = 0;
                    d.Descrizione = " ";
                    listRequisitiPrevalenza.Add(d);

                    DizionarioFDT d1 = new DizionarioFDT();
                    d1.IdElemento = 1;
                    d1.Descrizione = "Sussistono";
                    listRequisitiPrevalenza.Add(d1);

                    DizionarioFDT d2 = new DizionarioFDT();
                    d2.IdElemento = 2;
                    d2.Descrizione = "Non sussistono";
                    listRequisitiPrevalenza.Add(d2);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.REQUISITI_PREVALENZA,
                        listRequisitiPrevalenza.ToArray());
                }

                #endregion Tipi durata
                #region Tipi verifica bilancio
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_VERIFICA_BILANCIO))
                {
                    List<DizionarioFDT> listVerificaBilanci = new List<DizionarioFDT>();

                    DizionarioFDT d0 = new DizionarioFDT();
                    d0.IdElemento = 0;
                    d0.Descrizione = " ";
                    listVerificaBilanci.Add(d0);

                    DizionarioFDT d = new DizionarioFDT();
                    d.IdElemento = 1;
                    d.Descrizione = "Ok";
                    listVerificaBilanci.Add(d);

                    DizionarioFDT d1 = new DizionarioFDT();
                    d1.IdElemento = 2;
                    d1.Descrizione = "Da verificare";
                    listVerificaBilanci.Add(d1);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_VERIFICA_BILANCIO,
                        listVerificaBilanci.ToArray());
                }

                #endregion Tipi verifica bilancio
                #region Tipi stato procedimento
                if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_STATO_PROCEDIMENTO))
                {
                    List<DizionarioFDT> listStatiProc = new List<DizionarioFDT>();

                    DizionarioFDT s = new DizionarioFDT();
                    s.IdElemento = 0;
                    s.Descrizione = " ";
                    listStatiProc.Add(s);

                    DizionarioFDT s0 = new DizionarioFDT();
                    s0.IdElemento = TipiStatoProcedimento.Aperto;
                    s0.Descrizione = "Aperto";
                    listStatiProc.Add(s0);

                    DizionarioFDT s1 = new DizionarioFDT();
                    s1.IdElemento = TipiStatoProcedimento.Sospeso;
                    s1.Descrizione = "Sospeso";
                    listStatiProc.Add(s1);

                    DizionarioFDT s2 = new DizionarioFDT();
                    s2.IdElemento = TipiStatoProcedimento.Ripreso;
                    s2.Descrizione = "Ripreso";
                    listStatiProc.Add(s2);

                    DizionarioFDT s3 = new DizionarioFDT();
                    s3.IdElemento = TipiStatoProcedimento.Chiuso;
                    s3.Descrizione = "Chiuso";
                    listStatiProc.Add(s3);

                    corrispondenceTypeDictionary.Add(
                        it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_STATO_PROCEDIMENTO,
                        listStatiProc.ToArray());
                }

                #endregion Tipi stato procedimento

                //if (!corrispondenceTypeDictionary.ContainsKey(it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_PROCEDIMENTO))
                //{
                    if (listDizionari != null && listDizionari.Length > 0)
                    {
                        foreach (DizionarioFDT diz in listDizionari)
                        {
                            if (diz.Tipo == it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.TIPI_PROCEDIMENTO)
                            {
                                diz.Dettaglio = this.InvokeService<ICooperatives, DettaglioDizionarioFDT>(
                                                delegate() { return Cooperatives.GetDettaglioProcedimentoDictionary(diz.IdElemento); },
                                                false);
                            }
                            else if (diz.Tipo == it.dedagroup.GVC.Repository.Common.Configurations.DictionaryTypes.CADENZA_REVISIONI)
                            {
                                diz.Dettaglio = this.InvokeService<ICooperatives, DettaglioDizionarioFDT>(
                                              delegate() { return Cooperatives.GetDettaglioCadenzaRevDictionary(diz.IdElemento); },
                                              false);
                            }
                        }
                    }
                //}
            }
        }

        #endregion Dizionari

    }
}
