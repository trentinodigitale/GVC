//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCDTIPI_MODIFICA
	/// </summary>
	public partial class GVCDTIPI_MODIFICA
	{
		private System.Int32 _iDOBJ;
		private System.String _dESCRIZIONE;
		private System.Int32 _fLAG_APERTO;
		private System.Boolean _fLAG_APERTONull = true;
		private System.Int32 _fLAG_ATTIVO;
		private System.Boolean _fLAG_ATTIVONull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCDTIPI_MODIFICA(){}

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
		/// Descrizione tipo modifica statutaria
		/// The field is mandatory.
		/// </summary>
		public System.String DESCRIZIONE
		{
			get
			{
				return _dESCRIZIONE;
			}
			set
			{
				_dESCRIZIONE = value;
			}
		}

		/// <summary>
		/// 1=voce aperta
		/// </summary>
		public System.Int32 FLAG_APERTO
		{
			get
			{
				if(IsFLAG_APERTONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fLAG_APERTO;
			}
			set
			{
				_fLAG_APERTONull = false;
				_fLAG_APERTO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFLAG_APERTONull
		{
			get
			{
				return _fLAG_APERTONull;
			}
			set
			{
				_fLAG_APERTONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 FLAG_APERTOSafe
		{
			get
			{
				if (IsFLAG_APERTONull)
					return -1;
				return FLAG_APERTO;
			}
		}

		/// <summary>
		/// Flag attivo 0=attivo 1=non attivo
		/// </summary>
		public System.Int32 FLAG_ATTIVO
		{
			get
			{
				if(IsFLAG_ATTIVONull)
					throw new InvalidOperationException("Impossibile leggere il dato in quanto vale DBNull.");
				return _fLAG_ATTIVO;
			}
			set
			{
				_fLAG_ATTIVONull = false;
				_fLAG_ATTIVO = value;
			}
		}

		/// <summary>
		/// Return true if field is null, otherwise false.
		/// </summary>
		public bool IsFLAG_ATTIVONull
		{
			get
			{
				return _fLAG_ATTIVONull;
			}
			set
			{
				_fLAG_ATTIVONull = value;
			}
		}

		/// <summary>
		///  This property is intend to use with string and integer fields 
		///  that can contain nullable values. 
		///  It is read only. 
		/// </summary>
		/// <returns>The value of the field or String.Empty/-1</returns>
		public System.Int32 FLAG_ATTIVOSafe
		{
			get
			{
				if (IsFLAG_ATTIVONull)
					return -1;
				return FLAG_ATTIVO;
			}
		}

	}
}