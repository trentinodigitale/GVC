//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.14
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTRELAZIONI_SEMESTRALI
	/// </summary>
	public partial class GVCTRELAZIONI_SEMESTRALI
	{
		private System.Int32 _iDOBJ;
		private System.DateTime _dATA_RELAZIONE;
		private System.Int32 _iDOBJ_LIQUIDAZIONE;
		private System.DateTime _dATA_PARERE;
		private System.Boolean _dATA_PARERENull = true;
		private System.DateTime _dATA_ESAME;
		private System.Boolean _dATA_ESAMENull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTRELAZIONI_SEMESTRALI(){}

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
		/// Data della relazione
		/// The field is mandatory.
		/// </summary>
		public System.DateTime DATA_RELAZIONE
		{
			get
			{
				return _dATA_RELAZIONE;
			}
			set
			{
				_dATA_RELAZIONE = value;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_LIQUIDAZIONE
		{
			get
			{
				return _iDOBJ_LIQUIDAZIONE;
			}
			set
			{
				_iDOBJ_LIQUIDAZIONE = value;
			}
		}

		/// <summary>
		/// Data parere commissione
		/// </summary>
		public System.DateTime DATA_PARERE
		{
			get
			{
				if(IsDATA_PARERENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_PARERE;
			}
			set
			{
				_dATA_PARERENull = false;
				_dATA_PARERE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_PARERENull
		{
			get
			{
				return _dATA_PARERENull;
			}
			set
			{
				_dATA_PARERENull = value;
			}
		}

		/// <summary>
		/// Data esame ufficio
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

	}
}