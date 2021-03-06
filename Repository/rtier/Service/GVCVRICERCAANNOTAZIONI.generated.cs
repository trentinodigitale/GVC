//
//Generated by DELTADATOR\gs0445 at 27/07/2009 16.10.08
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCVRICERCAANNOTAZIONI
	/// </summary>
	public partial class GVCVRICERCAANNOTAZIONI
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
		private System.DateTime _aNN_DATA_ANNOTAZIONE;
		private System.Int32 _aNN_IDOBJ_TIPO_NOTA;
		private System.Int32 _aNN_RISERVATA;
		private System.Boolean _aNN_RISERVATANull = true;
		private System.String _aNN_DESCRIZIONE;
		private System.Boolean _aNN_DESCRIZIONENull = true;
		private System.Int32 _aNN_EVASA;
		private System.Boolean _aNN_EVASANull = true;
		private System.DateTime _aNN_DATA_SCADENZA;
		private System.Boolean _aNN_DATA_SCADENZANull = true;
		private System.DateTime _aNN_DATA_EVASIONE;
		private System.Boolean _aNN_DATA_EVASIONENull = true;
		private System.String _aDESIONE_ASSOCIAZIONE;
		private System.Boolean _aDESIONE_ASSOCIAZIONENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCVRICERCAANNOTAZIONI(){}

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
		/// Value of field ANN_DATA_ANNOTAZIONE
		/// The field is mandatory.
		/// </summary>
		public System.DateTime ANN_DATA_ANNOTAZIONE
		{
			get
			{
				return _aNN_DATA_ANNOTAZIONE;
			}
			set
			{
				_aNN_DATA_ANNOTAZIONE = value;
			}
		}

		/// <summary>
		/// Value of field ANN_IDOBJ_TIPO_NOTA
		/// The field is mandatory.
		/// </summary>
		public System.Int32 ANN_IDOBJ_TIPO_NOTA
		{
			get
			{
				return _aNN_IDOBJ_TIPO_NOTA;
			}
			set
			{
				_aNN_IDOBJ_TIPO_NOTA = value;
			}
		}

		/// <summary>
		/// Value of field ANN_RISERVATA
		/// </summary>
		public System.Int32 ANN_RISERVATA
		{
			get
			{
				if(IsANN_RISERVATANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aNN_RISERVATA;
			}
			set
			{
				_aNN_RISERVATANull = false;
				_aNN_RISERVATA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsANN_RISERVATANull
		{
			get
			{
				return _aNN_RISERVATANull;
			}
			set
			{
				_aNN_RISERVATANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 ANN_RISERVATASafe
		{
			get
			{
				if (IsANN_RISERVATANull)
					return -1;
				return ANN_RISERVATA;
			}
		}

		/// <summary>
		/// Value of field ANN_DESCRIZIONE
		/// </summary>
		public System.String ANN_DESCRIZIONE
		{
			get
			{
				if(IsANN_DESCRIZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aNN_DESCRIZIONE;
			}
			set
			{
				_aNN_DESCRIZIONENull = false;
				_aNN_DESCRIZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsANN_DESCRIZIONENull
		{
			get
			{
				return _aNN_DESCRIZIONENull;
			}
			set
			{
				_aNN_DESCRIZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String ANN_DESCRIZIONESafe
		{
			get
			{
				if (IsANN_DESCRIZIONENull)
					return System.String.Empty;
				return ANN_DESCRIZIONE;
			}
		}

		/// <summary>
		/// Value of field ANN_EVASA
		/// </summary>
		public System.Int32 ANN_EVASA
		{
			get
			{
				if(IsANN_EVASANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aNN_EVASA;
			}
			set
			{
				_aNN_EVASANull = false;
				_aNN_EVASA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsANN_EVASANull
		{
			get
			{
				return _aNN_EVASANull;
			}
			set
			{
				_aNN_EVASANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 ANN_EVASASafe
		{
			get
			{
				if (IsANN_EVASANull)
					return -1;
				return ANN_EVASA;
			}
		}

		/// <summary>
		/// Value of field ANN_DATA_SCADENZA
		/// </summary>
		public System.DateTime ANN_DATA_SCADENZA
		{
			get
			{
				if(IsANN_DATA_SCADENZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aNN_DATA_SCADENZA;
			}
			set
			{
				_aNN_DATA_SCADENZANull = false;
				_aNN_DATA_SCADENZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsANN_DATA_SCADENZANull
		{
			get
			{
				return _aNN_DATA_SCADENZANull;
			}
			set
			{
				_aNN_DATA_SCADENZANull = value;
			}
		}

		/// <summary>
		/// Value of field ANN_DATA_EVASIONE
		/// </summary>
		public System.DateTime ANN_DATA_EVASIONE
		{
			get
			{
				if(IsANN_DATA_EVASIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _aNN_DATA_EVASIONE;
			}
			set
			{
				_aNN_DATA_EVASIONENull = false;
				_aNN_DATA_EVASIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsANN_DATA_EVASIONENull
		{
			get
			{
				return _aNN_DATA_EVASIONENull;
			}
			set
			{
				_aNN_DATA_EVASIONENull = value;
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