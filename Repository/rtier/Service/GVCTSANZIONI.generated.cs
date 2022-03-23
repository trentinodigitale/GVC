//
//Generated by DELTADATOR\GS0445 at 17/07/2009 11.39.26
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTSANZIONI
	/// </summary>
	public partial class GVCTSANZIONI
	{
		private System.Int32 _iDOBJ;
		private System.DateTime _dATA_RILIEVO_INFRAZIONE;
		private System.Int32 _iDOBJ_TIPO_TRASGRESSIONE;
		private System.Int32 _iDOBJ_REGISTRO;
		private System.Int32 _iDOBJ_LEGGE_TRASGRESSIONE;
		private System.Boolean _iDOBJ_LEGGE_TRASGRESSIONENull = true;
		private System.DateTime _dATA_INFRAZIONE;
		private System.Boolean _dATA_INFRAZIONENull = true;
		private System.DateTime _dATA_NOTIFICA_INFRAZIONE;
		private System.Boolean _dATA_NOTIFICA_INFRAZIONENull = true;
		private System.DateTime _dATA_RACCOMANDATA;
		private System.Boolean _dATA_RACCOMANDATANull = true;
		private System.DateTime _dATA_SCADENZA_PAGAMENTO;
		private System.Boolean _dATA_SCADENZA_PAGAMENTONull = true;
		private System.Double _iMPORTO_SANZIONE;
		private System.Boolean _iMPORTO_SANZIONENull = true;
		private System.String _nUMERO_RECIDIVA;
		private System.Boolean _nUMERO_RECIDIVANull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;
		private System.DateTime _dATA_PAG_OBLAZIONE;
		private System.Boolean _dATA_PAG_OBLAZIONENull = true;
		private System.Double _iMPORTO_OBLAZIONE;
		private System.Boolean _iMPORTO_OBLAZIONENull = true;
		private System.DateTime _dATA_SCRITTI_DIFENSIVI;
		private System.Boolean _dATA_SCRITTI_DIFENSIVINull = true;
		private System.DateTime _dATA_AUDIZIONE;
		private System.Boolean _dATA_AUDIZIONENull = true;
		private System.String _nOTE_CONTRADDITTORIO;
		private System.Boolean _nOTE_CONTRADDITTORIONull = true;
		private System.String _nUMERO_ORDINANZA;
		private System.Boolean _nUMERO_ORDINANZANull = true;
		private System.DateTime _dATA_ORDINANZA;
		private System.Boolean _dATA_ORDINANZANull = true;
		private System.Double _iMPORTO_ORDINANZA;
		private System.Boolean _iMPORTO_ORDINANZANull = true;
		private System.DateTime _dATA_NOTIFICA_ORDINANZA;
		private System.Boolean _dATA_NOTIFICA_ORDINANZANull = true;
		private System.DateTime _dATA_RACCOMANDATA_ORDINANZA;
		private System.Boolean _dATA_RACCOMANDATA_ORDINANZANull = true;
		private System.DateTime _dATA_SCADENZA_PAG_ORDINANZA;
		private System.Boolean _dATA_SCADENZA_PAG_ORDINANZANull = true;
		private System.String _nUMERO_ARCHIVIAZIONE;
		private System.Boolean _nUMERO_ARCHIVIAZIONENull = true;
		private System.DateTime _dATA_ARCHIVIAZIONE;
		private System.Boolean _dATA_ARCHIVIAZIONENull = true;
		private System.String _nOTE_INGIUNZIONE;
		private System.Boolean _nOTE_INGIUNZIONENull = true;
		private System.DateTime _dATA_RICORSO;
		private System.Boolean _dATA_RICORSONull = true;
		private System.Int32 _iDOBJ_GIUDICE;
		private System.Boolean _iDOBJ_GIUDICENull = true;
		private System.DateTime _dATA_SENTENZA_RICORSO;
		private System.Boolean _dATA_SENTENZA_RICORSONull = true;
		private System.DateTime _dATA_DEPOSITO_RICORSO;
		private System.Boolean _dATA_DEPOSITO_RICORSONull = true;
		private System.String _eSITO_RICORSO;
		private System.Boolean _eSITO_RICORSONull = true;
		private System.DateTime _dATA_PAGAMENTO;
		private System.Boolean _dATA_PAGAMENTONull = true;
		private System.Double _iMPORTO_PAGAMENTO;
		private System.Boolean _iMPORTO_PAGAMENTONull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTSANZIONI(){}

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
		/// Data rilievo infrazione
		/// The field is mandatory.
		/// </summary>
		public System.DateTime DATA_RILIEVO_INFRAZIONE
		{
			get
			{
				return _dATA_RILIEVO_INFRAZIONE;
			}
			set
			{
				_dATA_RILIEVO_INFRAZIONE = value;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_TIPO_TRASGRESSIONE
		{
			get
			{
				return _iDOBJ_TIPO_TRASGRESSIONE;
			}
			set
			{
				_iDOBJ_TIPO_TRASGRESSIONE = value;
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
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_LEGGE_TRASGRESSIONE
		{
			get
			{
				if(IsIDOBJ_LEGGE_TRASGRESSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_LEGGE_TRASGRESSIONE;
			}
			set
			{
				_iDOBJ_LEGGE_TRASGRESSIONENull = false;
				_iDOBJ_LEGGE_TRASGRESSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_LEGGE_TRASGRESSIONENull
		{
			get
			{
				return _iDOBJ_LEGGE_TRASGRESSIONENull;
			}
			set
			{
				_iDOBJ_LEGGE_TRASGRESSIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_LEGGE_TRASGRESSIONESafe
		{
			get
			{
				if (IsIDOBJ_LEGGE_TRASGRESSIONENull)
					return -1;
				return IDOBJ_LEGGE_TRASGRESSIONE;
			}
		}

		/// <summary>
		/// Data infrazione
		/// </summary>
		public System.DateTime DATA_INFRAZIONE
		{
			get
			{
				if(IsDATA_INFRAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_INFRAZIONE;
			}
			set
			{
				_dATA_INFRAZIONENull = false;
				_dATA_INFRAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_INFRAZIONENull
		{
			get
			{
				return _dATA_INFRAZIONENull;
			}
			set
			{
				_dATA_INFRAZIONENull = value;
			}
		}

		/// <summary>
		/// Data notifica infrazione
		/// </summary>
		public System.DateTime DATA_NOTIFICA_INFRAZIONE
		{
			get
			{
				if(IsDATA_NOTIFICA_INFRAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_NOTIFICA_INFRAZIONE;
			}
			set
			{
				_dATA_NOTIFICA_INFRAZIONENull = false;
				_dATA_NOTIFICA_INFRAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_NOTIFICA_INFRAZIONENull
		{
			get
			{
				return _dATA_NOTIFICA_INFRAZIONENull;
			}
			set
			{
				_dATA_NOTIFICA_INFRAZIONENull = value;
			}
		}

		/// <summary>
		/// Data raccomandata
		/// </summary>
		public System.DateTime DATA_RACCOMANDATA
		{
			get
			{
				if(IsDATA_RACCOMANDATANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_RACCOMANDATA;
			}
			set
			{
				_dATA_RACCOMANDATANull = false;
				_dATA_RACCOMANDATA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_RACCOMANDATANull
		{
			get
			{
				return _dATA_RACCOMANDATANull;
			}
			set
			{
				_dATA_RACCOMANDATANull = value;
			}
		}

		/// <summary>
		/// Data scadenza pagamento
		/// </summary>
		public System.DateTime DATA_SCADENZA_PAGAMENTO
		{
			get
			{
				if(IsDATA_SCADENZA_PAGAMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_SCADENZA_PAGAMENTO;
			}
			set
			{
				_dATA_SCADENZA_PAGAMENTONull = false;
				_dATA_SCADENZA_PAGAMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_SCADENZA_PAGAMENTONull
		{
			get
			{
				return _dATA_SCADENZA_PAGAMENTONull;
			}
			set
			{
				_dATA_SCADENZA_PAGAMENTONull = value;
			}
		}

		/// <summary>
		/// Entità della sanzione
		/// </summary>
		public System.Double IMPORTO_SANZIONE
		{
			get
			{
				if(IsIMPORTO_SANZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iMPORTO_SANZIONE;
			}
			set
			{
				_iMPORTO_SANZIONENull = false;
				_iMPORTO_SANZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIMPORTO_SANZIONENull
		{
			get
			{
				return _iMPORTO_SANZIONENull;
			}
			set
			{
				_iMPORTO_SANZIONENull = value;
			}
		}

		/// <summary>
		/// Numero recidiva
		/// </summary>
		public System.String NUMERO_RECIDIVA
		{
			get
			{
				if(IsNUMERO_RECIDIVANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_RECIDIVA;
			}
			set
			{
				_nUMERO_RECIDIVANull = false;
				_nUMERO_RECIDIVA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_RECIDIVANull
		{
			get
			{
				return _nUMERO_RECIDIVANull;
			}
			set
			{
				_nUMERO_RECIDIVANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_RECIDIVASafe
		{
			get
			{
				if (IsNUMERO_RECIDIVANull)
					return System.String.Empty;
				return NUMERO_RECIDIVA;
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
		/// Data pagamento oblazione
		/// </summary>
		public System.DateTime DATA_PAG_OBLAZIONE
		{
			get
			{
				if(IsDATA_PAG_OBLAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_PAG_OBLAZIONE;
			}
			set
			{
				_dATA_PAG_OBLAZIONENull = false;
				_dATA_PAG_OBLAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_PAG_OBLAZIONENull
		{
			get
			{
				return _dATA_PAG_OBLAZIONENull;
			}
			set
			{
				_dATA_PAG_OBLAZIONENull = value;
			}
		}

		/// <summary>
		/// Importo oblazione
		/// </summary>
		public System.Double IMPORTO_OBLAZIONE
		{
			get
			{
				if(IsIMPORTO_OBLAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iMPORTO_OBLAZIONE;
			}
			set
			{
				_iMPORTO_OBLAZIONENull = false;
				_iMPORTO_OBLAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIMPORTO_OBLAZIONENull
		{
			get
			{
				return _iMPORTO_OBLAZIONENull;
			}
			set
			{
				_iMPORTO_OBLAZIONENull = value;
			}
		}

		/// <summary>
		/// Data scritti difensivi
		/// </summary>
		public System.DateTime DATA_SCRITTI_DIFENSIVI
		{
			get
			{
				if(IsDATA_SCRITTI_DIFENSIVINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_SCRITTI_DIFENSIVI;
			}
			set
			{
				_dATA_SCRITTI_DIFENSIVINull = false;
				_dATA_SCRITTI_DIFENSIVI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_SCRITTI_DIFENSIVINull
		{
			get
			{
				return _dATA_SCRITTI_DIFENSIVINull;
			}
			set
			{
				_dATA_SCRITTI_DIFENSIVINull = value;
			}
		}

		/// <summary>
		/// Data audizione
		/// </summary>
		public System.DateTime DATA_AUDIZIONE
		{
			get
			{
				if(IsDATA_AUDIZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_AUDIZIONE;
			}
			set
			{
				_dATA_AUDIZIONENull = false;
				_dATA_AUDIZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_AUDIZIONENull
		{
			get
			{
				return _dATA_AUDIZIONENull;
			}
			set
			{
				_dATA_AUDIZIONENull = value;
			}
		}

		/// <summary>
		/// Note
		/// </summary>
		public System.String NOTE_CONTRADDITTORIO
		{
			get
			{
				if(IsNOTE_CONTRADDITTORIONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nOTE_CONTRADDITTORIO;
			}
			set
			{
				_nOTE_CONTRADDITTORIONull = false;
				_nOTE_CONTRADDITTORIO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNOTE_CONTRADDITTORIONull
		{
			get
			{
				return _nOTE_CONTRADDITTORIONull;
			}
			set
			{
				_nOTE_CONTRADDITTORIONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NOTE_CONTRADDITTORIOSafe
		{
			get
			{
				if (IsNOTE_CONTRADDITTORIONull)
					return System.String.Empty;
				return NOTE_CONTRADDITTORIO;
			}
		}

		/// <summary>
		/// Numero ordinanza ingiunizione
		/// </summary>
		public System.String NUMERO_ORDINANZA
		{
			get
			{
				if(IsNUMERO_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_ORDINANZA;
			}
			set
			{
				_nUMERO_ORDINANZANull = false;
				_nUMERO_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_ORDINANZANull
		{
			get
			{
				return _nUMERO_ORDINANZANull;
			}
			set
			{
				_nUMERO_ORDINANZANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_ORDINANZASafe
		{
			get
			{
				if (IsNUMERO_ORDINANZANull)
					return System.String.Empty;
				return NUMERO_ORDINANZA;
			}
		}

		/// <summary>
		/// Data ordinanza ingiunzione
		/// </summary>
		public System.DateTime DATA_ORDINANZA
		{
			get
			{
				if(IsDATA_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ORDINANZA;
			}
			set
			{
				_dATA_ORDINANZANull = false;
				_dATA_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ORDINANZANull
		{
			get
			{
				return _dATA_ORDINANZANull;
			}
			set
			{
				_dATA_ORDINANZANull = value;
			}
		}

		/// <summary>
		/// Importo ordinanza
		/// </summary>
		public System.Double IMPORTO_ORDINANZA
		{
			get
			{
				if(IsIMPORTO_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iMPORTO_ORDINANZA;
			}
			set
			{
				_iMPORTO_ORDINANZANull = false;
				_iMPORTO_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIMPORTO_ORDINANZANull
		{
			get
			{
				return _iMPORTO_ORDINANZANull;
			}
			set
			{
				_iMPORTO_ORDINANZANull = value;
			}
		}

		/// <summary>
		/// Data notifica ingiunzione
		/// </summary>
		public System.DateTime DATA_NOTIFICA_ORDINANZA
		{
			get
			{
				if(IsDATA_NOTIFICA_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_NOTIFICA_ORDINANZA;
			}
			set
			{
				_dATA_NOTIFICA_ORDINANZANull = false;
				_dATA_NOTIFICA_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_NOTIFICA_ORDINANZANull
		{
			get
			{
				return _dATA_NOTIFICA_ORDINANZANull;
			}
			set
			{
				_dATA_NOTIFICA_ORDINANZANull = value;
			}
		}

		/// <summary>
		/// Data raccomandata
		/// </summary>
		public System.DateTime DATA_RACCOMANDATA_ORDINANZA
		{
			get
			{
				if(IsDATA_RACCOMANDATA_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_RACCOMANDATA_ORDINANZA;
			}
			set
			{
				_dATA_RACCOMANDATA_ORDINANZANull = false;
				_dATA_RACCOMANDATA_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_RACCOMANDATA_ORDINANZANull
		{
			get
			{
				return _dATA_RACCOMANDATA_ORDINANZANull;
			}
			set
			{
				_dATA_RACCOMANDATA_ORDINANZANull = value;
			}
		}

		/// <summary>
		/// Data scadenza pagamento
		/// </summary>
		public System.DateTime DATA_SCADENZA_PAG_ORDINANZA
		{
			get
			{
				if(IsDATA_SCADENZA_PAG_ORDINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_SCADENZA_PAG_ORDINANZA;
			}
			set
			{
				_dATA_SCADENZA_PAG_ORDINANZANull = false;
				_dATA_SCADENZA_PAG_ORDINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_SCADENZA_PAG_ORDINANZANull
		{
			get
			{
				return _dATA_SCADENZA_PAG_ORDINANZANull;
			}
			set
			{
				_dATA_SCADENZA_PAG_ORDINANZANull = value;
			}
		}

		/// <summary>
		/// Numero archiviazione
		/// </summary>
		public System.String NUMERO_ARCHIVIAZIONE
		{
			get
			{
				if(IsNUMERO_ARCHIVIAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_ARCHIVIAZIONE;
			}
			set
			{
				_nUMERO_ARCHIVIAZIONENull = false;
				_nUMERO_ARCHIVIAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_ARCHIVIAZIONENull
		{
			get
			{
				return _nUMERO_ARCHIVIAZIONENull;
			}
			set
			{
				_nUMERO_ARCHIVIAZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_ARCHIVIAZIONESafe
		{
			get
			{
				if (IsNUMERO_ARCHIVIAZIONENull)
					return System.String.Empty;
				return NUMERO_ARCHIVIAZIONE;
			}
		}

		/// <summary>
		/// Data archiviazione
		/// </summary>
		public System.DateTime DATA_ARCHIVIAZIONE
		{
			get
			{
				if(IsDATA_ARCHIVIAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ARCHIVIAZIONE;
			}
			set
			{
				_dATA_ARCHIVIAZIONENull = false;
				_dATA_ARCHIVIAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ARCHIVIAZIONENull
		{
			get
			{
				return _dATA_ARCHIVIAZIONENull;
			}
			set
			{
				_dATA_ARCHIVIAZIONENull = value;
			}
		}

		/// <summary>
		/// Note ingiunzione
		/// </summary>
		public System.String NOTE_INGIUNZIONE
		{
			get
			{
				if(IsNOTE_INGIUNZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nOTE_INGIUNZIONE;
			}
			set
			{
				_nOTE_INGIUNZIONENull = false;
				_nOTE_INGIUNZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNOTE_INGIUNZIONENull
		{
			get
			{
				return _nOTE_INGIUNZIONENull;
			}
			set
			{
				_nOTE_INGIUNZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NOTE_INGIUNZIONESafe
		{
			get
			{
				if (IsNOTE_INGIUNZIONENull)
					return System.String.Empty;
				return NOTE_INGIUNZIONE;
			}
		}

		/// <summary>
		/// Data ricorso
		/// </summary>
		public System.DateTime DATA_RICORSO
		{
			get
			{
				if(IsDATA_RICORSONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_RICORSO;
			}
			set
			{
				_dATA_RICORSONull = false;
				_dATA_RICORSO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_RICORSONull
		{
			get
			{
				return _dATA_RICORSONull;
			}
			set
			{
				_dATA_RICORSONull = value;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_GIUDICE
		{
			get
			{
				if(IsIDOBJ_GIUDICENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_GIUDICE;
			}
			set
			{
				_iDOBJ_GIUDICENull = false;
				_iDOBJ_GIUDICE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_GIUDICENull
		{
			get
			{
				return _iDOBJ_GIUDICENull;
			}
			set
			{
				_iDOBJ_GIUDICENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_GIUDICESafe
		{
			get
			{
				if (IsIDOBJ_GIUDICENull)
					return -1;
				return IDOBJ_GIUDICE;
			}
		}

		/// <summary>
		/// Data sentenza ricorso
		/// </summary>
		public System.DateTime DATA_SENTENZA_RICORSO
		{
			get
			{
				if(IsDATA_SENTENZA_RICORSONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_SENTENZA_RICORSO;
			}
			set
			{
				_dATA_SENTENZA_RICORSONull = false;
				_dATA_SENTENZA_RICORSO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_SENTENZA_RICORSONull
		{
			get
			{
				return _dATA_SENTENZA_RICORSONull;
			}
			set
			{
				_dATA_SENTENZA_RICORSONull = value;
			}
		}

		/// <summary>
		/// Data deposito ricorso
		/// </summary>
		public System.DateTime DATA_DEPOSITO_RICORSO
		{
			get
			{
				if(IsDATA_DEPOSITO_RICORSONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DEPOSITO_RICORSO;
			}
			set
			{
				_dATA_DEPOSITO_RICORSONull = false;
				_dATA_DEPOSITO_RICORSO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DEPOSITO_RICORSONull
		{
			get
			{
				return _dATA_DEPOSITO_RICORSONull;
			}
			set
			{
				_dATA_DEPOSITO_RICORSONull = value;
			}
		}

		/// <summary>
		/// Esito sentenza ricorso
		/// </summary>
		public System.String ESITO_RICORSO
		{
			get
			{
				if(IsESITO_RICORSONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _eSITO_RICORSO;
			}
			set
			{
				_eSITO_RICORSONull = false;
				_eSITO_RICORSO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsESITO_RICORSONull
		{
			get
			{
				return _eSITO_RICORSONull;
			}
			set
			{
				_eSITO_RICORSONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String ESITO_RICORSOSafe
		{
			get
			{
				if (IsESITO_RICORSONull)
					return System.String.Empty;
				return ESITO_RICORSO;
			}
		}

		/// <summary>
		/// Data pagamento
		/// </summary>
		public System.DateTime DATA_PAGAMENTO
		{
			get
			{
				if(IsDATA_PAGAMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_PAGAMENTO;
			}
			set
			{
				_dATA_PAGAMENTONull = false;
				_dATA_PAGAMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_PAGAMENTONull
		{
			get
			{
				return _dATA_PAGAMENTONull;
			}
			set
			{
				_dATA_PAGAMENTONull = value;
			}
		}

		/// <summary>
		/// Importo pagamento
		/// </summary>
		public System.Double IMPORTO_PAGAMENTO
		{
			get
			{
				if(IsIMPORTO_PAGAMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iMPORTO_PAGAMENTO;
			}
			set
			{
				_iMPORTO_PAGAMENTONull = false;
				_iMPORTO_PAGAMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIMPORTO_PAGAMENTONull
		{
			get
			{
				return _iMPORTO_PAGAMENTONull;
			}
			set
			{
				_iMPORTO_PAGAMENTONull = value;
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