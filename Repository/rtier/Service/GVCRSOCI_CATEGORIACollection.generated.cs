//
//Generated by gvc at 26/03/2009 9.03.13
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCRSOCI_CATEGORIA
	/// </summary>
	public partial class GVCRSOCI_CATEGORIACollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_CATEGORIA.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_CATEGORIAColumnName = "IDOBJ_CATEGORIA";
		/// <summary>
		/// Returns the Database Name of the field VALMAX.
		/// </summary>
		public const string VALMAXColumnName = "VALMAX";
		/// <summary>
		/// Returns the Database Name of the field VALMIN.
		/// </summary>
		public const string VALMINColumnName = "VALMIN";
		/// <summary>
		/// Returns the Database Name of the field NOTE.
		/// </summary>
		public const string NOTEColumnName = "NOTE";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCRSOCI_CATEGORIACollection(GVC db)
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
		/// Returns an array containing all the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <returns>Array of objects GVCRSOCI_CATEGORIA</returns>
		public virtual GVCRSOCI_CATEGORIA[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <returns>DataTable of objects GVCRSOCI_CATEGORIA</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCRSOCI_CATEGORIA selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCRSOCI_CATEGORIA</returns>
		public GVCRSOCI_CATEGORIA GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCRSOCI_CATEGORIA[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCRSOCI_CATEGORIA selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCRSOCI_CATEGORIA</returns>
		public GVCRSOCI_CATEGORIA[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCRSOCI_CATEGORIA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCRSOCI_CATEGORIA</returns>
		public virtual GVCRSOCI_CATEGORIA[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCRSOCI_CATEGORIA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCRSOCI_CATEGORIA</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCRSOCI_CATEGORIA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCRSOCI_CATEGORIA</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCRSOCI_CATEGORIA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ, ");
			sql.Append("IDOBJ_CATEGORIA, ");
			sql.Append("VALMAX, ");
			sql.Append("VALMIN, ");
			sql.Append("NOTE ");
			sql.Append("FROM GVCRSOCI_CATEGORIA ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Returns an object GVCRSOCI_CATEGORIA selected by a primary key
		/// </summary>
		/// <param name="IDOBJ">The primary key of the object</param>
		/// <returns>Object of type GVCRSOCI_CATEGORIA</returns>
		public virtual GVCRSOCI_CATEGORIA GetByPrimaryKey(System.Int32 IDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateGetCommand(whereSql, null))
			{
				AddParameter(cmd, "IDOBJ", IDOBJ);
				GVCRSOCI_CATEGORIA[] tempArray = MapRecords(cmd);
				return tempArray.Length == 0 ? null : tempArray[0];
			}
		}


		/// <summary>
		/// Returns an object GVCRSOCI_CATEGORIA selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_CATEGORIA">The foreign key of the object</param>
		/// <returns>Object of type GVCRSOCI_CATEGORIA</returns>
		public virtual GVCRSOCI_CATEGORIA[] GetByIDOBJ_CATEGORIA(System.Int32 iDOBJ_CATEGORIA)
		{
			return MapRecords(CreateGetByIDOBJ_CATEGORIACommand(iDOBJ_CATEGORIA));
		}

		/// <summary>
		/// Returns a DataTable of objects GVCRSOCI_CATEGORIA selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_CATEGORIA">The foreign key of the object</param>
		/// <returns>A DataTable</returns>
		public virtual DataTable GetByIDOBJ_CATEGORIAAsDataTable(System.Int32 iDOBJ_CATEGORIA)
		{
			return MapRecordsToDataTable(CreateGetByIDOBJ_CATEGORIACommand(iDOBJ_CATEGORIA));
		}

		/// <summary>
		/// Returns an IdbCommand with the selected foreign key
		/// </summary>
		/// <param name="iDOBJ_CATEGORIA">The foreign key</param>
		/// <returns>An IDbCommand</returns>
		protected virtual IDbCommand CreateGetByIDOBJ_CATEGORIACommand(System.Int32 iDOBJ_CATEGORIA)
		{
			string whereSql = "IDOBJ_CATEGORIA = " + _db.CreateSqlParameterName("IDOBJ_CATEGORIA");
			IDbCommand cmd = CreateGetCommand(whereSql, null);
			AddParameter(cmd, "IDOBJ_CATEGORIA", iDOBJ_CATEGORIA);
			return cmd;
		}

		/// <summary>
		/// Deletes from the Database the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="iDOBJ_CATEGORIA">The foreign key</param>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteByIDOBJ_CATEGORIA(System.Int32 iDOBJ_CATEGORIA)
		{
			return CreateDeleteByIDOBJ_CATEGORIACommand(iDOBJ_CATEGORIA).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates the IDbCommand for the deletion from the Database of the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="iDOBJ_CATEGORIA">The foreign key</param>
		/// <returns>The IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteByIDOBJ_CATEGORIACommand(System.Int32 iDOBJ_CATEGORIA)
		{
			string whereSql = "IDOBJ_CATEGORIA = " + _db.CreateSqlParameterName("IDOBJ_CATEGORIA");
			IDbCommand cmd = CreateDeleteCommand(whereSql);
			AddParameter(cmd, "IDOBJ_CATEGORIA", iDOBJ_CATEGORIA);
			return cmd;
		}

		/// <summary>
		/// Inserts in the Database an object GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="valore">The object to insert</param>
		public virtual void Insert(GVCRSOCI_CATEGORIA valore)
		{
			System.Int32 id = -1;
			System.String sqlStr;

			sqlStr = "SELECT GVCRSOCI_CATEGORIA_SEQ.NEXTVAL FROM DUAL";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				id = Convert.ToInt32(cmd.ExecuteScalar());
			}

			sqlStr = "INSERT INTO GVCRSOCI_CATEGORIA (" +
			"IDOBJ, " +
			"IDOBJ_CATEGORIA, " +
			"VALMAX, " +
			"VALMIN, " +
			"NOTE) " +
			"VALUES (" + id.ToString() + ", " +
			_db.CreateSqlParameterName("IDOBJ_CATEGORIA") + ", " +
			_db.CreateSqlParameterName("VALMAX") + ", " +
			_db.CreateSqlParameterName("VALMIN") + ", " +
			_db.CreateSqlParameterName("NOTE") + ")";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ_CATEGORIA", valore.IDOBJ_CATEGORIA);
				AddParameter(cmd, "VALMAX", valore.IsVALMAXNull ? DBNull.Value : (object)valore.VALMAX);
				AddParameter(cmd, "VALMIN", valore.IsVALMINNull ? DBNull.Value : (object)valore.VALMIN);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				cmd.ExecuteScalar();
				valore.IDOBJ = id;
			}
		}

		/// <summary>
		/// Updates in the Database an object GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="valore">The object to update</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool Update(GVCRSOCI_CATEGORIA valore)
		{
			System.String sqlStr = "UPDATE GVCRSOCI_CATEGORIA SET " +
				"IDOBJ_CATEGORIA = " + _db.CreateSqlParameterName("IDOBJ_CATEGORIA") + ", " +
				"VALMAX = " + _db.CreateSqlParameterName("VALMAX") + ", " +
				"VALMIN = " + _db.CreateSqlParameterName("VALMIN") + ", " +
				"NOTE = " + _db.CreateSqlParameterName("NOTE") +
				" WHERE " +
				"IDOBJ = " + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ", valore.IDOBJ);
				AddParameter(cmd, "IDOBJ_CATEGORIA", valore.IDOBJ_CATEGORIA);
				AddParameter(cmd, "VALMAX", valore.IsVALMAXNull ? DBNull.Value : (object)valore.VALMAX);
				AddParameter(cmd, "VALMIN", valore.IsVALMINNull ? DBNull.Value : (object)valore.VALMIN);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				return cmd.ExecuteNonQuery() != 0;
			}
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="table">The DataTable of objects GVCRSOCI_CATEGORIA</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="table">The DataTable of objects GVCRSOCI_CATEGORIA</param>
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
		/// Deletes from the Database an object GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="valore">The object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public bool Delete(GVCRSOCI_CATEGORIA valore)
		{
			return DeleteByPrimaryKey(valore.IDOBJ);
		}

		/// <summary>
		/// Deletes from the Database an object GVCRSOCI_CATEGORIA
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
		/// Deletes from the Database the objects GVCRSOCI_CATEGORIA selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>The number of the deleted objects</returns>
		public int Delete(System.String whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Returns an IDbCommand to delete the objects GVCRSOCI_CATEGORIA selected by 
		/// a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			StringBuilder sql = new StringBuilder("DELETE FROM GVCRSOCI_CATEGORIA");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format(" WHERE {0}", whereSql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Deletes all the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteAll()
		{
			return Delete("");
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCRSOCI_CATEGORIA</returns>
		protected GVCRSOCI_CATEGORIA[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCRSOCI_CATEGORIA</returns>
		protected GVCRSOCI_CATEGORIA[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCRSOCI_CATEGORIA</returns>
		protected virtual GVCRSOCI_CATEGORIA[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int iDOBJ_CATEGORIAColumnIndex = reader.GetOrdinal("IDOBJ_CATEGORIA");
			int vALMAXColumnIndex = reader.GetOrdinal("VALMAX");
			int vALMINColumnIndex = reader.GetOrdinal("VALMIN");
			int nOTEColumnIndex = reader.GetOrdinal("NOTE");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCRSOCI_CATEGORIA record = new GVCRSOCI_CATEGORIA();
					recordList.Add(record);
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.IDOBJ_CATEGORIA = Convert.ToInt32(reader.GetValue(iDOBJ_CATEGORIAColumnIndex));
					if(!reader.IsDBNull(vALMAXColumnIndex))
						record.VALMAX = Convert.ToInt32(reader.GetValue(vALMAXColumnIndex));
					if(!reader.IsDBNull(vALMINColumnIndex))
						record.VALMIN = Convert.ToInt32(reader.GetValue(vALMINColumnIndex));
					if(!reader.IsDBNull(nOTEColumnIndex))
						record.NOTE = Convert.ToString(reader.GetValue(nOTEColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCRSOCI_CATEGORIA[])(recordList.ToArray(typeof(GVCRSOCI_CATEGORIA)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCRSOCI_CATEGORIA</returns>
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
		/// <returns>DataTable of objects GVCRSOCI_CATEGORIA</returns>
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
		/// <returns>DataTable of objects GVCRSOCI_CATEGORIA</returns>
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
		/// Converts a DataRow to an object GVCRSOCI_CATEGORIA
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCRSOCI_CATEGORIA</returns>
		protected virtual GVCRSOCI_CATEGORIA MapRow(DataRow row)
		{
			GVCRSOCI_CATEGORIA mappedObject = new GVCRSOCI_CATEGORIA();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_CATEGORIA"
			dataColumn = dataTable.Columns["IDOBJ_CATEGORIA"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_CATEGORIA = (System.Int32)row[dataColumn];
			//Campo "VALMAX"
			dataColumn = dataTable.Columns["VALMAX"];
			if(!row.IsNull(dataColumn))
				mappedObject.VALMAX = (System.Int32)row[dataColumn];
			//Campo "VALMIN"
			dataColumn = dataTable.Columns["VALMIN"];
			if(!row.IsNull(dataColumn))
				mappedObject.VALMIN = (System.Int32)row[dataColumn];
			//Campo "NOTE"
			dataColumn = dataTable.Columns["NOTE"];
			if(!row.IsNull(dataColumn))
				mappedObject.NOTE = (System.String)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCRSOCI_CATEGORIA
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCRSOCI_CATEGORIA";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("IDOBJ_CATEGORIA", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("VALMAX", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("VALMIN", typeof(System.Int32));
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

				case "IDOBJ_CATEGORIA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "VALMAX":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "VALMIN":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "NOTE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}