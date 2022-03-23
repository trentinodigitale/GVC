//
//Generated by gvc at 26/03/2009 9.03.13
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCTCREDITI_FISCALI
	/// </summary>
	public partial class GVCTCREDITI_FISCALICollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_LIQUIDAZIONE.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_LIQUIDAZIONEColumnName = "IDOBJ_LIQUIDAZIONE";
		/// <summary>
		/// Returns the Database Name of the field NUMERO_DELIBERA.
		/// </summary>
		public const string NUMERO_DELIBERAColumnName = "NUMERO_DELIBERA";
		/// <summary>
		/// Returns the Database Name of the field DATA_DELIBERA.
		/// </summary>
		public const string DATA_DELIBERAColumnName = "DATA_DELIBERA";
		/// <summary>
		/// Returns the Database Name of the field VALUTA.
		/// </summary>
		public const string VALUTAColumnName = "VALUTA";
		/// <summary>
		/// Returns the Database Name of the field IMPORTO.
		/// </summary>
		public const string IMPORTOColumnName = "IMPORTO";
		/// <summary>
		/// Returns the Database Name of the field NOTE.
		/// </summary>
		public const string NOTEColumnName = "NOTE";
		/// <summary>
		/// Returns the Database Name of the field OPERATOREULTMOD.
		/// </summary>
		public const string OPERATOREULTMODColumnName = "OPERATOREULTMOD";
		/// <summary>
		/// Returns the Database Name of the field DATAORAULTMOD.
		/// </summary>
		public const string DATAORAULTMODColumnName = "DATAORAULTMOD";

		/// <summary>
		/// Gateway to the Database
		/// </summary>
		protected GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public GVCTCREDITI_FISCALICollection(GVC db)
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
		/// Returns an array containing all the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <returns>Array of objects GVCTCREDITI_FISCALI</returns>
		public virtual GVCTCREDITI_FISCALI[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <returns>DataTable of objects GVCTCREDITI_FISCALI</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCTCREDITI_FISCALI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCTCREDITI_FISCALI</returns>
		public GVCTCREDITI_FISCALI GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCTCREDITI_FISCALI[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCTCREDITI_FISCALI selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCTCREDITI_FISCALI</returns>
		public GVCTCREDITI_FISCALI[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCTCREDITI_FISCALI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCTCREDITI_FISCALI</returns>
		public virtual GVCTCREDITI_FISCALI[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCTCREDITI_FISCALI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCTCREDITI_FISCALI</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCTCREDITI_FISCALI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCTCREDITI_FISCALI</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCTCREDITI_FISCALI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ, ");
			sql.Append("IDOBJ_LIQUIDAZIONE, ");
			sql.Append("NUMERO_DELIBERA, ");
			sql.Append("DATA_DELIBERA, ");
			sql.Append("VALUTA, ");
			sql.Append("IMPORTO, ");
			sql.Append("NOTE, ");
			sql.Append("OPERATOREULTMOD, ");
			sql.Append("DATAORAULTMOD ");
			sql.Append("FROM GVCTCREDITI_FISCALI ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Returns an object GVCTCREDITI_FISCALI selected by a primary key
		/// </summary>
		/// <param name="IDOBJ">The primary key of the object</param>
		/// <returns>Object of type GVCTCREDITI_FISCALI</returns>
		public virtual GVCTCREDITI_FISCALI GetByPrimaryKey(System.Int32 IDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateGetCommand(whereSql, null))
			{
				AddParameter(cmd, "IDOBJ", IDOBJ);
				GVCTCREDITI_FISCALI[] tempArray = MapRecords(cmd);
				return tempArray.Length == 0 ? null : tempArray[0];
			}
		}


		/// <summary>
		/// Returns an object GVCTCREDITI_FISCALI selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_LIQUIDAZIONE">The foreign key of the object</param>
		/// <returns>Object of type GVCTCREDITI_FISCALI</returns>
		public virtual GVCTCREDITI_FISCALI[] GetByIDOBJ_LIQUIDAZIONE(System.Int32 iDOBJ_LIQUIDAZIONE)
		{
			return MapRecords(CreateGetByIDOBJ_LIQUIDAZIONECommand(iDOBJ_LIQUIDAZIONE));
		}

		/// <summary>
		/// Returns a DataTable of objects GVCTCREDITI_FISCALI selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_LIQUIDAZIONE">The foreign key of the object</param>
		/// <returns>A DataTable</returns>
		public virtual DataTable GetByIDOBJ_LIQUIDAZIONEAsDataTable(System.Int32 iDOBJ_LIQUIDAZIONE)
		{
			return MapRecordsToDataTable(CreateGetByIDOBJ_LIQUIDAZIONECommand(iDOBJ_LIQUIDAZIONE));
		}

		/// <summary>
		/// Returns an IdbCommand with the selected foreign key
		/// </summary>
		/// <param name="iDOBJ_LIQUIDAZIONE">The foreign key</param>
		/// <returns>An IDbCommand</returns>
		protected virtual IDbCommand CreateGetByIDOBJ_LIQUIDAZIONECommand(System.Int32 iDOBJ_LIQUIDAZIONE)
		{
			string whereSql = "IDOBJ_LIQUIDAZIONE = " + _db.CreateSqlParameterName("IDOBJ_LIQUIDAZIONE");
			IDbCommand cmd = CreateGetCommand(whereSql, null);
			AddParameter(cmd, "IDOBJ_LIQUIDAZIONE", iDOBJ_LIQUIDAZIONE);
			return cmd;
		}

		/// <summary>
		/// Deletes from the Database the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="iDOBJ_LIQUIDAZIONE">The foreign key</param>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteByIDOBJ_LIQUIDAZIONE(System.Int32 iDOBJ_LIQUIDAZIONE)
		{
			return CreateDeleteByIDOBJ_LIQUIDAZIONECommand(iDOBJ_LIQUIDAZIONE).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates the IDbCommand for the deletion from the Database of the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="iDOBJ_LIQUIDAZIONE">The foreign key</param>
		/// <returns>The IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteByIDOBJ_LIQUIDAZIONECommand(System.Int32 iDOBJ_LIQUIDAZIONE)
		{
			string whereSql = "IDOBJ_LIQUIDAZIONE = " + _db.CreateSqlParameterName("IDOBJ_LIQUIDAZIONE");
			IDbCommand cmd = CreateDeleteCommand(whereSql);
			AddParameter(cmd, "IDOBJ_LIQUIDAZIONE", iDOBJ_LIQUIDAZIONE);
			return cmd;
		}

		/// <summary>
		/// Inserts in the Database an object GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="valore">The object to insert</param>
		public virtual void Insert(GVCTCREDITI_FISCALI valore)
		{
			System.Int32 id = -1;
			System.String sqlStr;

			sqlStr = "SELECT GVCTCREDITI_FISCALI_SEQ.NEXTVAL FROM DUAL";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				id = Convert.ToInt32(cmd.ExecuteScalar());
			}

			sqlStr = "INSERT INTO GVCTCREDITI_FISCALI (" +
			"IDOBJ, " +
			"IDOBJ_LIQUIDAZIONE, " +
			"NUMERO_DELIBERA, " +
			"DATA_DELIBERA, " +
			"VALUTA, " +
			"IMPORTO, " +
			"NOTE, " +
			"OPERATOREULTMOD, " +
			"DATAORAULTMOD) " +
			"VALUES (" + id.ToString() + ", " +
			_db.CreateSqlParameterName("IDOBJ_LIQUIDAZIONE") + ", " +
			_db.CreateSqlParameterName("NUMERO_DELIBERA") + ", " +
			_db.CreateSqlParameterName("DATA_DELIBERA") + ", " +
			_db.CreateSqlParameterName("VALUTA") + ", " +
			_db.CreateSqlParameterName("IMPORTO") + ", " +
			_db.CreateSqlParameterName("NOTE") + ", " +
			_db.CreateSqlParameterName("OPERATOREULTMOD") + ", " +
			_db.CreateSqlParameterName("DATAORAULTMOD") + ")";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ_LIQUIDAZIONE", valore.IDOBJ_LIQUIDAZIONE);
				AddParameter(cmd, "NUMERO_DELIBERA", valore.IsNUMERO_DELIBERANull ? DBNull.Value : (object)valore.NUMERO_DELIBERA);
				AddParameter(cmd, "DATA_DELIBERA", valore.IsDATA_DELIBERANull ? DBNull.Value : (object)valore.DATA_DELIBERA);
				AddParameter(cmd, "VALUTA", valore.IsVALUTANull ? DBNull.Value : (object)valore.VALUTA);
				AddParameter(cmd, "IMPORTO", valore.IsIMPORTONull ? DBNull.Value : (object)valore.IMPORTO);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				AddParameter(cmd, "OPERATOREULTMOD", valore.IsOPERATOREULTMODNull ? DBNull.Value : (object)valore.OPERATOREULTMOD);
				AddParameter(cmd, "DATAORAULTMOD", valore.IsDATAORAULTMODNull ? DBNull.Value : (object)valore.DATAORAULTMOD);
				cmd.ExecuteScalar();
				valore.IDOBJ = id;
			}
		}

		/// <summary>
		/// Updates in the Database an object GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="valore">The object to update</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool Update(GVCTCREDITI_FISCALI valore)
		{
			System.String sqlStr = "UPDATE GVCTCREDITI_FISCALI SET " +
				"IDOBJ_LIQUIDAZIONE = " + _db.CreateSqlParameterName("IDOBJ_LIQUIDAZIONE") + ", " +
				"NUMERO_DELIBERA = " + _db.CreateSqlParameterName("NUMERO_DELIBERA") + ", " +
				"DATA_DELIBERA = " + _db.CreateSqlParameterName("DATA_DELIBERA") + ", " +
				"VALUTA = " + _db.CreateSqlParameterName("VALUTA") + ", " +
				"IMPORTO = " + _db.CreateSqlParameterName("IMPORTO") + ", " +
				"NOTE = " + _db.CreateSqlParameterName("NOTE") + ", " +
				"OPERATOREULTMOD = " + _db.CreateSqlParameterName("OPERATOREULTMOD") + ", " +
				"DATAORAULTMOD = " + _db.CreateSqlParameterName("DATAORAULTMOD") +
				" WHERE " +
				"IDOBJ = " + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ", valore.IDOBJ);
				AddParameter(cmd, "IDOBJ_LIQUIDAZIONE", valore.IDOBJ_LIQUIDAZIONE);
				AddParameter(cmd, "NUMERO_DELIBERA", valore.IsNUMERO_DELIBERANull ? DBNull.Value : (object)valore.NUMERO_DELIBERA);
				AddParameter(cmd, "DATA_DELIBERA", valore.IsDATA_DELIBERANull ? DBNull.Value : (object)valore.DATA_DELIBERA);
				AddParameter(cmd, "VALUTA", valore.IsVALUTANull ? DBNull.Value : (object)valore.VALUTA);
				AddParameter(cmd, "IMPORTO", valore.IsIMPORTONull ? DBNull.Value : (object)valore.IMPORTO);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				AddParameter(cmd, "OPERATOREULTMOD", valore.IsOPERATOREULTMODNull ? DBNull.Value : (object)valore.OPERATOREULTMOD);
				AddParameter(cmd, "DATAORAULTMOD", valore.IsDATAORAULTMODNull ? DBNull.Value : (object)valore.DATAORAULTMOD);
				return cmd.ExecuteNonQuery() != 0;
			}
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="table">The DataTable of objects GVCTCREDITI_FISCALI</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="table">The DataTable of objects GVCTCREDITI_FISCALI</param>
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
		/// Deletes from the Database an object GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="valore">The object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public bool Delete(GVCTCREDITI_FISCALI valore)
		{
			return DeleteByPrimaryKey(valore.IDOBJ);
		}

		/// <summary>
		/// Deletes from the Database an object GVCTCREDITI_FISCALI
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
		/// Deletes from the Database the objects GVCTCREDITI_FISCALI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>The number of the deleted objects</returns>
		public int Delete(System.String whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Returns an IDbCommand to delete the objects GVCTCREDITI_FISCALI selected by 
		/// a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			StringBuilder sql = new StringBuilder("DELETE FROM GVCTCREDITI_FISCALI");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format(" WHERE {0}", whereSql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Deletes all the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteAll()
		{
			return Delete("");
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCTCREDITI_FISCALI</returns>
		protected GVCTCREDITI_FISCALI[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCTCREDITI_FISCALI</returns>
		protected GVCTCREDITI_FISCALI[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCTCREDITI_FISCALI</returns>
		protected virtual GVCTCREDITI_FISCALI[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int iDOBJ_LIQUIDAZIONEColumnIndex = reader.GetOrdinal("IDOBJ_LIQUIDAZIONE");
			int nUMERO_DELIBERAColumnIndex = reader.GetOrdinal("NUMERO_DELIBERA");
			int dATA_DELIBERAColumnIndex = reader.GetOrdinal("DATA_DELIBERA");
			int vALUTAColumnIndex = reader.GetOrdinal("VALUTA");
			int iMPORTOColumnIndex = reader.GetOrdinal("IMPORTO");
			int nOTEColumnIndex = reader.GetOrdinal("NOTE");
			int oPERATOREULTMODColumnIndex = reader.GetOrdinal("OPERATOREULTMOD");
			int dATAORAULTMODColumnIndex = reader.GetOrdinal("DATAORAULTMOD");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					GVCTCREDITI_FISCALI record = new GVCTCREDITI_FISCALI();
					recordList.Add(record);
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.IDOBJ_LIQUIDAZIONE = Convert.ToInt32(reader.GetValue(iDOBJ_LIQUIDAZIONEColumnIndex));
					if(!reader.IsDBNull(nUMERO_DELIBERAColumnIndex))
						record.NUMERO_DELIBERA = Convert.ToString(reader.GetValue(nUMERO_DELIBERAColumnIndex));
					if(!reader.IsDBNull(dATA_DELIBERAColumnIndex))
						record.DATA_DELIBERA = Convert.ToDateTime(reader.GetValue(dATA_DELIBERAColumnIndex));
					if(!reader.IsDBNull(vALUTAColumnIndex))
						record.VALUTA = Convert.ToInt32(reader.GetValue(vALUTAColumnIndex));
					if(!reader.IsDBNull(iMPORTOColumnIndex))
						record.IMPORTO = Convert.ToDouble(reader.GetValue(iMPORTOColumnIndex));
					if(!reader.IsDBNull(nOTEColumnIndex))
						record.NOTE = Convert.ToString(reader.GetValue(nOTEColumnIndex));
					if(!reader.IsDBNull(oPERATOREULTMODColumnIndex))
						record.OPERATOREULTMOD = Convert.ToString(reader.GetValue(oPERATOREULTMODColumnIndex));
					if(!reader.IsDBNull(dATAORAULTMODColumnIndex))
						record.DATAORAULTMOD = Convert.ToDateTime(reader.GetValue(dATAORAULTMODColumnIndex));
					if(ri == length && totalRecordCount != 0)
						break;
				}
			}
			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (GVCTCREDITI_FISCALI[])(recordList.ToArray(typeof(GVCTCREDITI_FISCALI)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCTCREDITI_FISCALI</returns>
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
		/// <returns>DataTable of objects GVCTCREDITI_FISCALI</returns>
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
		/// <returns>DataTable of objects GVCTCREDITI_FISCALI</returns>
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
		/// Converts a DataRow to an object GVCTCREDITI_FISCALI
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCTCREDITI_FISCALI</returns>
		protected virtual GVCTCREDITI_FISCALI MapRow(DataRow row)
		{
			GVCTCREDITI_FISCALI mappedObject = new GVCTCREDITI_FISCALI();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_LIQUIDAZIONE"
			dataColumn = dataTable.Columns["IDOBJ_LIQUIDAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_LIQUIDAZIONE = (System.Int32)row[dataColumn];
			//Campo "NUMERO_DELIBERA"
			dataColumn = dataTable.Columns["NUMERO_DELIBERA"];
			if(!row.IsNull(dataColumn))
				mappedObject.NUMERO_DELIBERA = (System.String)row[dataColumn];
			//Campo "DATA_DELIBERA"
			dataColumn = dataTable.Columns["DATA_DELIBERA"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATA_DELIBERA = (System.DateTime)row[dataColumn];
			//Campo "VALUTA"
			dataColumn = dataTable.Columns["VALUTA"];
			if(!row.IsNull(dataColumn))
				mappedObject.VALUTA = (System.Int32)row[dataColumn];
			//Campo "IMPORTO"
			dataColumn = dataTable.Columns["IMPORTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IMPORTO = (System.Double)row[dataColumn];
			//Campo "NOTE"
			dataColumn = dataTable.Columns["NOTE"];
			if(!row.IsNull(dataColumn))
				mappedObject.NOTE = (System.String)row[dataColumn];
			//Campo "OPERATOREULTMOD"
			dataColumn = dataTable.Columns["OPERATOREULTMOD"];
			if(!row.IsNull(dataColumn))
				mappedObject.OPERATOREULTMOD = (System.String)row[dataColumn];
			//Campo "DATAORAULTMOD"
			dataColumn = dataTable.Columns["DATAORAULTMOD"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATAORAULTMOD = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a DataTable to store the objects GVCTCREDITI_FISCALI
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCTCREDITI_FISCALI";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("IDOBJ_LIQUIDAZIONE", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("NUMERO_DELIBERA", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATA_DELIBERA", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("VALUTA", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IMPORTO", typeof(System.Double));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("NOTE", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("OPERATOREULTMOD", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATAORAULTMOD", typeof(System.DateTime));
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

				case "IDOBJ_LIQUIDAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "NUMERO_DELIBERA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "DATA_DELIBERA":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "VALUTA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IMPORTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Double, valore);
					break;

				case "NOTE":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "OPERATOREULTMOD":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "DATAORAULTMOD":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				default:
					throw new ArgumentException("Nome parametro sconosciuto (" + paramName + ").");
			}
			return parameter;
		}
	}
}