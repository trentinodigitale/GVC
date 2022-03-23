using System;
using System.Collections.Generic;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.FDT.Dictionaries;
using it.dedagroup.GVC.Repository.rtier.Service;
using it.dedagroup.GVC.Repository.Common.Configurations;

namespace it.dedagroup.GVC.Repository.Common.Converters
{
    public abstract partial class Converters
    {

		#region Methods (4) 


		// Public Methods (4) 

        public static RegistroCooperativaFDT Convert(GVCTREGISTRI itemToConvert)
        {
            RegistroCooperativaFDT item = null;
            if (itemToConvert != null)
            {
                item = new RegistroCooperativaFDT();
                item.IdRegistro = itemToConvert.IDOBJ;
                item.NumeroREA = itemToConvert.NUMERO_REASafe;
                item.IdFormaGiu = itemToConvert.IDOBJ_FORMA_GIURIDICASafe;
                item.IdSoggetto = itemToConvert.IDOBJ_SOGGETTO;
                item.IdStatoIscrizione = itemToConvert.IDOBJ_STATOSafe;
                item.NumeroIscrizioneAlboNaz = itemToConvert.NUMERO_ALBOSafe;
                item.CodiceCooperativa = itemToConvert.CODICE_COOPERATIVASafe;
                if (!itemToConvert.IsDATA_COSTITUZIONENull)
                    item.DataCostituzione = itemToConvert.DATA_COSTITUZIONE;
                if (!itemToConvert.IsDURATANull)
                    item.Durata = itemToConvert.DURATA;
                if (!itemToConvert.IsDATA_DEPOSITO_BFLNull)
                    item.DataDepositoBFL = itemToConvert.DATA_DEPOSITO_BFL;
                if (!itemToConvert.IsESENTE_VERSAMENTO_UTILINull)
                    item.EsenzioneVersamentoUtili = itemToConvert.ESENTE_VERSAMENTO_UTILI == 1 ? true : false;
                item.IdTipoCostituzione = itemToConvert.IDOBJ_TIPO_COSTITUZIONESafe;
                item.NumeroRI = itemToConvert.NUMERO_RISafe;
                item.FormaGiuridicaParix = itemToConvert.FORMA_GIURIDICA_CCIAASafe;
                item.FormaAmministrativaParix = itemToConvert.FORMA_AMM_CCIAASafe;
                item.NumeroRepertorioNotarile = itemToConvert.NUMERO_REPERTORIO_NOTAIOSafe;

                if (itemToConvert.DURATA_ILLIMITATASafe == -1)
                    item.DurataIllimitata = 0;
                else
                    item.DurataIllimitata = itemToConvert.DURATA_ILLIMITATASafe;
                if (!itemToConvert.IsBILANCIO_ESERCIZIO_ALNull)
                    item.BilancioEsercizioAl = itemToConvert.BILANCIO_ESERCIZIO_AL;
                if (!itemToConvert.IsGRUPPO_PARITETICONull)
                    item.GruppoParitetico = itemToConvert.GRUPPO_PARITETICO == 1 ? true : false;
                if (!itemToConvert.IsDATA_BFLNull)
                    item.DataBFL = itemToConvert.DATA_BFL;
                if (!itemToConvert.IsNUMERO_SCIOGLIMENTONull)
                    item.NumeroScioglimento = itemToConvert.NUMERO_SCIOGLIMENTOSafe;
                if (!itemToConvert.IsIMPORTO_VERSAMENTONull)
                    item.ImportoVersamentoPatrimonioResiduo = itemToConvert.IMPORTO_VERSAMENTO;
                item.CodiceOperatore = itemToConvert.CODICE_OPERATORESafe;
                item.CodiceUfficio = itemToConvert.CODICE_UFFICIOSafe;
                item.IdFormaAmm = itemToConvert.IDOBJ_FORMA_AMMINISTRATIVASafe;
                //item.IdSottoCategoriaSociale = itemToConvert.IDOBJ_SOTTOCATEGORIASafe;
                //item.IdCategoria = itemToConvert.IDOBJ_CATEGORIASafe;
                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
                item.IdNotaio = itemToConvert.IDOBJ_NOTAIOSafe;
                item.IdCadenzaRevisione = itemToConvert.IDOBJ_CADENZA_REVISIONESafe;
                if (!itemToConvert.IsDATA_ACQUISIZIONE_ATTONull)
                    item.DataAcquisizioneAtto = itemToConvert.DATA_ACQUISIZIONE_ATTO;
                if (!itemToConvert.IsDATA_DEPOSITO_ATTONull)
                    item.DataDepositoAtto = itemToConvert.DATA_DEPOSITO_ATTO;
                if (!itemToConvert.IsDATA_ESAMENull)
                    item.DataEsameComm = itemToConvert.DATA_ESAME;
                item.NumeroEsameComm = itemToConvert.NUMERO_ESAMESafe;
            }
            return item;
        }

