//
//Generated by gvc at 30/07/2009 11.51.58
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCVRICERCABILANCI
	/// </summary>
	public partial class GVCVRICERCABILANCICollection
	{
		/// <summary>
		/// Returns the Database Name of the field S_DENOMINAZIONE.
		/// </summary>
		public const string S_DENOMINAZIONEColumnName = "S_DENOMINAZIONE";
		/// <summary>
		/// Returns the Database Name of the field S_IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string S_IDOBJColumnName = "S_IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field R_IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string R_IDOBJColumnName = "R_IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field R_NUMERO_REA.
		/// </summary>
		public const string R_NUMERO_REAColumnName = "R_NUMERO_REA";
		/// <summary>
		/// Returns the Database Name of the field R_IDOBJ_STATO.
		/// </summary>
		public const string R_IDOBJ_STATOColumnName = "R_IDOBJ_STATO";
		/// <summary>
		/// Returns the Database Name of the field R_ESENTE_VERSAMENTO_UTILI.
		/// </summary>
		public const string R_ESENTE_VERSAMENTO_UTILIColumnName = "R_ESENTE_VERSAMENTO_UTILI";
		/// <summary>
		/// Returns the Database Name of the field BIL_IDOBJ.
		/// </summary>
		public const string BIL_IDOBJColumnName = "BIL_IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field BIL_ANNO_RIFERIMENTO.
		/// </summary>
		public const string BIL_ANNO_RIFERIMENTOColumnName = "BIL_ANNO_RIFERIMENTO";
		/// <summary>
		/// Returns the Database Name of the field BIL_IDOBJ_TIPO_BILANCIO.
		/// </summary>
		public const string BIL_IDOBJ_TIPO_BILANCIOColumnName = "BIL_IDOBJ_TIPO_BILANCIO";
		/// <summary>
		/// Returns the Database Name of the field BIL_DATA_RIFERIMENTO.
		/// </summary>
		public const string BIL_DATA_RIFERIMENTOColumnName = "BIL_DATA_RIFERIMENTO";
		/// <summary>
		/// Returns the Database Name of the field BIL_DATA_DEPOSITO_RI.
		/// </summary>
		public const string BIL_DATA_DEPOSITO_RIColumnName = "BIL_DATA_DEPOSITO_RI";
		/// <summary>
		/// Returns the Database Name of the field BIL_DATA_SEGNALAZIONE.
		/// </summary>
		public const string BIL_DATA_SEGNALAZIONEColumnName = "BIL_DATA_SEGNALAZIONE";
		/// <summary>
		/// Returns the Database Name of the field BIL_REQUISITO_PREVALENZA.
		/// </summary>
		public const string BIL_REQUISITO_PREVALENZAColumnName = "BIL_REQUISITO_PREVALENZA";
		/// <summary>
		/// Returns the Database Name of the field BIL_IMPORTO_PERCENTO_UTILI.
		/// </summary>
		public const string BIL_IMPORTO_PERCENTO_UTILIColumnName = "BIL_IMPORTO_PERCENTO_UTILI";
		/// <summary>
		/// Returns the Database Name of the field BIL_IMPORTO_PATRIMONIO.
		/// </summary>
		public const string BIL_IMPORTO_PATRIMONIOColumnName = "BIL_IMPORTO_PATRIMONIO";
		/// <summary>
		/// Returns the Database Name of the field BIL_VERIFICA_PAGAMENTO.
		/// </summary>
		public const string BIL_VERIFICA_PAGAMENTOColumnName = "BIL_VERIFICA_PAGAMENTO";
		/// <summary>
		/// Returns the Database Name of the field ADESIONE_ASSOCIAZIONE.
		/// </summary>
		public const string ADESIONE_ASSOCIAZIONEColumnName = "ADESIONE_ASSOCIAZIONE";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCVRICERCABILANCICollection(GVC db)
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
		/// Returns an array containing all the objects GVCVRICERCABILANCI
		/// </summary>
		/// <returns>Array of objects GVCVRICERCABILANCI</returns>
		public virtual GVCVRICERCABILANCI[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCVRICERCABILANCI
		/// </summary>
		/// <returns>DataTable of objects GVCVRICERCABILANCI</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCVRICERCABILANCI
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCVRICERCABILANCI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCVRICERCABILANCI</returns>
		public GVCVRICERCABILANCI GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCVRICERCABILANCI[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCVRICERCABILANCI selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCVRICERCABILANCI</returns>
		public GVCVRICERCABILANCI[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCVRICERCABILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCVRICERCABILANCI</returns>
		public virtual GVCVRICERCABILANCI[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVRICERCABILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCVRICERCABILANCI</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVRICERCABILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCVRICERCABILANCI</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCVRICERCABILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("S_DENOMINAZIONE, ");
			sql.Append("S_IDOBJ, ");
			sql.Append("R_IDOBJ, ");
			sql.Append("R_NUMERO_REA, ");
			sql.Append("R_IDOBJ_STATO, ");
			sql.Append("R_ESENTE_VERSAMENTO_UTILI, ");
			sql.Append("BIL_IDOBJ, ");
			sql.Append("BIL_ANNO_RIFERIMENTO, ");
			sql.Append("BIL_IDOBJ_TIPO_BILANCIO, ");
			sql.Append("BIL_DATA_RIFERIMENTO, ");
			sql.Append("BIL_DATA_DEPOSITO_RI, ");
			sql.Append("BIL_DATA_SEGNALAZIONE, ");
			sql.Append("BIL_REQUISITO_PREVALENZA, ");
			sql.Append("BIL_IMPORTO_PERCENTO_UTILI, ");
			sql.Append("BIL_IMPORTO_PATRIMONIO, ");
			sql.Append("BIL_VERIFICA_PAGAMENTO, ");
			sql.Append("ADESIONE_ASSOCIAZIONE ");
			sql.Append("FROM GVCVRICERCABILANCI ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}


		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVRICERCABILANCI
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCVRICERCABILANCI</returns>
		protected GVCVRICERCABILANCI[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVRICERCABILANCI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCVRICERCABILANCI</returns>
		protected GVCVRICERCABILANCI[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCVRICERCABILANCI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCVRICERCABILANCI</returns>
		protected virtual GVCVRICERCABILANCI[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int s_DENOMINAZIONEColumnIndex = reader.GetOrdinal("S_DENOMINAZIONE");
			int s_IDOBJColumnIndex = reader.GetOrdinal("S_IDOBJ");
			int r_IDOBJColumnIndex = reader.GetOrdinal("R_IDOBJ");
			int r_NUMERO_REAColumnIndex = reader.GetOrdinal("R_NUMERO_REA");
			int r_IDOBJ_STATOColumnIndex = reader.GetOrdinal("R_IDOBJ_STATO");
			int r_ESENTE_VERSAMENTO_UTILIColumnIndex = reader.GetOrdinal("R_ESENTE_VERSAMENTO_UTILI");
			int bIL_IDOBJColumnIndex = reader.GetOrdinal("BIL_IDOBJ");
			int bIL_ANNO_RIFERIMENTOColumnIndex = reader.GetOrdinal("BIL_ANNO_RIFERIMENTO");
			int bIL_IDOBJ_TIPO_BILANCIOColumnIndex = reader.GetOrdinal("BIL_IDOBJ_TIPO_BILANCIO");
			int bIL_DATA_RIFERIMENTOColumnIndex = reader.GetOrdinal("BIL_DATA_RIFERIMENTO");
			int bIL_DATA_DEPOSITO_RIColumnIndex = reader.GetOrdinal("BIL_DATA_DEPOSITO_RI");
			int bIL_DATA_SEGNALAZIONEColumnIndex = reader.GetOrdinal("BIL_DATA_SEGNALAZIONE");
			int bIL_REQUISITO_PREVALENZAColumnIndex = reader.GetOrdinal("BIL_REQUISITO_PREVALENZA");
			int bIL_IMPORTO_PERCENTO_UTILIColumnIndex = reader.GetOrdinal("BIL_IMPORTO_PERCENTO_UTILI");
			int bIL_IMPORTO_PATRIMONIOColumnIndex = reader.GetOrdinal("BIL_IMPORTO_PATRIMONIO");
			int bIL_VERIFICA_PAGAMENTOColumnIndex = reader.GetOrdinal("BIL_VERIFICA_PAGAMENTO");
			int aDESIONE_ASSOCIAZIONEColumnIndex = reader.GetOrdinal("ADESIONE_ASSOCIAZIONE");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCVRICERCABILANCI record = new GVCVRICERCABILANCI();
					recordList.Add(record);
					if(!reader.IsDBNull(s_DENOMINAZIONEColumnIndex))
						record.S_DENOMINAZIONE = Convert.ToString(reader.GetValue(s_DENOMINAZIONEColumnIndex));
					record.S_IDOBJ = Convert.ToInt32(reader.GetValue(s_IDOBJColumnIndex));
					record.R_IDOBJ = Convert.ToInt32(reader.GetValue(r_IDOBJColumnIndex));
					if(!reader.IsDBNull(r_NUMERO_REAColumnIndex))
						record.R_NUMERO_REA = Convert.ToString(reader.GetValue(r_NUMERO_REAColumnIndex));
					if(!reader.IsDBNull(r_IDOBJ_STATOColumnIndex))
						record.R_IDOBJ_STATO = Convert.ToInt32(reader.GetValue(r_IDOBJ_STATOColumnIndex));
					if(!reader.IsDBNull(r_ESENTE_VERSAMENTO_UTILIColumnIndex))
						record.R_ESENTE_VERSAMENTO_UTILI = Convert.ToInt32(reader.GetValue(r_ESENTE_VERSAMENTO_UTILIColumnIndex));
					if(!reader.IsDBNull(bIL_IDOBJColumnIndex))
						record.BIL_IDOBJ = Convert.ToInt32(reader.GetValue(bIL_IDOBJColumnIndex));
					if(!reader.IsDBNull(bIL_ANNO_RIFERIMENTOColumnIndex))
						record.BIL_ANNO_RIFERIMENTO = Convert.ToInt32(reader.GetValue(bIL_ANNO_RIFERIMENTOColumnIndex));
					if(!reader.IsDBNull(bIL_IDOBJ_TIPO_BILANCIOColumnIndex))
						record.BIL_IDOBJ_TIPO_BILANCIO = Convert.ToInt32(reader.GetValue(bIL_IDOBJ_TIPO_BILANCIOColumnIndex));
					if(!reader.IsDBNull(bIL_DATA_RIFERIMENTOColumnIndex))
						record.BIL_DATA_RIFERIMENTO = Convert.ToDateTime(reader.GetValue(bIL_DATA_RIFERIMENTOColumnIndex));
					if(!reader.IsDBNull(bIL_DATA_DEPOSITO_RIColumnIndex))
						record.BIL_DATA_DEPOSITO_RI = Convert.ToDateTime(reader.GetValue(bIL_DATA_DEPOSITO_RIColumnIndex));
					if(!reader.IsDBNull(bIL_DATA_SEGNALAZIONEColumnIndex))
						record.BIL_DATA_SEGNALAZIONE = Convert.ToDateTime(reader.GetValue(bIL_DATA_SEGNALAZIONEColumnIndex));
					if(!reader.IsDBNull(bIL_REQUISITO_PREVALENZAColumnIndex))
						record.BIL_REQUISITO_PREVALENZA = Convert.ToInt32(reader.GetValue(bIL_REQUISITO_PREVALENZAColumnIndex));
					if(!reader.IsDBNull(bIL_IMPORTO_PERCENTO_UTILIColumnIndex))
						record.BIL_IMPORTO_PERCENTO_UTILI = Convert.ToDouble(reader.GetValue(bIL_IMPORTO_PERCENTO_UTILIColumnIndex));
					if(!reader.IsDBNull(bIL_IMPORTO_PATRIMONIOColumnIndex))
						record.BIL_IMPORTO_PATRIMONIO = Convert.ToDouble(reader.GetValue(bIL_IMPORTO_PATRIMONIOColumnIndex));
					if(!reader.IsDBNull(bIL_VERIFICA_PAGAMENTOColumnIndex))
						record.BIL_VERIFICA_PAGAMENTO = Convert.ToInt32(reader.GetValue(bIL_VERIFICA_PAGAMENTOColumnIndex));
					if(!reader.IsDBNull(aDESIONE_ASSOCIAZIONEColumnIndex))
						record.ADESIONE_ASSOCIAZIONE = Convert.ToString(reader.GetValue(aDESIONE_ASSOCIAZIONEColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCVRICERCABILANCI[])(recordList.ToArray(typeof(GVCVRICERCABILANCI)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCVRICERCABILANCI</returns>
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
		/// <returns>DataTable of objects GVCVRICERCABILANCI</returns>
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
		/// <returns>DataTable of objects GVCVRICERCABILANCI</returns>
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
		/// Converts a DataRow to an object GVCVRICERCABILANCI
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCVRICERCABILANCI</returns>
		protected virtual GVCVRICERCABILANCI MapRow(DataRow row)
		{
			GVCVRICERCABILANCI mappedObject = new GVCVRICERCABILANCI();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "S_DENOMINAZIONE"
			dataColumn = dataTable.Columns["S_DENOMINAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.S_DENOMINAZIONE = (System.String)row[dataColumn];
			//Campo "S_IDOBJ"
			dataColumn = dataTable.Columns["S_IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.S_IDOBJ = (System.Int32)row[dataColumn];
			//Campo "R_IDOBJ"
			dataColumn = dataTable.Columns["R_IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_IDOBJ = (System.Int32)row[dataColumn];
			//Campo "R_NUMERO_REA"
			dataColumn = dataTable.Columns["R_NUMERO_REA"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_NUMERO_REA = (System.String)row[dataColumn];
			//Campo "R_IDOBJ_STATO"
			dataColumn = dataTable.Columns["R_IDOBJ_STATO"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_IDOBJ_STATO = (System.Int32)row[dataColumn];
			//Campo "R_ESENTE_VERSAMENTO_UTILI"
			dataColumn = dataTable.Columns["R_ESENTE_VERSAMENTO_UTILI"];
			if(!row.IsNull(dataColumn))
				mappedObject.R_ESENTE_VERSAMENTO_UTILI = (System.Int32)row[dataColumn];
			//Campo "BIL_IDOBJ"
			dataColumn = dataTable.Columns["BIL_IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_IDOBJ = (System.Int32)row[dataColumn];
			//Campo "BIL_ANNO_RIFERIMENTO"
			dataColumn = dataTable.Columns["BIL_ANNO_RIFERIMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_ANNO_RIFERIMENTO = (System.Int32)row[dataColumn];
			//Campo "BIL_IDOBJ_TIPO_BILANCIO"
			dataColumn = dataTable.Columns["BIL_IDOBJ_TIPO_BILANCIO"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_IDOBJ_TIPO_BILANCIO = (System.Int32)row[dataColumn];
			//Campo "BIL_DATA_RIFERIMENTO"
			dataColumn = dataTable.Columns["BIL_DATA_RIFERIMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_DATA_RIFERIMENTO = (System.DateTime)row[dataColumn];
			//Campo "BIL_DATA_DEPOSITO_RI"
			dataColumn = dataTable.Columns["BIL_DATA_DEPOSITO_RI"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_DATA_DEPOSITO_RI = (System.DateTime)row[dataColumn];
			//Campo "BIL_DATA_SEGNALAZIONE"
			dataColumn = dataTable.Columns["BIL_DATA_SEGNALAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_DATA_SEGNALAZIONE = (System.DateTime)row[dataColumn];
			//Campo "BIL_REQUISITO_PREVALENZA"
			dataColumn = dataTable.Columns["BIL_REQUISITO_PREVALENZA"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_REQUISITO_PREVALENZA = (System.Int32)row[dataColumn];
			//Campo "BIL_IMPORTO_PERCENTO_UTILI"
			dataColumn = dataTable.Columns["BIL_IMPORTO_PERCENTO_UTILI"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_IMPORTO_PERCENTO_UTILI = (System.Double)row[dataColumn];
			//Campo "BIL_IMPORTO_PATRIMONIO"
			dataColumn = dataTable.Columns["BIL_IMPORTO_PATRIMONIO"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_IMPORTO_PATRIMONIO = (System.Double)row[dataColumn];
			//Campo "BIL_VERIFICA_PAGAMENTO"
			dataColumn = dataTable.Columns["BIL_VERIFICA_PAGAMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.BIL_VERIFICA_PAGAMENTO = (System.Int32)row[dataColumn];
			//Campo "ADESIONE_ASSOCIAZIONE"
			dataColumn = dataTable.Columns["ADESIONE_ASSOCIAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.ADESIONE_ASSOCIAZIONE = (System.String)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCVRICERCABILANCI
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCVRICERCABILANCI";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("S_DENOMINAZIONE", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("S_IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_NUMERO_REA", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_IDOBJ_STATO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("R_ESENTE_VERSAMENTO_UTILI", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_ANNO_RIFERIMENTO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_IDOBJ_TIPO_BILANCIO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_DATA_RIFERIMENTO", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_DATA_DEPOSITO_RI", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_DATA_SEGNALAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_REQUISITO_PREVALENZA", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_IMPORTO_PERCENTO_UTILI", typeof(System.Double));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_IMPORTO_PATRIMONIO", typeof(System.Double));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("BIL_VERIFICA_PAGAMENTO", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("ADESIONE_ASSOCIAZIONE", typeof(System.String));
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
				case "S_DENOMINAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "S_IDOBJ":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_IDOBJ":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_NUMERO_REA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "R_IDOBJ_STATO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "R_ESENTE_VERSAMENTO_UTILI":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "BIL_IDOBJ":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "BIL_ANNO_RIFERIMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "BIL_IDOBJ_TIPO_BILANCIO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "BIL_DATA_RIFERIMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "BIL_DATA_DEPOSITO_RI":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "BIL_DATA_SEGNALAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "BIL_REQUISITO_PREVALENZA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "BIL_IMPORTO_PERCENTO_UTILI":
					parameter = _db.AddParameter(cmd, paramName, DbType.Double, valore);
					break;

				case "BIL_IMPORTO_PATRIMONIO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Double, valore);
					break;

				case "BIL_VERIFICA_PAGAMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "ADESIONE_ASSOCIAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}
