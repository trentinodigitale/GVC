using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;

namespace it.dedagroup.GVC.Client.Forms
{
    public  static partial class StaticClassTemp
    {
        public static AttivitaFDT[] GetListActivitiesParix()
        {
            List<AttivitaFDT> toReturn = new List<AttivitaFDT>();

            AttivitaFDT a = new AttivitaFDT();

            a.IdTipoAttivita = 5;
            a.Importanza = "P";
            a.DataInizio = new DateTime(1978, 3, 21);

            toReturn.Add(a);

            return toReturn.ToArray();
        }

        public static AttivitaFDT[] GetListActivities()
        {
            List<AttivitaFDT> toReturn = new List<AttivitaFDT>();

            AttivitaFDT a = new AttivitaFDT();

            a.IdTipoAttivita = 4;

            toReturn.Add(a);

            return toReturn.ToArray();
        }

        public static ComunicazioneBaseSocialeFDT[] GetListSocialBase()
        {
            List<ComunicazioneBaseSocialeFDT> toReturn = new List<ComunicazioneBaseSocialeFDT>();

            ComunicazioneBaseSocialeFDT c = new ComunicazioneBaseSocialeFDT();

            c.DataComunicazione = new DateTime(1991, 5, 30);
            c.DataSituazione = new DateTime(1990, 12, 31);

            c.SociCooperatori = 9;
            //c.PersoneSvantaggiate;
            //c.Documentazioni;
            c.TipoConferimentoCapitale = 0;
            c.IdComunicazioneBaseSociale = 1;
            //c.SociPersoneGiuridiche;
          
            //c.SociUtenti;
            //c.SociVolontari;
            c.ValoreAzione = 50000;
          
            //c.Note;
            //c.SociAltreTipologie;
            c.SociSovventori = 0;
            c.CapitaleVersato = 75050000;
            //c.ValoreQuote;
            
            c.CapitaleSottoscritto = 75050000;
            //c.LavoratoriSoci;
            c.Lavoratori = 5;
            //c.LavoratoriSociENon;
            //c.LavoratoriRemunerati;
            c.Documentazioni = GetListDocumentationForComunications();

            toReturn.Add(c);

            return toReturn.ToArray();
        }

        public static RevisioneFDT[] GetListRevisions()
        {
            List<RevisioneFDT> toReturn = new List<RevisioneFDT>();

            RevisioneFDT r = new RevisioneFDT();

            #region prima

            r.IdRevisione = 1;
            //r.IdRegistro = 1 * 100 + 1;
            r.IdTipoRevisione = 3;
            r.Liquidazioni = GetListCounterBalanceLiquidationRevisor(1);

            CooperativaFDT p = new CooperativaFDT();
            p.Denominazione = "FEDERAZIONE TRENTINA DELLA COOPERAZIONE";
            //r.Revisore = p;

            r.RevisioniIncarichi = GetListRevisionTasks(1);
            r.AnnoRevisione = 1995;

            

            #endregion prima

            toReturn.Add(r);


            r = new RevisioneFDT();

            #region seconda

            r.IdRevisione = 2;
            //r.IdRegistro = 2 * 100 + 1;
            r.IdTipoRevisione = 3;
            r.Liquidazioni = GetListCounterBalanceLiquidationRevisor(2);

            p = new CooperativaFDT();
            p.Denominazione = "FEDERAZIONE TRENTINA DELLA COOPERAZIONE";
            //r.Revisore = p;

            r.RevisioniIncarichi = GetListRevisionTasks(2);
            r.AnnoRevisione = 2001;

            #endregion seconda

            toReturn.Add(r);

            return toReturn.ToArray();
        }

