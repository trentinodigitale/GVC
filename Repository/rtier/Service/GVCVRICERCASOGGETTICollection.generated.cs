//
//Generated by gvc at 26/03/2009 9.03.14
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCVRICERCASOGGETTI
	/// </summary>
	public partial class GVCVRICERCASOGGETTICollection
	{
		/// <summary>
		/// Returns the Database Name of the field R_ID_SOGGETTO.
		///The field is mandatory.
		/// </summary>
		public const string R_ID_SOGGETTOColumnName = "R_ID_SOGGETTO";
		/// <summary>
		/// Returns the Database Name of the field R_ID_TIPO_SOGGETTO.
		/// </summary>
		public const string R_ID_TIPO_SOGGETTOColumnName = "R_ID_TIPO_SOGGETTO";
		/// <summary>
		/// Returns the Database Name of the field R_ASSOCIAZIONE.
		///The field is mandatory.
		/// </summary>
		public const string R_ASSOCIAZIONEColumnName = "R_ASSOCIAZIONE";
		/// <summary>
		/// Returns the Database Name of the field R_NOME.
		/// </summary>
		public const string R_NOMEColumnName = "R_NOME";
		/// <summary>
		/// Returns the Database Name of the field R_COGNOME.
		/// </summary>
		public const string R_COGNOMEColumnName = "R_COGNOME";
		/// <summary>
		/// Returns the Database Name of the field R_DENOMINAZIONE.
		/// </summary>
		public const string R_DENOMINAZIONEColumnName = "R_DENOMINAZIONE";
		/// <summary>
		/// Returns the Database Name of the field R_CODICE_FISCALE.
		/// </summary>
		public const string R_CODICE_FISCALEColumnName = "R_CODICE_FISCALE";
		/// <summary>
		/// Returns the Database Name of the field R_DATA_NASCITA.
		/// </summary>
		public const string R_DATA_NASCITAColumnName = "R_DATA_NASCITA";
		/// <summary>
		/// Returns the Database Name of the field R_LUOGO_NASCITA.
		/// </summary>
		public const string R_LUOGO_NASCITAColumnName = "R_LUOGO_NASCITA";
		/// <summary>
		/// Returns the Database Name of the field R_CODICE_COOPERATIVA.
		/// </summary>
		public const string R_CODICE_COOPERATIVAColumnName = "R_CODICE_COOPERATIVA";
		/// <summary>
		/// Returns the Database Name of the field R_NUMERO_REA.
		/// </summary>
		public const string R_NUMERO_REAColumnName = "R_NUMERO_REA";
		/// <summary>
		/// Returns the Database Name of the field R_ID_OBJ_STATO.
		/// </summary>
		public const string R_ID_OBJ_STATOColumnName = "R_ID_OBJ_STATO";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCVRICERCASOGGETTICollection(GVC db)
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

		/// <summary>
		/// Returns an array containing all the objects GVCVRICERCASOGGETTI
		/// </summary>
		/// <returns>Array of objects GVCVRICERCASOGGETTI</returns>
		public virtual GVCVRICERCASOGGETTI[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCVRICERCASOGGETTI
		/// </summary>
		/// <returns>DataTable of objects GVCVRICERCASOGGETTI</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCVRICERCASOGGETTI
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCVRICERCASOGGETTI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCVRICERCASOGGETTI</returns>
		public GVCVRICERCASOGGETTI GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCVRICERCASOGGETTI[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCVRICERCASOGGETTI selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCVRICERCASOGGETTI</returns>
		public GVCVRICERCASOGGETTI[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCVRICERCASOGGETTI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCVRICERCASOGGETTI</returns>
		public virtual GVCVRICERCASOGGETTI[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVRICERCASOGGETTI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCVRICERCASOGGETTI</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVRICERCASOGGETTI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCVRICERCASOGGETTI</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCVRICERCASOGGETTI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("R_ID_SOGGETTO, ");
			sql.Append("R_ID_TIPO_SOGGETTO, ");
			sql.Append("R_ASSOCIAZIONE, ");
			sql.Append("R_NOME, ");
			sql.Append("R_COGNOME, ");
			sql.Append("R_DENOMINAZIONE, ");
			sql.Append("R_CODICE_FISCALE, ");
			sql.Append("R_DATA_NASCITA, ");
			sql.Append("R_LUOGO_NASCITA, ");
			sql.Append("R_CODICE_COOPERATIVA, ");
			sql.Append("R_NUMERO_REA, ");
			sql.Append("R_ID_OBJ_STATO ");
			sql.Append("FROM GVCVRICERCASOGGETTI ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}


		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVRICERCASOGGETTI
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCVRICERCASOGGETTI</returns>
		protected GVCVRICERCASOGGETTI[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVRICERCASOGGETTI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCVRICERCASOGGETTI</returns>
		protected GVCVRICERCASOGGETTI[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCVRICERCASOGGETTI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCVRICERCASOGGETTI</returns>
		protected virtual GVCVRICERCASOGGETTI[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int r_ID_SOGGETTOColumnIndex = reader.GetOrdinal("R_ID_SOGGETTO");
			int r_ID_TIPO_SOGGETTOColumnIndex = reader.GetOrdinal("R_ID_TIPO_SOGGETTO");
			int r_ASSOCIAZIONEColumnIndex = reader.GetOrdinal("R_ASSOCIAZIONE");
			int r_NOMEColumnIndex = reader.GetOrdinal("R_NOME");
			int r_COGNOMEColumnIndex = reader.GetOrdinal("R_COGNOME");
			int r_DENOMINAZIONEColumnIndex = reader.GetOrdinal("R_DENOMINAZIONE");
			int r_CODICE_FISCALEColumnIndex = reader.GetOrdinal("R_CODICE_FISCALE");
			int r_DATA_NASCITAColumnIndex = reader.GetOrdinal("R_DATA_NASCITA");
			int r_LUOGO_NASCITAColumnIndex = reader.GetOrdinal("R_LUOGO_NASCITA");
			int r_CODICE_COOPERATIVAColumnIndex = reader.GetOrdinal("R_CODICE_COOPERATIVA");
			int r_NUMERO_REAColumnIndex = reader.GetOrdinal("R_NUMERO_REA");
			int r_ID_OBJ_STATOColumnIndex = reader.GetOrdinal("R_ID_OBJ_STATO");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCVRICERCASOGGETTI record = new GVCVRICERCASOGGETTI();
					recordList.Add(record);
					record.R_ID_SOGGETTO = Convert.ToInt32(reader.GetValue(r_ID_SOGGETTOColumnIndex));
					if(!reader.IsDBNull(r_ID_TIPO_SOGGETTOColumnIndex))
						record.R_ID_TIPO_SOGGETTO = Convert.ToInt32(reader.GetValue(r_ID_TIPO_SOGGETTOColumnIndex));
					record.R_ASSOCIAZIONE = Convert.ToInt32(reader.GetValue(r_ASSOCIAZIONEColumnIndex));
					if(!reader.IsDBNull(r_NOMEColumnIndex))
						record.R_NOME = Convert.ToString(reader.GetValue(r_NOMEColumnIndex));
					if(!reader.IsDBNull(r_COGNOMEColumnIndex))
						record.R_COGNOME = Convert.ToString(reader.GetValue(r_COGNOMEColumnIndex));
					if(!reader.IsDBNull(r_DENOMINAZIONEColumnIndex))
						record.R_DENOMINAZIONE = Convert.ToString(reader.GetValue(r_DENOMINAZIONEColumnIndex));
					if(!reader.IsDBNull(r_CODICE_FISCALEColumnIndex))
						record.R_CODICE_FISCALE = Convert.ToString(reader.GetValue(r_CODICE_FISCALEColumnIndex));
					if(!reader.IsDBNull(r_DATA_NASCITAColumnIndex))
						record.R_DATA_NASCITA = Convert.ToDateTime(reader.GetValue(r_DATA_NASCITAColumnIndex));
					if(!reader.IsDBNull(r_LUOGO_NASCITAColumnIndex))
						record.R_LUOGO_NASCITA = Convert.ToString(reader.GetValue(r_LUOGO_NASCITAColumnIndex));
					if(!reader.IsDBNull(r_CODICE_COOPERATIVAColumnIndex))
						record.R_CODICE_COOPERATIVA = Convert.ToInt32(reader.GetValue(r_CODICE_COOPERATIVAColumnIndex));
					if(!reader.IsDBNull(r_NUMERO_REAColumnIndex))
						record.R_NUMERO_REA = Convert.ToString(reader.GetValue(r_NUMERO_REAColumnIndex));
					if(!reader.IsDBNull(r_ID_OBJ_STATOColumnIndex))
						record.R_ID_OBJ_STATO = Convert.ToInt32(reader.GetValue(r_ID_OBJ_STATOColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCVRICERCASOGGETTI[])(recordList.ToArray(typeof(GVCVRICERCASOGGETTI)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCVRICERCASOGGETTI</returns>
		protected DataTable MapRecordsToDataTable(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>DataTable of objects GVCVRICERCASOGGETTI</returns>
		protected DataTable MapRecordsToDataTable(IDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to a DataTable
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCVRICERCASOGGETTI</returns>
		protected virtual DataTable MapRecordsToDataTable(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;

			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			dataTable.EndLoadData();
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts a DataRow to an object GVCVRICERCASOGGETTI
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCVRICERCASOGGETTI</returns>
		protected virtual GVCVRICERCASOGGETTI MapRow(DataRow row)
		{
			GVCVRICERCASOGGETTI mappedObject = new GVCVRICERCASOGGETTI();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "R_ID_SOGGETTO"
			dataColumn = dataTable.Columns["R_ID_SOGGETTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_ID_SOGGETTO = (System.Int32)row[dataColumn];
			//Campo "R_ID_TIPO_SOGGETTO"
			dataColumn = dataTable.Columns["R_ID_TIPO_SOGGETTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_ID_TIPO_SOGGETTO = (System.Int32)row[dataColumn];
			//Campo "R_ASSOCIAZIONE"
			dataColumn = dataTable.Columns["R_ASSOCIAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_ASSOCIAZIONE = (System.Int32)row[dataColumn];
			//Campo "R_NOME"
			dataColumn = dataTable.Columns["R_NOME"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_NOME = (System.String)row[dataColumn];
			//Campo "R_COGNOME"
			dataColumn = dataTable.Columns["R_COGNOME"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_COGNOME = (System.String)row[dataColumn];
			//Campo "R_DENOMINAZIONE"
			dataColumn = dataTable.Columns["R_DENOMINAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_DENOMINAZIONE = (System.String)row[dataColumn];
			//Campo "R_CODICE_FISCALE"
			dataColumn = dataTable.Columns["R_CODICE_FISCALE"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_CODICE_FISCALE = (System.String)row[dataColumn];
			//Campo "R_DATA_NASCITA"
			dataColumn = dataTable.Columns["R_DATA_NASCITA"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_DATA_NASCITA = (System.DateTime)row[dataColumn];
			//Campo "R_LUOGO_NASCITA"
			dataColumn = dataTable.Columns["R_LUOGO_NASCITA"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_LUOGO_NASCITA = (System.String)row[dataColumn];
			//Campo "R_CODICE_COOPERATIVA"
			dataColumn = dataTable.Columns["R_CODICE_COOPERATIVA"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_CODICE_COOPERATIVA = (System.Int32)row[dataColumn];
			//Campo "R_NUMERO_REA"
			dataColumn = dataTable.Columns["R_NUMERO_REA"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_NUMERO_REA = (System.String)row[dataColumn];
			//Campo "R_ID_OBJ_STATO"
			dataColumn = dataTable.Columns["R_ID_OBJ_STATO"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_ID_OBJ_STATO = (System.Int32)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCVRICERCASOGGETTI
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCVRICERCASOGGETTI";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("R_ID_SOGGETTO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_ID_TIPO_SOGGETTO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_ASSOCIAZIONE", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_NOME", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_COGNOME", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_DENOMINAZIONE", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_CODICE_FISCALE", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_DATA_NASCITA", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_LUOGO_NASCITA", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_CODICE_COOPERATIVA", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_NUMERO_REA", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_ID_OBJ_STATO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			return dataTable;
		}

		/// <summary>
		/// Adds to an IDbCommand a IDbDataParameter
		/// </summary>
		/// <param name="cmd">The IDbCommand</param>
		/// <param name="paramName">The parameter name to add</param>
		/// <param name="valore">The value of the parameter</param>
		/// <returns>A IDbDataParameter</returns>
		protected virtual IDbDataParameter AddParameter(IDbCommand cmd, string paramName, object valore)
		{
			IDbDataParameter parameter;
			switch(paramName)
			{
				case "R_ID_SOGGETTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_ID_TIPO_SOGGETTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_ASSOCIAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_NOME":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_COGNOME":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_DENOMINAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_CODICE_FISCALE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_DATA_NASCITA":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "R_LUOGO_NASCITA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_CODICE_COOPERATIVA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_NUMERO_REA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_ID_OBJ_STATO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}
