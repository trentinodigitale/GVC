//
//Generated by DELTADATOR\GS0445 at 26/03/2009 9.03.14
//

using System;
using System.Data;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
	/// <summary>
	/// Data Access Layer for the stored procedures
	/// </summary>
	public partial class StoredProcedures
	{
		private GVC _db;

		/// <summary>
		/// Default constructor
		/// </summary>
		/// <param name="db">Istance of the Database</param>
		public StoredProcedures(GVC db)
			{
			_db = db;
			}

		/// <summary>
		/// Property for the Database
		/// </summary>
		public GVC Database
		{
			get
			{
				return _db;
			}
		}

		/// <summary>
		/// Fills a DataTable using an IDbCommand
		/// </summary>
		/// <param name="command">The IDbCommand</param>
		/// <returns>A filled DataTable</returns>
		protected DataTable CreateDataTable(IDbCommand command)
		{
			return _db.CreateDataTable(command);
		}
		

	}
}
