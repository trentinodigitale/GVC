//
//Generated by gvc at 26/03/2009 9.03.13
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCDTIPI_BILANCIO
	/// </summary>
	public partial class GVCDTIPI_BILANCIOCollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field DESCRIZIONE.
		///The field is mandatory.
		/// </summary>
		public const string DESCRIZIONEColumnName = "DESCRIZIONE";
		/// <summary>
		/// Returns the Database Name of the field FLAG_ATTIVO.
		/// </summary>
		public const string FLAG_ATTIVOColumnName = "FLAG_ATTIVO";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCDTIPI_BILANCIOCollection(GVC db)
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
		/// Returns an array containing all the objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <returns>Array of objects GVCDTIPI_BILANCIO</returns>
		public virtual GVCDTIPI_BILANCIO[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <returns>DataTable of objects GVCDTIPI_BILANCIO</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCDTIPI_BILANCIO selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCDTIPI_BILANCIO</returns>
		public GVCDTIPI_BILANCIO GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCDTIPI_BILANCIO[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCDTIPI_BILANCIO selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCDTIPI_BILANCIO</returns>
		public GVCDTIPI_BILANCIO[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCDTIPI_BILANCIO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCDTIPI_BILANCIO</returns>
		public virtual GVCDTIPI_BILANCIO[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCDTIPI_BILANCIO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCDTIPI_BILANCIO</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCDTIPI_BILANCIO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCDTIPI_BILANCIO</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCDTIPI_BILANCIO selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ, ");
			sql.Append("DESCRIZIONE, ");
			sql.Append("FLAG_ATTIVO ");
			sql.Append("FROM GVCDTIPI_BILANCIO ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Returns an object GVCDTIPI_BILANCIO selected by a primary key
		/// </summary>
		/// <param name="IDOBJ">The primary key of the object</param>
		/// <returns>Object of type GVCDTIPI_BILANCIO</returns>
		public virtual GVCDTIPI_BILANCIO GetByPrimaryKey(System.Int32 IDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateGetCommand(whereSql, null))
			{
				AddParameter(cmd, "IDOBJ", IDOBJ);
				GVCDTIPI_BILANCIO[] tempArray = MapRecords(cmd);
				return tempArray.Length == 0 ? null : tempArray[0];
			}
		}


		/// <summary>
		/// Inserts in the Database an object GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="valore">The object to insert</param>
		public virtual void Insert(GVCDTIPI_BILANCIO valore)
		{
			System.Int32 id = -1;
			System.String sqlStr;

			sqlStr = "SELECT GVCDTIPI_BILANCIO_SEQ.NEXTVAL FROM DUAL";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				id = Convert.ToInt32(cmd.ExecuteScalar());
			}

			sqlStr = "INSERT INTO GVCDTIPI_BILANCIO (" +
			"IDOBJ, " +
			"DESCRIZIONE, " +
			"FLAG_ATTIVO) " +
			"VALUES (" + id.ToString() + ", " +
			_db.CreateSqlParameterName("DESCRIZIONE") + ", " +
			_db.CreateSqlParameterName("FLAG_ATTIVO") + ")";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "DESCRIZIONE", valore.DESCRIZIONE);
				AddParameter(cmd, "FLAG_ATTIVO", valore.IsFLAG_ATTIVONull ? DBNull.Value : (object)valore.FLAG_ATTIVO);
				cmd.ExecuteScalar();
				valore.IDOBJ = id;
			}
		}

		/// <summary>
		/// Updates in the Database an object GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="valore">The object to update</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool Update(GVCDTIPI_BILANCIO valore)
		{
			System.String sqlStr = "UPDATE GVCDTIPI_BILANCIO SET " +
				"DESCRIZIONE = " + _db.CreateSqlParameterName("DESCRIZIONE") + ", " +
				"FLAG_ATTIVO = " + _db.CreateSqlParameterName("FLAG_ATTIVO") +
				" WHERE " +
				"IDOBJ = " + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ", valore.IDOBJ);
				AddParameter(cmd, "DESCRIZIONE", valore.DESCRIZIONE);
				AddParameter(cmd, "FLAG_ATTIVO", valore.IsFLAG_ATTIVONull ? DBNull.Value : (object)valore.FLAG_ATTIVO);
				return cmd.ExecuteNonQuery() != 0;
			}
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="table">The DataTable of objects GVCDTIPI_BILANCIO</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="table">The DataTable of objects GVCDTIPI_BILANCIO</param>
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
		/// Deletes from the Database an object GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="valore">The object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public bool Delete(GVCDTIPI_BILANCIO valore)
		{
			return DeleteByPrimaryKey(valore.IDOBJ);
		}

		/// <summary>
		/// Deletes from the Database an object GVCDTIPI_BILANCIO
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
		/// Deletes from the Database the objects GVCDTIPI_BILANCIO selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>The number of the deleted objects</returns>
		public int Delete(System.String whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Returns an IDbCommand to delete the objects GVCDTIPI_BILANCIO selected by 
		/// a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			StringBuilder sql = new StringBuilder("DELETE FROM GVCDTIPI_BILANCIO");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format(" WHERE {0}", whereSql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Deletes all the objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteAll()
		{
			return Delete("");
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCDTIPI_BILANCIO</returns>
		protected GVCDTIPI_BILANCIO[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCDTIPI_BILANCIO</returns>
		protected GVCDTIPI_BILANCIO[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCDTIPI_BILANCIO</returns>
		protected virtual GVCDTIPI_BILANCIO[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int dESCRIZIONEColumnIndex = reader.GetOrdinal("DESCRIZIONE");
			int fLAG_ATTIVOColumnIndex = reader.GetOrdinal("FLAG_ATTIVO");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCDTIPI_BILANCIO record = new GVCDTIPI_BILANCIO();
					recordList.Add(record);
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.DESCRIZIONE = Convert.ToString(reader.GetValue(dESCRIZIONEColumnIndex));
					if(!reader.IsDBNull(fLAG_ATTIVOColumnIndex))
						record.FLAG_ATTIVO = Convert.ToInt32(reader.GetValue(fLAG_ATTIVOColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCDTIPI_BILANCIO[])(recordList.ToArray(typeof(GVCDTIPI_BILANCIO)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCDTIPI_BILANCIO</returns>
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
		/// <returns>DataTable of objects GVCDTIPI_BILANCIO</returns>
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
		/// <returns>DataTable of objects GVCDTIPI_BILANCIO</returns>
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
		/// Converts a DataRow to an object GVCDTIPI_BILANCIO
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCDTIPI_BILANCIO</returns>
		protected virtual GVCDTIPI_BILANCIO MapRow(DataRow row)
		{
			GVCDTIPI_BILANCIO mappedObject = new GVCDTIPI_BILANCIO();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "DESCRIZIONE"
			dataColumn = dataTable.Columns["DESCRIZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.DESCRIZIONE = (System.String)row[dataColumn];
			//Campo "FLAG_ATTIVO"
			dataColumn = dataTable.Columns["FLAG_ATTIVO"];
			if(!row.IsNull(dataColumn))
				mappedObject.FLAG_ATTIVO = (System.Int32)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCDTIPI_BILANCIO
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCDTIPI_BILANCIO";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("DESCRIZIONE", typeof(System.String));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("FLAG_ATTIVO", typeof(System.Int32));
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

				case "DESCRIZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "FLAG_ATTIVO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}
