//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTDELIBERE_ASSEMBLEA
	/// </summary>
	public partial class GVCTDELIBERE_ASSEMBLEA
	{
		private System.Int32 _iDOBJ;
		private System.DateTime _dATA_ASSEMBLEA;
		private System.Int32 _iDOBJ_REGISTRO;
		private System.Int32 _iDOBJ_TIPO_ASSEMBLEA;
		private System.String _cONTENUTO;
		private System.Boolean _cONTENUTONull = true;
		private System.DateTime _dATA_ISCRIZIONE_RI;
		private System.Boolean _dATA_ISCRIZIONE_RINull = true;
		private System.String _nUMERO_ESAME;
		private System.Boolean _nUMERO_ESAMENull = true;
		private System.DateTime _dATA_ESAME;
		private System.Boolean _dATA_ESAMENull = true;
		private System.DateTime _dATA_EVASIONE;
		private System.Boolean _dATA_EVASIONENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;
		private System.Int32 _iDOBJ_NOTAIO;
		private System.Boolean _iDOBJ_NOTAIONull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTDELIBERE_ASSEMBLEA(){}

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
		/// Data assemblea
		/// The field is mandatory.
		/// </summary>
		public System.DateTime DATA_ASSEMBLEA
		{
			get
			{
				return _dATA_ASSEMBLEA;
			}
			set
			{
				_dATA_ASSEMBLEA = value;
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
		/// Identificativo del recor
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_TIPO_ASSEMBLEA
		{
			get
			{
				return _iDOBJ_TIPO_ASSEMBLEA;
			}
			set
			{
				_iDOBJ_TIPO_ASSEMBLEA = value;
			}
		}

		/// <summary>
		/// Contenuto delibera
		/// </summary>
		public System.String CONTENUTO
		{
			get
			{
				if(IsCONTENUTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cONTENUTO;
			}
			set
			{
				_cONTENUTONull = false;
				_cONTENUTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCONTENUTONull
		{
			get
			{
				return _cONTENUTONull;
			}
			set
			{
				_cONTENUTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CONTENUTOSafe
		{
			get
			{
				if (IsCONTENUTONull)
					return System.String.Empty;
				return CONTENUTO;
			}
		}

		/// <summary>
		/// Data iscrizione Registro Imprese
		/// </summary>
		public System.DateTime DATA_ISCRIZIONE_RI
		{
			get
			{
				if(IsDATA_ISCRIZIONE_RINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ISCRIZIONE_RI;
			}
			set
			{
				_dATA_ISCRIZIONE_RINull = false;
				_dATA_ISCRIZIONE_RI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ISCRIZIONE_RINull
		{
			get
			{
				return _dATA_ISCRIZIONE_RINull;
			}
			set
			{
				_dATA_ISCRIZIONE_RINull = value;
			}
		}

		/// <summary>
		/// Numero esame commissione
		/// </summary>
		public System.String NUMERO_ESAME
		{
			get
			{
				if(IsNUMERO_ESAMENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_ESAME;
			}
			set
			{
				_nUMERO_ESAMENull = false;
				_nUMERO_ESAME = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_ESAMENull
		{
			get
			{
				return _nUMERO_ESAMENull;
			}
			set
			{
				_nUMERO_ESAMENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_ESAMESafe
		{
			get
			{
				if (IsNUMERO_ESAMENull)
					return System.String.Empty;
				return NUMERO_ESAME;
			}
		}

		/// <summary>
		/// Data esame commissione
		/// </summary>
		public System.DateTime DATA_ESAME
		{
			get
			{
				if(IsDATA_ESAMENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ESAME;
			}
			set
			{
				_dATA_ESAMENull = false;
				_dATA_ESAME = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ESAMENull
		{
			get
			{
				return _dATA_ESAMENull;
			}
			set
			{
				_dATA_ESAMENull = value;
			}
		}

		/// <summary>
		/// Data evasione ufficio
		/// </summary>
		public System.DateTime DATA_EVASIONE
		{
			get
			{
				if(IsDATA_EVASIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_EVASIONE;
			}
			set
			{
				_dATA_EVASIONENull = false;
				_dATA_EVASIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_EVASIONENull
		{
			get
			{
				return _dATA_EVASIONENull;
			}
			set
			{
				_dATA_EVASIONENull = value;
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
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_NOTAIO
		{
			get
			{
				if(IsIDOBJ_NOTAIONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_NOTAIO;
			}
			set
			{
				_iDOBJ_NOTAIONull = false;
				_iDOBJ_NOTAIO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_NOTAIONull
		{
			get
			{
				return _iDOBJ_NOTAIONull;
			}
			set
			{
				_iDOBJ_NOTAIONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_NOTAIOSafe
		{
			get
			{
				if (IsIDOBJ_NOTAIONull)
					return -1;
				return IDOBJ_NOTAIO;
			}
		}

	}
}