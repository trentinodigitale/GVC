using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.rtier.Service;
using OeF.Validation;
using System.Data;

namespace it.dedagroup.GVC.Repository.etier.Services
{  
    /// <summary>
    /// 
    /// </summary>
    [KnownType(typeof(OeF.Utility.FieldName))]
    [KnownType(typeof(OeF.Utility.FieldValue))]
    [KnownType(typeof(OeF.Utility.Set))]
    [KnownType(typeof(OeF.Utility.Range))]
    public class Cooperatives : ServiceBase, ICooperatives
    {
        #region Cooperativa

        public CooperativaFDT GetCooperativaByIdRegistro(int idRegistro)
        {
            CooperativaFDT toReturn = null;

            try
            {
                GVCTREGISTRI registro = GVCDB.GVCTREGISTRICollection.GetByPrimaryKey(idRegistro);
                if (registro != null)
                {
                    toReturn = Converters.ConvertIntoCooperative(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(registro.IDOBJ_SOGGETTO));

                    GetCooperativaExtended(toReturn);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the cooperativa.
        /// </summary>
        /// <param name="idCooperativa">The id cooperativa.</param>
        /// <returns></returns>
        public CooperativaFDT GetCooperativaById(int idCooperativa)
        {
            CooperativaFDT toReturn = null;

            try
            {
                toReturn =  Converters.ConvertIntoCooperative(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(idCooperativa));

                GetCooperativaExtended(toReturn);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
              
            return toReturn;
        }

        private void GetCooperativaExtended(CooperativaFDT item)
        {
            if (item != null)
            {
                RegistroCooperativaFDT[] registries =  Converters.ConvertAll(GVCDB.GVCTREGISTRICollection.GetByIDOBJ_SOGGETTO(item.IdSoggetto));
                item.RegistroCooperativa = (registries != null && registries.Length == 1) ? registries[0] : new RegistroCooperativaFDT();

                item.Indirizzi = GetListIndirizziByIdSoggetto(item.IdSoggetto);
                item.GruppiPariteticiAppartenenza = GetListGruppiPariteticiByidSoggetto(item.IdSoggetto);

                if (item.RegistroCooperativa != null)
                {
                    SetDocumentazioni(registries, "IdRegistro", GVCTDOCUMENTAZIONECollection.IDOBJ_REGISTROColumnName);
                    
                    item.RegistroCooperativa.Adesioni = GetAdesioniInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.ComunicazioniBaseSociale = GetListBaseSocByIdRegistro(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale = GetComCaricheSocInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.Revisioni = GetRevisioniInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.Assemblee = GetAssembleeInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.Notaio = GetSoggettoById(item.RegistroCooperativa.IdNotaio) as PersonaFisicaFDT;
                    item.RegistroCooperativa.CambioPosizioni = GetListCambiPosizioneByIdRegistroOrder(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.ProcedureCoatte = GetProcedureCoatteInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.LiquidazioniCoatte = GetLiquidazioniCoatteInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.ProcedureFallimentari = GetFallimentiInternal(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.ScadenzaAnnotazioni = Converters.ConvertAll(GVCDB.GVCTANNOTAZIONICollection.GetByIDOBJ_REGISTRO(item.RegistroCooperativa.IdRegistro));
                    item.RegistroCooperativa.Attivita = GetListAttivitaByIdRegistro(item.RegistroCooperativa.IdRegistro, false);
                    item.RegistroCooperativa.AttivitaParix = GetListAttivitaByIdRegistro(item.RegistroCooperativa.IdRegistro, true);
                    item.RegistroCooperativa.Procedimenti = Converters.ConvertAll(GVCDB.GVCTPROCEDIMENTICollection.GetByIDOBJ_REGISTRO(item.RegistroCooperativa.IdRegistro));
                    item.RegistroCooperativa.Bilanci = GetListBilanciIdRegistro(item.RegistroCooperativa.IdRegistro);
                    item.RegistroCooperativa.Sanzioni = GetListSanzioniIdRegistro(item.RegistroCooperativa.IdRegistro);

                    CancellazioneFDT[] listCancellazioni = Converters.ConvertAll(GVCDB.GVCTCANCELLAZIONICollection.GetByIDOBJ_REGISTRO(item.RegistroCooperativa.IdRegistro));
                    if (listCancellazioni != null && listCancellazioni.Length > 0)
                        item.RegistroCooperativa.Cancellazione = listCancellazioni[0];

                    item.RegistroCooperativa.Cartelle = GetCartelle();
                }
            }
        }

        public CooperativaRicercaFDT[] GetListActiveGvcCooperatives() 
        {
            CooperativaRicercaFDT[] toReturn = null;
            try
            {
                toReturn = Converters.ConvertAllActiveCoop(GVCDB.GVCVCOOPERATIVEATTIVECollection.GetAll());
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return toReturn;
        }

        public CooperativaRicercaFDT[] GetListClosedGvcCooperatives(DateTime closedAfterDt)
        {
            CooperativaRicercaFDT[] toReturn = null;
            try
            {
               // toReturn = Converters.ConvertAllClosedCoop(GVCDB.GVCVCOOPERATIVECESSATECollection.GetCooperativesClosedAfter(closedAfterDt));
                toReturn = Converters.ConvertAllClosedCoop(GVCDB.GVCVCOOPERATIVECESSATECollection.GetAll());
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return toReturn;
        }

        public CooperativaRicercaFDT[] GetListActiveParixCooperatives(out Boolean exception)
        {
            CooperativaRicercaFDT[] allActive = GetAllCooperativesParix(out exception);
            //Console.WriteLine("Cooperative \"attive\"");
            //for (int i = 0; i < allActive.Length; i++)
            //    Console.WriteLine(allActive[i].NumeroREA);

            if (allActive == null || allActive.Length == 0)
                return null;
            List<CooperativaRicercaFDT> onlyActive = new List<CooperativaRicercaFDT>();
            for (int i = 0; i < allActive.Length; i++)
                if (allActive[i].DataCancellazioneRIRegistro == null)
                    onlyActive.Add(allActive[i]);
            if (onlyActive.Count == 0)
                return null;
            return onlyActive.ToArray();
        }

        public CooperativaRicercaFDT[] GetListClosedParixCooperatives(DateTime closedAfterDt, out Boolean exception)
        {
            CooperativaRicercaFDT[] allClosed = GetAllCooperativesParix(out exception);
            
            if (allClosed == null || allClosed.Length == 0)
                return null;
            List<CooperativaRicercaFDT> closedAfter = new List<CooperativaRicercaFDT>();
            for (int i = 0; i < allClosed.Length; i++)
                if (allClosed[i].DataCancellazioneRIRegistro.HasValue && allClosed[i].DataCancellazioneRIRegistro.Value.CompareTo(closedAfterDt) >= 0)
                    closedAfter.Add(allClosed[i]);
            if (closedAfter.Count == 0)
                return null;
            return closedAfter.ToArray();
        }

        private AttivitaFDT[] GetListAttivitaByIdRegistro(int idRegistro, Boolean parix)
        {
            AttivitaFDT[] toReturn = null;
            try
            {
                toReturn = Converters.ConvertAll(GVCDB.GVCTATTIVITACollection.GetActivitiesByIdRegistro(idRegistro, parix));
            }
            catch (Exception ex)
            {
                
                throw;
            }

            return toReturn;
        }

        public AggiornamentoFDT GetAggiornamentoByNrRea(int nrRea)
        {
            AggiornamentoFDT toReturn = null;
            try
            {
                AggiornamentoFDT[] aggiornamenti = Converters.ConvertAll(GVCDB.GVC_PARIX_UPDCollection.GetAsArray("N_ISCRIZIONE_REA = " + nrRea, "DATAORA_AGGIORNAMENTO DESC"));
                if (aggiornamenti != null && aggiornamenti.Length > 0)
                {
                    toReturn = aggiornamenti[0];
                    toReturn.Cooperativa = GetCooperativaFromXml(toReturn.CooperativaByte);
                    toReturn.CooperativaByte = null;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return toReturn;
        }

        private CooperativaFDT GetCooperativaFromXml(byte[] xml) 
        {
            CooperativaFDT toReturn = null;
            try
            {
                System.Xml.Serialization.XmlRootAttribute rootAttribute= new System.Xml.Serialization.XmlRootAttribute("RISPOSTA");
                System.Xml.Serialization.XmlSerializer serializer =
                new System.Xml.Serialization.XmlSerializer(typeof(RISPOSTA), rootAttribute);
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                
                String prefix = "<?xml version=\"1.0\" encoding=\"utf-8\"?> "+
                                "<RISPOSTA xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"> "+
                                "<DATI xmlns=\"http://InfoTn/2007/AnagraficaImprese\">";

                String suffix = "</DATI> " +
                                "</RISPOSTA>";

                byte[] bytePrefix = encoding.GetBytes(prefix);
                byte[] byteSuffix = encoding.GetBytes(suffix);

                byte[] cocatenation = new byte[bytePrefix.Length + xml.Length + byteSuffix.Length];

                bytePrefix.CopyTo(cocatenation, 0);
                xml.CopyTo(cocatenation, bytePrefix.Length);
                byteSuffix.CopyTo(cocatenation, bytePrefix.Length + xml.Length);

                System.IO.MemoryStream ms = new System.IO.MemoryStream(cocatenation);
                ms.Position = 0;
                RISPOSTA ObjItems = (RISPOSTA)serializer.Deserialize(ms);
                
                CooperativaFDT[] cooperativa = it.dedagroup.GVC.Repository.etier.Services.ParixWrapper.Converters.ConvertResponseToCompleteCooperative(ObjItems);
                toReturn = cooperativa[0];
            }
            catch (Exception e) 
            {
                return null;
            }
            return toReturn;
        }

        /// <summary>
        /// Saves the cooperativa.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public string[] SaveCooperativa(CooperativaFDT item, Boolean forceSaving)
        {
            CooperativaFDT toReturn = null;
            List<string> messages = new List<string>();
            Boolean setNumeroScioglimento = false;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.RegistroCooperativa != null)
                    {
                        if (item.RegistroCooperativa.AggiornaNrScioglimento && 
                            !item.RegistroCooperativa.NumeroScioglimento.HasValue)
                        {
                            setNumeroScioglimento = true;
                        }
                    }

                    string taxCode = item.CodiceFiscale;
                    string reaNumber = string.Empty;

                    if (item.RegistroCooperativa != null)
                    {
                        reaNumber = item.RegistroCooperativa.NumeroREA;
                    }
                    if (item.IdSoggetto > 0)
                        forceSaving = true;

                    if (forceSaving || !AlreadyExistsTheCooperative(taxCode, reaNumber))
                    {
                        #region Salvataggi 

                        //Salva Soggetto
                        toReturn = SaveCooperativaInternal(item);

                        if (toReturn != null && toReturn.IdSoggetto > 0)
                        {
                            SaveListaIndirizziInternal(toReturn.IdSoggetto, item.Indirizzi);

                            //Salva Registro
                            if (item.RegistroCooperativa != null)
                            {
                                item.RegistroCooperativa.IdSoggetto = toReturn.IdSoggetto;

                                RegistroCooperativaFDT toReturnReg = null;

                                toReturnReg = SaveRegistroInternal(item.RegistroCooperativa);

                                toReturn.RegistroCooperativa = toReturnReg;

                                if (toReturnReg != null)
                                {
                                    //--Salva Documentazione
                                    if (item.RegistroCooperativa.Documentazioni != null && item.RegistroCooperativa.Documentazioni.Length > 0)
                                    {
                                        foreach (DocumentazioneFDT doc in item.RegistroCooperativa.Documentazioni)
                                        {
                                            doc.IdPadre = toReturnReg.IdRegistro;
                                        }
                                        SaveListDocumentazione(item.RegistroCooperativa.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_REGISTROColumnName);
                                    }

                                    //--Salva Adesioni
                                    SaveListaAdesioniInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Adesioni);
                                    //--Salva cominicazioni base soc (+ doc)
                                    SaveListaBaseSocInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.ComunicazioniBaseSociale);
                                    //--Salva comunicazioni cariche (+ cariche + doc)
                                    SaveListaComCaricaInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale);
                                    //--Salva revisioni (+ incarichi + compensi + liquidazioni + doc)
                                    SaveListaRevisioniInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Revisioni);
                                    //--Salva assemblee (+ modifiche stat + atti integrativi + doc)
                                    SaveListaAssembleeInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Assemblee);
                                    //--Salva cambi posizione
                                    SaveListaCambiPosizioneInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.CambioPosizioni);
                                    //--Salva procedure coatta (+ compensi + liquidazioni + doc)
                                    SaveListaProcedureCoattaInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.ProcedureCoatte);
                                    //--Salva liquidazioni coatta (+.... + doc)
                                    SaveListaLiquidazioniCoattaInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.LiquidazioniCoatte);
                                    //--Salva attività
                                    SaveListaAttivitaInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Attivita);
                                    SaveListaAttivitaInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.AttivitaParix);
                                    //--Fallimenti (+ doc)
                                    SaveListaFallimentiInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.ProcedureFallimentari);
                                    //--Procedimenti
                                    SaveListaProcedimentiInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Procedimenti);
                                    //--Bilanci (+ doc)
                                    SaveListaBilanciInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Bilanci);
                                    //--Scadenze/Annotazioni
                                    SaveListaAnnotazioniInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.ScadenzaAnnotazioni);
                                    //--Sanzioni amministrative
                                    SaveListaSanzioniInternal(toReturnReg.IdRegistro, item.RegistroCooperativa.Sanzioni);
                                    //--Salva segnalazioni parix
                                    SaveListaSegnalazioniInternal(item.SegnalazioniApplied);
                                    //--Salva cancellazione
                                    if (item.RegistroCooperativa.Cancellazione != null)
                                    {
                                        item.RegistroCooperativa.Cancellazione.IdRegistroCooperativa = toReturnReg.IdRegistro;
                                        SaveCancellazioneInternal(item.RegistroCooperativa.Cancellazione);
                                    }
                                }
                            }
                        }

                        #endregion Salvataggi
                    }
                    else
                    {
                        string one = (!String.IsNullOrEmpty(taxCode)) ? string.Concat("codice fiscale \"", taxCode, "\"") : string.Empty; ;
                        string two = (!String.IsNullOrEmpty(reaNumber)) ? string.Concat("numero REA \"", reaNumber, "\"") : string.Empty; ;

                        messages.Add(MessageIdentifications.COOP_ALREADY_PRESENT);
                        messages.Add(string.Concat("Esiste già una cooperativa salvata identificata con gli stessi dati : ", Environment.NewLine, one, Environment.NewLine, two));
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            if (toReturn != null)
            {
                messages.Add(MessageIdentifications.ID_SOGGETTO);
                messages.Add(toReturn.IdSoggetto.ToString());

                if (toReturn.RegistroCooperativa != null)
                {
                    messages.Add(MessageIdentifications.ID_REGISTRO);
                    messages.Add(toReturn.RegistroCooperativa.IdRegistro.ToString());

                    if (setNumeroScioglimento && toReturn.RegistroCooperativa.NumeroScioglimento.HasValue)
                    {
                        messages.Add(MessageIdentifications.NUMERO_SCIOGLIMENTO);
                        messages.Add(toReturn.RegistroCooperativa.NumeroScioglimento.Value.ToString());
                    }
                }
            }

            return messages.ToArray();
        }

        private Boolean SaveListaAttivitaInternal(int idRegistro, AttivitaFDT[] items)
        {
            Boolean toReturn = true;

            if (items != null)
            {
                foreach (AttivitaFDT item in items)
                {
                    if (item.Status == ObjectStatus.ToInsert ||
                        item.Status == ObjectStatus.ToUpdate)
                    {
                        item.IdRegistro = idRegistro;
                        SaveAttivitaInternal(item);
                    }
                    else if (item.Status >= ObjectStatus.ToHide &&
                             item.IdAttivita > 0)
                    {
                        toReturn = DeleteAttivita(item);
                    }
                }
            }

            return toReturn;
            //Boolean toReturn = true;

            //if (items != null)
            //{
            //    foreach (AttivitaFDT item in items)
            //    {
            //        if (item != null)
            //        {
            //            item.IdRegistro = idRegistro;
            //            toReturn = SaveAttivitaInternal(item);
            //        }
            //    }
            //}

            //return toReturn;
        }

        private AttivitaFDT SaveAttivitaInternal(AttivitaFDT item)
        {
            AttivitaFDT toReturn = null;

            if (item != null)
            {
                GVCTATTIVITA itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdAttivita > 0)
                {
                    if (GVCDB.GVCTATTIVITACollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTATTIVITACollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;

            //Boolean toReturn = true;

            //try
            //{
            //    if (item != null)
            //    {
            //        if (item.Status == ObjectStatus.ToView)
            //            return toReturn;

            //        if (item.Status >= ObjectStatus.ToHide)
            //        {
            //            toReturn = DeleteAttivita(item);
            //        }
            //        else
            //        {
            //            GVCTATTIVITA itemConverted = Converters.Convert(item);

            //            itemConverted.OPERATOREULTMOD = CallerIdentity;
            //            itemConverted.DATAORAULTMOD = DateTime.Now;

            //            if (item.IdAttivita <= 0)
            //            {
            //                GVCDB.GVCTATTIVITACollection.Insert(itemConverted);
            //                if (itemConverted.IDOBJ > 0)
            //                {
            //                    item = Converters.Convert(itemConverted);
            //                }
            //                else
            //                {
            //                    toReturn = false;
            //                }
            //            }
            //            else
            //            {
            //                if (!GVCDB.GVCTATTIVITACollection.Update(itemConverted))
            //                {
            //                    toReturn = false;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log(ex.Message, LoggingCategories.Trace);
            //    throw;
            //}

            //return toReturn;
        }

        private Boolean DeleteAttivita(AttivitaFDT item)
        {
            Boolean toReturn = true;

            try
            {
                if (item != null)
                {
                    if (item.IdAttivita > 0)
                    {
                        GVCTATTIVITA temp = new GVCTATTIVITA();
                        temp.IDOBJ = item.IdAttivita;
                        toReturn = GVCDB.GVCTATTIVITACollection.Delete(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the cooperativa internal.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        internal CooperativaFDT SaveCooperativaInternal(CooperativaFDT item)
        {
            CooperativaFDT toReturn = null;

            try
            {
                if (item != null)
                {
                    if (item.IdTipoSoggetto <= 0)
                        item.IdTipoSoggetto = 2;

                    GVCTSOGGETTI itemConverted = Converters.Convert(item);

                    itemConverted.OPERATOREULTMOD = CallerIdentity;
                    itemConverted.DATAORAULTMOD = DateTime.Now;

                    if (item.IdSoggetto > 0)
                    {
                        if (GVCDB.GVCTSOGGETTICollection.Update(itemConverted))
                        {
                            // update success
                            toReturn = item;
                        }
                        else
                        {
                            //update no success
                        }
                    }
                    else
                    {
                        // perform new insert

                        GVCDB.GVCTSOGGETTICollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ > 0)
                        {
                            toReturn = Converters.ConvertIntoCooperative(itemConverted);
                        }
                        else
                        {
                            // insert no success
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Searches cooperative in parix.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="fiscalCode">The fiscal code.</param>
        /// <param name="nrRea">R.E.A number.</param>
        /// <returns></returns>
        public CooperativaFDT[] SearchCooperativaParix(String name, String fiscalCode, String nrRea, bool includeCeased, out Boolean exception)
        {
            try
            {
                ParixProxy parixProxy = new ParixProxy();
                exception = false;
               
                if (!String.IsNullOrEmpty(nrRea))
                    return parixProxy.GetCompleteCooperatives(nrRea);
                if (!String.IsNullOrEmpty(fiscalCode))
                    return parixProxy.GetCooperativesTaxCode(fiscalCode);
                if (!String.IsNullOrEmpty(name))
                {
                    if (includeCeased)
                        return parixProxy.GetCooperativesByName(name);
                    else
                        return parixProxy.GetNotCeasedCooperativesByName(name);

                }
                
                return null;
            }
            catch (Exception ex) {
                Log(ex.Message, LoggingCategories.General);
                exception = true;
                return null;
            }
            
        }

        private CooperativaRicercaFDT[] GetAllCooperativesParix(out Boolean exception)
        {
            String[] formeGiuridiche = null;
            try
            {
                GVCDFORME_GIURIDICHE_PARIX[] allForme = GVCDB.GVCDFORME_GIURIDICHE_PARIXCollection.GetAll();
                if (allForme != null) 
                { 
                    formeGiuridiche = new String[allForme.Length];
                    for (int i = 0; i < allForme.Length; i++)
                        formeGiuridiche[i] = allForme[i].CODICE;
                }

            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.General);
                throw;
            }

            try
            {
                ParixProxy parixProxy = new ParixProxy();
                exception = false;

                return Converters.ConvertAllParixCoops( parixProxy.GetAllCooperatives(formeGiuridiche));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.General);
                exception = true;
                return null;
            }
        }


        public ComunicazioneCaricaSocialeFDT[] GetCaricheSocialiFromParix(String nrRea, String province, out Boolean exception)
        {
            try
            {
                ParixProxy parixProxy = new ParixProxy();
                exception = false;
                if (!nrRea.Equals("") && !province.Equals(""))
                    return parixProxy.GetPersons(nrRea, province);
                return null;
            }catch(Exception ex)
            {
                Log(ex.Message, LoggingCategories.General);
                exception = true;
                return null;
            }
        }

        public SoggettoPerVisualizzazioneFDT[] GetListCooperativeBySearch(OeF.Utility.Expression query)
        {
            SoggettoPerVisualizzazioneFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.NOME, 
                                               SearchParameters.COGNOME,
                                               SearchParameters.CODICE_FISCALE,
                                               SearchParameters.DENOMINAZIONE, 
                                               SearchParameters.DATA_NASCITA,
                                               SearchParameters.LUOGO_NASCITA,
                                               SearchParameters.ID_SOGGETTO, 
                                               SearchParameters.ID_TIPO_SOGGETTO,
                                               SearchParameters.ASSOCIAZIONE,
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.CODICE_COOPERATIVA};

                string[] values = new string[] { GVCVRICERCASOGGETTICollection.R_NOMEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_COGNOMEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_CODICE_FISCALEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_DENOMINAZIONEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_DATA_NASCITAColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_LUOGO_NASCITAColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_ID_SOGGETTOColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_ID_TIPO_SOGGETTOColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_ASSOCIAZIONEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_CODICE_COOPERATIVAColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                toReturn = Converters.ConvertAllResults(
                        GVCDB.GVCVRICERCASOGGETTICollection.GetBySearchParameters(
                             where
                        ));

            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetListCooperativeBySearchAdvanced(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.FORMA_GIURIDICA, 
                                               SearchParameters.STATO_ISCRIZIONE,
                                               SearchParameters.CODICE_FISCALE,
                                               SearchParameters.DENOMINAZIONE, 
                                               SearchParameters.CADENZA_REV,
                                               SearchParameters.ESENTE_VERSAM_UTILI,
                                               SearchParameters.FLAG_GRUPPO,
                                               SearchParameters.DATA_COSTITUZIONE, 
                                               SearchParameters.TIPO_COSTITUZIONE,
                                               SearchParameters.COD_OPERATORE,
                                               SearchParameters.COD_UFF,
                                               SearchParameters.DATA_BILANCIO,
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.CODICE_COOPERATIVA,
                                               SearchParameters.ATTIVITA,
                                               SearchParameters.ATT_FLAG_CCIAA,
                                               SearchParameters.INDIRIZZO_SEDE};

                string[] values = new string[] { GVCVRICERCACOOPAVANZATACollection.R_IDOBJ_FORMA_GIURIDICAColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_IDOBJ_STATOColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.S_CODICE_FISCALEColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.S_DENOMINAZIONEColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_IDOBJ_CADENZA_REVISIONEColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_ESENTE_VERSAMENTO_UTILIColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_GRUPPO_PARITETICOColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_DATA_COSTITUZIONEColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_IDOBJ_TIPO_COSTITUZIONEColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_CODICE_OPERATOREColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_CODICE_UFFICIOColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_BILANCIO_ESERCIZIO_ALColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.R_IDOBJColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.ATT_IDOBJ_TPIO_ATTColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.ATT_FLAG_CCIAAColumnName,
                                                 GVCVRICERCACOOPAVANZATACollection.IND_COMUNEColumnName};

                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCACOOPAVANZATA[] listaRisultati = GVCDB.GVCVRICERCACOOPAVANZATACollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                      indexIscrizione > 0 ||
                     (idCategoria.Length > 0 || idSezione > 0 || idSottoCatSoc > 0 || idCategoriaSoc > 0))
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc);
                }
                toReturn = Converters.ConvertAllIntoCoopAvanzata(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public DataSet GetCooperativeDaEsportare(int[] arrayOfId)
        {
            DataSet toReturn = null;

            try
            {
                toReturn = GVCDB.ExportCooperative.GetDataToExport(arrayOfId);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public DataSet GetCooperativeStatistica(DateTime dataDal, DateTime dataAl, bool soloAttivi)
        {
            DataSet toReturn = null;

            try
            {
                if (dataAl > DateTime.MinValue)
                {
                    toReturn = GVCDB.StatisticsCooperative.GetDataStatistics(dataDal, dataAl, soloAttivi);
                }
                else
                {
                    toReturn = GVCDB.StatisticsCooperative.GetDataStatistics(dataDal, soloAttivi);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }       

        #endregion Cooperativa

        #region Registro

        internal RegistroCooperativaFDT SaveRegistroInternal(RegistroCooperativaFDT item)
        {
            RegistroCooperativaFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.Notaio, item.IdNotaio);
                if (idSoggettoFK > 0)
                    item.IdNotaio = idSoggettoFK;
                #endregion Salvataggio del soggetto contenuto nell'oggetto

                //Salvataggio del numero di scioglimento
                if (item.AggiornaNrScioglimento && !item.NumeroScioglimento.HasValue)
                {
                    int nrScioglimento = SaveNrScioglimentoInternal();
                    if (nrScioglimento > 0)
                        item.NumeroScioglimento = nrScioglimento;
                }

                GVCTREGISTRI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdRegistro > 0)
                {
                    if (GVCDB.GVCTREGISTRICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    } 
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTREGISTRICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        #endregion Registro
         
        #region Soggetto

        internal GVCTSOGGETTI GetSoggettoByID(int IdSoggetto)
        {
            //Converters.Convert(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(IdSoggetto));
            return GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(IdSoggetto);
        }

        public SoggettoFDT GetSoggettoById(int idSoggetto)
        {
            SoggettoFDT toReturn = null;

            try
            {
                toReturn = Converters.Convert(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(idSoggetto));

                GetSoggettoDataExtended(toReturn);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        private void GetSoggettoDataExtended(SoggettoFDT toReturn)
        {
            if (toReturn != null)
            {
                toReturn.Indirizzi = GetListIndirizziByIdSoggetto(toReturn.IdSoggetto);
            }
        }

        public SoggettoPerVisualizzazioneFDT[] GetSoggettoBySearch(OeF.Utility.Expression query)
        {
            SoggettoPerVisualizzazioneFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.NOME, 
                                               SearchParameters.COGNOME,
                                               SearchParameters.CODICE_FISCALE,
                                               SearchParameters.DENOMINAZIONE, 
                                               SearchParameters.DATA_NASCITA,
                                               SearchParameters.LUOGO_NASCITA,
                                               SearchParameters.ID_SOGGETTO, 
                                               SearchParameters.ID_TIPO_SOGGETTO,
                                               SearchParameters.ASSOCIAZIONE,
                                               SearchParameters.CODICE_COOPERATIVA};

                string[] values = new string[] { GVCVRICERCASOGGETTICollection.R_NOMEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_COGNOMEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_CODICE_FISCALEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_DENOMINAZIONEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_DATA_NASCITAColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_LUOGO_NASCITAColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_ID_SOGGETTOColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_ID_TIPO_SOGGETTOColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_ASSOCIAZIONEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_CODICE_COOPERATIVAColumnName};

                
                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                toReturn = Converters.ConvertAllResults(
                        GVCDB.GVCVRICERCASOGGETTICollection.GetBySearchParameters(
                             where
                        ));

                //if (toReturn != null)
                //{
                //    foreach (SoggettoFDT item in toReturn)
                //    {
                //        GetSoggettoDataExtended(item);
                //    }
                //}
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public DataSet GetSoggettiDaEsportare(int[] arrayOfIdSoggetti)
        {
            DataSet toReturn = null;

            try
            { 
                toReturn = GVCDB.ExportSoggetti.GetDataToExport(arrayOfIdSoggetti);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public SoggettoFDT SaveSoggetto(SoggettoFDT item)
        {
            SoggettoFDT toReturn = null;
            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveSoggettoInternal(item);

                if (toReturn != null)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }


            return toReturn;
        }

        private SoggettoFDT SaveSoggettoInternal(SoggettoFDT item)
        {
            SoggettoFDT toReturn = null;

            if (item != null)
            {
                GVCTSOGGETTI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdSoggetto > 0)
                {
                    if (GVCDB.GVCTSOGGETTICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTSOGGETTICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }

                if (toReturn != null)
                {
                    if (!SaveListaIndirizziInternal(toReturn.IdSoggetto, item.Indirizzi))
                    {
                        toReturn = null;
                    }
                }
            }
            return toReturn;
        }

        private int SaveSoggettoConditional(SoggettoFDT item, int idSoggetto)
        {
            int toReturn = -1;

            if (idSoggetto > 0)
            {
                toReturn = idSoggetto;
            }
            else
            {
                if (item != null)
                {
                    if (item.CodiceFiscale != null && !item.CodiceFiscale.Equals(string.Empty))
                    {
                        GVCTSOGGETTI[] subjs = GVCDB.GVCTSOGGETTICollection.GetByCodiceFiscale(item.CodiceFiscale);
                        if (subjs != null && subjs.Length > 0)
                        {
                            toReturn = subjs[0].IDOBJ;
                        }
                        else
                        {
                            SoggettoFDT saved = SaveSoggettoInternal(item);
                            if (saved != null)
                            {
                                toReturn = saved.IdSoggetto;
                            }
                        }
                    }
                    else
                    {
                        //Salva anche senza il codice fiscale
                        SoggettoFDT saved = SaveSoggettoInternal(item);
                        if (saved != null)
                        {
                            toReturn = saved.IdSoggetto;
                        }
                    }
                }
            }

            return toReturn;
        }

        public string[] DeleteSubject(int idSoggetto)
        {
            List<string> toReturn = new List<string>();

            Boolean outcome = false;
            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (idSoggetto > 0)
                {
                    #region CARICHE
                    GVCRCARICHE[] cariche = GVCDB.GVCRCARICHECollection.GetByIDOBJ_SOGGETTO(idSoggetto);
                    if (cariche != null && cariche.Length > 0)
                    {
                        string q = string.Empty;
                        foreach (GVCRCARICHE item in cariche)
                        {
                            if (item.IDOBJ_SOGGETTOSafe > 0)
                            {
                            if (!String.IsNullOrEmpty(q))
                                q = string.Format("{0}, {1}", q, item.IDOBJ_SOGGETTOSafe);
                            else
                                q = string.Format("{0}", item.IDOBJ_SOGGETTOSafe);
                            }
                        }
                        string where = string.Format("{0} IN ({1})", GVCTREGISTRICollection.IDOBJColumnName, q);

                        string r = string.Empty;
                        GVCTREGISTRI[] rs = GVCDB.GVCTREGISTRICollection.GetAsArray(where, string.Empty);
                        if (rs != null && rs.Length > 0)
                        {
                            SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                            foreach (GVCTREGISTRI item in rs)
                            {
                                if (!corrs.ContainsKey(item.IDOBJ))
                                    corrs.Add(item.IDOBJ, string.Empty);
                            }
                            foreach (int key in corrs.Keys)
                            {
                                if (!String.IsNullOrEmpty(r))
                                    r = string.Format("{0}, {1}", r, key);
                                else
                                    r = string.Format("{0}", key);
                            }
                        }

                        toReturn.Add(string.Format("carica sociale in cooperativa {0}", r));
                    }
                    #endregion CARICHE

                    #region SOCIETA COLLEGATE
                    GVCRSOCIETA_COLLEGATE[] societaColl = GVCDB.GVCRSOCIETA_COLLEGATECollection.GetByIDOBJ_SOGGETTO(idSoggetto);
                    if (societaColl != null && societaColl.Length > 0)
                    {
                        //string r = string.Empty;
                        //foreach (GVCRSOCIETA_COLLEGATE item in societaColl)
                        //{
                        //    if (!String.IsNullOrEmpty(r))
                        //        r = string.Format("{0}, {1}", r, item.IDOBJ_REGISTRO);
                        //    else
                        //        r = string.Format("{0}", item.IDOBJ_REGISTRO);
                        //}
                        toReturn.Add("Società collegata tramite fusione / scissione");
                    }
                    #endregion SOCIETA COLLEGATE

                    #region ADESIONI
                    GVCTADESIONI[] adesioni = GVCDB.GVCTADESIONICollection.GetByIDOBJ_ASSOCIAZIONE(idSoggetto);
                    if (adesioni != null && adesioni.Length > 0)
                    {
                        string r = string.Empty;
                        SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                        foreach (GVCTADESIONI item in adesioni)
                        {
                            if (!corrs.ContainsKey(item.IDOBJ_REGISTRO))
                                corrs.Add(item.IDOBJ_REGISTRO, string.Empty);
                        }
                        foreach (int key in corrs.Keys)
                        {
                            if (!String.IsNullOrEmpty(r))
                                r = string.Format("{0}, {1}", r, key);
                            else
                                r = string.Format("{0}", key);
                        }

                        toReturn.Add(string.Format("associazione di rappresenzanta nelle adesioni in cooperativa {0}", r));
                    }
                    #endregion ADESIONI

                    #region COMPENSI
                    GVCTCOMPENSI[] compensi = GVCDB.GVCTCOMPENSICollection.GetByIDOBJ_SOGGETTO(idSoggetto);
                    if (compensi != null && compensi.Length > 0)
                    {
                        //string r = string.Empty;
                        //foreach (GVCTCOMPENSI item in compensi)
                        //{
                        //    if (!String.IsNullOrEmpty(r))
                        //        r = string.Format("{0}, {1}", r, item.IDOBJ_REGISTRO);
                        //    else
                        //        r = string.Format("{0}", item.IDOBJ_REGISTRO);
                        //}
                        toReturn.Add("commissario con compenso");
                    }
                    #endregion COMPENSI

                    #region DELIBERE ASSEMBLEA
                    GVCTDELIBERE_ASSEMBLEA[] delibere = GVCDB.GVCTDELIBERE_ASSEMBLEACollection.GetByIDOBJ_NOTAIO(idSoggetto);
                    if (delibere != null && delibere.Length > 0)
                    {
                        string r = string.Empty;
                        SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                        foreach (GVCTDELIBERE_ASSEMBLEA item in delibere)
                        {
                            if (!corrs.ContainsKey(item.IDOBJ_REGISTRO))
                                corrs.Add(item.IDOBJ_REGISTRO, string.Empty);
                        }
                        foreach (int key in corrs.Keys)
                        {
                            if (!String.IsNullOrEmpty(r))
                                r = string.Format("{0}, {1}", r, key);
                            else
                                r = string.Format("{0}", key);
                        }

                        toReturn.Add(string.Format("notaio nelle delibere delle assemblee in cooperativa {0}", r));
                    }
                    #endregion DELIBERE ASSEMBLEA

                    #region FALLIMENTI
                    GVCTFALLIMENTI[] fallimenti = GVCDB.GVCTFALLIMENTICollection.GetByIDOBJ_CURATORE(idSoggetto);
                    if (fallimenti != null && fallimenti.Length > 0)
                    {
                        string r = string.Empty;
                        SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                        foreach (GVCTFALLIMENTI item in fallimenti)
                        {
                            if (!corrs.ContainsKey(item.IDOBJ_REGISTRO))
                                corrs.Add(item.IDOBJ_REGISTRO, string.Empty);
                        }
                        foreach (int key in corrs.Keys)
                        {
                            if (!String.IsNullOrEmpty(r))
                                r = string.Format("{0}, {1}", r, key);
                            else
                                r = string.Format("{0}", key);
                        }

                        toReturn.Add(string.Format("come curatore fallimentare in cooperativa {0}", r));
                    }
                    #endregion FALLIMENTI

                    #region MODIFICHE STATUTARIE
                    GVCTMODIFICHE_STATUTARIE[] modifiche = GVCDB.GVCTMODIFICHE_STATUTARIECollection.GetByIDOBJ_NOTAIO(idSoggetto);
                    if (modifiche != null && modifiche.Length > 0)
                    {
                        toReturn.Add("notaio nelle modifiche statutarie");
                    }
                    #endregion MODIFICHE STATUTARIE

                    #region REGISTRI
                    GVCTREGISTRI[] registro = GVCDB.GVCTREGISTRICollection.GetByIDOBJ_NOTAIO(idSoggetto);
                    if (registro != null && registro.Length > 0)
                    {
                        string r = string.Empty;
                        SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                        foreach (GVCTREGISTRI item in registro)
                        {
                            if (!corrs.ContainsKey(item.IDOBJ))
                                corrs.Add(item.IDOBJ, string.Empty);
                        }
                        foreach (int key in corrs.Keys)
                        {
                            if (!String.IsNullOrEmpty(r))
                                r = string.Format("{0}, {1}", r, key);
                            else
                                r = string.Format("{0}", key);
                        }

                        toReturn.Add(string.Format("notaio dell'atto costitutivo in cooperativa {0}", r));
                    }
                    #endregion REGISTRI

                    #region REGISTRI idSogg
                    GVCTREGISTRI[] registroN = GVCDB.GVCTREGISTRICollection.GetByIDOBJ_SOGGETTO(idSoggetto);
                    if (registroN != null && registroN.Length > 0)
                    {
                        string r = string.Empty;
                        SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                        foreach (GVCTREGISTRI item in registroN)
                        {
                            if (!corrs.ContainsKey(item.IDOBJ))
                                corrs.Add(item.IDOBJ, string.Empty);
                        }
                        foreach (int key in corrs.Keys)
                        {
                            if (!String.IsNullOrEmpty(r))
                                r = string.Format("{0}, {1}", r, key);
                            else
                                r = string.Format("{0}", key);
                        }

                        toReturn.Add(string.Format("è la cooperativa {0}", r));
                    }
                    #endregion REGISTRI idSogg

                    #region REVISIONI
                    GVCTREVISIONI[] revisioni = GVCDB.GVCTREVISIONICollection.GetByIDOBJ_ORGANO_REVISORE(idSoggetto);
                    if (revisioni != null && revisioni.Length > 0)
                    {
                        string r = string.Empty;
                        SortedDictionary<int, string> corrs = new SortedDictionary<int, string>();
                        foreach (GVCTREVISIONI item in revisioni)
                        {
                            if (!corrs.ContainsKey(item.IDOBJ_REGISTRO))
                                corrs.Add(item.IDOBJ_REGISTRO, string.Empty);
                        }
                        foreach (int key in corrs.Keys)
                        {
                            if (!String.IsNullOrEmpty(r))
                                r = string.Format("{0}, {1}", r, key);
                            else
                                r = string.Format("{0}", key);
                        }

                        toReturn.Add(string.Format("organo revisore nelle revisioni in cooperativa {0}", r));
                    }
                    #endregion REVISIONI
                    
                    // INDIRIZZI
                    // REGISTRO


                    if (toReturn.Count == 0)
                    {
                        outcome = GVCDB.GVCTSOGGETTICollection.DeleteByPrimaryKey(idSoggetto);
                    }
                }

                if (outcome)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn.ToArray();
        }

        #endregion Soggetto
         
        #region Cambi posizione

        /// <summary>
        /// Gets the cambio posizione by id.
        /// </summary>
        /// <param name="idCambioPosizione">The id cambio posizione.</param>
        /// <returns></returns>
        public CambioPosizioneFDT GetCambioPosizioneById(int idCambioPosizione)
        {
            CambioPosizioneFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCTCAMBI_POSIZIONECollection.GetByPrimaryKey(idCambioPosizione));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list cambi posizione by id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public CambioPosizioneFDT[] GetListCambiPosizioneByIdRegistro(int idRegistro)
        {
            CambioPosizioneFDT[] toReturn = null;
            try
            {
                toReturn =
                    Converters.ConvertAll(GVCDB.GVCTCAMBI_POSIZIONECollection.GetByIDOBJ_REGISTRO(idRegistro));
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal CambioPosizioneFDT[] GetListCambiPosizioneByIdRegistroOrder(int idRegistro)
        {
            return Converters.ConvertAll(GVCDB.GVCTCAMBI_POSIZIONECollection.GetListCambiPosizioneByIdRegistroOrder(idRegistro));
            //GVCTCAMBI_POSIZIONE[] itemDB = GVCDB.GVCTCAMBI_POSIZIONECollection.GetByIDOBJ_REGISTRO(idRegistro);
            //return Converters.ConvertAll(itemDB);
        }

        internal Boolean SaveListaCambiPosizioneInternal(int idRegistro, CambioPosizioneFDT[] items)
        {
            if (items != null)
            {
                foreach (CambioPosizioneFDT cambioPos in items)
                {
                    if (cambioPos.Status == ObjectStatus.ToInsert ||
                        cambioPos.Status == ObjectStatus.ToUpdate)
                    {
                        cambioPos.IdRegistro = idRegistro;
                        SaveCambioPosizioneInternal(cambioPos);
                    }
                    else if (cambioPos.Status >= ObjectStatus.ToHide &&
                        cambioPos.IdCambioPosizione > 0)
                    {
                        DeleteCambioPosizione(cambioPos);
                    }

                }
            }

            return true;
        }

        internal CambioPosizioneFDT SaveCambioPosizioneInternal(CambioPosizioneFDT item)
        {
            CambioPosizioneFDT toReturn = null;

            if (item != null)
            {
                GVCTCAMBI_POSIZIONE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdCambioPosizione > 0)
                {
                    if (GVCDB.GVCTCAMBI_POSIZIONECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTCAMBI_POSIZIONECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the indirizzo.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public CambioPosizioneFDT SaveCambioPosizione(CambioPosizioneFDT item)
        {
            CambioPosizioneFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveCambioPosizioneInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the cambio posizione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteCambioPosizione(CambioPosizioneFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdCambioPosizione > 0)
                {
                    GVCTCAMBI_POSIZIONE cpTmp = new GVCTCAMBI_POSIZIONE();
                    cpTmp.IDOBJ = item.IdCambioPosizione;

                    toReturn = GVCDB.GVCTCAMBI_POSIZIONECollection.Delete(cpTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Cambi posizione

        #region Cancellazione

        public CancellazioneFDT GetCancellazioneById(int idCancellazione)
        {
            CancellazioneFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTCANCELLAZIONICollection.GetByPrimaryKey(idCancellazione));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }


        public CancellazioneFDT GetCancellazioneByIdRegistro(int idRegistro)
        {
            CancellazioneFDT toReturn = null;
            try
            {
                CancellazioneFDT[] lTemp = 
                    Converters.ConvertAll(GVCDB.GVCTCANCELLAZIONICollection.GetByIDOBJ_REGISTRO(idRegistro));
                if (lTemp != null && lTemp.Length > 0)
                {
                    toReturn = lTemp[0];
                }
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal CancellazioneFDT SaveCancellazioneInternal(CancellazioneFDT item)
        {
            CancellazioneFDT toReturn = null;

            if (item != null)
            {
                if (item.Status == ObjectStatus.ToView)
                    return item;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    DeleteCancellazione(item);
                }
                else
                {
                    GVCTCANCELLAZIONI itemConverted = Converters.Convert(item);

                    itemConverted.DATAORAULTMOD = DateTime.Now;
                    itemConverted.OPERATOREULTMOD = CallerIdentity;

                    if (item.IdCancellazione > 0)
                    {
                        if (GVCDB.GVCTCANCELLAZIONICollection.Update(itemConverted))
                        {
                            // update success
                            toReturn = item;
                        }
                        else
                        {
                            //update no success
                        }
                    }
                    else
                    {
                        // perform new insert

                        GVCDB.GVCTCANCELLAZIONICollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ > 0)
                        {
                            // insert success
                            toReturn = Converters.Convert(itemConverted);
                        }
                        else
                        {
                            // insert no success
                        }
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the indirizzo.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public CancellazioneFDT SaveCancellazione(CancellazioneFDT item)
        {
            CancellazioneFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveCancellazioneInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the cancellazione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteCancellazione(CancellazioneFDT item)
        {
           Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

            if (item != null && item.IdCancellazione > 0)
            {
                GVCTCANCELLAZIONI cancTmp = new GVCTCANCELLAZIONI();
                cancTmp.IDOBJ = item.IdCancellazione;

                toReturn = GVCDB.GVCTCANCELLAZIONICollection.Delete(cancTmp);
            }

            if (toReturn)
            {
                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            else
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }
            }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Cancellazione

        #region Indirizzi

        /// <summary>
        /// Gets the indirizzo by id.
        /// </summary>
        /// <param name="idIndirizzo">The id indirizzo.</param>
        /// <returns></returns>
        public IndirizzoFDT GetIndirizzoById(int idIndirizzo)
        {
            IndirizzoFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTINDIRIZZICollection.GetByPrimaryKey(idIndirizzo));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list indirizzi by id soggetto.
        /// </summary>
        /// <param name="idSoggetto">The id soggetto.</param>
        /// <returns></returns>
        public IndirizzoFDT[] GetListIndirizziByIdSoggetto(int idSoggetto)
        {
            IndirizzoFDT[] toReturn = null;
            try
            {
                toReturn = 
                    Converters.ConvertAll(GVCDB.GVCTINDIRIZZICollection.GetByIDOBJ_SOGGETTO(idSoggetto));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        internal IndirizzoFDT SaveIndirizzoInternal(IndirizzoFDT item)
        {
            IndirizzoFDT toReturn = null;

            if (item != null)
            {
                if (item.Status == ObjectStatus.ToView)
                    return item;

                if (item.Status >= ObjectStatus.ToHide)
                {
                    DeleteIndirizzo(item);
                }
                else
                {
                    GVCTINDIRIZZI itemConverted = Converters.Convert(item);

                    itemConverted.OPERATOREULTMOD = CallerIdentity;
                    itemConverted.DATAORAULTMOD = DateTime.Now;

                    if (item.IdIndirizzo > 0)
                    {
                        if (GVCDB.GVCTINDIRIZZICollection.Update(itemConverted))
                        {
                            // update success
                            toReturn = item;
                        }
                        else
                        {
                            //update no success
                        }
                    }
                    else
                    {
                        // perform new insert

                        GVCDB.GVCTINDIRIZZICollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ > 0)
                        {
                            // insert success
                            item = Converters.Convert(itemConverted);
                            toReturn = item;
                        }
                        else
                        {
                            // insert no success
                        }
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the indirizzo.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public IndirizzoFDT SaveIndirizzo(IndirizzoFDT item)
        {
            IndirizzoFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveIndirizzoInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public Boolean DeleteIndirizzo(IndirizzoFDT item)
        {
            Boolean toReturn = true;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdIndirizzo > 0)
                {
                    GVCTINDIRIZZI indTmp = new GVCTINDIRIZZI();
                    indTmp.IDOBJ = item.IdIndirizzo;

                    toReturn = GVCDB.GVCTINDIRIZZICollection.Delete(indTmp);
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        internal Boolean SaveListaIndirizziInternal(int idSoggetto, IndirizzoFDT[] items)
        {
            Boolean toReturn = true;

            if (items != null)
            {
                IndirizzoFDT indTemp = null;
                foreach (IndirizzoFDT item in items)
                {
                    if (item != null)
                    {
                        item.IdSoggetto = idSoggetto;

                        indTemp = null;
                        indTemp = SaveIndirizzoInternal(item);
                        if (indTemp == null)
                        {
                            toReturn = false;
                            break;
                        }
                    }
                }
            }

            return toReturn;
        }

        #endregion Indirizzi

        #region Modifiche Statutarie

        public ModificaStatutariaFDT[] GetListModificheStatutarieByIdDeliberaAssemblea(int idAssemblea)
        {
            ModificaStatutariaFDT[] toReturn = null;

            try
            {
                toReturn = GetModificheStatutarieInternal(idAssemblea);
            }
            catch
            {
            }

            return toReturn;
        }

        public ModificaStatutariaFDT GetModificaStatutariaById(int idModificaStatutaria)
        {
            ModificaStatutariaFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCTMODIFICHE_STATUTARIECollection.GetByPrimaryKey(idModificaStatutaria));

                if (toReturn != null)
                {
                    toReturn.Notaio = Converters.ConvertIntoPersonaFisica(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(toReturn.IdNotaio));
                    toReturn.SocietaCollegate = GetSocCollInternal(toReturn.IdModificaStatutaria);
                }
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list indirizzi by id soggetto.
        /// </summary>
        /// <param name="idSoggetto">The id soggetto.</param>
        /// <returns></returns>
        public ModificaStatutariaFDT[] GetModificheStatutarieInternal(int idDeliberaAssemblea)
        {
            ModificaStatutariaFDT[] toReturn = null;

            if (idDeliberaAssemblea != null)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCTMODIFICHE_STATUTARIECollection.GetByIDOBJ_ASSEMBLEA(idDeliberaAssemblea));

                if (toReturn != null && toReturn.Length > 0)
                {
                    foreach (ModificaStatutariaFDT modStat in toReturn)
                    {
                        modStat.Notaio = Converters.ConvertIntoPersonaFisica(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(modStat.IdNotaio));
                        modStat.SocietaCollegate = GetSocCollInternal(modStat.IdModificaStatutaria);
                    }
                }
            }

            return toReturn;
        }

        internal Boolean SaveListaModificheStatutarieInternal(int idAssemblea, ModificaStatutariaFDT[] items)
        {
            if (items != null)
            {
                foreach (ModificaStatutariaFDT modifica in items)
                {
                    if (modifica.Status >= ObjectStatus.ToHide &&
                        modifica.IdModificaStatutaria > 0)
                    {
                        DeleteModificaStatutaria(modifica);
                    }
                    else
                    {
                        int idModificaStat = modifica.IdModificaStatutaria;

                        if (modifica.Status == ObjectStatus.ToInsert ||
                            modifica.Status == ObjectStatus.ToUpdate)
                        {
                            modifica.IdAssemblea = idAssemblea;
                            ModificaStatutariaFDT modSaved = SaveModificaStatutariaInternal(modifica);
                            if (modSaved != null)
                                idModificaStat = modSaved.IdModificaStatutaria;
                        }

                        if (idModificaStat > 0)
                        {
                            //Salva collegamento società
                            SaveListaSocCollInternal(idModificaStat, modifica.SocietaCollegate);
                        }
                    }
                }
            }

            return true;
        }

        internal ModificaStatutariaFDT SaveModificaStatutariaInternal(ModificaStatutariaFDT item)
        {
            ModificaStatutariaFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.Notaio, item.IdNotaio);
                if (idSoggettoFK > 0)
                    item.IdNotaio = idSoggettoFK;
                #endregion Salvataggio del soggetto contenuto nell'oggetto


                GVCTMODIFICHE_STATUTARIE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdModificaStatutaria > 0)
                {
                    if (GVCDB.GVCTMODIFICHE_STATUTARIECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTMODIFICHE_STATUTARIECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the indirizzo.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public ModificaStatutariaFDT SaveModificaStatutaria(ModificaStatutariaFDT item)
        {
            ModificaStatutariaFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveModificaStatutariaInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        public Boolean DeleteModificaStatutaria(ModificaStatutariaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdModificaStatutaria > 0)
                {
                    GVCTMODIFICHE_STATUTARIE modStatTmp = new GVCTMODIFICHE_STATUTARIE();
                    modStatTmp.IDOBJ = item.IdModificaStatutaria;

                    toReturn = GVCDB.GVCTMODIFICHE_STATUTARIECollection.Delete(modStatTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Modifiche Statutarie

        #region Procedure coatte

        internal ProceduraCoattaFDT[] GetProcedureCoatteInternal(int idRegistro)
        {
            ProceduraCoattaFDT[] toReturn = null;

            if (idRegistro != null)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCTPROCEDURE_COATTECollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null && toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdProceduraCoatta", GVCTDOCUMENTAZIONECollection.IDOBJ_PROCEDURAColumnName);

                    foreach (ProceduraCoattaFDT proceduraC in toReturn)
                    {
                        proceduraC.Liquidazioni = Converters.ConvertAll(GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.GetByIDOBJ_PROCEDURA(proceduraC.IdProceduraCoatta));
                        proceduraC.CompensiCommissari = GetCompensiInternal("GVCTPROCEDURE_COATTE", proceduraC.IdProceduraCoatta);
                        proceduraC.Proroghe =  Converters.ConvertAll(GVCDB.GVCRPROROGHECollection.GetByIDOBJ_PROCEDURA(proceduraC.IdProceduraCoatta));
                    }
                }
            }

            return toReturn;
        }

        public ProceduraCoattaFDT[] GetListProcedureCoatteByIdRegistro(int idRegistro)
        {
            ProceduraCoattaFDT[] toReturn = null;

            try
            {
                toReturn = 
                    Converters.ConvertAll(
                        GVCDB.GVCTPROCEDURE_COATTECollection.GetByIDOBJ_REGISTRO(idRegistro));
            }
            catch
            {
            }

            return toReturn;
        }

        internal ProceduraCoattaFDT SaveProceduraCoattaInternal(ProceduraCoattaFDT item)
        {
            ProceduraCoattaFDT toReturn = null;

            if (item != null)
            {
                GVCTPROCEDURE_COATTE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdProceduraCoatta > 0)
                {
                    if (GVCDB.GVCTPROCEDURE_COATTECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTPROCEDURE_COATTECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the procedura coatta.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public ProceduraCoattaFDT SaveProceduraCoatta(ProceduraCoattaFDT item)
        {
            ProceduraCoattaFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveProceduraCoattaInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaProcedureCoattaInternal(int idRegistro, ProceduraCoattaFDT[] items)
        {
            if (items != null)
            {
                foreach (ProceduraCoattaFDT proceduraCoatta in items)
                {
                    if (proceduraCoatta.Status >= ObjectStatus.ToHide &&
                        proceduraCoatta.IdProceduraCoatta > 0)
                    {
                        DeleteProceduraCoatta(proceduraCoatta);
                    }
                    else
                    {
                        int idProcedura = proceduraCoatta.IdProceduraCoatta;

                        if (proceduraCoatta.Status == ObjectStatus.ToInsert ||
                            proceduraCoatta.Status == ObjectStatus.ToUpdate)
                        {
                            proceduraCoatta.IdRegistro = idRegistro;
                            ProceduraCoattaFDT proceduraSaved = SaveProceduraCoattaInternal(proceduraCoatta);
                            if (proceduraSaved != null)
                                idProcedura = proceduraSaved.IdProceduraCoatta;
                        }

                        if (idProcedura > 0)
                        {
                            if (proceduraCoatta.Documentazioni != null && proceduraCoatta.Documentazioni.Length > 0)
                            {
                                foreach (DocumentazioneFDT doc in proceduraCoatta.Documentazioni)
                                {
                                    doc.IdPadre = idProcedura;
                                }
                                SaveListDocumentazione(proceduraCoatta.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_PROCEDURAColumnName);
                            }

                            //Salva compensi
                            SaveListaCompensiInternal("GVCTPROCEDURE_COATTE", idProcedura, proceduraCoatta.CompensiCommissari);
                            //Salva liquidazioni
                            SaveListaLiqCompensoInternal("GVCTPROCEDURE_COATTE", idProcedura, proceduraCoatta.Liquidazioni);
                            //Salva Proroghe
                            SaveListaProrogheInternal(idProcedura, proceduraCoatta.Proroghe);
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Deletes the procedura coatta.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteProceduraCoatta(ProceduraCoattaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdProceduraCoatta > 0)
                {
                    GVCTPROCEDURE_COATTE proceduraCoattaTmp = new GVCTPROCEDURE_COATTE();
                    proceduraCoattaTmp.IDOBJ = item.IdProceduraCoatta;

                    toReturn = GVCDB.GVCTPROCEDURE_COATTECollection.Delete(proceduraCoattaTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetListProcedureCoatteBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
             CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.ID_TIPO_SOGGETTO, 
                                               SearchParameters.CODICE_COOPERATIVA,
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.PROCEDURA_COATTA_ID, 
                                               SearchParameters.PROCEDURA_COATTA_DATA_INIZIO, 
                                               SearchParameters.PROCEDURA_COATTA_DATA_CONCLUSIONE,
                                               SearchParameters.PROCEDURA_COATTA_ID_TIPO,
                                               SearchParameters.PROCEDURA_COATTA_ID_SOGGETTO};

                string[] values = new string[] { GVCVRICERCAPROCEDURE_COATTECollection.R_IDOBJ_STATOColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.R_IDOBJColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.PROCOA_IDOBJColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.PROCOA_DATA_INIZIOColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.PROCOA_DATA_CONCLUSIONEColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.PROCOA_IDOBJ_TIPO_PROCEDURAColumnName,
                                                 GVCVRICERCAPROCEDURE_COATTECollection.COMP_IDOBJ_SOGGETTOColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);
                GVCVRICERCAPROCEDURE_COATTE[] listaRisultati = GVCDB.GVCVRICERCAPROCEDURE_COATTECollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoProcedureCoatte(listaRisultati);                
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn; 
        }

        #endregion Procedure coatte

        #region Procedure coatte Proroghe

        internal Boolean SaveListaProrogheInternal(int idProceduraCoatta, ProrogaFDT[] items)
        {
            if (items != null)
            {
                foreach (ProrogaFDT proroga in items)
                {
                    if (proroga.Status == ObjectStatus.ToInsert ||
                      proroga.Status == ObjectStatus.ToUpdate)
                    {
                        proroga.IdProceduraCoatta = idProceduraCoatta;
                        SaveProrogaInternal(proroga);
                    }
                    else if (proroga.Status >= ObjectStatus.ToHide &&
                      proroga.IdProceduraCoatta > 0)
                    {
                        DeleteProroga(proroga);
                    }
                }
            }

            return true;
        }

        internal ProrogaFDT SaveProrogaInternal(ProrogaFDT item)
        {
            ProrogaFDT toReturn = null;

            if (item != null)
            {
                GVCRPROROGHE itemConverted = Converters.Convert(item);

                if (item.IdProroga > 0)
                {
                    if (GVCDB.GVCRPROROGHECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCRPROROGHECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the proroga.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteProroga(ProrogaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdProroga > 0)
                {
                    GVCRPROROGHE itemTmp = new GVCRPROROGHE();
                    itemTmp.IDOBJ = item.IdProroga;

                    toReturn = GVCDB.GVCRPROROGHECollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();    
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Procedure coatte proroghe

        #region Liquidazioni coatte

        internal LiquidazioneCoattaFDT[] GetLiquidazioniCoatteInternal(int idRegistro)
        {
            LiquidazioneCoattaFDT[] toReturn = null;

            if (idRegistro != null)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCTLIQUIDAZIONI_COATTECollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null && toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdLiquidazioneCoatta", GVCTDOCUMENTAZIONECollection.IDOBJ_LIQUIDAZIONEColumnName);

                    foreach (LiquidazioneCoattaFDT liqC in toReturn)
                    {
                        liqC.Liquidazioni = Converters.ConvertAll(GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.GetByIDOBJ_LIQUIDAZIONE(liqC.IdLiquidazioneCoatta));
                        liqC.CompensiCommissari = GetCompensiInternal("GVCTLIQUIDAZIONI_COATTE", liqC.IdLiquidazioneCoatta);
                        liqC.DelibereAcquistoCreditiFisc = Converters.ConvertAll(GVCDB.GVCTCREDITI_FISCALICollection.GetByIDOBJ_LIQUIDAZIONE(liqC.IdLiquidazioneCoatta));
                        liqC.Autorizzazioni = Converters.ConvertAll(GVCDB.GVCTAUTORIZZAZIONICollection.GetByIDOBJ_LIQUIDAZIONE(liqC.IdLiquidazioneCoatta));
                        liqC.RelazioniSemestrali = Converters.ConvertAll(GVCDB.GVCTRELAZIONI_SEMESTRALICollection.GetByIDOBJ_LIQUIDAZIONE(liqC.IdLiquidazioneCoatta));
                        liqC.DelibereAcquistoCreditiFisc = Converters.ConvertAll(GVCDB.GVCTCREDITI_FISCALICollection.GetByIDOBJ_LIQUIDAZIONE(liqC.IdLiquidazioneCoatta));
                    }
                }
            }

            return toReturn;
        }

        internal LiquidazioneCoattaFDT SaveLiquidazioneCoattaInternal(LiquidazioneCoattaFDT item)
        {
            LiquidazioneCoattaFDT toReturn = null;

            if (item != null)
            {
                GVCTLIQUIDAZIONI_COATTE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdLiquidazioneCoatta > 0)
                {
                    if (GVCDB.GVCTLIQUIDAZIONI_COATTECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTLIQUIDAZIONI_COATTECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the procedura coatta.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public LiquidazioneCoattaFDT SaveLiquidazioneCoatta(LiquidazioneCoattaFDT item)
        {
            LiquidazioneCoattaFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveLiquidazioneCoattaInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        internal Boolean SaveListaLiquidazioniCoattaInternal(int idRegistro, LiquidazioneCoattaFDT[] items)
        {
            if (items != null)
            {
                foreach (LiquidazioneCoattaFDT liquidazioneCoatta in items)
                {
                    if (liquidazioneCoatta.Status >= ObjectStatus.ToHide &&
                        liquidazioneCoatta.IdLiquidazioneCoatta > 0)
                    {
                        DeleteLiquidazioneCoatta(liquidazioneCoatta);
                    }
                    else
                    {
                        int idLiquidazione = liquidazioneCoatta.IdLiquidazioneCoatta;

                        if (liquidazioneCoatta.Status == ObjectStatus.ToInsert ||
                            liquidazioneCoatta.Status == ObjectStatus.ToUpdate)
                        {
                            liquidazioneCoatta.IdRegistro = idRegistro;
                            LiquidazioneCoattaFDT liquidazioneSaved = SaveLiquidazioneCoattaInternal(liquidazioneCoatta);
                            if (liquidazioneSaved != null)
                                idLiquidazione = liquidazioneSaved.IdLiquidazioneCoatta;
                        }

                        if (idLiquidazione > 0)
                        {
                            if (liquidazioneCoatta.Documentazioni != null && liquidazioneCoatta.Documentazioni.Length > 0)
                            {
                                foreach (DocumentazioneFDT doc in liquidazioneCoatta.Documentazioni)
                                {
                                    doc.IdPadre = idLiquidazione;
                                }
                                SaveListDocumentazione(liquidazioneCoatta.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_LIQUIDAZIONEColumnName);
                            }

                            SaveListaCompensiInternal("GVCTLIQUIDAZIONI_COATTE", idLiquidazione, liquidazioneCoatta.CompensiCommissari);

                            SaveListaLiqCompensoInternal("GVCTLIQUIDAZIONI_COATTE", idLiquidazione, liquidazioneCoatta.Liquidazioni);

                            SaveListaRelazioniSemestraliInternal(idLiquidazione, liquidazioneCoatta.RelazioniSemestrali);

                            SaveListaAutorizzazioniInternal(idLiquidazione, liquidazioneCoatta.Autorizzazioni);

                            SaveListaAcquistiCreditiFiscali(idLiquidazione, liquidazioneCoatta.DelibereAcquistoCreditiFisc);
                        }
                        
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Deletes the liquidazione coatta.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteLiquidazioneCoatta(LiquidazioneCoattaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdLiquidazioneCoatta > 0)
                {
                    GVCTLIQUIDAZIONI_COATTE liqiudazioneCoattaTmp = new GVCTLIQUIDAZIONI_COATTE();
                    liqiudazioneCoattaTmp.IDOBJ = item.IdLiquidazioneCoatta;

                    toReturn = GVCDB.GVCTLIQUIDAZIONI_COATTECollection.Delete(liqiudazioneCoattaTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetListLiquidazioniCoatteBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.ID_TIPO_SOGGETTO, 
                                               SearchParameters.CODICE_COOPERATIVA,
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.LIQUIDAZIONE_COATTA_DATA_GIUNTA, 
                                               SearchParameters.LIQUIDAZIONE_COATTA_DEPOSITO_BFL,
                                               SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_CONCLUSA,
                                               SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_REVOCATA,
                                               SearchParameters.LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT,
                                               SearchParameters.LIQUIDAZIONE_COATTA_SPESE_CARICO_PAT_ID,
                                               SearchParameters.LIQUIDAZIONE_COATTA_ACQUISTO_CREDITI_FISCALI,
                                               SearchParameters.LIQUIDAZIONE_COATTA_CODICE_UFFICIO,
                                               SearchParameters.LIQUIDAZIONE_COATTA_ID_TIPO,
                                               SearchParameters.LIQUIDAZIONE_COATTA_ID_SOGGETTO};

                string[] values = new string[] { GVCVRICERCALIQUIDAZIONI_COATTECollection.R_IDOBJ_STATOColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.R_IDOBJColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_DATA_DELIBERA_GIUNTAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_DEPOSITO_BFLColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_PROCEDURA_CONCLUSAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_PROCEDURA_REVOCATAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.COMPLIQ_IMPORTO_SPESEColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.COMPLIQ_IDOBJColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.CREFIS_IDOBJColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_CODICE_UFFICIOColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_IDOBJ_TIPO_LIQUIDAZIONEColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.COMP_IDOBJ_SOGGETTOColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);
                GVCVRICERCALIQUIDAZIONI_COATTE[] listaRisultati = GVCDB.GVCVRICERCALIQUIDAZIONI_COATTECollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
              indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoLiquidazioniCoatte(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Liquidazioni coatte

        #region Relazioni semestrali liquidazioni coatte

        internal Boolean SaveListaRelazioniSemestraliInternal(int idLiquidazione, RelazioneSemestraleFDT[] items)
        {
            if (items != null)
            {
                foreach (RelazioneSemestraleFDT relazioneSemestrale in items)
                {
                    if (relazioneSemestrale.Status == ObjectStatus.ToInsert ||
                      relazioneSemestrale.Status == ObjectStatus.ToUpdate)
                    {
                        relazioneSemestrale.IdLiquidazione = idLiquidazione;
                        SaveRelazioneSemestraleInternal(relazioneSemestrale);
                    }
                    else if (relazioneSemestrale.Status >= ObjectStatus.ToHide &&
                      relazioneSemestrale.IdRelazioneSemestrale > 0)
                    {
                        DeleteRelazioneSemestrale(relazioneSemestrale);
                    }
                }
            }

            return true;
        }

        internal RelazioneSemestraleFDT SaveRelazioneSemestraleInternal(RelazioneSemestraleFDT item)
        {
            RelazioneSemestraleFDT toReturn = null;

            if (item != null)
            {
                GVCTRELAZIONI_SEMESTRALI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdRelazioneSemestrale > 0)
                {
                    if (GVCDB.GVCTRELAZIONI_SEMESTRALICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTRELAZIONI_SEMESTRALICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the relazione semestrale.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteRelazioneSemestrale(RelazioneSemestraleFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdRelazioneSemestrale > 0)
                {
                    GVCTRELAZIONI_SEMESTRALI itemTmp = new GVCTRELAZIONI_SEMESTRALI();
                    itemTmp.IDOBJ = item.IdRelazioneSemestrale;

                    toReturn = GVCDB.GVCTRELAZIONI_SEMESTRALICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetListRelazioniSemestraliBySearch(OeF.Utility.Expression query, DateTime? dataRelazione, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.ID_TIPO_SOGGETTO, 
                                               SearchParameters.CODICE_COOPERATIVA,
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.RELAZIONE_SEMESTRALE_DATA_RIFERIMENTO, 
                                               SearchParameters.LIQUIDAZIONE_COATTA_CODICE_UFFICIO,                                               
                                               SearchParameters.LIQUIDAZIONE_COATTA_DEPOSITO_BFL,
                                               SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_CONCLUSA,
                                               SearchParameters.LIQUIDAZIONE_COATTA_PROCEDURA_REVOCATA,                                               
                                               SearchParameters.LIQUIDAZIONE_COATTA_ID_TIPO,
                                               SearchParameters.LIQUIDAZIONE_COATTA_ID};

                string[] values = new string[] { GVCVRICERCALIQUIDAZIONI_COATTECollection.R_IDOBJ_STATOColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.R_IDOBJColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.RELSEM_DATA_RELAZIONEColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_CODICE_UFFICIOColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_DEPOSITO_BFLColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_PROCEDURA_CONCLUSAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_PROCEDURA_REVOCATAColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_IDOBJ_TIPO_LIQUIDAZIONEColumnName,
                                                 GVCVRICERCALIQUIDAZIONI_COATTECollection.LIQCOA_IDOBJColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                if (dataRelazione.HasValue)
                {
                    where = where + " AND " + GVCDB.GVCVRICERCALIQUIDAZIONI_COATTECollection.GetSqlWhereDataRelazioneNotIn(dataRelazione.Value);
                }

                GVCVRICERCALIQUIDAZIONI_COATTE[] listaRisultati = GVCDB.GVCVRICERCALIQUIDAZIONI_COATTECollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
              indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoLiquidazioniCoatte(listaRisultati);

                //toReturn = Converters.ConvertAllIntoLiquidazioniCoatte(GVCDB.GVCVRICERCALIQUIDAZIONI_COATTECollection.GetBySearchParameters(where));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }


        #endregion  Relazioni semestrali liquidazioni coatte

        #region Autorizzazioni liquidazioni coatte

        internal Boolean SaveListaAutorizzazioniInternal(int idLiquidazione, AutorizzazioneFDT[] items)
        {
            if (items != null)
            {
                foreach (AutorizzazioneFDT autorizzazione in items)
                {
                    if (autorizzazione.Status == ObjectStatus.ToInsert ||
                      autorizzazione.Status == ObjectStatus.ToUpdate)
                    {
                        autorizzazione.IdLiquidazione = idLiquidazione;
                        SaveAutorizzazioneInternal(autorizzazione);
                    }
                    else if (autorizzazione.Status >= ObjectStatus.ToHide&&
                      autorizzazione.IdAutorizzazione > 0)
                    {
                        DeleteAutorizzazione(autorizzazione);
                    }
                }
            }

            return true;
        }

        internal AutorizzazioneFDT SaveAutorizzazioneInternal(AutorizzazioneFDT item)
        {
            AutorizzazioneFDT toReturn = null;

            if (item != null)
            {
                GVCTAUTORIZZAZIONI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdAutorizzazione > 0)
                {
                    if (GVCDB.GVCTAUTORIZZAZIONICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTAUTORIZZAZIONICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the relazione autorizzazione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteAutorizzazione(AutorizzazioneFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdAutorizzazione > 0)
                {
                    GVCTAUTORIZZAZIONI itemTmp = new GVCTAUTORIZZAZIONI();
                    itemTmp.IDOBJ = item.IdAutorizzazione;

                    toReturn = GVCDB.GVCTAUTORIZZAZIONICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion  Relazioni semestrali liquidazioni coatte

        #region Acquisti crediti fiscali liquidazioni coatte

        internal Boolean SaveListaAcquistiCreditiFiscali(int idLiquidazione, DeliberaAcquistoCreditiFiscFDT[] items)
        {
            if (items != null)
            {
                foreach (DeliberaAcquistoCreditiFiscFDT acquistoCreditiFisc in items)
                {
                    if (acquistoCreditiFisc.Status == ObjectStatus.ToInsert ||
                      acquistoCreditiFisc.Status == ObjectStatus.ToUpdate)
                    {
                        acquistoCreditiFisc.IdLiquidazione = idLiquidazione;
                        SaveAcquistoCreditiFiscaliInternal(acquistoCreditiFisc);
                    }
                    else if (acquistoCreditiFisc.Status >= ObjectStatus.ToHide &&
                      acquistoCreditiFisc.IdDeliberaAcquistoCreditiFisc > 0)
                    {
                        DeleteAcquistoCreditiFiscali(acquistoCreditiFisc);
                    }
                }
            }

            return true;
        }

        internal DeliberaAcquistoCreditiFiscFDT SaveAcquistoCreditiFiscaliInternal(DeliberaAcquistoCreditiFiscFDT item)
        {
            DeliberaAcquistoCreditiFiscFDT toReturn = null;

            if (item != null)
            {
                GVCTCREDITI_FISCALI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdDeliberaAcquistoCreditiFisc > 0)
                {
                    if (GVCDB.GVCTCREDITI_FISCALICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTCREDITI_FISCALICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the relazione acquisto crediti fiscali.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteAcquistoCreditiFiscali(DeliberaAcquistoCreditiFiscFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdDeliberaAcquistoCreditiFisc > 0)
                {
                    GVCTCREDITI_FISCALI itemTmp = new GVCTCREDITI_FISCALI();
                    itemTmp.IDOBJ = item.IdDeliberaAcquistoCreditiFisc;

                    toReturn = GVCDB.GVCTCREDITI_FISCALICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion  Acquisti crediti fiscali semestrali liquidazioni coatte

        #region Dizionari

        /// <summary>
        /// Gets all dictionaries.
        /// </summary>
        /// <returns></returns>
        public DizionarioFDT[] GetAllDictionaries()
        {
            DizionarioFDT[] toReturn = null;
            try
            {
                toReturn = Converters.ConvertAll(GVCDB.GVCVDIZIONARICollection.GetAll());
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the dettaglio procedimento dictionary.
        /// </summary>
        /// <param name="idDictionary">The id dictionary.</param>
        /// <returns></returns>
        public DettaglioDizionarioFDT GetDettaglioProcedimentoDictionary(int idDictionary)
        {
            DettaglioDizionarioFDT toReturn = null;
            try
            {
                toReturn = Converters.Convert(GVCDB.GVCDTIPI_PROCEDIMENTOCollection.GetByPrimaryKey(idDictionary));
            }
            catch
            {
            }

            return toReturn;
        }

        //public DettaglioDizionarioFDT GetDettaglioSanzioneDictionary(int idDictionary)
        //{
        //    DettaglioDizionarioFDT toReturn = null;
        //    try
        //    {
        //        toReturn = Converters.Convert(GVCDB.GVCDLEGGI_TRASGRESSIONECollection.GetByPrimaryKey(idDictionary));
        //    }
        //    catch
        //    {
        //    }

        //    return toReturn;
        //}

        public DettaglioDizionarioFDT GetDettaglioCadenzaRevDictionary(int idDictionary)
        {
            DettaglioDizionarioFDT toReturn = null;
            try
            {
                toReturn = Converters.Convert(GVCDB.GVCDCADENZA_REVISIONICollection.GetByPrimaryKey(idDictionary));
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the dictionary.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public DizionarioFDT SaveDictionary(DizionarioFDT item)
        {
            DizionarioFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                   string type1 = String.Concat("it.dedagroup.GVC.Repository.rtier.Service.", item.Tipo.ToUpper());
                   string type2 = String.Concat(type1, ", it.dedagroup.GVC.Repository.rtier");
                   Type type = Type.GetType(type2);

                   if (type != null)
                   {
                       object itemToSave = Converters.getObject(type, item);

                       string dllBase = string.Concat("it.dedagroup.GVC.Repository.rtier.Service.", item.Tipo.ToUpper(), "Collection");
                       string dllFull = String.Concat(dllBase, ", it.dedagroup.GVC.Repository.rtier");

                       System.Reflection.PropertyInfo pInfo = GVCDB.GetType().GetProperty(string.Concat(item.Tipo.ToUpper(), "Collection"));

                       if (pInfo != null)
                       {
                           #region Get the method

                           Boolean update = true;
                           System.Reflection.MethodInfo mi = null;
                           if (item.IdElemento >= 0)
                           {
                               mi = pInfo.PropertyType.GetMethod("Update", new Type[] { type });
                           }
                           else
                           {
                               mi = pInfo.PropertyType.GetMethod("Insert", new Type[] { type });
                               update = false;
                           }
                           
                           #endregion Get the method

                           if (mi != null)
                           {
                               mi.Invoke(pInfo.GetValue(GVCDB, null), new object[] { itemToSave });

                               #region Get the new ID

                               if (itemToSave != null)
                               {
                                   toReturn = item;
                                   if (!update)
                                   {
                                       System.Reflection.PropertyInfo pToReturn = itemToSave.GetType().GetProperty("IDOBJ");
                                       if (pToReturn != null)
                                       {
                                           object oToSave = pToReturn.GetValue(itemToSave, null);
                                           if (oToSave != null)
                                           {
                                               int idNew = -1;
                                               if (Int32.TryParse(oToSave.ToString(), out idNew))
                                               {
                                                   toReturn.IdElemento = idNew;
                                               }
                                           }
                                       }
                                   }
                               }

                               #endregion Get the new ID
                           }
                       }
                   }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the dictionary.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public string[] DeleteDictionary(DizionarioFDT item)
        {
            string[] toReturn = new string[0];

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {

                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    string type1 = String.Concat("it.dedagroup.GVC.Repository.rtier.Service.", item.Tipo.ToUpper());
                    string type2 = String.Concat(type1, ", it.dedagroup.GVC.Repository.rtier");
                    Type type = Type.GetType(type2);

                    if (type != null)
                    {
                        object itemToSave = Converters.getObject(type, item);

                        string dllBase = string.Concat("it.dedagroup.GVC.Repository.rtier.Service.", item.Tipo.ToUpper(), "Collection");
                        string dllFull = String.Concat(dllBase, ", it.dedagroup.GVC.Repository.rtier");

                        System.Reflection.PropertyInfo pInfo = GVCDB.GetType().GetProperty(string.Concat(item.Tipo.ToUpper(), "Collection"));

                        if (pInfo != null)
                        {
                            #region Get the method
                           
                            System.Reflection.MethodInfo mi = null;
                            if (item.IdElemento > 0)
                            {
                                mi = pInfo.PropertyType.GetMethod("Delete", new Type[] { type });
                            }
                            #endregion Get the method

                            if (mi != null)
                            {
                                object outcome = mi.Invoke(pInfo.GetValue(GVCDB, null), new object[] { itemToSave });
                                Boolean res = false;
                                if (!Boolean.TryParse(outcome.ToString(), out res))
                                {
                                    toReturn = null;
                                }
                            }
                        }
                    }
                }

               

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);

                if (ex.InnerException != null && ex.InnerException.Message.Contains("ORA-02292"))
                {
                    toReturn = new string[1];
                }
                else
                {
                    toReturn = null;
                    throw;
                }
            }

            return toReturn;
        }

        #endregion Dizionari

        #region Adesioni

        internal AdesioneFDT[] GetAdesioniInternal(int idRegistro)
        {
            AdesioneFDT[] toReturn = null;

            if (idRegistro > 0)
            {
                toReturn =
                   Converters.ConvertAll(
                       GVCDB.GVCTADESIONICollection.GetListAdesioniByIdRegistro(idRegistro));

                if (toReturn != null)
                {
                    SetDocumentazioni(toReturn, "IdAdesione", GVCTDOCUMENTAZIONECollection.IDOBJ_ADESIONEColumnName);
                }

                if (toReturn != null & toReturn.Length > 0)
                {
                    foreach (AdesioneFDT adesione in toReturn)
                    {
                        //Carica associazione
                        adesione.Associazione = Converters.ConvertIntoPersonaGiuridica(GetSoggettoByID(adesione.IdAssociazione));
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list adesioni by id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public AdesioneFDT[] GetListAdesioniByIdRegistro(int idRegistro)
        {
            AdesioneFDT[] toReturn = null;

            try
            {
               toReturn = GetAdesioniInternal(idRegistro);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return toReturn;
        }


        /// <summary>
        /// Gets the adesione by id.
        /// </summary>
        /// <param name="idAdesione">The id adesione.</param>
        /// <returns></returns>
        public AdesioneFDT GetAdesioneById(int idAdesione)
        {
            AdesioneFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTADESIONICollection.GetByPrimaryKey(idAdesione));

                if (toReturn != null)
                {
                   //Carica Associazione
                    toReturn.Associazione = Converters.ConvertIntoPersonaGiuridica(GetSoggettoByID(toReturn.IdAssociazione));
                }

            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list of notifications by id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public SegnalazioneFDT[] GetListSegnalazioniByIdRegistro(int idRegistro)
        {
            SegnalazioneFDT[] toReturn = null;

            try
            {
                toReturn = Converters.ConvertAll(GVCDB.GVCVSEGDAAPPLICARECollection.GetSegnalazioniToAppliByIdReg(idRegistro));
            } 
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return toReturn;
        }

        internal void SaveListaSegnalazioniInternal(List<SegnalazioneFDT> items)
        {
            if (items != null)
            {
                GVCTLOG_SEGNALAZIONI segToUpdate;
                foreach (SegnalazioneFDT segnalazione in items)
                {
                    segToUpdate = Converters.Convert(segnalazione);
                    segToUpdate.OPERATOREULTMOD = CallerIdentity;
                    segToUpdate.DATAORAULTMOD = DateTime.Now;
                    GVCDB.GVCTLOG_SEGNALAZIONICollection.Update(segToUpdate);
                }
            }
        }
        public SegnalazioneFDT[] GetListSegnalazioniByDate(int regNr, DateTime from, DateTime to, int[] segTypes, int visible, int applied)
        {
            SegnalazioneFDT[] toReturn = null;

            try
            {
                toReturn = Converters.ConvertAll(
                                GVCDB.GVCVCERCAMODIFICHEPARIXCollection.GetListSegnalazioniBetweenDates(regNr,
                                            from, to,segTypes, visible, applied));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the notification.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteSegnalazione(SegnalazioneFDT item)
        {
            Boolean toReturn = false;
            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    GVCTLOG_SEGNALAZIONI itemTmp = new GVCTLOG_SEGNALAZIONI();
                    itemTmp.IDOBJ = item.IdSegnalazione;
                    toReturn = GVCDB.GVCTLOG_SEGNALAZIONICollection.Delete(itemTmp);
                }

                if (toReturn)
                    if (!isInTransaction)
                        GVCDB.CommitTransaction();
                else
                    if (!isInTransaction)
                        GVCDB.RollbackTransaction();
            }
            catch(Exception ex)
            {
                if (!isInTransaction)
                    GVCDB.RollbackTransaction();
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        internal Boolean SaveListaAdesioniInternal(int idRegistro, AdesioneFDT[] items)
        {
            if (items != null)
            {
                foreach (AdesioneFDT adesione in items)
                {
                    if (adesione.Status >= ObjectStatus.ToHide &&
                            adesione.IdAdesione > 0)
                    {
                        DeleteAdesione(adesione);
                    }
                    else
                    {
                        int idAdesione = adesione.IdAdesione;

                        if (adesione.Status == ObjectStatus.ToInsert ||
                            adesione.Status == ObjectStatus.ToUpdate)
                        {
                            adesione.IdRegistro = idRegistro;
                            AdesioneFDT itemSaved = SaveAdesioneInternal(adesione);
                            if (itemSaved != null)
                                idAdesione = itemSaved.IdAdesione;
                        }

                        if (adesione.Documentazioni != null && 
                            adesione.Documentazioni.Length > 0 &&
                            idAdesione > 0)
                        {
                            foreach (DocumentazioneFDT doc in adesione.Documentazioni)
                            {
                                doc.IdPadre = idAdesione;
                            }
                            SaveListDocumentazione(adesione.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_ADESIONEColumnName);
                        }

                       
                    }
                }
            }

            return true;
        }

        internal AdesioneFDT SaveAdesioneInternal(AdesioneFDT item)
        {
            AdesioneFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.Associazione, item.IdAssociazione);
                if (idSoggettoFK > 0)
                    item.IdAssociazione = idSoggettoFK;
                #endregion Salvataggio del soggetto contenuto nell'oggetto

                GVCTADESIONI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdAdesione > 0)
                {
                    if (GVCDB.GVCTADESIONICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTADESIONICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the adesione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public AdesioneFDT SaveAdesione(AdesioneFDT item)
        {
            AdesioneFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveAdesioneInternal(item);
               
                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the adesione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteAdesione(AdesioneFDT item)
        {
            Boolean toReturn = false;
             
            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdAdesione > 0)
                {
                    GVCTADESIONI adesioneTmp = new GVCTADESIONI();
                    adesioneTmp.IDOBJ = item.IdAdesione;

                    toReturn = GVCDB.GVCTADESIONICollection.Delete(adesioneTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Adesioni

        #region Cariche

        internal CaricaSocialeFDT[] GetCaricheInternal(int idComunicazione)
        {
            CaricaSocialeFDT[] toReturn = null;

            if (idComunicazione != null)
            {
                toReturn = Converters.ConvertAll(
                        GVCDB.GVCRCARICHECollection.GetByIDOBJ_COMUNICAZIONE(idComunicazione));

                if (toReturn != null & toReturn.Length > 0)
                {
                    foreach (CaricaSocialeFDT carica in toReturn)
                    {
                        //Carica socio
                        carica.PersonaFisica = Converters.ConvertIntoPersonaFisica(GetSoggettoByID(carica.IdSoggetto));
                    }
                }
            }

            return toReturn;
        }

        public CaricaSocialeFDT[] GetListCaricheByIdComunicazione(int idComunicazione)
        {
            CaricaSocialeFDT[] toReturn = null;

            try
            {
               toReturn = GetCaricheInternal(idComunicazione);
            }
            catch
            {
            }

            return toReturn;
        }

        public CaricaSocialeFDT GetCaricaById(int idItem)
        {
            CaricaSocialeFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCRCARICHECollection.GetByPrimaryKey(idItem));

                if (toReturn != null)
                {
                    toReturn.PersonaFisica = Converters.ConvertIntoPersonaFisica(GetSoggettoByID(toReturn.IdSoggetto));
                }

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaCaricheInternal(int idComunicazione, CaricaSocialeFDT[] items)
        {
            if (items != null)
            {
                foreach (CaricaSocialeFDT carica in items)
                {
                    if (carica.Status == ObjectStatus.ToInsert ||
                        carica.Status == ObjectStatus.ToUpdate)
                    {
                        carica.IdComunicazione = idComunicazione;
                        SaveCaricaInternal(carica);
                    }
                    else if (carica.Status >= ObjectStatus.ToHide &&
                             carica.IdCarica > 0)
                    {
                        DeleteCarica(carica);
                    }
                }
            }

            return true;
        }

        internal CaricaSocialeFDT SaveCaricaInternal(CaricaSocialeFDT item)
        {
            CaricaSocialeFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.PersonaFisica, item.IdSoggetto);
                if (idSoggettoFK > 0)
                {
                    item.IdSoggetto = idSoggettoFK;
                }
                else
                {
                    //Se non è riuscito a creare il soggetto per mancanza del codice fiscale
                    item.DescrizioneGSC = item.DescrizioneSocio;
                }
                #endregion Salvataggio del soggetto contenuto nell'oggetto

                GVCRCARICHE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdCarica > 0)
                {
                    if (GVCDB.GVCRCARICHECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCRCARICHECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        public Boolean DeleteCarica(CaricaSocialeFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdCarica > 0)
                {
                    GVCRCARICHE itemTmp = new GVCRCARICHE();
                    itemTmp.IDOBJ = item.IdCarica;

                    toReturn = GVCDB.GVCRCARICHECollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Cariche

        #region Comunicazioni Cariche Sociali

        internal ComunicazioneCaricaSocialeFDT[] GetComCaricheSocInternal(int idRegistro)
        {
            ComunicazioneCaricaSocialeFDT[] toReturn = null;

            if (idRegistro > 0)
            {
                toReturn =
                   Converters.ConvertAll(
                        GVCDB.GVCTCOM_CARICHECollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null & toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdComunicazioneCaricaSociale", GVCTDOCUMENTAZIONECollection.IDOBJ_CARICHEColumnName);

                    foreach (ComunicazioneCaricaSocialeFDT com in toReturn)
                    {
                        com.Cariche = GetCaricheInternal(com.IdComunicazioneCaricaSociale); //Converters.ConvertAll(GVCDB.GVCRCARICHECollection.GetByIDOBJ_COMUNICAZIONE(com.IdComunicazioneCaricaSociale));
                    }
                }
            }

            return toReturn;
        }

        public ComunicazioneCaricaSocialeFDT[] GetListComCaricheSocByIdRegistro(int idRegistro)
        {
            ComunicazioneCaricaSocialeFDT[] toReturn = null;

            try
            {
                toReturn = GetComCaricheSocInternal(idRegistro);
            }
            catch
            {
            }

            return toReturn;
        }

        public ComunicazioneCaricaSocialeFDT GetComCaricaSocById(int idItem)
        {
            ComunicazioneCaricaSocialeFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTCOM_CARICHECollection.GetByPrimaryKey(idItem));

                if (toReturn != null)
                {
                    toReturn.Cariche = Converters.ConvertAll(GVCDB.GVCRCARICHECollection.GetByIDOBJ_COMUNICAZIONE(toReturn.IdComunicazioneCaricaSociale));
                }

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaComCaricaInternal(int idRegistro, ComunicazioneCaricaSocialeFDT[] items)
        {
            if (items != null)
            {
                foreach (ComunicazioneCaricaSocialeFDT comCarica in items)
                {
                    if (comCarica.Status >= ObjectStatus.ToHide &&
                        comCarica.IdComunicazioneCaricaSociale > 0)
                    {
                        DeleteComCaricaSoc(comCarica);
                    }
                    else
                    {
                        int idComunicazione = comCarica.IdComunicazioneCaricaSociale;

                        if (comCarica.Status == ObjectStatus.ToInsert ||
                            comCarica.Status == ObjectStatus.ToUpdate)
                        {
                            comCarica.IdRegistro = idRegistro;
                            ComunicazioneCaricaSocialeFDT comCaricaSaved = SaveComCaricaSocInternal(comCarica);
                            if (comCaricaSaved != null)
                                idComunicazione = comCaricaSaved.IdComunicazioneCaricaSociale;
                        }

                        if (idComunicazione > 0)
                        {
                            if (comCarica.Documentazioni != null && comCarica.Documentazioni.Length > 0)
                            {
                                foreach (DocumentazioneFDT doc in comCarica.Documentazioni)
                                {
                                    doc.IdPadre = idComunicazione;
                                }
                                SaveListDocumentazione(comCarica.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_CARICHEColumnName);
                            }

                            //Salva cariche
                            SaveListaCaricheInternal(idComunicazione, comCarica.Cariche);
                        }
                    }
                }
            }

            return true;
        }

        internal ComunicazioneCaricaSocialeFDT SaveComCaricaSocInternal(ComunicazioneCaricaSocialeFDT item)
        {
            ComunicazioneCaricaSocialeFDT toReturn = null;

            if (item != null)
            {
                GVCTCOM_CARICHE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdComunicazioneCaricaSociale > 0)
                {
                    if (GVCDB.GVCTCOM_CARICHECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTCOM_CARICHECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        public Boolean DeleteComCaricaSoc(ComunicazioneCaricaSocialeFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdComunicazioneCaricaSociale > 0)
                {
                    GVCTCOM_CARICHE itemTmp = new GVCTCOM_CARICHE();
                    itemTmp.IDOBJ = item.IdComunicazioneCaricaSociale;

                    toReturn = GVCDB.GVCTCOM_CARICHECollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Comunicazioni Cariche Sociali

        #region Comunicazioni Base Sociale

        /// <summary>
        /// Gets the list base soc by id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public ComunicazioneBaseSocialeFDT[] GetListBaseSocByIdRegistro(int idRegistro)
        {
            ComunicazioneBaseSocialeFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTCOM_BASE_SOCIALECollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null && toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdComunicazioneBaseSociale", GVCTDOCUMENTAZIONECollection.IDOBJ_BASE_SOCIALEColumnName);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the base soc by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public ComunicazioneBaseSocialeFDT GetBaseSocById(int idItem)
        {
            ComunicazioneBaseSocialeFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTCOM_BASE_SOCIALECollection.GetByPrimaryKey(idItem));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaBaseSocInternal(int idRegistro, ComunicazioneBaseSocialeFDT[] items)
        {
            if (items != null)
            {
                foreach (ComunicazioneBaseSocialeFDT baseSoc in items)
                {
                    if (baseSoc.Status >= ObjectStatus.ToHide &&
                       baseSoc.IdComunicazioneBaseSociale > 0)
                    {
                        DeleteBaseSoc(baseSoc);
                    }
                    else
                    {
                        int idBaseSoc = baseSoc.IdComunicazioneBaseSociale;

                        if (baseSoc.Status == ObjectStatus.ToInsert ||
                            baseSoc.Status == ObjectStatus.ToUpdate)
                        {
                            baseSoc.IdRegistro = idRegistro;
                            ComunicazioneBaseSocialeFDT baseSocSaved = SaveBaseSocInternal(baseSoc);
                            if (baseSocSaved != null)
                                idBaseSoc = baseSocSaved.IdComunicazioneBaseSociale;
                        }

                        if (idBaseSoc > 0)
                        {
                            if (baseSoc.Documentazioni != null && baseSoc.Documentazioni.Length > 0)
                            {
                                foreach (DocumentazioneFDT doc in baseSoc.Documentazioni)
                                {
                                    doc.IdPadre = idBaseSoc;
                                }
                                SaveListDocumentazione(baseSoc.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_BASE_SOCIALEColumnName);
                            }
                        }
                    }
                }
            }

            return true;
        }

        internal ComunicazioneBaseSocialeFDT SaveBaseSocInternal(ComunicazioneBaseSocialeFDT item)
        {
            ComunicazioneBaseSocialeFDT toReturn = null;

            if (item != null)
            {
                GVCTCOM_BASE_SOCIALE itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdComunicazioneBaseSociale > 0)
                {
                    if (GVCDB.GVCTCOM_BASE_SOCIALECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTCOM_BASE_SOCIALECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the base soc.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteBaseSoc(ComunicazioneBaseSocialeFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdComunicazioneBaseSociale > 0)
                {
                    GVCTCOM_BASE_SOCIALE itemTmp = new GVCTCOM_BASE_SOCIALE();
                    itemTmp.IDOBJ = item.IdComunicazioneBaseSociale;

                    toReturn = GVCDB.GVCTCOM_BASE_SOCIALECollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion

        #region Fallimenti

        internal ProceduraFallimentareFDT[] GetFallimentiInternal(int idRegistro)
        {
            ProceduraFallimentareFDT[] toReturn = null;

            if (idRegistro != null)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCTFALLIMENTICollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null && toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdProceduraFallimentare", GVCTDOCUMENTAZIONECollection.IDOBJ_FALLIMENTOColumnName);

                    foreach (ProceduraFallimentareFDT proc in toReturn)
                    {
                        proc.Curatore = Converters.ConvertIntoPersonaFisica(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(proc.IdCuratore));
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the base soc by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public ProceduraFallimentareFDT GetFallimentoById(int idItem)
        {
            ProceduraFallimentareFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTFALLIMENTICollection.GetByPrimaryKey(idItem));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaFallimentiInternal(int idRegistro, ProceduraFallimentareFDT[] items)
        {
            if (items != null)
            {
                foreach (ProceduraFallimentareFDT fallimento in items)
                {
                    if (fallimento.Status >= ObjectStatus.ToHide &&
                             fallimento.IdProceduraFallimentare > 0)
                    {
                        DeleteFallimento(fallimento);
                    }
                    else
                    {
                        int idFallimento = fallimento.IdProceduraFallimentare;

                        if (fallimento.Status == ObjectStatus.ToInsert ||
                         fallimento.Status == ObjectStatus.ToUpdate)
                        {
                            fallimento.IdRegistro = idRegistro;
                            ProceduraFallimentareFDT fallimentoSaved = SaveFallimentoInternal(fallimento);
                            if (fallimentoSaved != null)
                                idFallimento = fallimentoSaved.IdProceduraFallimentare;

                            if (idFallimento > 0)
                            {
                                if (fallimento.Documentazioni != null && fallimento.Documentazioni.Length > 0)
                                {
                                    foreach (DocumentazioneFDT doc in fallimento.Documentazioni)
                                    {
                                        doc.IdPadre = idFallimento;
                                    }
                                    SaveListDocumentazione(fallimento.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_FALLIMENTOColumnName);
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }

        internal ProceduraFallimentareFDT SaveFallimentoInternal(ProceduraFallimentareFDT item)
        {
            ProceduraFallimentareFDT toReturn = null;

            if (item != null)
            {
                GVCTFALLIMENTI itemConverted = Converters.Convert(item);

                if (item.IdProceduraFallimentare > 0)
                {
                    if (GVCDB.GVCTFALLIMENTICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTFALLIMENTICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the base soc.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteFallimento(ProceduraFallimentareFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdProceduraFallimentare > 0)
                {
                    GVCTFALLIMENTI itemTmp = new GVCTFALLIMENTI();
                    itemTmp.IDOBJ = item.IdProceduraFallimentare;

                    toReturn = GVCDB.GVCTFALLIMENTICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Fallimenti

        #region Revisioni

        internal RevisioneFDT[] GetRevisioniInternal(int idRegistro)
        {
            RevisioneFDT[] toReturn = null;

            if (idRegistro > 0)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCTREVISIONICollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null && toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdRevisione", GVCTDOCUMENTAZIONECollection.IDOBJ_REVISIONEColumnName);

                    foreach (RevisioneFDT revisione in toReturn)
                    {
                        revisione.Revisore = Converters.ConvertIntoPersonaGiuridica(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(revisione.IdOrganoRevisore));
                        revisione.Liquidazioni = Converters.ConvertAll(GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.GetByIDOBJ_REVISIONE(revisione.IdRevisione));

                        revisione.RevisioniIncarichi = GetIncarichiInternal(revisione.IdRevisione);
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list revisioni by id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public RevisioneFDT[] GetListRevisioniByIdRegistro(int idRegistro)
        {
            RevisioneFDT[] toReturn = null;

            try
            {
                toReturn = GetRevisioniInternal(idRegistro);
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the revisione by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public RevisioneFDT GetRevisioneById(int idItem)
        {
            RevisioneFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTREVISIONICollection.GetByPrimaryKey(idItem));

                if (toReturn != null)
                {
                    toReturn.Revisore = Converters.ConvertIntoPersonaGiuridica(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(toReturn.IdOrganoRevisore));
                }

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaRevisioniInternal(int idRegistro, RevisioneFDT[] items)
        {
            if (items != null)
            {
                foreach (RevisioneFDT revisione in items)
                {
                    if (revisione.Status >= ObjectStatus.ToHide &&
                        revisione.IdRevisione > 0)
                    {
                        DeleteRevisione(revisione);
                    }
                    else
                    {
                        int idRevisione = revisione.IdRevisione;

                        if (revisione.Status == ObjectStatus.ToInsert ||
                            revisione.Status == ObjectStatus.ToUpdate)
                        {
                            revisione.IdRegistro = idRegistro;
                            RevisioneFDT revisioneSaved = SaveRevisioneInternal(revisione);
                            if (revisioneSaved != null)
                                idRevisione = revisioneSaved.IdRevisione;
                        }

                        if (idRevisione > 0)
                        {
                            if (revisione.Documentazioni != null && revisione.Documentazioni.Length > 0)
                            {
                                foreach (DocumentazioneFDT doc in revisione.Documentazioni)
                                {
                                    doc.IdPadre = idRevisione;
                                }
                                SaveListDocumentazione(revisione.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_REVISIONEColumnName);
                            }

                            //Salva incarichi
                            SaveListaIncarichiInternal(idRevisione, revisione.RevisioniIncarichi);

                            //Salva liquidazione
                            SaveListaLiqCompensoInternal("GVCTINCARICHI", idRevisione, revisione.Liquidazioni);
                        }
                    }
                }
            }

            return true;
        }

        internal RevisioneFDT SaveRevisioneInternal(RevisioneFDT item)
        {
            RevisioneFDT toReturn = null;

            if (item != null)
            {
                GVCTREVISIONI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdRevisione > 0)
                {
                    if (GVCDB.GVCTREVISIONICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTREVISIONICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the revisione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteRevisione(RevisioneFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdRevisione > 0)
                {
                    GVCTREVISIONI itemTmp = new GVCTREVISIONI();
                    itemTmp.IDOBJ = item.IdRevisione;

                    toReturn = GVCDB.GVCTREVISIONICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Revisioni

        #region Incarichi Revisione

        internal RevisioneIncaricoFDT[] GetIncarichiInternal(int idRevisione)
        {
            RevisioneIncaricoFDT[] toReturn = null;

            if (idRevisione != null)
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTINCARICHICollection.GetByIDOBJ_REVISIONE(idRevisione));

                if (toReturn != null && toReturn.Length > 0)
                {
                    foreach (RevisioneIncaricoFDT incarico in toReturn)
                    {
                        //Compenso
                        CompensoFDT[] listCompensi = GetCompensiInternal("GVCTINCARICHI", incarico.IdRevisioneIncarico);

                        if (listCompensi != null && listCompensi.Length > 0)
                            incarico.CompensoRevisore = listCompensi[0];
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list incarichi by id revisione.
        /// </summary>
        /// <param name="idRevisione">The id revisione.</param>
        /// <returns></returns>
        public RevisioneIncaricoFDT[] GetListIncarichiByIdRevisione(int idRevisione)
        {
            RevisioneIncaricoFDT[] toReturn = null;

            try
            {
                toReturn = GetIncarichiInternal(idRevisione);
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the incarico by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public RevisioneIncaricoFDT GetIncaricoById(int idItem)
        {
            RevisioneIncaricoFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCTINCARICHICollection.GetByPrimaryKey(idItem));
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaIncarichiInternal(int idRevisione, RevisioneIncaricoFDT[] items)
        {
            if (items != null)
            {
                foreach (RevisioneIncaricoFDT incarico in items)
                {
                    if (incarico.Status >= ObjectStatus.ToHide &&
                        incarico.IdRevisioneIncarico > 0)
                    {
                        DeleteIncarico(incarico);
                    }
                    else
                    {
                        int idIncarico = incarico.IdRevisioneIncarico;

                        if (incarico.Status == ObjectStatus.ToInsert ||
                            incarico.Status == ObjectStatus.ToUpdate)
                        {
                            incarico.IdRevisione = idRevisione;
                            RevisioneIncaricoFDT incaricoSaved = SaveIncaricoInternal(incarico);
                            if (incaricoSaved != null)
                                idIncarico = incaricoSaved.IdRevisioneIncarico;
                        }

                        if (idIncarico > 0)
                        {
                            //Salva compenso
                            incarico.CompensoRevisore.IdIncarico = idIncarico;
                            SaveCompensoInternal(incarico.CompensoRevisore);
                        }
                    }
                }
            }

            return true;
        }

        internal RevisioneIncaricoFDT SaveIncaricoInternal(RevisioneIncaricoFDT item)
        {
            RevisioneIncaricoFDT toReturn = null;

            if (item != null)
            {
                GVCTINCARICHI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdRevisioneIncarico > 0)
                {
                    if (GVCDB.GVCTINCARICHICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTINCARICHICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the incarico.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteIncarico(RevisioneIncaricoFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdRevisione > 0)
                {
                    GVCTINCARICHI itemTmp = new GVCTINCARICHI();
                    itemTmp.IDOBJ = item.IdRevisioneIncarico;

                    toReturn = GVCDB.GVCTINCARICHICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Incarichi Revisione

        #region Compensi Revisori

        internal CompensoFDT[] GetCompensiInternal(String tabellaPadre, int idPadre)
        {
            CompensoFDT[] listToReturn = null;

            switch (tabellaPadre)
            {
                case "GVCTINCARICHI" :
                    listToReturn =
               Converters.ConvertAll(GVCDB.GVCTCOMPENSICollection.GetByIDOBJ_INCARICO(idPadre));
                        break;

                case "GVCTPROCEDURE_COATTE":
                        listToReturn =
                   Converters.ConvertAll(GVCDB.GVCTCOMPENSICollection.GetByIDOBJ_PROCEDURA(idPadre));
                        break;

                case "GVCTLIQUIDAZIONI_COATTE":
                        listToReturn =
                   Converters.ConvertAll(GVCDB.GVCTCOMPENSICollection.GetByIDOBJ_LIQUIDAZIONE(idPadre));
                        break;
            }

            if (listToReturn != null && listToReturn.Length > 0)
            {
                foreach (CompensoFDT compenso in listToReturn)
                {
                    GVCTSOGGETTI soggRevisore = GetSoggettoByID(compenso.IdRevisore);
                    if (soggRevisore != null)
                    {
                        if (soggRevisore.FLAG_PF == 1)
                        {
                            compenso.Revisore = Converters.ConvertIntoPersonaFisica(soggRevisore) as SoggettoFDT;
                        }
                        else
                        {
                            compenso.Revisore = Converters.ConvertIntoPersonaGiuridica(soggRevisore) as SoggettoFDT;
                        }
                    }
                    else
                    {
                        compenso.Revisore = null;
                    }
                }
            }

            return listToReturn;
        }

        internal Boolean SaveListaCompensiInternal(String tabellaPadre, int idPadre, CompensoFDT[] items)
        {
            if (items != null)
            {
                foreach (CompensoFDT compenso in items)
                {
                    if (compenso.Status == ObjectStatus.ToInsert ||
                      compenso.Status == ObjectStatus.ToUpdate)
                    {
                        switch (tabellaPadre)
                        {
                            case "GVCTINCARICHI":
                                compenso.IdIncarico = idPadre;
                                break;

                            case "GVCTPROCEDURE_COATTE":
                                compenso.IdProcedura = idPadre;
                                break;

                            case "GVCTLIQUIDAZIONI_COATTE":
                                compenso.IdLiquidazione = idPadre;
                                break;
                        }

                        SaveCompensoInternal(compenso);
                    }
                    else if (compenso.Status >= ObjectStatus.ToHide &&
                             compenso.IdCompenso > 0)
                    {
                        DeleteCompenso(compenso);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Gets the compenso by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public CompensoFDT GetCompensoById(int idItem)
        {
            CompensoFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCTCOMPENSICollection.GetByPrimaryKey(idItem));

                if (toReturn != null)
                {
                    GVCTSOGGETTI soggRevisore = GetSoggettoByID(toReturn.IdRevisore);
                    if (soggRevisore.FLAG_PF == 1)
                    {
                        toReturn.Revisore = Converters.ConvertIntoPersonaFisica(soggRevisore) as SoggettoFDT;
                    }
                    else
                    {
                        toReturn.Revisore = Converters.ConvertIntoPersonaGiuridica(soggRevisore) as SoggettoFDT;
                    }
                }
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal CompensoFDT SaveCompensoInternal(CompensoFDT item)
        {
            CompensoFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.Revisore, item.IdRevisore);
                if (idSoggettoFK > 0)
                    item.IdRevisore = idSoggettoFK;
                #endregion Salvataggio del soggetto contenuto nell'oggetto

                GVCTCOMPENSI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdCompenso > 0)
                {
                    if (GVCDB.GVCTCOMPENSICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTCOMPENSICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the compenso.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteCompenso(CompensoFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdCompenso > 0)
                {
                    GVCTCOMPENSI itemTmp = new GVCTCOMPENSI();
                    itemTmp.IDOBJ = item.IdCompenso;

                    toReturn = GVCDB.GVCTCOMPENSICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Compensi Revisori

        #region Liquidazione Revisori

        /// <summary>
        /// Gets the list liq compensi by id revisione.
        /// </summary>
        /// <param name="idRevisione">The id revisione.</param>
        /// <returns></returns>
        public CompensoLiquidazioneFDT[] GetListLiqCompensiByIdRevisione(int idRevisione)
        {
            CompensoLiquidazioneFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.GetByIDOBJ_REVISIONE(idRevisione));
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the liq compenso by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public CompensoLiquidazioneFDT GetLiqCompensoById(int idItem)
        {
            CompensoLiquidazioneFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.GetByPrimaryKey(idItem));
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaLiqCompensoInternal(String tabellaPadre, int idPadre, CompensoLiquidazioneFDT[] items)
        {
            if (items != null)
            {
                foreach (CompensoLiquidazioneFDT liquidazione in items)
                {
                    if (liquidazione.Status == ObjectStatus.ToInsert ||
                      liquidazione.Status == ObjectStatus.ToUpdate)
                    {
                        switch (tabellaPadre)
                        {
                            case "GVCTINCARICHI":
                                liquidazione.IdRevisione = idPadre;
                                break;

                            case "GVCTPROCEDURE_COATTE":
                                liquidazione.IdProcedura = idPadre;
                                break;

                            case "GVCTLIQUIDAZIONI_COATTE":
                                liquidazione.IdLiquidazione = idPadre;
                                break;
                        }
                        
                        SaveLiqCompensoInternal(liquidazione);
                    }
                    else if (liquidazione.Status >= ObjectStatus.ToHide &&
                             liquidazione.IdCompensoLiquidazione > 0)
                    {
                        DeleteLiqCompenso(liquidazione);
                    }
                }
            }

            return true;
        }

        internal CompensoLiquidazioneFDT SaveLiqCompensoInternal(CompensoLiquidazioneFDT item)
        {
            CompensoLiquidazioneFDT toReturn = null;

            if (item != null)
            {
                GVCTLIQUIDAZIONE_COMPENSI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdCompensoLiquidazione > 0)
                {
                    if (GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the liq compenso.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteLiqCompenso(CompensoLiquidazioneFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdCompensoLiquidazione > 0)
                {
                    GVCTLIQUIDAZIONE_COMPENSI itemTmp = new GVCTLIQUIDAZIONE_COMPENSI();
                    itemTmp.IDOBJ = item.IdCompensoLiquidazione;

                    toReturn = GVCDB.GVCTLIQUIDAZIONE_COMPENSICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Liquidazione Revisori

        #region Assemblea

        internal DeliberaAssembleaFDT[] GetAssembleeInternal(int idRegistro)
        {
            DeliberaAssembleaFDT[] toReturn = null;

            if (idRegistro > 0)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCTDELIBERE_ASSEMBLEACollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null && toReturn.Length > 0)
                {
                    SetDocumentazioni(toReturn, "IdDeliberaAssemblea", GVCTDOCUMENTAZIONECollection.IDOBJ_ASSEMBLEAColumnName);

                    foreach (DeliberaAssembleaFDT item in toReturn)
                    {
                        item.AttiIntegrativi = Converters.ConvertAll(GVCDB.GVCRATTI_INTEGRATIVICollection.GetByIDOBJ_ASSEMBLEA(item.IdDeliberaAssemblea));
                        item.ModificheStatutarie = GetListModificheStatutarieByIdDeliberaAssemblea(item.IdDeliberaAssemblea);
                        item.Notaio = Converters.ConvertIntoPersonaFisica(GetSoggettoByID(item.IdNotaio));
                    }
                }
            }

            return toReturn;
        }

        public DeliberaAssembleaFDT[] GetListAssembleeByIdRegistro(int idRegistro)
        {
            DeliberaAssembleaFDT[] toReturn = null;

            try
            {
                toReturn = GetAssembleeInternal(idRegistro);
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the assemblea by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public DeliberaAssembleaFDT GetAssembleaById(int idItem)
        {
            DeliberaAssembleaFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTDELIBERE_ASSEMBLEACollection.GetByPrimaryKey(idItem));

                if (toReturn != null)
                {
                    toReturn.AttiIntegrativi = Converters.ConvertAll(GVCDB.GVCRATTI_INTEGRATIVICollection.GetByIDOBJ_ASSEMBLEA(toReturn.IdDeliberaAssemblea));
                    toReturn.ModificheStatutarie = Converters.ConvertAll(GVCDB.GVCTMODIFICHE_STATUTARIECollection.GetByIDOBJ_ASSEMBLEA(toReturn.IdDeliberaAssemblea));
                    toReturn.Notaio = Converters.ConvertIntoPersonaFisica(GetSoggettoByID(toReturn.IdNotaio));
                }
            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaAssembleeInternal(int idRegistro, DeliberaAssembleaFDT[] items)
        {
            if (items != null)
            {
                foreach (DeliberaAssembleaFDT assemblea in items)
                {
                    if (assemblea.Status >= ObjectStatus.ToHide &&
                        assemblea.IdDeliberaAssemblea > 0)
                    {
                        DeleteAssemblea(assemblea);
                    }
                    else
                    {
                        int idAssemblea = assemblea.IdDeliberaAssemblea;

                        if (assemblea.Status == ObjectStatus.ToInsert ||
                            assemblea.Status == ObjectStatus.ToUpdate)
                        {
                            assemblea.IdRegistro = idRegistro;
                            DeliberaAssembleaFDT assembleaSaved = SaveAssembleaInternal(assemblea);
                            if (assembleaSaved != null)
                                idAssemblea = assembleaSaved.IdDeliberaAssemblea;
                        }

                        if (idAssemblea > 0)
                        {
                            if (assemblea.Documentazioni != null && assemblea.Documentazioni.Length > 0)
                            {
                                foreach (DocumentazioneFDT doc in assemblea.Documentazioni)
                                {
                                    doc.IdPadre = idAssemblea;
                                }
                                SaveListDocumentazione(assemblea.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_ASSEMBLEAColumnName);
                            }

                            //Salva Modifiche statutarie
                            SaveListaModificheStatutarieInternal(idAssemblea, assemblea.ModificheStatutarie);
                            //Salva Atti integrativi
                            SaveListaAttiIntInternal(idAssemblea, assemblea.AttiIntegrativi);
                        }
                    }
                }
            }

            return true;
        }

        internal DeliberaAssembleaFDT SaveAssembleaInternal(DeliberaAssembleaFDT item)
        {
            DeliberaAssembleaFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.Notaio, item.IdNotaio);
                if (idSoggettoFK > 0)
                    item.IdNotaio = idSoggettoFK;
                #endregion Salvataggio del soggetto contenuto nell'oggetto


                GVCTDELIBERE_ASSEMBLEA itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdDeliberaAssemblea > 0)
                {
                    if (GVCDB.GVCTDELIBERE_ASSEMBLEACollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCTDELIBERE_ASSEMBLEACollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        public DeliberaAssembleaFDT SaveAssemblea(DeliberaAssembleaFDT item)
        {
            DeliberaAssembleaFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                toReturn = SaveAssembleaInternal(item);

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public Boolean DeleteAssemblea(DeliberaAssembleaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdDeliberaAssemblea > 0)
                {
                    GVCTDELIBERE_ASSEMBLEA assTmp = new GVCTDELIBERE_ASSEMBLEA();
                    assTmp.IDOBJ = item.IdDeliberaAssemblea;

                    toReturn = GVCDB.GVCTDELIBERE_ASSEMBLEACollection.Delete(assTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Assemblea

        #region Atti integrativi

        public AttoIntegrativoFDT[] GetListAttiIntByIdAssemblea(int idAssemblea)
        {
            AttoIntegrativoFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCRATTI_INTEGRATIVICollection.GetByIDOBJ_ASSEMBLEA(idAssemblea));
            }
            catch
            {
            }

            return toReturn;
        }

        public AttoIntegrativoFDT GetAttoIntById(int idItem)
        {
            AttoIntegrativoFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCRATTI_INTEGRATIVICollection.GetByPrimaryKey(idItem));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaAttiIntInternal(int idAssemblea, AttoIntegrativoFDT[] items)
        {
            if (items != null)
            {
                foreach (AttoIntegrativoFDT atto in items)
                {
                    if (atto.Status == ObjectStatus.ToInsert ||
                        atto.Status == ObjectStatus.ToUpdate)
                    {
                        atto.IdAssemblea = idAssemblea;
                        SaveAttoIntInternal(atto);
                    }
                    else if (atto.Status >= ObjectStatus.ToHide &&
                             atto.IdAttoIntegrativo > 0)
                    {
                        DeleteAttoInt(atto);
                    }
                }
            }

            return true;
        }

        internal AttoIntegrativoFDT SaveAttoIntInternal(AttoIntegrativoFDT item)
        {
            AttoIntegrativoFDT toReturn = null;

            if (item != null)
            {
                GVCRATTI_INTEGRATIVI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdAttoIntegrativo > 0)
                {
                    if (GVCDB.GVCRATTI_INTEGRATIVICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCRATTI_INTEGRATIVICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        public Boolean DeleteAttoInt(AttoIntegrativoFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdAttoIntegrativo > 0)
                {
                    GVCRATTI_INTEGRATIVI itemTmp = new GVCRATTI_INTEGRATIVI();
                    itemTmp.IDOBJ = item.IdAttoIntegrativo;

                    toReturn = GVCDB.GVCRATTI_INTEGRATIVICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Atti integrativi

        #region ControlloSoci

        public Boolean DeleteNumeroSoci(ControlloNumeroSociFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdRelazione > 0)
                {
                    if (item.Tipo == TipoControlloNumeroSoci.PER_CATEGORIA)
                    {
                        GVCRSOCI_CATEGORIA sc = new GVCRSOCI_CATEGORIA();
                        sc.IDOBJ = item.IdRelazione;
                        toReturn = GVCDB.GVCRSOCI_CATEGORIACollection.Delete(sc);
                    }
                    else
                    {
                        if (item.Tipo == TipoControlloNumeroSoci.PER_FORMAGIURIDICA)
                        {
                            GVCRSOCI_FOG sc = new GVCRSOCI_FOG();
                            sc.IDOBJ = item.IdRelazione;
                            toReturn = GVCDB.GVCRSOCI_FOGCollection.Delete(sc);
                        }
                    }
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public ControlloNumeroSociFDT SaveNumeroSoci(ControlloNumeroSociFDT item)
        {
            ControlloNumeroSociFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.Tipo == TipoControlloNumeroSoci.PER_CATEGORIA)
                    {
                        GVCRSOCI_CATEGORIA sc = Converters.Convert(item) as GVCRSOCI_CATEGORIA;

                        if (sc != null)
                        {
                            if (sc.IDOBJ >= 0)
                            {
                                GVCDB.GVCRSOCI_CATEGORIACollection.Update(sc);
                            }
                            else
                            {
                                GVCDB.GVCRSOCI_CATEGORIACollection.Insert(sc);
                            }
                        }
                        toReturn = Converters.Convert(sc);
                    }
                    else
                    {
                        if (item.Tipo == TipoControlloNumeroSoci.PER_FORMAGIURIDICA)
                        {
                            GVCRSOCI_FOG sc = Converters.Convert(item) as GVCRSOCI_FOG;

                            if (sc != null)
                            {
                                if (sc.IDOBJ >= 0)
                                {
                                    GVCDB.GVCRSOCI_FOGCollection.Update(sc);
                                }
                                else
                                {
                                    GVCDB.GVCRSOCI_FOGCollection.Insert(sc);
                                }
                            }
                            toReturn = Converters.Convert(sc);
                        }

                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public ControlloNumeroSociFDT[] GetAllControlloSoci(int tipo)
        {
            ControlloNumeroSociFDT[] toReturn = null;
            try
            {
                switch (tipo)
                {
                    case TipoControlloNumeroSoci.PER_CATEGORIA:
                        toReturn = Converters.ConvertAll(GVCDB.GVCRSOCI_CATEGORIACollection.GetAll());
                        break;
                    case TipoControlloNumeroSoci.PER_FORMAGIURIDICA:
                        toReturn = Converters.ConvertAll(GVCDB.GVCRSOCI_FOGCollection.GetAll());
                        break;
                    default:
                        toReturn = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public ViolatedRule[] VerifyNumeroSoci(int numeroSoci, int idCategoria, int idFormaGiuridica)
        {
            List<ViolatedRule> violatedRules = new List<ViolatedRule>();
            ControlloNumeroSociFDT[] listaControlli = null;

            try
            {
                listaControlli = GetListControlloSoci(idCategoria, idFormaGiuridica);
            }
            catch
            { }

            if (listaControlli != null &&
                listaControlli.Length > 0)
            {
                foreach (ControlloNumeroSociFDT controllo in listaControlli)
                {
                    if (numeroSoci < controllo.ValMin ||
                        numeroSoci > controllo.ValMax)
                    {
                        violatedRules.Add(new ViolatedRule("",
                                                   "ComunicazioneBaseSocialeFDT",
                                                   "Il numero soci non è corretto",
                                                    DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
                                                    ));
                    }
                }
            }

            return violatedRules.ToArray();
        }

        internal ControlloNumeroSociFDT[] GetListControlloSoci(int idCategoria, int idFormaGiuridica)
        {
            List<ControlloNumeroSociFDT> listControlli = new List<ControlloNumeroSociFDT>();
            ControlloNumeroSociFDT[] toReturn = null;

            ControlloNumeroSociFDT[] listCategoria = null;
            ControlloNumeroSociFDT[] listFormaGiuridica = null;

            if (idCategoria > 0)
            {
                listCategoria = Converters.ConvertAll(GVCDB.GVCRSOCI_CATEGORIACollection.GetByIDOBJ_CATEGORIA(idCategoria));

                if (listCategoria != null && listCategoria.Length > 0)
                {
                    listControlli.Add(listCategoria[0]);
                }
            }
            if (idFormaGiuridica > 0)
            {
                listFormaGiuridica = Converters.ConvertAll(GVCDB.GVCRSOCI_FOGCollection.GetByIDOBJ_FORMA_GIURIDICA(idFormaGiuridica));

                if (listFormaGiuridica != null && listFormaGiuridica.Length > 0)
                {
                    listControlli.Add(listFormaGiuridica[0]);
                }
            }
         
            if (listControlli.Count > 0)
            {
                toReturn = listControlli.ToArray();
            }

            return toReturn;
        }

        #endregion ControlloSoci

        #region Dati

        public DatiFDT GetDati()
        {
            DatiFDT toReturn = null;
            DatiFDT[] listDati = null;

            try
            {
                listDati =
                    Converters.ConvertAll(GVCDB.GVCDDATICollection.GetAll());
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            if (listDati != null &&
                listDati.Length > 0)
            {
                toReturn = listDati[0];
            }

            return toReturn;
        }

        public DatiFDT SaveDati(DatiFDT item)
        {
            DatiFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    GVCDDATI itemConverted = Converters.Convert(item);

                    if (item.IdItem > 0)
                    {
                        if (GVCDB.GVCDDATICollection.Update(itemConverted))
                        {
                            toReturn = item;
                        }
                    }
                    else
                    {
                        GVCDB.GVCDDATICollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ >= 0)
                        {
                            toReturn = Converters.Convert(itemConverted);
                        }
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public Boolean DeleteDati(DatiFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.IdItem >= 0)
                    {
                        toReturn = GVCDB.GVCDDATICollection.DeleteByPrimaryKey(item.IdItem);
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public LeggiTrasgressioneFDT[] GetLeggiSanzioni()
        {          
            LeggiTrasgressioneFDT[] listDati = null;

            try
            {
                listDati =
                    Converters.ConvertAll(GVCDB.GVCDLEGGI_TRASGRESSIONECollection.GetAll());
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return listDati;
        }

        public LeggiTrasgressioneFDT GetLeggeSanzioniById(int idItem)
        {
            LeggiTrasgressioneFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCDLEGGI_TRASGRESSIONECollection.GetByPrimaryKey(idItem));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public LeggiTrasgressioneFDT SaveLeggi(LeggiTrasgressioneFDT item)
        {
            LeggiTrasgressioneFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    GVCDLEGGI_TRASGRESSIONE itemConverted = Converters.Convert(item);

                    if (item.IdElemento > 0)
                    {
                        if (GVCDB.GVCDLEGGI_TRASGRESSIONECollection.Update(itemConverted))
                        {
                            toReturn = item;
                        }
                    }
                    else
                    {
                        GVCDB.GVCDLEGGI_TRASGRESSIONECollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ >= 0)
                        {
                            toReturn = Converters.Convert(itemConverted);
                        }
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public Boolean DeleteLeggi(LeggiTrasgressioneFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.IdElemento >= 0)
                    {
                        toReturn = GVCDB.GVCDLEGGI_TRASGRESSIONECollection.DeleteByPrimaryKey(item.IdElemento);
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Dati

        #region Cartelle

        public CartellaFDT[] GetCartelle()
        {
            CartellaFDT[] toReturn = null;
            
            try
            {
                toReturn =
                    Converters.ConvertAll(GVCDB.GVCDCARTELLECollection.GetAll());
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CartellaFDT GetCartellaById(int idItem)
        {
            CartellaFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCDCARTELLECollection.GetByPrimaryKey(idItem));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CartellaFDT SaveCartella(CartellaFDT item)
        {
            CartellaFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    GVCDCARTELLE itemConverted = Converters.Convert(item);

                    if (item.IdElemento > 0)
                    {
                        if (GVCDB.GVCDCARTELLECollection.Update(itemConverted))
                        {
                            toReturn = item;
                        }
                    }
                    else
                    {
                        GVCDB.GVCDCARTELLECollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ >= 0)
                        {
                            toReturn = Converters.Convert(itemConverted);
                        }
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public Boolean DeleteCartella(CartellaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.IdElemento >= 0)
                    {
                        toReturn = GVCDB.GVCDCARTELLECollection.DeleteByPrimaryKey(item.IdElemento);
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion
        
        #region Storico Dati

        /// <summary>
        /// Gets the list dati storici registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public DatiStoriciFDT[] GetListDatiStoriciRegistro(int idRegistro)
        {
            DatiStoriciFDT[] toReturn = null;
            
            try
            {
                toReturn =
                    Converters.ConvertAll(GVCDB.GVCTSTORICO_REGISTROCollection.GetByIDOBJ_REGISTRO(idRegistro));
            }
            catch
            {
                
                //log
                //throw
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the list dati storici registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public DatiStoriciFDT[] GetListDatiStoriciAssemblea(int idAssemblea)
        {
            DatiStoriciFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(GVCDB.GVCTSTORICO_ASSEMBLEACollection.GetByIDOBJ_ASSEMBLEA(idAssemblea));
            }
            catch
            {

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Storico Dati

        #region Societa collegate

        internal Boolean SaveListaSocCollInternal(int idModificaStat, CollegamentoSocietaFDT[] items)
        {
            if (items != null)
            {
                foreach (CollegamentoSocietaFDT collegamento in items)
                {
                    if (collegamento.Status == ObjectStatus.ToInsert ||
                        collegamento.Status == ObjectStatus.ToUpdate)
                    {
                        collegamento.IdModificaStatutaria = idModificaStat;
                        SaveSocCollInternal(collegamento);
                    }
                    else if (collegamento.Status >= ObjectStatus.ToHide &&
                        collegamento.IdCollegamento > 0)
                    {
                        DeleteSocColl(collegamento);
                    }

                }
            }

            return true;
        }

        internal CollegamentoSocietaFDT SaveSocCollInternal(CollegamentoSocietaFDT item)
        {
            CollegamentoSocietaFDT toReturn = null;

            if (item != null)
            {
                #region Salvataggio del soggetto contenuto nell'oggetto
                // se nella maschera si è ricercato un soggetto, non c'era ed è quindi stato aggiunto
                // non lo si trova con l'id e dunque si salva prima il soggetto e poi si aggiunge l'id
                // nel campo apposito
                int idSoggettoFK = SaveSoggettoConditional(item.Societa, item.IdSoggetto);
                if (idSoggettoFK > 0)
                    item.IdSoggetto = idSoggettoFK;
                #endregion Salvataggio del soggetto contenuto nell'oggetto

                GVCRSOCIETA_COLLEGATE itemConverted = Converters.Convert(item);

                if (item.IdCollegamento > 0)
                {
                    if (GVCDB.GVCRSOCIETA_COLLEGATECollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCRSOCIETA_COLLEGATECollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        internal CollegamentoSocietaFDT[] GetSocCollInternal(int idModificaStat)
        {
            CollegamentoSocietaFDT[] toReturn = null;

            if (idModificaStat != null)
            {
                toReturn =
                       Converters.ConvertAll(
                           GVCDB.GVCRSOCIETA_COLLEGATECollection.GetByIDOBJ_MODIFICA_STATUTARIA(idModificaStat));

                if (toReturn != null && toReturn.Length > 0)
                {
                    foreach (CollegamentoSocietaFDT coll in toReturn)
                    {
                        coll.Societa = Converters.ConvertIntoPersonaGiuridica(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(coll.IdSoggetto));
                    }
                }
            }

            return toReturn;
        }

        public Boolean DeleteSocColl(CollegamentoSocietaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdCollegamento > 0)
                {
                    GVCRSOCIETA_COLLEGATE itemTmp = new GVCRSOCIETA_COLLEGATE();
                    itemTmp.IDOBJ = item.IdCollegamento;

                    toReturn = GVCDB.GVCRSOCIETA_COLLEGATECollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Societa collegate

        #region Procedimenti

        /// <summary>
        /// Gets the list procedimenti id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public ProcedimentoFDT[] GetListProcedimentiIdRegistro(int idRegistro)
        {
            ProcedimentoFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTPROCEDIMENTICollection.GetByIDOBJ_REGISTRO(idRegistro));
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the procedimento by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public ProcedimentoFDT GetProcedimentoById(int idItem)
        {
            ProcedimentoFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTPROCEDIMENTICollection.GetByPrimaryKey(idItem));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaProcedimentiInternal(int idRegistro, ProcedimentoFDT[] items)
        {
            if (items != null)
            {
                foreach (ProcedimentoFDT proc in items)
                {
                    if (proc.Status == ObjectStatus.ToInsert ||
                        proc.Status == ObjectStatus.ToUpdate)
                    {
                        proc.IdRegistro = idRegistro;
                        SaveProcedimentoInternal(proc);
                    }
                    else if (proc.Status >= ObjectStatus.ToHide &&
                             proc.IdProcedimento > 0)
                    {
                        DeleteProcedimento(proc);
                    }
                }
            }

            return true;
        }

        internal ProcedimentoFDT SaveProcedimentoInternal(ProcedimentoFDT item)
        {
            ProcedimentoFDT toReturn = null;

            if (item != null)
            {
                GVCTPROCEDIMENTI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdProcedimento > 0)
                {
                    if (GVCDB.GVCTPROCEDIMENTICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTPROCEDIMENTICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the procedimento.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteProcedimento(ProcedimentoFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdProcedimento > 0)
                {
                    GVCTPROCEDIMENTI itemTmp = new GVCTPROCEDIMENTI();
                    itemTmp.IDOBJ = item.IdProcedimento;

                    toReturn = GVCDB.GVCTPROCEDIMENTICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Procedimenti

        #region Bilanci

        /// <summary>
        /// Gets the list bilanci id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public BilancioFDT[] GetListBilanciIdRegistro(int idRegistro)
        {
            BilancioFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTBILANCICollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null)
                {
                    SetDocumentazioni(toReturn, "IdBilancio", GVCTDOCUMENTAZIONECollection.IDOBJ_BILANCIOColumnName);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the bilancio by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public BilancioFDT GetBilancioById(int idItem)
        {
            BilancioFDT toReturn = null;
            try
            {
                toReturn =
                    Converters.Convert(GVCDB.GVCTBILANCICollection.GetByPrimaryKey(idItem));

            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        internal Boolean SaveListaBilanciInternal(int idRegistro, BilancioFDT[] items)
        {
            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }
                if (items != null)
                {
                    foreach (BilancioFDT bil in items)
                    {
                        if (bil.Status >= ObjectStatus.ToHide &&
                                 bil.IdBilancio > 0)
                        {
                            DeleteBilancio(bil);
                        }
                        else
                        {
                            int idBilancio = bil.IdBilancio;
                            DocumentazioneFDT[] listDoc = bil.Documentazioni;

                            if (bil.Status == ObjectStatus.ToInsert ||
                                bil.Status == ObjectStatus.ToUpdate)
                            {
                                bil.IdRegistro = idRegistro;
                                BilancioFDT bilSaved = SaveBilancioInternal(bil);

                                if (bilSaved != null)
                                    idBilancio = bil.IdBilancio;
                            }

                            if (idBilancio >= 0)
                            {
                                if (listDoc != null && listDoc.Length > 0)
                                {
                                    foreach (DocumentazioneFDT doc in listDoc)
                                    {
                                        doc.IdPadre = idBilancio;
                                    }
                                    SaveListDocumentazione(bil.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_BILANCIOColumnName);
                                }
                            }
                        }
                    }
                }
                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return true;
        }

        internal BilancioFDT SaveBilancioInternal(BilancioFDT item)
        {
            BilancioFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    GVCTBILANCI itemConverted = Converters.Convert(item);

                    itemConverted.OPERATOREULTMOD = CallerIdentity;
                    itemConverted.DATAORAULTMOD = DateTime.Now;

                    if (item.IdBilancio > 0)
                    {
                        if (GVCDB.GVCTBILANCICollection.Update(itemConverted))
                        {
                            // update success
                            toReturn = item;
                        }
                        else
                        {
                            //update no success
                        }
                    }
                    else
                    {
                        // perform new insert
                        GVCDB.GVCTBILANCICollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ > 0)
                        {
                            // insert success
                            toReturn = Converters.Convert(itemConverted);
                        }
                        else
                        {
                            // insert no success
                        }
                    }

                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the bilancio.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteBilancio(BilancioFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdBilancio > 0)
                {
                    GVCTBILANCI itemTmp = new GVCTBILANCI();
                    itemTmp.IDOBJ = item.IdBilancio;

                    toReturn = GVCDB.GVCTBILANCICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Bilanci

        #region  Scadenze Annotazioni

        /// <summary>
        /// Gets the list annotazioni id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public ScadenziarioFDT[] GetListAnnotazioniIdRegistro(int idRegistro)
        {
            ScadenziarioFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTANNOTAZIONICollection.GetByIDOBJ_REGISTRO(idRegistro));
            }
            catch
            {
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the annotazione by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public ScadenziarioFDT GetAnnotazioneById(int idItem)
        {
            ScadenziarioFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTANNOTAZIONICollection.GetByPrimaryKey(idItem));

            }
            catch
            {
                //log
                //throw
            }

            return toReturn;
        }

        internal Boolean SaveListaAnnotazioniInternal(int idRegistro, ScadenziarioFDT[] items)
        {
            if (items != null)
            {
                foreach (ScadenziarioFDT scad in items)
                {
                    if (scad.Status == ObjectStatus.ToInsert ||
                        scad.Status == ObjectStatus.ToUpdate)
                    {
                        scad.IdRegistro = idRegistro;
                        SaveAnnotazioneInternal(scad);
                    }
                    else if (scad.Status >= ObjectStatus.ToHide &&
                             scad.IdScadenziario > 0)
                    {
                        DeleteAnnotazione(scad);
                    }
                }
            }

            return true;
        }

        internal ScadenziarioFDT SaveAnnotazioneInternal(ScadenziarioFDT item)
        {
            ScadenziarioFDT toReturn = null;

            if (item != null)
            {
                GVCTANNOTAZIONI itemConverted = Converters.Convert(item);

                itemConverted.OPERATOREULTMOD = CallerIdentity;
                itemConverted.DATAORAULTMOD = DateTime.Now;

                if (item.IdScadenziario > 0)
                {
                    if (GVCDB.GVCTANNOTAZIONICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert
                    GVCDB.GVCTANNOTAZIONICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the annotazione.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteAnnotazione(ScadenziarioFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdScadenziario > 0)
                {
                    GVCTANNOTAZIONI itemTmp = new GVCTANNOTAZIONI();
                    itemTmp.IDOBJ = item.IdScadenziario;

                    toReturn = GVCDB.GVCTANNOTAZIONICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }


        #endregion Scadenze Annotazioni

        #region Sanzioni amministrative

        /// <summary>
        /// Gets the list sanzioni id registro.
        /// </summary>
        /// <param name="idRegistro">The id registro.</param>
        /// <returns></returns>
        public SanzioneFDT[] GetListSanzioniIdRegistro(int idRegistro)
        {
            SanzioneFDT[] toReturn = null;

            try
            {
                toReturn =
                    Converters.ConvertAll(
                        GVCDB.GVCTSANZIONICollection.GetByIDOBJ_REGISTRO(idRegistro));

                if (toReturn != null)
                {
                    SetDocumentazioni(toReturn, "IdSanzione", GVCTDOCUMENTAZIONECollection.IDOBJ_SANZIONEColumnName);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        /// <summary>
        /// Gets the sanzione by id.
        /// </summary>
        /// <param name="idItem">The id item.</param>
        /// <returns></returns>
        public SanzioneFDT GetSanzioneById(int idItem)
        {
            SanzioneFDT toReturn = null;
            try
            {

                toReturn =
                    Converters.Convert(GVCDB.GVCTSANZIONICollection.GetByPrimaryKey(idItem));

            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        internal Boolean SaveListaSanzioniInternal(int idRegistro, SanzioneFDT[] items)
        {
            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }
                if (items != null)
                {
                    foreach (SanzioneFDT sanz in items)
                    {
                        if (sanz.Status >= ObjectStatus.ToHide &&
                                 sanz.IdSanzione > 0)
                        {
                            DeleteSanzione(sanz);
                        }
                        else
                        {
                            int idSanzione = sanz.IdSanzione;
                            DocumentazioneFDT[] listDoc = sanz.Documentazioni;

                            if (sanz.Status == ObjectStatus.ToInsert ||
                                sanz.Status == ObjectStatus.ToUpdate)
                            {
                                sanz.IdRegistro = idRegistro;
                                SanzioneFDT sanzSaved = SaveSanzioneInternal(sanz);

                                if (sanzSaved != null)
                                    idSanzione = sanzSaved.IdSanzione;
                            }

                            if (idSanzione >= 0)
                            {
                                if (listDoc != null && listDoc.Length > 0)
                                {
                                    foreach (DocumentazioneFDT doc in listDoc)
                                    {
                                        doc.IdPadre = idSanzione;
                                    }
                                    SaveListDocumentazione(sanz.Documentazioni, GVCTDOCUMENTAZIONECollection.IDOBJ_SANZIONEColumnName);
                                }
                            }
                        }
                    }
                }
                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return true;
        }

        internal SanzioneFDT SaveSanzioneInternal(SanzioneFDT item)
        {
            SanzioneFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    GVCTSANZIONI itemConverted = Converters.Convert(item);

                    itemConverted.OPERATOREULTMOD = CallerIdentity;
                    itemConverted.DATAORAULTMOD = DateTime.Now;

                    if (item.IdSanzione > 0)
                    {
                        if (GVCDB.GVCTSANZIONICollection.Update(itemConverted))
                        {
                            // update success
                            toReturn = item;
                        }
                        else
                        {
                            //update no success
                        }
                    }
                    else
                    {
                        // perform new insert
                        GVCDB.GVCTSANZIONICollection.Insert(itemConverted);
                        if (itemConverted.IDOBJ > 0)
                        {
                            // insert success
                            toReturn = Converters.Convert(itemConverted);
                        }
                        else
                        {
                            // insert no success
                        }
                    }

                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public Boolean DeleteSanzione(SanzioneFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdSanzione > 0)
                {
                    GVCTSANZIONI itemTmp = new GVCTSANZIONI();
                    itemTmp.IDOBJ = item.IdSanzione;

                    toReturn = GVCDB.GVCTSANZIONICollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Sanzioni amministrative

        internal int SaveNrScioglimentoInternal()
        {
            int numero = -1;
            NumeroScioglimentoFDT scioglimento = null;

            //Prendo ultimo numero salvato
            GVCTSCIOGLIMENTO contatore = GVCDB.GVCTSCIOGLIMENTOCollection.GetByPrimaryKey(1);

            if (contatore != null)
            {
                if (!contatore.IsNRSCIOGLIMENTONull)
                {
                    contatore.NRSCIOGLIMENTO = contatore.NRSCIOGLIMENTO + 1;

                    if (GVCDB.GVCTSCIOGLIMENTOCollection.Update(contatore))
                    {
                        // update success
                        scioglimento = Converters.Convert(contatore);
                    }
                    else
                    {
                        //update no success
                    }
                }
            }

            if (scioglimento != null)
            {
                numero = scioglimento.NrScioglimento;
            }

           return numero;

        }

        private Boolean AlreadyExistsTheCooperative(string taxCode, string ReaNumber)
        {
            Boolean toReturn = false;

            try
            {
                OeF.Utility.Expression query = (OeF.Utility.FieldName)SearchParameters.CODICE_FISCALE
                                    == taxCode | (OeF.Utility.FieldName)SearchParameters.NUMERO_REA == ReaNumber;

                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_FISCALE,
                                               SearchParameters.NUMERO_REA};

                string[] values = new string[] { GVCVRICERCASOGGETTICollection.R_CODICE_FISCALEColumnName,
                                                 GVCVRICERCASOGGETTICollection.R_NUMERO_REAColumnName};

                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCASOGGETTI[] results = GVCDB.GVCVRICERCASOGGETTICollection.GetBySearchParameters(where);
                if (results != null && results.Length > 0)
                    toReturn = true;
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #region Documentazione

        private void SaveListDocumentazione(DocumentazioneFDT[] items, string parameter)
        {
            try
            {
                if (items != null)
                {
                    foreach (DocumentazioneFDT item in items)
                    {
                        if (item.Status >= ObjectStatus.ToHide)
                        {
                            DeleteDocumentazione(item);
                        }
                        else
                        {
                            if (item.Status > ObjectStatus.ToView)
                            {
                                SaveDocumentazione(item, parameter);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
        }

        private Boolean DeleteDocumentazione(DocumentazioneFDT item)
        {
            Boolean toReturn = true;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdDocumentazione > 0)
                {
                    GVCTDOCUMENTAZIONE docTmp = new GVCTDOCUMENTAZIONE();
                    docTmp.IDOBJ = item.IdDocumentazione;

                    toReturn = GVCDB.GVCTDOCUMENTAZIONECollection.Delete(docTmp);
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }


        private void SaveDocumentazione(DocumentazioneFDT item, string parameter)
        {
            try
            {
                if (item != null)
                {
                    GVCTDOCUMENTAZIONE itemConverted = Converters.Convert(item, parameter);
                    if (itemConverted != null)
                    {
                        if (item.IdDocumentazione <= 0)
                        {
                            GVCDB.GVCTDOCUMENTAZIONECollection.Insert(itemConverted);
                        }
                        else
                        {
                            GVCDB.GVCTDOCUMENTAZIONECollection.Update(itemConverted);
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
        }

        private void SetDocumentazioni(object[] objects, string idobj_name,string columnName)
        {
            if (objects != null && objects.Length > 0)
            {
                OeF.Utility.Expression query =
                    new OeF.Utility.Expression((OeF.Utility.FieldName)columnName,
                                        OeF.Utility.Operators.IsNot,
                                        DBNull.Value);

                Type type = objects[0].GetType();

                #region parameter replacement

                string[] tags = new string[] { GVCTDOCUMENTAZIONECollection.IDOBJ_ADESIONEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_ASSEMBLEAColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_BASE_SOCIALEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_BILANCIOColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_CARICHEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_FALLIMENTOColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_LIQUIDAZIONEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_PROCEDURAColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_REGISTROColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_REVISIONEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_SANZIONEColumnName};
                string[] values = new string[]  { GVCTDOCUMENTAZIONECollection.IDOBJ_ADESIONEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_ASSEMBLEAColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_BASE_SOCIALEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_BILANCIOColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_CARICHEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_FALLIMENTOColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_LIQUIDAZIONEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_PROCEDURAColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_REGISTROColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_REVISIONEColumnName,
                                            GVCTDOCUMENTAZIONECollection.IDOBJ_SANZIONEColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);
                DocumentazioneFDT[] listDoc = Converters.ConvertAll(GVCDB.GVCTDOCUMENTAZIONECollection.GetBySearch(where));
                if (listDoc != null && listDoc.Length > 0)
                {
                    Dictionary<int, List<DocumentazioneFDT>> corrTypeDoc = new Dictionary<int, List<DocumentazioneFDT>>();
                    foreach (DocumentazioneFDT item in listDoc)
                    {
                        List<DocumentazioneFDT> listTemp = new List<DocumentazioneFDT>();
                        if (corrTypeDoc.ContainsKey(item.IdPadre))
                        {
                            listTemp = corrTypeDoc[item.IdPadre];  
                            corrTypeDoc.Remove(item.IdPadre);
                        }
                        listTemp.Add(item);

                        corrTypeDoc.Add(item.IdPadre, listTemp);
                    }

                    System.Reflection.PropertyInfo pInfo = type.GetProperty("Documentazioni");
                    System.Reflection.PropertyInfo pInfoIdObj = type.GetProperty(idobj_name);
                    if (pInfo != null && pInfoIdObj != null)
                    {
                        foreach (object ob in objects)
                        {
                            int idPadre = -1;
                            object idObject = pInfoIdObj.GetValue(ob, null);
                            if (idObject != null && Int32.TryParse(idObject.ToString(), out idPadre))
                            {
                                if (corrTypeDoc.ContainsKey(idPadre))
                                {
                                    pInfo.SetValue(ob, corrTypeDoc[idPadre].ToArray(), null);
                                }
                            }
                        }
                    }
                }
            }
        }

        public Byte[] GetDocumentazioneByID(int idDocumentazione)
        {
            Byte[] toReturn = null;

            try
            {
                if (idDocumentazione >= 0)
                {
                    GVCTDOCUMENTAZIONE item = GVCDB.GVCTDOCUMENTAZIONECollection.GetByPrimaryKey(idDocumentazione);
                    if (item != null && !item.IsTESTONull)
                    {
                        toReturn = item.TESTO;
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }
            return toReturn;
        }

        #endregion Documentazione

        #region Ricerche

        public CooperativaRicercaFDT[] GetAnnotazioniBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.ANNOTAZIONE_DATA_DA,
                                               SearchParameters.ANNOTAZIONE_DATA_A,
                                               SearchParameters.ANNOTAZIONE_ID_TIPO,
                                               SearchParameters.ANNOTAZIONE_DESCRIZIONE, 
                                               SearchParameters.ANNOTAZIONE_FLAG_EVASA,
                                               SearchParameters.ANNOTAZIONE_DATA_SCAD_DA,
                                               SearchParameters.ANNOTAZIONE_DATA_SCAD_A};

                string[] values = new string[] { GVCVRICERCAANNOTAZIONICollection.R_IDOBJColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_DATA_ANNOTAZIONEColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_DATA_ANNOTAZIONEColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_IDOBJ_TIPO_NOTAColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_DESCRIZIONEColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_EVASAColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_DATA_SCADENZAColumnName,
                                                 GVCVRICERCAANNOTAZIONICollection.ANN_DATA_SCADENZAColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCAANNOTAZIONI[] listaRisultati = GVCDB.GVCVRICERCAANNOTAZIONICollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                    indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoAnnotazioni(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetDocumentazioneBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
           CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.DOC_ID_TIPO,
                                               SearchParameters.DOC_TITOLO};

                string[] values = new string[] { GVCVRICERCADOCUMENTAZIONECollection.R_IDOBJColumnName,
                                                 GVCVRICERCADOCUMENTAZIONECollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCADOCUMENTAZIONECollection.DOC_IDOBJ_TIPOColumnName,
                                                 GVCVRICERCADOCUMENTAZIONECollection.DOC_SEGNALIBROColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCADOCUMENTAZIONE[] listaRisultati = GVCDB.GVCVRICERCADOCUMENTAZIONECollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                  indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoDocumentazione(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetFallimentiBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.FALLIMENTO_DATA_SENTENZA,
                                               SearchParameters.FALLIMENTO_STATO,
                                               SearchParameters.FALLIMENTO_CURATORE,
                                               SearchParameters.FALLIMENTO_TRIBUNALE};

                string[] values = new string[] { GVCVRICERCAFALLIMENTICollection.R_IDOBJColumnName,
                                                 GVCVRICERCAFALLIMENTICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAFALLIMENTICollection.FALL_DATA_SENTENZAColumnName,
                                                 GVCVRICERCAFALLIMENTICollection.FALL_ESITOColumnName,
                                                 GVCVRICERCAFALLIMENTICollection.FALL_IDOBJ_CURATOREColumnName,
                                                 GVCVRICERCAFALLIMENTICollection.FALL_TRIBUNALEColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCAFALLIMENTI[] listaRisultati = GVCDB.GVCVRICERCAFALLIMENTICollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                  indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoFallimenti(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetProcedimentiBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.PROC_DATA_DA,
                                               SearchParameters.PROC_DATA_A,
                                               SearchParameters.PROC_TIPO_PROC,
                                               SearchParameters.PROC_TIPO_INIZIATIVA,
                                               SearchParameters.PROC_STATO,
                                               SearchParameters.PROC_DATA_TEORICA_FINE,
                                               SearchParameters.PROC_DATA_CONCLUSIONE};

                string[] values = new string[] { GVCVRICERCAPROCEDIMENTICollection.R_IDOBJColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_DATA_INIZIOColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_DATA_INIZIOColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_IDOBJ_TIPO_PROCEDIMENTOColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_IDOBJ_TIPO_INIZIATIVAColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_STATOColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_DATA_TERMINE_FINEColumnName,
                                                 GVCVRICERCAPROCEDIMENTICollection.PRO_DATA_FINEColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);
                where = where.Replace("'PROC_DATA_CONCLUSIONEName'", GVCVRICERCAPROCEDIMENTICollection.PRO_DATA_FINEColumnName);

                GVCVRICERCAPROCEDIMENTI[] listaRisultati = GVCDB.GVCVRICERCAPROCEDIMENTICollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                 indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoProcedimenti(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetCancellazioniBySearch(OeF.Utility.Expression query)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.CANC_DATA_DETERMINA,
                                               SearchParameters.CANC_DATA_ALBO,
                                               SearchParameters.CANC_DATA_REG,
                                               SearchParameters.CANC_FLAG_ALBO,
                                               SearchParameters.CANC_FLAG_REGCOOP,
                                               SearchParameters.CANC_FLAG_RI};

                string[] values = new string[] { GVCVRICERCACANCELLAZIONICollection.R_IDOBJColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.CANC_DATA_DETERMINAColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.CANC_DATA_CANC_ALBOColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.CANC_DATA_CANC_REGISTROColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.CANC_TIPO_1ColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.CANC_TIPO_2ColumnName,
                                                 GVCVRICERCACANCELLAZIONICollection.CANC_TIPO_3ColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                toReturn = Converters.ConvertAllIntoCancellazioni(
                        GVCDB.GVCVRICERCACANCELLAZIONICollection.GetBySearchParameters(
                             where
                        ));
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetBilanciBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione, int annoBil)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.STATO_ISCRIZIONE,
                                               SearchParameters.BILANCIO_ANNO_DA,
                                               SearchParameters.BILANCIO_ANNO_A,
                                               SearchParameters.BILANCIO_FLAG_SEGNALAZIONE,
                                               SearchParameters.ESENTE_VERSAM_UTILI,
                                               SearchParameters.BILANCIO_FLAG_UTILI, 
                                               SearchParameters.BILANCIO_FLAG_VERIFICA,
                                               SearchParameters.BILANCIO_MUTUALITA,
                                               SearchParameters.BILANCIO_TIPO};

                string[] values = new string[] { GVCVRICERCABILANCICollection.R_IDOBJColumnName,
                                                 GVCVRICERCABILANCICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCABILANCICollection.R_IDOBJ_STATOColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_ANNO_RIFERIMENTOColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_ANNO_RIFERIMENTOColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_DATA_SEGNALAZIONEColumnName,
                                                 GVCVRICERCABILANCICollection.R_ESENTE_VERSAMENTO_UTILIColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_IMPORTO_PERCENTO_UTILIColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_VERIFICA_PAGAMENTOColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_REQUISITO_PREVALENZAColumnName,
                                                 GVCVRICERCABILANCICollection.BIL_IDOBJ_TIPO_BILANCIOColumnName};


                #endregion parameter replacement

                //string getFunction = string.Empty;
                //string getRightValue = string.Empty;
                //InitQuery(query, ref getFunction, ref getRightValue);

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                if (annoBil > 0)
                {
                    if (!String.IsNullOrEmpty(where))
                        where = where + " AND ";

                    where = where + GVCDB.GVCVRICERCABILANCICollection.GetSqlWhereBilancioNotIn(annoBil, TipiBilancio.ESERCIZIO);
                }

                GVCVRICERCABILANCI[] listaRisultati = GVCDB.GVCVRICERCABILANCICollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                //if (!String.IsNullOrEmpty(getFunction) && !String.IsNullOrEmpty(getRightValue))
                //{
                //    listaRisultati = GVCDB.GVCVRICERCABILANCICollection.
                //                                            GetBySearchParameters(where, getFunction, getRightValue);
                //}
                //else
                //{
                //    listaRisultati = GVCDB.GVCVRICERCABILANCICollection.GetBySearchParameters(where);
                //}

                toReturn = Converters.ConvertAllIntoBilanci(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        private void InitQuery(OeF.Utility.Expression query, ref string getFunction, ref string getRightValue)
        {
            if (query.LeftValue is OeF.Utility.Function)
            {
                OeF.Utility.Function f = query.LeftValue as OeF.Utility.Function;
                if (f != null)
                {
                    getFunction = f.Value.ToString();

                    string op = " = ";
                    int v = -1;
                    if (Int32.TryParse( query.RightValue.ToString(), out v))
                    {
                        if (v == 1)
                            op = " >= ";
                    }
                    getRightValue = String.Concat(op,
                                            " ",
                                            query.RightValue.ToString());
                    f.Value = "1";
                }

                query.Operator = OeF.Utility.Operators.Equal;
                query.RightValue = "1";
            }
            else
            {
                if (query.RightValue is OeF.Utility.Expression)
                {
                     InitQuery(((OeF.Utility.Expression)query.RightValue), ref getFunction, ref getRightValue);
                }
                else
                {
                     return;
                }
            }
        }

        public CooperativaRicercaFDT[] GetModificheStatBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.MODSTAT_DATA_ASS_DA,
                                               SearchParameters.MODSTAT_DATA_ASS_A,
                                               SearchParameters.MODSTAT_ID_TIPO_ASS,
                                               SearchParameters.MODSTAT_ID_TIPO_MODIFICA,
                                               SearchParameters.MODSTAT_VECCHIA_DENOMINAZIONE,
                                               SearchParameters.MODSTAT_FLAG_COLL};

                string[] values = new string[] { GVCVRICERCAMODIFICHE_STATCollection.R_IDOBJColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.ASS_DATA_ASSEMBLEAColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.ASS_DATA_ASSEMBLEAColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.ASS_IDOBJ_TIPO_ASSEMBLEAColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.MODSTAT_IDOBJ_TIPO_MODIFICAColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.MODSTAT_VECCHIA_DENOMINAZIONEColumnName,
                                                 GVCVRICERCAMODIFICHE_STATCollection.COLL_IDOBJ_SOGGETTOColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCAMODIFICHE_STAT[] listaRisultati = GVCDB.GVCVRICERCAMODIFICHE_STATCollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoModificheStat(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetRevisioniEffettuateBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.CADENZA_REV,
                                               SearchParameters.REV_ANNO,
                                               SearchParameters.REV_DATA_SCAD,
                                               SearchParameters.REV_ID_INC,
                                               SearchParameters.REV_DATA_CONCLUSIONE,
                                               SearchParameters.REV_DATA_REVOCA_DET,
                                               SearchParameters.REV_DATA_REVOCA_DEL,
                                               SearchParameters.REV_FLAG_LIQUID,
                                               SearchParameters.REV_ID_ESITO,
                                               SearchParameters.REV_ID_ORGANO,
                                               SearchParameters.REV_ID_REVISORE,
                                               SearchParameters.REV_ID_TIPO,
                                               SearchParameters.REV_ID_LIMITI};


                string[] values = new string[] { GVCVRICERCAREV_EFFCollection.R_IDOBJColumnName,
                                                 GVCVRICERCAREV_EFFCollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAREV_EFFCollection.R_IDOBJ_CADENZA_REVISIONEColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_ANNO_REVISIONEColumnName,
                                                 GVCVRICERCAREV_EFFCollection.INC_DATA_SCADENZA_TEORICAColumnName,
                                                 GVCVRICERCAREV_EFFCollection.INC_IDOBJColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_DATA_CONCLUSIONEColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_DATA_DETERMINA_REVOCAColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_DATA_DELIBERA_REVOCAColumnName,
                                                 GVCVRICERCAREV_EFFCollection.LIQ_LIQUIDATOColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_IDOBJ_ESITO_REVISIONEColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_IDOBJ_ORGANO_REVISOREColumnName,
                                                 GVCVRICERCAREV_EFFCollection.COMPENSI_IDOBJ_SOGGETTOColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_IDOBJ_TIPO_REVISIONEColumnName,
                                                 GVCVRICERCAREV_EFFCollection.REV_IDOBJ_LIMITE_COSTOColumnName};

                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                int stringIndexFrom = where.IndexOf(GVCVRICERCAREV_EFFCollection.INC_DATA_SCADENZA_TEORICAColumnName);
                if (stringIndexFrom > -1)
                {
                   

                    int stringIndexTo = stringIndexFrom + GVCVRICERCAREV_EFFCollection.INC_DATA_SCADENZA_TEORICAColumnName.Length + 1;
                    stringIndexFrom -= 6;
                    string whereOriginal = where;
                    where = where.Substring(0, stringIndexFrom);
                    where = String.Concat(where, GVCVRICERCAREV_EFFCollection.INC_DATA_SCADENZA_TEORICAColumnName, whereOriginal.Substring(stringIndexTo));
                }

                GVCVRICERCAREV_EFF[] listaRisultati = GVCDB.GVCVRICERCAREV_EFFCollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoRevisioniEff(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public RevisioneCooperativaFlatFDT[] GetRevisioniDaEffettuareBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            RevisioneCooperativaFlatFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.CADENZA_REV,
                                               SearchParameters.STATO_SOGG_REV,
                                               SearchParameters.DATA_COSTITUZIONE,
                                               SearchParameters.REV_ANNO,
                                               SearchParameters.REV_ID_TIPO};

                string[] values = new string[] { GVCVRICERCAREV_DAEFFCollection.R_IDOBJColumnName,
                                                 GVCVRICERCAREV_DAEFFCollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCAREV_DAEFFCollection.R_IDOBJ_CADENZA_REVISIONEColumnName,
                                                 GVCVRICERCAREV_DAEFFCollection.STATO_FLAG_REVISIONEColumnName,
                                                 GVCVRICERCAREV_DAEFFCollection.R_DATA_COSTITUZIONEColumnName,
                                                 GVCVRICERCAREV_DAEFFCollection.REV_ANNO_REVISIONEColumnName,
                                                 GVCVRICERCAREV_DAEFFCollection.REV_IDOBJ_TIPO_REVISIONEColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCAREV_DAEFF[] listaRisultati = GVCDB.GVCVRICERCAREV_DAEFFCollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
               indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoRevisioniDaEffFlat(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public CooperativaRicercaFDT[] GetSanzioniBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione)
        {
            CooperativaRicercaFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.CODICE_COOPERATIVA, 
                                               SearchParameters.NUMERO_REA,
                                               SearchParameters.SANZ_DATA_RILIEVO,
                                               SearchParameters.SANZ_DATA_OBLAZIONE,
                                               SearchParameters.SANZ_DATA_RICORSO};

                string[] values = new string[] { GVCVRICERCASANZIONICollection.R_IDOBJColumnName,
                                                 GVCVRICERCASANZIONICollection.R_NUMERO_REAColumnName,
                                                 GVCVRICERCASANZIONICollection.SAN_DATA_RILIEVO_INFRAZIONEColumnName,
                                                 GVCVRICERCASANZIONICollection.SAN_DATA_PAG_OBLAZIONEColumnName,
                                                 GVCVRICERCASANZIONICollection.SAN_DATA_RICORSOColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);

                GVCVRICERCASANZIONI[] listaRisultati = GVCDB.GVCVRICERCASANZIONICollection.GetBySearchParameters(where);
                if (indexAdesione > 0 ||
                indexIscrizione > 0)
                {
                    listaRisultati = GVCDB.SearchCooperative.GetAderentiIscritte(listaRisultati, dataRifIscrizione, DataRifAdesione, indexIscrizione, indexAdesione, idAssociazione);
                }
                toReturn = Converters.ConvertAllIntoSanzioni(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Ricerche

        #region Locks

        public LockFDT[] GetListLocks()
        {
            LockFDT[] toReturn = null;

            try
            {
                toReturn = Converters.ConvertAll(GVCDB.GVCTLOCKCollection.GetAll());
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        public LockFDT SaveLock(LockFDT item)
        {
            LockFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.IdLock > 0)
                    {
                        // strano non dovrei essere qui
                    }
                    else
                    {
                        GVCTLOCK itemConverted = Converters.Convert(item);
                        GVCDB.GVCTLOCKCollection.Insert(itemConverted);

                        if (itemConverted.IDOBJ > 0)
                        {
                            item.IdLock = itemConverted.IDOBJ;
                            toReturn = item;
                        }
                        else
                        {
                            throw new Exception("L'inserimento non ha generato l'idObj");
                        }
                    }
                    
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
            }

            return toReturn;
        }

        public Boolean Unlock(LockFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;
            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null)
                {
                    if (item.IdLock <= 0)
                    {
                        GVCTLOCK itemRet = 
                                GVCDB.GVCTLOCKCollection.GetLockByEntityTypeAndStatus(
                                                    item.IdEntity, item.IdEntityType, item.Status);
                        if (itemRet != null)
                        {
                            if (itemRet.IDOBJ > 0)
                            {
                                item.IdLock = itemRet.IDOBJ;
                            }
                        }
                    }

                    if (item.IdLock > 0)
                    {
                        toReturn = GVCDB.GVCTLOCKCollection.DeleteByPrimaryKey(item.IdLock);
                    }
                }

                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch (Exception ex)
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Locks

        #region Gruppi Paritetico

        internal GruppoPariteticoFDT[] GetListGruppiPariteticiByidSoggetto(int idSoggetto)
        {
            GVCRSOCIETA_GRUPPO[] elencoGruppi = null;
            List<GruppoPariteticoFDT> gruppiApp = new List<GruppoPariteticoFDT>();

            try
            {
                elencoGruppi = GVCDB.GVCRSOCIETA_GRUPPOCollection.GetByIDOBJ_SOGGETTO(idSoggetto);

                if (elencoGruppi != null &&
                    elencoGruppi.Length > 0)
                {
                    foreach (GVCRSOCIETA_GRUPPO item in elencoGruppi)
                    {
                        GruppoPariteticoFDT gruppo = Converters.Convert(
                            GVCDB.GVCDGRUPPI_PARITETICICollection.GetByPrimaryKey(item.IDOBJ_GRUPPO));

                        if (gruppo != null)
                            gruppiApp.Add(gruppo);

                    }
                }
            }
            catch
            {
            }

            return gruppiApp.ToArray();
        }

        public GruppoPariteticoFDT GetGruppoParitetico(int idGruppo)
        {
            GruppoPariteticoFDT toReturn = null;
            RegistroCooperativaFDT tmp;

            try
            {
                toReturn =
                    Converters.Convert(
                        GVCDB.GVCDGRUPPI_PARITETICICollection.GetByPrimaryKey(idGruppo));
                
                if (toReturn != null)
                {
                    toReturn.Cooperative = Converters.ConvertAllIntoSocietaGruppo(GVCDB.GVCRSOCIETA_GRUPPOCollection.GetByIDOBJ_GRUPPO(idGruppo));

                    for (int i = 0; i < toReturn.Cooperative.Length; i++)
                    {
                        toReturn.Cooperative[i].Denominazione = Converters.ConvertIntoCooperative(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(toReturn.Cooperative[i].IdSoggetto)).Denominazione;
                        toReturn.Cooperative[i].RegistroCooperativa.IdRegistro = Converters.ConvertAll(GVCDB.GVCTREGISTRICollection.GetByIDOBJ_SOGGETTO(toReturn.Cooperative[i].IdSoggetto))[0].IdRegistro;
                    }
                }                                
            }
            catch
            {
            }

            return toReturn;
        }


        internal GruppoPariteticoFDT SaveGruppoPariteticoInternal(GruppoPariteticoFDT item)
        {
            GruppoPariteticoFDT toReturn = null;

            if (item != null)
            {
                GVCDGRUPPI_PARITETICI itemConverted = Converters.Convert(item);

                if (item.IdGruppoParitetico > 0)
                {
                    if (GVCDB.GVCDGRUPPI_PARITETICICollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCDGRUPPI_PARITETICICollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.Convert(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Saves the procedura coatta.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public GruppoPariteticoFDT SaveGruppoParitetico(GruppoPariteticoFDT item)
        {
            GruppoPariteticoFDT toReturn = null;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }
                                                
                toReturn = SaveGruppoPariteticoInternal(item);

                if (toReturn.IdGruppoParitetico > 0)
                {
                    item.IdGruppoParitetico = toReturn.IdGruppoParitetico;
                    SaveListaSocietaGruppoPariteticoInternal(item);

                    item.Cooperative = Converters.ConvertAllIntoSocietaGruppo(GVCDB.GVCRSOCIETA_GRUPPOCollection.GetByIDOBJ_GRUPPO(item.IdGruppoParitetico));

                    for (int i = 0; i < item.Cooperative.Length; i++)
                    {
                        item.Cooperative[i].Denominazione = Converters.ConvertIntoCooperative(GVCDB.GVCTSOGGETTICollection.GetByPrimaryKey(item.Cooperative[i].IdSoggetto)).Denominazione;
                        item.Cooperative[i].RegistroCooperativa.IdRegistro = Converters.ConvertAll(GVCDB.GVCTREGISTRICollection.GetByIDOBJ_SOGGETTO(item.Cooperative[i].IdSoggetto))[0].IdRegistro;
                    }
                }
                                
                if (!isInTransaction)
                {
                    GVCDB.CommitTransaction();
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return item;
        }

        internal Boolean SaveListaGruppoPariteticoInternal(GruppoPariteticoFDT[] items)
        {
            if (items != null)
            {
                foreach (GruppoPariteticoFDT gruppoParitetico in items)
                {
                    if (gruppoParitetico.Status >= ObjectStatus.ToHide &&
                        gruppoParitetico.IdGruppoParitetico > 0)
                    {
                        DeleteGruppoParitetico(gruppoParitetico);
                    }
                    else
                    {
                        int idGruppo = gruppoParitetico.IdGruppoParitetico;

                        if (gruppoParitetico.Status == ObjectStatus.ToInsert ||
                            gruppoParitetico.Status == ObjectStatus.ToUpdate)
                        {
                            GruppoPariteticoFDT gruppoSaved = SaveGruppoPariteticoInternal(gruppoParitetico);
                            if (gruppoSaved != null)
                                idGruppo = gruppoSaved.IdGruppoParitetico;
                        }

                        if (idGruppo > 0)
                        {                                                                              
                            SaveListaSocietaGruppoPariteticoInternal(gruppoParitetico);
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Deletes the procedura coatta.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteGruppoParitetico(GruppoPariteticoFDT item)
        {
            Boolean toReturn = true;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdGruppoParitetico > 0)
                {
                    for (int i = 0; i < item.Cooperative.Length; i++)
                    {
                        if ((toReturn) && (item.Cooperative[i].IdTipoSoggetto > 0))
                        {
                            GVCRSOCIETA_GRUPPO societaGruppoTmp = new GVCRSOCIETA_GRUPPO();
                            societaGruppoTmp.IDOBJ = item.Cooperative[i].IdTipoSoggetto;

                            toReturn = GVCDB.GVCRSOCIETA_GRUPPOCollection.Delete(societaGruppoTmp);
                        }
                    }
                    
                    GVCDGRUPPI_PARITETICI gruppoTmp = new GVCDGRUPPI_PARITETICI();
                    gruppoTmp.IDOBJ = item.IdGruppoParitetico;

                    if (toReturn)
                    {
                        toReturn = GVCDB.GVCDGRUPPI_PARITETICICollection.Delete(gruppoTmp);
                    }
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }
            }

            return toReturn;
        }

        public GruppoPariteticoFDT[] GetListGruppiPariteticiBySearch(OeF.Utility.Expression query)
        {
            GruppoPariteticoFDT[] toReturn = null;

            try
            {
                #region parameter replacement

                string[] tags = new string[] { SearchParameters.GRUPPO_PARITETICO_DATA_ATTO, 
                                               SearchParameters.GRUPPO_PARITETICO_DATA_FINO_AL,
                                               SearchParameters.GRUPPO_PARITETICO_NUMERO_ATTO,
                                               SearchParameters.GRUPPO_PARITETICO_NOTE};

                string[] values = new string[] { GVCDGRUPPI_PARITETICICollection.DATA_ATTOColumnName,
                                                 GVCDGRUPPI_PARITETICICollection.DATA_SCADENZAColumnName,
                                                 GVCDGRUPPI_PARITETICICollection.NUMERO_ATTOColumnName,
                                                 GVCDGRUPPI_PARITETICICollection.DESCRIZIONEColumnName};


                #endregion parameter replacement

                string where = OeF.Utility.QueryBuilder.Get(query, OeF.DBTypes.Oracle, tags, values);
                GVCDGRUPPI_PARITETICI[] listaRisultati = GVCDB.GVCDGRUPPI_PARITETICICollection.GetBySearchParameters(where);
                
                toReturn = Converters.ConvertAll(listaRisultati);
            }
            catch (Exception ex)
            {
                Log(ex.Message, LoggingCategories.Trace);
                throw;
            }

            return toReturn;
        }

        #endregion Gruppi Paritetico

        #region Societa Gruppi Paritetici

        internal Boolean SaveListaSocietaGruppoPariteticoInternal(GruppoPariteticoFDT item)
        {
            if (item.Cooperative != null)
            {
                foreach (CooperativaFDT coop in item.Cooperative)
                {
                    if (coop.Status == ObjectStatus.ToInsert ||
                      coop.Status == ObjectStatus.ToUpdate)
                    {
                        SaveSocietaGruppoPariteticoInternal(coop, item.IdGruppoParitetico);
                    }
                    else if (coop.Status >= ObjectStatus.ToHide &&
                      coop.IdTipoSoggetto > 0)
                    {
                        DeleteSocietaGruppoParitetico(coop);
                    }
                }
            }

            return true;
        }

        internal CooperativaFDT SaveSocietaGruppoPariteticoInternal(CooperativaFDT item, int idGruppo)
        {
            CooperativaFDT toReturn = null;

            if (item != null)
            {
                GVCRSOCIETA_GRUPPO itemConverted = Converters.ConvertIntoSocietaGruppo(item);
                itemConverted.IDOBJ_GRUPPO = idGruppo;

                if (item.IdTipoSoggetto > 0)
                {
                    if (GVCDB.GVCRSOCIETA_GRUPPOCollection.Update(itemConverted))
                    {
                        // update success
                        toReturn = item;
                    }
                    else
                    {
                        //update no success
                    }
                }
                else
                {
                    // perform new insert

                    GVCDB.GVCRSOCIETA_GRUPPOCollection.Insert(itemConverted);
                    if (itemConverted.IDOBJ > 0)
                    {
                        // insert success
                        toReturn = Converters.ConvertIntoSocietaGruppo(itemConverted);
                    }
                    else
                    {
                        // insert no success
                    }
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Deletes the proroga.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public Boolean DeleteSocietaGruppoParitetico(CooperativaFDT item)
        {
            Boolean toReturn = false;

            bool isInTransaction = GVCDB.IsInTransaction;

            try
            {
                if (!isInTransaction)
                {
                    GVCDB.BeginTransaction();
                }

                if (item != null && item.IdTipoSoggetto > 0)
                {
                    GVCRSOCIETA_GRUPPO itemTmp   = new GVCRSOCIETA_GRUPPO();
                    itemTmp.IDOBJ = item.IdTipoSoggetto;

                    toReturn = GVCDB.GVCRSOCIETA_GRUPPOCollection.Delete(itemTmp);
                }

                if (toReturn)
                {
                    if (!isInTransaction)
                    {
                        GVCDB.CommitTransaction();
                    }
                }
                else
                {
                    if (!isInTransaction)
                    {
                        GVCDB.RollbackTransaction();
                    }
                }
            }
            catch
            {
                if (!isInTransaction)
                {
                    GVCDB.RollbackTransaction();
                }

                //log
                //throw
            }

            return toReturn;
        }

        #endregion Societa Gruppi Paritetici
    }
}
