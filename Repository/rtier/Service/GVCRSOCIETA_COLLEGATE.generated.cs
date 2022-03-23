//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.13
//

using System;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Description of GVCRSOCIETA_COLLEGATE
	/// </summary>
	public partial class GVCRSOCIETA_COLLEGATE
	{
		private System.Int32 _iDOBJ;
		private System.Int32 _iDOBJ_MODIFICA_STATUTARIA;
		private System.Int32 _iDOBJ_SOGGETTO;
		private System.String _nOTE;
		private System.Boolean _nOTENull = true;

		/// <summary>
		/// Default constructor
		/// </summary>
		public GVCRSOCIETA_COLLEGATE(){}

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
		public System.Int32 IDOBJ_MODIFICA_STATUTARIA
		{
			get
			{
				return _iDOBJ_MODIFICA_STATUTARIA;
			}
			set
			{
				_iDOBJ_MODIFICA_STATUTARIA = value;
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