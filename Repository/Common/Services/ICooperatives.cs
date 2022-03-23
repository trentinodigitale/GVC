using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.RicercheWrapper;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using OeF.Validation;
using System.Data;

namespace it.dedagroup.GVC.Repository.Common.Services
{
    [ServiceContract(Namespace = "it.dedagroup.GVC.Repository.Common.Services", Name = "Cooperatives")]
    public interface ICooperatives
    {
        #region Cooperativa

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaFDT GetCooperativaByIdRegistro(int idRegistro);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaFDT GetCooperativaById(int idCooperativa);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        string[] SaveCooperativa(CooperativaFDT item, Boolean forceSaving);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaFDT[] SearchCooperativaParix(String name, String fiscalCode, String nrRea, bool includeCeased, out Boolean exception);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        ComunicazioneCaricaSocialeFDT[] GetCaricheSocialiFromParix(String nrRea, String province, out Boolean exception);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        SoggettoPerVisualizzazioneFDT[] GetListCooperativeBySearch(OeF.Utility.Expression query);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaRicercaFDT[] GetListActiveGvcCooperatives();

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaRicercaFDT[] GetListClosedGvcCooperatives(DateTime closedAfterDt);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaRicercaFDT[] GetListActiveParixCooperatives(out Boolean exception);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        CooperativaRicercaFDT[] GetListClosedParixCooperatives(DateTime closedAfterDt, out Boolean exception);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        DataSet GetCooperativeDaEsportare(int[] arrayOfId);

