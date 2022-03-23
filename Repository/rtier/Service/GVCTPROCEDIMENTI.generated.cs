//
//Generated by DELTADATOR\gs0445 at 27/04/2009 11.14.32
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTPROCEDIMENTI
	/// </summary>
	public partial class GVCTPROCEDIMENTI
	{
		private System.Int32 _iDOBJ;
		private System.Int32 _iDOBJ_REGISTRO;
		private System.Int32 _iDOBJ_TIPO_PROCEDIMENTO;
		private System.Int32 _iDOBJ_TIPO_INIZIATIVA;
		private System.DateTime _dATA_INIZIO;
		private System.Boolean _dATA_INIZIONull = true;
		private System.DateTime _dATA_AVVISO;
		private System.Boolean _dATA_AVVISONull = true;
		private System.Int32 _tEMPI;
		private System.Boolean _tEMPINull = true;
		private System.DateTime _dATA_TEORICA_FINE;
		private System.Boolean _dATA_TEORICA_FINENull = true;
		private System.String _mOTIVO_SOSPENSIONE;
		private System.Boolean _mOTIVO_SOSPENSIONENull = true;
		private System.Int32 _gIORNI_SOSPENSIONE;
		private System.Boolean _gIORNI_SOSPENSIONENull = true;
		private System.DateTime _dATA_RIATTIVAZIONE;
		private System.Boolean _dATA_RIATTIVAZIONENull = true;
		private System.DateTime _dATA_TERMINE_FINE;
		private System.Boolean _dATA_TERMINE_FINENull = true;
		private System.DateTime _dATA_FINE;
		private System.Boolean _dATA_FINENull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;
		private System.Int32 _iDOBJ_TIPO_SOSPENSIONE;
		private System.Boolean _iDOBJ_TIPO_SOSPENSIONENull = true;
		private System.Int32 _iDOBJ_TIPO_CONCLUSIONE;
		private System.Boolean _iDOBJ_TIPO_CONCLUSIONENull = true;
		private System.String _rESPONSABILE;
		private System.Boolean _rESPONSABILENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTPROCEDIMENTI(){}

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
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_TIPO_PROCEDIMENTO
		{
			get
			{
				return _iDOBJ_TIPO_PROCEDIMENTO;
			}
			set
			{
				_iDOBJ_TIPO_PROCEDIMENTO = value;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// The field is mandatory.
		/// </summary>
		public System.Int32 IDOBJ_TIPO_INIZIATIVA
		{
			get
			{
				return _iDOBJ_TIPO_INIZIATIVA;
			}
			set
			{
				_iDOBJ_TIPO_INIZIATIVA = value;
			}
		}

		/// <summary>
		/// Data inizio procedimento
		/// </summary>
		public System.DateTime DATA_INIZIO
		{
			get
			{
				if(IsDATA_INIZIONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_INIZIO;
			}
			set
			{
				_dATA_INIZIONull = false;
				_dATA_INIZIO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_INIZIONull
		{
			get
			{
				return _dATA_INIZIONull;
			}
			set
			{
				_dATA_INIZIONull = value;
			}
		}

		/// <summary>
		/// Data avviso procedimento
		/// </summary>
		public System.DateTime DATA_AVVISO
		{
			get
			{
				if(IsDATA_AVVISONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_AVVISO;
			}
			set
			{
				_dATA_AVVISONull = false;
				_dATA_AVVISO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_AVVISONull
		{
			get
			{
				return _dATA_AVVISONull;
			}
			set
			{
				_dATA_AVVISONull = value;
			}
		}

		/// <summary>
		/// Tempi di procedimento
		/// </summary>
		public System.Int32 TEMPI
		{
			get
			{
				if(IsTEMPINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _tEMPI;
			}
			set
			{
				_tEMPINull = false;
				_tEMPI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsTEMPINull
		{
			get
			{
				return _tEMPINull;
			}
			set
			{
				_tEMPINull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 TEMPISafe
		{
			get
			{
				if (IsTEMPINull)
					return -1;
				return TEMPI;
			}
		}

		/// <summary>
		/// Data teorica fine procedimento
		/// </summary>
		public System.DateTime DATA_TEORICA_FINE
		{
			get
			{
				if(IsDATA_TEORICA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_TEORICA_FINE;
			}
			set
			{
				_dATA_TEORICA_FINENull = false;
				_dATA_TEORICA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_TEORICA_FINENull
		{
			get
			{
				return _dATA_TEORICA_FINENull;
			}
			set
			{
				_dATA_TEORICA_FINENull = value;
			}
		}

		/// <summary>
		/// Motivo della sospensione
		/// </summary>
		public System.String MOTIVO_SOSPENSIONE
		{
			get
			{
				if(IsMOTIVO_SOSPENSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _mOTIVO_SOSPENSIONE;
			}
			set
			{
				_mOTIVO_SOSPENSIONENull = false;
				_mOTIVO_SOSPENSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsMOTIVO_SOSPENSIONENull
		{
			get
			{
				return _mOTIVO_SOSPENSIONENull;
			}
			set
			{
				_mOTIVO_SOSPENSIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String MOTIVO_SOSPENSIONESafe
		{
			get
			{
				if (IsMOTIVO_SOSPENSIONENull)
					return System.String.Empty;
				return MOTIVO_SOSPENSIONE;
			}
		}

		/// <summary>
		/// Giorni di sospensione
		/// </summary>
		public System.Int32 GIORNI_SOSPENSIONE
		{
			get
			{
				if(IsGIORNI_SOSPENSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _gIORNI_SOSPENSIONE;
			}
			set
			{
				_gIORNI_SOSPENSIONENull = false;
				_gIORNI_SOSPENSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsGIORNI_SOSPENSIONENull
		{
			get
			{
				return _gIORNI_SOSPENSIONENull;
			}
			set
			{
				_gIORNI_SOSPENSIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 GIORNI_SOSPENSIONESafe
		{
			get
			{
				if (IsGIORNI_SOSPENSIONENull)
					return -1;
				return GIORNI_SOSPENSIONE;
			}
		}

		/// <summary>
		/// Data riattivazione
		/// </summary>
		public System.DateTime DATA_RIATTIVAZIONE
		{
			get
			{
				if(IsDATA_RIATTIVAZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_RIATTIVAZIONE;
			}
			set
			{
				_dATA_RIATTIVAZIONENull = false;
				_dATA_RIATTIVAZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_RIATTIVAZIONENull
		{
			get
			{
				return _dATA_RIATTIVAZIONENull;
			}
			set
			{
				_dATA_RIATTIVAZIONENull = value;
			}
		}

		/// <summary>
		/// Data termine finale
		/// </summary>
		public System.DateTime DATA_TERMINE_FINE
		{
			get
			{
				if(IsDATA_TERMINE_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_TERMINE_FINE;
			}
			set
			{
				_dATA_TERMINE_FINENull = false;
				_dATA_TERMINE_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_TERMINE_FINENull
		{
			get
			{
				return _dATA_TERMINE_FINENull;
			}
			set
			{
				_dATA_TERMINE_FINENull = value;
			}
		}

		/// <summary>
		/// Data conclusione
		/// </summary>
		public System.DateTime DATA_FINE
		{
			get
			{
				if(IsDATA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_FINE;
			}
			set
			{
				_dATA_FINENull = false;
				_dATA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_FINENull
		{
			get
			{
				return _dATA_FINENull;
			}
			set
			{
				_dATA_FINENull = value;
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

		/// <summary>
		/// identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_TIPO_SOSPENSIONE
		{
			get
			{
				if(IsIDOBJ_TIPO_SOSPENSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_TIPO_SOSPENSIONE;
			}
			set
			{
				_iDOBJ_TIPO_SOSPENSIONENull = false;
				_iDOBJ_TIPO_SOSPENSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_TIPO_SOSPENSIONENull
		{
			get
			{
				return _iDOBJ_TIPO_SOSPENSIONENull;
			}
			set
			{
				_iDOBJ_TIPO_SOSPENSIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_TIPO_SOSPENSIONESafe
		{
			get
			{
				if (IsIDOBJ_TIPO_SOSPENSIONENull)
					return -1;
				return IDOBJ_TIPO_SOSPENSIONE;
			}
		}

		/// <summary>
		/// Identificativo del record
		/// </summary>
		public System.Int32 IDOBJ_TIPO_CONCLUSIONE
		{
			get
			{
				if(IsIDOBJ_TIPO_CONCLUSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _iDOBJ_TIPO_CONCLUSIONE;
			}
			set
			{
				_iDOBJ_TIPO_CONCLUSIONENull = false;
				_iDOBJ_TIPO_CONCLUSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsIDOBJ_TIPO_CONCLUSIONENull
		{
			get
			{
				return _iDOBJ_TIPO_CONCLUSIONENull;
			}
			set
			{
				_iDOBJ_TIPO_CONCLUSIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 IDOBJ_TIPO_CONCLUSIONESafe
		{
			get
			{
				if (IsIDOBJ_TIPO_CONCLUSIONENull)
					return -1;
				return IDOBJ_TIPO_CONCLUSIONE;
			}
		}

		/// <summary>
		/// Responsabile del procedimento
		/// </summary>
		public System.String RESPONSABILE
		{
			get
			{
				if(IsRESPONSABILENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _rESPONSABILE;
			}
			set
			{
				_rESPONSABILENull = false;
				_rESPONSABILE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsRESPONSABILENull
		{
			get
			{
				return _rESPONSABILENull;
			}
			set
			{
				_rESPONSABILENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String RESPONSABILESafe
		{
			get
			{
				if (IsRESPONSABILENull)
					return System.String.Empty;
				return RESPONSABILE;
			}
		}

	}
}