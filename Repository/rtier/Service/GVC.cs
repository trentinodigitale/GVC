using System;
using System.Data;
using System.Configuration;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    /// <summary>
    /// The gateway to the Database GVC
    /// </summary>
    public partial class GVC
    {
        /// <summary>
        /// Returns true if a transaction is started
        /// </summary>
        /// <returns>true if a transaction is started, otherwise false</returns>
        public bool IsInTransaction
        {
            get
            {
                return !(_transaction == null);
            }
        }

        /// <summary>
        /// Returns the current transaction object
        /// </summary>
        public IDbTransaction Transaction
        {
            get
            {
                return _transaction;
            }
        }



        private ExportXML.ExportSoggetti _exportSoggetti;
        private ExportXML.ExportCooperative _exportCooperative;
        private Statistics.StatisticsCooperative _statisticsCooperative;
        private Search.SearchCooperative _searchCooperative;

        /// <summary>
        /// Gets a Data Access Layer to the ExportSoggetti
        /// </summary>
        public ExportXML.ExportSoggetti ExportSoggetti
        {
            get
            {
                if (null == _exportSoggetti)
                    _exportSoggetti = new ExportXML.ExportSoggetti((GVC)this);
                return _exportSoggetti;
            }
        }

        /// <summary>
        /// Gets a Data Access Layer to the ExportCooperative
        /// </summary>
        public ExportXML.ExportCooperative ExportCooperative
        {
            get
            {
                if (null == _exportCooperative)
                    _exportCooperative = new ExportXML.ExportCooperative((GVC)this);
                return _exportCooperative;
            }
        }

        /// <summary>
        /// Gets a Data Access Layer to the StatisticsCooperative
        /// </summary>
        public Statistics.StatisticsCooperative StatisticsCooperative
        {
            get
            {
                if (null == _statisticsCooperative)
                    _statisticsCooperative = new Statistics.StatisticsCooperative((GVC)this);
                return _statisticsCooperative;
            }
        }

        public Search.SearchCooperative SearchCooperative
        {
            get
            {
                if (null == _searchCooperative)
                    _searchCooperative = new Search.SearchCooperative((GVC)this);
                return _searchCooperative;
            }
        }
    }
}