        [OperationContract(ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        DataSet GetCooperativeStatistica(DateTime dataDal, DateTime dataAl, bool soloAttivi);

        #endregion Cooperativa

        #region Cambio posizione

        [OperationContract]
        CambioPosizioneFDT GetCambioPosizioneById(int idCambioPosizione);

        [OperationContract]
        CambioPosizioneFDT[] GetListCambiPosizioneByIdRegistro(int idRegistro);

        [OperationContract]
        CambioPosizioneFDT SaveCambioPosizione(CambioPosizioneFDT item);

        [OperationContract]
        Boolean DeleteCambioPosizione(CambioPosizioneFDT item);

        #endregion Cambio posizione

        #region Indirizzi

        [OperationContract]
        IndirizzoFDT[] GetListIndirizziByIdSoggetto(int idSoggetto);

        [OperationContract]
        IndirizzoFDT GetIndirizzoById(int idIndirizzo);

        [OperationContract]
        IndirizzoFDT SaveIndirizzo(IndirizzoFDT item);

        [OperationContract]
        Boolean DeleteIndirizzo(IndirizzoFDT item);

        #endregion Indirizzi

        #region Cancellazione

        [OperationContract]
        CancellazioneFDT GetCancellazioneById(int idCancellazione);

        [OperationContract]
        CancellazioneFDT GetCancellazioneByIdRegistro(int idRegistro);

        [OperationContract]
        CancellazioneFDT SaveCancellazione(CancellazioneFDT item);

        [OperationContract]
        Boolean DeleteCancellazione(CancellazioneFDT item);

        #endregion Cancellazione

        #region Procedure coatte

        [OperationContract]
        ProceduraCoattaFDT SaveProceduraCoatta(ProceduraCoattaFDT item);

        [OperationContract]
        Boolean DeleteProceduraCoatta(ProceduraCoattaFDT item);

        [OperationContract]
        ProceduraCoattaFDT[] GetListProcedureCoatteByIdRegistro(int idRegistro);

        [OperationContract]
        CooperativaRicercaFDT[] GetListProcedureCoatteBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        #endregion Procedure coatte

        #region Liquidazioni coatte

        [OperationContract]
        CooperativaRicercaFDT[] GetListLiquidazioniCoatteBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        #endregion Liquidazioni coatte

        #region Relazioni semestrali

        [OperationContract]
        CooperativaRicercaFDT[] GetListRelazioniSemestraliBySearch(OeF.Utility.Expression query, DateTime? dataRelazione, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        #endregion Relazioni semestrali

        #region Dizionari

        [OperationContract]
        DizionarioFDT[] GetAllDictionaries();

        [OperationContract]
        DettaglioDizionarioFDT GetDettaglioProcedimentoDictionary(int idDictionary);

        //[OperationContract]
        //DettaglioDizionarioFDT GetDettaglioSanzioneDictionary(int idDictionary);

        [OperationContract]
        DettaglioDizionarioFDT GetDettaglioCadenzaRevDictionary(int idDictionary);

        [OperationContract]
        DizionarioFDT SaveDictionary(DizionarioFDT item);

        [OperationContract]
        string[] DeleteDictionary(DizionarioFDT item);

        #endregion Dizionari

        #region Adesioni

        [OperationContract]
        AdesioneFDT[] GetListAdesioniByIdRegistro(int idRegistro);

        [OperationContract]
        AdesioneFDT GetAdesioneById(int idAdesione);

        [OperationContract]
        AdesioneFDT SaveAdesione(AdesioneFDT item);

        [OperationContract]
        Boolean DeleteAdesione(AdesioneFDT item);

        #endregion Adesioni

        #region Cariche

        [OperationContract]
        CaricaSocialeFDT[] GetListCaricheByIdComunicazione(int idComunicazione);

        [OperationContract]
        CaricaSocialeFDT GetCaricaById(int idItem);

        [OperationContract]
        Boolean DeleteCarica(CaricaSocialeFDT item);

        #endregion Cariche

        #region Comunicazioni Cariche Sociali

        [OperationContract]
        ComunicazioneCaricaSocialeFDT[] GetListComCaricheSocByIdRegistro(int idRegistro);

        [OperationContract]
        ComunicazioneCaricaSocialeFDT GetComCaricaSocById(int idItem);

        [OperationContract]
        Boolean DeleteComCaricaSoc(ComunicazioneCaricaSocialeFDT item);

        #endregion Comunicazioni Cariche Sociali

        #region Comunicazioni Base Sociale

        [OperationContract]
        ComunicazioneBaseSocialeFDT[] GetListBaseSocByIdRegistro(int idRegistro);

        [OperationContract]
        ComunicazioneBaseSocialeFDT GetBaseSocById(int idItem);

        [OperationContract]
        Boolean DeleteBaseSoc(ComunicazioneBaseSocialeFDT item);

        #endregion Comunicazioni Base Sociale

        #region Revisioni

        [OperationContract]
        RevisioneFDT[] GetListRevisioniByIdRegistro(int idRegistro);

        [OperationContract]
        RevisioneFDT GetRevisioneById(int idItem);

        [OperationContract]
        Boolean DeleteRevisione(RevisioneFDT item);

        #endregion Revisioni

        #region Incarichi Revisione

        [OperationContract]
        RevisioneIncaricoFDT[] GetListIncarichiByIdRevisione(int idRevisione);

        [OperationContract]
        RevisioneIncaricoFDT GetIncaricoById(int idItem);

        [OperationContract]
        Boolean DeleteIncarico(RevisioneIncaricoFDT item);

        #endregion Incarichi Revisione

        #region Compenso Revisore

        [OperationContract]
        CompensoFDT GetCompensoById(int idItem);

        [OperationContract]
        Boolean DeleteCompenso(CompensoFDT item);

        #endregion Compenso Revisore

        #region Liquidazione Compensi Revisione

        [OperationContract]
        CompensoLiquidazioneFDT[] GetListLiqCompensiByIdRevisione(int idRevisione);

        [OperationContract]
        CompensoLiquidazioneFDT GetLiqCompensoById(int idItem);

        [OperationContract]
        Boolean DeleteLiqCompenso(CompensoLiquidazioneFDT item);

        #endregion Liquidazione Compensi Revisione

        #region Assemblea

        [OperationContract]
        DeliberaAssembleaFDT SaveAssemblea(DeliberaAssembleaFDT item);

        [OperationContract]
        DeliberaAssembleaFDT[] GetListAssembleeByIdRegistro(int idRegistro);

        [OperationContract]
        DeliberaAssembleaFDT GetAssembleaById(int idItem);

        #endregion Assemblea

        #region Modifiche Statutarie

        [OperationContract]
        ModificaStatutariaFDT[] GetListModificheStatutarieByIdDeliberaAssemblea(int idAssemblea);

        [OperationContract]
        ModificaStatutariaFDT GetModificaStatutariaById(int idModificaStatutaria);

        [OperationContract]
        ModificaStatutariaFDT[] GetModificheStatutarieInternal(int idDeliberaAssemblea);

        [OperationContract]
        ModificaStatutariaFDT SaveModificaStatutaria(ModificaStatutariaFDT item);

        [OperationContract]
        Boolean DeleteModificaStatutaria(ModificaStatutariaFDT item);

        #endregion Modifiche Statutarie

        [OperationContract]
        ViolatedRule[] VerifyNumeroSoci(int numeroSoci, int idCategoria, int idFormaGiuridica);

        [OperationContract]
        ControlloNumeroSociFDT[] GetAllControlloSoci(int tipo);

        [OperationContract]
        ControlloNumeroSociFDT SaveNumeroSoci(ControlloNumeroSociFDT item);

        [OperationContract]
        Boolean DeleteNumeroSoci(ControlloNumeroSociFDT item);

        #region Dati

        [OperationContract]
        DatiFDT GetDati();

        [OperationContract]
        DatiFDT SaveDati(DatiFDT item);

        [OperationContract]
        Boolean DeleteDati(DatiFDT item);

        [OperationContract]
        LeggiTrasgressioneFDT[] GetLeggiSanzioni();

        [OperationContract]
        LeggiTrasgressioneFDT SaveLeggi(LeggiTrasgressioneFDT item);

        [OperationContract]
        Boolean DeleteLeggi(LeggiTrasgressioneFDT item);

        [OperationContract]
        LeggiTrasgressioneFDT GetLeggeSanzioniById(int idItem);

        #endregion

        #region Cartelle

        [OperationContract]
        CartellaFDT[] GetCartelle();

        [OperationContract]
        CartellaFDT GetCartellaById(int idItem);

        [OperationContract]
        CartellaFDT SaveCartella(CartellaFDT item);

        [OperationContract]
        Boolean DeleteCartella(CartellaFDT item);

        #endregion Cartelle

        #region Soggetti

        [OperationContract]
        SoggettoPerVisualizzazioneFDT[] GetSoggettoBySearch(OeF.Utility.Expression query);

        [OperationContract]
        DataSet GetSoggettiDaEsportare(int[] arrayOfIdSoggetti);

        [OperationContract]
        SoggettoFDT GetSoggettoById(int idSoggetto);

        [OperationContract]
        SoggettoFDT SaveSoggetto(SoggettoFDT item);

        [OperationContract]
        string[] DeleteSubject(int idSoggetto);

        #endregion Soggetti

        #region Storico Dati 

        [OperationContract]
        DatiStoriciFDT[] GetListDatiStoriciRegistro(int idRegistro);

        [OperationContract]
        DatiStoriciFDT[] GetListDatiStoriciAssemblea(int idAssemblea);

        #endregion Storico Dati 

        #region CollegamentoSocieta

        [OperationContract]
        Boolean DeleteSocColl(CollegamentoSocietaFDT item);

        #endregion CollegamentoSocieta

        #region Fallimenti

        [OperationContract]
        ProceduraFallimentareFDT GetFallimentoById(int idItem);

        [OperationContract]
        Boolean DeleteFallimento(ProceduraFallimentareFDT item);

        #endregion Fallimenti

        #region Procedimenti

        [OperationContract]
        ProcedimentoFDT[] GetListProcedimentiIdRegistro(int idRegistro);

        [OperationContract]
        ProcedimentoFDT GetProcedimentoById(int idItem);

        [OperationContract]
        Boolean DeleteProcedimento(ProcedimentoFDT item);

        #endregion Procedimenti

        #region Sanzioni amministrative

        [OperationContract]
        SanzioneFDT[] GetListSanzioniIdRegistro(int idRegistro);

        [OperationContract]
        SanzioneFDT GetSanzioneById(int idItem);

        [OperationContract]
        Boolean DeleteSanzione(SanzioneFDT item);

        #endregion Sanzioni amministrative

        #region Bilanci

        [OperationContract]
        BilancioFDT[] GetListBilanciIdRegistro(int idRegistro);

        [OperationContract]
        BilancioFDT GetBilancioById(int idItem);

        [OperationContract]
        Boolean DeleteBilancio(BilancioFDT item);

        #endregion Bilanci

        #region Scadenze Annotazioni

        [OperationContract]
        ScadenziarioFDT[] GetListAnnotazioniIdRegistro(int idRegistro);

        [OperationContract]
        ScadenziarioFDT GetAnnotazioneById(int idItem);

        [OperationContract]
        Boolean DeleteAnnotazione(ScadenziarioFDT item);

        #endregion Scadenze Annotazioni

        #region Segnalazioni

        [OperationContract]
        SegnalazioneFDT[] GetListSegnalazioniByIdRegistro(int idRegistro);

        [OperationContract]
        SegnalazioneFDT[] GetListSegnalazioniByDate(int regNr, DateTime from, DateTime to, int[] segTypes, int visible, int applied);

        [OperationContract]
        Boolean DeleteSegnalazione(SegnalazioneFDT item);

        #endregion Segnalazioni

        #region Aggiornamenti

        [OperationContract]
        AggiornamentoFDT GetAggiornamentoByNrRea(int nrRea);

        #endregion Aggiornamenti

        #region Documentazione

        [OperationContract]
        Byte[] GetDocumentazioneByID(int idDocumentazione);

        #endregion Documentazione

        #region Ricerche

        [OperationContract]
        //CooperativaRicercaFDT[] GetAnnotazioniBySearch(OeF.Utility.Expression query);
        CooperativaRicercaFDT[] GetAnnotazioniBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetDocumentazioneBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetFallimentiBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetProcedimentiBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetCancellazioniBySearch(OeF.Utility.Expression query);

        [OperationContract]
        CooperativaRicercaFDT[] GetBilanciBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione, int annoBil);

        [OperationContract]
        CooperativaRicercaFDT[] GetModificheStatBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetSanzioniBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        RevisioneCooperativaFlatFDT[] GetRevisioniDaEffettuareBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetRevisioniEffettuateBySearch(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione);

        [OperationContract]
        CooperativaRicercaFDT[] GetListCooperativeBySearchAdvanced(OeF.Utility.Expression query, int indexIscrizione, int indexAdesione, DateTime dataRifIscrizione, DateTime DataRifAdesione, int idAssociazione, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc);

        #endregion Ricerche

        #region Lock

        [OperationContract]
        LockFDT SaveLock(LockFDT item);

        [OperationContract]
        LockFDT[] GetListLocks();

        [OperationContract]
        Boolean Unlock(LockFDT item);

        #endregion Lock

        #region Gruppi paritetici 

        [OperationContract]
        GruppoPariteticoFDT SaveGruppoParitetico(GruppoPariteticoFDT item);

        [OperationContract]
        GruppoPariteticoFDT[] GetListGruppiPariteticiBySearch(OeF.Utility.Expression query);

        [OperationContract]
        GruppoPariteticoFDT GetGruppoParitetico(int idGruppo);

        [OperationContract]
        Boolean DeleteGruppoParitetico(GruppoPariteticoFDT item);
                
        #endregion Gruppi paritetici
    }
}
