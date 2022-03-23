using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using System.Globalization;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;




namespace it.dedagroup.GVC.Repository.etier.Services.ParixWrapper
{
    public abstract partial class Converters
    {
        #region ResponseConverters

        public static CooperativaFDT[] ConvertResponseToCooperative(RISPOSTA response)
        {
            List<CooperativaFDT> cooperatives = new List<CooperativaFDT>();

            if (response.DATI != null && response.DATI.ERRORE != null)
                if (response.DATI.ERRORE.TIPO.Equals("occorrenza_max"))
                    return cooperatives.ToArray();

            if (response.DATI != null &&
                response.DATI.LISTA_IMPRESE != null &&
                response.DATI.LISTA_IMPRESE.ESTREMI_IMPRESA != null &&
                response.DATI.LISTA_IMPRESE.ESTREMI_IMPRESA.Length > 0)
            {
                foreach (ESTREMI_IMPRESA parixCooperative in response.DATI.LISTA_IMPRESE.ESTREMI_IMPRESA)
                {
                    CooperativaFDT cooperativeFdt = convertToCooperativa(parixCooperative);
                    if (cooperativeFdt != null)
                        cooperatives.Add(cooperativeFdt);
                }
            }
            if (cooperatives.Count > 0)
                return cooperatives.ToArray();
            return null;
        }

