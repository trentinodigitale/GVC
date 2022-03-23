//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.14
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTSOGGETTI
	/// </summary>
	public partial class GVCTSOGGETTI
	{
		private System.Int32 _iDOBJ;
		private System.Int32 _fLAG_ASSOCIAZIONE;
		private System.Int32 _fLAG_PF;
		private System.String _dENOMINAZIONE;
		private System.Boolean _dENOMINAZIONENull = true;
		private System.String _cOGNOME;
		private System.Boolean _cOGNOMENull = true;
		private System.String _nOME;
		private System.Boolean _nOMENull = true;
		private System.String _cODICE_FISCALE;
		private System.Boolean _cODICE_FISCALENull = true;
		private System.String _pARTITA_IVA;
		private System.Boolean _pARTITA_IVANull = true;
		private System.String _sESSO;
		private System.Boolean _sESSONull = true;
		private System.String _cOGNOME_ACQUISITO;
		private System.Boolean _cOGNOME_ACQUISITONull = true;
		private System.DateTime _dATA_NASCITA;
		private System.Boolean _dATA_NASCITANull = true;
		private System.String _lUOGO_NASCITA;
		private System.Boolean _lUOGO_NASCITANull = true;
		private System.String _sTATO_NASCITA;
		private System.Boolean _sTATO_NASCITANull = true;
		private System.String _cITTADINANZA;
		private System.Boolean _cITTADINANZANull = true;
		private System.String _tELEFONO_1;
		private System.Boolean _tELEFONO_1Null = true;
		private System.String _tELEFONO_2;
		private System.Boolean _tELEFONO_2Null = true;
		private System.String _cELLULARE;
		private System.Boolean _cELLULARENull = true;
		private System.String _eMAIL;
		private System.Boolean _eMAILNull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;
		private System.Int32 _iDOBJ_TIPO_SOGGETTO;
		private System.Boolean _iDOBJ_TIPO_SOGGETTONull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTSOGGETTI(){}

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
		/// Flag attivo 0=no associazione 1=associazione
		/// The field is mandatory.
		/// </summary>
		public System.Int32 FLAG_ASSOCIAZIONE
		{
			get
			{
				return _fLAG_ASSOCIAZIONE;
			}
			set
			{
				_fLAG_ASSOCIAZIONE = value;
			}
		}

		/// <summary>
		/// Flag persona fisica 0= no 1= si
		/// The field is mandatory.
		/// </summary>
		public System.Int32 FLAG_PF
		{
			get
			{
				return _fLAG_PF;
			}
			set
			{
				_fLAG_PF = value;
			}
		}

		/// <summary>
		/// Denominazione
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
		/// Cognome
		/// </summary>
		public System.String COGNOME
		{
			get
			{
				if(IsCOGNOMENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cOGNOME;
			}
			set
			{
				_cOGNOMENull = false;
				_cOGNOME = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCOGNOMENull
		{
			get
			{
				return _cOGNOMENull;
			}
			set
			{
				_cOGNOMENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String COGNOMESafe
		{
			get
			{
				if (IsCOGNOMENull)
					return System.String.Empty;
				return COGNOME;
			}
		}

		/// <summary>
		/// Nome
		/// </summary>
		public System.String NOME
		{
			get
			{
				if(IsNOMENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nOME;
			}
			set
			{
				_nOMENull = false;
				_nOME = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNOMENull
		{
			get
			{
				return _nOMENull;
			}
			set
			{
				_nOMENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NOMESafe
		{
			get
			{
				if (IsNOMENull)
					return System.String.Empty;
				return NOME;
			}
		}

		/// <summary>
		/// Codice fiscale
		/// </summary>
		public System.String CODICE_FISCALE
		{
			get
			{
				if(IsCODICE_FISCALENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cODICE_FISCALE;
			}
			set
			{
				_cODICE_FISCALENull = false;
				_cODICE_FISCALE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCODICE_FISCALENull
		{
			get
			{
				return _cODICE_FISCALENull;
			}
			set
			{
				_cODICE_FISCALENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CODICE_FISCALESafe
		{
			get
			{
				if (IsCODICE_FISCALENull)
					return System.String.Empty;
				return CODICE_FISCALE;
			}
		}

		/// <summary>
		/// Partita iva
		/// </summary>
		public System.String PARTITA_IVA
		{
			get
			{
				if(IsPARTITA_IVANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _pARTITA_IVA;
			}
			set
			{
				_pARTITA_IVANull = false;
				_pARTITA_IVA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsPARTITA_IVANull
		{
			get
			{
				return _pARTITA_IVANull;
			}
			set
			{
				_pARTITA_IVANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String PARTITA_IVASafe
		{
			get
			{
				if (IsPARTITA_IVANull)
					return System.String.Empty;
				return PARTITA_IVA;
			}
		}

		/// <summary>
		/// M/F
		/// </summary>
		public System.String SESSO
		{
			get
			{
				if(IsSESSONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sESSO;
			}
			set
			{
				_sESSONull = false;
				_sESSO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSESSONull
		{
			get
			{
				return _sESSONull;
			}
			set
			{
				_sESSONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String SESSOSafe
		{
			get
			{
				if (IsSESSONull)
					return System.String.Empty;
				return SESSO;
			}
		}

		/// <summary>
		/// Cognome acquisito
		/// </summary>
		public System.String COGNOME_ACQUISITO
		{
			get
			{
				if(IsCOGNOME_ACQUISITONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cOGNOME_ACQUISITO;
			}
			set
			{
				_cOGNOME_ACQUISITONull = false;
				_cOGNOME_ACQUISITO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCOGNOME_ACQUISITONull
		{
			get
			{
				return _cOGNOME_ACQUISITONull;
			}
			set
			{
				_cOGNOME_ACQUISITONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String COGNOME_ACQUISITOSafe
		{
			get
			{
				if (IsCOGNOME_ACQUISITONull)
					return System.String.Empty;
				return COGNOME_ACQUISITO;
			}
		}

		/// <summary>
		/// Data di nascita
		/// </summary>
		public System.DateTime DATA_NASCITA
		{
			get
			{
				if(IsDATA_NASCITANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_NASCITA;
			}
			set
			{
				_dATA_NASCITANull = false;
				_dATA_NASCITA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_NASCITANull
		{
			get
			{
				return _dATA_NASCITANull;
			}
			set
			{
				_dATA_NASCITANull = value;
			}
		}

		/// <summary>
		/// Luogo di nascita
		/// </summary>
		public System.String LUOGO_NASCITA
		{
			get
			{
				if(IsLUOGO_NASCITANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _lUOGO_NASCITA;
			}
			set
			{
				_lUOGO_NASCITANull = false;
				_lUOGO_NASCITA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsLUOGO_NASCITANull
		{
			get
			{
				return _lUOGO_NASCITANull;
			}
			set
			{
				_lUOGO_NASCITANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String LUOGO_NASCITASafe
		{
			get
			{
				if (IsLUOGO_NASCITANull)
					return System.String.Empty;
				return LUOGO_NASCITA;
			}
		}

		/// <summary>
		/// Stato di nascita
		/// </summary>
		public System.String STATO_NASCITA
		{
			get
			{
				if(IsSTATO_NASCITANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _sTATO_NASCITA;
			}
			set
			{
				_sTATO_NASCITANull = false;
				_sTATO_NASCITA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsSTATO_NASCITANull
		{
			get
			{
				return _sTATO_NASCITANull;
			}
			set
			{
				_sTATO_NASCITANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String STATO_NASCITASafe
		{
			get
			{
				if (IsSTATO_NASCITANull)
					return System.String.Empty;
				return STATO_NASCITA;
			}
		}

		/// <summary>
		/// Cittadinanza
		/// </summary>
		public System.String CITTADINANZA
		{
			get
			{
				if(IsCITTADINANZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cITTADINANZA;
			}
			set
			{
				_cITTADINANZANull = false;
				_cITTADINANZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCITTADINANZANull
		{
			get
			{
				return _cITTADINANZANull;
			}
			set
			{
				_cITTADINANZANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CITTADINANZASafe
		{
			get
			{
				if (IsCITTADINANZANull)
					return System.String.Empty;
				return CITTADINANZA;
			}
		}

		/// <summary>
		/// Telefono 1
		/// </summary>
		public System.String TELEFONO_1
		{
			get
			{
				if(IsTELEFONO_1Null)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _tELEFONO_1;
			}
			set
			{
				_tELEFONO_1Null = false;
				_tELEFONO_1 = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsTELEFONO_1Null
		{
			get
			{
				return _tELEFONO_1Null;
			}
			set
			{
				_tELEFONO_1Null = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String TELEFONO_1Safe
		{
			get
			{
				if (IsTELEFONO_1Null)
					return System.String.Empty;
				return TELEFONO_1;
			}
		}

		/// <summary>
		/// Telefono 2
		/// </summary>
		public System.String TELEFONO_2
		{
			get
			{
				if(IsTELEFONO_2Null)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _tELEFONO_2;
			}
			set
			{
				_tELEFONO_2Null = false;
				_tELEFONO_2 = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsTELEFONO_2Null
		{
			get
			{
				return _tELEFONO_2Null;
			}
			set
			{
				_tELEFONO_2Null = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String TELEFONO_2Safe
		{
			get
			{
				if (IsTELEFONO_2Null)
					return System.String.Empty;
				return TELEFONO_2;
			}
		}

		/// <summary>
		/// Telefono cellulare
		/// </summary>
		public System.String CELLULARE
		{
			get
			{
				if(IsCELLULARENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cELLULARE;
			}
			set
			{
				_cELLULARENull = false;
				_cELLULARE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCELLULARENull
		{
			get
			{
				return _cELLULARENull;
			}
			set
			{
				_cELLULARENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CELLULARESafe
		{
			get
			{
				if (IsCELLULARENull)
					return System.String.Empty;
				return CELLULARE;
			}
		}

		/// <summary>
		/// Indirizzo e-mail
		/// </summary>
		public System.String EMAIL
		{
			get
			{
				if(IsEMAILNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _eMAIL;
			}
			set
			{
				_eMAILNull = false;
				_eMAIL = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsEMAILNull
		{
			get
			{
				return _eMAILNull;
			}
			set
			{
				_eMAILNull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String EMAILSafe
		{
			get
			{
				if (IsEMAILNull)
					return System.String.Empty;
				return EMAIL;
			}
		}

		/// <summary>
		/// Value of field NOTE
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
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_TIPO_SOGGETTO
		{
			get
			{
				if(IsIDOBJ_TIPO_SOGGETTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_TIPO_SOGGETTO;
			}
			set
			{
				_iDOBJ_TIPO_SOGGETTONull = false;
				_iDOBJ_TIPO_SOGGETTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_TIPO_SOGGETTONull
		{
			get
			{
				return _iDOBJ_TIPO_SOGGETTONull;
			}
			set
			{
				_iDOBJ_TIPO_SOGGETTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_TIPO_SOGGETTOSafe
		{
			get
			{
				if (IsIDOBJ_TIPO_SOGGETTONull)
					return -1;
				return IDOBJ_TIPO_SOGGETTO;
			}
		}

	}
}