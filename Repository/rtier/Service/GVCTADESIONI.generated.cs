//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTADESIONI
	/// </summary>
	public partial class GVCTADESIONI
	{
		private System.Int32 _iDOBJ;
		private System.DateTime _dATA_INIZIO_ADESIONE;
		private System.Int32 _rEVISORE;
		private System.Int32 _iDOBJ_ASSOCIAZIONE;
		private System.Int32 _iDOBJ_REGISTRO;
		private System.DateTime _dATA_ESAME_INIZIO;
		private System.Boolean _dATA_ESAME_INIZIONull = true;
		private System.DateTime _dATA_FINE_ADESIONE;
		private System.Boolean _dATA_FINE_ADESIONENull = true;
		private System.DateTime _dATA_ESAME_FINE;
		private System.Boolean _dATA_ESAME_FINENull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTADESIONI(){}

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
		/// Data decorrenza adesione
		/// The field is mandatory.
		/// </summary>
		public System.DateTime DATA_INIZIO_ADESIONE
		{
			get
			{
				return _dATA_INIZIO_ADESIONE;
			}
			set
			{
				_dATA_INIZIO_ADESIONE = value;
			}
		}

		/// <summary>
		/// 1= è anche organo revisore
		/// The field is mandatory.
		/// </summary>
		public System.Int32 REVISORE
		{
			get
			{
				return _rEVISORE;
			}
			set
			{
				_rEVISORE = value;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_ASSOCIAZIONE
		{
			get
			{
				return _iDOBJ_ASSOCIAZIONE;
			}
			set
			{
				_iDOBJ_ASSOCIAZIONE = value;
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
		/// Data esame commissione inizio adesione
		/// </summary>
		public System.DateTime DATA_ESAME_INIZIO
		{
			get
			{
				if(IsDATA_ESAME_INIZIONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ESAME_INIZIO;
			}
			set
			{
				_dATA_ESAME_INIZIONull = false;
				_dATA_ESAME_INIZIO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ESAME_INIZIONull
		{
			get
			{
				return _dATA_ESAME_INIZIONull;
			}
			set
			{
				_dATA_ESAME_INIZIONull = value;
			}
		}

		/// <summary>
		/// Data fine adesione
		/// </summary>
		public System.DateTime DATA_FINE_ADESIONE
		{
			get
			{
				if(IsDATA_FINE_ADESIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_FINE_ADESIONE;
			}
			set
			{
				_dATA_FINE_ADESIONENull = false;
				_dATA_FINE_ADESIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_FINE_ADESIONENull
		{
			get
			{
				return _dATA_FINE_ADESIONENull;
			}
			set
			{
				_dATA_FINE_ADESIONENull = value;
			}
		}

		/// <summary>
		/// Data esame commissione fine adesione
		/// </summary>
		public System.DateTime DATA_ESAME_FINE
		{
			get
			{
				if(IsDATA_ESAME_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ESAME_FINE;
			}
			set
			{
				_dATA_ESAME_FINENull = false;
				_dATA_ESAME_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ESAME_FINENull
		{
			get
			{
				return _dATA_ESAME_FINENull;
			}
			set
			{
				_dATA_ESAME_FINENull = value;
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