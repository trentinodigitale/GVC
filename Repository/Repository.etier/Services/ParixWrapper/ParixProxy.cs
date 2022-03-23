using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.etier.Services.ParixWrapper;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Configuration;
using System.ServiceModel;

namespace it.dedagroup.GVC.Repository.etier.Services
{

    public class ParixProxy 
    {
        private ServiceAnagraficaImprese parixService;
        private String userName;
        private String password;
        

        public ParixProxy()
        {
            try
            {
                userName = ConfigurationSettings.AppSettings["PARIXProxyUsername"].ToString();
                password = ConfigurationSettings.AppSettings["PARIXProxyPassword"].ToString();

                //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;
            }
            catch (Exception ex)
            {
                try
                {
                    LogEntry logEntry = new LogEntry();
                    logEntry.EventId = 0;
                    logEntry.Priority = 0;
                    logEntry.Message = ex.Message;
                    logEntry.Categories.Clear();
                    logEntry.Categories.Add(it.dedagroup.GVC.Repository.Common.Configurations.LoggingCategories.Trace);
                    Logger.Write(logEntry);
                }
                catch
                {
                }
                throw;
            }
            ChannelFactory<ServiceAnagraficaImprese> factory =
                    new ChannelFactory<ServiceAnagraficaImprese>("ServiceAnagraficaImpreseEndpoint");
            parixService = factory.CreateChannel();

            //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;
        }

        public CooperativaFDT[] GetNotCeasedCooperativesByName(String name)
        {
            return GetAllCooperativeByName(name, false);
        }

        public CooperativaFDT[] GetCooperativesByName(String name)
        {
            return GetAllCooperativeByName(name, true);
        }

        public CooperativaFDT[] GetCooperativesTaxCode(String taxCode)
        {
            RISPOSTA result;
            RicercaImpresaPerCFType searchParameters = new RicercaImpresaPerCFType();
            searchParameters.User = userName;
            searchParameters.Password = password;
            searchParameters.CodiceFiscale = taxCode;
            RicercaImpreseNonCessPerCFRequest request = new RicercaImpreseNonCessPerCFRequest(searchParameters);
            result = parixService.RicercaImpresePerCF(request).RISPOSTA;
            return Converters.ConvertResponseToCooperative(result);
        }

        public CooperativaFDT[] GetCompleteCooperatives(String reaNr)
        {
            RISPOSTA result;
            DettaglioImpresaType searchParameters = new DettaglioImpresaType();
            searchParameters.User = userName;
            searchParameters.Password = password;
            searchParameters.ProvinciaSede = "TN";
            searchParameters.NumeroREASede = reaNr;
            DettaglioRidottoImpresaRequest request = new DettaglioRidottoImpresaRequest(searchParameters);
            result = parixService.DettaglioCompletoImpresa(request).RISPOSTA;
            return Converters.ConvertResponseToCompleteCooperative(result);
        }

        public ComunicazioneCaricaSocialeFDT[] GetPersons(String nrRea, String province)
        {
            RISPOSTA result;
            ListaPerNumREAType partameters = new ListaPerNumREAType();
            partameters.User = userName;
            partameters.Password = password;
            partameters.NumeroREA = nrRea;
            partameters.Provincia = province;
            ListaPersoneImpresaRequest request = new ListaPersoneImpresaRequest(partameters);
            result = parixService.ListaPersoneImpresa(request).RISPOSTA;
            return Converters.ConvertResponseToPerson(result);
        }

        private CooperativaFDT[] GetAllCooperativeByName(String name, bool ceased)
        {
            RISPOSTA result;
            RicercaPerDenominazioneType searchParameters = new RicercaPerDenominazioneType();
            searchParameters.User = userName;
            searchParameters.Password = password;
            searchParameters.Denominazione = name;

            RicercaImpresePerDenomRequest request = new RicercaImpresePerDenomRequest(searchParameters);
            if (!ceased)
            {
                result = parixService.RicercaImpreseNonCessPerDenom(request).RISPOSTA;
            }
            else
            {   
                result = parixService.RicercaImpresePerDenom(request).RISPOSTA;
            }
            return Converters.ConvertResponseToCooperative(result);
        }

        public CooperativaFDT[] GetAllCooperatives(String[] formeGiuridiche/*, Boolean cessate */) 
        {
            RISPOSTA result;
            RicercaImpreseGenericaType searchParameters = new RicercaImpreseGenericaType();
            searchParameters.User = userName;
            searchParameters.Password = password;
            searchParameters.ProvinciaSede = "TN";

            if(formeGiuridiche != null)
                searchParameters.CodiceFormaGiuridica = formeGiuridiche;

            RicercaImpreseGenericaRequest request = new RicercaImpreseGenericaRequest(searchParameters);

            result = parixService.RicercaImpreseGenerica(request).RISPOSTA;

            return Converters.ConvertResponseToCooperative(result);
        }
    }
}