        public static CooperativaFDT[] ConvertResponseToCompleteCooperative(RISPOSTA response)
        {
            CooperativaFDT cooperative = null;
            if (response.DATI != null && response.DATI.DATI_IMPRESA != null)
            {
                DATI_IMPRESA cooperativeData = response.DATI.DATI_IMPRESA;
                if (response.DATI.DATI_IMPRESA.ESTREMI_IMPRESA != null)
                {
                    cooperative = convertToCooperativa(response.DATI.DATI_IMPRESA.ESTREMI_IMPRESA);
                    if (cooperative == null)
                        return null;
                }
                else
                    return null;
                if (cooperativeData.DURATA_SOCIETA != null)
                { 
                    DURATA_SOCIETA duration = cooperativeData.DURATA_SOCIETA;
                    cooperative.RegistroCooperativa.DataCostituzione = convertToDateTime(duration.DT_COSTITUZIONE);
                    cooperative.RegistroCooperativa.Durata = convertToDateTime(duration.DT_TERMINE);

                    if (duration.DURATA_ILLIMITATA != null && duration.DURATA_ILLIMITATA.Equals("SI"))
                        cooperative.RegistroCooperativa.DurataIllimitata = 1; //hidhi i sy ksaj
                    
                    if (duration.SCADENZE_ESERCIZI != null)
                    {
                        cooperative.RegistroCooperativa.BilancioEsercizioAl = convertToDateTime(AdjustBilancioAl(duration.SCADENZE_ESERCIZI.DT_SUCCESSIVE));
                    }
                }

                if (cooperativeData.CAPITALI != null)
                {
                    cooperative.RegistroCooperativa.ComunicazioniBaseSociale = convertToComunicazioneBaseSociale(cooperativeData.CAPITALI);
                }

                if (cooperativeData.CODICE_FORMA_AMMV != null && cooperativeData.DESC_FORMA_AMMV!= null)
                    cooperative.RegistroCooperativa.FormaAmministrativaParix = cooperativeData.CODICE_FORMA_AMMV + " - " + cooperativeData.DESC_FORMA_AMMV;
        

                List<AttivitaFDT> parixActivity = new List<AttivitaFDT>();
                if (cooperativeData.INFORMAZIONI_SEDE != null)
                {
                    INFORMAZIONI_SEDE headOfficeInfo = cooperativeData.INFORMAZIONI_SEDE;
                    //cooperative.IndirizzoSede ?????
                    String dataCessazione = "";
                    if (headOfficeInfo.CESSAZIONE != null)
                    {
                        dataCessazione = headOfficeInfo.CESSAZIONE.DT_CESSAZIONE;
                    }
                    
                    if (headOfficeInfo.INDIRIZZO != null)
                    {
                        cooperative.AddIndirizzo(convertToIndirizzoFDT(headOfficeInfo.INDIRIZZO, true, "", dataCessazione));
                    }

                    //CODICI ATECO 2002
                    //if (headOfficeInfo.CODICI_ISTAT_02 != null && headOfficeInfo.CODICI_ISTAT_02.Length > 0)
                    //{
                    //    foreach (ATTIVITA_ISTAT istatActivity in headOfficeInfo.CODICI_ISTAT_02)
                    //    {
                    //        AttivitaFDT activityFDT = convertToAttivitaFDT(istatActivity);
                    //        parixActivity.Add(activityFDT);
                    //    }
                    //}

                    //CODICI ATECO 2007
                    if (headOfficeInfo.CODICE_ATECO_UL != null && headOfficeInfo.CODICE_ATECO_UL.Length > 0)
                    {
                        foreach (ATTIVITA_ISTAT istatActivity in headOfficeInfo.CODICE_ATECO_UL)
                        {
                            AttivitaFDT activityFDT = convertToAttivitaFDT(istatActivity);
                            parixActivity.Add(activityFDT);
                        }
                    }
                }
                if (cooperativeData.PERSONE_SEDE != null && cooperativeData.PERSONE_SEDE.PERSONA != null)
                {
                    cooperative.RegistroCooperativa.ComunicazioniPosizioneCaricaSociale = convertToComunicazioneCaricaSociale(cooperativeData.PERSONE_SEDE.PERSONA);
                }

                if (cooperativeData.LOCALIZZAZIONI != null && cooperativeData.LOCALIZZAZIONI.Length > 0)
                {
                    foreach (LOCALIZZAZIONI locations in cooperativeData.LOCALIZZAZIONI)
                    {
                        if (!locations.provincia.Trim().ToLower().Equals("tn"))
                            continue;
                        foreach (LOCALIZZAZIONE location in locations.LOCALIZZAZIONE)
                        {
                            String dataApertura = location.DT_APERTURA;
                            String dataCessazione = "";
                            if (location.CESSAZIONE_LOC != null)
                            {
                                dataCessazione = location.CESSAZIONE_LOC.DT_CESSAZIONE;
                            }
                            
                            if (location.INDIRIZZO != null)
                            {
                                IndirizzoFDT locAdress = convertToIndirizzoFDT(location.INDIRIZZO, false, dataApertura, dataCessazione);
                                cooperative.AddIndirizzo(locAdress);   
                            }

                            //CODICI ATECO 2002
                            //if (location.CODICI_ISTAT_02 != null && location.CODICI_ISTAT_02.Length > 0)
                            //{
                            //    foreach (ATTIVITA_ISTAT istatActivity in location.CODICI_ISTAT_02)
                            //    {
                            //        AttivitaFDT activityFDT = convertToAttivitaFDT(istatActivity);
                            //        parixActivity.Add(activityFDT);
                            //    }
                            //}
                            //CODICI ATECO 2007
                            if (location.CODICE_ATECO_UL != null && location.CODICE_ATECO_UL.Length > 0)
                            {
                                foreach (ATTIVITA_ISTAT istatActivity in location.CODICE_ATECO_UL)
                                {
                                    AttivitaFDT activityFDT = convertToAttivitaFDT(istatActivity);
                                    parixActivity.Add(activityFDT);
                                }
                            }
                            
                        }
                    }
                }
                cooperative.RegistroCooperativa.AttivitaParix = parixActivity.ToArray();
            }
            if (cooperative == null)
                return null;
            return new CooperativaFDT[] { cooperative };
        }

