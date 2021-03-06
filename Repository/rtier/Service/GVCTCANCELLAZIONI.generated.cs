//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTCANCELLAZIONI
	/// </summary>
	public partial class GVCTCANCELLAZIONI
	{
		private System.Int32 _iDOBJ;
		private System.Int32 _iDOBJ_REGISTRO;
		private System.Int32 _tIPO;
		private System.Boolean _tIPONull = true;
		private System.DateTime _dATA_DOMANDA;
		private System.Boolean _dATA_DOMANDANull = true;
		private System.String _nUMERO_DETERMINA;
		private System.Boolean _nUMERO_DETERMINANull = true;
		private System.DateTime _dATA_DETERMINA;
		private System.Boolean _dATA_DETERMINANull = true;
		private System.String _nUMERO_DELIBERA;
		private System.Boolean _nUMERO_DELIBERANull = true;
		private System.DateTime _dATA_DELIBERA;
		private System.Boolean _dATA_DELIBERANull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;
		private System.DateTime _dATA_CANC_REGISTRO;
		private System.Boolean _dATA_CANC_REGISTRONull = true;
		private System.DateTime _dATA_CANC_ALBO;
		private System.Boolean _dATA_CANC_ALBONull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTCANCELLAZIONI(){}

		/// <summary>
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ
		{
			get
			{
				return _iDOBJ;
			}
			set
			{
				_iDOBJ = value;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_REGISTRO
		{
			get
			{
				return _iDOBJ_REGISTRO;
			}
			set
			{
				_iDOBJ_REGISTRO = value;
			}
		}

		/// <summary>
		/// 1=RI, 2=registro coop 3=albo nazionale
		/// </summary>
		public System.Int32 TIPO
		{
			get
			{
				if(IsTIPONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _tIPO;
			}
			set
			{
				_tIPONull = false;
				_tIPO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsTIPONull
		{
			get
			{
				return _tIPONull;
			}
			set
			{
				_tIPONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 TIPOSafe
		{
			get
			{
				if (IsTIPONull)
					return -1;
				return TIPO;
			}
		}

		/// <summary>
		/// Data ricevimento domanda
		/// </summary>
		public System.DateTime DATA_DOMANDA
		{
			get
			{
				if(IsDATA_DOMANDANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DOMANDA;
			}
			set
			{
				_dATA_DOMANDANull = false;
				_dATA_DOMANDA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DOMANDANull
		{
			get
			{
				return _dATA_DOMANDANull;
			}
			set
			{
				_dATA_DOMANDANull = value;
			}
		}

		/// <summary>
		/// Numero determina
		/// </summary>
		public System.String NUMERO_DETERMINA
		{
			get
			{
				if(IsNUMERO_DETERMINANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_DETERMINA;
			}
			set
			{
				_nUMERO_DETERMINANull = false;
				_nUMERO_DETERMINA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_DETERMINANull
		{
			get
			{
				return _nUMERO_DETERMINANull;
			}
			set
			{
				_nUMERO_DETERMINANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_DETERMINASafe
		{
			get
			{
				if (IsNUMERO_DETERMINANull)
					return System.String.Empty;
				return NUMERO_DETERMINA;
			}
		}

		/// <summary>
		/// Data della determina
		/// </summary>
		public System.DateTime DATA_DETERMINA
		{
			get
			{
				if(IsDATA_DETERMINANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DETERMINA;
			}
			set
			{
				_dATA_DETERMINANull = false;
				_dATA_DETERMINA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DETERMINANull
		{
			get
			{
				return _dATA_DETERMINANull;
			}
			set
			{
				_dATA_DETERMINANull = value;
			}
		}

		/// <summary>
		/// Numero delibera commissione
		/// </summary>
		public System.String NUMERO_DELIBERA
		{
			get
			{
				if(IsNUMERO_DELIBERANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_DELIBERA;
			}
			set
			{
				_nUMERO_DELIBERANull = false;
				_nUMERO_DELIBERA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_DELIBERANull
		{
			get
			{
				return _nUMERO_DELIBERANull;
			}
			set
			{
				_nUMERO_DELIBERANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_DELIBERASafe
		{
			get
			{
				if (IsNUMERO_DELIBERANull)
					return System.String.Empty;
				return NUMERO_DELIBERA;
			}
		}

		/// <summary>
		/// Data delibera commissione
		/// </summary>
		public System.DateTime DATA_DELIBERA
		{
			get
			{
				if(IsDATA_DELIBERANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DELIBERA;
			}
			set
			{
				_dATA_DELIBERANull = false;
				_dATA_DELIBERA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DELIBERANull
		{
			get
			{
				return _dATA_DELIBERANull;
			}
			set
			{
				_dATA_DELIBERANull = value;
			}
		}

		/// <summary>
		/// Note
		/// </summary>
		public System.String NOTE
		{
			get
			{
				if(IsNOTENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nOTE;
			}
			set
			{
				_nOTENull = false;
				_nOTE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNOTENull
		{
			get
			{
				return _nOTENull;
			}
			set
			{
				_nOTENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NOTESafe
		{
			get
			{
				if (IsNOTENull)
					return System.String.Empty;
				return NOTE;
			}
		}

		/// <summary>
		/// Value of field OPERATOREULTMOD
		/// </summary>
		public System.String OPERATOREULTMOD
		{
			get
			{
				if(IsOPERATOREULTMODNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _oPERATOREULTMOD;
			}
			set
			{
				_oPERATOREULTMODNull = false;
				_oPERATOREULTMOD = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsOPERATOREULTMODNull
		{
			get
			{
				return _oPERATOREULTMODNull;
			}
			set
			{
				_oPERATOREULTMODNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String OPERATOREULTMODSafe
		{
			get
			{
				if (IsOPERATOREULTMODNull)
					return System.String.Empty;
				return OPERATOREULTMOD;
			}
		}

		/// <summary>
		/// Value of field DATAORAULTMOD
		/// </summary>
		public System.DateTime DATAORAULTMOD
		{
			get
			{
				if(IsDATAORAULTMODNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATAORAULTMOD;
			}
			set
			{
				_dATAORAULTMODNull = false;
				_dATAORAULTMOD = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATAORAULTMODNull
		{
			get
			{
				return _dATAORAULTMODNull;
			}
			set
			{
				_dATAORAULTMODNull = value;
			}
		}

		/// <summary>
		/// Data cancellazione dal registro imprese
		/// </summary>
		public System.DateTime DATA_CANC_REGISTRO
		{
			get
			{
				if(IsDATA_CANC_REGISTRONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_CANC_REGISTRO;
			}
			set
			{
				_dATA_CANC_REGISTRONull = false;
				_dATA_CANC_REGISTRO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_CANC_REGISTRONull
		{
			get
			{
				return _dATA_CANC_REGISTRONull;
			}
			set
			{
				_dATA_CANC_REGISTRONull = value;
			}
		}

		/// <summary>
		/// Data cancellazione dall albo nazionale
		/// </summary>
		public System.DateTime DATA_CANC_ALBO
		{
			get
			{
				if(IsDATA_CANC_ALBONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_CANC_ALBO;
			}
			set
			{
				_dATA_CANC_ALBONull = false;
				_dATA_CANC_ALBO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_CANC_ALBONull
		{
			get
			{
				return _dATA_CANC_ALBONull;
			}
			set
			{
				_dATA_CANC_ALBONull = value;
			}
		}

	}
}