        private static RevisioneIncaricoFDT[] GetListRevisionTasks(int index)
        {
            List<RevisioneIncaricoFDT> toReturn = new List<RevisioneIncaricoFDT>();

            RevisioneIncaricoFDT r = new RevisioneIncaricoFDT();

            if (index == 1)
            {
                #region revisionTask
                r.IdRevisioneIncarico = 1;

                //r.DataDeliberaCommRicusazione;
                //r.NumeroDeliberaCommRicusazione;
                //r.DataDeterminaRicusazione;
                //r.NumeroDeterminaRicusazione;
               // r.CounterBalances = GetListCounterBalanceRevisor(1);
                //r.DataScadenzaEffettiva = new DateTime(1995, 12, 29);
                //r.DataFine = new DateTime(1995, 12, 29);
                //r.DataDeliberaCommissioneEsame = new DateTime(1996, 2, 6);
                //r.NumeroDeliberaCommissioneEsame;
                //r.DataDeterminaEsame;
                //r.NumeroDeterminaEsame;
                //r.FilingDate;

                //r.DataDeliberaCommissioneIncarico;
                //r.NumeroDeliberaCommissioneIncarico;
                r.DataDeterminaIncarico = new DateTime(1995, 12, 29);
                r.NumeroDeterminaIncarico = "7476669";
                //r.DataEsito;
                //r.IdEsito = 3;
                //r.ProgressDuration;
                r.DataScadenzaTeorica = new DateTime(1995, 12, 29);



                #endregion revisionTask
            }
            else
            {
                #region revisionTask

                r.IdRevisioneIncarico = 2;

                //r.DataDeliberaCommRicusazione;
                //r.NumeroDeliberaCommRicusazione;
                //r.DataDeterminaRicusazione;
                //r.NumeroDeterminaRicusazione;
                //r.CounterBalances = GetListCounterBalanceRevisor(2);
                //r.DataScadenzaEffettiva = new DateTime(2001, 12, 20);
                //r.DataFine = new DateTime(2001, 05, 9);
                //r.DataDeliberaCommissioneEsame = new DateTime(2001, 6, 1);
                //r.NumeroDeliberaCommissioneEsame;
                //r.DataDeterminaEsame;
                //r.NumeroDeterminaEsame;
                //r.FilingDate;

                //r.DataDeliberaCommissioneIncarico;
                //r.NumeroDeliberaCommissioneIncarico;
                r.DataDeterminaIncarico = new DateTime(2001, 05, 9);
                r.NumeroDeterminaIncarico = "123332";
                //r.DataEsito;
                //r.IdEsito = 2;
                //r.ProgressDuration;
                r.DataScadenzaTeorica = new DateTime(2001, 12, 20);

                #endregion revisionTask
            }

            toReturn.Add(r);

            return toReturn.ToArray();
        }

        private static List<CompensoFDT> GetListCounterBalanceRevisor(int index)
        {
            List<CompensoFDT> toReturn = new List<CompensoFDT>();
            CompensoFDT c = new CompensoFDT();

            if (index == 1)
            {
                c.Valuta = 1;
                c.ImportoCompenso = 1 * 1000;

                PersonaFisicaFDT p = new PersonaFisicaFDT();
                p.Nome = "Stefano";
                p.Cognome = "Giovannini";
                c.Revisore = p;
            }
            else
            {
                c.Valuta = 1;
                c.ImportoCompenso = 2 * 1000;

                PersonaFisicaFDT p = new PersonaFisicaFDT();
                p.Nome = "Massimo";
                p.Cognome = "Degasperi";
                c.Revisore = p;
            }

            toReturn.Add(c);

            return toReturn;
        }

        private static CompensoLiquidazioneFDT[] GetListCounterBalanceLiquidationRevisor(int index)
        {
            List<CompensoLiquidazioneFDT> toReturn = new List<CompensoLiquidazioneFDT>();

            CompensoLiquidazioneFDT c = new CompensoLiquidazioneFDT();

            if (index == 1)
            {
                //c.ImportoSpeseBFL;
                //c.TipoContributo;
                c.Valuta = 0;
                //c.DataDetermina;
                //c.NumeroDetermina;
                //c.ImportoDefinito;
                //c.IdCompensoLiquidazione;
                c.Liquidato = true;
                //c.ProcessoChiuso = true;
                //c.Note;
                //c.DataLiquidazioneUfficio = new DateTime(1997, 2, 1);
                //c.DurataProcessoUfficio = 60;
                c.ImportoErogato = 1000;
                //c.PercentualeContributoPAT;
                //c.DataMandatoPagamento;
                //c.NumeroMandatoPagamento;
                //c.ImportoRichiesto;
                //c.DataRicevimentoDomanda = new DateTime(1997, 1, 15);
                //c.DataFineTeorica = c.DataLiquidazioneUfficio.Value.AddDays(c.DurataProcessoUfficio);
            }
            else
            {
                //c.ImportoSpeseBFL;
                //c.TipoContributo;
                c.Valuta = 0;
                //c.DataDetermina;
                //c.NumeroDetermina;
                //c.ImportoDefinito;
                //c.IdCompensoLiquidazione;
                c.Liquidato = true;
                //c.ProcessoChiuso = true;
                //c.Note;
                //c.DataLiquidazioneUfficio = new DateTime(2002, 2, 3);
                //c.DurataProcessoUfficio = 60;
                c.ImportoDeterminato = 2000;
                //c.PercentualeContributoPAT;
                //c.DataMandatoPagamento;
                //c.NumeroMandatoPagamento;
                //c.ImportoRichiesto;
                //c.DataRicevimentoDomanda = new DateTime(2002, 1, 10);
                //c.DataFineTeorica = c.DataLiquidazioneUfficio.Value.AddDays(c.DurataProcessoUfficio);
            }
            
           

            toReturn.Add(c);


            return toReturn.ToArray();
        }