        public static ComunicazioneCaricaSocialeFDT[] ConvertResponseToPerson(RISPOSTA response)
        {
            if (response.DATI.LISTA_PERSONE != null && response.DATI.LISTA_PERSONE.PERSONA != null && response.DATI.LISTA_PERSONE.PERSONA.Length > 0)
            {
                return convertToComunicazioneCaricaSociale(response.DATI.LISTA_PERSONE.PERSONA);
            }
            return null;
        }

        #endregion ResponseConverters


        #region FDRConverters
        private static ComunicazioneBaseSocialeFDT[] convertToComunicazioneBaseSociale(CAPITALI capital)
        {
            ComunicazioneBaseSocialeFDT socialBase = new ComunicazioneBaseSocialeFDT();
            if (capital.CAPITALE_SOCIALE != null) {
                socialBase.CapitaleSottoscritto = convertToDouble(capital.CAPITALE_SOCIALE.SOTTOSCRITTO);
                socialBase.CapitaleVersato = convertToDouble(capital.CAPITALE_SOCIALE.VERSATO);    
            }
            if (capital.TOTALE_QUOTE != null) {
                if (capital.TOTALE_QUOTE.NUMERO_AZIONI != null)
                    socialBase.ValoreAzione = convertToDouble(capital.TOTALE_QUOTE.AMMONTARE);
                else
                    socialBase.ValoreQuote = convertToDouble(capital.TOTALE_QUOTE.AMMONTARE);
            }

            socialBase.Status = ObjectStatus.ToInsert;

            return new ComunicazioneBaseSocialeFDT[] { socialBase };
        }

        private static ComunicazioneCaricaSocialeFDT[] convertToComunicazioneCaricaSociale(PERSONA[] persons) {
            ComunicazioneCaricaSocialeFDT[] socialChargeComunications = new ComunicazioneCaricaSocialeFDT[1];
            ComunicazioneCaricaSocialeFDT socialChargeComunication = new ComunicazioneCaricaSocialeFDT();
            List<CaricaSocialeFDT> charges = new List<CaricaSocialeFDT>();
            foreach (PERSONA person in persons)
            {
                
                if (person.IDENTIFICATIVO != null)
                {
                    //*** = person.IDENTIFICATIVO.PRESSO_CCIAA;
                    //*** = person.IDENTIFICATIVO.PRESSO_N_REA;
                    //*** = person.IDENTIFICATIVO.PROGRESSIVO_PERSONA;
                    //*** = person.IDENTIFICATIVO.PROGRESSIVO_LOC;

                }
                PersonaFisicaFDT naturalPerson = null;
                PersonaGiuridicaFDT legalPerson = null;

                if (person.PERSONA_FISICA != null)
                {
                    naturalPerson = convertToNaturalPerson(person);
                    if (person.PERSONA_FISICA.INDIRIZZO != null)
                        naturalPerson.Indirizzi = new IndirizzoFDT[] { convertToIndirizzoFDT(person.PERSONA_FISICA.INDIRIZZO, false, "", "") };
                }
                //else if (person.PERSONA_GIURIDICA != null)
                //{
                //    legalPerson = ConvertToLegalPerson(person);
                //    naturalPerson = ConvertLegalToNaturalPerson(legalPerson);
                //    if (person.PERSONA_GIURIDICA.INDIRIZZO != null)
                //        naturalPerson.Indirizzi = new IndirizzoFDT[1] { convertToIndirizzoFDT(person.PERSONA_FISICA.INDIRIZZO) };
                //}

                if (naturalPerson == null)
                    continue;

                if (person.CARICHE != null && person.CARICHE.Length > 0)
                {
                    
                    foreach (CARICA charge in person.CARICHE)
                    {
                        charges.Add(convertToCaricaSociale(charge, naturalPerson, convertToBoolean(person.RAPPRESENTANTE)));
                    }
                    
                }
            }
            socialChargeComunication.Cariche = charges.ToArray();
            socialChargeComunication.DataSituazione = DateTime.Now;
            socialChargeComunication.Status = ObjectStatus.ToInsert;
            socialChargeComunications[0] = socialChargeComunication;
            return socialChargeComunications;
        }

