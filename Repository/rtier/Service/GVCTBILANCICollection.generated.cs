//
//Generated by gvc at 26/03/2009 9.03.13
//

using System;
using System.Data;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the object GVCTBILANCI
	/// </summary>
	public partial class GVCTBILANCICollection
	{
		/// <summary>
		/// Returns the Database Name of the field IDOBJ.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJColumnName = "IDOBJ";
		/// <summary>
		/// Returns the Database Name of the field ANNO_RIFERIMENTO.
		///The field is mandatory.
		/// </summary>
		public const string ANNO_RIFERIMENTOColumnName = "ANNO_RIFERIMENTO";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_REGISTRO.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_REGISTROColumnName = "IDOBJ_REGISTRO";
		/// <summary>
		/// Returns the Database Name of the field IDOBJ_TIPO_BILANCIO.
		///The field is mandatory.
		/// </summary>
		public const string IDOBJ_TIPO_BILANCIOColumnName = "IDOBJ_TIPO_BILANCIO";
		/// <summary>
		/// Returns the Database Name of the field DATA_RIFERIMENTO.
		/// </summary>
		public const string DATA_RIFERIMENTOColumnName = "DATA_RIFERIMENTO";
		/// <summary>
		/// Returns the Database Name of the field DATA_DEPOSITO_RI.
		/// </summary>
		public const string DATA_DEPOSITO_RIColumnName = "DATA_DEPOSITO_RI";
		/// <summary>
		/// Returns the Database Name of the field DATA_SEGNALAZIONE.
		/// </summary>
		public const string DATA_SEGNALAZIONEColumnName = "DATA_SEGNALAZIONE";
		/// <summary>
		/// Returns the Database Name of the field REQUISITO_PREVALENZA.
		/// </summary>
		public const string REQUISITO_PREVALENZAColumnName = "REQUISITO_PREVALENZA";
		/// <summary>
		/// Returns the Database Name of the field IMPORTO_PERCENTO_UTILI.
		/// </summary>
		public const string IMPORTO_PERCENTO_UTILIColumnName = "IMPORTO_PERCENTO_UTILI";
		/// <summary>
		/// Returns the Database Name of the field IMPORTO_PATRIMONIO.
		/// </summary>
		public const string IMPORTO_PATRIMONIOColumnName = "IMPORTO_PATRIMONIO";
		/// <summary>
		/// Returns the Database Name of the field VERIFICA_PAGAMENTO.
		/// </summary>
		public const string VERIFICA_PAGAMENTOColumnName = "VERIFICA_PAGAMENTO";
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
		public GVCTBILANCICollection(GVC db)
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
		/// Returns an array containing all the objects GVCTBILANCI
		/// </summary>
		/// <returns>Array of objects GVCTBILANCI</returns>
		public virtual GVCTBILANCI[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns a DataTable containing all the objects GVCTBILANCI
		/// </summary>
		/// <returns>DataTable of objects GVCTBILANCI</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Returns an IDbCommand to get all the objects GVCTBILANCI
		/// </summary>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetAllCommand()
		{
			return CreateGetCommand(null, null);
		}

		/// <summary>
		/// Returns an object GVCTBILANCI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Object of type GVCTBILANCI</returns>
		public GVCTBILANCI GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			GVCTBILANCI[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return rows.Length == 0 ? null : rows[0];
		}

		/// <summary>
		/// Returns an array containing the objects GVCTBILANCI selected by a WHERE statement
		/// and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Array of objects GVCTBILANCI</returns>
		public GVCTBILANCI[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns an array containing a subset of the objects GVCTBILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="Length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of objects GVCTBILANCI</returns>
		public virtual GVCTBILANCI[] GetAsArray(string whereSql, string orderBySql, int startIndex, int Length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, Length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCTBILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>DataTable of objects GVCTBILANCI</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Returns a DataTable containing a subset of the objects GVCTBILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">Length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>DataTable of objects GVCTBILANCI</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,	int startIndex, int length, ref int totalRecordCount)
		{
			using(IDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Returns an IDbCommand to get the objects GVCTBILANCI selected by 
		/// a WHERE statement and ordered by ORDER BY statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <param name="orderBySql">The ORDER BY statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			StringBuilder sql = new StringBuilder("SELECT ");
			sql.Append("IDOBJ, ");
			sql.Append("ANNO_RIFERIMENTO, ");
			sql.Append("IDOBJ_REGISTRO, ");
			sql.Append("IDOBJ_TIPO_BILANCIO, ");
			sql.Append("DATA_RIFERIMENTO, ");
			sql.Append("DATA_DEPOSITO_RI, ");
			sql.Append("DATA_SEGNALAZIONE, ");
			sql.Append("REQUISITO_PREVALENZA, ");
			sql.Append("IMPORTO_PERCENTO_UTILI, ");
			sql.Append("IMPORTO_PATRIMONIO, ");
			sql.Append("VERIFICA_PAGAMENTO, ");
			sql.Append("NOTE, ");
			sql.Append("OPERATOREULTMOD, ");
			sql.Append("DATAORAULTMOD ");
			sql.Append("FROM GVCTBILANCI ");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format("WHERE {0} ", whereSql));
			if(orderBySql != null && orderBySql.Length > 0)
				sql.Append(String.Format("ORDER BY {0} ", orderBySql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Returns an object GVCTBILANCI selected by a primary key
		/// </summary>
		/// <param name="IDOBJ">The primary key of the object</param>
		/// <returns>Object of type GVCTBILANCI</returns>
		public virtual GVCTBILANCI GetByPrimaryKey(System.Int32 IDOBJ)
		{
			string whereSql = "IDOBJ=" + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = CreateGetCommand(whereSql, null))
			{
				AddParameter(cmd, "IDOBJ", IDOBJ);
				GVCTBILANCI[] tempArray = MapRecords(cmd);
				return tempArray.Length == 0 ? null : tempArray[0];
			}
		}


		/// <summary>
		/// Returns an object GVCTBILANCI selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_TIPO_BILANCIO">The foreign key of the object</param>
		/// <returns>Object of type GVCTBILANCI</returns>
		public virtual GVCTBILANCI[] GetByIDOBJ_TIPO_BILANCIO(System.Int32 iDOBJ_TIPO_BILANCIO)
		{
			return MapRecords(CreateGetByIDOBJ_TIPO_BILANCIOCommand(iDOBJ_TIPO_BILANCIO));
		}

		/// <summary>
		/// Returns a DataTable of objects GVCTBILANCI selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_TIPO_BILANCIO">The foreign key of the object</param>
		/// <returns>A DataTable</returns>
		public virtual DataTable GetByIDOBJ_TIPO_BILANCIOAsDataTable(System.Int32 iDOBJ_TIPO_BILANCIO)
		{
			return MapRecordsToDataTable(CreateGetByIDOBJ_TIPO_BILANCIOCommand(iDOBJ_TIPO_BILANCIO));
		}

		/// <summary>
		/// Returns an IdbCommand with the selected foreign key
		/// </summary>
		/// <param name="iDOBJ_TIPO_BILANCIO">The foreign key</param>
		/// <returns>An IDbCommand</returns>
		protected virtual IDbCommand CreateGetByIDOBJ_TIPO_BILANCIOCommand(System.Int32 iDOBJ_TIPO_BILANCIO)
		{
			string whereSql = "IDOBJ_TIPO_BILANCIO = " + _db.CreateSqlParameterName("IDOBJ_TIPO_BILANCIO");
			IDbCommand cmd = CreateGetCommand(whereSql, null);
			AddParameter(cmd, "IDOBJ_TIPO_BILANCIO", iDOBJ_TIPO_BILANCIO);
			return cmd;
		}

		/// <summary>
		/// Deletes from the Database the objects GVCTBILANCI
		/// </summary>
		/// <param name="iDOBJ_TIPO_BILANCIO">The foreign key</param>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteByIDOBJ_TIPO_BILANCIO(System.Int32 iDOBJ_TIPO_BILANCIO)
		{
			return CreateDeleteByIDOBJ_TIPO_BILANCIOCommand(iDOBJ_TIPO_BILANCIO).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates the IDbCommand for the deletion from the Database of the objects GVCTBILANCI
		/// </summary>
		/// <param name="iDOBJ_TIPO_BILANCIO">The foreign key</param>
		/// <returns>The IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteByIDOBJ_TIPO_BILANCIOCommand(System.Int32 iDOBJ_TIPO_BILANCIO)
		{
			string whereSql = "IDOBJ_TIPO_BILANCIO = " + _db.CreateSqlParameterName("IDOBJ_TIPO_BILANCIO");
			IDbCommand cmd = CreateDeleteCommand(whereSql);
			AddParameter(cmd, "IDOBJ_TIPO_BILANCIO", iDOBJ_TIPO_BILANCIO);
			return cmd;
		}

		/// <summary>
		/// Returns an object GVCTBILANCI selected by a foreign key
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key of the object</param>
		/// <returns>Object of type GVCTBILANCI</returns>
		public virtual GVCTBILANCI[] GetByIDOBJ_REGISTRO(System.Int32 iDOBJ_REGISTRO)
		{
			return MapRecords(CreateGetByIDOBJ_REGISTROCommand(iDOBJ_REGISTRO));
		}

		/// <summary>
		/// Returns a DataTable of objects GVCTBILANCI selected by a foreign key
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
		/// Deletes from the Database the objects GVCTBILANCI
		/// </summary>
		/// <param name="iDOBJ_REGISTRO">The foreign key</param>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteByIDOBJ_REGISTRO(System.Int32 iDOBJ_REGISTRO)
		{
			return CreateDeleteByIDOBJ_REGISTROCommand(iDOBJ_REGISTRO).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates the IDbCommand for the deletion from the Database of the objects GVCTBILANCI
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
		/// Inserts in the Database an object GVCTBILANCI
		/// </summary>
		/// <param name="valore">The object to insert</param>
		public virtual void Insert(GVCTBILANCI valore)
		{
			System.Int32 id = -1;
			System.String sqlStr;

			sqlStr = "SELECT GVCTBILANCI_SEQ.NEXTVAL FROM DUAL";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				id = Convert.ToInt32(cmd.ExecuteScalar());
			}

			sqlStr = "INSERT INTO GVCTBILANCI (" +
			"IDOBJ, " +
			"ANNO_RIFERIMENTO, " +
			"IDOBJ_REGISTRO, " +
			"IDOBJ_TIPO_BILANCIO, " +
			"DATA_RIFERIMENTO, " +
			"DATA_DEPOSITO_RI, " +
			"DATA_SEGNALAZIONE, " +
			"REQUISITO_PREVALENZA, " +
			"IMPORTO_PERCENTO_UTILI, " +
			"IMPORTO_PATRIMONIO, " +
			"VERIFICA_PAGAMENTO, " +
			"NOTE, " +
			"OPERATOREULTMOD, " +
			"DATAORAULTMOD) " +
			"VALUES (" + id.ToString() + ", " +
			_db.CreateSqlParameterName("ANNO_RIFERIMENTO") + ", " +
			_db.CreateSqlParameterName("IDOBJ_REGISTRO") + ", " +
			_db.CreateSqlParameterName("IDOBJ_TIPO_BILANCIO") + ", " +
			_db.CreateSqlParameterName("DATA_RIFERIMENTO") + ", " +
			_db.CreateSqlParameterName("DATA_DEPOSITO_RI") + ", " +
			_db.CreateSqlParameterName("DATA_SEGNALAZIONE") + ", " +
			_db.CreateSqlParameterName("REQUISITO_PREVALENZA") + ", " +
			_db.CreateSqlParameterName("IMPORTO_PERCENTO_UTILI") + ", " +
			_db.CreateSqlParameterName("IMPORTO_PATRIMONIO") + ", " +
			_db.CreateSqlParameterName("VERIFICA_PAGAMENTO") + ", " +
			_db.CreateSqlParameterName("NOTE") + ", " +
			_db.CreateSqlParameterName("OPERATOREULTMOD") + ", " +
			_db.CreateSqlParameterName("DATAORAULTMOD") + ")";
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "ANNO_RIFERIMENTO", valore.ANNO_RIFERIMENTO);
				AddParameter(cmd, "IDOBJ_REGISTRO", valore.IDOBJ_REGISTRO);
				AddParameter(cmd, "IDOBJ_TIPO_BILANCIO", valore.IDOBJ_TIPO_BILANCIO);
				AddParameter(cmd, "DATA_RIFERIMENTO", valore.IsDATA_RIFERIMENTONull ? DBNull.Value : (object)valore.DATA_RIFERIMENTO);
				AddParameter(cmd, "DATA_DEPOSITO_RI", valore.IsDATA_DEPOSITO_RINull ? DBNull.Value : (object)valore.DATA_DEPOSITO_RI);
				AddParameter(cmd, "DATA_SEGNALAZIONE", valore.IsDATA_SEGNALAZIONENull ? DBNull.Value : (object)valore.DATA_SEGNALAZIONE);
				AddParameter(cmd, "REQUISITO_PREVALENZA", valore.IsREQUISITO_PREVALENZANull ? DBNull.Value : (object)valore.REQUISITO_PREVALENZA);
				AddParameter(cmd, "IMPORTO_PERCENTO_UTILI", valore.IsIMPORTO_PERCENTO_UTILINull ? DBNull.Value : (object)valore.IMPORTO_PERCENTO_UTILI);
				AddParameter(cmd, "IMPORTO_PATRIMONIO", valore.IsIMPORTO_PATRIMONIONull ? DBNull.Value : (object)valore.IMPORTO_PATRIMONIO);
				AddParameter(cmd, "VERIFICA_PAGAMENTO", valore.IsVERIFICA_PAGAMENTONull ? DBNull.Value : (object)valore.VERIFICA_PAGAMENTO);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				AddParameter(cmd, "OPERATOREULTMOD", valore.IsOPERATOREULTMODNull ? DBNull.Value : (object)valore.OPERATOREULTMOD);
				AddParameter(cmd, "DATAORAULTMOD", valore.IsDATAORAULTMODNull ? DBNull.Value : (object)valore.DATAORAULTMOD);
				cmd.ExecuteScalar();
				valore.IDOBJ = id;
			}
		}

		/// <summary>
		/// Updates in the Database an object GVCTBILANCI
		/// </summary>
		/// <param name="valore">The object to update</param>
		/// <returns>true if success, otherwise false</returns>
		public virtual bool Update(GVCTBILANCI valore)
		{
			System.String sqlStr = "UPDATE GVCTBILANCI SET " +
				"ANNO_RIFERIMENTO = " + _db.CreateSqlParameterName("ANNO_RIFERIMENTO") + ", " +
				"IDOBJ_REGISTRO = " + _db.CreateSqlParameterName("IDOBJ_REGISTRO") + ", " +
				"IDOBJ_TIPO_BILANCIO = " + _db.CreateSqlParameterName("IDOBJ_TIPO_BILANCIO") + ", " +
				"DATA_RIFERIMENTO = " + _db.CreateSqlParameterName("DATA_RIFERIMENTO") + ", " +
				"DATA_DEPOSITO_RI = " + _db.CreateSqlParameterName("DATA_DEPOSITO_RI") + ", " +
				"DATA_SEGNALAZIONE = " + _db.CreateSqlParameterName("DATA_SEGNALAZIONE") + ", " +
				"REQUISITO_PREVALENZA = " + _db.CreateSqlParameterName("REQUISITO_PREVALENZA") + ", " +
				"IMPORTO_PERCENTO_UTILI = " + _db.CreateSqlParameterName("IMPORTO_PERCENTO_UTILI") + ", " +
				"IMPORTO_PATRIMONIO = " + _db.CreateSqlParameterName("IMPORTO_PATRIMONIO") + ", " +
				"VERIFICA_PAGAMENTO = " + _db.CreateSqlParameterName("VERIFICA_PAGAMENTO") + ", " +
				"NOTE = " + _db.CreateSqlParameterName("NOTE") + ", " +
				"OPERATOREULTMOD = " + _db.CreateSqlParameterName("OPERATOREULTMOD") + ", " +
				"DATAORAULTMOD = " + _db.CreateSqlParameterName("DATAORAULTMOD") +
				" WHERE " +
				"IDOBJ = " + _db.CreateSqlParameterName("IDOBJ");
			using(IDbCommand cmd = _db.CreateCommand(sqlStr))
			{
				AddParameter(cmd, "IDOBJ", valore.IDOBJ);
				AddParameter(cmd, "ANNO_RIFERIMENTO", valore.ANNO_RIFERIMENTO);
				AddParameter(cmd, "IDOBJ_REGISTRO", valore.IDOBJ_REGISTRO);
				AddParameter(cmd, "IDOBJ_TIPO_BILANCIO", valore.IDOBJ_TIPO_BILANCIO);
				AddParameter(cmd, "DATA_RIFERIMENTO", valore.IsDATA_RIFERIMENTONull ? DBNull.Value : (object)valore.DATA_RIFERIMENTO);
				AddParameter(cmd, "DATA_DEPOSITO_RI", valore.IsDATA_DEPOSITO_RINull ? DBNull.Value : (object)valore.DATA_DEPOSITO_RI);
				AddParameter(cmd, "DATA_SEGNALAZIONE", valore.IsDATA_SEGNALAZIONENull ? DBNull.Value : (object)valore.DATA_SEGNALAZIONE);
				AddParameter(cmd, "REQUISITO_PREVALENZA", valore.IsREQUISITO_PREVALENZANull ? DBNull.Value : (object)valore.REQUISITO_PREVALENZA);
				AddParameter(cmd, "IMPORTO_PERCENTO_UTILI", valore.IsIMPORTO_PERCENTO_UTILINull ? DBNull.Value : (object)valore.IMPORTO_PERCENTO_UTILI);
				AddParameter(cmd, "IMPORTO_PATRIMONIO", valore.IsIMPORTO_PATRIMONIONull ? DBNull.Value : (object)valore.IMPORTO_PATRIMONIO);
				AddParameter(cmd, "VERIFICA_PAGAMENTO", valore.IsVERIFICA_PAGAMENTONull ? DBNull.Value : (object)valore.VERIFICA_PAGAMENTO);
				AddParameter(cmd, "NOTE", valore.IsNOTENull ? DBNull.Value : (object)valore.NOTE);
				AddParameter(cmd, "OPERATOREULTMOD", valore.IsOPERATOREULTMODNull ? DBNull.Value : (object)valore.OPERATOREULTMOD);
				AddParameter(cmd, "DATAORAULTMOD", valore.IsDATAORAULTMODNull ? DBNull.Value : (object)valore.DATAORAULTMOD);
				return cmd.ExecuteNonQuery() != 0;
			}
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCTBILANCI
		/// </summary>
		/// <param name="table">The DataTable of objects GVCTBILANCI</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates in the Database a DataTable of objects GVCTBILANCI
		/// </summary>
		/// <param name="table">The DataTable of objects GVCTBILANCI</param>
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
		/// Deletes from the Database an object GVCTBILANCI
		/// </summary>
		/// <param name="valore">The object to delete</param>
		/// <returns>true if success, otherwise false</returns>
		public bool Delete(GVCTBILANCI valore)
		{
			return DeleteByPrimaryKey(valore.IDOBJ);
		}

		/// <summary>
		/// Deletes from the Database an object GVCTBILANCI
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
		/// Deletes from the Database the objects GVCTBILANCI selected by a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>The number of the deleted objects</returns>
		public int Delete(System.String whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Returns an IDbCommand to delete the objects GVCTBILANCI selected by 
		/// a WHERE statement
		/// </summary>
		/// <param name="whereSql">The WHERE statement</param>
		/// <returns>Istance of IDbCommand</returns>
		protected virtual IDbCommand CreateDeleteCommand(string whereSql)
		{
			StringBuilder sql = new StringBuilder("DELETE FROM GVCTBILANCI");
			if(whereSql != null && whereSql.Length > 0)
				sql.Append(String.Format(" WHERE {0}", whereSql));
			return _db.CreateCommand(sql.ToString());
		}

		/// <summary>
		/// Deletes all the objects GVCTBILANCI
		/// </summary>
		/// <returns>The number of the deleted objects</returns>
		public int DeleteAll()
		{
			return Delete("");
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCTBILANCI
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>Array of type GVCTBILANCI</returns>
		protected GVCTBILANCI[] MapRecords(IDbCommand command)
		{
			using(IDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Converts the IDataReader object to an array of type GVCTBILANCI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <returns>Array of type GVCTBILANCI</returns>
		protected GVCTBILANCI[] MapRecords(IDataReader reader)
		{
			int totalRecordCount = -1;
				return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Converts a subset of the IDataReader object to an array of type GVCTBILANCI
		/// </summary>
		/// <param name="reader">The IDataReader to convert</param>
		/// <param name="startIndex">The index of the subset</param>
		/// <param name="length">length of the subset</param>
		/// <param name="totalRecordCount">Number of records</param>
		/// <returns>Array of type GVCTBILANCI</returns>
		protected virtual GVCTBILANCI[] MapRecords(IDataReader reader, int startIndex, int length, ref int totalRecordCount)
		{
			if(startIndex < 0)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex non può essere minore di zero.");
			if(length < 0)
				throw new ArgumentOutOfRangeException("length", length, "La lunghezza non può essere minore di zero.");

			int iDOBJColumnIndex = reader.GetOrdinal("IDOBJ");
			int aNNO_RIFERIMENTOColumnIndex = reader.GetOrdinal("ANNO_RIFERIMENTO");
			int iDOBJ_REGISTROColumnIndex = reader.GetOrdinal("IDOBJ_REGISTRO");
			int iDOBJ_TIPO_BILANCIOColumnIndex = reader.GetOrdinal("IDOBJ_TIPO_BILANCIO");
			int dATA_RIFERIMENTOColumnIndex = reader.GetOrdinal("DATA_RIFERIMENTO");
			int dATA_DEPOSITO_RIColumnIndex = reader.GetOrdinal("DATA_DEPOSITO_RI");
			int dATA_SEGNALAZIONEColumnIndex = reader.GetOrdinal("DATA_SEGNALAZIONE");
			int rEQUISITO_PREVALENZAColumnIndex = reader.GetOrdinal("REQUISITO_PREVALENZA");
			int iMPORTO_PERCENTO_UTILIColumnIndex = reader.GetOrdinal("IMPORTO_PERCENTO_UTILI");
			int iMPORTO_PATRIMONIOColumnIndex = reader.GetOrdinal("IMPORTO_PATRIMONIO");
			int vERIFICA_PAGAMENTOColumnIndex = reader.GetOrdinal("VERIFICA_PAGAMENTO");
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
					GVCTBILANCI record = new GVCTBILANCI();
					recordList.Add(record);
					record.IDOBJ = Convert.ToInt32(reader.GetValue(iDOBJColumnIndex));
					record.ANNO_RIFERIMENTO = Convert.ToInt32(reader.GetValue(aNNO_RIFERIMENTOColumnIndex));
					record.IDOBJ_REGISTRO = Convert.ToInt32(reader.GetValue(iDOBJ_REGISTROColumnIndex));
					record.IDOBJ_TIPO_BILANCIO = Convert.ToInt32(reader.GetValue(iDOBJ_TIPO_BILANCIOColumnIndex));
					if(!reader.IsDBNull(dATA_RIFERIMENTOColumnIndex))
						record.DATA_RIFERIMENTO = Convert.ToDateTime(reader.GetValue(dATA_RIFERIMENTOColumnIndex));
					if(!reader.IsDBNull(dATA_DEPOSITO_RIColumnIndex))
						record.DATA_DEPOSITO_RI = Convert.ToDateTime(reader.GetValue(dATA_DEPOSITO_RIColumnIndex));
					if(!reader.IsDBNull(dATA_SEGNALAZIONEColumnIndex))
						record.DATA_SEGNALAZIONE = Convert.ToDateTime(reader.GetValue(dATA_SEGNALAZIONEColumnIndex));
					if(!reader.IsDBNull(rEQUISITO_PREVALENZAColumnIndex))
						record.REQUISITO_PREVALENZA = Convert.ToInt32(reader.GetValue(rEQUISITO_PREVALENZAColumnIndex));
					if(!reader.IsDBNull(iMPORTO_PERCENTO_UTILIColumnIndex))
						record.IMPORTO_PERCENTO_UTILI = Convert.ToDouble(reader.GetValue(iMPORTO_PERCENTO_UTILIColumnIndex));
					if(!reader.IsDBNull(iMPORTO_PATRIMONIOColumnIndex))
						record.IMPORTO_PATRIMONIO = Convert.ToDouble(reader.GetValue(iMPORTO_PATRIMONIOColumnIndex));
					if(!reader.IsDBNull(vERIFICA_PAGAMENTOColumnIndex))
						record.VERIFICA_PAGAMENTO = Convert.ToInt32(reader.GetValue(vERIFICA_PAGAMENTOColumnIndex));
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
			return (GVCTBILANCI[])(recordList.ToArray(typeof(GVCTBILANCI)));
		}

		/// <summary>
		/// Converts the IDataReader object to a DataTable
		/// </summary>
		/// <param name="command">The IDbCommand to execute</param>
		/// <returns>DataTable of objects GVCTBILANCI</returns>
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
		/// <returns>DataTable of objects GVCTBILANCI</returns>
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
		/// <returns>DataTable of objects GVCTBILANCI</returns>
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
		/// Converts a DataRow to an object GVCTBILANCI
		/// </summary>
		/// <param name="row">The DataRow to convert</param>
		/// <returns>An object GVCTBILANCI</returns>
		protected virtual GVCTBILANCI MapRow(DataRow row)
		{
			GVCTBILANCI mappedObject = new GVCTBILANCI();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			//Campo "IDOBJ"
			dataColumn = dataTable.Columns["IDOBJ"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ = (System.Int32)row[dataColumn];
			//Campo "ANNO_RIFERIMENTO"
			dataColumn = dataTable.Columns["ANNO_RIFERIMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.ANNO_RIFERIMENTO = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_REGISTRO"
			dataColumn = dataTable.Columns["IDOBJ_REGISTRO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_REGISTRO = (System.Int32)row[dataColumn];
			//Campo "IDOBJ_TIPO_BILANCIO"
			dataColumn = dataTable.Columns["IDOBJ_TIPO_BILANCIO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IDOBJ_TIPO_BILANCIO = (System.Int32)row[dataColumn];
			//Campo "DATA_RIFERIMENTO"
			dataColumn = dataTable.Columns["DATA_RIFERIMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATA_RIFERIMENTO = (System.DateTime)row[dataColumn];
			//Campo "DATA_DEPOSITO_RI"
			dataColumn = dataTable.Columns["DATA_DEPOSITO_RI"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATA_DEPOSITO_RI = (System.DateTime)row[dataColumn];
			//Campo "DATA_SEGNALAZIONE"
			dataColumn = dataTable.Columns["DATA_SEGNALAZIONE"];
			if(!row.IsNull(dataColumn))
				mappedObject.DATA_SEGNALAZIONE = (System.DateTime)row[dataColumn];
			//Campo "REQUISITO_PREVALENZA"
			dataColumn = dataTable.Columns["REQUISITO_PREVALENZA"];
			if(!row.IsNull(dataColumn))
				mappedObject.REQUISITO_PREVALENZA = (System.Int32)row[dataColumn];
			//Campo "IMPORTO_PERCENTO_UTILI"
			dataColumn = dataTable.Columns["IMPORTO_PERCENTO_UTILI"];
			if(!row.IsNull(dataColumn))
				mappedObject.IMPORTO_PERCENTO_UTILI = (System.Double)row[dataColumn];
			//Campo "IMPORTO_PATRIMONIO"
			dataColumn = dataTable.Columns["IMPORTO_PATRIMONIO"];
			if(!row.IsNull(dataColumn))
				mappedObject.IMPORTO_PATRIMONIO = (System.Double)row[dataColumn];
			//Campo "VERIFICA_PAGAMENTO"
			dataColumn = dataTable.Columns["VERIFICA_PAGAMENTO"];
			if(!row.IsNull(dataColumn))
				mappedObject.VERIFICA_PAGAMENTO = (System.Int32)row[dataColumn];
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
		/// Creates a DataTable to store the objects GVCTBILANCI
		/// </summary>
		/// <returns>A DataTable</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "GVCTBILANCI";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("IDOBJ", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("ANNO_RIFERIMENTO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ_REGISTRO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IDOBJ_TIPO_BILANCIO", typeof(System.Int32));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATA_RIFERIMENTO", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATA_DEPOSITO_RI", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("DATA_SEGNALAZIONE", typeof(System.DateTime));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("REQUISITO_PREVALENZA", typeof(System.Int32));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IMPORTO_PERCENTO_UTILI", typeof(System.Double));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("IMPORTO_PATRIMONIO", typeof(System.Double));
			dataColumn.AllowDBNull = true;
			dataColumn.ReadOnly = false;
			dataColumn.Unique = false;
			dataColumn.AutoIncrement = false;
			dataColumn = dataTable.Columns.Add("VERIFICA_PAGAMENTO", typeof(System.Int32));
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

				case "ANNO_RIFERIMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IDOBJ_REGISTRO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IDOBJ_TIPO_BILANCIO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "DATA_RIFERIMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "DATA_DEPOSITO_RI":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "DATA_SEGNALAZIONE":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, valore);
					break;

				case "REQUISITO_PREVALENZA":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
					break;

				case "IMPORTO_PERCENTO_UTILI":
					parameter = _db.AddParameter(cmd, paramName, DbType.Double, valore);
					break;

				case "IMPORTO_PATRIMONIO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Double, valore);
					break;

				case "VERIFICA_PAGAMENTO":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, valore);
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