        public static TipoAssembleaFDT[] GetListMeetingTypes()
        {
            List<TipoAssembleaFDT> toReturn = new List<TipoAssembleaFDT>();

            string[] desc = new string[] { "Ordinaria",
                                            "Straordinaria",
                                            "Costitutiva"};

            for (int i = 0; i < desc.Length; i++)
            {
                TipoAssembleaFDT item = new TipoAssembleaFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];

                toReturn.Add(item);
            }

            return toReturn.ToArray();
        }

        public static TipoModificaStatutariaFDT[] GetListStatutaryChangeTypes()
        {
            List<TipoModificaStatutariaFDT> toReturn = new List<TipoModificaStatutariaFDT>();

            string[] desc = new string[] { "Cambio Denominazione",
                                            "Cambio sede legale",
                                            "Cambio sede amministrativa",
                                            "Cambio durata",
                                            "Cambio tipo società",
                                            "Cambio scadenza esercizi",
                                            "Cambio tipo responsabilità",
                                            "Trasferimento fuori provincia"
                                            };

            for (int i = 0; i < desc.Length; i++)
            {
                TipoModificaStatutariaFDT item = new TipoModificaStatutariaFDT();
                item.IdElemento = i;
                item.Descrizione = desc[i];

                toReturn.Add(item);
            }

            return toReturn.ToArray();
        }


        public static DeliberaAssembleaFDT[] GetListMeetingDeliberations()
        {
            List<DeliberaAssembleaFDT> toReturn = new List<DeliberaAssembleaFDT>();

            DeliberaAssembleaFDT m = new DeliberaAssembleaFDT();
            //m.DataEsameCommissione;
            m.Contenuto = "Atto costitutivo";
            m.IdDeliberaAssemblea = 1;
            m.IdTipoAssemblea = 2;
            //m.IdNotaio;
            m.DataAssemblea = new DateTime(1978, 1, 23);
            m.Notaio = new PersonaFisicaFDT();
            m.Notaio.Nome = "Mario";
            m.Notaio.Cognome = "Stelzer";
            m.DataEvasioneUfficio = new DateTime(1978, 3, 9);
            //m.OfficeMinutesReceivingDate;
            //m.DurataProcessoUfficio;
            //m.AttiIntegrativi;
            //m.DataIscrizRegistroImprese;
            //m.ModificheStatutarie = GetListStatutoryChanges(1);
            toReturn.Add(m);

            m = new DeliberaAssembleaFDT();
            m.DataEsameCommissione = new DateTime(2000, 4, 6);
            m.Contenuto = "ADOTTATO NUOVO STATUTO (adeguamento al nuovo diritto societario)";
            m.IdDeliberaAssemblea = 2;
            m.IdTipoAssemblea = 1;
            //m.IdNotaio;
            m.DataAssemblea = new DateTime(1999, 12, 31);
            m.Notaio = new PersonaFisicaFDT();
            m.Notaio.Nome = "Paolo";
            m.Notaio.Cognome = "Piccoli";
            m.DataEvasioneUfficio = new DateTime(2000, 1, 13);
            //m.OfficeMinutesReceivingDate;
            //m.DurataProcessoUfficio;
            //m.AttiIntegrativi;
            m.DataIscrizRegistroImprese = new DateTime(2000,2, 21);
            m.ModificheStatutarie = GetListStatutoryChanges(2);
            toReturn.Add(m);

            return toReturn.ToArray();
        }

        private static ModificaStatutariaFDT[] GetListStatutoryChanges(int p)
        {
            List<ModificaStatutariaFDT> toReturn = new List<ModificaStatutariaFDT>();
            if (p == 1)
            {
                ModificaStatutariaFDT s = new ModificaStatutariaFDT();

                s.IdTipoModifica = 2;
                s.DataInizioValidita = new DateTime(1978, 3, 20);
                toReturn.Add(s);

                s = new ModificaStatutariaFDT();
                s.IdTipoModifica = 5;
                s.DataInizioValidita = new DateTime(1978, 5, 10);
                toReturn.Add(s);

            }
            else
            {
                ModificaStatutariaFDT s = new ModificaStatutariaFDT();

                s.IdTipoModifica = 0;
                s.DataInizioValidita = new DateTime(1999, 9, 20);
                toReturn.Add(s);

                s = new ModificaStatutariaFDT();
                s.IdTipoModifica = 3;
                s.DataInizioValidita = new DateTime(1999, 1, 10);
                toReturn.Add(s);

                s = new ModificaStatutariaFDT();
                s.IdTipoModifica = 4;
                s.DataInizioValidita = new DateTime(1999, 4, 15);
                toReturn.Add(s);
            }

            return toReturn.ToArray();
        }

    }
}
