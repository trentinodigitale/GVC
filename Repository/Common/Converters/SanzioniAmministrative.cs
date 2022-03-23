using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.rtier.Service;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {
        #region Methods (4)

        public static SanzioneFDT Convert(GVCTSANZIONI itemToConvert)
        {
            SanzioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new SanzioneFDT();
                item.IdSanzione = itemToConvert.IDOBJ;
                item.IdRegistro = itemToConvert.IDOBJ_REGISTRO;
                item.DataRilievoInfrazione = itemToConvert.DATA_RILIEVO_INFRAZIONE;
                if (!itemToConvert.IsDATA_ARCHIVIAZIONENull)
                    item.DataArchiviazione = itemToConvert.DATA_ARCHIVIAZIONE;
                if (!itemToConvert.IsDATA_AUDIZIONENull)
                    item.DataAudizione = itemToConvert.DATA_AUDIZIONE;
                if (!itemToConvert.IsDATA_ORDINANZANull)
                    item.DataDecretoIngiunzione = itemToConvert.DATA_ORDINANZA;
                if (!itemToConvert.IsDATA_DEPOSITO_RICORSONull)
                    item.DataDepositoRicorso = itemToConvert.DATA_DEPOSITO_RICORSO;
                if (!itemToConvert.IsDATA_INFRAZIONENull)
                    item.DataInfrazione = itemToConvert.DATA_INFRAZIONE;
                if (!itemToConvert.IsDATA_NOTIFICA_INFRAZIONENull)
                    item.DataNotificaInfrazione = itemToConvert.DATA_NOTIFICA_INFRAZIONE;
                if (!itemToConvert.IsDATA_NOTIFICA_ORDINANZANull)
                    item.DataNotificaOrdinanza = itemToConvert.DATA_NOTIFICA_ORDINANZA;
                if (!itemToConvert.IsDATA_PAG_OBLAZIONENull)
                    item.DataPagamentoOblazione = itemToConvert.DATA_PAG_OBLAZIONE;
                if (!itemToConvert.IsDATA_PAGAMENTONull)
                    item.DataPagamentoOrdinanza = itemToConvert.DATA_PAGAMENTO;
                if (!itemToConvert.IsDATA_RACCOMANDATANull)
                    item.DataRicevimentoInfrazione = itemToConvert.DATA_RACCOMANDATA;
                if (!itemToConvert.IsDATA_RACCOMANDATA_ORDINANZANull)
                    item.DataRicevimentoOrdinanza = itemToConvert.DATA_RACCOMANDATA_ORDINANZA;
                if (!itemToConvert.IsDATA_RICORSONull)
                    item.DataRicorso = itemToConvert.DATA_RICORSO;
                if (!itemToConvert.IsDATA_SCADENZA_PAGAMENTONull)
                    item.DataScadenzaPagamento =itemToConvert.DATA_SCADENZA_PAGAMENTO;
                if (!itemToConvert.IsDATA_SCADENZA_PAG_ORDINANZANull)
                    item.DataScadenzaPagamentoOrdinanza = itemToConvert.DATA_SCADENZA_PAG_ORDINANZA;
                if (!itemToConvert.IsDATA_SCRITTI_DIFENSIVINull)
                    item.DataScrittiDifensivi = itemToConvert.DATA_SCRITTI_DIFENSIVI;
                if (!itemToConvert.IsDATA_SENTENZA_RICORSONull)
                    item.DataSentenzaRicorso = itemToConvert.DATA_SENTENZA_RICORSO;
                if (!itemToConvert.IsIMPORTO_SANZIONENull)
                item.EntitaSanzione = itemToConvert.IMPORTO_SANZIONE;
                item.EsitoSentenza = itemToConvert.ESITO_RICORSOSafe;
                    item.IdGiudiceCompetente = itemToConvert.IDOBJ_GIUDICESafe;
                    item.IdLeggeTrasgredita = itemToConvert.IDOBJ_LEGGE_TRASGRESSIONESafe;
                item.IdNaturaTrasgressione = itemToConvert.IDOBJ_TIPO_TRASGRESSIONE;
                if (!itemToConvert.IsIMPORTO_OBLAZIONENull)
                item.ImportoOblazione = itemToConvert.IMPORTO_OBLAZIONE;
                if (!itemToConvert.IsIMPORTO_ORDINANZANull)
                item.ImportoOrdinanza = itemToConvert.IMPORTO_ORDINANZA;
                if (!itemToConvert.IsIMPORTO_PAGAMENTONull)
                item.ImportoPagamento = itemToConvert.IMPORTO_PAGAMENTO;
                item.NoteContraddittorio = itemToConvert.NOTE_CONTRADDITTORIOSafe;
                item.NoteSanzione = itemToConvert.NOTESafe;
                item.NoteOrdinanza = itemToConvert.NOTE_INGIUNZIONESafe;
                item.NumeroArchiviazione = itemToConvert.NUMERO_ARCHIVIAZIONESafe;
                item.NumeroProtocolloIngiunzione = itemToConvert.NUMERO_ORDINANZASafe;
                item.NumeroRecidiva = itemToConvert.NUMERO_RECIDIVASafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;

            }
            return item;
        }

        public static GVCTSANZIONI Convert(SanzioneFDT itemToConvert)
        {
            GVCTSANZIONI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTSANZIONI();
                item.IDOBJ = itemToConvert.IdSanzione;

                item.IDOBJ_REGISTRO = itemToConvert.IdRegistro;
                item.DATA_RILIEVO_INFRAZIONE = itemToConvert.DataRilievoInfrazione;
                if (itemToConvert.DataArchiviazione.HasValue)
                    item.DATA_ARCHIVIAZIONE = itemToConvert.DataArchiviazione.Value;
                if (itemToConvert.DataAudizione.HasValue)
                    item.DATA_AUDIZIONE = itemToConvert.DataAudizione.Value;
                if (itemToConvert.DataDecretoIngiunzione.HasValue)
                    item.DATA_ORDINANZA = itemToConvert.DataDecretoIngiunzione.Value;
                if (itemToConvert.DataDepositoRicorso.HasValue)
                    item.DATA_DEPOSITO_RICORSO = itemToConvert.DataDepositoRicorso.Value;
                if (itemToConvert.DataInfrazione.HasValue)
                    item.DATA_INFRAZIONE = itemToConvert.DataInfrazione.Value;
                if (itemToConvert.DataNotificaInfrazione.HasValue)
                    item.DATA_NOTIFICA_INFRAZIONE = itemToConvert.DataNotificaInfrazione.Value;
                if (itemToConvert.DataNotificaOrdinanza.HasValue)
                    item.DATA_NOTIFICA_ORDINANZA = itemToConvert.DataNotificaOrdinanza.Value;
                if (itemToConvert.DataPagamentoOblazione.HasValue)
                    item.DATA_PAG_OBLAZIONE = itemToConvert.DataPagamentoOblazione.Value;
                if (itemToConvert.DataPagamentoOrdinanza.HasValue)
                    item.DATA_PAGAMENTO = itemToConvert.DataPagamentoOrdinanza.Value;
                if (itemToConvert.DataRicevimentoInfrazione.HasValue)
                    item.DATA_RACCOMANDATA = itemToConvert.DataRicevimentoInfrazione.Value;
                if (itemToConvert.DataRicevimentoOrdinanza.HasValue)
                    item.DATA_RACCOMANDATA_ORDINANZA = itemToConvert.DataRicevimentoOrdinanza.Value;
                if (itemToConvert.DataRicorso.HasValue)
                    item.DATA_RICORSO = itemToConvert.DataRicorso.Value;
                if (itemToConvert.DataScadenzaPagamento.HasValue)
                    item.DATA_SCADENZA_PAGAMENTO = itemToConvert.DataScadenzaPagamento.Value;
                if (itemToConvert.DataScadenzaPagamentoOrdinanza.HasValue)
                    item.DATA_SCADENZA_PAG_ORDINANZA = itemToConvert.DataScadenzaPagamentoOrdinanza.Value;
                if (itemToConvert.DataScrittiDifensivi.HasValue)
                    item.DATA_SCRITTI_DIFENSIVI = itemToConvert.DataScrittiDifensivi.Value;
                if (itemToConvert.DataArchiviazione.HasValue)
                    item.DATA_SENTENZA_RICORSO = itemToConvert.DataSentenzaRicorso.Value;
                item.IMPORTO_SANZIONE = itemToConvert.EntitaSanzione;
                item.ESITO_RICORSO = itemToConvert.EsitoSentenza;
                if (itemToConvert.IdGiudiceCompetente > 0)
                    item.IDOBJ_GIUDICE = itemToConvert.IdGiudiceCompetente;
                else
                    item.IsIDOBJ_GIUDICENull = true;
                if (itemToConvert.IdLeggeTrasgredita > 0)
                    item.IDOBJ_LEGGE_TRASGRESSIONE = itemToConvert.IdLeggeTrasgredita;
                else
                    item.IsIDOBJ_LEGGE_TRASGRESSIONENull = true;
                item.IDOBJ_TIPO_TRASGRESSIONE = itemToConvert.IdNaturaTrasgressione;
                item.IMPORTO_OBLAZIONE = itemToConvert.ImportoOblazione;
                item.IMPORTO_ORDINANZA = itemToConvert.ImportoOrdinanza;
                item.IMPORTO_PAGAMENTO = itemToConvert.ImportoPagamento;
                item.NOTE_CONTRADDITTORIO = itemToConvert.NoteContraddittorio;
                item.NOTE = itemToConvert.NoteSanzione;
                item.NOTE_INGIUNZIONE = itemToConvert.NoteOrdinanza;
                item.NUMERO_ARCHIVIAZIONE = itemToConvert.NumeroArchiviazione;
                item.NUMERO_ORDINANZA = itemToConvert.NumeroProtocolloIngiunzione;
                item.NUMERO_RECIDIVA = itemToConvert.NumeroRecidiva;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static SanzioneFDT[] ConvertAll(GVCTSANZIONI[] itemsToConvert)
        {
            List<SanzioneFDT> listItem = new List<SanzioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTSANZIONI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTSANZIONI[] ConvertAll(SanzioneFDT[] itemsToConvert)
        {
            List<GVCTSANZIONI> listItem = new List<GVCTSANZIONI>();
            if (itemsToConvert != null)
            {
                foreach (SanzioneFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


        #endregion Methods 
    }
}
