//
//Generated by gvc at 15/06/2009 9.44.12
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCVCERCAMODIFICHEPARIX
	/// </summary>
	public partial class GVCVCERCAMODIFICHEPARIXCollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_TIPO_SEGNALAZIONE.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_TIPO_SEGNALAZIONEColumnName = "IDOBJ_TIPO_SEGNALAZIONE";
		/// <summary>
		/// Returns the Database Name of the field DESCRIZIONE.
		/// </summary>
		public const string DESCRIZIONEColumnName = "DESCRIZIONE";
		/// <summary>
		/// Returns the Database Name of the field DATA_SEGNALAZIONE.
		///The field is mandatory.
		/// </summary>
		public const string DATA_SEGNALAZIONEColumnName = "DATA_SEGNALAZIONE";
		/// <summary>
		/// Returns the Database Name of the field DATAORAULTMOD.
		/// </summary>
		public const string DATAORAULTMODColumnName = "DATAORAULTMOD";
		/// <summary>
		/// Returns the Database Name of the field VISIBILE.
		/// </summary>
		public const string VISIBILEColumnName = "VISIBILE";
		/// <summary>
		/// Returns the Database Name of the field APPLICATO.
		/// </summary>
		public const string APPLICATOColumnName = "APPLICATO";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_REGISTRO.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_REGISTROColumnName = "IDOBJ_REGISTRO";
		/// <summary>
		/// Returns the Database Name of the field NUMERO_REA.
		/// </summary>
		public const string NUMERO_REAColumnName = "NUMERO_REA";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_SOGGETTO.
		/// </summary>
		public const string IDOBJ_SOGGETTOColumnName = "IDOBJ_SOGGETTO";
		/// <summary>
		/// Returns the Database Name of the field DENOMINAZIONE.
		/// </summary>
		public const string DENOMINAZIONEColumnName = "DENOMINAZIONE";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCVCERCAMODIFICHEPARIXCollection(GVC db)
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
		/// Returns an array containing all the objects GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <returns>Array of objects GVCVCERCAMODIFICHEPARIX</returns>
		public virtual GVCVCERCAMODIFICHEPARIX[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <returns>DataTable of objects GVCVCERCAMODIFICHEPARIX</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCVCERCAMODIFICHEPARIX selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCVCERCAMODIFICHEPARIX</returns>
		public GVCVCERCAMODIFICHEPARIX GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCVCERCAMODIFICHEPARIX[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCVCERCAMODIFICHEPARIX selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCVCERCAMODIFICHEPARIX</returns>
		public GVCVCERCAMODIFICHEPARIX[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCVCERCAMODIFICHEPARIX selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCVCERCAMODIFICHEPARIX</returns>
		public virtual GVCVCERCAMODIFICHEPARIX[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVCERCAMODIFICHEPARIX selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCVCERCAMODIFICHEPARIX</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVCERCAMODIFICHEPARIX selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCVCERCAMODIFICHEPARIX</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCVCERCAMODIFICHEPARIX selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ_TIPO_SEGNALAZIONE, ");
			sql.Append("DESCRIZIONE, ");
			sql.Append("DATA_SEGNALAZIONE, ");
			sql.Append("DATAORAULTMOD, ");
			sql.Append("VISIBILE, ");
			sql.Append("APPLICATO, ");
			sql.Append("IDOBJ, ");
			sql.Append("IDOBJ_REGISTRO, ");
			sql.Append("NUMERO_REA, ");
			sql.Append("IDOBJ_SOGGETTO, ");
			sql.Append("DENOMINAZIONE ");
			sql.Append("FROM GVCVCERCAMODIFICHEPARIX ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}


		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCVCERCAMODIFICHEPARIX</returns>
		protected GVCVCERCAMODIFICHEPARIX[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCVCERCAMODIFICHEPARIX</returns>
		protected GVCVCERCAMODIFICHEPARIX[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCVCERCAMODIFICHEPARIX</returns>
		protected virtual GVCVCERCAMODIFICHEPARIX[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJ_TIPO_SEGNALAZIONEColumnIndex = reader.GetOrdinal("IDOBJ_TIPO_SEGNALAZIONE");
			int dESCRIZIONEColumnIndex = reader.GetOrdinal("DESCRIZIONE");
			int dATA_SEGNALAZIONEColumnIndex = reader.GetOrdinal("DATA_SEGNALAZIONE");
			int dATAORAULTMODColumnIndex = reader.GetOrdinal("DATAORAULTMOD");
			int vISIBILEColumnIndex = reader.GetOrdinal("VISIBILE");
			int aPPLICATOColumnIndex = reader.GetOrdinal("APPLICATO");
			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int iDOBJ_REGISTROColumnIndex = reader.GetOrdinal("IDOBJ_REGISTRO");
			int nUMERO_REAColumnIndex = reader.GetOrdinal("NUMERO_REA");
			int iDOBJ_SOGGETTOColumnIndex = reader.GetOrdinal("IDOBJ_SOGGETTO");
			int dENOMINAZIONEColumnIndex = reader.GetOrdinal("DENOMINAZIONE");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCVCERCAMODIFICHEPARIX record = new GVCVCERCAMODIFICHEPARIX();
					recordList.Add(record);
					record.IDOBJ_TIPO_SEGNALAZIONE = Convert.ToInt32(reader.GetValue(iDOBJ_TIPO_SEGNALAZIONEColumnIndex));
					if(!reader.IsDBNull(dESCRIZIONEColumnIndex))
						record.DESCRIZIONE = Convert.ToString(reader.GetValue(dESCRIZIONEColumnIndex));
					record.DATA_SEGNALAZIONE = Convert.ToDateTime(reader.GetValue(dATA_SEGNALAZIONEColumnIndex));
					if(!reader.IsDBNull(dATAORAULTMODColumnIndex))
						record.DATAORAULTMOD = Convert.ToDateTime(reader.GetValue(dATAORAULTMODColumnIndex));
					if(!reader.IsDBNull(vISIBILEColumnIndex))
						record.VISIBILE = Convert.ToInt32(reader.GetValue(vISIBILEColumnIndex));
					if(!reader.IsDBNull(aPPLICATOColumnIndex))
						record.APPLICATO = Convert.ToInt32(reader.GetValue(aPPLICATOColumnIndex));
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.IDOBJ_REGISTRO = Convert.ToInt32(reader.GetValue(iDOBJ_REGISTROColumnIndex));
					if(!reader.IsDBNull(nUMERO_REAColumnIndex))
						record.NUMERO_REA = Convert.ToString(reader.GetValue(nUMERO_REAColumnIndex));
					if(!reader.IsDBNull(iDOBJ_SOGGETTOColumnIndex))
						record.IDOBJ_SOGGETTO = Convert.ToInt32(reader.GetValue(iDOBJ_SOGGETTOColumnIndex));
					if(!reader.IsDBNull(dENOMINAZIONEColumnIndex))
						record.DENOMINAZIONE = Convert.ToString(reader.GetValue(dENOMINAZIONEColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCVCERCAMODIFICHEPARIX[])(recordList.ToArray(typeof(GVCVCERCAMODIFICHEPARIX)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCVCERCAMODIFICHEPARIX</returns>
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
		/// <returns>DataTable of objects GVCVCERCAMODIFICHEPARIX</returns>
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
		/// <returns>DataTable of objects GVCVCERCAMODIFICHEPARIX</returns>
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
		/// Converts a DataRow to an object GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCVCERCAMODIFICHEPARIX</returns>
		protected virtual GVCVCERCAMODIFICHEPARIX MapRow(DataRow row)
		{
			GVCVCERCAMODIFICHEPARIX mappedObject = new GVCVCERCAMODIFICHEPARIX();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ_TIPO_SEGNALAZIONE"
			dataColumn = dataTable.Columns["IDOBJ_TIPO_SEGNALAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_TIPO_SEGNALAZIONE = (System.Int32)row[dataColumn];
			//Campo "DESCRIZIONE"
			dataColumn = dataTable.Columns["DESCRIZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.DESCRIZIONE = (System.String)row[dataColumn];
			//Campo "DATA_SEGNALAZIONE"
			dataColumn = dataTable.Columns["DATA_SEGNALAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATA_SEGNALAZIONE = (System.DateTime)row[dataColumn];
			//Campo "DATAORAULTMOD"
			dataColumn = dataTable.Columns["DATAORAULTMOD"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATAORAULTMOD = (System.DateTime)row[dataColumn];
			//Campo "VISIBILE"
			dataColumn = dataTable.Columns["VISIBILE"];
			if(!row.IsNull(dataColumn))
				mappedObject.VISIBILE = (System.Int32)row[dataColumn];
			//Campo "APPLICATO"
			dataColumn = dataTable.Columns["APPLICATO"];
			if(!row.IsNull(dataColumn))
				mappedObject.APPLICATO = (System.Int32)row[dataColumn];
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_REGISTRO"
			dataColumn = dataTable.Columns["IDOBJ_REGISTRO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_REGISTRO = (System.Int32)row[dataColumn];
			//Campo "NUMERO_REA"
			dataColumn = dataTable.Columns["NUMERO_REA"];
			if(!row.IsNull(dataColumn))
				mappedObject.NUMERO_REA = (System.String)row[dataColumn];
			//Campo "IDOBJ_SOGGETTO"
			dataColumn = dataTable.Columns["IDOBJ_SOGGETTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_SOGGETTO = (System.Int32)row[dataColumn];
			//Campo "DENOMINAZIONE"
			dataColumn = dataTable.Columns["DENOMINAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.DENOMINAZIONE = (System.String)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCVCERCAMODIFICHEPARIX
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCVCERCAMODIFICHEPARIX";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ_TIPO_SEGNALAZIONE", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DESCRIZIONE", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATA_SEGNALAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATAORAULTMOD", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("VISIBILE", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("APPLICATO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("NUMERO_REA", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ_SOGGETTO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DENOMINAZIONE", typeof(System.String));
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
				case "IDOBJ_TIPO_SEGNALAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "DESCRIZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "DATA_SEGNALAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "DATAORAULTMOD":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "VISIBILE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "APPLICATO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IDOBJ":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IDOBJ_REGISTRO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "NUMERO_REA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "IDOBJ_SOGGETTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "DENOMINAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}