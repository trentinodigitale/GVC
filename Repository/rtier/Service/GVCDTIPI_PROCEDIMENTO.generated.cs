//
//Generated by DELTADATOR\gs0445 at 27/04/2009 11.14.31
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCDTIPI_PROCEDIMENTO
	/// </summary>
	public partial class GVCDTIPI_PROCEDIMENTO
	{
		private System.Int32 _iDOBJ;
		private System.String _dESCRIZIONE;
		private System.Int32 _fLAG_ATTIVO;
		private System.Boolean _fLAG_ATTIVONull = true;
		private System.Int32 _tEMPI;
		private System.Boolean _tEMPINull = true;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCDTIPI_PROCEDIMENTO(){}

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
		/// Descrizione
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
		/// 0= Attivo, 1= Non Attivo
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

		/// <summary>
		/// Value of field TEMPI
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

	}
}