        private static CaricaSocialeFDT convertToCaricaSociale(CARICA charge, PersonaFisicaFDT naturalPerson, Boolean isLegaleRappresentante)
        {
            DictionaryContainer dataContainer = new DictionaryContainer();
            dataContainer.RetrieveCharges();
            CaricaSocialeFDT chargeFdt = new CaricaSocialeFDT();
            String chargeDesc = charge.DESCRIZIONE;
            int indexofSpacedivider = charge.DESCRIZIONE.IndexOf("   ");
            if(indexofSpacedivider >= 0)
                chargeDesc = charge.DESCRIZIONE.Substring(0, indexofSpacedivider);
            chargeFdt.IdTipoCarica = DictionaryContainer.Charges[chargeDesc];
            chargeFdt.DataInizio = convertToDateTime(charge.DT_INIZIO);
            chargeFdt.DataFine = convertToDateTime(charge.DT_FINE);
            chargeFdt.PersonaFisica = naturalPerson;
            chargeFdt.LegaleRappresentante = isLegaleRappresentante;
            chargeFdt.Status = ObjectStatus.ToInsert;
            return chargeFdt;
        }

        private static PersonaGiuridicaFDT convertToLegalPerson(PERSONA person)
        {
            if (person.PERSONA_GIURIDICA != null)
            {
                PersonaGiuridicaFDT legalPerson = new PersonaGiuridicaFDT();
                legalPerson.Denominazione = person.PERSONA_GIURIDICA.DENOMINAZIONE;
                legalPerson.CodiceFiscale = person.PERSONA_GIURIDICA.CODICE_FISCALE;
                legalPerson.IdTipoSoggetto = TipoSoggetto.PERSONA_GIURIDICA;
                legalPerson.PersonaFisica = false;
                return legalPerson;
            }
            return null;
        }

        //questo metodo e temporaneo
        private static PersonaFisicaFDT convertLegalToNaturalPerson(PersonaGiuridicaFDT legalPerson)
        {
            PersonaFisicaFDT naturalPerson = new PersonaFisicaFDT();
            naturalPerson.Nome = legalPerson.Denominazione;
            naturalPerson.CodiceFiscale = legalPerson.CodiceFiscale;
            naturalPerson.IdTipoSoggetto = TipoSoggetto.PERSONA_FISICA;
            naturalPerson.PersonaFisica = true;
            //???
            naturalPerson.Note = "Persona giuridica";
            return naturalPerson;
        }

        private static PersonaFisicaFDT convertToNaturalPerson(PERSONA person)
        {
            if (person.PERSONA_FISICA != null)
            {
                PersonaFisicaFDT naturalPerson = new PersonaFisicaFDT();
                naturalPerson.Cognome = person.PERSONA_FISICA.COGNOME;
                naturalPerson.Nome = person.PERSONA_FISICA.NOME;
                if (!String.IsNullOrEmpty(person.PERSONA_FISICA.SESSO))
                    naturalPerson.Sesso = person.PERSONA_FISICA.SESSO.Substring(0, 1);
                if (person.PERSONA_FISICA.ESTREMI_NASCITA != null)
                {
                    //*** = person.PERSONA_FISICA.ESTREMI_NASCITA.PROVINCIA;
                    naturalPerson.ComuneNascita = person.PERSONA_FISICA.ESTREMI_NASCITA.COMUNE;
                    //*** = person.PERSONA_FISICA.ESTREMI_NASCITA.C_COMUNE;
                    naturalPerson.StatoNascita = person.PERSONA_FISICA.ESTREMI_NASCITA.STATO;
                    if (convertToDateTime(person.PERSONA_FISICA.ESTREMI_NASCITA.DATA) != null)
                        naturalPerson.DataNascita = (DateTime)convertToDateTime(person.PERSONA_FISICA.ESTREMI_NASCITA.DATA);
                }
                naturalPerson.CodiceFiscale = person.PERSONA_FISICA.CODICE_FISCALE;
                naturalPerson.Cittadinanza = person.PERSONA_FISICA.CITTADINANZA;
                naturalPerson.IdTipoSoggetto = TipoSoggetto.PERSONA_FISICA;
                naturalPerson.PersonaFisica = true;

                return naturalPerson;
            }
            return null;
        }