        public static GVCTREGISTRI Convert(RegistroCooperativaFDT itemToConvert)
        {
            GVCTREGISTRI item = null;
            if (itemToConvert != null)
            {
                item = new GVCTREGISTRI();
                item.IDOBJ = itemToConvert.IdRegistro;
                if (itemToConvert.BilancioEsercizioAl.HasValue)
                    item.BILANCIO_ESERCIZIO_AL = itemToConvert.BilancioEsercizioAl.Value;
                item.CODICE_COOPERATIVA = itemToConvert.CodiceCooperativa;
                item.CODICE_OPERATORE = itemToConvert.CodiceOperatore;
                item.CODICE_UFFICIO = itemToConvert.CodiceUfficio;
                if (itemToConvert.DataBFL.HasValue)
                    item.DATA_BFL = itemToConvert.DataBFL.Value;
                if (itemToConvert.DataCostituzione.HasValue)
                    item.DATA_COSTITUZIONE = itemToConvert.DataCostituzione.Value;
                if (itemToConvert.DataDepositoBFL.HasValue)
                    item.DATA_DEPOSITO_BFL = itemToConvert.DataDepositoBFL.Value;
                if (itemToConvert.Durata.HasValue)
                    item.DURATA = itemToConvert.Durata.Value;
                if (itemToConvert.DurataIllimitata >= 0)
                    item.DURATA_ILLIMITATA = itemToConvert.DurataIllimitata;
                item.ESENTE_VERSAMENTO_UTILI = itemToConvert.EsenzioneVersamentoUtili == true ? 1 : 0;
                item.FORMA_GIURIDICA_CCIAA = Strings.Cut.Get(itemToConvert.FormaGiuridicaParix, 0, 50);
                item.FORMA_AMM_CCIAA = itemToConvert.FormaAmministrativaParix;
                if (itemToConvert.DataBFL.HasValue)
                    item.DATA_BFL = itemToConvert.DataBFL.Value;
                item.GRUPPO_PARITETICO = itemToConvert.GruppoParitetico == true ? 1 : 0;
                //item.IDOBJ_CATEGORIA = itemToConvert.IdCategoria;

                if (itemToConvert.IdFormaAmm > 0)
                    item.IDOBJ_FORMA_AMMINISTRATIVA = itemToConvert.IdFormaAmm;
                else
                    item.IsIDOBJ_FORMA_AMMINISTRATIVANull = true;

                if (itemToConvert.IdFormaGiu > 0)
                    item.IDOBJ_FORMA_GIURIDICA = itemToConvert.IdFormaGiu;
                else
                    item.IsIDOBJ_FORMA_GIURIDICANull = true;

                item.IDOBJ_SOGGETTO = itemToConvert.IdSoggetto;

                //item.IDOBJ_SOTTOCATEGORIA = itemToConvert.IdSottoCategoriaSociale;
               
                item.IDOBJ_STATO = itemToConvert.IdStatoIscrizione;

                if (itemToConvert.IdTipoCostituzione > 0)
                    item.IDOBJ_TIPO_COSTITUZIONE = itemToConvert.IdTipoCostituzione;
                else
                    item.IsIDOBJ_TIPO_COSTITUZIONENull = true;

                item.IMPORTO_VERSAMENTO = itemToConvert.ImportoVersamentoPatrimonioResiduo;
                    item.NUMERO_ALBO = itemToConvert.NumeroIscrizioneAlboNaz;
                item.NUMERO_REA = itemToConvert.NumeroREA;
                item.NUMERO_REPERTORIO_NOTAIO = itemToConvert.NumeroRepertorioNotarile;
                item.NUMERO_RI = itemToConvert.NumeroRI;
                if (itemToConvert.NumeroScioglimento.HasValue)
                    item.NUMERO_SCIOGLIMENTO = itemToConvert.NumeroScioglimento.Value;
                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;

                if (itemToConvert.IdNotaio > 0)
                    item.IDOBJ_NOTAIO = itemToConvert.IdNotaio;
                else
                    item.IsIDOBJ_NOTAIONull = true;

                if (itemToConvert.IdCadenzaRevisione > 0)
                    item.IDOBJ_CADENZA_REVISIONE = itemToConvert.IdCadenzaRevisione;
                else
                    item.IsIDOBJ_CADENZA_REVISIONENull = true;

                if (itemToConvert.DataAcquisizioneAtto.HasValue)
                    item.DATA_ACQUISIZIONE_ATTO = itemToConvert.DataAcquisizioneAtto.Value;
                if (itemToConvert.DataDepositoAtto.HasValue)
                    item.DATA_DEPOSITO_ATTO = itemToConvert.DataDepositoAtto.Value;
                if (itemToConvert.DataEsameComm.HasValue)
                    item.DATA_ESAME = itemToConvert.DataEsameComm.Value;
                item.NUMERO_ESAME = itemToConvert.NumeroEsameComm;
            }
            return item;
        }

        public static RegistroCooperativaFDT[] ConvertAll(GVCTREGISTRI[] itemsToConvert)
        {
            List<RegistroCooperativaFDT> listItem = new List<RegistroCooperativaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTREGISTRI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTREGISTRI[] ConvertAll(RegistroCooperativaFDT[] itemsToConvert)
        {
            List<GVCTREGISTRI> listItem = new List<GVCTREGISTRI>();
            if (itemsToConvert != null)
            {
                foreach (RegistroCooperativaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
