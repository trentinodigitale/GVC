//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCRUTENTI_RUOLI
	/// </summary>
	public partial class GVCRUTENTI_RUOLI
	{
		private System.Int32 _iDOBJ;
		private System.String _uSERNAME;
		private System.String _rUOLO;
		private System.Boolean _rUOLONull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCRUTENTI_RUOLI(){}

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
		/// Identificativo dell'utente
		/// The field is mandatory.
		/// </summary>
		public System.String USERNAME
		{
			get
			{
				return _uSERNAME;
			}
			set
			{
				_uSERNAME = value;
			}
		}

		/// <summary>
		/// Ruolo utente
		/// </summary>
		public System.String RUOLO
		{
			get
			{
				if(IsRUOLONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _rUOLO;
			}
			set
			{
				_rUOLONull = false;
				_rUOLO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsRUOLONull
		{
			get
			{
				return _rUOLONull;
			}
			set
			{
				_rUOLONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.String RUOLOSafe
		{
			get
			{
				if (IsRUOLONull)
					return System.String.Empty;
				return RUOLO;
			}
		}

	}
}