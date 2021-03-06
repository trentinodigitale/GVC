//
//Generated by DELTADATOR\gs0445 at 27/07/2009 16.10.08
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCVRICERCAFALLIMENTI
	/// </summary>
	public partial class GVCVRICERCAFALLIMENTI
	{
		private System.String _s_DENOMINAZIONE;
		private System.Boolean _s_DENOMINAZIONENull = true;
		private System.Int32 _s_IDOBJ;
		private System.Int32 _r_IDOBJ;
		private System.Boolean _r_IDOBJNull = true;
		private System.String _r_NUMERO_REA;
		private System.Boolean _r_NUMERO_REANull = true;
		private System.Int32 _r_IDOBJ_STATO;
		private System.Boolean _r_IDOBJ_STATONull = true;
		private System.DateTime _fALL_DATA_SENTENZA;
		private System.DateTime _fALL_DATA_FINE;
		private System.Boolean _fALL_DATA_FINENull = true;
		private System.Int32 _fALL_ESITO;
		private System.Boolean _fALL_ESITONull = true;
		private System.String _fALL_TRIBUNALE;
		private System.Boolean _fALL_TRIBUNALENull = true;
		private System.Int32 _fALL_IDOBJ_CURATORE;
		private System.Boolean _fALL_IDOBJ_CURATORENull = true;
		private System.String _sGG_DESCRIZIONE;
		private System.Boolean _sGG_DESCRIZIONENull = true;
		private System.String _aDESIONE_ASSOCIAZIONE;
		private System.Boolean _aDESIONE_ASSOCIAZIONENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCVRICERCAFALLIMENTI(){}

		/// <summary>
		/// Value of field S_DENOMINAZIONE
		/// </summary>
		public System.String S_DENOMINAZIONE
		{
			get
			{
				if(IsS_DENOMINAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _s_DENOMINAZIONE;
			}
			set
			{
				_s_DENOMINAZIONENull = false;
				_s_DENOMINAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsS_DENOMINAZIONENull
		{
			get
			{
				return _s_DENOMINAZIONENull;
			}
			set
			{
				_s_DENOMINAZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String S_DENOMINAZIONESafe
		{
			get
			{
				if (IsS_DENOMINAZIONENull)
					return System.String.Empty;
				return S_DENOMINAZIONE;
			}
		}

		/// <summary>
		/// Value of field S_IDOBJ
		/// The field is mandatory.
		/// </summary>
		public System.Int32 S_IDOBJ
		{
			get
			{
				return _s_IDOBJ;
			}
			set
			{
				_s_IDOBJ = value;
			}
		}

		/// <summary>
		/// Value of field R_IDOBJ
		/// </summary>
		public System.Int32 R_IDOBJ
		{
			get
			{
				if(IsR_IDOBJNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _r_IDOBJ;
			}
			set
			{
				_r_IDOBJNull = false;
				_r_IDOBJ = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsR_IDOBJNull
		{
			get
			{
				return _r_IDOBJNull;
			}
			set
			{
				_r_IDOBJNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 R_IDOBJSafe
		{
			get
			{
				if (IsR_IDOBJNull)
					return -1;
				return R_IDOBJ;
			}
		}

		/// <summary>
		/// Value of field R_NUMERO_REA
		/// </summary>
		public System.String R_NUMERO_REA
		{
			get
			{
				if(IsR_NUMERO_REANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _r_NUMERO_REA;
			}
			set
			{
				_r_NUMERO_REANull = false;
				_r_NUMERO_REA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsR_NUMERO_REANull
		{
			get
			{
				return _r_NUMERO_REANull;
			}
			set
			{
				_r_NUMERO_REANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String R_NUMERO_REASafe
		{
			get
			{
				if (IsR_NUMERO_REANull)
					return System.String.Empty;
				return R_NUMERO_REA;
			}
		}

		/// <summary>
		/// Value of field R_IDOBJ_STATO
		/// </summary>
		public System.Int32 R_IDOBJ_STATO
		{
			get
			{
				if(IsR_IDOBJ_STATONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _r_IDOBJ_STATO;
			}
			set
			{
				_r_IDOBJ_STATONull = false;
				_r_IDOBJ_STATO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsR_IDOBJ_STATONull
		{
			get
			{
				return _r_IDOBJ_STATONull;
			}
			set
			{
				_r_IDOBJ_STATONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 R_IDOBJ_STATOSafe
		{
			get
			{
				if (IsR_IDOBJ_STATONull)
					return -1;
				return R_IDOBJ_STATO;
			}
		}

		/// <summary>
		/// Value of field FALL_DATA_SENTENZA
		/// The field is mandatory.
		/// </summary>
		public System.DateTime FALL_DATA_SENTENZA
		{
			get
			{
				return _fALL_DATA_SENTENZA;
			}
			set
			{
				_fALL_DATA_SENTENZA = value;
			}
		}

		/// <summary>
		/// Value of field FALL_DATA_FINE
		/// </summary>
		public System.DateTime FALL_DATA_FINE
		{
			get
			{
				if(IsFALL_DATA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fALL_DATA_FINE;
			}
			set
			{
				_fALL_DATA_FINENull = false;
				_fALL_DATA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFALL_DATA_FINENull
		{
			get
			{
				return _fALL_DATA_FINENull;
			}
			set
			{
				_fALL_DATA_FINENull = value;
			}
		}

		/// <summary>
		/// Value of field FALL_ESITO
		/// </summary>
		public System.Int32 FALL_ESITO
		{
			get
			{
				if(IsFALL_ESITONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fALL_ESITO;
			}
			set
			{
				_fALL_ESITONull = false;
				_fALL_ESITO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFALL_ESITONull
		{
			get
			{
				return _fALL_ESITONull;
			}
			set
			{
				_fALL_ESITONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 FALL_ESITOSafe
		{
			get
			{
				if (IsFALL_ESITONull)
					return -1;
				return FALL_ESITO;
			}
		}

		/// <summary>
		/// Value of field FALL_TRIBUNALE
		/// </summary>
		public System.String FALL_TRIBUNALE
		{
			get
			{
				if(IsFALL_TRIBUNALENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fALL_TRIBUNALE;
			}
			set
			{
				_fALL_TRIBUNALENull = false;
				_fALL_TRIBUNALE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFALL_TRIBUNALENull
		{
			get
			{
				return _fALL_TRIBUNALENull;
			}
			set
			{
				_fALL_TRIBUNALENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String FALL_TRIBUNALESafe
		{
			get
			{
				if (IsFALL_TRIBUNALENull)
					return System.String.Empty;
				return FALL_TRIBUNALE;
			}
		}

		/// <summary>
		/// Value of field FALL_IDOBJ_CURATORE
		/// </summary>
		public System.Int32 FALL_IDOBJ_CURATORE
		{
			get
			{
				if(IsFALL_IDOBJ_CURATORENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fALL_IDOBJ_CURATORE;
			}
			set
			{
				_fALL_IDOBJ_CURATORENull = false;
				_fALL_IDOBJ_CURATORE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFALL_IDOBJ_CURATORENull
		{
			get
			{
				return _fALL_IDOBJ_CURATORENull;
			}
			set
			{
				_fALL_IDOBJ_CURATORENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 FALL_IDOBJ_CURATORESafe
		{
			get
			{
				if (IsFALL_IDOBJ_CURATORENull)
					return -1;
				return FALL_IDOBJ_CURATORE;
			}
		}

		/// <summary>
		/// Value of field SGG_DESCRIZIONE
		/// </summary>
		public System.String SGG_DESCRIZIONE
		{
			get
			{
				if(IsSGG_DESCRIZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sGG_DESCRIZIONE;
			}
			set
			{
				_sGG_DESCRIZIONENull = false;
				_sGG_DESCRIZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSGG_DESCRIZIONENull
		{
			get
			{
				return _sGG_DESCRIZIONENull;
			}
			set
			{
				_sGG_DESCRIZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String SGG_DESCRIZIONESafe
		{
			get
			{
				if (IsSGG_DESCRIZIONENull)
					return System.String.Empty;
				return SGG_DESCRIZIONE;
			}
		}

		/// <summary>
		/// Value of field ADESIONE_ASSOCIAZIONE
		/// </summary>
		public System.String ADESIONE_ASSOCIAZIONE
		{
			get
			{
				if(IsADESIONE_ASSOCIAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aDESIONE_ASSOCIAZIONE;
			}
			set
			{
				_aDESIONE_ASSOCIAZIONENull = false;
				_aDESIONE_ASSOCIAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsADESIONE_ASSOCIAZIONENull
		{
			get
			{
				return _aDESIONE_ASSOCIAZIONENull;
			}
			set
			{
				_aDESIONE_ASSOCIAZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String ADESIONE_ASSOCIAZIONESafe
		{
			get
			{
				if (IsADESIONE_ASSOCIAZIONENull)
					return System.String.Empty;
				return ADESIONE_ASSOCIAZIONE;
			}
		}

	}
}