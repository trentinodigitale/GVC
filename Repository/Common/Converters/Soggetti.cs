using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.rtier.Service;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {

		#region Methods (10) 


		// Public Methods (10) 

        public static SoggettoFDT Convert(GVCTSOGGETTI itemToConvert)
        {
            SoggettoFDT item = null;
            if (itemToConvert != null)
            {

                if (itemToConvert.IDOBJ_TIPO_SOGGETTOSafe == -1 || itemToConvert.IDOBJ_TIPO_SOGGETTOSafe == 1)
                {
                    item = ConvertIntoPersonaFisica(itemToConvert);
                }
                else if (itemToConvert.IDOBJ_TIPO_SOGGETTOSafe == 99)
                {
                    item = ConvertIntoCooperative(itemToConvert);
                }
                else
                {
                    // persona giuridica
                    item = ConvertIntoPersonaGiuridica(itemToConvert);
                }

              
                
                return item;




                item = new SoggettoFDT();
                item.IdSoggetto = itemToConvert.IDOBJ;
                item.IdTipoSoggetto = itemToConvert.IDOBJ_TIPO_SOGGETTOSafe;
                item.PersonaFisica = itemToConvert.FLAG_PF == 1 ? true : false;
                item.Associazione = itemToConvert.FLAG_ASSOCIAZIONE == 1 ? true : false;             
                item.CodiceFiscale = itemToConvert.CODICE_FISCALESafe;
               // item.PartitaIVA = itemToConvert.PARTITA_IVASafe;
                item.Note = itemToConvert.NOTESafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTSOGGETTI Convert(SoggettoFDT itemToConvert)
        {
            GVCTSOGGETTI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTSOGGETTI();
                item.IDOBJ = itemToConvert.IdSoggetto;
                item.IDOBJ_TIPO_SOGGETTO = itemToConvert.IdTipoSoggetto;
                item.NOTE = itemToConvert.Note;
                item.FLAG_PF = itemToConvert.PersonaFisica == true ? 1 : 0;
                item.FLAG_ASSOCIAZIONE = itemToConvert.Associazione == true ? 1 : 0;
                item.CODICE_FISCALE = itemToConvert.CodiceFiscale;
           //     item.PARTITA_IVA = itemToConvert.PartitaIVA;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;


                if (itemToConvert is PersonaFisicaFDT)
                {
                    item.CELLULARE = ((PersonaFisicaFDT)itemToConvert).Cellulare;
                    item.CITTADINANZA = ((PersonaFisicaFDT)itemToConvert).Cittadinanza;
                    item.COGNOME = ((PersonaFisicaFDT)itemToConvert).Cognome;
                    item.COGNOME_ACQUISITO = ((PersonaFisicaFDT)itemToConvert).CognomeAcquisito;
                    item.LUOGO_NASCITA = ((PersonaFisicaFDT)itemToConvert).ComuneNascita;
                    item.DATA_NASCITA = ((PersonaFisicaFDT)itemToConvert).DataNascita;
                    item.EMAIL = ((PersonaFisicaFDT)itemToConvert).Email;
                    item.NOME = ((PersonaFisicaFDT)itemToConvert).Nome;
                    item.SESSO = ((PersonaFisicaFDT)itemToConvert).Sesso;
                    item.STATO_NASCITA = ((PersonaFisicaFDT)itemToConvert).StatoNascita;
                    item.TELEFONO_1 = ((PersonaFisicaFDT)itemToConvert).Telefono;
                }
                else if (itemToConvert is CooperativaFDT)
                {
                    item.DENOMINAZIONE = ((CooperativaFDT)itemToConvert).Denominazione;
                }
                else if (itemToConvert is PersonaGiuridicaFDT)
                {
                    item.DENOMINAZIONE = ((PersonaGiuridicaFDT)itemToConvert).Denominazione;
                }

            }
            return item;
        }

        public static SoggettoFDT[] ConvertAll(GVCTSOGGETTI[] itemsToConvert)
        {
            List<SoggettoFDT> listItem = new List<SoggettoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTSOGGETTI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTSOGGETTI[] ConvertAll(SoggettoFDT[] itemsToConvert)
        {
            List<GVCTSOGGETTI> listItem = new List<GVCTSOGGETTI>();
            if (itemsToConvert != null)
            {
                foreach (SoggettoFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static SoggettoPerVisualizzazioneFDT[] ConvertAllForVisualization(SoggettoFDT[] itemsToConvert)
        {
            List<SoggettoPerVisualizzazioneFDT> listItem = new List<SoggettoPerVisualizzazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (SoggettoFDT item in itemsToConvert)
                {
                    listItem.Add(ConvertForVisualization(item));
                }
            }
            return listItem.ToArray();
        }

        public static CooperativaFDT[] ConvertAllIntoCooperative(GVCTSOGGETTI[] itemsToConvert)
        {
            List<CooperativaFDT> listItem = new List<CooperativaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTSOGGETTI item in itemsToConvert)
                {
                    listItem.Add(ConvertIntoCooperative(item));
                }
            }
            return listItem.ToArray();
        }

        public static SoggettoPerVisualizzazioneFDT ConvertForVisualization(SoggettoFDT itemToConvert)
        {
            SoggettoPerVisualizzazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new SoggettoPerVisualizzazioneFDT();

                
                string codiceFiscale = string.Empty;
                string nominativo = string.Empty;
                string comuneNascita = string.Empty;
                DateTime? dataNascita = null;

                #region conversion

                if (itemToConvert is PersonaFisicaFDT)
                {
                    PersonaFisicaFDT p = itemToConvert as PersonaFisicaFDT;
                    if (p != null)
                    {
                        codiceFiscale = p.CodiceFiscale;
                        nominativo = p.NomeCompleto;
                        comuneNascita = p.ComuneNascita;
                        dataNascita = p.DataNascita;
                    }
                }
                else if (itemToConvert is CooperativaFDT)
                {
                    CooperativaFDT c = itemToConvert as CooperativaFDT;
                    if (c != null)
                    {
                 //       codiceFiscale = c.PartitaIVA;
                        codiceFiscale = c.CodiceFiscale;
                        nominativo = c.Denominazione;
                        comuneNascita = c.IndirizzoSede;
                        dataNascita = null;
                    }
                }
                else if (itemToConvert is PersonaGiuridicaFDT)
                {
                    PersonaGiuridicaFDT p = itemToConvert as PersonaGiuridicaFDT;
                    if (p != null)
                    {
                   //     codiceFiscale = p.PartitaIVA;
                        codiceFiscale = p.CodiceFiscale;
                        nominativo = p.Denominazione;
                        comuneNascita = p.IndirizzoSede;
                        dataNascita = null;
                    }
                }

                #endregion conversion

                item.Nominativo = nominativo;
                item.CodiceFiscale = codiceFiscale;
                item.ComuneNascita = comuneNascita;
                item.DataNascita = dataNascita;

                item.Associazione = itemToConvert.Associazione;
                item.IdSoggetto = itemToConvert.IdSoggetto;
                item.IdTipoSoggetto = itemToConvert.IdTipoSoggetto;

                item.Soggetto = itemToConvert;
            }
            return item;
        }

        public static CooperativaFDT ConvertIntoCooperative(GVCTSOGGETTI itemToConvert)
        {
            CooperativaFDT item = null;
            if (itemToConvert != null)
            {
                item = new CooperativaFDT();
                item.IdSoggetto = itemToConvert.IDOBJ;
                item.IdTipoSoggetto = itemToConvert.IDOBJ_TIPO_SOGGETTOSafe;
                item.PersonaFisica = itemToConvert.FLAG_PF == 1 ? true : false;
                item.Associazione = itemToConvert.FLAG_ASSOCIAZIONE == 1 ? true : false;
                item.CodiceFiscale = itemToConvert.CODICE_FISCALESafe;
          //      item.PartitaIVA = itemToConvert.PARTITA_IVASafe;

                item.Denominazione = itemToConvert.DENOMINAZIONESafe;
                item.Note = itemToConvert.NOTESafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;

                
            }
            return item;
        }

        public static PersonaFisicaFDT ConvertIntoPersonaFisica(GVCTSOGGETTI itemToConvert)
        {
            PersonaFisicaFDT item = null;
            if (itemToConvert != null)
            {
                item = new PersonaFisicaFDT();
                item.Cellulare = itemToConvert.CELLULARESafe;
                item.Cittadinanza = itemToConvert.CITTADINANZASafe;
                item.Cognome = itemToConvert.COGNOMESafe;
                item.CognomeAcquisito = itemToConvert.COGNOME_ACQUISITOSafe;
                item.ComuneNascita = itemToConvert.LUOGO_NASCITASafe;
                if (!itemToConvert.IsDATA_NASCITANull)
                    item.DataNascita = itemToConvert.DATA_NASCITA;
                item.Nome = itemToConvert.NOMESafe;
                item.Sesso = itemToConvert.SESSOSafe;
                //item.StatoCivile = itemToConvert.
                item.StatoNascita = itemToConvert.STATO_NASCITASafe;
                item.CodiceFiscale = itemToConvert.CODICE_FISCALESafe;
                item.Note = itemToConvert.NOTESafe;
                item.Telefono = itemToConvert.TELEFONO_1Safe;
                item.Email = itemToConvert.EMAILSafe;

                if (itemToConvert.IDOBJ_TIPO_SOGGETTOSafe != -1)
                    item.IdTipoSoggetto = itemToConvert.IDOBJ_TIPO_SOGGETTOSafe;
                else
                    item.IdTipoSoggetto = 1;

                item.IdSoggetto = itemToConvert.IDOBJ;
            }
            return item;
        }

        public static PersonaGiuridicaFDT ConvertIntoPersonaGiuridica(GVCTSOGGETTI itemToConvert)
        {
            PersonaGiuridicaFDT item = null;
            if (itemToConvert != null)
            {
                item = new PersonaGiuridicaFDT();
                item.IdSoggetto = itemToConvert.IDOBJ;
                item.Denominazione = itemToConvert.DENOMINAZIONESafe;
                item.IdTipoSoggetto = itemToConvert.IDOBJ_TIPO_SOGGETTOSafe;
                item.CodiceFiscale = itemToConvert.CODICE_FISCALESafe;

                item.Associazione = itemToConvert.FLAG_ASSOCIAZIONE == 1 ? true : false;
                item.Note = itemToConvert.NOTESafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }


		#endregion Methods 


        #region view Ricerca soggetti

        public static SoggettoPerVisualizzazioneFDT ConvertResults(GVCVRICERCASOGGETTI itemToConvert)
        {
            SoggettoPerVisualizzazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new SoggettoPerVisualizzazioneFDT();

                item.Nominativo = (itemToConvert.R_DENOMINAZIONESafe.Equals(string.Empty)) ? String.Concat(itemToConvert.R_NOMESafe, " ",itemToConvert.R_COGNOMESafe) : itemToConvert.R_DENOMINAZIONESafe;
                item.CodiceFiscale = itemToConvert.R_CODICE_FISCALESafe;
                item.ComuneNascita = itemToConvert.R_LUOGO_NASCITASafe;
                if (!itemToConvert.IsR_DATA_NASCITANull) 
                    item.DataNascita = itemToConvert.R_DATA_NASCITA;

                item.Associazione = (itemToConvert.R_ASSOCIAZIONE == 0) ? false : true;
                item.CodiceCooperativa = itemToConvert.R_CODICE_COOPERATIVASafe;
                item.NumeroREA = itemToConvert.R_NUMERO_REASafe;
                item.IdSoggetto = itemToConvert.R_ID_SOGGETTO;
                item.IdTipoSoggetto = itemToConvert.R_ID_TIPO_SOGGETTOSafe;
            }
            return item;
        }

        public static SoggettoPerVisualizzazioneFDT[] ConvertAllResults(GVCVRICERCASOGGETTI[] itemsToConvert)
        {
            //SortedDictionary<string, SoggettoPerVisualizzazioneFDT> corrRes = new SortedDictionary<string, SoggettoPerVisualizzazioneFDT>();
            //if (itemsToConvert != null)
            //{
            //    foreach (GVCVRICERCASOGGETTI item in itemsToConvert)
            //    {
            //        SoggettoPerVisualizzazioneFDT spv = ConvertResults(item);
            //        if (spv != null)
            //        {
            //            if (!corrRes.ContainsKey(spv.Nominativo))
            //            {
            //                corrRes.Add(spv.Nominativo, spv);
            //            }
            //        }
            //    }
            //}
            //List<SoggettoPerVisualizzazioneFDT> listItem = new List<SoggettoPerVisualizzazioneFDT>();
            //listItem.AddRange(corrRes.Values);

            List<SoggettoPerVisualizzazioneFDT> listItem = new List<SoggettoPerVisualizzazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCVRICERCASOGGETTI item in itemsToConvert)
                {
                    listItem.Add(ConvertResults(item));
                }
            }
            return listItem.ToArray();
        }

        public static void ConvertAllResults(GVCVRICERCASOGGETTIDAESPORTARE[] itemsToConvert, ref PersonaFisicaFDT[] listPersonaFisica, ref PersonaGiuridicaFDT[] listPersonaGiuridica)
        {
            List<PersonaFisicaFDT> lstPF = new List<PersonaFisicaFDT>();
            List<PersonaGiuridicaFDT> lstPG = new List<PersonaGiuridicaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                PersonaFisicaFDT itemPF = null;
                PersonaGiuridicaFDT itemPG = null;

                foreach (GVCVRICERCASOGGETTIDAESPORTARE itemView in itemsToConvert)
                {

                    if (idRif != itemView.R_ID_SOGGETTO)
                    {
                        if (itemPF != null)
                        {
                            lstPF.Add(itemPF);
                        }
                        else if (itemPG != null)
                        {
                            lstPG.Add(itemPG);
                        }

                        if (itemView.R_ID_TIPO_SOGGETTOSafe == 1)
                        {
                            itemPG = null;
                            itemPF = new PersonaFisicaFDT();
                            itemPF.IdSoggetto = itemView.R_ID_SOGGETTO;
                            itemPF.IdTipoSoggetto = itemView.R_ID_TIPO_SOGGETTOSafe;
                            itemPF.Associazione = (itemView.R_ASSOCIAZIONE == 0) ? false : true;
                            itemPF.Nome = itemView.R_NOMESafe;
                            itemPF.Cognome = itemView.R_COGNOMESafe;
                            itemPF.CognomeAcquisito = itemView.R_COGNOME_ACQUISITOSafe;

                            if (!String.IsNullOrEmpty(itemView.R_SESSOSafe))
                                itemPF.Sesso = itemView.R_SESSOSafe.Substring(0, 1);
                            if (!itemView.IsR_DATA_NASCITANull)
                                itemPF.DataNascita = itemView.R_DATA_NASCITA;

                            itemPF.ComuneNascita = itemView.R_LUOGO_NASCITASafe;
                            itemPF.StatoNascita = itemView.R_STATO_NASCITASafe;

                            itemPF.CodiceFiscale = itemView.R_CODICE_FISCALESafe;
                            itemPF.Cittadinanza = itemView.R_CITTADINANZASafe;

                            itemPF.Telefono = itemView.R_TELEFONO_1Safe;
                            itemPF.Cellulare = itemView.R_CELLULARESafe;
                            itemPF.Email = itemView.R_EMAILSafe;
                        }
                        else
                        {
                            itemPF = null;
                            itemPG = new PersonaGiuridicaFDT();
                            itemPG.IdSoggetto = itemView.R_ID_SOGGETTO;
                            itemPG.IdTipoSoggetto = itemView.R_ID_TIPO_SOGGETTOSafe;
                            itemPG.Associazione = (itemView.R_ASSOCIAZIONE == 0) ? false : true;
                            itemPG.Denominazione = itemView.R_DENOMINAZIONESafe;
                            itemPG.CodiceFiscale = itemView.R_CODICE_FISCALESafe;
                            itemPG.Email = itemView.R_EMAILSafe;
                            itemPG.Telefono = itemView.R_TELEFONO_1Safe;
                            itemPG.PersonaFisica = false;
                        }

                        idRif = itemView.R_ID_SOGGETTO;
                    }

                    if (!itemView.IsIND_IDOBJNull)
                    {
                        IndirizzoFDT objIndirizzio;

                        objIndirizzio = new IndirizzoFDT();
                        objIndirizzio.IdIndirizzo = itemView.IND_IDOBJ;
                        objIndirizzio.Principale = itemView.IND_FLAG_PRINCIPALE == 1 ? true : false;
                        objIndirizzio.Sede = itemView.IND_FLAG_SEDE == 1 ? true : false;
                        objIndirizzio.Via = itemView.IND_VIA;
                        objIndirizzio.IdSoggetto = itemView.IND_IDOBJ_SOGGETTO;
                        objIndirizzio.IdTipoIndirizzo = itemView.IND_IDOBJ_TIPO_INDIRIZZO;
                        objIndirizzio.NumeroCivico = itemView.IND_CIVICOSafe;
                        objIndirizzio.Cap = itemView.IND_CAPSafe;
                        objIndirizzio.Provincia = itemView.IND_PROVINCIASafe;
                        objIndirizzio.Comune = itemView.IND_COMUNESafe;
                        objIndirizzio.Frazione = itemView.IND_FRAZIONESafe;

                        objIndirizzio.CodiceStradario = itemView.IND_CODICE_STRADARIOSafe;
                        objIndirizzio.Telefono = itemView.IND_TELEFONOSafe;
                        objIndirizzio.Fax = itemView.IND_FAXSafe;

                        objIndirizzio.Email = itemView.IND_EMAILSafe;
                        objIndirizzio.UrlPage = itemView.IND_WEBPAGESafe;
                        objIndirizzio.Nazione = itemView.IND_STATOSafe;
                        objIndirizzio.Altro = itemView.IND_ALTROSafe;
                        objIndirizzio.Note = itemView.IND_NOTESafe;
                        objIndirizzio.DataInizio = itemView.IND_DATA_INIZIO;
                        if (!itemView.IsIND_DATA_FINENull)
                            objIndirizzio.DataFine = itemView.IND_DATA_FINE;

                        if (itemPF != null)
                        {
                            itemPF.AddIndirizzo(objIndirizzio);
                        }
                        else if (itemPG != null)
                        {
                            itemPG.AddIndirizzo(objIndirizzio);
                        }
                        
                    }
                }

                if (itemPF != null)
                {
                    lstPF.Add(itemPF);
                }
                else if (itemPG != null)
                {
                    lstPG.Add(itemPG);
                }

                listPersonaFisica = lstPF.ToArray();
                listPersonaGiuridica = lstPG.ToArray();
            }
        }

        #endregion view Ricerca soggetti

    }
}
