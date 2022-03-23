//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.14
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTREGISTRI
	/// </summary>
	public partial class GVCTREGISTRI
	{
		private System.Int32 _iDOBJ;
		private System.Int32 _iDOBJ_SOGGETTO;
		private System.String _nUMERO_REA;
		private System.Boolean _nUMERO_REANull = true;
		private System.String _nUMERO_RI;
		private System.Boolean _nUMERO_RINull = true;
		private System.String _nUMERO_ALBO;
		private System.Boolean _nUMERO_ALBONull = true;
		private System.String _fORMA_GIURIDICA_CCIAA;
		private System.Boolean _fORMA_GIURIDICA_CCIAANull = true;
		private System.DateTime _dATA_COSTITUZIONE;
		private System.Boolean _dATA_COSTITUZIONENull = true;
		private System.DateTime _dURATA;
		private System.Boolean _dURATANull = true;
		private System.Int32 _dURATA_ILLIMITATA;
		private System.Boolean _dURATA_ILLIMITATANull = true;
		private System.DateTime _bILANCIO_ESERCIZIO_AL;
		private System.Boolean _bILANCIO_ESERCIZIO_ALNull = true;
		private System.Int32 _gRUPPO_PARITETICO;
		private System.Boolean _gRUPPO_PARITETICONull = true;
		private System.DateTime _dATA_BFL;
		private System.Boolean _dATA_BFLNull = true;
		private System.DateTime _dATA_DEPOSITO_BFL;
		private System.Boolean _dATA_DEPOSITO_BFLNull = true;
		private System.Int32 _nUMERO_SCIOGLIMENTO;
		private System.Boolean _nUMERO_SCIOGLIMENTONull = true;
		private System.Int32 _eSENTE_VERSAMENTO_UTILI;
		private System.Boolean _eSENTE_VERSAMENTO_UTILINull = true;
		private System.Double _iMPORTO_VERSAMENTO;
		private System.Boolean _iMPORTO_VERSAMENTONull = true;
		private System.String _cODICE_OPERATORE;
		private System.Boolean _cODICE_OPERATORENull = true;
		private System.String _cODICE_UFFICIO;
		private System.Boolean _cODICE_UFFICIONull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;
		private System.Int32 _iDOBJ_STATO;
		private System.Boolean _iDOBJ_STATONull = true;
		private System.Int32 _iDOBJ_TIPO_COSTITUZIONE;
		private System.Boolean _iDOBJ_TIPO_COSTITUZIONENull = true;
		private System.Int32 _iDOBJ_NOTAIO;
		private System.Boolean _iDOBJ_NOTAIONull = true;
		private System.Int32 _iDOBJ_FORMA_AMMINISTRATIVA;
		private System.Boolean _iDOBJ_FORMA_AMMINISTRATIVANull = true;
		private System.Int32 _iDOBJ_FORMA_GIURIDICA;
		private System.Boolean _iDOBJ_FORMA_GIURIDICANull = true;
		private System.Int32 _iDOBJ_CADENZA_REVISIONE;
		private System.Boolean _iDOBJ_CADENZA_REVISIONENull = true;
		private System.Int32 _cODICE_COOPERATIVA;
		private System.Boolean _cODICE_COOPERATIVANull = true;
		private System.String _nUMERO_REPERTORIO_NOTAIO;
		private System.Boolean _nUMERO_REPERTORIO_NOTAIONull = true;
		private System.String _fORMA_AMM_CCIAA;
		private System.Boolean _fORMA_AMM_CCIAANull = true;
		private System.DateTime _dATA_ACQUISIZIONE_ATTO;
		private System.Boolean _dATA_ACQUISIZIONE_ATTONull = true;
		private System.DateTime _dATA_DEPOSITO_ATTO;
		private System.Boolean _dATA_DEPOSITO_ATTONull = true;
		private System.String _nUMERO_ESAME;
		private System.Boolean _nUMERO_ESAMENull = true;
		private System.DateTime _dATA_ESAME;
		private System.Boolean _dATA_ESAMENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTREGISTRI(){}

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
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_SOGGETTO
		{
			get
			{
				return _iDOBJ_SOGGETTO;
			}
			set
			{
				_iDOBJ_SOGGETTO = value;
			}
		}

		/// <summary>
		/// Numero REA
		/// </summary>
		public System.String NUMERO_REA
		{
			get
			{
				if(IsNUMERO_REANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_REA;
			}
			set
			{
				_nUMERO_REANull = false;
				_nUMERO_REA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_REANull
		{
			get
			{
				return _nUMERO_REANull;
			}
			set
			{
				_nUMERO_REANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_REASafe
		{
			get
			{
				if (IsNUMERO_REANull)
					return System.String.Empty;
				return NUMERO_REA;
			}
		}

		/// <summary>
		/// Numero iscrizione R.I.
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
		/// Numero iscrizione albo nazionale
		/// </summary>
		public System.String NUMERO_ALBO
		{
			get
			{
				if(IsNUMERO_ALBONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_ALBO;
			}
			set
			{
				_nUMERO_ALBONull = false;
				_nUMERO_ALBO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_ALBONull
		{
			get
			{
				return _nUMERO_ALBONull;
			}
			set
			{
				_nUMERO_ALBONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_ALBOSafe
		{
			get
			{
				if (IsNUMERO_ALBONull)
					return System.String.Empty;
				return NUMERO_ALBO;
			}
		}

		/// <summary>
		/// Forma giuridica presa da Infocamere
		/// </summary>
		public System.String FORMA_GIURIDICA_CCIAA
		{
			get
			{
				if(IsFORMA_GIURIDICA_CCIAANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fORMA_GIURIDICA_CCIAA;
			}
			set
			{
				_fORMA_GIURIDICA_CCIAANull = false;
				_fORMA_GIURIDICA_CCIAA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFORMA_GIURIDICA_CCIAANull
		{
			get
			{
				return _fORMA_GIURIDICA_CCIAANull;
			}
			set
			{
				_fORMA_GIURIDICA_CCIAANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String FORMA_GIURIDICA_CCIAASafe
		{
			get
			{
				if (IsFORMA_GIURIDICA_CCIAANull)
					return System.String.Empty;
				return FORMA_GIURIDICA_CCIAA;
			}
		}

		/// <summary>
		/// Data costituzione
		/// </summary>
		public System.DateTime DATA_COSTITUZIONE
		{
			get
			{
				if(IsDATA_COSTITUZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_COSTITUZIONE;
			}
			set
			{
				_dATA_COSTITUZIONENull = false;
				_dATA_COSTITUZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_COSTITUZIONENull
		{
			get
			{
				return _dATA_COSTITUZIONENull;
			}
			set
			{
				_dATA_COSTITUZIONENull = value;
			}
		}

		/// <summary>
		/// Durata
		/// </summary>
		public System.DateTime DURATA
		{
			get
			{
				if(IsDURATANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dURATA;
			}
			set
			{
				_dURATANull = false;
				_dURATA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDURATANull
		{
			get
			{
				return _dURATANull;
			}
			set
			{
				_dURATANull = value;
			}
		}

		/// <summary>
		/// 1=illimitata
		/// </summary>
		public System.Int32 DURATA_ILLIMITATA
		{
			get
			{
				if(IsDURATA_ILLIMITATANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dURATA_ILLIMITATA;
			}
			set
			{
				_dURATA_ILLIMITATANull = false;
				_dURATA_ILLIMITATA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDURATA_ILLIMITATANull
		{
			get
			{
				return _dURATA_ILLIMITATANull;
			}
			set
			{
				_dURATA_ILLIMITATANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 DURATA_ILLIMITATASafe
		{
			get
			{
				if (IsDURATA_ILLIMITATANull)
					return -1;
				return DURATA_ILLIMITATA;
			}
		}

		/// <summary>
		/// Bilancio esercizio al
		/// </summary>
		public System.DateTime BILANCIO_ESERCIZIO_AL
		{
			get
			{
				if(IsBILANCIO_ESERCIZIO_ALNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _bILANCIO_ESERCIZIO_AL;
			}
			set
			{
				_bILANCIO_ESERCIZIO_ALNull = false;
				_bILANCIO_ESERCIZIO_AL = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsBILANCIO_ESERCIZIO_ALNull
		{
			get
			{
				return _bILANCIO_ESERCIZIO_ALNull;
			}
			set
			{
				_bILANCIO_ESERCIZIO_ALNull = value;
			}
		}

		/// <summary>
		/// 1=appartiene a gruppo paritetico 0= non appartiene
		/// </summary>
		public System.Int32 GRUPPO_PARITETICO
		{
			get
			{
				if(IsGRUPPO_PARITETICONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _gRUPPO_PARITETICO;
			}
			set
			{
				_gRUPPO_PARITETICONull = false;
				_gRUPPO_PARITETICO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsGRUPPO_PARITETICONull
		{
			get
			{
				return _gRUPPO_PARITETICONull;
			}
			set
			{
				_gRUPPO_PARITETICONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 GRUPPO_PARITETICOSafe
		{
			get
			{
				if (IsGRUPPO_PARITETICONull)
					return -1;
				return GRUPPO_PARITETICO;
			}
		}

		/// <summary>
		/// Data bilancio finale di liquidazione
		/// </summary>
		public System.DateTime DATA_BFL
		{
			get
			{
				if(IsDATA_BFLNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_BFL;
			}
			set
			{
				_dATA_BFLNull = false;
				_dATA_BFL = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_BFLNull
		{
			get
			{
				return _dATA_BFLNull;
			}
			set
			{
				_dATA_BFLNull = value;
			}
		}

		/// <summary>
		/// Data deposito bilancio finale
		/// </summary>
		public System.DateTime DATA_DEPOSITO_BFL
		{
			get
			{
				if(IsDATA_DEPOSITO_BFLNull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DEPOSITO_BFL;
			}
			set
			{
				_dATA_DEPOSITO_BFLNull = false;
				_dATA_DEPOSITO_BFL = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DEPOSITO_BFLNull
		{
			get
			{
				return _dATA_DEPOSITO_BFLNull;
			}
			set
			{
				_dATA_DEPOSITO_BFLNull = value;
			}
		}

		/// <summary>
		/// Numero scioglimento
		/// </summary>
		public System.Int32 NUMERO_SCIOGLIMENTO
		{
			get
			{
				if(IsNUMERO_SCIOGLIMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_SCIOGLIMENTO;
			}
			set
			{
				_nUMERO_SCIOGLIMENTONull = false;
				_nUMERO_SCIOGLIMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_SCIOGLIMENTONull
		{
			get
			{
				return _nUMERO_SCIOGLIMENTONull;
			}
			set
			{
				_nUMERO_SCIOGLIMENTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 NUMERO_SCIOGLIMENTOSafe
		{
			get
			{
				if (IsNUMERO_SCIOGLIMENTONull)
					return -1;
				return NUMERO_SCIOGLIMENTO;
			}
		}

		/// <summary>
		/// 1= esente
		/// </summary>
		public System.Int32 ESENTE_VERSAMENTO_UTILI
		{
			get
			{
				if(IsESENTE_VERSAMENTO_UTILINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _eSENTE_VERSAMENTO_UTILI;
			}
			set
			{
				_eSENTE_VERSAMENTO_UTILINull = false;
				_eSENTE_VERSAMENTO_UTILI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsESENTE_VERSAMENTO_UTILINull
		{
			get
			{
				return _eSENTE_VERSAMENTO_UTILINull;
			}
			set
			{
				_eSENTE_VERSAMENTO_UTILINull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 ESENTE_VERSAMENTO_UTILISafe
		{
			get
			{
				if (IsESENTE_VERSAMENTO_UTILINull)
					return -1;
				return ESENTE_VERSAMENTO_UTILI;
			}
		}

		/// <summary>
		/// Importo previsto versamento patrimonio residuo
		/// </summary>
		public System.Double IMPORTO_VERSAMENTO
		{
			get
			{
				if(IsIMPORTO_VERSAMENTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iMPORTO_VERSAMENTO;
			}
			set
			{
				_iMPORTO_VERSAMENTONull = false;
				_iMPORTO_VERSAMENTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIMPORTO_VERSAMENTONull
		{
			get
			{
				return _iMPORTO_VERSAMENTONull;
			}
			set
			{
				_iMPORTO_VERSAMENTONull = value;
			}
		}

		/// <summary>
		/// Codice operatore
		/// </summary>
		public System.String CODICE_OPERATORE
		{
			get
			{
				if(IsCODICE_OPERATORENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cODICE_OPERATORE;
			}
			set
			{
				_cODICE_OPERATORENull = false;
				_cODICE_OPERATORE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCODICE_OPERATORENull
		{
			get
			{
				return _cODICE_OPERATORENull;
			}
			set
			{
				_cODICE_OPERATORENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CODICE_OPERATORESafe
		{
			get
			{
				if (IsCODICE_OPERATORENull)
					return System.String.Empty;
				return CODICE_OPERATORE;
			}
		}

		/// <summary>
		/// Codice ufficio
		/// </summary>
		public System.String CODICE_UFFICIO
		{
			get
			{
				if(IsCODICE_UFFICIONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cODICE_UFFICIO;
			}
			set
			{
				_cODICE_UFFICIONull = false;
				_cODICE_UFFICIO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCODICE_UFFICIONull
		{
			get
			{
				return _cODICE_UFFICIONull;
			}
			set
			{
				_cODICE_UFFICIONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String CODICE_UFFICIOSafe
		{
			get
			{
				if (IsCODICE_UFFICIONull)
					return System.String.Empty;
				return CODICE_UFFICIO;
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
		public System.Int32 IDOBJ_STATO
		{
			get
			{
				if(IsIDOBJ_STATONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_STATO;
			}
			set
			{
				_iDOBJ_STATONull = false;
				_iDOBJ_STATO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_STATONull
		{
			get
			{
				return _iDOBJ_STATONull;
			}
			set
			{
				_iDOBJ_STATONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_STATOSafe
		{
			get
			{
				if (IsIDOBJ_STATONull)
					return -1;
				return IDOBJ_STATO;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_TIPO_COSTITUZIONE
		{
			get
			{
				if(IsIDOBJ_TIPO_COSTITUZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_TIPO_COSTITUZIONE;
			}
			set
			{
				_iDOBJ_TIPO_COSTITUZIONENull = false;
				_iDOBJ_TIPO_COSTITUZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_TIPO_COSTITUZIONENull
		{
			get
			{
				return _iDOBJ_TIPO_COSTITUZIONENull;
			}
			set
			{
				_iDOBJ_TIPO_COSTITUZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_TIPO_COSTITUZIONESafe
		{
			get
			{
				if (IsIDOBJ_TIPO_COSTITUZIONENull)
					return -1;
				return IDOBJ_TIPO_COSTITUZIONE;
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

		/// <summary>
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_FORMA_AMMINISTRATIVA
		{
			get
			{
				if(IsIDOBJ_FORMA_AMMINISTRATIVANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_FORMA_AMMINISTRATIVA;
			}
			set
			{
				_iDOBJ_FORMA_AMMINISTRATIVANull = false;
				_iDOBJ_FORMA_AMMINISTRATIVA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_FORMA_AMMINISTRATIVANull
		{
			get
			{
				return _iDOBJ_FORMA_AMMINISTRATIVANull;
			}
			set
			{
				_iDOBJ_FORMA_AMMINISTRATIVANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_FORMA_AMMINISTRATIVASafe
		{
			get
			{
				if (IsIDOBJ_FORMA_AMMINISTRATIVANull)
					return -1;
				return IDOBJ_FORMA_AMMINISTRATIVA;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_FORMA_GIURIDICA
		{
			get
			{
				if(IsIDOBJ_FORMA_GIURIDICANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_FORMA_GIURIDICA;
			}
			set
			{
				_iDOBJ_FORMA_GIURIDICANull = false;
				_iDOBJ_FORMA_GIURIDICA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_FORMA_GIURIDICANull
		{
			get
			{
				return _iDOBJ_FORMA_GIURIDICANull;
			}
			set
			{
				_iDOBJ_FORMA_GIURIDICANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_FORMA_GIURIDICASafe
		{
			get
			{
				if (IsIDOBJ_FORMA_GIURIDICANull)
					return -1;
				return IDOBJ_FORMA_GIURIDICA;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_CADENZA_REVISIONE
		{
			get
			{
				if(IsIDOBJ_CADENZA_REVISIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_CADENZA_REVISIONE;
			}
			set
			{
				_iDOBJ_CADENZA_REVISIONENull = false;
				_iDOBJ_CADENZA_REVISIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_CADENZA_REVISIONENull
		{
			get
			{
				return _iDOBJ_CADENZA_REVISIONENull;
			}
			set
			{
				_iDOBJ_CADENZA_REVISIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_CADENZA_REVISIONESafe
		{
			get
			{
				if (IsIDOBJ_CADENZA_REVISIONENull)
					return -1;
				return IDOBJ_CADENZA_REVISIONE;
			}
		}

		/// <summary>
		/// Codice cooperativa
		/// </summary>
		public System.Int32 CODICE_COOPERATIVA
		{
			get
			{
				if(IsCODICE_COOPERATIVANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _cODICE_COOPERATIVA;
			}
			set
			{
				_cODICE_COOPERATIVANull = false;
				_cODICE_COOPERATIVA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsCODICE_COOPERATIVANull
		{
			get
			{
				return _cODICE_COOPERATIVANull;
			}
			set
			{
				_cODICE_COOPERATIVANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 CODICE_COOPERATIVASafe
		{
			get
			{
				if (IsCODICE_COOPERATIVANull)
					return -1;
				return CODICE_COOPERATIVA;
			}
		}

		/// <summary>
		/// Value of field NUMERO_REPERTORIO_NOTAIO
		/// </summary>
		public System.String NUMERO_REPERTORIO_NOTAIO
		{
			get
			{
				if(IsNUMERO_REPERTORIO_NOTAIONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_REPERTORIO_NOTAIO;
			}
			set
			{
				_nUMERO_REPERTORIO_NOTAIONull = false;
				_nUMERO_REPERTORIO_NOTAIO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_REPERTORIO_NOTAIONull
		{
			get
			{
				return _nUMERO_REPERTORIO_NOTAIONull;
			}
			set
			{
				_nUMERO_REPERTORIO_NOTAIONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_REPERTORIO_NOTAIOSafe
		{
			get
			{
				if (IsNUMERO_REPERTORIO_NOTAIONull)
					return System.String.Empty;
				return NUMERO_REPERTORIO_NOTAIO;
			}
		}

		/// <summary>
		/// Forma amministrativa presa da Infocamere
		/// </summary>
		public System.String FORMA_AMM_CCIAA
		{
			get
			{
				if(IsFORMA_AMM_CCIAANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fORMA_AMM_CCIAA;
			}
			set
			{
				_fORMA_AMM_CCIAANull = false;
				_fORMA_AMM_CCIAA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFORMA_AMM_CCIAANull
		{
			get
			{
				return _fORMA_AMM_CCIAANull;
			}
			set
			{
				_fORMA_AMM_CCIAANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String FORMA_AMM_CCIAASafe
		{
			get
			{
				if (IsFORMA_AMM_CCIAANull)
					return System.String.Empty;
				return FORMA_AMM_CCIAA;
			}
		}

		/// <summary>
		/// Value of field DATA_ACQUISIZIONE_ATTO
		/// </summary>
		public System.DateTime DATA_ACQUISIZIONE_ATTO
		{
			get
			{
				if(IsDATA_ACQUISIZIONE_ATTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ACQUISIZIONE_ATTO;
			}
			set
			{
				_dATA_ACQUISIZIONE_ATTONull = false;
				_dATA_ACQUISIZIONE_ATTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ACQUISIZIONE_ATTONull
		{
			get
			{
				return _dATA_ACQUISIZIONE_ATTONull;
			}
			set
			{
				_dATA_ACQUISIZIONE_ATTONull = value;
			}
		}

		/// <summary>
		/// Value of field DATA_DEPOSITO_ATTO
		/// </summary>
		public System.DateTime DATA_DEPOSITO_ATTO
		{
			get
			{
				if(IsDATA_DEPOSITO_ATTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DEPOSITO_ATTO;
			}
			set
			{
				_dATA_DEPOSITO_ATTONull = false;
				_dATA_DEPOSITO_ATTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DEPOSITO_ATTONull
		{
			get
			{
				return _dATA_DEPOSITO_ATTONull;
			}
			set
			{
				_dATA_DEPOSITO_ATTONull = value;
			}
		}

		/// <summary>
		/// Value of field NUMERO_ESAME
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
		/// Value of field DATA_ESAME
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

	}
}