        private static IndirizzoFDT convertToIndirizzoFDT(INDIRIZZO indirizzio, Boolean sede, String dataApertura, String dataCessazione)
        {
            IndirizzoFDT address = new IndirizzoFDT();
            //commentato perche indirizzio.PROVINCIA ha piu di 2 lettere
            //address.Provincia = indirizzio.PROVINCIA;
            address.Comune = indirizzio.COMUNE;
            //*** = indirizzio.C_COMUNE;
            //*** = indirizzio.TOPONIMO;
            address.Via = indirizzio.VIA;
            address.NumeroCivico = indirizzio.N_CIVICO;
            address.Cap = indirizzio.CAP;
            //*** = indirizzio.STATO;
            address.Frazione = indirizzio.FRAZIONE;
            address.Altro = indirizzio.ALTRE_INDICAZIONI;
            address.Sede = sede;
            address.Telefono = indirizzio.TELEFONO;
            address.CodiceStradario = indirizzio.STRADARIO;
            address.DataFine = convertToDateTime(dataCessazione);
            if (sede)
                address.IdTipoIndirizzo = it.dedagroup.GVC.Repository.Common.Configurations.TipoIndirizzo.SedeLegale;
            else
                address.IdTipoIndirizzo = it.dedagroup.GVC.Repository.Common.Configurations.TipoIndirizzo.UnitaLocale;
            if (convertToDateTime(dataApertura) != null)
                address.DataInizio = (DateTime)convertToDateTime(dataApertura);
            else
                address.DataInizio = System.DateTime.Now;

            address.Status = ObjectStatus.ToInsert;
            return address;
        }

        private static CancellazioneFDT convertToCancellazioneFDT(CESSAZIONE cessazione)
        {
            CancellazioneFDT cancellation = new CancellazioneFDT();
            cancellation.IdTipoCancellazione = 211;
            cancellation.DataCancRegistro = convertToDateTime(cessazione.DT_CANCELLAZIONE);
            return cancellation;
        }

        private static AttivitaFDT convertToAttivitaFDT(ATTIVITA_ISTAT istatActivity)
        {
            DictionaryContainer dataContainer = new DictionaryContainer();
            dataContainer.RetrieveActivities();
            AttivitaFDT activityFDT = new AttivitaFDT();
            activityFDT.IdTipoAttivita = DictionaryContainer.Activities[istatActivity.C_ATTIVITA];
            activityFDT.Note = istatActivity.DESC_ATTIVITA;
            activityFDT.Importanza = istatActivity.C_IMPORTANZA;
            activityFDT.DataInizio = convertToDateTime(istatActivity.DT_INIZIO_ATTIVITA);
            activityFDT.InfoCamere = true;
            activityFDT.Status = ObjectStatus.ToInsert;
            return activityFDT;
        }

