//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVC_PARIX_UPD
	/// </summary>
	public partial class GVC_PARIX_UPD
	{
		private System.Int32 _iD;
		private System.String _tRACKINGID;
		private System.Boolean _tRACKINGIDNull = true;
		private System.DateTime _dATAORA_INSERIMENTO_RECORD;
		private System.Boolean _dATAORA_INSERIMENTO_RECORDNull = true;
		private System.DateTime _dATAORA_AGGIORNAMENTO;
		private System.Boolean _dATAORA_AGGIORNAMENTONull = true;
		private System.String _cODICE_FISCALE;
		private System.String _dENOMINAZIONE;
		private System.Boolean _dENOMINAZIONENull = true;
		private System.String _nUMERO_RI;
		private System.Boolean _nUMERO_RINull = true;
		private System.String _cCIAA_REGZ;
		private System.Boolean _cCIAA_REGZNull = true;
		private System.Int32 _n_ISCRIZIONE_REA;
		private System.Boolean _n_ISCRIZIONE_REANull = true;
		private System.DateTime _dATA_ISCR_REA;
		private System.Boolean _dATA_ISCR_REANull = true;
		private System.Byte[] _dATI_IMPRESA;
		private System.Boolean _dATI_IMPRESANull = true;
		private System.String _c_NATURA_GIURIDICA;
		private System.Boolean _c_NATURA_GIURIDICANull = true;
		private System.DateTime _dATAORA_ALLINEAMENTOINGVC;
		private System.Boolean _dATAORA_ALLINEAMENTOINGVCNull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVC_PARIX_UPD(){}

		/// <summary>
		/// Value of field ID
		/// The field is mandatory.
		/// </summary>
		public System.Int32 ID
		{
			get
			{
				return _iD;
			}
			set
			{
				_iD = value;
			}
		}

		/// <summary>
		/// Value of field TRACKINGID
		/// </summary>
		public System.String TRACKINGID
		{
			get
			{
				if(IsTRACKINGIDNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _tRACKINGID;
			}
			set
			{
				_tRACKINGIDNull = false;
				_tRACKINGID = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsTRACKINGIDNull
		{
			get
			{
				return _tRACKINGIDNull;
			}
			set
			{
				_tRACKINGIDNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String TRACKINGIDSafe
		{
			get
			{
				if (IsTRACKINGIDNull)
					return System.String.Empty;
				return TRACKINGID;
			}
		}

		/// <summary>
		/// Value of field DATAORA_INSERIMENTO_RECORD
		/// </summary>
		public System.DateTime DATAORA_INSERIMENTO_RECORD
		{
			get
			{
				if(IsDATAORA_INSERIMENTO_RECORDNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATAORA_INSERIMENTO_RECORD;
			}
			set
			{
				_dATAORA_INSERIMENTO_RECORDNull = false;
				_dATAORA_INSERIMENTO_RECORD = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATAORA_INSERIMENTO_RECORDNull
		{
			get
			{
				return _dATAORA_INSERIMENTO_RECORDNull;
			}
			set
			{
				_dATAORA_INSERIMENTO_RECORDNull = value;
			}
		}

		/// <summary>
		/// Value of field DATAORA_AGGIORNAMENTO
		/// </summary>
		public System.DateTime DATAORA_AGGIORNAMENTO
		{
			get
			{
				if(IsDATAORA_AGGIORNAMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATAORA_AGGIORNAMENTO;
			}
			set
			{
				_dATAORA_AGGIORNAMENTONull = false;
				_dATAORA_AGGIORNAMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATAORA_AGGIORNAMENTONull
		{
			get
			{
				return _dATAORA_AGGIORNAMENTONull;
			}
			set
			{
				_dATAORA_AGGIORNAMENTONull = value;
			}
		}

		/// <summary>
		/// Value of field CODICE_FISCALE
		/// The field is mandatory.
		/// </summary>
		public System.String CODICE_FISCALE
		{
			get
			{
				return _cODICE_FISCALE;
			}
			set
			{
				_cODICE_FISCALE = value;
			}
		}

		/// <summary>
		/// Value of field DENOMINAZIONE
		/// </summary>
		public System.String DENOMINAZIONE
		{
			get
			{
				if(IsDENOMINAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dENOMINAZIONE;
			}
			set
			{
				_dENOMINAZIONENull = false;
				_dENOMINAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDENOMINAZIONENull
		{
			get
			{
				return _dENOMINAZIONENull;
			}
			set
			{
				_dENOMINAZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String DENOMINAZIONESafe
		{
			get
			{
				if (IsDENOMINAZIONENull)
					return System.String.Empty;
				return DENOMINAZIONE;
			}
		}

		/// <summary>
		/// Value of field NUMERO_RI
		/// </summary>
		public System.String NUMERO_RI
		{
			get
			{
				if(IsNUMERO_RINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_RI;
			}
			set
			{
				_nUMERO_RINull = false;
				_nUMERO_RI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_RINull
		{
			get
			{
				return _nUMERO_RINull;
			}
			set
			{
				_nUMERO_RINull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_RISafe
		{
			get
			{
				if (IsNUMERO_RINull)
					return System.String.Empty;
				return NUMERO_RI;
			}
		}

		/// <summary>
		/// Value of field CCIAA_REGZ
		/// </summary>
		public System.String CCIAA_REGZ
		{
			get
			{
				if(IsCCIAA_REGZNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cCIAA_REGZ;
			}
			set
			{
				_cCIAA_REGZNull = false;
				_cCIAA_REGZ = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCCIAA_REGZNull
		{
			get
			{
				return _cCIAA_REGZNull;
			}
			set
			{
				_cCIAA_REGZNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CCIAA_REGZSafe
		{
			get
			{
				if (IsCCIAA_REGZNull)
					return System.String.Empty;
				return CCIAA_REGZ;
			}
		}

		/// <summary>
		/// Value of field N_ISCRIZIONE_REA
		/// </summary>
		public System.Int32 N_ISCRIZIONE_REA
		{
			get
			{
				if(IsN_ISCRIZIONE_REANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _n_ISCRIZIONE_REA;
			}
			set
			{
				_n_ISCRIZIONE_REANull = false;
				_n_ISCRIZIONE_REA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsN_ISCRIZIONE_REANull
		{
			get
			{
				return _n_ISCRIZIONE_REANull;
			}
			set
			{
				_n_ISCRIZIONE_REANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 N_ISCRIZIONE_REASafe
		{
			get
			{
				if (IsN_ISCRIZIONE_REANull)
					return -1;
				return N_ISCRIZIONE_REA;
			}
		}

		/// <summary>
		/// Value of field DATA_ISCR_REA
		/// </summary>
		public System.DateTime DATA_ISCR_REA
		{
			get
			{
				if(IsDATA_ISCR_REANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ISCR_REA;
			}
			set
			{
				_dATA_ISCR_REANull = false;
				_dATA_ISCR_REA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ISCR_REANull
		{
			get
			{
				return _dATA_ISCR_REANull;
			}
			set
			{
				_dATA_ISCR_REANull = value;
			}
		}

		/// <summary>
		/// Value of field DATI_IMPRESA
		/// </summary>
		public System.Byte[] DATI_IMPRESA
		{
			get
			{
				if(IsDATI_IMPRESANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATI_IMPRESA;
			}
			set
			{
				_dATI_IMPRESANull = false;
				_dATI_IMPRESA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATI_IMPRESANull
		{
			get
			{
				return _dATI_IMPRESANull;
			}
			set
			{
				_dATI_IMPRESANull = value;
			}
		}

		/// <summary>
		/// Value of field C_NATURA_GIURIDICA
		/// </summary>
		public System.String C_NATURA_GIURIDICA
		{
			get
			{
				if(IsC_NATURA_GIURIDICANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _c_NATURA_GIURIDICA;
			}
			set
			{
				_c_NATURA_GIURIDICANull = false;
				_c_NATURA_GIURIDICA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsC_NATURA_GIURIDICANull
		{
			get
			{
				return _c_NATURA_GIURIDICANull;
			}
			set
			{
				_c_NATURA_GIURIDICANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String C_NATURA_GIURIDICASafe
		{
			get
			{
				if (IsC_NATURA_GIURIDICANull)
					return System.String.Empty;
				return C_NATURA_GIURIDICA;
			}
		}

		/// <summary>
		/// Value of field DATAORA_ALLINEAMENTOINGVC
		/// </summary>
		public System.DateTime DATAORA_ALLINEAMENTOINGVC
		{
			get
			{
				if(IsDATAORA_ALLINEAMENTOINGVCNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATAORA_ALLINEAMENTOINGVC;
			}
			set
			{
				_dATAORA_ALLINEAMENTOINGVCNull = false;
				_dATAORA_ALLINEAMENTOINGVC = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATAORA_ALLINEAMENTOINGVCNull
		{
			get
			{
				return _dATAORA_ALLINEAMENTOINGVCNull;
			}
			set
			{
				_dATAORA_ALLINEAMENTOINGVCNull = value;
			}
		}

	}
}