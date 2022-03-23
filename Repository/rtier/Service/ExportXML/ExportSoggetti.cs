using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace it.dedagroup.GVC.Repository.rtier.Service.ExportXML
{
    public class ExportSoggetti
    {

        /// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
        public ExportSoggetti(GVC db)
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

        public DataSet GetDataToExport(int[] idSoggetti)
        {
            DataSet toReturn;
            DataRelation relSoggettiIndirizzi;
            StringBuilder sbSqlWhere;
                                   
            
            toReturn = new DataSet();

            sbSqlWhere = new StringBuilder();

            sbSqlWhere.Append("{0} IN (");
            for (int i = 0; i < idSoggetti.Length; i++)
            {
                if ((i != 0) && ((i % 1000) == 0))
                {
                    sbSqlWhere.Append(") OR {0} IN (");
                }
                else if (i > 0)
                {
                    sbSqlWhere.Append(", ");
                }

                sbSqlWhere.Append(idSoggetti[i]);
            }
            sbSqlWhere.Append(")");

            using (IDataReader reader = _db.ExecuteReader(CreateSoggettiGetCommand(string.Format(sbSqlWhere.ToString(), "SOG.IDOBJ"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsSoggettiToDataTable(reader));
            }


            using (IDataReader reader = _db.ExecuteReader(CreateIndirizziGetCommand(string.Format(sbSqlWhere.ToString(), "IND.IDOBJ_SOGGETTO"), string.Empty)))
            {
                toReturn.Tables.Add(MapRecordsIndirizziToDataTable(reader));
            }

            relSoggettiIndirizzi = new DataRelation("relSoggettiIndirizzi", toReturn.Tables["Soggetti"].Columns["IDOBJ"], toReturn.Tables["Indirizzi"].Columns["IDOBJ_SOGGETTO"]);
            relSoggettiIndirizzi.Nested = true;
            toReturn.Relations.Add(relSoggettiIndirizzi);

            return toReturn;
        }

        protected virtual IDbCommand CreateSoggettiGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("SOG.IDOBJ, ");
            sql.Append("SOG.IDOBJ_TIPO_SOGGETTO, ");
            sql.Append("TSO.descrizione AS TIPO_SOGGETTO, ");
            sql.Append("SOG.FLAG_ASSOCIAZIONE, ");
            sql.Append("SOG.FLAG_PF, ");
            sql.Append("SOG.DENOMINAZIONE, ");
            sql.Append("SOG.COGNOME, ");
            sql.Append("SOG.NOME, ");
            sql.Append("SOG.CODICE_FISCALE, ");
            sql.Append("SOG.PARTITA_IVA, ");
            sql.Append("SOG.SESSO, ");
            sql.Append("SOG.COGNOME_ACQUISITO, ");
            sql.Append("SOG.DATA_NASCITA, ");
            sql.Append("SOG.LUOGO_NASCITA, ");            
            sql.Append("SOG.STATO_NASCITA, ");
            sql.Append("SOG.CITTADINANZA, ");
            sql.Append("SOG.TELEFONO_1, ");
            sql.Append("SOG.TELEFONO_2, ");
            sql.Append("SOG.CELLULARE, ");
            sql.Append("SOG.EMAIL, ");
            sql.Append("SOG.NOTE ");
            sql.Append("FROM GVCTSOGGETTI SOG ");
            sql.Append("left join GVCDTIPI_SOGGETTO TSO ON ");
            sql.Append("SOG.IDOBJ_TIPO_SOGGETTO = TSO.idobj ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }

        protected virtual IDbCommand CreateIndirizziGetCommand(string whereSql, string orderBySql)
        {
            StringBuilder sql = new StringBuilder("SELECT ");
            sql.Append("IND.IDOBJ, ");
            sql.Append("IND.FLAG_PRINCIPALE, ");
            sql.Append("IND.FLAG_SEDE, ");
            sql.Append("IND.VIA, ");
            sql.Append("IND.IDOBJ_SOGGETTO, ");
            sql.Append("IND.IDOBJ_TIPO_INDIRIZZO, ");
            sql.Append("TIN.DESCRIZIONE AS TIPO_INDIRIZZO, ");
            sql.Append("IND.CIVICO, ");
            sql.Append("IND.CAP, ");
            sql.Append("IND.PROVINCIA, ");
            sql.Append("IND.COMUNE, ");
            sql.Append("IND.FRAZIONE, ");
            sql.Append("IND.STATO, ");
            sql.Append("IND.CODICE_STRADARIO, ");
            sql.Append("IND.TELEFONO, ");
            sql.Append("IND.FAX, ");
            sql.Append("IND.ALTRO, ");
            sql.Append("IND.NOTE, ");
            sql.Append("IND.DATA_INIZIO, ");
            sql.Append("IND.DATA_FINE, ");
            sql.Append("IND.EMAIL, ");
            sql.Append("IND.WEBPAGE ");
            sql.Append("FROM GVCTINDIRIZZI IND ");
            sql.Append("left join GVCDTIPI_INDIRIZZO TIN ON ");
            sql.Append("IND.IDOBJ_TIPO_INDIRIZZO = TIN.IDOBJ ");
            if (whereSql != null && whereSql.Length > 0)
                sql.Append(String.Format("WHERE {0} ", whereSql));
            if (orderBySql != null && orderBySql.Length > 0)
                sql.Append(String.Format("ORDER BY {0} ", orderBySql));
            return _db.CreateCommand(sql.ToString());
        }
                
        protected virtual DataTable MapRecordsSoggettiToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateSoggettiDataTable();
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

        protected virtual DataTable CreateSoggettiDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Soggetti";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("IDOBJ_TIPO_SOGGETTO", typeof(System.Int32));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_SOGGETTO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_ASSOCIAZIONE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_PF", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DENOMINAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COGNOME", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOME", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_FISCALE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PARTITA_IVA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("SESSO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COGNOME_ACQUISITO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_NASCITA", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("LUOGO_NASCITA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("STATO_NASCITA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CITTADINANZA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TELEFONO_1", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TELEFONO_2", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CELLULARE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("EMAIL", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;            
            return dataTable;
        }

        protected virtual DataTable MapRecordsIndirizziToDataTable(IDataReader reader)
        {
            int columnCount = reader.FieldCount;

            DataTable dataTable = CreateIndirizziDataTable();
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

        protected virtual DataTable CreateIndirizziDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = "Indirizzi";
            DataColumn dataColumn;
            dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = true;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn = dataTable.Columns.Add("FLAG_PRINCIPALE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FLAG_SEDE", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("VIA", typeof(System.String));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_SOGGETTO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("IDOBJ_TIPO_INDIRIZZO", typeof(System.Int32));
            dataColumn.AllowDBNull = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TIPO_INDIRIZZO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;            
            dataColumn = dataTable.Columns.Add("CIVICO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CAP", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("PROVINCIA", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("COMUNE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FRAZIONE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("STATO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("CODICE_STRADARIO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("TELEFONO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("FAX", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("ALTRO", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_INIZIO", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("DATA_FINE", typeof(System.DateTime));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("EMAIL", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            dataColumn = dataTable.Columns.Add("WEBPAGE", typeof(System.String));
            dataColumn.AllowDBNull = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            dataColumn.AutoIncrement = false;
            return dataTable;
        }
    }
}