        private static CooperativaFDT convertToCooperativa(ESTREMI_IMPRESA parixCooperative)
        {
            CooperativaFDT cooperativeFdt = new CooperativaFDT();
            RegistroCooperativaFDT cooperativeReg = new RegistroCooperativaFDT();
            cooperativeFdt.Associazione = false;
            cooperativeReg.IdStatoIscrizione = TipoStatoIscrizione.NORMALE;
            Boolean notOfInterest = true;
            if (parixCooperative.FORMA_GIURIDICA != null && parixCooperative.FORMA_GIURIDICA.C_FORMA_GIURIDICA != null)
            {
                if (!(FormeGiuridiche.getFormeGiuridiche().Contains(parixCooperative.FORMA_GIURIDICA.C_FORMA_GIURIDICA.ToLower())))
                    return null;
                cooperativeReg.FormaGiuridicaParix = parixCooperative.FORMA_GIURIDICA.C_FORMA_GIURIDICA + " - " + parixCooperative.FORMA_GIURIDICA.DESCRIZIONE;
                //CooperativeReg.*** = item.FORMA_GIURIDICA.DESCRIZIONE;
            }
            else
                return null;

            if (parixCooperative.DATI_ISCRIZIONE_REA != null && parixCooperative.DATI_ISCRIZIONE_REA.Length > 0)
            {
                foreach (DATI_ISCRIZIONE_REA READata in parixCooperative.DATI_ISCRIZIONE_REA)
                {
                    if (READata.FLAG_SEDE != null && !READata.FLAG_SEDE.ToLower().Equals("si"))
                        continue;
                    if (READata.CCIAA != null && READata.CCIAA.ToLower().Equals("tn"))
                    {
                        notOfInterest = false;
                        cooperativeReg.NumeroREA = READata.NREA;
                        //*** = READata.CCIAA; //Interessa nr. REA della CCIAA di TN
                        //*** = READata.DATA; //data incrizione rea
                    }
                    if (READata.CESSAZIONE != null)
                    {
                        cooperativeReg.Cancellazione = convertToCancellazioneFDT(READata.CESSAZIONE);
                    }
                }
            }

            if (notOfInterest)
                return null;

            cooperativeFdt.Denominazione = parixCooperative.DENOMINAZIONE;
            cooperativeFdt.CodiceFiscale = parixCooperative.CODICE_FISCALE;

            if (parixCooperative.DATI_ISCRIZIONE_RI != null)
            {
                cooperativeReg.NumeroRI = parixCooperative.DATI_ISCRIZIONE_RI.NUMERO_RI;



                // tolto perche al momento in parix non ci sono i dati di iscrizione al registro delle 
                // cooperative.. a noi quello del registro imprese non interessa in questo senso

                //DateTime? dataRicevimento =  convertToDateTime(parixCooperative.DATI_ISCRIZIONE_RI.DATA);
                //if(!cooperativeReg.NumeroRI.Equals(""))
                //{
                //    CambioPosizioneFDT posChange = new CambioPosizioneFDT();
                //    if (dataRicevimento.HasValue)
                //        posChange.DataRicevimentoDomanda = (DateTime)dataRicevimento;
                //    cooperativeReg.CambioPosizioni = new CambioPosizioneFDT[]{posChange};
                //}
            }

            cooperativeFdt.RegistroCooperativa = cooperativeReg;
            return cooperativeFdt;
        }
        #endregion FDRConverters


        #region GeneralConverters
        private static String AdjustBilancioAl(String bilancioXml)
        {
            try
            {
                String date = bilancioXml.Replace(" ", "");
                String[] datemonth = date.Split('/');
                String month = datemonth[1];
                if (month.Length == 1)
                    month = "0" + month;
                String day = datemonth[0];
                if (day.Length == 1)
                    day = "0" + day;

                date = "1900" + month + day;
                return date;
            }
            catch (Exception)
            {
                return "";
            }
        }
        
        
        
        private static DateTime? convertToDateTime(String sdate) 
        {
            DateTime date;
            if(DateTime.TryParseExact(sdate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture, DateTimeStyles.None, out date))
                return date;
            return null;
            
           
        }

        private static double convertToDouble(String sdouble)
        {
            double d = 0;
            if (Double.TryParse(sdouble, out d))
                return d;
            return 0;
        }

        private static bool convertToBoolean(String sboolean)
        {
            if (String.IsNullOrEmpty(sboolean))
                return false;

            if (sboolean.ToLower().Equals("si"))
                return true;
            else
                return false;
        }
        
        private static int convertToInt(String sint)
        {
            int i = 0;
            if (Int32.TryParse(sint, out i))
                return i;
            return 0;
        }
        #endregion GeneralConverters
    }
}
