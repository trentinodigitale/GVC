//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.14
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCTPROCEDURE_COATTE
	/// </summary>
	public partial class GVCTPROCEDURE_COATTE
	{
		private System.Int32 _iDOBJ;
		private System.Int32 _iDOBJ_TIPO_PROCEDURA;
		private System.Int32 _iDOBJ_REGISTRO;
		private System.String _nUMERO_DELIBERA;
		private System.Boolean _nUMERO_DELIBERANull = true;
		private System.DateTime _dATA_DELIBERA;
		private System.Boolean _dATA_DELIBERANull = true;
		private System.String _nUMERO_DETERMINA;
		private System.Boolean _nUMERO_DETERMINANull = true;
		private System.DateTime _dATA_DETERMINA;
		private System.Boolean _dATA_DETERMINANull = true;
		private System.DateTime _dATA_INIZIO;
		private System.Boolean _dATA_INIZIONull = true;
		private System.DateTime _dATA_ISCRIZIONE_RI;
		private System.Boolean _dATA_ISCRIZIONE_RINull = true;
		private System.DateTime _dATA_SCADENZA;
		private System.Boolean _dATA_SCADENZANull = true;
		private System.DateTime _dATA_CONCLUSIONE;
		private System.Boolean _dATA_CONCLUSIONENull = true;
		private System.String _nUMERO_DELIBERA_FINE;
		private System.Boolean _nUMERO_DELIBERA_FINENull = true;
		private System.DateTime _dATA_DELIBERA_FINE;
		private System.Boolean _dATA_DELIBERA_FINENull = true;
		private System.String _nUMERO_DETERMINA_FINE;
		private System.Boolean _nUMERO_DETERMINA_FINENull = true;
		private System.DateTime _dATA_DETERMINA_FINE;
		private System.Boolean _dATA_DETERMINA_FINENull = true;
		private System.String _oPERATOREULTMOD;
		private System.Boolean _oPERATOREULTMODNull = true;
		private System.DateTime _dATAORAULTMOD;
		private System.Boolean _dATAORAULTMODNull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCTPROCEDURE_COATTE(){}

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
		public System.Int32 IDOBJ_TIPO_PROCEDURA
		{
			get
			{
				return _iDOBJ_TIPO_PROCEDURA;
			}
			set
			{
				_iDOBJ_TIPO_PROCEDURA = value;
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
		/// Numero delibera commissione
		/// </summary>
		public System.String NUMERO_DELIBERA
		{
			get
			{
				if(IsNUMERO_DELIBERANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_DELIBERA;
			}
			set
			{
				_nUMERO_DELIBERANull = false;
				_nUMERO_DELIBERA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_DELIBERANull
		{
			get
			{
				return _nUMERO_DELIBERANull;
			}
			set
			{
				_nUMERO_DELIBERANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_DELIBERASafe
		{
			get
			{
				if (IsNUMERO_DELIBERANull)
					return System.String.Empty;
				return NUMERO_DELIBERA;
			}
		}

		/// <summary>
		/// Data delibera commissione
		/// </summary>
		public System.DateTime DATA_DELIBERA
		{
			get
			{
				if(IsDATA_DELIBERANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DELIBERA;
			}
			set
			{
				_dATA_DELIBERANull = false;
				_dATA_DELIBERA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DELIBERANull
		{
			get
			{
				return _dATA_DELIBERANull;
			}
			set
			{
				_dATA_DELIBERANull = value;
			}
		}

		/// <summary>
		/// Numero determina
		/// </summary>
		public System.String NUMERO_DETERMINA
		{
			get
			{
				if(IsNUMERO_DETERMINANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_DETERMINA;
			}
			set
			{
				_nUMERO_DETERMINANull = false;
				_nUMERO_DETERMINA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_DETERMINANull
		{
			get
			{
				return _nUMERO_DETERMINANull;
			}
			set
			{
				_nUMERO_DETERMINANull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_DETERMINASafe
		{
			get
			{
				if (IsNUMERO_DETERMINANull)
					return System.String.Empty;
				return NUMERO_DETERMINA;
			}
		}

		/// <summary>
		/// Data determina
		/// </summary>
		public System.DateTime DATA_DETERMINA
		{
			get
			{
				if(IsDATA_DETERMINANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DETERMINA;
			}
			set
			{
				_dATA_DETERMINANull = false;
				_dATA_DETERMINA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DETERMINANull
		{
			get
			{
				return _dATA_DETERMINANull;
			}
			set
			{
				_dATA_DETERMINANull = value;
			}
		}

		/// <summary>
		/// Data inizio procedura
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
		/// Data iscrizione al R.I.
		/// </summary>
		public System.DateTime DATA_ISCRIZIONE_RI
		{
			get
			{
				if(IsDATA_ISCRIZIONE_RINull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ISCRIZIONE_RI;
			}
			set
			{
				_dATA_ISCRIZIONE_RINull = false;
				_dATA_ISCRIZIONE_RI = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ISCRIZIONE_RINull
		{
			get
			{
				return _dATA_ISCRIZIONE_RINull;
			}
			set
			{
				_dATA_ISCRIZIONE_RINull = value;
			}
		}

		/// <summary>
		/// Data scadenza procedura
		/// </summary>
		public System.DateTime DATA_SCADENZA
		{
			get
			{
				if(IsDATA_SCADENZANull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_SCADENZA;
			}
			set
			{
				_dATA_SCADENZANull = false;
				_dATA_SCADENZA = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_SCADENZANull
		{
			get
			{
				return _dATA_SCADENZANull;
			}
			set
			{
				_dATA_SCADENZANull = value;
			}
		}

		/// <summary>
		/// Data conclusione procedura
		/// </summary>
		public System.DateTime DATA_CONCLUSIONE
		{
			get
			{
				if(IsDATA_CONCLUSIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_CONCLUSIONE;
			}
			set
			{
				_dATA_CONCLUSIONENull = false;
				_dATA_CONCLUSIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_CONCLUSIONENull
		{
			get
			{
				return _dATA_CONCLUSIONENull;
			}
			set
			{
				_dATA_CONCLUSIONENull = value;
			}
		}

		/// <summary>
		/// Numero delibera fine incarico
		/// </summary>
		public System.String NUMERO_DELIBERA_FINE
		{
			get
			{
				if(IsNUMERO_DELIBERA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_DELIBERA_FINE;
			}
			set
			{
				_nUMERO_DELIBERA_FINENull = false;
				_nUMERO_DELIBERA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_DELIBERA_FINENull
		{
			get
			{
				return _nUMERO_DELIBERA_FINENull;
			}
			set
			{
				_nUMERO_DELIBERA_FINENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_DELIBERA_FINESafe
		{
			get
			{
				if (IsNUMERO_DELIBERA_FINENull)
					return System.String.Empty;
				return NUMERO_DELIBERA_FINE;
			}
		}

		/// <summary>
		/// Data delibera fine incarico
		/// </summary>
		public System.DateTime DATA_DELIBERA_FINE
		{
			get
			{
				if(IsDATA_DELIBERA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DELIBERA_FINE;
			}
			set
			{
				_dATA_DELIBERA_FINENull = false;
				_dATA_DELIBERA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DELIBERA_FINENull
		{
			get
			{
				return _dATA_DELIBERA_FINENull;
			}
			set
			{
				_dATA_DELIBERA_FINENull = value;
			}
		}

		/// <summary>
		/// Numero determina fine incarico
		/// </summary>
		public System.String NUMERO_DETERMINA_FINE
		{
			get
			{
				if(IsNUMERO_DETERMINA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_DETERMINA_FINE;
			}
			set
			{
				_nUMERO_DETERMINA_FINENull = false;
				_nUMERO_DETERMINA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_DETERMINA_FINENull
		{
			get
			{
				return _nUMERO_DETERMINA_FINENull;
			}
			set
			{
				_nUMERO_DETERMINA_FINENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_DETERMINA_FINESafe
		{
			get
			{
				if (IsNUMERO_DETERMINA_FINENull)
					return System.String.Empty;
				return NUMERO_DETERMINA_FINE;
			}
		}

		/// <summary>
		/// Data determina fine incarico
		/// </summary>
		public System.DateTime DATA_DETERMINA_FINE
		{
			get
			{
				if(IsDATA_DETERMINA_FINENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_DETERMINA_FINE;
			}
			set
			{
				_dATA_DETERMINA_FINENull = false;
				_dATA_DETERMINA_FINE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_DETERMINA_FINENull
		{
			get
			{
				return _dATA_DETERMINA_FINENull;
			}
			set
			{
				_dATA_DETERMINA_FINENull = value;
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