//
//Generated by gvc at 26/03/2009 9.03.13
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCTATTIVITA
	/// </summary>
	public partial class GVCTATTIVITACollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field ATTIVITA_CCIAA.
		///The field is mandatory.
		/// </summary>
		public const string ATTIVITA_CCIAAColumnName = "ATTIVITA_CCIAA";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_REGISTRO.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_REGISTROColumnName = "IDOBJ_REGISTRO";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_CODICE_ATECO.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_CODICE_ATECOColumnName = "IDOBJ_CODICE_ATECO";
		/// <summary>
		/// Returns the Database Name of the field IMPORTANZA.
		/// </summary>
		public const string IMPORTANZAColumnName = "IMPORTANZA";
		/// <summary>
		/// Returns the Database Name of the field DATA_INIZIO.
		/// </summary>
		public const string DATA_INIZIOColumnName = "DATA_INIZIO";
		/// <summary>
		/// Returns the Database Name of the field STATO_ATTIVITA.
		/// </summary>
		public const string STATO_ATTIVITAColumnName = "STATO_ATTIVITA";
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
		public GVCTATTIVITACollection(GVC db)
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
		/// Returns an array containing all the objects GVCTATTIVITA
		/// </summary>
		/// <returns>Array of objects GVCTATTIVITA</returns>
		public virtual GVCTATTIVITA[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCTATTIVITA
		/// </summary>
		/// <returns>DataTable of objects GVCTATTIVITA</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCTATTIVITA
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCTATTIVITA selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCTATTIVITA</returns>
		public GVCTATTIVITA GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCTATTIVITA[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCTATTIVITA selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCTATTIVITA</returns>
		public GVCTATTIVITA[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCTATTIVITA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCTATTIVITA</returns>
		public virtual GVCTATTIVITA[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCTATTIVITA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCTATTIVITA</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCTATTIVITA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCTATTIVITA</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCTATTIVITA selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ, ");
			sql.Append("ATTIVITA_CCIAA, ");
			sql.Append("IDOBJ_REGISTRO, ");
			sql.Append("IDOBJ_CODICE_ATECO, ");
			sql.Append("IMPORTANZA, ");
			sql.Append("DATA_INIZIO, ");
			sql.Append("STATO_ATTIVITA, ");
			sql.Append("NOTE, ");
			sql.Append("OPERATOREULTMOD, ");
			sql.Append("DATAORAULTMOD ");
			sql.Append("FROM GVCTATTIVITA ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Returns an object GVCTATTIVITA selected by a primary key
		/// </summary>
		/// <param name="IDOBJ">The primary key of the object</param>
		/// <returns>Object of type GVCTATTIVITA</returns>
		public virtual GVCTATTIVITA GetByPrimaryKey(System.Int32 IDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateGetCommand(whereSql, null))
			{
				AddParameter(cmd, "IDOBJ", IDOBJ);
				GVCTATTIVITA[] tempArray = MapRecords(cmd);
				return tempArray.Length == 0 ? null : tempArray[0];
			}
		}


		/// <summary>
		/// Returns an object GVCTATTIVITA selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_CODICE_ATECO">The foreign key of the object</param>
		/// <returns>Object of type GVCTATTIVITA</returns>
		public virtual GVCTATTIVITA[] GetByIDOBJ_CODICE_ATECO(System.Int32 iDOBJ_CODICE_ATECO)
		{
			return MapRecords(CreateGetByIDOBJ_CODICE_ATECOCommand(iDOBJ_CODICE_ATECO));
		}

		/// <summary>
		/// Returns a DataTable of objects GVCTATTIVITA selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_CODICE_ATECO">The foreign key of the object</param>
		/// <returns>A DataTable</returns>
		public virtual DataTable GetByIDOBJ_CODICE_ATECOAsDataTable(System.Int32 iDOBJ_CODICE_ATECO)
		{
			return MapRecordsToDataTable(CreateGetByIDOBJ_CODICE_ATECOCommand(iDOBJ_CODICE_ATECO));
		}

		/// <summary>
		/// Returns an IdbCommand with the selected foreign key
		/// </summary>
		/// <param name="iDOBJ_CODICE_ATECO">The foreign key</param>
		/// <returns>An IDbCommand</returns>
		protected virtual IDbCommand CreateGetByIDOBJ_CODICE_ATECOCommand(System.Int32 iDOBJ_CODICE_ATECO)
		{
			string whereSql = "IDOBJ_CODICE_ATECO = " + _db.CreateSqlParameterName("IDOBJ_CODICE_ATECO");
			IDbCommand cmd = CreateGetCommand(whereSql, null);
			AddParameter(cmd, "IDOBJ_CODICE_ATECO", iDOBJ_CODICE_ATECO);
			return cmd;
		}

		/// <summary>
		/// Deletes from the Database the objects GVCTATTIVITA
		/// </summary>
		/// <param name="iDOBJ_CODICE_ATECO">The foreign key</param>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteByIDOBJ_CODICE_ATECO(System.Int32 iDOBJ_CODICE_ATECO)
		{
			return CreateDeleteByIDOBJ_CODICE_ATECOCommand(iDOBJ_CODICE_ATECO).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates the IDbCommand for the deletion from the Database of the objects GVCTATTIVITA
		/// </summary>
		/// <param name="iDOBJ_CODICE_ATECO">The foreign key</param>
		/// <returns>The IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteByIDOBJ_CODICE_ATECOCommand(System.Int32 iDOBJ_CODICE_ATECO)
		{
			string whereSql = "IDOBJ_CODICE_ATECO = " + _db.CreateSqlParameterName("IDOBJ_CODICE_ATECO");
			IDbCommand cmd = CreateDeleteCommand(whereSql);
			AddParameter(cmd, "IDOBJ_CODICE_ATECO", iDOBJ_CODICE_ATECO);
			return cmd;
		}

		/// <summary>
		/// Returns an object GVCTATTIVITA selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key of the object</param>
		/// <returns>Object of type GVCTATTIVITA</returns>
		public virtual GVCTATTIVITA[] GetByIDOBJ_REGISTRO(System.Int32 iDOBJ_REGISTRO)
		{
			return MapRecords(CreateGetByIDOBJ_REGISTROCommand(iDOBJ_REGISTRO));
		}

		/// <summary>
		/// Returns a DataTable of objects GVCTATTIVITA selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key of the object</param>
		/// <returns>A DataTable</returns>
		public virtual DataTable GetByIDOBJ_REGISTROAsDataTable(System.Int32 iDOBJ_REGISTRO)
		{
			return MapRecordsToDataTable(CreateGetByIDOBJ_REGISTROCommand(iDOBJ_REGISTRO));
		}

		/// <summary>
		/// Returns an IdbCommand with the selected foreign key
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key</param>
		/// <returns>An IDbCommand</returns>
		protected virtual IDbCommand CreateGetByIDOBJ_REGISTROCommand(System.Int32 iDOBJ_REGISTRO)
		{
			string whereSql = "IDOBJ_REGISTRO = " + _db.CreateSqlParameterName("IDOBJ_REGISTRO");
			IDbCommand cmd = CreateGetCommand(whereSql, null);
			AddParameter(cmd, "IDOBJ_REGISTRO", iDOBJ_REGISTRO);
			return cmd;
		}

		/// <summary>
		/// Deletes from the Database the objects GVCTATTIVITA
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key</param>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteByIDOBJ_REGISTRO(System.Int32 iDOBJ_REGISTRO)
		{
			return CreateDeleteByIDOBJ_REGISTROCommand(iDOBJ_REGISTRO).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates the IDbCommand for the deletion from the Database of the objects GVCTATTIVITA
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key</param>
		/// <returns>The IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteByIDOBJ_REGISTROCommand(System.Int32 iDOBJ_REGISTRO)
		{
			string whereSql = "IDOBJ_REGISTRO = " + _db.CreateSqlParameterName("IDOBJ_REGISTRO");
			IDbCommand cmd = CreateDeleteCommand(whereSql);
			AddParameter(cmd, "IDOBJ_REGISTRO", iDOBJ_REGISTRO);
			return cmd;
		}

		/// <summary>
		/// Inserts in the Database an object GVCTATTIVITA
		/// </summary>
		/// <param name="valore">The object to insert</param>
		public virtual void Insert(GVCTATTIVITA valore)
		{
			System.Int32 id = -1;
			System.String sqlStr;

			sqlStr = "SELECT GVCTATTIVITA_SEQ.NEXTVAL FROM DUAL";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				id = Convert.ToInt32(cmd.ExecuteScalar());
			}

			sqlStr = "INSERT INTO GVCTATTIVITA (" +
			"IDOBJ, " +
			"ATTIVITA_CCIAA, " +
			"IDOBJ_REGISTRO, " +
			"IDOBJ_CODICE_ATECO, " +
			"IMPORTANZA, " +
			"DATA_INIZIO, " +
			"STATO_ATTIVITA, " +
			"NOTE, " +
			"OPERATOREULTMOD, " +
			"DATAORAULTMOD) " +
			"VALUES (" + id.ToString() + ", " +
			_db.CreateSqlParameterName("ATTIVITA_CCIAA") + ", " +
			_db.CreateSqlParameterName("IDOBJ_REGISTRO") + ", " +
			_db.CreateSqlParameterName("IDOBJ_CODICE_ATECO") + ", " +
			_db.CreateSqlParameterName("IMPORTANZA") + ", " +
			_db.CreateSqlParameterName("DATA_INIZIO") + ", " +
			_db.CreateSqlParameterName("STATO_ATTIVITA") + ", " +
			_db.CreateSqlParameterName("NOTE") + ", " +
			_db.CreateSqlParameterName("OPERATOREULTMOD") + ", " +
			_db.CreateSqlParameterName("DATAORAULTMOD") + ")";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "ATTIVITA_CCIAA", valore.ATTIVITA_CCIAA);
				AddParameter(cmd, "IDOBJ_REGISTRO", valore.IDOBJ_REGISTRO);
				AddParameter(cmd, "IDOBJ_CODICE_ATECO", valore.IDOBJ_CODICE_ATECO);
				AddParameter(cmd, "IMPORTANZA", valore.IsIMPORTANZANull ? DBNull.Value : (object)valore.IMPORTANZA);
				AddParameter(cmd, "DATA_INIZIO", valore.IsDATA_INIZIONull ? DBNull.Value : (object)valore.DATA_INIZIO);
				AddParameter(cmd, "STATO_ATTIVITA", valore.IsSTATO_ATTIVITANull ? DBNull.Value : (object)valore.STATO_ATTIVITA);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				AddParameter(cmd, "OPERATOREULTMOD", valore.IsOPERATOREULTMODNull ? DBNull.Value : (object)valore.OPERATOREULTMOD);
				AddParameter(cmd, "DATAORAULTMOD", valore.IsDATAORAULTMODNull ? DBNull.Value : (object)valore.DATAORAULTMOD);
				cmd.ExecuteScalar();
				valore.IDOBJ = id;
			}
		}

		/// <summary>
		/// Updates in the Database an object GVCTATTIVITA
		/// </summary>
		/// <param name="valore">The object to update</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool Update(GVCTATTIVITA valore)
		{
			System.String sqlStr = "UPDATE GVCTATTIVITA SET " +
				"ATTIVITA_CCIAA = " + _db.CreateSqlParameterName("ATTIVITA_CCIAA") + ", " +
				"IDOBJ_REGISTRO = " + _db.CreateSqlParameterName("IDOBJ_REGISTRO") + ", " +
				"IDOBJ_CODICE_ATECO = " + _db.CreateSqlParameterName("IDOBJ_CODICE_ATECO") + ", " +
				"IMPORTANZA = " + _db.CreateSqlParameterName("IMPORTANZA") + ", " +
				"DATA_INIZIO = " + _db.CreateSqlParameterName("DATA_INIZIO") + ", " +
				"STATO_ATTIVITA = " + _db.CreateSqlParameterName("STATO_ATTIVITA") + ", " +
				"NOTE = " + _db.CreateSqlParameterName("NOTE") + ", " +
				"OPERATOREULTMOD = " + _db.CreateSqlParameterName("OPERATOREULTMOD") + ", " +
				"DATAORAULTMOD = " + _db.CreateSqlParameterName("DATAORAULTMOD") +
				" WHERE " +
				"IDOBJ = " + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ", valore.IDOBJ);
				AddParameter(cmd, "ATTIVITA_CCIAA", valore.ATTIVITA_CCIAA);
				AddParameter(cmd, "IDOBJ_REGISTRO", valore.IDOBJ_REGISTRO);
				AddParameter(cmd, "IDOBJ_CODICE_ATECO", valore.IDOBJ_CODICE_ATECO);
				AddParameter(cmd, "IMPORTANZA", valore.IsIMPORTANZANull ? DBNull.Value : (object)valore.IMPORTANZA);
				AddParameter(cmd, "DATA_INIZIO", valore.IsDATA_INIZIONull ? DBNull.Value : (object)valore.DATA_INIZIO);
				AddParameter(cmd, "STATO_ATTIVITA", valore.IsSTATO_ATTIVITANull ? DBNull.Value : (object)valore.STATO_ATTIVITA);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				AddParameter(cmd, "OPERATOREULTMOD", valore.IsOPERATOREULTMODNull ? DBNull.Value : (object)valore.OPERATOREULTMOD);
				AddParameter(cmd, "DATAORAULTMOD", valore.IsDATAORAULTMODNull ? DBNull.Value : (object)valore.DATAORAULTMOD);
				return cmd.ExecuteNonQuery() != 0;
			}
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCTATTIVITA
		/// </summary>
		/// <param name="table">The DataTable of objects GVCTATTIVITA</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCTATTIVITA
		/// </summary>
		/// <param name="table">The DataTable of objects GVCTATTIVITA</param>
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
		/// Deletes from the Database an object GVCTATTIVITA
		/// </summary>
		/// <param name="valore">The object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public bool Delete(GVCTATTIVITA valore)
		{
			return DeleteByPrimaryKey(valore.IDOBJ);
		}

		/// <summary>
		/// Deletes from the Database an object GVCTATTIVITA
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
		/// Deletes from the Database the objects GVCTATTIVITA selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>The number of the deleted objects</returns>
		public int Delete(System.String whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Returns an IDbCommand to delete the objects GVCTATTIVITA selected by 
		/// a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			StringBuilder sql = new StringBuilder("DELETE FROM GVCTATTIVITA");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format(" WHERE {0}", whereSql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Deletes all the objects GVCTATTIVITA
		/// </summary>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteAll()
		{
			return Delete("");
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCTATTIVITA
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCTATTIVITA</returns>
		protected GVCTATTIVITA[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCTATTIVITA
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCTATTIVITA</returns>
		protected GVCTATTIVITA[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCTATTIVITA
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCTATTIVITA</returns>
		protected virtual GVCTATTIVITA[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int aTTIVITA_CCIAAColumnIndex = reader.GetOrdinal("ATTIVITA_CCIAA");
			int iDOBJ_REGISTROColumnIndex = reader.GetOrdinal("IDOBJ_REGISTRO");
			int iDOBJ_CODICE_ATECOColumnIndex = reader.GetOrdinal("IDOBJ_CODICE_ATECO");
			int iMPORTANZAColumnIndex = reader.GetOrdinal("IMPORTANZA");
			int dATA_INIZIOColumnIndex = reader.GetOrdinal("DATA_INIZIO");
			int sTATO_ATTIVITAColumnIndex = reader.GetOrdinal("STATO_ATTIVITA");
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
					GVCTATTIVITA record = new GVCTATTIVITA();
					recordList.Add(record);
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.ATTIVITA_CCIAA = Convert.ToInt32(reader.GetValue(aTTIVITA_CCIAAColumnIndex));
					record.IDOBJ_REGISTRO = Convert.ToInt32(reader.GetValue(iDOBJ_REGISTROColumnIndex));
					record.IDOBJ_CODICE_ATECO = Convert.ToInt32(reader.GetValue(iDOBJ_CODICE_ATECOColumnIndex));
					if(!reader.IsDBNull(iMPORTANZAColumnIndex))
						record.IMPORTANZA = Convert.ToString(reader.GetValue(iMPORTANZAColumnIndex));
					if(!reader.IsDBNull(dATA_INIZIOColumnIndex))
						record.DATA_INIZIO = Convert.ToDateTime(reader.GetValue(dATA_INIZIOColumnIndex));
					if(!reader.IsDBNull(sTATO_ATTIVITAColumnIndex))
						record.STATO_ATTIVITA = Convert.ToString(reader.GetValue(sTATO_ATTIVITAColumnIndex));
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
			return (GVCTATTIVITA[])(recordList.ToArray(typeof(GVCTATTIVITA)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCTATTIVITA</returns>
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
		/// <returns>DataTable of objects GVCTATTIVITA</returns>
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
		/// <returns>DataTable of objects GVCTATTIVITA</returns>
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
		/// Converts a DataRow to an object GVCTATTIVITA
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCTATTIVITA</returns>
		protected virtual GVCTATTIVITA MapRow(DataRow row)
		{
			GVCTATTIVITA mappedObject = new GVCTATTIVITA();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "ATTIVITA_CCIAA"
			dataColumn = dataTable.Columns["ATTIVITA_CCIAA"];
			if(!row.IsNull(dataColumn))
				mappedObject.ATTIVITA_CCIAA = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_REGISTRO"
			dataColumn = dataTable.Columns["IDOBJ_REGISTRO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_REGISTRO = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_CODICE_ATECO"
			dataColumn = dataTable.Columns["IDOBJ_CODICE_ATECO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_CODICE_ATECO = (System.Int32)row[dataColumn];
			//Campo "IMPORTANZA"
			dataColumn = dataTable.Columns["IMPORTANZA"];
			if(!row.IsNull(dataColumn))
				mappedObject.IMPORTANZA = (System.String)row[dataColumn];
			//Campo "DATA_INIZIO"
			dataColumn = dataTable.Columns["DATA_INIZIO"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATA_INIZIO = (System.DateTime)row[dataColumn];
			//Campo "STATO_ATTIVITA"
			dataColumn = dataTable.Columns["STATO_ATTIVITA"];
			if(!row.IsNull(dataColumn))
				mappedObject.STATO_ATTIVITA = (System.String)row[dataColumn];
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
		/// Creates a DataTable to store the objects GVCTATTIVITA
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCTATTIVITA";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("ATTIVITA_CCIAA", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ_CODICE_ATECO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IMPORTANZA", typeof(System.String));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATA_INIZIO", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("STATO_ATTIVITA", typeof(System.String));
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

				case "ATTIVITA_CCIAA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IDOBJ_REGISTRO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IDOBJ_CODICE_ATECO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IMPORTANZA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
					break;

				case "DATA_INIZIO":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "STATO_ATTIVITA":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, valore);
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