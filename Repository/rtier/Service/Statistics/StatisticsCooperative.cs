using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace it.dedagroup.GVC.Repository.rtier.Service.Statistics
{
    public class StatisticsCooperative
    {

        /// <summary>
        /// Gateway to the Database 
        /// </summary>
        protected GVC _db;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="db">Istance of the Database</param>
        public StatisticsCooperative(GVC db)
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

        protected class AdesioneItem
        {

            public int Id { get; set; }

            public string Descrizione { get; set; }

        }


        public DataSet GetDataStatistics(DateTime dataDal, DateTime dataAl, bool soloAttivi)
        {
            DataSet toReturn;
            string sqlDataDal;
            string sqlDataAl;
            string sqlWhere;
            AdesioneItem[] lstAdesioni;
            DataTable dtCooperative;
            
            toReturn = new DataSet();

            sqlDataDal = "TO_DATE('" + dataDal.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
            sqlDataAl = "TO_DATE('" + dataAl.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";

            using (IDataReader reader = _db.ExecuteReader(CreateCooperativeAdesioniGetCommand(null, "DENOMINAZIONE")))
            {
                lstAdesioni = MapAdesioni(reader);
            }


            sqlWhere = string.Empty;
            if (soloAttivi)
            {
                sqlWhere = "FLAG_ATTIVO = 0";
            }

            using (IDataReader reader = _db.ExecuteReader(CreateCategorieGetCommand(sqlWhere, "DESCRIZIONE")))
            {
                toReturn.Tables.Add(MapRecordsToDataTable(reader, lstAdesioni));
            }

            sqlWhere = "(DATA_DETERMINA >= " + sqlDataDal + ") AND (DATA_DETERMINA <= " + sqlDataAl + ")";
            using (IDataReader reader = _db.ExecuteReader(CreateCooperativeCategoriaGetCommand(sqlWhere, "IDOBJ_REGISTRO, DATA_DETERMINA DESC")))
            {
                dtCooperative = MapRecordsToDataTableCooperative(reader);
            }
            
            for (int i = 0; i < toReturn.Tables["StatisticaCooperative"].Rows.Count; i++)
            {
                int[] idCooperative;
                int[] idCooperativeIscritteDalAl;
                int[] idCooperativeCancellate;

                int idCategoria = Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["IDOBJ"]);

                idCooperative = MapIdsCategoria(dtCooperative, idCategoria);
                
                if (idCooperative.Length > 0)
                {                                     
                   
                    sqlWhere = string.Format(GetSqlWhere(idCooperative), "IDOBJ_REGISTRO") + " AND " +
                        //"(DATA_DELIBERA >= " + sqlDataDal + ") AND (DATA_DELIBERA <= " + sqlDataAl + ")";
                          "(DATA_DETERMINA >= " + sqlDataDal + ") AND (DATA_DETERMINA <= " + sqlDataAl + ")";
                    using (IDataReader reader = _db.ExecuteReader(CreateCancellazioniGetCommand(sqlWhere, string.Empty)))
                    {
                        idCooperativeCancellate = MapIds(reader);
                        toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_CANCELLATE"] = idCooperativeCancellate.Length;
                    }

                    sqlWhere = string.Format(GetSqlWhere(idCooperative), "IDOBJ_REGISTRO") + " AND " +                        
                            "(DATA_DETERMINA >= " + sqlDataDal + ") AND (DATA_DETERMINA <= " + sqlDataAl + ")";
                    if (idCooperativeCancellate.Length > 0)
                    {
                        sqlWhere = sqlWhere + " AND " + string.Format(GetSqlWhere(idCooperativeCancellate), "IDOBJ_REGISTRO NOT");
                    }

                    using (IDataReader reader = _db.ExecuteReader(CreateCooperativeIscritteGetCommand(sqlWhere, string.Empty)))
                    {
                        idCooperativeIscritteDalAl = MapIds(reader);
                        toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_ISCRITTE"] = idCooperativeIscritteDalAl.Length;
                    }

                    if (idCooperativeIscritteDalAl.Length > 0)
                    {
                        sqlWhere = string.Format(GetSqlWhere(idCooperativeIscritteDalAl), "IDOBJ_REGISTRO") + " AND " +
                            "(DATA_INIZIO_ADESIONE >= " + sqlDataDal + ") AND (DATA_INIZIO_ADESIONE <= " + sqlDataAl + ") AND " +
                            "(REVISORE = 1)";
                        using (IDataReader reader = _db.ExecuteReader(CreateCooperativeAderentiGetCommand(sqlWhere, "IDOBJ_REGISTRO , DATA_INIZIO_ADESIONE DESC")))
                        {
                            int[] results = MapAderenti(reader, lstAdesioni);
                            int sum = 0;

                            for (int x = 0; x < lstAdesioni.Length; x++)
                            {
                                toReturn.Tables["StatisticaCooperative"].Rows[i][lstAdesioni[x].Id.ToString()] = results[x].ToString();
                                sum = sum + results[x];
                            }

                            toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_NONADERENTI"] = idCooperativeIscritteDalAl.Length - sum;
                        }
                    }

                    toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_ISCRITTE_TOTALE"] =
                        Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_ISCRITTE"]);
                }                                    
            }

            DataRow rw = toReturn.Tables["StatisticaCooperative"].NewRow();
            rw["IDOBJ"] = -1;
            rw["CODICE"] = " - ";
            rw["DESCRIZIONE"] = " - SOMME - ";
            rw["FLAG_ATTIVO"] = 0;
            for (int i = 0; i < toReturn.Tables["StatisticaCooperative"].Rows.Count; i++)
            {
                rw["COOPERATIVE_CANCELLATE"] = Convert.ToInt32(rw["COOPERATIVE_CANCELLATE"]) + Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_CANCELLATE"]);
                rw["COOPERATIVE_ISCRITTE"] = Convert.ToInt32(rw["COOPERATIVE_ISCRITTE"]) + Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_ISCRITTE"]);
                rw["COOPERATIVE_NONADERENTI"] = Convert.ToInt32(rw["COOPERATIVE_NONADERENTI"]) + Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_NONADERENTI"]);

                for (int x = 0; x < lstAdesioni.Length; x++)
                {
                    rw[lstAdesioni[x].Id.ToString()] = Convert.ToInt32(rw[lstAdesioni[x].Id.ToString()]) + Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i][lstAdesioni[x].Id.ToString()]);
                }
            }

            toReturn.Tables[0].Rows.Add(rw);

            return toReturn;
        }

        public DataSet GetDataStatistics(DateTime dataFinoAl, bool soloAttivi)
        {
            DataSet toReturn;
            DataTable dtCooperative;
            string sqlDataFinoAl;            
            string sqlWhere;
            AdesioneItem[] lstAdesioni;
           
            toReturn = new DataSet();

            sqlDataFinoAl = "TO_DATE('" + dataFinoAl.ToString("yyyy-MM-dd") + "','yyyy-mm-dd')";
           
            using (IDataReader reader = _db.ExecuteReader(CreateCooperativeAdesioniGetCommand(null, "DENOMINAZIONE")))
            {
                lstAdesioni = MapAdesioni(reader);
            }

            sqlWhere = string.Empty;
            if (soloAttivi)
            {
                sqlWhere = "FLAG_ATTIVO = 0";
            }
            
            using (IDataReader reader = _db.ExecuteReader(CreateCategorieGetCommand(sqlWhere, "DESCRIZIONE")))
            {
                toReturn.Tables.Add(MapRecordsToDataTable(reader, lstAdesioni));
            }

            sqlWhere = "(DATA_DETERMINA < " + sqlDataFinoAl + ")";
            using (IDataReader reader = _db.ExecuteReader(CreateCooperativeCategoriaGetCommand(sqlWhere, "IDOBJ_REGISTRO, DATA_DETERMINA DESC")))
            {
                dtCooperative = MapRecordsToDataTableCooperative(reader);
            }
                        
            for (int i = 0; i < toReturn.Tables["StatisticaCooperative"].Rows.Count; i++)
            {
                int[] idCooperative;
                int[] idCooperativeIscritte;
                int[] idCooperativeCancellate;

                int idCategoria = Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["IDOBJ"]);

                idCooperative = MapIdsCategoria(dtCooperative, idCategoria);
                                    
                if (idCooperative.Length > 0)
                {

                    sqlWhere = string.Format(GetSqlWhere(idCooperative), "IDOBJ_REGISTRO") + " AND " +
                        //"(DATA_DELIBERA < " + sqlDataFinoAl + ")";
                         "(DATA_DETERMINA < " + sqlDataFinoAl + ")";
                    using (IDataReader reader = _db.ExecuteReader(CreateCancellazioniGetCommand(sqlWhere, string.Empty)))
                    {
                        idCooperativeCancellate = MapIds(reader);
                        toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_CANCELLATE"] = idCooperativeCancellate.Length;
                    }

                    sqlWhere = string.Format(GetSqlWhere(idCooperative), "IDOBJ_REGISTRO") + " AND " +
                        "(DATA_DETERMINA < " + sqlDataFinoAl + ")";
                    if (idCooperativeCancellate.Length > 0)
                    {
                        sqlWhere = sqlWhere + " AND " + string.Format(GetSqlWhere(idCooperativeCancellate), "IDOBJ_REGISTRO NOT");
                    }

                    using (IDataReader reader = _db.ExecuteReader(CreateCooperativeIscritteGetCommand(sqlWhere, string.Empty)))
                    {
                        idCooperativeIscritte = MapIds(reader);
                        toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_ISCRITTE"] = idCooperativeIscritte.Length;
                    }

                    if (idCooperativeIscritte.Length > 0)
                    {
                        sqlWhere = string.Format(GetSqlWhere(idCooperativeIscritte), "IDOBJ_REGISTRO") + " AND " +
                            "(DATA_INIZIO_ADESIONE < " + sqlDataFinoAl + ") AND (REVISORE = 1)";
                        using (IDataReader reader = _db.ExecuteReader(CreateCooperativeAderentiGetCommand(sqlWhere, "IDOBJ_REGISTRO , DATA_INIZIO_ADESIONE DESC")))
                        {
                            int[] results = MapAderenti(reader, lstAdesioni);
                            int sum = 0;

                            for (int x = 0; x < lstAdesioni.Length; x++)
                            {
                                toReturn.Tables["StatisticaCooperative"].Rows[i][lstAdesioni[x].Id.ToString()] = results[x].ToString();
                                sum = sum + results[x];
                            }

                            toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_NONADERENTI"] = idCooperativeIscritte.Length - sum;
                        }
                    }                                        
                }
            }

            DataRow rw = toReturn.Tables["StatisticaCooperative"].NewRow();
            rw["IDOBJ"] = -1;
            rw["CODICE"] = " - ";
            rw["DESCRIZIONE"] = " - SOMME - ";
            rw["FLAG_ATTIVO"] = 0;
            for (int i = 0; i < toReturn.Tables["StatisticaCooperative"].Rows.Count; i++)
            {
                rw["COOPERATIVE_CANCELLATE"] = Convert.ToInt32(rw["COOPERATIVE_CANCELLATE"]) +  Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_CANCELLATE"]);
                rw["COOPERATIVE_ISCRITTE"] = Convert.ToInt32(rw["COOPERATIVE_ISCRITTE"]) +  Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_ISCRITTE"]);
                rw["COOPERATIVE_NONADERENTI"] = Convert.ToInt32(rw["COOPERATIVE_NONADERENTI"]) +  Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i]["COOPERATIVE_NONADERENTI"]);
                
                for (int x = 0; x < lstAdesioni.Length; x++)
                {
                    rw[lstAdesioni[x].Id.ToString()] = Convert.ToInt32(rw[lstAdesioni[x].Id.ToString()]) + Convert.ToInt32(toReturn.Tables["StatisticaCooperative"].Rows[i][lstAdesioni[x].Id.ToString()]);                    
                }
            } 
               
            toReturn.Tables[0].Rows.Add(rw);

            return toReturn;
        }

        protected virtual string GetSqlWhere(int[] idCooperatives)
        {
            StringBuilder sbSqlWhere;


            sbSqlWhere = new StringBuilder();
            if (idCooperatives.Length > 0)
            {
                sbSqlWhere.Append("(");
                sbSqlWhere.Append("{0} IN (");
                for (int x = 0; x < idCooperatives.Length; x++)
                {
                    if ((x != 0) && ((x % 1000) == 0))
                    {
                        sbSqlWhere.Append(") OR {0} IN (");
                    }
                    else if (x > 0)
                    {
                        sbSqlWhere.Append(", ");
                    }
                    sbSqlWhere.Append(idCooperatives[x]);
                }
                sbSqlWhere.Append("))");
            }

            return sbSqlWhere.ToString();
        }

        protected virtual DataTable CreateDataTable(AdesioneItem[] adesioni)
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "StatisticaCooperative";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.Caption = string.Empty;
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("CODICE", typeof(System.String));
            dataColumn.Caption = "Codice";
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DESCRIZIONE", typeof(System.String));
            dataColumn.Caption = "Descrizione";
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_ATTIVO", typeof(System.Int32));
            dataColumn.Caption = string.Empty;
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COOPERATIVE_CANCELLATE", typeof(System.Int32));
            dataColumn.Caption = "Cancellate";
            dataColumn.DefaultValue = 0;
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COOPERATIVE_ISCRITTE", typeof(System.Int32));
            dataColumn.Caption = "Iscritte";
            dataColumn.DefaultValue = 0;
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;

            for (int i = 0; i < adesioni.Length; i++)
            {
                dataColumn = dataTable.Columns.Add(adesioni[i].Id.ToString(), typeof(System.Int32));
                dataColumn.Caption = adesioni[i].Descrizione;
                dataColumn.DefaultValue = 0;
                dataColumn.AllowDBNull = true;
                dataColumn.ReadOnly = false;
                dataColumn.Unique = false;
                dataColumn.AutoIncrement = false;
            }
                        
            dataColumn = dataTable.Columns.Add("COOPERATIVE_NONADERENTI", typeof(System.Int32));
            dataColumn.Caption = "Non aderente";
            dataColumn.DefaultValue = 0;
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;                     
            
            return dataTable;   
        }

        protected virtual DataTable MapRecordsToDataTableCooperative(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateDataTableCooperative();
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual DataTable CreateDataTableCooperative()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Cooperative";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_DETERMINA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_CATEGORIA", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;

            return dataTable;   
        }

        protected virtual DataTable MapRecordsToDataTable(IDataReader reader, AdesioneItem[] lst)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateDataTable(lst);
            dataTable.BeginLoadData();
            object[] values = new object[columnCount];

            while (reader.Read())
            {
                reader.GetValues(values);
                dataTable.LoadDataRow(values, true);
            }
            dataTable.EndLoadData();

            return dataTable;
        }

        protected virtual int[] MapIds(IDataReader reader)
        {
            List<int> toReturn;
            int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");

            toReturn = new List<int>();
            while (reader.Read())
            {
                toReturn.Add(Convert.ToInt32(reader.GetValue(iDOBJColumnIndex)));
            }

            return toReturn.ToArray();
        }

        protected virtual int[] MapIdsCategoria(DataTable dataTable, int idCategoria)
        {
            List<int> toReturn;
            int lastId;

            lastId = -1;
            toReturn = new List<int>();
            
            for (int i = 0; i < dataTable.Rows.Count; i++)
			{
                if ((idCategoria == Convert.ToInt32(dataTable.Rows[i]["IDOBJ_CATEGORIA"])) && (lastId != Convert.ToInt32(dataTable.Rows[i]["IDOBJ"])))
                {
                    toReturn.Add(Convert.ToInt32(dataTable.Rows[i]["IDOBJ"]));
                }

                lastId = Convert.ToInt32(dataTable.Rows[i]["IDOBJ"]);
            }

            return toReturn.ToArray();
        }

        protected virtual AdesioneItem[] MapAdesioni(IDataReader reader)
        {
            List<AdesioneItem> toReturn;
            AdesioneItem obj;
            int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
            int iDENOMINAZIONEColumnIndex = reader.GetOrdinal("DENOMINAZIONE");

            toReturn = new List<AdesioneItem>();
            while (reader.Read())
            {
                obj = new AdesioneItem();
                obj.Id = reader.GetInt32(iDOBJColumnIndex);
                obj.Descrizione = reader.GetString(iDENOMINAZIONEColumnIndex);
                toReturn.Add(obj);
            }

            return toReturn.ToArray();
        }

        protected virtual int[] MapAderenti(IDataReader reader, AdesioneItem[] lst)
        {
            int lastIdRegister = -1;
            int idAssociazione;
            int[] records;
            int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
            int iDOBJ_ASSOCIAZIONEColumnIndex = reader.GetOrdinal("IDOBJ_ASSOCIAZIONE");

            records = new int[lst.Length];

            while (reader.Read())
            {
                if (lastIdRegister != reader.GetInt32(iDOBJColumnIndex))
                {
                    idAssociazione = reader.GetInt32(iDOBJ_ASSOCIAZIONEColumnIndex);

                    for (int i = 0; i < lst.Length; i++)
                    {
                        if (idAssociazione == lst[i].Id)
                        {
                            records[i] = records[i] + 1;
                        }
                    }

                    lastIdRegister = reader.GetInt32(iDOBJColumnIndex);
                }
            }

            return records;
        }


        protected virtual IDbCommand CreateCategorieGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("IDOBJ, ");
            sql.Append("CODICE, ");
            sql.Append("DESCRIZIONE, ");
            sql.Append("FLAG_ATTIVO ");
            sql.Append("FROM GVCDCATEGORIE ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCooperativeDaCategoriaGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("DISTINCT(IDOBJ_REGISTRO) AS IDOBJ ");
            sql.Append("FROM GVCTCAMBI_POSIZIONE ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCooperativeCategoriaGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("IDOBJ_REGISTRO AS IDOBJ, ");
            sql.Append("DATA_DETERMINA, ");
            sql.Append("IDOBJ_CATEGORIA ");
            sql.Append("FROM GVCTCAMBI_POSIZIONE ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCancellazioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("DISTINCT(IDOBJ_REGISTRO) AS IDOBJ ");
            sql.Append("FROM GVCTCANCELLAZIONI ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCooperativeIscritteGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("DISTINCT(IDOBJ_REGISTRO) AS IDOBJ ");
            sql.Append("FROM GVCTCAMBI_POSIZIONE ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCooperativeAderentiGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("IDOBJ_REGISTRO AS IDOBJ, ");
            sql.Append("DATA_INIZIO_ADESIONE, ");
            sql.Append("IDOBJ_ASSOCIAZIONE ");
            sql.Append("FROM GVCTADESIONI ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateCooperativeAdesioniGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("DISTINCT (A.IDOBJ_ASSOCIAZIONE) AS IDOBJ, ");
            sql.Append("S.DENOMINAZIONE ");
            sql.Append("FROM GVCTADESIONI A ");
            sql.Append("LEFT JOIN GVCTSOGGETTI S ");
            sql.Append("ON A.IDOBJ_ASSOCIAZIONE = S.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }


        protected virtual IDbCommand CreateCooperativeIscritteTotaleGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("DISTINCT(CP.IDOBJ_REGISTRO) AS IDOBJ ");
            sql.Append("FROM GVCTCAMBI_POSIZIONE CP ");
            sql.Append("WHERE CP.IDOBJ_REGISTRO NOT IN ");
            sql.Append("( ");
            sql.Append("SELECT DISTINCT(CAN.IDOBJ_REGISTRO) ");
            sql.Append("FROM GVCTCANCELLAZIONI CAN ");
            sql.Append(") ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }
    }
}
