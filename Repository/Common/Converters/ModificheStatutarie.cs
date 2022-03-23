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

		#region Methods (4) 


		// Public Methods (4) 

        public static ModificaStatutariaFDT Convert(GVCTMODIFICHE_STATUTARIE itemToConvert)
        {
            ModificaStatutariaFDT item = null;
            if (itemToConvert != null)
            {
                item = new ModificaStatutariaFDT();
                item.IdModificaStatutaria = itemToConvert.IDOBJ;
                item.IdTipoModifica = itemToConvert.IDOBJ_TIPO_MODIFICA;
                if (!itemToConvert.IsDATA_ATTO_FUSIONENull)
                    item.DataAttoFusioneScissione = itemToConvert.DATA_ATTO_FUSIONE;
                if (!itemToConvert.IsDATA_EFFICACIA_ATTONull)
                    item.DataEfficaciaAtto = itemToConvert.DATA_EFFICACIA_ATTO;
                if (!itemToConvert.IsDATA_INIZIONull)
                    item.DataInizioValidita = itemToConvert.DATA_INIZIO;
                if (!itemToConvert.IsDATA_ISCRIZIONE_ATTONull)
                    item.DataIscrizioneAtto = itemToConvert.DATA_ISCRIZIONE_ATTO;
                item.IdAssemblea = itemToConvert.IDOBJ_ASSEMBLEA;
                item.IdNotaio = itemToConvert.IDOBJ_NOTAIOSafe;
                item.IdNuovaFormaGiuridica = itemToConvert.IDOBJ_NUOVA_FGSafe;
                item.IdNuovoStatoIscrizione = itemToConvert.IDOBJ_NUOVO_STATOSafe;
                item.IdVecchiaFormaGiuridica = itemToConvert.IDOBJ_VECCHIA_FGSafe;
                item.IdVecchioStatoIscrizione = itemToConvert.IDOBJ_VECCHIO_STATOSafe;
                item.Note = itemToConvert.NOTESafe;
                item.NuovaDenominazione = itemToConvert.NUOVA_DENOMINAZIONESafe;
                if (!itemToConvert.IsNUOVA_DURATANull)
                    item.NuovaDurata = itemToConvert.NUOVA_DURATA;
                if (itemToConvert.NUOVA_ILLIMITATASafe == -1)
                    item.NuovaDurataIllimitata = 0;
                else
                    item.NuovaDurataIllimitata = itemToConvert.NUOVA_ILLIMITATASafe;
                //item.NuovaDurataIllimitata = (!itemToConvert.IsNUOVA_ILLIMITATANull &&
                //   itemToConvert.NUOVA_ILLIMITATA == 1) ? true : false;
                if (!itemToConvert.IsNUOVO_BILANCIO_ALNull)
                    item.NuovoBilancioEsercizioAl = itemToConvert.NUOVO_BILANCIO_AL;
                if (!itemToConvert.IsVECCHIO_BILANCIO_ALNull)
                    item.VecchioBilancioEsercizioAl = itemToConvert.VECCHIO_BILANCIO_AL;
                item.VecchiaDenominazione = itemToConvert.VECCHIA_DENOMINAZIONESafe;

                if (!itemToConvert.IsDATAORAULTMODNull)
                    item.DataUltimaModifica = itemToConvert.DATAORAULTMOD;
                item.OperatoreUltimaModifica = itemToConvert.OPERATOREULTMODSafe;
            }
            return item;
        }

        public static GVCTMODIFICHE_STATUTARIE Convert(ModificaStatutariaFDT itemToConvert)
        {
            GVCTMODIFICHE_STATUTARIE item = null;
            if (itemToConvert != null)
            {
                item = new GVCTMODIFICHE_STATUTARIE();
                item.IDOBJ = itemToConvert.IdModificaStatutaria;
                item.IDOBJ_TIPO_MODIFICA = itemToConvert.IdTipoModifica;
                if (itemToConvert.DataAttoFusioneScissione.HasValue)
                    item.DATA_ATTO_FUSIONE = itemToConvert.DataAttoFusioneScissione.Value;
                if (itemToConvert.DataEfficaciaAtto.HasValue)
                    item.DATA_EFFICACIA_ATTO = itemToConvert.DataEfficaciaAtto.Value;
                if (itemToConvert.DataInizioValidita.HasValue)
                    item.DATA_INIZIO = itemToConvert.DataInizioValidita.Value;
                if (itemToConvert.DataIscrizioneAtto.HasValue)
                    item.DATA_ISCRIZIONE_ATTO = itemToConvert.DataIscrizioneAtto.Value;
                item.IDOBJ_ASSEMBLEA = itemToConvert.IdAssemblea;
                if (itemToConvert.IdNotaio > 0)
                    item.IDOBJ_NOTAIO = itemToConvert.IdNotaio;
                else
                    item.IsIDOBJ_NOTAIONull = true;

                if (itemToConvert.IdNuovaFormaGiuridica > 0)
                    item.IDOBJ_NUOVA_FG = itemToConvert.IdNuovaFormaGiuridica;
                if (itemToConvert.IdNuovoStatoIscrizione > 0)
                    item.IDOBJ_NUOVO_STATO = itemToConvert.IdNuovoStatoIscrizione;
                if (itemToConvert.IdVecchiaFormaGiuridica > 0)
                    item.IDOBJ_VECCHIA_FG = itemToConvert.IdVecchiaFormaGiuridica;
                if (itemToConvert.IdVecchioStatoIscrizione > 0)
                    item.IDOBJ_VECCHIO_STATO = itemToConvert.IdVecchioStatoIscrizione;
                item.NOTE = itemToConvert.Note;
                item.NUOVA_DENOMINAZIONE = itemToConvert.NuovaDenominazione;
                if (itemToConvert.NuovaDurata.HasValue)
                    item.NUOVA_DURATA = itemToConvert.NuovaDurata.Value;
                //item.NUOVA_ILLIMITATA = (itemToConvert.NuovaDurataIllimitata == true) ? 1 : 0;
                if (itemToConvert.NuovaDurataIllimitata >= 0)
                    item.NUOVA_ILLIMITATA = itemToConvert.NuovaDurataIllimitata;
                if (itemToConvert.NuovoBilancioEsercizioAl.HasValue)
                    item.NUOVO_BILANCIO_AL = itemToConvert.NuovoBilancioEsercizioAl.Value;
                if (itemToConvert.VecchioBilancioEsercizioAl.HasValue)
                    item.VECCHIO_BILANCIO_AL = itemToConvert.VecchioBilancioEsercizioAl.Value;
                item.VECCHIA_DENOMINAZIONE = itemToConvert.VecchiaDenominazione;

                if (itemToConvert.DataUltimaModifica.HasValue)
                    item.DATAORAULTMOD = itemToConvert.DataUltimaModifica.Value;
                item.OPERATOREULTMOD = itemToConvert.OperatoreUltimaModifica;
            }
            return item;
        }

        public static ModificaStatutariaFDT[] ConvertAll(GVCTMODIFICHE_STATUTARIE[] itemsToConvert)
        {
            List<ModificaStatutariaFDT> listItem = new List<ModificaStatutariaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCTMODIFICHE_STATUTARIE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCTMODIFICHE_STATUTARIE[] ConvertAll(ModificaStatutariaFDT[] itemsToConvert)
        {
            List<GVCTMODIFICHE_STATUTARIE> listItem = new List<GVCTMODIFICHE_STATUTARIE>();
            if (itemsToConvert != null)
            {
                foreach (ModificaStatutariaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


		#endregion Methods 

    }
}
