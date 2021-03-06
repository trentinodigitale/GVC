//
//Generated by DELTADATOR\GS0445 at 06/04/2010 11.51.23
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCVRICERCAMODIFICHE_STAT
	/// </summary>
	public partial class GVCVRICERCAMODIFICHE_STAT
	{
		private System.String _s_DENOMINAZIONE;
		private System.Boolean _s_DENOMINAZIONENull = true;
		private System.Int32 _s_IDOBJ;
		private System.Boolean _s_IDOBJNull = true;
		private System.Int32 _r_IDOBJ;
		private System.Boolean _r_IDOBJNull = true;
		private System.String _r_NUMERO_REA;
		private System.Boolean _r_NUMERO_REANull = true;
		private System.Int32 _r_IDOBJ_STATO;
		private System.Boolean _r_IDOBJ_STATONull = true;
		private System.DateTime _r_BILANCIO_ESERCIZIO_AL;
		private System.Boolean _r_BILANCIO_ESERCIZIO_ALNull = true;
		private System.Int32 _aSS_IDOBJ;
		private System.Boolean _aSS_IDOBJNull = true;
		private System.Int32 _aSS_IDOBJ_TIPO_ASSEMBLEA;
		private System.Boolean _aSS_IDOBJ_TIPO_ASSEMBLEANull = true;
		private System.DateTime _aSS_DATA_ASSEMBLEA;
		private System.Boolean _aSS_DATA_ASSEMBLEANull = true;
		private System.String _aSS_CONTENUTO;
		private System.Boolean _aSS_CONTENUTONull = true;
		private System.Int32 _mODSTAT_IDOBJ;
		private System.Int32 _mODSTAT_IDOBJ_TIPO_MODIFICA;
		private System.String _mODSTAT_VECCHIA_DENOMINAZIONE;
		private System.Boolean _mODSTAT_VECCHIA_DENOMINAZIONENull = true;
		private System.Int32 _cOLL_IDOBJ_SOGGETTO;
		private System.Boolean _cOLL_IDOBJ_SOGGETTONull = true;
		private System.String _aDESIONE_ASSOCIAZIONE;
		private System.Boolean _aDESIONE_ASSOCIAZIONENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCVRICERCAMODIFICHE_STAT(){}

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
		/// </summary>
		public System.Int32 S_IDOBJ
		{
			get
			{
				if(IsS_IDOBJNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _s_IDOBJ;
			}
			set
			{
				_s_IDOBJNull = false;
				_s_IDOBJ = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsS_IDOBJNull
		{
			get
			{
				return _s_IDOBJNull;
			}
			set
			{
				_s_IDOBJNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 S_IDOBJSafe
		{
			get
			{
				if (IsS_IDOBJNull)
					return -1;
				return S_IDOBJ;
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
		/// Value of field R_BILANCIO_ESERCIZIO_AL
		/// </summary>
		public System.DateTime R_BILANCIO_ESERCIZIO_AL
		{
			get
			{
				if(IsR_BILANCIO_ESERCIZIO_ALNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _r_BILANCIO_ESERCIZIO_AL;
			}
			set
			{
				_r_BILANCIO_ESERCIZIO_ALNull = false;
				_r_BILANCIO_ESERCIZIO_AL = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsR_BILANCIO_ESERCIZIO_ALNull
		{
			get
			{
				return _r_BILANCIO_ESERCIZIO_ALNull;
			}
			set
			{
				_r_BILANCIO_ESERCIZIO_ALNull = value;
			}
		}

		/// <summary>
		/// Value of field ASS_IDOBJ
		/// </summary>
		public System.Int32 ASS_IDOBJ
		{
			get
			{
				if(IsASS_IDOBJNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aSS_IDOBJ;
			}
			set
			{
				_aSS_IDOBJNull = false;
				_aSS_IDOBJ = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsASS_IDOBJNull
		{
			get
			{
				return _aSS_IDOBJNull;
			}
			set
			{
				_aSS_IDOBJNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 ASS_IDOBJSafe
		{
			get
			{
				if (IsASS_IDOBJNull)
					return -1;
				return ASS_IDOBJ;
			}
		}

		/// <summary>
		/// Value of field ASS_IDOBJ_TIPO_ASSEMBLEA
		/// </summary>
		public System.Int32 ASS_IDOBJ_TIPO_ASSEMBLEA
		{
			get
			{
				if(IsASS_IDOBJ_TIPO_ASSEMBLEANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aSS_IDOBJ_TIPO_ASSEMBLEA;
			}
			set
			{
				_aSS_IDOBJ_TIPO_ASSEMBLEANull = false;
				_aSS_IDOBJ_TIPO_ASSEMBLEA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsASS_IDOBJ_TIPO_ASSEMBLEANull
		{
			get
			{
				return _aSS_IDOBJ_TIPO_ASSEMBLEANull;
			}
			set
			{
				_aSS_IDOBJ_TIPO_ASSEMBLEANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 ASS_IDOBJ_TIPO_ASSEMBLEASafe
		{
			get
			{
				if (IsASS_IDOBJ_TIPO_ASSEMBLEANull)
					return -1;
				return ASS_IDOBJ_TIPO_ASSEMBLEA;
			}
		}

		/// <summary>
		/// Value of field ASS_DATA_ASSEMBLEA
		/// </summary>
		public System.DateTime ASS_DATA_ASSEMBLEA
		{
			get
			{
				if(IsASS_DATA_ASSEMBLEANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aSS_DATA_ASSEMBLEA;
			}
			set
			{
				_aSS_DATA_ASSEMBLEANull = false;
				_aSS_DATA_ASSEMBLEA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsASS_DATA_ASSEMBLEANull
		{
			get
			{
				return _aSS_DATA_ASSEMBLEANull;
			}
			set
			{
				_aSS_DATA_ASSEMBLEANull = value;
			}
		}

		/// <summary>
		/// Value of field ASS_CONTENUTO
		/// </summary>
		public System.String ASS_CONTENUTO
		{
			get
			{
				if(IsASS_CONTENUTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aSS_CONTENUTO;
			}
			set
			{
				_aSS_CONTENUTONull = false;
				_aSS_CONTENUTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsASS_CONTENUTONull
		{
			get
			{
				return _aSS_CONTENUTONull;
			}
			set
			{
				_aSS_CONTENUTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String ASS_CONTENUTOSafe
		{
			get
			{
				if (IsASS_CONTENUTONull)
					return System.String.Empty;
				return ASS_CONTENUTO;
			}
		}

		/// <summary>
		/// Value of field MODSTAT_IDOBJ
		/// The field is mandatory.
		/// </summary>
		public System.Int32 MODSTAT_IDOBJ
		{
			get
			{
				return _mODSTAT_IDOBJ;
			}
			set
			{
				_mODSTAT_IDOBJ = value;
			}
		}

		/// <summary>
		/// Value of field MODSTAT_IDOBJ_TIPO_MODIFICA
		/// The field is mandatory.
		/// </summary>
		public System.Int32 MODSTAT_IDOBJ_TIPO_MODIFICA
		{
			get
			{
				return _mODSTAT_IDOBJ_TIPO_MODIFICA;
			}
			set
			{
				_mODSTAT_IDOBJ_TIPO_MODIFICA = value;
			}
		}

		/// <summary>
		/// Value of field MODSTAT_VECCHIA_DENOMINAZIONE
		/// </summary>
		public System.String MODSTAT_VECCHIA_DENOMINAZIONE
		{
			get
			{
				if(IsMODSTAT_VECCHIA_DENOMINAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _mODSTAT_VECCHIA_DENOMINAZIONE;
			}
			set
			{
				_mODSTAT_VECCHIA_DENOMINAZIONENull = false;
				_mODSTAT_VECCHIA_DENOMINAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsMODSTAT_VECCHIA_DENOMINAZIONENull
		{
			get
			{
				return _mODSTAT_VECCHIA_DENOMINAZIONENull;
			}
			set
			{
				_mODSTAT_VECCHIA_DENOMINAZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String MODSTAT_VECCHIA_DENOMINAZIONESafe
		{
			get
			{
				if (IsMODSTAT_VECCHIA_DENOMINAZIONENull)
					return System.String.Empty;
				return MODSTAT_VECCHIA_DENOMINAZIONE;
			}
		}

		/// <summary>
		/// Value of field COLL_IDOBJ_SOGGETTO
		/// </summary>
		public System.Int32 COLL_IDOBJ_SOGGETTO
		{
			get
			{
				if(IsCOLL_IDOBJ_SOGGETTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cOLL_IDOBJ_SOGGETTO;
			}
			set
			{
				_cOLL_IDOBJ_SOGGETTONull = false;
				_cOLL_IDOBJ_SOGGETTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCOLL_IDOBJ_SOGGETTONull
		{
			get
			{
				return _cOLL_IDOBJ_SOGGETTONull;
			}
			set
			{
				_cOLL_IDOBJ_SOGGETTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 COLL_IDOBJ_SOGGETTOSafe
		{
			get
			{
				if (IsCOLL_IDOBJ_SOGGETTONull)
					return -1;
				return COLL_IDOBJ_SOGGETTO;
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