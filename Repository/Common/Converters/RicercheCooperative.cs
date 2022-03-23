using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Configurations;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.rtier.Service;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {
        #region Ricerca revisioni effettuate

        public static CooperativaRicercaFDT[] ConvertAllIntoRevisioniEff(GVCVRICERCAREV_EFF[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                int idRifRev = 0;
                Double idIncRif = 0;
                Double idLiqRif = 0;

                CooperativaRicercaFDT item = null;
                RevisioneRicercaFDT itemDettRev = null;

                foreach (GVCVRICERCAREV_EFF itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.IdCadenzaRevisione = itemView.R_IDOBJ_CADENZA_REVISIONESafe;
                        item.SoggettaRevisione = (!itemView.IsSTATO_FLAG_REVISIONENull &&
                                    itemView.STATO_FLAG_REVISIONE == 0) ? true : false;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                     
                        item.Revisioni = new List<RevisioneRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<RevisioneRicercaFDT> listaRev = new List<RevisioneRicercaFDT>(item.Revisioni);

                        if (idRifRev != itemView.REV_IDOBJ)
                        {
                            itemDettRev = new RevisioneRicercaFDT();
                            itemDettRev.IdRevisione = itemView.REV_IDOBJ;
                            itemDettRev.AnnoRevisione = itemView.REV_ANNO_REVISIONE;
                            if (!itemView.IsREV_IDOBJ_ESITO_REVISIONENull)
                                itemDettRev.IdEsitoRevisione = itemView.REV_IDOBJ_ESITO_REVISIONESafe;
                            itemDettRev.IdTipoRevisione = itemView.REV_IDOBJ_TIPO_REVISIONE;
                            if (!itemView.IsREV_DATA_CONCLUSIONENull)
                                itemDettRev.DataConclusione = itemView.REV_DATA_CONCLUSIONE;
                            if (!itemView.IsREV_DATA_DEPOSITO_RELAZIONENull)
                                itemDettRev.DataDepositoRelazione = itemView.REV_DATA_DEPOSITO_RELAZIONE;
                            if (!itemView.IsREV_DATA_DETERMINA_REVOCANull)
                                itemDettRev.DataDeterminaRevoca = itemView.REV_DATA_DETERMINA_REVOCA;
                            if (!itemView.IsREV_DATA_DELIBERA_REVOCANull)
                                itemDettRev.DataDeliberaRevoca = itemView.REV_DATA_DELIBERA_REVOCA;
                            itemDettRev.NumeroDeterminaRevoca = itemView.REV_NUMERO_DETERMINA_REVOCASafe;
                            itemDettRev.OrganoRevisore = itemView.REV_DESC_ORGANO_REVISORESafe;

                            itemDettRev.Liquidazioni = new List<CompensoLiquidazioneRicercaFDT>();
                            itemDettRev.Compensi = new List<CompensoRicercaFDT>();

                            listaRev.Add(itemDettRev);

                            item.Revisioni = listaRev;
                            idRifRev = itemDettRev.IdRevisione;
                        }

                        if (itemDettRev != null)
                        {
                            //aggiungo dettaglio
                            if (itemView.IsINC_IDOBJNull)
                            {
                                //Dettaglio liquidazione
                                if (itemView.LIQ_IDOBJ != idLiqRif)
                                {
                                    List<CompensoLiquidazioneRicercaFDT> listaLiq = new List<CompensoLiquidazioneRicercaFDT>(itemDettRev.Liquidazioni);
                                    CompensoLiquidazioneRicercaFDT itemDettLiq = new CompensoLiquidazioneRicercaFDT();

                                    if (!itemView.IsLIQ_DATA_DETERMINANull)
                                        itemDettLiq.DataDetermina = itemView.LIQ_DATA_DETERMINA;
                                    if (!itemView.IsLIQ_DATA_DOMANDANull)
                                        itemDettLiq.DataRicevimentoDomanda = itemView.LIQ_DATA_DOMANDA;
                                    if (!itemView.IsLIQ_IMPORTO_CONTRIBUTONull)
                                        itemDettLiq.ImportoErogato = itemView.LIQ_IMPORTO_CONTRIBUTO;
                                    itemDettLiq.Liquidato = (!itemView.IsLIQ_LIQUIDATONull &&
                                    itemView.LIQ_LIQUIDATO == 1) ? true : false;
                                    itemDettLiq.NumeroDetermina = itemView.LIQ_NUMERO_DETERMINASafe;

                                    listaLiq.Add(itemDettLiq);

                                    item.Revisioni[item.Revisioni.Count - 1].Liquidazioni = listaLiq;

                                    idLiqRif = itemView.LIQ_IDOBJ;
                                }
                            }
                            else
                            {
                                //Dettaglio incarico + compenso
                                if (itemView.INC_IDOBJ != idIncRif)
                                {
                                    List<CompensoRicercaFDT> listaComp = new List<CompensoRicercaFDT>(itemDettRev.Compensi);
                                    CompensoRicercaFDT itemDettComp = new CompensoRicercaFDT();

                                    if (!itemView.IsINC_DATA_DELIBERA_INCARICONull)
                                        itemDettComp.DataDeliberaCommissioneIncarico = itemView.INC_DATA_DELIBERA_INCARICO;
                                    if (!itemView.IsINC_DATA_DETERMINA_INCARICONull)
                                        itemDettComp.DataDeterminaIncarico = itemView.INC_DATA_DETERMINA_INCARICO;
                                    itemDettComp.NumeroDeterminaIncarico = itemView.INC_NUMERO_DETERMINA_INCARICOSafe;
                                    if (!itemView.IsINC_DATA_SCADENZA_TEORICANull)
                                        itemDettComp.DataScadenzaTeorica = itemView.INC_DATA_SCADENZA_TEORICA;
                                    if (!itemView.IsINC_IMPEGNONull)
                                        itemDettComp.ImportoImpegno = itemView.INC_IMPEGNO;
                                    itemDettComp.Revisore = itemView.COMPENSI_SOGG_DESCSafe;
                                    if (!itemView.IsCOMPENSI_TOTALENull)
                                        itemDettComp.ImportoTotale = itemView.COMPENSI_TOTALE;

                                    listaComp.Add(itemDettComp);

                                    item.Revisioni[item.Revisioni.Count - 1].Compensi = listaComp;

                                    idIncRif = itemView.INC_IDOBJ;
                                }
                            }
                        }
                    }

                    idRif = item.IdRegistro;

                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca revisioni effettuate

        #region Ricerca revisioni da effettuare

        public static CooperativaRicercaFDT[] ConvertAllIntoRevisioniDaEff(GVCVRICERCAREV_DAEFF[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                int idRifRev = 0;

                CooperativaRicercaFDT item = null;
                RevisioneRicercaFDT itemDettRev = null;

                foreach (GVCVRICERCAREV_DAEFF itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.IdCadenzaRevisione = itemView.R_IDOBJ_CADENZA_REVISIONESafe;
                        item.IdStatoIscrizione = itemView.R_IDOBJ_STATOSafe;
                        item.RevisioneStraordinaria = false;
                        item.Revisioni = new List<RevisioneRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<RevisioneRicercaFDT> listaRev = new List<RevisioneRicercaFDT>(item.Revisioni);

                        if (!itemView.IsREV_IDOBJNull)
                        {
                            if (idRifRev != itemView.REV_IDOBJ)
                            {
                                itemDettRev = new RevisioneRicercaFDT();
                                if (!itemView.IsREV_IDOBJNull)
                                    itemDettRev.IdRevisione = itemView.REV_IDOBJ;
                                if (!itemView.IsREV_ANNO_REVISIONENull)
                                    itemDettRev.AnnoRevisione = itemView.REV_ANNO_REVISIONE;
                                if (!itemView.IsREV_IDOBJ_ESITO_REVISIONENull)
                                    itemDettRev.IdEsitoRevisione = itemView.REV_IDOBJ_ESITO_REVISIONE;
                                if (!itemView.IsREV_IDOBJ_TIPO_REVISIONENull)
                                {
                                    itemDettRev.IdTipoRevisione = itemView.REV_IDOBJ_TIPO_REVISIONE;
                                    if (itemView.REV_IDOBJ_TIPO_REVISIONE == TipoRevisione.BIENNALE_STRAORDINARIA ||
                                        itemView.REV_IDOBJ_TIPO_REVISIONE == TipoRevisione.STRAORDINARIA)
                                        item.RevisioneStraordinaria = true;
                                }
                                if (!itemView.IsREV_DATA_CONCLUSIONENull)
                                    itemDettRev.DataConclusione = itemView.REV_DATA_CONCLUSIONE;
                                if (!itemView.IsREV_DATA_DEPOSITO_RELAZIONENull)
                                    itemDettRev.DataDepositoRelazione = itemView.REV_DATA_DEPOSITO_RELAZIONE;
                                if (!itemView.IsREV_DATA_DETERMINA_REVOCANull)
                                    itemDettRev.DataDeterminaRevoca = itemView.REV_DATA_DETERMINA_REVOCA;
                                itemDettRev.NumeroDeterminaRevoca = itemView.REV_NUMERO_DETERMINA_REVOCASafe;
                                itemDettRev.OrganoRevisore = itemView.REV_DESC_ORGANO_REVISORESafe;

                                itemDettRev.Compensi = new List<CompensoRicercaFDT>();

                                listaRev.Add(itemDettRev);

                                item.Revisioni = listaRev;

                                idRifRev = itemDettRev.IdRevisione;
                            }

                            if (itemDettRev != null)
                            {
                                //aggiungo dettaglio

                                if (!itemView.IsINC_IDOBJNull)
                                {
                                    //Dettaglio incarico + compenso
                                    List<CompensoRicercaFDT> listaComp = new List<CompensoRicercaFDT>(itemDettRev.Compensi);
                                    CompensoRicercaFDT itemDettComp = new CompensoRicercaFDT();

                                    if (!itemView.IsINC_DATA_DELIBERA_INCARICONull)
                                        itemDettComp.DataDeliberaCommissioneIncarico = itemView.INC_DATA_DELIBERA_INCARICO;
                                    if (!itemView.IsINC_DATA_DETERMINA_INCARICONull)
                                        itemDettComp.DataDeterminaIncarico = itemView.INC_DATA_DETERMINA_INCARICO;
                                    itemDettComp.NumeroDeterminaIncarico = itemView.INC_NUMERO_DETERMINA_INCARICOSafe;
                                    if (!itemView.IsINC_DATA_SCADENZA_TEORICANull)
                                        itemDettComp.DataScadenzaTeorica = itemView.INC_DATA_SCADENZA_TEORICA;
                                    if (!itemView.IsINC_IMPEGNONull)
                                        itemDettComp.ImportoImpegno = itemView.INC_IMPEGNO;
                                    itemDettComp.Revisore = itemView.COMPENSI_SOGG_DESCSafe;
                                    //if (!itemView.IsCOMPENSI_TOTALENull)
                                    //    itemDettComp.ImportoTotale = itemView.COMPENSI_TOTALE;

                                    listaComp.Add(itemDettComp);

                                    if (item.Revisioni != null &&
                                        item.Revisioni.Count >= 1)
                                        item.Revisioni[item.Revisioni.Count - 1].Compensi = listaComp;
                                }
                            }
                        }
                    }

                    idRif = item.IdRegistro;

                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        public static RevisioneCooperativaFlatFDT[] ConvertAllIntoRevisioniDaEffFlat(GVCVRICERCAREV_DAEFF[] itemsToConvert)
        {
            List<RevisioneCooperativaFlatFDT> listResultSearch = new List<RevisioneCooperativaFlatFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                int idRifRev = 0;

                RevisioneCooperativaFlatFDT item = null;

                foreach (GVCVRICERCAREV_DAEFF itemView in itemsToConvert)
                {
                    item = new RevisioneCooperativaFlatFDT();

                    item.IdSoggetto = itemView.S_IDOBJ;
                    item.Denominazione = itemView.S_DENOMINAZIONE;
                    item.IdRegistro = itemView.R_IDOBJSafe;
                    item.NumeroREA = itemView.R_NUMERO_REASafe;
                    item.IdCadenzaRevisione = itemView.R_IDOBJ_CADENZA_REVISIONESafe;
                    item.IdStatoIscrizione = itemView.R_IDOBJ_STATOSafe;
                    item.RevisioneStraordinaria = false;

                    if (!itemView.IsREV_IDOBJNull)
                        item.IdRevisione = itemView.REV_IDOBJ;
                    if (!itemView.IsREV_ANNO_REVISIONENull)
                        item.AnnoRevisione = itemView.REV_ANNO_REVISIONE;
                    if (!itemView.IsREV_IDOBJ_ESITO_REVISIONENull)
                        item.IdEsitoRevisione = itemView.REV_IDOBJ_ESITO_REVISIONE;
                    if (!itemView.IsREV_IDOBJ_TIPO_REVISIONENull)
                    {
                        item.IdTipoRevisione = itemView.REV_IDOBJ_TIPO_REVISIONE;
                        if (itemView.REV_IDOBJ_TIPO_REVISIONE == TipoRevisione.BIENNALE_STRAORDINARIA ||
                            itemView.REV_IDOBJ_TIPO_REVISIONE == TipoRevisione.STRAORDINARIA)
                            item.RevisioneStraordinaria = true;
                    }
                    if (!itemView.IsREV_DATA_CONCLUSIONENull)
                        item.DataConclusione = itemView.REV_DATA_CONCLUSIONE;
                    if (!itemView.IsREV_DATA_DEPOSITO_RELAZIONENull)
                        item.DataDepositoRelazione = itemView.REV_DATA_DEPOSITO_RELAZIONE;
                    if (!itemView.IsREV_DATA_DETERMINA_REVOCANull)
                        item.DataDeterminaRevoca = itemView.REV_DATA_DETERMINA_REVOCA;
                    item.NumeroDeterminaRevoca = itemView.REV_NUMERO_DETERMINA_REVOCASafe;
                    item.OrganoRevisore = itemView.REV_DESC_ORGANO_REVISORESafe;

                    if (!itemView.IsINC_IMPEGNONull)
                        item.ImportoImpegno = itemView.INC_IMPEGNO;
                    item.Revisore = itemView.COMPENSI_SOGG_DESCSafe;

                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca revisioni da effettuare

        #region Ricerca modifiche statutarie

        public static CooperativaRicercaFDT[] ConvertAllIntoModificheStat(GVCVRICERCAMODIFICHE_STAT[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                int idRifAss = 0;
                CooperativaRicercaFDT item = null;
                AssembleaRicercaFDT itemDettAss = null;
                foreach (GVCVRICERCAMODIFICHE_STAT itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJSafe;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        item.Assemblee = new List<AssembleaRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<AssembleaRicercaFDT> listaAss = new List<AssembleaRicercaFDT>(item.Assemblee);

                        if (idRifAss != itemView.ASS_IDOBJ)
                        {
                            itemDettAss = new AssembleaRicercaFDT();
                            itemDettAss.IdDeliberaAssemblea = itemView.ASS_IDOBJSafe;
                            if (!itemView.IsASS_DATA_ASSEMBLEANull)
                                itemDettAss.DataAssemblea = itemView.ASS_DATA_ASSEMBLEA;
                            itemDettAss.IdTipoAssemblea = itemView.ASS_IDOBJ_TIPO_ASSEMBLEASafe;
                            itemDettAss.ModificheStatutarie = new List<ModificaStatRicercaFDT>();

                            listaAss.Add(itemDettAss);

                            item.Assemblee = listaAss;

                            idRifAss = itemDettAss.IdDeliberaAssemblea;
                        }

                        if (itemDettAss != null)
                        {
                            //aggiungo mod stat
                            List<ModificaStatRicercaFDT> listaMod = new List<ModificaStatRicercaFDT>(itemDettAss.ModificheStatutarie);
                            ModificaStatRicercaFDT itemDettMod = new ModificaStatRicercaFDT();

                            itemDettMod.IdTipoModifica = itemView.MODSTAT_IDOBJ_TIPO_MODIFICA;

                            listaMod.Add(itemDettMod);

                            item.Assemblee[item.Assemblee.Count - 1].ModificheStatutarie = listaMod;
                        }
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca modifiche statutarie

        #region Ricerca procedure coatte

        public static CooperativaRicercaFDT[] ConvertAllIntoProcedureCoatte(GVCVRICERCAPROCEDURE_COATTE[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch;

            listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                int idProceduraCoatta = 0;
                List<int> idProroga = new List<int>();
                List<int> idCommisario = new List<int>();
                List<int> idLiquidazione = new List<int>();
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCAPROCEDURE_COATTE itemView in itemsToConvert)
                {
                    if (itemView.R_IDOBJSafe > 0)
                    {
                        if (idRif != itemView.R_IDOBJSafe)
                        {
                            if (item != null)
                            {
                                listResultSearch.Add(item);
                            }

                            item = new CooperativaRicercaFDT();

                            item.IdSoggetto = itemView.S_IDOBJ;
                            item.Denominazione = itemView.S_DENOMINAZIONESafe;
                            item.IdRegistro = itemView.R_IDOBJSafe;
                            item.NumeroREA = itemView.R_NUMERO_REASafe;
                            item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                            item.ProcedureCoatte = new List<ProceduraCoattaRicercaFDT>();

                            idRif = itemView.R_IDOBJ;

                            idProroga.Clear();
                            idCommisario.Clear();
                            idLiquidazione.Clear();
                        }

                        if ((item != null) && (!itemView.IsPROCOA_IDOBJNull) && (itemView.PROCOA_IDOBJ != idProceduraCoatta))
                        {
                            List<ProceduraCoattaRicercaFDT> listaProcedureRicerca = new List<ProceduraCoattaRicercaFDT>(item.ProcedureCoatte);

                            ProceduraCoattaRicercaFDT itemProcCoatta = new ProceduraCoattaRicercaFDT();

                            itemProcCoatta.IdTipoProceduraCoatta = itemView.PROCOA_IDOBJ_TIPO_PROCEDURASafe;
                            itemProcCoatta.NumeroDetermina = itemView.PROCOA_NUMERO_DETERMINASafe;
                            if (!itemView.IsPROCOA_DATA_DETERMINANull)
                                itemProcCoatta.DataDetermina = itemView.PROCOA_DATA_DETERMINA;
                            itemProcCoatta.NumeroDeliberaCommissione = itemView.PROCOA_NUMERO_DELIBERASafe;
                            if (!itemView.IsPROCOA_DATA_DELIBERANull)
                                itemProcCoatta.DataDeliberaCommissione = itemView.PROCOA_DATA_DELIBERA;
                            if (!itemView.IsPROCOA_DATA_INIZIONull)
                                itemProcCoatta.DataInzioProcedura = itemView.PROCOA_DATA_INIZIO;
                            if (!itemView.IsPROCOA_DATA_ISCRIZIONE_RINull)
                                itemProcCoatta.DataIscrizioneRI = itemView.PROCOA_DATA_ISCRIZIONE_RI;
                            if (!itemView.IsPROCOA_DATA_SCADENZANull)
                                itemProcCoatta.DataScadenzaProcedura = itemView.PROCOA_DATA_SCADENZA;
                            if (!itemView.IsPROCOA_DATA_CONCLUSIONENull)
                                itemProcCoatta.DataFineProcedura = itemView.PROCOA_DATA_CONCLUSIONE;
                            itemProcCoatta.NumeroDeterminaFineIncarico = itemView.PROCOA_NUMERO_DETERMINA_FINESafe;
                            if (!itemView.IsPROCOA_DATA_DETERMINA_FINENull)
                                itemProcCoatta.DataDeterminaFineIncarico = itemView.PROCOA_DATA_DETERMINA_FINE;
                            itemProcCoatta.NumeroDeliberaCommissioneFineIncarico = itemView.PROCOA_NUMERO_DELIBERA_FINESafe;
                            if (!itemView.IsPROCOA_DATA_DELIBERA_FINENull)
                                itemProcCoatta.DataDeliberaCommissioneFineIncarico = itemView.PROCOA_DATA_DELIBERA_FINE;

                            itemProcCoatta.Proroghe = new List<ProrogaRicercaFDT>();
                            itemProcCoatta.CompensiCommissari = new List<CompensoCommissarioRicercaFDT>();
                            itemProcCoatta.Liquidazioni = new List<CompensoLiquidazioneRicercaFDT>();

                            listaProcedureRicerca.Add(itemProcCoatta);

                            item.ProcedureCoatte = listaProcedureRicerca;

                            idProceduraCoatta = itemView.PROCOA_IDOBJ;
                        }

                        if ((item.ProcedureCoatte != null) && (item.ProcedureCoatte.Count > 0) && (!itemView.IsPROROGHE_IDOBJNull) && (idProroga.IndexOf(itemView.PROROGHE_IDOBJSafe) < 0))
                        {
                            List<ProrogaRicercaFDT> listaProroghe = new List<ProrogaRicercaFDT>(item.ProcedureCoatte[item.ProcedureCoatte.Count - 1].Proroghe);

                            ProrogaRicercaFDT itemProroga = new ProrogaRicercaFDT();

                            if (!itemView.IsPROROGHE_DATA_PROROGANull)
                                itemProroga.DataProroga = itemView.PROROGHE_DATA_PROROGA;
                            itemProroga.NumeroDetermina = itemView.PROROGHE_NUMERO_DETERMINASafe;
                            if (!itemView.IsPROROGHE_DATA_DETERMINANull)
                                itemProroga.DataDetermina = itemView.PROROGHE_DATA_DETERMINA;
                            itemProroga.NumeroDeliberaCommissione = itemView.PROROGHE_NUMERO_DELIBERASafe;
                            if (!itemView.IsPROROGHE_DATA_DELIBERANull)
                                itemProroga.DataDeliberaCommissione = itemView.PROROGHE_DATA_DELIBERA;

                            listaProroghe.Add(itemProroga);

                            item.ProcedureCoatte[item.ProcedureCoatte.Count - 1].Proroghe = listaProroghe;

                            idProroga.Add(itemView.PROROGHE_IDOBJSafe);
                        }

                        if ((item.ProcedureCoatte != null) && (item.ProcedureCoatte.Count > 0) && (!itemView.IsCOMP_IDOBJNull) && (idCommisario.IndexOf(itemView.COMP_IDOBJSafe) < 0))
                        {
                            List<CompensoCommissarioRicercaFDT> listaCommissari = new List<CompensoCommissarioRicercaFDT>(item.ProcedureCoatte[item.ProcedureCoatte.Count - 1].CompensiCommissari);

                            CompensoCommissarioRicercaFDT itemCompenso = new CompensoCommissarioRicercaFDT();

                            if (itemView.COMP_IDOBJ_SOGGETTOSafe > 0)
                            {
                                itemCompenso.Revisore = itemView.COMP_NOMESafe;
                            }
                            if (!itemView.IsCOMP_PERCENTUALE_CNPNull)
                                itemCompenso.PercentualeCNP = itemView.COMP_PERCENTUALE_CNP;
                            if (!itemView.IsCOMP_PERCENTUALE_IVANull)
                                itemCompenso.PercentualeIVA = itemView.COMP_PERCENTUALE_IVA;
                            if (!itemView.IsCOMP_CASSANull)
                                itemCompenso.ImportoCassa = itemView.COMP_CASSA;
                            if (!itemView.IsCOMP_COMPENSONull)
                                itemCompenso.ImportoCompenso = itemView.COMP_COMPENSO;
                            if (!itemView.IsCOMP_IVANull)
                                itemCompenso.ImportoIVA = itemView.COMP_IVA;
                            if (!itemView.IsCOMP_SPESENull)
                                itemCompenso.ImportoSpese = itemView.COMP_SPESE;
                            if (!itemView.IsCOMP_TOTALENull)
                                itemCompenso.ImportoTotale = itemView.COMP_TOTALE;

                            listaCommissari.Add(itemCompenso);

                            item.ProcedureCoatte[item.ProcedureCoatte.Count - 1].CompensiCommissari = listaCommissari;

                            idCommisario.Add(itemView.COMP_IDOBJSafe);
                        }

                        if ((item.ProcedureCoatte != null) && (item.ProcedureCoatte.Count > 0) && (!itemView.IsCOMPLIQ_IDOBJNull) && (idLiquidazione.IndexOf(itemView.COMPLIQ_IDOBJSafe) < 0))
                        {
                            List<CompensoLiquidazioneRicercaFDT> listaLiquidazioni = new List<CompensoLiquidazioneRicercaFDT>(item.ProcedureCoatte[item.ProcedureCoatte.Count - 1].Liquidazioni);

                            CompensoLiquidazioneRicercaFDT itemLiquidazione = new CompensoLiquidazioneRicercaFDT();

                            if (!itemView.IsCOMPLIQ_DATA_DOMANDANull)
                                itemLiquidazione.DataRicevimentoDomanda = itemView.COMPLIQ_DATA_DOMANDA;
                            itemLiquidazione.NumeroDetermina = itemView.COMPLIQ_NUMERO_DETERMINASafe;
                            if (!itemView.IsCOMPLIQ_DATA_DETERMINANull)
                                itemLiquidazione.DataDetermina = itemView.COMPLIQ_DATA_DETERMINA;
                            if (!itemView.IsCOMPLIQ_IMPORTO_DETERMINATONull)
                                itemLiquidazione.ImportoDeterminato = itemView.COMPLIQ_IMPORTO_DETERMINATO;
                            if (!itemView.IsCOMPLIQ_IMPORTO_CONTRIBUTONull)
                                itemLiquidazione.ImportoErogato = itemView.COMPLIQ_IMPORTO_CONTRIBUTO;
                            itemLiquidazione.Liquidato = itemView.COMPLIQ_LIQUIDATOSafe == 1 ? true : false;
                            itemLiquidazione.NumeroMandatoPagamento = itemView.COMPLIQ_NUMERO_MANDATOSafe;
                            if (!itemView.IsCOMPLIQ_DATA_MANDATONull)
                                itemLiquidazione.DataMandatoPagamento = itemView.COMPLIQ_DATA_MANDATO;

                            listaLiquidazioni.Add(itemLiquidazione);

                            item.ProcedureCoatte[item.ProcedureCoatte.Count - 1].Liquidazioni = listaLiquidazioni;

                            idLiquidazione.Add(itemView.COMPLIQ_IDOBJSafe);
                        }
                    }
                }


                if (item != null)
                {
                    listResultSearch.Add(item);
                }

            }

            return listResultSearch.ToArray();
        }        

        #endregion Ricerca procedure coatte

        #region Ricerca liquidazione coatte

        public static CooperativaRicercaFDT[] ConvertAllIntoLiquidazioniCoatte(GVCVRICERCALIQUIDAZIONI_COATTE[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch;

            listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                int idLiquidazioneCoatta = 0;
                List<double> idDelAcquistoCredFis = new List<double>();
                List<int> idCommisario = new List<int>();
                List<int> idAutorizzazione = new List<int>();
                List<int> idRelazioneSemestrale = new List<int>();            
                List<int> idLiquidazione = new List<int>();
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCALIQUIDAZIONI_COATTE itemView in itemsToConvert)
                {             
                    if (!itemView.IsR_IDOBJNull &&
                        idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONESafe;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        item.LiquidazioniCoatte = new List<LiquidazioneCoattaRicercaFDT>();

                        idRif = itemView.R_IDOBJ;

                        idDelAcquistoCredFis.Clear();
                        idCommisario.Clear();
                        idAutorizzazione.Clear();
                        idRelazioneSemestrale.Clear();
                        idLiquidazione.Clear();
                    }

                    if ((item != null) && (!itemView.IsLIQCOA_IDOBJNull) && (itemView.LIQCOA_IDOBJ != idLiquidazioneCoatta))
                    {
                        List<LiquidazioneCoattaRicercaFDT> listaLiquidazioneRicerca = new List<LiquidazioneCoattaRicercaFDT>(item.LiquidazioniCoatte);

                        LiquidazioneCoattaRicercaFDT itemLiqCoatta = new LiquidazioneCoattaRicercaFDT();

                        itemLiqCoatta.IdTipoLiquidazioneCoatta = itemView.LIQCOA_IDOBJ_TIPO_LIQUIDAZIONESafe;
                        itemLiqCoatta.ProceduraTerminata = itemView.LIQCOA_PROCEDURA_CONCLUSASafe == 1 ? true : false;
                        itemLiqCoatta.ProceduraRevocata = itemView.LIQCOA_PROCEDURA_REVOCATASafe == 1 ? true : false;
                        itemLiqCoatta.DepositoBFL = itemView.LIQCOA_DEPOSITO_BFLSafe == 1 ? true : false;
                        if (!itemView.IsLIQCOA_DATA_INSOLVENZANull)
                            itemLiqCoatta.DataSentenzaInsolvenza = itemView.LIQCOA_DATA_INSOLVENZA;
                        if (!itemView.IsLIQCOA_DATA_PUBBLICAZIONENull)
                            itemLiqCoatta.DataPubblicazioneGU = itemView.LIQCOA_DATA_PUBBLICAZIONE;
                        if (!itemView.IsLIQCOA_DATA_DEPOSITO_RINull)
                            itemLiqCoatta.DataDepositoRI = itemView.LIQCOA_DATA_DEPOSITO_RI;
                        if (!itemView.IsLIQCOA_DATA_DELIBERA_GIUNTANull)
                            itemLiqCoatta.DataDeliberaGiunta = itemView.LIQCOA_DATA_DELIBERA_GIUNTA;
                        itemLiqCoatta.NumeroDeliberaGiunta = itemView.LIQCOA_NUMERO_DELIBERA_GIUNTASafe;
                        if (!itemView.IsLIQCOA_DATA_DELIBERANull)
                            itemLiqCoatta.DataDeliberaCommissione = itemView.LIQCOA_DATA_DELIBERA;
                        itemLiqCoatta.NumeroDeliberaCommissione = itemView.LIQCOA_NUMERO_DELIBERASafe;
                        if (!itemView.IsLIQCOA_DATA_DETERMINANull)
                            itemLiqCoatta.DataDetermina = itemView.LIQCOA_DATA_DETERMINA;
                        itemLiqCoatta.NumeroDetermina = itemView.LIQCOA_NUMERO_DETERMINASafe;

                        itemLiqCoatta.AcquistoCreditiFiscali = new List<DeliberaAcquistoCreditiFiscRicercaFDT>();
                        itemLiqCoatta.CompensiCommissari = new List<CompensoCommissarioRicercaFDT>();
                        itemLiqCoatta.Autorizzazioni = new List<AutorizzazioneRicercaFDT>();
                        itemLiqCoatta.RelazioniSemestrali = new List<RelazioneSemestraleRicercaFDT>();
                        itemLiqCoatta.LiquidazioneSpeseProcedure = new List<CompensoLiquidazioneRicercaFDT>();

                        listaLiquidazioneRicerca.Add(itemLiqCoatta);

                        item.LiquidazioniCoatte = listaLiquidazioneRicerca;

                        idLiquidazioneCoatta = itemView.LIQCOA_IDOBJ;
                    }

                    if ((item.LiquidazioniCoatte != null) && (item.LiquidazioniCoatte.Count > 0) && (!itemView.IsCREFIS_IDOBJNull) && (idDelAcquistoCredFis.IndexOf(itemView.CREFIS_IDOBJ) < 0))
                    {
                        List<DeliberaAcquistoCreditiFiscRicercaFDT> listaAcquistoCreditiFisc = new List<DeliberaAcquistoCreditiFiscRicercaFDT>(item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].AcquistoCreditiFiscali);
                        
                        DeliberaAcquistoCreditiFiscRicercaFDT itemAcquistoCreditiFisc = new DeliberaAcquistoCreditiFiscRicercaFDT();

                        if (!itemView.IsCREFIS_IMPORTONull)
                            itemAcquistoCreditiFisc.Importo = itemView.CREFIS_IMPORTO;
                        if (!itemView.IsCREFIS_DATA_DELIBERANull)
                            itemAcquistoCreditiFisc.DataDelibera = itemView.CREFIS_DATA_DELIBERA;
                        itemAcquistoCreditiFisc.NumeroDelibera = itemView.CREFIS_NUMERO_DELIBERASafe;

                        listaAcquistoCreditiFisc.Add(itemAcquistoCreditiFisc);

                        item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].AcquistoCreditiFiscali = listaAcquistoCreditiFisc;

                        idDelAcquistoCredFis.Add(itemView.CREFIS_IDOBJ);
                    }


                    if ((item.LiquidazioniCoatte != null) && (item.LiquidazioniCoatte.Count > 0) && (!itemView.IsCOMP_IDOBJNull) && (idCommisario.IndexOf(itemView.COMP_IDOBJSafe) < 0))
                    {
                        List<CompensoCommissarioRicercaFDT> listaCommissari = new List<CompensoCommissarioRicercaFDT>(item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].CompensiCommissari);

                        CompensoCommissarioRicercaFDT itemCompenso = new CompensoCommissarioRicercaFDT();

                        if (itemView.COMP_IDOBJ_SOGGETTOSafe > 0)
                        {
                            itemCompenso.Revisore = itemView.COMP_NOMESafe;
                        }
                        if (!itemView.IsCOMP_PERCENTUALE_CNPNull)
                            itemCompenso.PercentualeCNP = itemView.COMP_PERCENTUALE_CNP;
                        if (!itemView.IsCOMP_PERCENTUALE_IVANull)
                            itemCompenso.PercentualeIVA = itemView.COMP_PERCENTUALE_IVA;
                        if (!itemView.IsCOMP_CASSANull)
                            itemCompenso.ImportoCassa = itemView.COMP_CASSA;
                        if (!itemView.IsCOMP_COMPENSONull)
                            itemCompenso.ImportoCompenso = itemView.COMP_COMPENSO;
                        if (!itemView.IsCOMP_IVANull)
                            itemCompenso.ImportoIVA = itemView.COMP_IVA;
                        if (!itemView.IsCOMP_SPESENull)
                            itemCompenso.ImportoSpese = itemView.COMP_SPESE;
                        if (!itemView.IsCOMP_TOTALENull)
                            itemCompenso.ImportoTotale = itemView.COMP_TOTALE;

                        listaCommissari.Add(itemCompenso);

                        item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].CompensiCommissari = listaCommissari;

                        idCommisario.Add(itemView.COMP_IDOBJSafe);
                    }

                    if ((item.LiquidazioniCoatte != null) && (item.LiquidazioniCoatte.Count > 0) && (!itemView.IsAUTO_IDOBJNull) && (idAutorizzazione.IndexOf(itemView.AUTO_IDOBJSafe) < 0))
                    {
                        List<AutorizzazioneRicercaFDT> listaAutorizzazione = new List<AutorizzazioneRicercaFDT>(item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].Autorizzazioni);

                        AutorizzazioneRicercaFDT itemAutorizzazione = new AutorizzazioneRicercaFDT();

                        itemAutorizzazione.Note = itemView.AUTO_NOTESafe;
                        if (!itemView.IsAUTO_DATA_DETERMINANull)
                            itemAutorizzazione.DataDetermina = itemView.AUTO_DATA_DETERMINA;
                        itemAutorizzazione.NumeroDetermina = itemView.AUTO_NUMERO_DETERMINASafe;
                        if (!itemView.IsAUTO_DATA_DELIBERANull)
                            itemAutorizzazione.DataDeliberaCommissione = itemView.AUTO_DATA_DELIBERA;
                        itemAutorizzazione.NumeroDeliberaCommissione = itemView.AUTO_NUMERO_DELIBERASafe;
                        itemAutorizzazione.IdTipoAutorizzazione = itemView.AUTO_IDOBJ_TIPOSafe;
                        itemAutorizzazione.DescrizioneDatoStorico = itemView.AUTO_DESCRIZIONESafe;
                        if (!itemView.IsAUTO_DATA_ISTANZANull)
                            itemAutorizzazione.DataIstanza = itemView.AUTO_DATA_ISTANZA;

                        listaAutorizzazione.Add(itemAutorizzazione);

                        item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].Autorizzazioni = listaAutorizzazione;

                        idAutorizzazione.Add(itemView.AUTO_IDOBJSafe);
                    }

                    if ((item.LiquidazioniCoatte != null) && (item.LiquidazioniCoatte.Count > 0) && (!itemView.IsRELSEM_IDOBJNull) && (idRelazioneSemestrale.IndexOf(itemView.RELSEM_IDOBJSafe) < 0))
                    {
                        List<RelazioneSemestraleRicercaFDT> listaRelazioneSemestrale = new List<RelazioneSemestraleRicercaFDT>(item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].RelazioniSemestrali);

                        RelazioneSemestraleRicercaFDT itemRelazioneSemestrale = new RelazioneSemestraleRicercaFDT();

                        if (!itemView.IsRELSEM_DATA_ESAMENull)
                            itemRelazioneSemestrale.DataEsameufficio = itemView.RELSEM_DATA_ESAME;
                        if (!itemView.IsRELSEM_DATA_PARERENull)
                            itemRelazioneSemestrale.DataEsitoCommissione = itemView.RELSEM_DATA_PARERE;
                        if (!itemView.IsRELSEM_DATA_RELAZIONENull)
                            itemRelazioneSemestrale.DataRelazione = itemView.RELSEM_DATA_RELAZIONE;
                        itemRelazioneSemestrale.Note = itemView.RELSEM_NOTESafe;

                        listaRelazioneSemestrale.Add(itemRelazioneSemestrale);

                        item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].RelazioniSemestrali = listaRelazioneSemestrale;

                        idRelazioneSemestrale.Add(itemView.RELSEM_IDOBJSafe);
                    }

                    if ((item.LiquidazioniCoatte != null) && (item.LiquidazioniCoatte.Count > 0) && (!itemView.IsCOMPLIQ_IDOBJNull) && (idLiquidazione.IndexOf(itemView.COMPLIQ_IDOBJSafe) < 0))
                    {
                        List<CompensoLiquidazioneRicercaFDT> listaLiquidazioni = new List<CompensoLiquidazioneRicercaFDT>(item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].LiquidazioneSpeseProcedure);

                        CompensoLiquidazioneRicercaFDT itemLiquidazione = new CompensoLiquidazioneRicercaFDT();

                        if (!itemView.IsCOMPLIQ_DATA_DOMANDANull)
                            itemLiquidazione.DataRicevimentoDomanda = itemView.COMPLIQ_DATA_DOMANDA;
                        itemLiquidazione.NumeroDetermina = itemView.COMPLIQ_NUMERO_DETERMINASafe;
                        if (!itemView.IsCOMPLIQ_DATA_DETERMINANull)
                            itemLiquidazione.DataDetermina = itemView.COMPLIQ_DATA_DETERMINA;
                        if (!itemView.IsCOMPLIQ_IMPORTO_DETERMINATONull)
                            itemLiquidazione.ImportoDeterminato = itemView.COMPLIQ_IMPORTO_DETERMINATO;
                        if (!itemView.IsCOMPLIQ_IMPORTO_CONTRIBUTONull)
                            itemLiquidazione.ImportoErogato = itemView.COMPLIQ_IMPORTO_CONTRIBUTO;
                        itemLiquidazione.Liquidato = itemView.COMPLIQ_LIQUIDATOSafe == 1 ? true : false;
                        itemLiquidazione.NumeroMandatoPagamento = itemView.COMPLIQ_NUMERO_MANDATOSafe;
                        if (!itemView.IsCOMPLIQ_DATA_MANDATONull)
                            itemLiquidazione.DataMandatoPagamento = itemView.COMPLIQ_DATA_MANDATO;
                        if (!itemView.IsCOMPLIQ_IMPORTO_SPESENull)
                            itemLiquidazione.ImportoSpeseBFL = itemView.COMPLIQ_IMPORTO_SPESE;

                        listaLiquidazioni.Add(itemLiquidazione);

                        item.LiquidazioniCoatte[item.LiquidazioniCoatte.Count - 1].LiquidazioneSpeseProcedure = listaLiquidazioni;

                        idLiquidazione.Add(itemView.COMPLIQ_IDOBJSafe);
                    }
                }

                if (item != null)
                {
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca liquidazione coatte        

        #region Ricerca procedimenti

        public static CooperativaRicercaFDT[] ConvertAllIntoProcedimenti(GVCVRICERCAPROCEDIMENTI[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCAPROCEDIMENTI itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        item.Procedimenti = new List<ProcedimentoRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<ProcedimentoRicercaFDT> listaProc = new List<ProcedimentoRicercaFDT>(item.Procedimenti);

                        ProcedimentoRicercaFDT itemDett = new ProcedimentoRicercaFDT();

                        itemDett.IdTipoProcedimento = itemView.PRO_IDOBJ_TIPO_PROCEDIMENTO;
                        if (!itemView.IsPRO_DATA_INIZIONull)
                            itemDett.DataInizioProcedimento = itemView.PRO_DATA_INIZIO;
                        if (!itemView.IsPRO_DATA_TEORICA_FINENull)
                            itemDett.DataFineTeorica = itemView.PRO_DATA_TEORICA_FINE;
                        itemDett.IdTipoSospensione = itemView.PRO_IDOBJ_TIPO_SOSPENSIONESafe;
                        if (!itemView.IsPRO_DATA_RIATTIVAZIONENull)
                            itemDett.DataRiattivazione = itemView.PRO_DATA_RIATTIVAZIONE;
                        if (!itemView.IsPRO_DATA_TERMINE_FINENull)
                            itemDett.DataTermineFinale = itemView.PRO_DATA_TERMINE_FINE;
                        itemDett.IdTipoConclusione = itemView.PRO_IDOBJ_TIPO_CONCLUSIONESafe;
                        if (!itemView.IsPRO_DATA_FINENull)
                        itemDett.DataConclusione = itemView.PRO_DATA_FINE;
                        itemDett.Stato = itemView.PRO_STATOSafe;

                        listaProc.Add(itemDett);

                        item.Procedimenti = listaProc;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }
       
        #endregion Ricerca procedimenti

        #region Ricerca annotazioni/scadenze

        public static CooperativaRicercaFDT[] ConvertAllIntoAnnotazioni(GVCVRICERCAANNOTAZIONI[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCAANNOTAZIONI itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        item.ScadenzaAnnotazioni = new List<ScadenziarioRicercaFDT>();
                    }
                   
                    if (item != null)
                    {
                        List<ScadenziarioRicercaFDT> listaAnnotazioni = new List<ScadenziarioRicercaFDT>(item.ScadenzaAnnotazioni);

                        ScadenziarioRicercaFDT itemScad = new ScadenziarioRicercaFDT();

                        itemScad.DataAnnotazione = itemView.ANN_DATA_ANNOTAZIONE;
                        if (!itemView.IsANN_DATA_EVASIONENull)
                            itemScad.DataEvasione = itemView.ANN_DATA_EVASIONE;
                        if (!itemView.IsANN_DATA_SCADENZANull)
                            itemScad.DataScadenza = itemView.ANN_DATA_SCADENZA;
                        itemScad.Descrizione = itemView.ANN_DESCRIZIONESafe;
                        itemScad.Evasa = itemView.ANN_EVASASafe == 1 ? true : false;
                        itemScad.IdTipoScadenziario = itemView.ANN_IDOBJ_TIPO_NOTA;
                        itemScad.RiservataUfficio = itemView.ANN_RISERVATASafe == 1 ? true : false;

                        listaAnnotazioni.Add(itemScad);

                        item.ScadenzaAnnotazioni = listaAnnotazioni;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca annotazioni/scadenze

        #region Ricerca documentazione

        public static CooperativaRicercaFDT[] ConvertAllIntoDocumentazione(GVCVRICERCADOCUMENTAZIONE[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCADOCUMENTAZIONE itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJSafe;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        item.Documentazioni = new List<DocumentazioneRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<DocumentazioneRicercaFDT> listaDoc = new List<DocumentazioneRicercaFDT>(item.Documentazioni);

                        DocumentazioneRicercaFDT itemDett = new DocumentazioneRicercaFDT();

                        itemDett.IdDocumentazione = itemView.DOC_ID_OBJ;
                        itemDett.DataDocumento = itemView.DOC_DATA;
                        itemDett.IdTipoDocumentazione = itemView.DOC_IDOBJ_TIPOSafe;
                        itemDett.NomeFile = itemView.DOC_NOME_FILESafe;
                        itemDett.NumeroProtocollo = itemView.DOC_NUMERO_PROTOCOLLOSafe;
                        itemDett.Titolo = itemView.DOC_SEGNALIBROSafe;
                        itemDett.Dimensione = itemView.DOC_DIMENSIONESafe;
                        itemDett.SetIcon();


                        listaDoc.Add(itemDett);

                        item.Documentazioni = listaDoc;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca documentazione

        #region Ricerca bilancio

        public static CooperativaRicercaFDT[] ConvertAllIntoBilanci(GVCVRICERCABILANCI[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCABILANCI itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.IdRegistro = itemView.R_IDOBJ;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.Denominazione = itemView.S_DENOMINAZIONESafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        if (!itemView.IsBIL_DATA_RIFERIMENTONull)
                            item.BilancioEsercizioAl = itemView.BIL_DATA_RIFERIMENTO;

                        item.Bilanci = new List<BilancioRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<BilancioRicercaFDT> listaDett = new List<BilancioRicercaFDT>(item.Bilanci);

                        BilancioRicercaFDT itemDett = new BilancioRicercaFDT();

                        if (!itemView.IsBIL_ANNO_RIFERIMENTONull)
                            itemDett.Anno = itemView.BIL_ANNO_RIFERIMENTO;
                        if (!itemView.IsBIL_DATA_RIFERIMENTONull)
                            itemDett.DataEsercizio = itemView.BIL_DATA_RIFERIMENTO;
                        if (!itemView.IsBIL_IDOBJ_TIPO_BILANCIONull)
                            itemDett.IdTipoBilancio = itemView.BIL_IDOBJ_TIPO_BILANCIO;
                        if (!itemView.IsBIL_IMPORTO_PATRIMONIONull)
                            itemDett.ImportoPatrimonio = itemView.BIL_IMPORTO_PATRIMONIO;
                        if (!itemView.IsBIL_IMPORTO_PERCENTO_UTILINull)
                            itemDett.ImportoPercUtili = itemView.BIL_IMPORTO_PERCENTO_UTILI;
                        itemDett.Pagamento = itemView.BIL_VERIFICA_PAGAMENTOSafe;
                        if (!itemView.IsBIL_DATA_DEPOSITO_RINull)
                            itemDett.DataDepositoBilancioRI = itemView.BIL_DATA_DEPOSITO_RI;
                        if (!itemView.IsBIL_DATA_SEGNALAZIONENull)
                            itemDett.DataSegnalazioneRevisoreLegale = itemView.BIL_DATA_SEGNALAZIONE;

                        listaDett.Add(itemDett);

                        item.Bilanci = listaDett;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca bilancio

        #region Ricerca fallimenti

        public static CooperativaRicercaFDT[] ConvertAllIntoFallimenti(GVCVRICERCAFALLIMENTI[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCAFALLIMENTI itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.IdRegistro = itemView.R_IDOBJ;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.Denominazione = itemView.S_DENOMINAZIONESafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;

                        item.Fallimenti = new List<FallimentoRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<FallimentoRicercaFDT> listaDett = new List<FallimentoRicercaFDT>(item.Fallimenti);

                        FallimentoRicercaFDT itemDett = new FallimentoRicercaFDT();

                        //if (itemDett.Curatore != null)
                            //                        itemFall.Curatore = fallimento.Curatore.DescrizioneBreve;

                        if (!itemView.IsFALL_DATA_FINENull)
                        itemDett.DataFineProcedura = itemView.FALL_DATA_FINE;
                        itemDett.DataSentenza = itemView.FALL_DATA_SENTENZA;
                        itemDett.Esito = itemView.FALL_ESITOSafe;
                        itemDett.Tribunale = itemView.FALL_TRIBUNALESafe;
                        itemDett.Curatore = itemView.SGG_DESCRIZIONESafe;

                        listaDett.Add(itemDett);

                        item.Fallimenti = listaDett;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca fallimenti

        #region Ricerca sanzioni

        public static CooperativaRicercaFDT[] ConvertAllIntoSanzioni(GVCVRICERCASANZIONI[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCASANZIONI itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJSafe;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                        item.Sanzioni = new List<SanzioneRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<SanzioneRicercaFDT> listaSanzioni = new List<SanzioneRicercaFDT>(item.Sanzioni);

                        SanzioneRicercaFDT itemS = new SanzioneRicercaFDT();
                        itemS.NaturaTrasgressione = itemView.SAN_IDOBJ_TIPO_TRASGRESSIONE;
                        itemS.DataRilievoInfrazione = itemView.SAN_DATA_RILIEVO_INFRAZIONE;
                        if (!itemView.IsSAN_DATA_ARCHIVIAZIONENull)
                            itemS.DataArchiviazione = itemView.SAN_DATA_ARCHIVIAZIONE;
                        if (!itemView.IsSAN_DATA_AUDIZIONENull)
                            itemS.DataAudizione = itemView.SAN_DATA_AUDIZIONE;
                        if (!itemView.IsSAN_DATA_PAG_OBLAZIONENull)
                            itemS.DataPagamentoOblazione = itemView.SAN_DATA_PAG_OBLAZIONE;
                        if (!itemView.IsSAN_DATA_RICORSONull)
                            itemS.DataRicorso = itemView.SAN_DATA_RICORSO;
                        if (!itemView.IsSAN_DATA_SCRITTI_DIFENSIVINull)
                            itemS.DataScrittiDifensivi = itemView.SAN_DATA_SCRITTI_DIFENSIVI;
                        if (!itemView.IsSAN_IMPORTO_ORDINANZANull)
                            itemS.ImportoOrdinanza = itemView.SAN_IMPORTO_ORDINANZA;

                        listaSanzioni.Add(itemS);

                        item.Sanzioni = listaSanzioni;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Sanzioni

        #region Ricerca cancellazioni

        public static CooperativaRicercaFDT[] ConvertAllIntoCancellazioni(GVCVRICERCACANCELLAZIONI[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCACANCELLAZIONI itemView in itemsToConvert)
                {
                    if (idRif != itemView.R_IDOBJ)
                    {
                        if (item != null)
                        {
                            listResultSearch.Add(item);
                        }

                        item = new CooperativaRicercaFDT();

                        item.IdSoggetto = itemView.S_IDOBJ;
                        item.Denominazione = itemView.S_DENOMINAZIONE;
                        item.IdRegistro = itemView.R_IDOBJ;
                        item.NumeroREA = itemView.R_NUMERO_REASafe;
                        item.Cancellazioni = new List<CancellazioneRicercaFDT>();
                    }

                    if (item != null)
                    {
                        List<CancellazioneRicercaFDT> listaCanc = new List<CancellazioneRicercaFDT>(item.Cancellazioni);

                        CancellazioneRicercaFDT itemDett = new CancellazioneRicercaFDT();

                        if (!itemView.IsCANC_DATA_DETERMINANull)
                            itemDett.DataDetermina = itemView.CANC_DATA_DETERMINA;
                        if (itemView.CANC_TIPO_1Safe == "2")
                            itemDett.IdTipoCancellazione = 1;
                        else if (itemView.CANC_TIPO_2Safe == "2")
                            itemDett.IdTipoCancellazione = 2;
                        else if (itemView.CANC_TIPO_3Safe == "2")
                            itemDett.IdTipoCancellazione = 3;
                        itemDett.Note = itemView.CANC_NOTESafe;
                        itemDett.NumeroDetermina = itemView.CANC_NUMERO_DETERMINASafe;

                        listaCanc.Add(itemDett);

                        item.Cancellazioni = listaCanc;
                    }

                    idRif = item.IdRegistro;
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca cancellazioni

        #region Ricerca modifiche Parix

        public static CooperativaRicercaFDT[] ConvertAllIntoModificheParix(SegnalazioneFDT[] itemsToConvert)
        {
            if (itemsToConvert != null && itemsToConvert.Length > 0)
            {
                Dictionary<int, CooperativaRicercaFDT> dict = new Dictionary<int, CooperativaRicercaFDT>();
                foreach (SegnalazioneFDT item in itemsToConvert)
                {
                    if (dict.ContainsKey(item.IdRegistro))
                        dict[item.IdRegistro].Segnalazioni.Add(item);
                    else{
                        CooperativaRicercaFDT coopSearch = new CooperativaRicercaFDT();
                        coopSearch.IdRegistro = item.IdRegistro;
                        coopSearch.NumeroREA = item.NumeroRea;
                        coopSearch.IdSoggetto = item.IdSoggetto;
                        coopSearch.Denominazione = item.Denominazione;
                        List<SegnalazioneFDT> segs = new List<SegnalazioneFDT>();
                        segs.Add(item);
                        coopSearch.Segnalazioni = segs;
                        dict.Add(item.IdRegistro, coopSearch);
                    }
                }
                return dict.Values.ToArray<CooperativaRicercaFDT>();
            }
            return null;
        }

        #endregion Ricerca modifiche Parix

        #region Ricerca avanzata cooperative

        public static CooperativaRicercaFDT[] ConvertAllIntoCoopAvanzata(GVCVRICERCACOOPAVANZATA[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                int idRif = 0;
                CooperativaRicercaFDT item = null;

                foreach (GVCVRICERCACOOPAVANZATA itemView in itemsToConvert)
                {
                    if (!itemView.IsR_IDOBJNull)
                    {
                        if (idRif != itemView.R_IDOBJ)
                        {
                            if (item != null)
                            {
                                listResultSearch.Add(item);
                            }

                            item = new CooperativaRicercaFDT();

                            item.IdSoggetto = itemView.S_IDOBJ;
                            item.Denominazione = itemView.S_DENOMINAZIONESafe;
                            item.IdRegistro = itemView.R_IDOBJSafe;
                            item.NumeroREA = itemView.R_NUMERO_REASafe;
                            item.IdStatoIscrizione = itemView.R_IDOBJ_STATOSafe;
                            item.AdesionHeader = itemView.ADESIONE_ASSOCIAZIONESafe;
                            item.IscrizioneHeader = itemView.ISCRIZIONESafe;
                            item.NrScioglimento = itemView.R_NUMERO_SCIOGLIMENTOSafe;
                        }

                        idRif = item.IdRegistro;
                    }
                }

                if (item != null)
                {
                    // Aggiungo l'ultimo
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        #endregion Ricerca avanzata cooperative

        #region Ricerca cooperative attive/cessate

        public static CooperativaRicercaFDT[] ConvertAllActiveCoop(GVCVCOOPERATIVEATTIVE[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                CooperativaRicercaFDT item = null;

                foreach (GVCVCOOPERATIVEATTIVE itemView in itemsToConvert)
                {
                    item = new CooperativaRicercaFDT();
                    item.IdRegistro = itemView.IDOBJ;
                    item.CodiceFiscale = itemView.CODICE_FISCALESafe;
                    item.Denominazione = itemView.DENOMINAZIONESafe;
                    item.NumeroREA = itemView.NUMERO_REASafe;
                    item.NumeroReaNumeric = itemView.REANUMERIC;
                    if (!itemView.IsDATA_DETERMINANull)
                        item.DataIscrizioneRI = itemView.DATA_DETERMINA;
                    item.NumeroRI = itemView.NUMERO_DETERMINASafe;
                    item.IdStatoIscrizione = itemView.IDOBJ_STATOSafe;
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }

        public static CooperativaRicercaFDT[] ConvertAllClosedCoop(GVCVCOOPERATIVECESSATE[] itemsToConvert)
        {
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();

            if (itemsToConvert != null)
            {
                CooperativaRicercaFDT item = null;

                foreach (GVCVCOOPERATIVECESSATE itemView in itemsToConvert)
                {
                    item = new CooperativaRicercaFDT();
                    item.IdRegistro = itemView.IDOBJ;
                    item.CodiceFiscale = itemView.CODICE_FISCALESafe;
                    item.Denominazione = itemView.DENOMINAZIONESafe;
                    item.NumeroREA = itemView.NUMERO_REASafe;
                    item.NumeroReaNumeric = itemView.REANUMERIC;
                  
                    if (!itemView.IsDATA_CANC_REGISTRONull)
                        item.DataCancellazioneRIRegistro = itemView.DATA_CANC_REGISTRO;
                    
                    listResultSearch.Add(item);
                }
            }

            return listResultSearch.ToArray();
        }
        #endregion

        #region Ricerca cooperative parix

        public static CooperativaRicercaFDT[] ConvertAllParixCoops(CooperativaFDT[] itemsToConvert) 
        {
            if (itemsToConvert == null || itemsToConvert.Length == 0)
                return null;
            List<CooperativaRicercaFDT> listResultSearch = new List<CooperativaRicercaFDT>();
            int numeroReaint;
            CooperativaRicercaFDT item;
            foreach (CooperativaFDT itemView in itemsToConvert)
            {
                item = new CooperativaRicercaFDT();
                item.Denominazione = itemView.Denominazione;
                item.NumeroREA = itemView.RegistroCooperativa.NumeroREA;
                if (Int32.TryParse(item.NumeroREA, out numeroReaint))
                    item.NumeroReaNumeric = numeroReaint;
                item.CodiceFiscale = itemView.CodiceFiscale;
                //item.DataIscrizioneRI = itemView.RegistroCooperativa.Iscrizione.DataDetermina;
                //item.NumeroRI = itemView.RegistroCooperativa.Iscrizione.NumeroDetermina;
                if (itemView.RegistroCooperativa.Cancellazione != null && itemView.RegistroCooperativa.Cancellazione.DataCancRegistro!= null)
                    item.DataCancellazioneRIRegistro = itemView.RegistroCooperativa.Cancellazione.DataCancRegistro;
                listResultSearch.Add(item);
            }
            return listResultSearch.ToArray();
        }
        #endregion 
    }
}
