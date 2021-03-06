//
//Generated by DELTADATOR\gs0445 at 27/07/2009 16.10.08
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCVRICERCASANZIONI
	/// </summary>
	public partial class GVCVRICERCASANZIONI
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
		private System.DateTime _sAN_DATA_RILIEVO_INFRAZIONE;
		private System.Int32 _sAN_IDOBJ_TIPO_TRASGRESSIONE;
		private System.Int32 _sAN_IDOBJ_LEGGE_TRASGRESSIONE;
		private System.Boolean _sAN_IDOBJ_LEGGE_TRASGRESSIONENull = true;
		private System.DateTime _sAN_DATA_INFRAZIONE;
		private System.Boolean _sAN_DATA_INFRAZIONENull = true;
		private System.DateTime _sAN_DATA_PAG_OBLAZIONE;
		private System.Boolean _sAN_DATA_PAG_OBLAZIONENull = true;
		private System.DateTime _sAN_DATA_SCRITTI_DIFENSIVI;
		private System.Boolean _sAN_DATA_SCRITTI_DIFENSIVINull = true;
		private System.DateTime _sAN_DATA_AUDIZIONE;
		private System.Boolean _sAN_DATA_AUDIZIONENull = true;
		private System.Double _sAN_IMPORTO_ORDINANZA;
		private System.Boolean _sAN_IMPORTO_ORDINANZANull = true;
		private System.DateTime _sAN_DATA_RICORSO;
		private System.Boolean _sAN_DATA_RICORSONull = true;
		private System.Int32 _sAN_IDOBJ_GIUDICE;
		private System.Boolean _sAN_IDOBJ_GIUDICENull = true;
		private System.DateTime _sAN_DATA_ARCHIVIAZIONE;
		private System.Boolean _sAN_DATA_ARCHIVIAZIONENull = true;
		private System.DateTime _sAN_DATA_PAGAMENTO;
		private System.Boolean _sAN_DATA_PAGAMENTONull = true;
		private System.String _aDESIONE_ASSOCIAZIONE;
		private System.Boolean _aDESIONE_ASSOCIAZIONENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCVRICERCASANZIONI(){}

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
		/// Value of field SAN_DATA_RILIEVO_INFRAZIONE
		/// The field is mandatory.
		/// </summary>
		public System.DateTime SAN_DATA_RILIEVO_INFRAZIONE
		{
			get
			{
				return _sAN_DATA_RILIEVO_INFRAZIONE;
			}
			set
			{
				_sAN_DATA_RILIEVO_INFRAZIONE = value;
			}
		}

		/// <summary>
		/// Value of field SAN_IDOBJ_TIPO_TRASGRESSIONE
		/// The field is mandatory.
		/// </summary>
		public System.Int32 SAN_IDOBJ_TIPO_TRASGRESSIONE
		{
			get
			{
				return _sAN_IDOBJ_TIPO_TRASGRESSIONE;
			}
			set
			{
				_sAN_IDOBJ_TIPO_TRASGRESSIONE = value;
			}
		}

		/// <summary>
		/// Value of field SAN_IDOBJ_LEGGE_TRASGRESSIONE
		/// </summary>
		public System.Int32 SAN_IDOBJ_LEGGE_TRASGRESSIONE
		{
			get
			{
				if(IsSAN_IDOBJ_LEGGE_TRASGRESSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_IDOBJ_LEGGE_TRASGRESSIONE;
			}
			set
			{
				_sAN_IDOBJ_LEGGE_TRASGRESSIONENull = false;
				_sAN_IDOBJ_LEGGE_TRASGRESSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_IDOBJ_LEGGE_TRASGRESSIONENull
		{
			get
			{
				return _sAN_IDOBJ_LEGGE_TRASGRESSIONENull;
			}
			set
			{
				_sAN_IDOBJ_LEGGE_TRASGRESSIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 SAN_IDOBJ_LEGGE_TRASGRESSIONESafe
		{
			get
			{
				if (IsSAN_IDOBJ_LEGGE_TRASGRESSIONENull)
					return -1;
				return SAN_IDOBJ_LEGGE_TRASGRESSIONE;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_INFRAZIONE
		/// </summary>
		public System.DateTime SAN_DATA_INFRAZIONE
		{
			get
			{
				if(IsSAN_DATA_INFRAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_INFRAZIONE;
			}
			set
			{
				_sAN_DATA_INFRAZIONENull = false;
				_sAN_DATA_INFRAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_INFRAZIONENull
		{
			get
			{
				return _sAN_DATA_INFRAZIONENull;
			}
			set
			{
				_sAN_DATA_INFRAZIONENull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_PAG_OBLAZIONE
		/// </summary>
		public System.DateTime SAN_DATA_PAG_OBLAZIONE
		{
			get
			{
				if(IsSAN_DATA_PAG_OBLAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_PAG_OBLAZIONE;
			}
			set
			{
				_sAN_DATA_PAG_OBLAZIONENull = false;
				_sAN_DATA_PAG_OBLAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_PAG_OBLAZIONENull
		{
			get
			{
				return _sAN_DATA_PAG_OBLAZIONENull;
			}
			set
			{
				_sAN_DATA_PAG_OBLAZIONENull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_SCRITTI_DIFENSIVI
		/// </summary>
		public System.DateTime SAN_DATA_SCRITTI_DIFENSIVI
		{
			get
			{
				if(IsSAN_DATA_SCRITTI_DIFENSIVINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_SCRITTI_DIFENSIVI;
			}
			set
			{
				_sAN_DATA_SCRITTI_DIFENSIVINull = false;
				_sAN_DATA_SCRITTI_DIFENSIVI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_SCRITTI_DIFENSIVINull
		{
			get
			{
				return _sAN_DATA_SCRITTI_DIFENSIVINull;
			}
			set
			{
				_sAN_DATA_SCRITTI_DIFENSIVINull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_AUDIZIONE
		/// </summary>
		public System.DateTime SAN_DATA_AUDIZIONE
		{
			get
			{
				if(IsSAN_DATA_AUDIZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_AUDIZIONE;
			}
			set
			{
				_sAN_DATA_AUDIZIONENull = false;
				_sAN_DATA_AUDIZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_AUDIZIONENull
		{
			get
			{
				return _sAN_DATA_AUDIZIONENull;
			}
			set
			{
				_sAN_DATA_AUDIZIONENull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_IMPORTO_ORDINANZA
		/// </summary>
		public System.Double SAN_IMPORTO_ORDINANZA
		{
			get
			{
				if(IsSAN_IMPORTO_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_IMPORTO_ORDINANZA;
			}
			set
			{
				_sAN_IMPORTO_ORDINANZANull = false;
				_sAN_IMPORTO_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_IMPORTO_ORDINANZANull
		{
			get
			{
				return _sAN_IMPORTO_ORDINANZANull;
			}
			set
			{
				_sAN_IMPORTO_ORDINANZANull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_RICORSO
		/// </summary>
		public System.DateTime SAN_DATA_RICORSO
		{
			get
			{
				if(IsSAN_DATA_RICORSONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_RICORSO;
			}
			set
			{
				_sAN_DATA_RICORSONull = false;
				_sAN_DATA_RICORSO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_RICORSONull
		{
			get
			{
				return _sAN_DATA_RICORSONull;
			}
			set
			{
				_sAN_DATA_RICORSONull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_IDOBJ_GIUDICE
		/// </summary>
		public System.Int32 SAN_IDOBJ_GIUDICE
		{
			get
			{
				if(IsSAN_IDOBJ_GIUDICENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_IDOBJ_GIUDICE;
			}
			set
			{
				_sAN_IDOBJ_GIUDICENull = false;
				_sAN_IDOBJ_GIUDICE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_IDOBJ_GIUDICENull
		{
			get
			{
				return _sAN_IDOBJ_GIUDICENull;
			}
			set
			{
				_sAN_IDOBJ_GIUDICENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 SAN_IDOBJ_GIUDICESafe
		{
			get
			{
				if (IsSAN_IDOBJ_GIUDICENull)
					return -1;
				return SAN_IDOBJ_GIUDICE;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_ARCHIVIAZIONE
		/// </summary>
		public System.DateTime SAN_DATA_ARCHIVIAZIONE
		{
			get
			{
				if(IsSAN_DATA_ARCHIVIAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_ARCHIVIAZIONE;
			}
			set
			{
				_sAN_DATA_ARCHIVIAZIONENull = false;
				_sAN_DATA_ARCHIVIAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_ARCHIVIAZIONENull
		{
			get
			{
				return _sAN_DATA_ARCHIVIAZIONENull;
			}
			set
			{
				_sAN_DATA_ARCHIVIAZIONENull = value;
			}
		}

		/// <summary>
		/// Value of field SAN_DATA_PAGAMENTO
		/// </summary>
		public System.DateTime SAN_DATA_PAGAMENTO
		{
			get
			{
				if(IsSAN_DATA_PAGAMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sAN_DATA_PAGAMENTO;
			}
			set
			{
				_sAN_DATA_PAGAMENTONull = false;
				_sAN_DATA_PAGAMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSAN_DATA_PAGAMENTONull
		{
			get
			{
				return _sAN_DATA_PAGAMENTONull;
			}
			set
			{
				_sAN_DATA_PAGAMENTONull = value;
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