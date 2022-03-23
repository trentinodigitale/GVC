//
//Generated by DELTADATOR\GS0445 at 17/07/2009 11.39.26
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCDGRUPPI_PARITETICI
	/// </summary>
	public partial class GVCDGRUPPI_PARITETICI
	{
		private System.Int32 _iDOBJ;
		private System.String _nUMERO_ATTO;
		private System.Boolean _nUMERO_ATTONull = true;
		private System.DateTime _dATA_ATTO;
		private System.Boolean _dATA_ATTONull = true;
		private System.DateTime _dATA_SCADENZA;
		private System.Boolean _dATA_SCADENZANull = true;
		private System.String _dESCRIZIONE;
		private System.Boolean _dESCRIZIONENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCDGRUPPI_PARITETICI(){}

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
		/// Numero atto
		/// </summary>
		public System.String NUMERO_ATTO
		{
			get
			{
				if(IsNUMERO_ATTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _nUMERO_ATTO;
			}
			set
			{
				_nUMERO_ATTONull = false;
				_nUMERO_ATTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsNUMERO_ATTONull
		{
			get
			{
				return _nUMERO_ATTONull;
			}
			set
			{
				_nUMERO_ATTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String NUMERO_ATTOSafe
		{
			get
			{
				if (IsNUMERO_ATTONull)
					return System.String.Empty;
				return NUMERO_ATTO;
			}
		}

		/// <summary>
		/// Data atto
		/// </summary>
		public System.DateTime DATA_ATTO
		{
			get
			{
				if(IsDATA_ATTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dATA_ATTO;
			}
			set
			{
				_dATA_ATTONull = false;
				_dATA_ATTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDATA_ATTONull
		{
			get
			{
				return _dATA_ATTONull;
			}
			set
			{
				_dATA_ATTONull = value;
			}
		}

		/// <summary>
		/// Data scadenza
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
		/// Descrizione
		/// </summary>
		public System.String DESCRIZIONE
		{
			get
			{
				if(IsDESCRIZIONENull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _dESCRIZIONE;
			}
			set
			{
				_dESCRIZIONENull = false;
				_dESCRIZIONE = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsDESCRIZIONENull
		{
			get
			{
				return _dESCRIZIONENull;
			}
			set
			{
				_dESCRIZIONENull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String DESCRIZIONESafe
		{
			get
			{
				if (IsDESCRIZIONENull)
					return System.String.Empty;
				return DESCRIZIONE;
			}
		}

	}
}