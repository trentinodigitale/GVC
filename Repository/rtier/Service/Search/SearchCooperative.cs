using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service.Search
{
    public class SearchCooperative
    {
        private ResultItem[] listaCoopResult = null;
        private string sqlDataIscrizione;
        private string sqlDataAdesione;
        private Boolean ritornaAssociazione = true;
        private int[] arrVuoto = null;
        
         /// <summary>
        /// Gateway to the Database 
        /// </summary>
        protected GVC _db;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="db">Istance of the Database</param>
        public SearchCooperative(GVC db)
        {
            _db = db;
        }

        /// <summary>
        /// Property for the Database
        /// </summary>
        protected GVC Database
        {
            get
            {
                return _db;
            }
        }

        protected class IDItem
        {
            public int Id { get; set; }
        }

        protected class ResultItem
        {
            public int Id { get; set; }

            public string Descrizione { get; set; }

            public string Iscrizione { get; set; }
        }

        #region Private Method

        private ResultItem[] ConfrontaDati(int indexIscrizione, int indexAdesione, int idAssociazione, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            //Tipo ricerca
            if (indexAdesione == 0 && indexIscrizione == 0 && 
                (idCategoria.Length > 0 || idSezione > 0 || idSottoCatSoc > 0 || idCategoriaSoc > 0))
            {
                //TUTTE - TUTTE con categoria
                using (IDataReader reader = _db.ExecuteReader(TutteTutteCategoriaGetCommand(sqlDataIscrizione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc)))
                {
                    listaCoopResult = MapAdesioni(reader, null);
                }

                ritornaAssociazione = true;
            }

            if (indexAdesione == 1 && indexIscrizione == 0)
            {
                //ADERENTI - TUTTE
                using (IDataReader reader = _db.ExecuteReader(AderentiTutteGetCommand(sqlDataAdesione, idAssociazione)))
                {
                    listaCoopResult = MapAdesioni(reader, null);
                }

                ritornaAssociazione = true;
            }
            else if (indexAdesione == 2 && indexIscrizione == 0)
            {
                //NON ADERENTI - TUTTE
                using (IDataReader reader = _db.ExecuteReader(NonAderentiTutteGetCommand(sqlDataAdesione)))//, idAssociazione)))
                {
                    listaCoopResult = MapAdesioni(reader, null);
                }

                ritornaAssociazione = false;
            }
            else if (indexAdesione == 1 && indexIscrizione == 1)
            {
                //ADERENTI - ISCRITTE
                using (IDataReader reader = _db.ExecuteReader(AderentiIscritteGetCommand(sqlDataAdesione, sqlDataIscrizione, idAssociazione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc)))
                {
                    listaCoopResult = MapAdesioni(reader, "ISCRITTA");
                }

                ritornaAssociazione = true;
            }
            else if (indexAdesione == 1 && indexIscrizione == 2)
            {
                //ADERENTI - NN ISCRITTE
                using (IDataReader reader = _db.ExecuteReader(AderentiNonIscritteGetCommand(sqlDataAdesione, sqlDataIscrizione, idAssociazione))) //, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc)))
                {
                    listaCoopResult = MapAdesioni(reader, "NON ISCRITTA");
                }

                ritornaAssociazione = true;
            }
            else if (indexAdesione == 2 && indexIscrizione == 1)
            {
                //NN ADERENTI - ISCRITTE
                using (IDataReader reader = _db.ExecuteReader(NonAderentiIscritteGetCommand(sqlDataAdesione, sqlDataIscrizione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc))) //idAssociazione,
                {
                    listaCoopResult = MapAdesioni(reader, "ISCRITTA");
                }

                ritornaAssociazione = false;
            }
            else if (indexAdesione == 2 && indexIscrizione == 2)
            {
                //NN ADERENTI - NN ISCRITTE
                using (IDataReader reader = _db.ExecuteReader(NonAderentiNonIscritteGetCommand(sqlDataAdesione, sqlDataIscrizione)))//, idAssociazione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc)))
                {
                    listaCoopResult = MapAdesioni(reader, "NON ISCRITTA");
                }

                ritornaAssociazione = false;
            }
            else if (indexAdesione == 0 && indexIscrizione == 1)
            {
                //TUTTE - ISCRITTE
                using (IDataReader reader = _db.ExecuteReader(IscritteTutteGetCommand(sqlDataIscrizione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc))) //sqlDataAdesione, idAssociazione,
                {
                    listaCoopResult = MapAdesioni(reader, "ISCRITTA");
                }

                ritornaAssociazione = true;
            }
            else if (indexAdesione == 0 && indexIscrizione == 2)
            {
                //TUTTE - NN ISCRITTE
                using (IDataReader reader = _db.ExecuteReader(NonIscritteTutteGetCommand(sqlDataIscrizione)))//sqlDataAdesione, idAssociazione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc)))
                {
                    listaCoopResult = MapAdesioni(reader, "NON ISCRITTA");
                }

                ritornaAssociazione = true;
            }
            else if (indexIscrizione == 3)
            {
                //CANCELLATE
                using (IDataReader reader = _db.ExecuteReader(CancellateTutteGetCommand(sqlDataIscrizione)))//sqlDataAdesione, idAssociazione)))
                {
                    listaCoopResult = MapAdesioni(reader, "CANCELLATA");
                }

                ritornaAssociazione = false;
            }

            return listaCoopResult;
        }

        #endregion Private Method

        #region Search

        public GVCVRICERCACOOPAVANZATA[] GetAderentiIscritte(GVCVRICERCACOOPAVANZATA[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            List<GVCVRICERCACOOPAVANZATA> listaFine = new List<GVCVRICERCACOOPAVANZATA>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, idCategoria, idSezione, idCategoriaSoc, idSottoCatSoc);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCACOOPAVANZATA elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                        elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                if (!String.IsNullOrEmpty(item.Iscrizione))
                                {
                                    elemento.ISCRIZIONE = item.Iscrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAANNOTAZIONI[] GetAderentiIscritte(GVCVRICERCAANNOTAZIONI[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAANNOTAZIONI> listaFine = new List<GVCVRICERCAANNOTAZIONI>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAANNOTAZIONI elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCABILANCI[] GetAderentiIscritte(GVCVRICERCABILANCI[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCABILANCI> listaFine = new List<GVCVRICERCABILANCI>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCABILANCI elemento in listaVista)
                {
                    if (elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCADOCUMENTAZIONE[] GetAderentiIscritte(GVCVRICERCADOCUMENTAZIONE[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCADOCUMENTAZIONE> listaFine = new List<GVCVRICERCADOCUMENTAZIONE>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCADOCUMENTAZIONE elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAFALLIMENTI[] GetAderentiIscritte(GVCVRICERCAFALLIMENTI[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAFALLIMENTI> listaFine = new List<GVCVRICERCAFALLIMENTI>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAFALLIMENTI elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAMODIFICHE_STAT[] GetAderentiIscritte(GVCVRICERCAMODIFICHE_STAT[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAMODIFICHE_STAT> listaFine = new List<GVCVRICERCAMODIFICHE_STAT>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAMODIFICHE_STAT elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAPROCEDIMENTI[] GetAderentiIscritte(GVCVRICERCAPROCEDIMENTI[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAPROCEDIMENTI> listaFine = new List<GVCVRICERCAPROCEDIMENTI>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAPROCEDIMENTI elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAREV_EFF[] GetAderentiIscritte(GVCVRICERCAREV_EFF[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAREV_EFF> listaFine = new List<GVCVRICERCAREV_EFF>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAREV_EFF elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCALIQUIDAZIONI_COATTE[] GetAderentiIscritte(GVCVRICERCALIQUIDAZIONI_COATTE[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCALIQUIDAZIONI_COATTE> listaFine = new List<GVCVRICERCALIQUIDAZIONI_COATTE>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCALIQUIDAZIONI_COATTE elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAPROCEDURE_COATTE[] GetAderentiIscritte(GVCVRICERCAPROCEDURE_COATTE[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAPROCEDURE_COATTE> listaFine = new List<GVCVRICERCAPROCEDURE_COATTE>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAPROCEDURE_COATTE elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCASANZIONI[] GetAderentiIscritte(GVCVRICERCASANZIONI[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCASANZIONI> listaFine = new List<GVCVRICERCASANZIONI>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCASANZIONI elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        public GVCVRICERCAREV_DAEFF[] GetAderentiIscritte(GVCVRICERCAREV_DAEFF[] listaVista, DateTime dataRifIscrizione, DateTime DataRifAdesione, int indexIscrizione, int indexAdesione, int idAssociazione)
        {
            List<GVCVRICERCAREV_DAEFF> listaFine = new List<GVCVRICERCAREV_DAEFF>();

            sqlDataIscrizione = "TO_DATE('" + dataRifIscrizione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAdesione = "TO_DATE('" + DataRifAdesione.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            listaCoopResult = ConfrontaDati(indexIscrizione, indexAdesione, idAssociazione, arrVuoto, 0, 0, 0);

            if (listaCoopResult.Length > 0)
            {
                foreach (GVCVRICERCAREV_DAEFF elemento in listaVista)
                {
                    if (!(elemento.IsR_IDOBJNull) &&
                       elemento.R_IDOBJ > 0)
                    {
                        foreach (ResultItem item in listaCoopResult)
                        {
                            if (elemento.R_IDOBJ == item.Id)
                            {
                                if (!String.IsNullOrEmpty(item.Descrizione))
                                {
                                    elemento.ADESIONE_ASSOCIAZIONE = item.Descrizione;
                                }

                                listaFine.Add(elemento);
                                break;
                            }
                        }
                    }
                }
            }

            return listaFine.ToArray();
        }

        #endregion Search

        #region SELECT DB

        protected virtual IDbCommand AderentiTutteGetCommand(string dataRif, int idAssociazione)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione, GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO as iscrizione ");
             sql.Append("FROM GVCTREGISTRI ");
             sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
             sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRif));
             sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRif));
             sql.Append("AND GVCTADESIONI.REVISORE = 1 ");
             if (idAssociazione > 0)
             {
                 sql.Append(String.Format("AND GVCTADESIONI.IDOBJ_ASSOCIAZIONE = {0} ", idAssociazione.ToString()));
             }
             sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
             sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRif));

             sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
             sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRif));

             sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

             sql.Append("WHERE GVCTADESIONI.IDOBJ_REGISTRO IS NOT NULL ");

             sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

             return _db.CreateCommand(sql.ToString());           
        }

        protected virtual IDbCommand NonAderentiTutteGetCommand(string dataRif)//, int idAssociazione)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione, GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO as iscrizione  ");
            sql.Append("FROM GVCTREGISTRI ");
            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRif));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRif));

            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRif));

            sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRif));

            sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

            sql.Append("WHERE GVCTADESIONI.IDOBJ_REGISTRO IS NULL ");

            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand AderentiIscritteGetCommand(string dataRifAd, string dataRifIscr, int idAssociazione, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            StringBuilder sql = new StringBuilder("SELECT ");

            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifAd));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifAd));
            sql.Append("AND GVCTADESIONI.REVISORE = 1 ");
            if (idAssociazione > 0)
            {
                sql.Append(String.Format("AND GVCTADESIONI.IDOBJ_ASSOCIAZIONE = {0} ", idAssociazione.ToString()));
            }
            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            if ((idCategoria != null && idCategoria.Length > 0) ||
                idSezione > 0 ||
                idSottoCatSoc > 0 ||
                idCategoriaSoc > 0)
            {
                //++++
                sql.Append("INNER JOIN (");
                sql.Append("SELECT R1.IDOBJ as IDREG, max(CAM.DATA_DETERMINA) AS DATADET ");
                sql.Append("FROM GVCTREGISTRI R1 ");
                sql.Append("INNER JOIN GVCTCAMBI_POSIZIONE CAM ");
                sql.Append("ON CAM.idobj_registro = R1.IDOBJ ");
                sql.Append(String.Format("where CAM.DATA_DETERMINA <= {0} ", dataRifIscr));
                sql.Append("GROUP BY R1.IDOBJ) ultimocambio ");
                sql.Append("ON ultimocambio.IDREG = GVCTREGISTRI.IDOBJ ");

                sql.Append("inner join GVCTCAMBI_POSIZIONE cambiodata ");
                sql.Append("on (ultimocambio.IDREG = cambiodata.idobj_registro and ultimocambio.DATADET = cambiodata.DATA_DETERMINA) ");
                //++++

                sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

                sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
                sql.Append("AND GVCTADESIONI.IDOBJ_REGISTRO IS NOT NULL ");
                if ((idCategoria != null && idCategoria.Length > 0))
                {
                    sql.Append(" AND (");
                    int i = 0;
                    foreach (int id in idCategoria)
                    {
                        if (i > 0)
                            sql.Append(" OR ");

                        sql.Append(String.Format("cambiodata.IDOBJ_CATEGORIA = {0} ", id.ToString()));
                        i++;
                    }
                    sql.Append(") ");
                }
                if (idSezione > 0)
                {
                    sql.Append(String.Format("AND cambiodata.SEZIONE = {0} ", idSezione.ToString()));
                }
                if (idCategoriaSoc > 0)
                {
                    if (idCategoriaSoc == 2)
                    {
                        sql.Append("AND (cambiodata.CATEGORIA_SOCIALE <> 1 ");
                        sql.Append("OR cambiodata.CATEGORIA_SOCIALE = Null) ");
                    }
                    else
                    {
                        sql.Append(String.Format("AND cambiodata.CATEGORIA_SOCIALE = {0} ", idCategoriaSoc.ToString()));
                    }
                }
                if (idSottoCatSoc > 0)
                {
                    sql.Append(String.Format("AND cambiodata.IDOBJ_SOTTOCATEGORIA = {0} ", idSottoCatSoc.ToString()));
                }
            }
            else
            {
                sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
                sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRifIscr));         

                sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

                sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
                sql.Append("AND GVCTADESIONI.IDOBJ_REGISTRO IS NOT NULL ");
                sql.Append("AND GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO IS NOT NULL ");
            }

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand NonAderentiIscritteGetCommand(string dataRifAd, string dataRifIscr, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc) //int idAssociazione, 
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione "); //, MAX(GVCTCAMBI_POSIZIONE.IDOBJ)

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifAd));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifAd));
           
            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            if ((idCategoria != null && idCategoria.Length > 0) ||
                idSezione > 0 ||
                idSottoCatSoc > 0 ||
                idCategoriaSoc > 0)
            {
                //++++
                sql.Append("INNER JOIN (");
                sql.Append("SELECT R1.IDOBJ as IDREG, max(CAM.DATA_DETERMINA) AS DATADET ");
                sql.Append("FROM GVCTREGISTRI R1 ");
                sql.Append("INNER JOIN GVCTCAMBI_POSIZIONE CAM ");
                sql.Append("ON CAM.idobj_registro = R1.IDOBJ ");
                sql.Append(String.Format("where CAM.DATA_DETERMINA <= {0} ", dataRifIscr));
                sql.Append("GROUP BY R1.IDOBJ) ultimocambio ");
                sql.Append("ON ultimocambio.IDREG = GVCTREGISTRI.IDOBJ ");

                sql.Append("inner join GVCTCAMBI_POSIZIONE cambiodata ");
                sql.Append("on (ultimocambio.IDREG = cambiodata.idobj_registro and ultimocambio.DATADET = cambiodata.DATA_DETERMINA) ");
                //++++

                sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

                sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
                sql.Append("AND GVCTADESIONI.IDOBJ_REGISTRO IS NULL ");
                if ((idCategoria != null && idCategoria.Length > 0))
                {
                    sql.Append(" AND (");
                    int i = 0;
                    foreach (int id in idCategoria)
                    {
                        if (i > 0)
                            sql.Append(" OR ");

                        sql.Append(String.Format("cambiodata.IDOBJ_CATEGORIA = {0} ", id.ToString()));
                        i++;
                    }
                    sql.Append(") ");
                }
                if (idSezione > 0)
                {
                    sql.Append(String.Format("AND cambiodata.SEZIONE = {0} ", idSezione.ToString()));
                }
                if (idCategoriaSoc > 0)
                {
                    if (idCategoriaSoc == 2)
                    {
                        sql.Append("AND (cambiodata.CATEGORIA_SOCIALE <> 1 ");
                        sql.Append("OR cambiodata.CATEGORIA_SOCIALE = Null) ");
                    }
                    else
                    {
                        sql.Append(String.Format("AND cambiodata.CATEGORIA_SOCIALE = {0} ", idCategoriaSoc.ToString()));
                    }
                }
                if (idSottoCatSoc > 0)
                {
                    sql.Append(String.Format("AND cambiodata.IDOBJ_SOTTOCATEGORIA = {0} ", idSottoCatSoc.ToString()));
                }
            }
            else
            {
                sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
                sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRifIscr));

                sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

                sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
                sql.Append("AND GVCTADESIONI.IDOBJ_REGISTRO IS NULL ");
                sql.Append("AND GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO IS NOT NULL ");
            }

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand IscritteTutteGetCommand(string dataRifIscr, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc) //string dataRifAd, int idAssociazione
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifIscr));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifIscr));
            
            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            if ((idCategoria != null && idCategoria.Length > 0) ||
               idSezione > 0 ||
               idSottoCatSoc > 0 ||
               idCategoriaSoc > 0)
            {
                //++++
                sql.Append("INNER JOIN (");
                sql.Append("SELECT R1.IDOBJ as IDREG, max(CAM.DATA_DETERMINA) AS DATADET ");
                sql.Append("FROM GVCTREGISTRI R1 ");
                sql.Append("INNER JOIN GVCTCAMBI_POSIZIONE CAM ");
                sql.Append("ON CAM.idobj_registro = R1.IDOBJ ");
                sql.Append(String.Format("where CAM.DATA_DETERMINA <= {0} ", dataRifIscr));
                sql.Append("GROUP BY R1.IDOBJ) ultimocambio ");
                sql.Append("ON ultimocambio.IDREG = GVCTREGISTRI.IDOBJ ");

                sql.Append("inner join GVCTCAMBI_POSIZIONE cambiodata ");
                sql.Append("on (ultimocambio.IDREG = cambiodata.idobj_registro and ultimocambio.DATADET = cambiodata.DATA_DETERMINA) ");
                //++++

                sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

                sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
                if ((idCategoria != null && idCategoria.Length > 0))
                {
                    sql.Append(" AND (");
                    int i = 0;
                    foreach (int id in idCategoria)
                    {
                        if (i > 0)
                            sql.Append(" OR ");

                        sql.Append(String.Format("cambiodata.IDOBJ_CATEGORIA = {0} ", id.ToString()));
                        i++;
                    }
                    sql.Append(") ");
                }
                if (idSezione > 0)
                {
                    sql.Append(String.Format("AND cambiodata.SEZIONE = {0} ", idSezione.ToString()));
                }
                if (idCategoriaSoc > 0)
                {
                    if (idCategoriaSoc == 2)
                    {
                        sql.Append("AND (cambiodata.CATEGORIA_SOCIALE <> 1 ");
                        sql.Append("OR cambiodata.CATEGORIA_SOCIALE = Null) ");
                    }
                    else
                    {
                        sql.Append(String.Format("AND cambiodata.CATEGORIA_SOCIALE = {0} ", idCategoriaSoc.ToString()));
                    }
                }
                if (idSottoCatSoc > 0)
                {
                    sql.Append(String.Format("AND cambiodata.IDOBJ_SOTTOCATEGORIA = {0} ", idSottoCatSoc.ToString()));
                }
            }
            else
            {
                sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
                sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRifIscr));

                sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

                sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
                sql.Append("AND GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO IS NOT NULL ");
            }

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand AderentiNonIscritteGetCommand(string dataRifAd, string dataRifIscr, int idAssociazione) //, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifAd));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifAd));
            sql.Append("AND GVCTADESIONI.REVISORE = 1 ");
            if (idAssociazione > 0)
            {
                sql.Append(String.Format("AND GVCTADESIONI.IDOBJ_ASSOCIAZIONE = {0} ", idAssociazione.ToString()));
            }
            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRifIscr));
           
            sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

            sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
            sql.Append("AND GVCTADESIONI.IDOBJ_REGISTRO IS NOT NULL ");
            sql.Append("AND GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO IS NULL ");

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand NonAderentiNonIscritteGetCommand(string dataRifAd, string dataRifIscr)//, int idAssociazione, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione , MAX(GVCTCAMBI_POSIZIONE.IDOBJ) ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifAd));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifAd));
           
            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifAd));

            sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRifIscr));

            sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

            sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
            sql.Append("AND GVCTADESIONI.IDOBJ_REGISTRO IS NULL ");
            sql.Append("AND GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO IS NULL ");

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand NonIscritteTutteGetCommand(string dataRifIscr)//string dataRifAd, int idAssociazione) , int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifIscr));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifIscr));
           
            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTREGISTRI.IDOBJ=GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCAMBI_POSIZIONE.DATA_DETERMINA <= {0} ", dataRifIscr));

            sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

            sql.Append("WHERE (GVCTCANCELLAZIONI.IDOBJ_REGISTRO) Is Null ");
            sql.Append("AND GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO IS NULL ");

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CancellateTutteGetCommand(string dataRifIscr)//string dataRifAd, int idAssociazione)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, null as denominazione ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            sql.Append("WHERE GVCTCANCELLAZIONI.IDOBJ_REGISTRO Is NOT Null ");

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand TutteTutteCategoriaGetCommand(string dataRifIscr, int[] idCategoria, int idSezione, int idCategoriaSoc, int idSottoCatSoc)
        {
            Boolean trovaCategoria = false;
            Boolean trovaSezione = false;
            Boolean trovaCatSoc = false;

            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione as denominazione, GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO as iscrizione ");

            sql.Append("FROM GVCTREGISTRI ");

            sql.Append("LEFT JOIN GVCTADESIONI ON GVCTREGISTRI.IDOBJ = GVCTADESIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTADESIONI.DATA_INIZIO_ADESIONE <= {0} ", dataRifIscr));
            sql.Append(String.Format("AND (GVCTADESIONI.DATA_FINE_ADESIONE >= {0} OR GVCTADESIONI.DATA_FINE_ADESIONE Is Null) ", dataRifIscr));

            sql.Append("LEFT JOIN GVCTCANCELLAZIONI ON GVCTREGISTRI.IDOBJ=GVCTCANCELLAZIONI.IDOBJ_REGISTRO ");
            sql.Append(String.Format("AND GVCTCANCELLAZIONI.DATA_DETERMINA <= {0} ", dataRifIscr));

            sql.Append("LEFT JOIN GVCTCAMBI_POSIZIONE ON GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO = GVCTREGISTRI.IDOBJ ");

            sql.Append("LEFT join gvctsoggetti on GVCTADESIONI.IDOBJ_ASSOCIAZIONE = gvctsoggetti.idobj ");

            if ((idCategoria != null && idCategoria.Length > 0) ||
               idSezione > 0 ||
               idSottoCatSoc > 0 ||
               idCategoriaSoc > 0)
            {
                sql.Append(" WHERE ");

                if (idCategoria != null && idCategoria.Length > 0)
                {
                    sql.Append("(");
                    int i = 0;
                    foreach (int id in idCategoria)
                    {
                        if (i > 0)
                            sql.Append(" OR ");

                        sql.Append(String.Format("GVCTCAMBI_POSIZIONE.IDOBJ_CATEGORIA = {0} ", id.ToString()));
                        i++;
                    }
                    sql.Append(") ");

                    trovaCategoria = true;
                }

                if (idSezione > 0)
                {
                    if (trovaCategoria)
                        sql.Append(" AND ");
                
                    sql.Append(String.Format("GVCTCAMBI_POSIZIONE.SEZIONE = {0} ", idSezione.ToString()));

                    trovaSezione = true;
                }

                if (idCategoriaSoc > 0)
                {
                    if (trovaCategoria || trovaSezione)
                        sql.Append(" AND ");

                    if (idCategoriaSoc == 2)
                    {
                        sql.Append("(GVCTCAMBI_POSIZIONE.CATEGORIA_SOCIALE <> 1 ");
                        sql.Append("OR GVCTCAMBI_POSIZIONE.CATEGORIA_SOCIALE = Null) ");
                    }
                    else
                    {
                        sql.Append(String.Format("GVCTCAMBI_POSIZIONE.CATEGORIA_SOCIALE = {0} ", idCategoriaSoc.ToString()));
                    }

                    trovaCatSoc = true;
                }

                if (idSottoCatSoc > 0)
                {
                    if (trovaCategoria || trovaSezione || trovaCatSoc)
                        sql.Append(" AND ");

                    sql.Append(String.Format("GVCTCAMBI_POSIZIONE.IDOBJ_SOTTOCATEGORIA = {0} ", idSottoCatSoc.ToString()));
                }
            }

            sql.Append("GROUP BY GVCTREGISTRI.IDOBJ, GVCTCANCELLAZIONI.IDOBJ_REGISTRO, GVCTADESIONI.IDOBJ_ASSOCIAZIONE, gvctsoggetti.denominazione, GVCTCAMBI_POSIZIONE.IDOBJ_REGISTRO ");
            sql.Append("ORDER BY GVCTREGISTRI.IDOBJ");

            return _db.CreateCommand(sql.ToString());
        }

        #endregion SELECT DB

        #region Map record

        protected virtual ResultItem[] MapAdesioni(IDataReader reader, String tipoIscrizione)
        {
            List<ResultItem> toReturn;
            ResultItem obj;
            int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
            int iDENOMINAZIONEColumnIndex = reader.GetOrdinal("DENOMINAZIONE");
            int iDCANCColumnIndex = reader.GetOrdinal("IDOBJ_REGISTRO");

            toReturn = new List<ResultItem>();
            while (reader.Read())
            {
                obj = new ResultItem();
                obj.Id = reader.GetInt32(iDOBJColumnIndex);
               
                if (!reader.IsDBNull(iDENOMINAZIONEColumnIndex))
                {
                    obj.Descrizione = reader.GetString(iDENOMINAZIONEColumnIndex);
                }
                else
                {
                    obj.Descrizione = String.Empty;
                }

                if (!String.IsNullOrEmpty(tipoIscrizione))
                {
                    obj.Iscrizione = tipoIscrizione;
                }
                else
                {
                    if (!reader.IsDBNull(iDCANCColumnIndex))
                    {
                        obj.Iscrizione = "CANCELLATA";
                    }
                    else if (!reader.IsDBNull(4))
                    {
                        obj.Iscrizione = "ISCRITTA";
                    }
                    else
                    {
                        obj.Iscrizione = "NON ISCRITTA";
                    }
                }

                toReturn.Add(obj);
            }

            return toReturn.ToArray();
        }

        #endregion Map record
    }
}
