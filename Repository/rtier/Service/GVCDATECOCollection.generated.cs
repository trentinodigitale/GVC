//
//Generated by gvc at 26/03/2009 9.03.13
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCDATECO
	/// </summary>
	public partial class GVCDATECOCollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field CODICE.
		///The field is mandatory.
		/// </summary>
		public const string CODICEColumnName = "CODICE";
		/// <summary>
		/// Returns the Database Name of the field DESCRIZIONE.
		/// </summary>
		public const string DESCRIZIONEColumnName = "DESCRIZIONE";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCDATECOCollection(GVC db)
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
		/// Returns an array containing all the objects GVCDATECO
		/// </summary>
		/// <returns>Array of objects GVCDATECO</returns>
		public virtual GVCDATECO[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCDATECO
		/// </summary>
		/// <returns>DataTable of objects GVCDATECO</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCDATECO
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCDATECO selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCDATECO</returns>
		public GVCDATECO GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCDATECO[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCDATECO selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCDATECO</returns>
		public GVCDATECO[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCDATECO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCDATECO</returns>
		public virtual GVCDATECO[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCDATECO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCDATECO</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCDATECO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCDATECO</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCDATECO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ, ");
			sql.Append("CODICE, ");
			sql.Append("DESCRIZIONE ");
			sql.Append("FROM GVCDATECO ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Returns an object GVCDATECO selected by a primary key
		/// </summary>
		/// <param name="IDOBJ">The primary key of the object</param>
		/// <returns>Object of type GVCDATECO</returns>
		public virtual GVCDATECO GetByPrimaryKey(System.Int32 IDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateGetCommand(whereSql, null))
			{
				AddParameter(cmd, "IDOBJ", IDOBJ);
				GVCDATECO[] tempArray = MapRecords(cmd);
				return tempArray.Length == 0 ? null : tempArray[0];
			}
		}


		/// <summary>
		/// Inserts in the Database an object GVCDATECO
		/// </summary>
		/// <param name="valore">The object to insert</param>
		public virtual void Insert(GVCDATECO valore)
		{
			System.Int32 id = -1;
			System.String sqlStr;

			sqlStr = "SELECT GVCDATECO_SEQ.NEXTVAL FROM DUAL";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				id = Convert.ToInt32(cmd.ExecuteScalar());
			}

			sqlStr = "INSERT INTO GVCDATECO (" +
			"IDOBJ, " +
			"CODICE, " +
			"DESCRIZIONE) " +
			"VALUES (" + id.ToString() + ", " +
			_db.CreateSqlParameterName("CODICE") + ", " +
			_db.CreateSqlParameterName("DESCRIZIONE") + ")";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "CODICE", valore.CODICE);
				AddParameter(cmd, "DESCRIZIONE", valore.IsDESCRIZIONENull ? DBNull.Value : (object)valore.DESCRIZIONE);
				cmd.ExecuteScalar();
				valore.IDOBJ = id;
			}
		}

		/// <summary>
		/// Updates in the Database an object GVCDATECO
		/// </summary>
		/// <param name="valore">The object to update</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool Update(GVCDATECO valore)
		{
			System.String sqlStr = "UPDATE GVCDATECO SET " +
				"CODICE = " + _db.CreateSqlParameterName("CODICE") + ", " +
				"DESCRIZIONE = " + _db.CreateSqlParameterName("DESCRIZIONE") +
				" WHERE " +
				"IDOBJ = " + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ", valore.IDOBJ);
				AddParameter(cmd, "CODICE", valore.CODICE);
				AddParameter(cmd, "DESCRIZIONE", valore.IsDESCRIZIONENull ? DBNull.Value : (object)valore.DESCRIZIONE);
				return cmd.ExecuteNonQuery() != 0;
			}
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCDATECO
		/// </summary>
		/// <param name="table">The DataTable of objects GVCDATECO</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCDATECO
		/// </summary>
		/// <param name="table">The DataTable of objects GVCDATECO</param>
		/// <param name="acceptChanges">true to accept the changes, otherwise false</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((System.Int32)row["IDOBJ"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;

				case DataRowState.Modified:
					Update(MapRow(row));
					if(acceptChanges)
						row.AcceptChanges();
					break;
				}
			}
		}

		/// <summary>
		/// Deletes from the Database an object GVCDATECO
		/// </summary>
		/// <param name="valore">The object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public bool Delete(GVCDATECO valore)
		{
			return DeleteByPrimaryKey(valore.IDOBJ);
		}

		/// <summary>
		/// Deletes from the Database an object GVCDATECO
		/// </summary>
		/// <param name="iDOBJ">The primary key of the object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool DeleteByPrimaryKey(System.Int32 iDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateDeleteCommand(whereSql))
			{
				AddParameter(cmd, "IDOBJ" , iDOBJ);
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		/// <summary>
		/// Deletes from the Database the objects GVCDATECO selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>The number of the deleted objects</returns>
		public int Delete(System.String whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Returns an IDbCommand to delete the objects GVCDATECO selected by 
		/// a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			StringBuilder sql = new StringBuilder("DELETE FROM GVCDATECO");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format(" WHERE {0}", whereSql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Deletes all the objects GVCDATECO
		/// </summary>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteAll()
		{
			return Delete("");
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCDATECO
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCDATECO</returns>
		protected GVCDATECO[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCDATECO
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCDATECO</returns>
		protected GVCDATECO[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCDATECO
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCDATECO</returns>
		protected virtual GVCDATECO[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int cODICEColumnIndex = reader.GetOrdinal("CODICE");
			int dESCRIZIONEColumnIndex = reader.GetOrdinal("DESCRIZIONE");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCDATECO record = new GVCDATECO();
					recordList.Add(record);
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.CODICE = Convert.ToString(reader.GetValue(cODICEColumnIndex));
					if(!reader.IsDBNull(dESCRIZIONEColumnIndex))
						record.DESCRIZIONE = Convert.ToString(reader.GetValue(dESCRIZIONEColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCDATECO[])(recordList.ToArray(typeof(GVCDATECO)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCDATECO</returns>
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
		/// <returns>DataTable of objects GVCDATECO</returns>
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
		/// <returns>DataTable of objects GVCDATECO</returns>
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
		/// Converts a DataRow to an object GVCDATECO
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCDATECO</returns>
		protected virtual GVCDATECO MapRow(DataRow row)
		{
			GVCDATECO mappedObject = new GVCDATECO();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "CODICE"
			dataColumn = dataTable.Columns["CODICE"];
			if(!row.IsNull(dataColumn))
				mappedObject.CODICE = (System.String)row[dataColumn];
			//Campo "DESCRIZIONE"
			dataColumn = dataTable.Columns["DESCRIZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.DESCRIZIONE = (System.String)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCDATECO
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCDATECO";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("CODICE", typeof(System.String));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DESCRIZIONE", typeof(System.String));
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
				case "IDOBJ":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "CODICE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "DESCRIZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}