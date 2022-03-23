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


        #region Dizionario da Vista

        public static DizionarioFDT Convert(GVCVDIZIONARI itemToConvert)
        {
            DizionarioFDT item = null;
            if (itemToConvert != null)
            {
                item = new DizionarioFDT();
                item.IdElemento = itemToConvert.DIC_IDOBJ;
                item.Descrizione = itemToConvert.DIC_DESCRIZIONESafe;
               
                item.Codice = itemToConvert.DIC_CODICESafe;
                item.Tipo = itemToConvert.DIC_TIPOSafe;

                item.Attivo = (!itemToConvert.IsDIC_FLAG_ATTIVONull &&
                    itemToConvert.DIC_FLAG_ATTIVO == 0) ? true : false;

                if (itemToConvert.IsDIC_ALTRO_FLAGNull)
                {
                    item.Flag = true;
                }
                else
                {
                    item.Flag = (itemToConvert.DIC_ALTRO_FLAG == 0) ? true : false;
                }
                
            }
            return item;
        }

        public static DizionarioFDT[] ConvertAll(GVCVDIZIONARI[] itemsToConvert)
        {
            List<DizionarioFDT> listItem = new List<DizionarioFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCVDIZIONARI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Dizionario da Vista

        public static object getObject(Type T, DizionarioFDT item)
           // where T : class, new()
        {
            object ob = Activator.CreateInstance(T);

            int i = 0;
            foreach (System.Reflection.PropertyInfo property in T.GetProperties())
            {
                if (property != null)
                {
                    if (property.Name.Equals("IDOBJ"))
                    {
                        property.SetValue(ob, item.IdElemento , new object[] { });
                    }
                    else if (property.Name.Equals("DESCRIZIONE"))
                    {
                        property.SetValue(ob, item.Descrizione, new object[] { });
                    }
                    else if (property.Name.Equals("FLAG_ATTIVO"))
                    {
                        property.SetValue(ob, (item.Attivo) ? 0 : 1, new object[] { });
                    }
                    else if (property.Name.Equals("CODICE"))
                    {
                        property.SetValue(ob, item.Codice, new object[] { });
                    }
                    else if (property.Name.Equals("NOTE"))
                    {
                        if (item.Dettaglio != null && !String.IsNullOrEmpty(item.Dettaglio.Note))
                        {
                            property.SetValue(ob, item.Dettaglio.Note, new object[] { });
                        }
                    }
                    else if (property.Name.Equals("TEMPI"))
                    {
                        if (item.Dettaglio != null && item.Dettaglio.Tempi.HasValue)
                        {
                            property.SetValue(ob, item.Dettaglio.Tempi.Value, new object[] { });
                        }
                    }
                    else if (property.Name.Equals("FREQUENZA"))
                    {
                        if (item.Dettaglio != null && item.Dettaglio.Tempi.HasValue)
                        {
                            property.SetValue(ob, item.Dettaglio.Tempi.Value, new object[] { });
                        }
                    }
                    else if (   !(property.Name.ToUpper().StartsWith("IS")) &&
                                !(property.Name.EndsWith("Safe")) &&
                                property.Name.Contains("FLAG_"))
                    {
                        property.SetValue(ob, (item.Flag) ? 0 : 1, new object[] { });
                    }
                }
            }
            return ob;
        }

        #region dettaglio Tipi procedimento

        public static DettaglioDizionarioFDT Convert(GVCDTIPI_PROCEDIMENTO itemToConvert)
        {
            DettaglioDizionarioFDT item = null;
            if (itemToConvert != null)
            {
                item = new DettaglioDizionarioFDT();
                item.Note = itemToConvert.NOTESafe;

                if (!itemToConvert.IsTEMPINull)
                    item.Tempi = itemToConvert.TEMPISafe;

            }
            return item;
        }

        #endregion

        #region dettaglio tipi cadenza revisione

        public static DettaglioDizionarioFDT Convert(GVCDCADENZA_REVISIONI itemToConvert)
        {
            DettaglioDizionarioFDT item = null;
            if (itemToConvert != null)
            {
                item = new DettaglioDizionarioFDT();

                if (!itemToConvert.IsFREQUENZANull)
                    item.Tempi = itemToConvert.FREQUENZASafe;
            }
            return item;
        }

        #endregion

        #region Tipi Cariche Sociali

        public static TipoCaricaSocialeFDT Convert(GVCDTIPI_CARICA itemToConvert)
        {
            TipoCaricaSocialeFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoCaricaSocialeFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;

                item.Anti_Mafia =  itemToConvert.FLAG_ANTIMAFIA == 0 ? true : false;
                
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoCaricaSocialeFDT[] ConvertAll(GVCDTIPI_CARICA[] itemsToConvert)
        {
            List<TipoCaricaSocialeFDT> listItem = new List<TipoCaricaSocialeFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_CARICA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Cariche Sociali


        #region Tipi Categorie

        public static CategoriaFDT Convert(GVCDCATEGORIE itemToConvert)
        {
            CategoriaFDT item = null;
            if (itemToConvert != null)
            {
                item = new CategoriaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
                item.CodiceNuovo = itemToConvert.CODICE;
            }
            return item;
        }

        public static CategoriaFDT[] ConvertAll(GVCDCATEGORIE[] itemsToConvert)
        {
            List<CategoriaFDT> listItem = new List<CategoriaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDCATEGORIE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Categorie

        #region Cartelle

        public static CartellaFDT Convert(GVCDCARTELLE itemToConvert)
        {
            CartellaFDT item = null;
            if (itemToConvert != null)
            {
                item = new CartellaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.IdMaschera = itemToConvert.ID_MASCHERASafe;
                item.Path = itemToConvert.PATH;
            }
            return item;
        }

        public static CartellaFDT[] ConvertAll(GVCDCARTELLE[] itemsToConvert)
        {
            List<CartellaFDT> listItem = new List<CartellaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDCARTELLE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        public static GVCDCARTELLE Convert(CartellaFDT itemToConvert)
        {
            GVCDCARTELLE item = null;
            if (itemToConvert != null)
            {
                item = new GVCDCARTELLE();
                item.IDOBJ = itemToConvert.IdElemento;
                item.DESCRIZIONE = itemToConvert.Descrizione;
                item.ID_MASCHERA = itemToConvert.IdMaschera;
                item.PATH = itemToConvert.Path;
            }
            return item;
        }

        public static GVCDCARTELLE[] ConvertAll(CartellaFDT[] itemsToConvert)
        {
            List<GVCDCARTELLE> listItem = new List<GVCDCARTELLE>();
            if (itemsToConvert != null)
            {
                foreach (CartellaFDT item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }


        #endregion Cartelle

        #region Tipi Atti

        public static TipoAttoFDT Convert(GVCDTIPI_ATTI itemToConvert)
        {
            TipoAttoFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoAttoFDT();
                item.Descrizione = itemToConvert.DESCRIZIONESafe;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Codice = itemToConvert.CODICE;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoAttoFDT[] ConvertAll(GVCDTIPI_ATTI[] itemsToConvert)
        {
            List<TipoAttoFDT> listItem = new List<TipoAttoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_ATTI item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion

        #region Tipi SottoCategoria

        public static SottoCategoriaSocialeFDT Convert(GVCDSOTTOCATEGORIE itemToConvert)
        {
            SottoCategoriaSocialeFDT item = null;
            if (itemToConvert != null)
            {
                item = new SottoCategoriaSocialeFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static SottoCategoriaSocialeFDT[] ConvertAll(GVCDSOTTOCATEGORIE[] itemsToConvert)
        {
            List<SottoCategoriaSocialeFDT> listItem = new List<SottoCategoriaSocialeFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDSOTTOCATEGORIE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi SottoCategoria


        #region Tipi TipoCostituzione

        public static TipoCostituzioneFDT Convert(GVCDTIPI_COSTITUZIONE itemToConvert)
        {
            TipoCostituzioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoCostituzioneFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoCostituzioneFDT[] ConvertAll(GVCDTIPI_COSTITUZIONE[] itemsToConvert)
        {
            List<TipoCostituzioneFDT> listItem = new List<TipoCostituzioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_COSTITUZIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi TipoCostituzione


        #region Tipi Forme Amministrative

        public static FormaAmministrativaFDT Convert(GVCDFORMA_AMMINISTRATIVA itemToConvert)
        {
            FormaAmministrativaFDT item = null;
            if (itemToConvert != null)
            {
                item = new FormaAmministrativaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static FormaAmministrativaFDT[] ConvertAll(GVCDFORMA_AMMINISTRATIVA[] itemsToConvert)
        {
            List<FormaAmministrativaFDT> listItem = new List<FormaAmministrativaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDFORMA_AMMINISTRATIVA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Forme Amministrative


        #region Tipi Forme Giuridiche

        public static FormaGiuridicaFDT Convert(GVCDFORME_GIURIDICHE itemToConvert)
        {
            FormaGiuridicaFDT item = null;
            if (itemToConvert != null)
            {
                item = new FormaGiuridicaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static FormaGiuridicaFDT[] ConvertAll(GVCDFORME_GIURIDICHE[] itemsToConvert)
        {
            List<FormaGiuridicaFDT> listItem = new List<FormaGiuridicaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDFORME_GIURIDICHE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Forme Giuridiche


        #region Tipi Stati Cooperative

        public static StatoCooperativaFDT Convert(GVCDSTATI_ISCRIZIONE itemToConvert)
        {
            StatoCooperativaFDT item = null;
            if (itemToConvert != null)
            {
                item = new StatoCooperativaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;

                item.SoggettaRevisione = itemToConvert.FLAG_REVISIONE == 0 ? true : false;

            }
            return item;
        }

        public static StatoCooperativaFDT[] ConvertAll(GVCDSTATI_ISCRIZIONE[] itemsToConvert)
        {
            List<StatoCooperativaFDT> listItem = new List<StatoCooperativaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDSTATI_ISCRIZIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Stati Cooperative


        #region Tipi Indirizzi

        public static TipoIndirizzoFDT Convert(GVCDTIPI_INDIRIZZO itemToConvert)
        {
            TipoIndirizzoFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoIndirizzoFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoIndirizzoFDT[] ConvertAll(GVCDTIPI_INDIRIZZO[] itemsToConvert)
        {
            List<TipoIndirizzoFDT> listItem = new List<TipoIndirizzoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_INDIRIZZO item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Indirizzi


        #region Tipi Revisioni

        public static TipoRevisioneFDT Convert(GVCDTIPI_REVISIONE itemToConvert)
        {
            TipoRevisioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoRevisioneFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoRevisioneFDT[] ConvertAll(GVCDTIPI_REVISIONE[] itemsToConvert)
        {
            List<TipoRevisioneFDT> listItem = new List<TipoRevisioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_REVISIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Revisioni


        #region Esiti Revisione

        public static EsitoRevisioneFDT Convert(GVCDESITI_REVISIONE itemToConvert)
        {
            EsitoRevisioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new EsitoRevisioneFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static EsitoRevisioneFDT[] ConvertAll(GVCDESITI_REVISIONE[] itemsToConvert)
        {
            List<EsitoRevisioneFDT> listItem = new List<EsitoRevisioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDESITI_REVISIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Esiti Revisione


        #region Tipi Soggetti

        public static TipoSoggettoFDT Convert(GVCDTIPI_SOGGETTO itemToConvert)
        {
            TipoSoggettoFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoSoggettoFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoSoggettoFDT[] ConvertAll(GVCDTIPI_SOGGETTO[] itemsToConvert)
        {
            List<TipoSoggettoFDT> listItem = new List<TipoSoggettoFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_SOGGETTO item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Soggetti


        #region ATECO

        public static TipoAttivitaFDT Convert(GVCDATECO itemToConvert)
        {
            TipoAttivitaFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoAttivitaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONESafe;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Codice = itemToConvert.CODICE;
            }
            return item;
        }

        public static TipoAttivitaFDT[] ConvertAll(GVCDATECO[] itemsToConvert)
        {
            List<TipoAttivitaFDT> listItem = new List<TipoAttivitaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDATECO item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion ATECO


        #region Tipi Autorizzazione

        public static TipoAutorizzazioneFDT Convert(GVCDTIPI_AUTORIZZAZIONE itemToConvert)
        {
            TipoAutorizzazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoAutorizzazioneFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoAutorizzazioneFDT[] ConvertAll(GVCDTIPI_AUTORIZZAZIONE[] itemsToConvert)
        {
            List<TipoAutorizzazioneFDT> listItem = new List<TipoAutorizzazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_AUTORIZZAZIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Autorizzazione


        #region Tipi Modifiche Statutarie

        public static TipoModificaStatutariaFDT Convert(GVCDTIPI_MODIFICA itemToConvert)
        {
            TipoModificaStatutariaFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoModificaStatutariaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
                item.Aperta = itemToConvert.FLAG_APERTO == 0 ? true : false;

            }
            return item;
        }

        public static TipoModificaStatutariaFDT[] ConvertAll(GVCDTIPI_MODIFICA[] itemsToConvert)
        {
            List<TipoModificaStatutariaFDT> listItem = new List<TipoModificaStatutariaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_MODIFICA item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion

        #region Tipi Liquidazione Coatta

        public static TipoLiquidazioneCoattaFDT Convert(GVCDTIPI_LIQ_COATTE itemToConvert)
        {
            TipoLiquidazioneCoattaFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoLiquidazioneCoattaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoLiquidazioneCoattaFDT[] ConvertAll(GVCDTIPI_LIQ_COATTE[] itemsToConvert)
        {
            List<TipoLiquidazioneCoattaFDT> listItem = new List<TipoLiquidazioneCoattaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_LIQ_COATTE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Liquidazione Coatta


        #region Tipi Procedura Coatta

        public static TipoProceduraCoattaFDT Convert(GVCDTIPI_PROCEDURE_COATTE itemToConvert)
        {
            TipoProceduraCoattaFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoProceduraCoattaFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoProceduraCoattaFDT[] ConvertAll(GVCDTIPI_PROCEDURE_COATTE[] itemsToConvert)
        {
            List<TipoProceduraCoattaFDT> listItem = new List<TipoProceduraCoattaFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_PROCEDURE_COATTE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi Procedura Coatta

        #region Tipi segnalazione

        public static TipoSegnalazioneFDT Convert(GVCDTIPI_SEGNALAZIONE itemToConvert)
        {
            TipoSegnalazioneFDT item = null;
            if (itemToConvert != null)
            {
                item = new TipoSegnalazioneFDT();
                item.Descrizione = itemToConvert.DESCRIZIONE;
                item.IdElemento = itemToConvert.IDOBJ;
                item.Attivo = itemToConvert.FLAG_ATTIVO == 0 ? true : false;
            }
            return item;
        }

        public static TipoSegnalazioneFDT[] ConvertAll(GVCDTIPI_SEGNALAZIONE[] itemsToConvert)
        {
            List<TipoSegnalazioneFDT> listItem = new List<TipoSegnalazioneFDT>();
            if (itemsToConvert != null)
            {
                foreach (GVCDTIPI_SEGNALAZIONE item in itemsToConvert)
                {
                    listItem.Add(Convert(item));
                }
            }
            return listItem.ToArray();
        }

        #endregion Tipi segnalazione
    }
}
