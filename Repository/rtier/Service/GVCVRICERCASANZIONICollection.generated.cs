//
//Generated by gvc at 27/07/2009 16.10.08
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCVRICERCASANZIONI
	/// </summary>
	public partial class GVCVRICERCASANZIONICollection
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
		/// Returns the Database Name of the field SAN_DATA_RILIEVO_INFRAZIONE.
		///The field is mandatory.
		/// </summary>
		public const string SAN_DATA_RILIEVO_INFRAZIONEColumnName = "SAN_DATA_RILIEVO_INFRAZIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_IDOBJ_TIPO_TRASGRESSIONE.
		///The field is mandatory.
		/// </summary>
		public const string SAN_IDOBJ_TIPO_TRASGRESSIONEColumnName = "SAN_IDOBJ_TIPO_TRASGRESSIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_IDOBJ_LEGGE_TRASGRESSIONE.
		/// </summary>
		public const string SAN_IDOBJ_LEGGE_TRASGRESSIONEColumnName = "SAN_IDOBJ_LEGGE_TRASGRESSIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_INFRAZIONE.
		/// </summary>
		public const string SAN_DATA_INFRAZIONEColumnName = "SAN_DATA_INFRAZIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_PAG_OBLAZIONE.
		/// </summary>
		public const string SAN_DATA_PAG_OBLAZIONEColumnName = "SAN_DATA_PAG_OBLAZIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_SCRITTI_DIFENSIVI.
		/// </summary>
		public const string SAN_DATA_SCRITTI_DIFENSIVIColumnName = "SAN_DATA_SCRITTI_DIFENSIVI";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_AUDIZIONE.
		/// </summary>
		public const string SAN_DATA_AUDIZIONEColumnName = "SAN_DATA_AUDIZIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_IMPORTO_ORDINANZA.
		/// </summary>
		public const string SAN_IMPORTO_ORDINANZAColumnName = "SAN_IMPORTO_ORDINANZA";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_RICORSO.
		/// </summary>
		public const string SAN_DATA_RICORSOColumnName = "SAN_DATA_RICORSO";
		/// <summary>
		/// Returns the Database Name of the field SAN_IDOBJ_GIUDICE.
		/// </summary>
		public const string SAN_IDOBJ_GIUDICEColumnName = "SAN_IDOBJ_GIUDICE";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_ARCHIVIAZIONE.
		/// </summary>
		public const string SAN_DATA_ARCHIVIAZIONEColumnName = "SAN_DATA_ARCHIVIAZIONE";
		/// <summary>
		/// Returns the Database Name of the field SAN_DATA_PAGAMENTO.
		/// </summary>
		public const string SAN_DATA_PAGAMENTOColumnName = "SAN_DATA_PAGAMENTO";
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
		public GVCVRICERCASANZIONICollection(GVC db)
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
		/// Returns an array containing all the objects GVCVRICERCASANZIONI
		/// </summary>
		/// <returns>Array of objects GVCVRICERCASANZIONI</returns>
		public virtual GVCVRICERCASANZIONI[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCVRICERCASANZIONI
		/// </summary>
		/// <returns>DataTable of objects GVCVRICERCASANZIONI</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCVRICERCASANZIONI
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCVRICERCASANZIONI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCVRICERCASANZIONI</returns>
		public GVCVRICERCASANZIONI GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCVRICERCASANZIONI[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCVRICERCASANZIONI selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCVRICERCASANZIONI</returns>
		public GVCVRICERCASANZIONI[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCVRICERCASANZIONI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCVRICERCASANZIONI</returns>
		public virtual GVCVRICERCASANZIONI[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVRICERCASANZIONI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCVRICERCASANZIONI</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCVRICERCASANZIONI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCVRICERCASANZIONI</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCVRICERCASANZIONI selected by 
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
			sql.Append("SAN_DATA_RILIEVO_INFRAZIONE, ");
			sql.Append("SAN_IDOBJ_TIPO_TRASGRESSIONE, ");
			sql.Append("SAN_IDOBJ_LEGGE_TRASGRESSIONE, ");
			sql.Append("SAN_DATA_INFRAZIONE, ");
			sql.Append("SAN_DATA_PAG_OBLAZIONE, ");
			sql.Append("SAN_DATA_SCRITTI_DIFENSIVI, ");
			sql.Append("SAN_DATA_AUDIZIONE, ");
			sql.Append("SAN_IMPORTO_ORDINANZA, ");
			sql.Append("SAN_DATA_RICORSO, ");
			sql.Append("SAN_IDOBJ_GIUDICE, ");
			sql.Append("SAN_DATA_ARCHIVIAZIONE, ");
			sql.Append("SAN_DATA_PAGAMENTO, ");
			sql.Append("ADESIONE_ASSOCIAZIONE ");
			sql.Append("FROM GVCVRICERCASANZIONI ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}


		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVRICERCASANZIONI
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCVRICERCASANZIONI</returns>
		protected GVCVRICERCASANZIONI[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCVRICERCASANZIONI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCVRICERCASANZIONI</returns>
		protected GVCVRICERCASANZIONI[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCVRICERCASANZIONI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCVRICERCASANZIONI</returns>
		protected virtual GVCVRICERCASANZIONI[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
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
			int sAN_DATA_RILIEVO_INFRAZIONEColumnIndex = reader.GetOrdinal("SAN_DATA_RILIEVO_INFRAZIONE");
			int sAN_IDOBJ_TIPO_TRASGRESSIONEColumnIndex = reader.GetOrdinal("SAN_IDOBJ_TIPO_TRASGRESSIONE");
			int sAN_IDOBJ_LEGGE_TRASGRESSIONEColumnIndex = reader.GetOrdinal("SAN_IDOBJ_LEGGE_TRASGRESSIONE");
			int sAN_DATA_INFRAZIONEColumnIndex = reader.GetOrdinal("SAN_DATA_INFRAZIONE");
			int sAN_DATA_PAG_OBLAZIONEColumnIndex = reader.GetOrdinal("SAN_DATA_PAG_OBLAZIONE");
			int sAN_DATA_SCRITTI_DIFENSIVIColumnIndex = reader.GetOrdinal("SAN_DATA_SCRITTI_DIFENSIVI");
			int sAN_DATA_AUDIZIONEColumnIndex = reader.GetOrdinal("SAN_DATA_AUDIZIONE");
			int sAN_IMPORTO_ORDINANZAColumnIndex = reader.GetOrdinal("SAN_IMPORTO_ORDINANZA");
			int sAN_DATA_RICORSOColumnIndex = reader.GetOrdinal("SAN_DATA_RICORSO");
			int sAN_IDOBJ_GIUDICEColumnIndex = reader.GetOrdinal("SAN_IDOBJ_GIUDICE");
			int sAN_DATA_ARCHIVIAZIONEColumnIndex = reader.GetOrdinal("SAN_DATA_ARCHIVIAZIONE");
			int sAN_DATA_PAGAMENTOColumnIndex = reader.GetOrdinal("SAN_DATA_PAGAMENTO");
			int aDESIONE_ASSOCIAZIONEColumnIndex = reader.GetOrdinal("ADESIONE_ASSOCIAZIONE");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCVRICERCASANZIONI record = new GVCVRICERCASANZIONI();
					recordList.Add(record);
					if(!reader.IsDBNull(s_DENOMINAZIONEColumnIndex))
						record.S_DENOMINAZIONE = Convert.ToString(reader.GetValue(s_DENOMINAZIONEColumnIndex));
					record.S_IDOBJ = Convert.ToInt32(reader.GetValue(s_IDOBJColumnIndex));
					if(!reader.IsDBNull(r_IDOBJColumnIndex))
						record.R_IDOBJ = Convert.ToInt32(reader.GetValue(r_IDOBJColumnIndex));
					if(!reader.IsDBNull(r_NUMERO_REAColumnIndex))
						record.R_NUMERO_REA = Convert.ToString(reader.GetValue(r_NUMERO_REAColumnIndex));
					if(!reader.IsDBNull(r_IDOBJ_STATOColumnIndex))
						record.R_IDOBJ_STATO = Convert.ToInt32(reader.GetValue(r_IDOBJ_STATOColumnIndex));
					record.SAN_DATA_RILIEVO_INFRAZIONE = Convert.ToDateTime(reader.GetValue(sAN_DATA_RILIEVO_INFRAZIONEColumnIndex));
					record.SAN_IDOBJ_TIPO_TRASGRESSIONE = Convert.ToInt32(reader.GetValue(sAN_IDOBJ_TIPO_TRASGRESSIONEColumnIndex));
					if(!reader.IsDBNull(sAN_IDOBJ_LEGGE_TRASGRESSIONEColumnIndex))
						record.SAN_IDOBJ_LEGGE_TRASGRESSIONE = Convert.ToInt32(reader.GetValue(sAN_IDOBJ_LEGGE_TRASGRESSIONEColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_INFRAZIONEColumnIndex))
						record.SAN_DATA_INFRAZIONE = Convert.ToDateTime(reader.GetValue(sAN_DATA_INFRAZIONEColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_PAG_OBLAZIONEColumnIndex))
						record.SAN_DATA_PAG_OBLAZIONE = Convert.ToDateTime(reader.GetValue(sAN_DATA_PAG_OBLAZIONEColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_SCRITTI_DIFENSIVIColumnIndex))
						record.SAN_DATA_SCRITTI_DIFENSIVI = Convert.ToDateTime(reader.GetValue(sAN_DATA_SCRITTI_DIFENSIVIColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_AUDIZIONEColumnIndex))
						record.SAN_DATA_AUDIZIONE = Convert.ToDateTime(reader.GetValue(sAN_DATA_AUDIZIONEColumnIndex));
					if(!reader.IsDBNull(sAN_IMPORTO_ORDINANZAColumnIndex))
						record.SAN_IMPORTO_ORDINANZA = Convert.ToDouble(reader.GetValue(sAN_IMPORTO_ORDINANZAColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_RICORSOColumnIndex))
						record.SAN_DATA_RICORSO = Convert.ToDateTime(reader.GetValue(sAN_DATA_RICORSOColumnIndex));
					if(!reader.IsDBNull(sAN_IDOBJ_GIUDICEColumnIndex))
						record.SAN_IDOBJ_GIUDICE = Convert.ToInt32(reader.GetValue(sAN_IDOBJ_GIUDICEColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_ARCHIVIAZIONEColumnIndex))
						record.SAN_DATA_ARCHIVIAZIONE = Convert.ToDateTime(reader.GetValue(sAN_DATA_ARCHIVIAZIONEColumnIndex));
					if(!reader.IsDBNull(sAN_DATA_PAGAMENTOColumnIndex))
						record.SAN_DATA_PAGAMENTO = Convert.ToDateTime(reader.GetValue(sAN_DATA_PAGAMENTOColumnIndex));
					if(!reader.IsDBNull(aDESIONE_ASSOCIAZIONEColumnIndex))
						record.ADESIONE_ASSOCIAZIONE = Convert.ToString(reader.GetValue(aDESIONE_ASSOCIAZIONEColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCVRICERCASANZIONI[])(recordList.ToArray(typeof(GVCVRICERCASANZIONI)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCVRICERCASANZIONI</returns>
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
		/// <returns>DataTable of objects GVCVRICERCASANZIONI</returns>
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
		/// <returns>DataTable of objects GVCVRICERCASANZIONI</returns>
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
		/// Converts a DataRow to an object GVCVRICERCASANZIONI
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCVRICERCASANZIONI</returns>
		protected virtual GVCVRICERCASANZIONI MapRow(DataRow row)
		{
			GVCVRICERCASANZIONI mappedObject = new GVCVRICERCASANZIONI();
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
			//Campo "SAN_DATA_RILIEVO_INFRAZIONE"
			dataColumn = dataTable.Columns["SAN_DATA_RILIEVO_INFRAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_RILIEVO_INFRAZIONE = (System.DateTime)row[dataColumn];
			//Campo "SAN_IDOBJ_TIPO_TRASGRESSIONE"
			dataColumn = dataTable.Columns["SAN_IDOBJ_TIPO_TRASGRESSIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_IDOBJ_TIPO_TRASGRESSIONE = (System.Int32)row[dataColumn];
			//Campo "SAN_IDOBJ_LEGGE_TRASGRESSIONE"
			dataColumn = dataTable.Columns["SAN_IDOBJ_LEGGE_TRASGRESSIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_IDOBJ_LEGGE_TRASGRESSIONE = (System.Int32)row[dataColumn];
			//Campo "SAN_DATA_INFRAZIONE"
			dataColumn = dataTable.Columns["SAN_DATA_INFRAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_INFRAZIONE = (System.DateTime)row[dataColumn];
			//Campo "SAN_DATA_PAG_OBLAZIONE"
			dataColumn = dataTable.Columns["SAN_DATA_PAG_OBLAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_PAG_OBLAZIONE = (System.DateTime)row[dataColumn];
			//Campo "SAN_DATA_SCRITTI_DIFENSIVI"
			dataColumn = dataTable.Columns["SAN_DATA_SCRITTI_DIFENSIVI"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_SCRITTI_DIFENSIVI = (System.DateTime)row[dataColumn];
			//Campo "SAN_DATA_AUDIZIONE"
			dataColumn = dataTable.Columns["SAN_DATA_AUDIZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_AUDIZIONE = (System.DateTime)row[dataColumn];
			//Campo "SAN_IMPORTO_ORDINANZA"
			dataColumn = dataTable.Columns["SAN_IMPORTO_ORDINANZA"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_IMPORTO_ORDINANZA = (System.Double)row[dataColumn];
			//Campo "SAN_DATA_RICORSO"
			dataColumn = dataTable.Columns["SAN_DATA_RICORSO"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_RICORSO = (System.DateTime)row[dataColumn];
			//Campo "SAN_IDOBJ_GIUDICE"
			dataColumn = dataTable.Columns["SAN_IDOBJ_GIUDICE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_IDOBJ_GIUDICE = (System.Int32)row[dataColumn];
			//Campo "SAN_DATA_ARCHIVIAZIONE"
			dataColumn = dataTable.Columns["SAN_DATA_ARCHIVIAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_ARCHIVIAZIONE = (System.DateTime)row[dataColumn];
			//Campo "SAN_DATA_PAGAMENTO"
			dataColumn = dataTable.Columns["SAN_DATA_PAGAMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.SAN_DATA_PAGAMENTO = (System.DateTime)row[dataColumn];
			//Campo "ADESIONE_ASSOCIAZIONE"
			dataColumn = dataTable.Columns["ADESIONE_ASSOCIAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.ADESIONE_ASSOCIAZIONE = (System.String)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCVRICERCASANZIONI
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCVRICERCASANZIONI";
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
			dataColumn.AllowDBNull = true;
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
			dataColumn = dataTable.Columns.Add("SAN_DATA_RILIEVO_INFRAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_IDOBJ_TIPO_TRASGRESSIONE", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_IDOBJ_LEGGE_TRASGRESSIONE", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_INFRAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_PAG_OBLAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_SCRITTI_DIFENSIVI", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_AUDIZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_IMPORTO_ORDINANZA", typeof(System.Double));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_RICORSO", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_IDOBJ_GIUDICE", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_ARCHIVIAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("SAN_DATA_PAGAMENTO", typeof(System.DateTime));
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

				case "SAN_DATA_RILIEVO_INFRAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_IDOBJ_TIPO_TRASGRESSIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "SAN_IDOBJ_LEGGE_TRASGRESSIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "SAN_DATA_INFRAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_DATA_PAG_OBLAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_DATA_SCRITTI_DIFENSIVI":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_DATA_AUDIZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_IMPORTO_ORDINANZA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Double, valore);
					break;

				case "SAN_DATA_RICORSO":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_IDOBJ_GIUDICE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "SAN_DATA_ARCHIVIAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "SAN_DATA_PAGAMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
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
