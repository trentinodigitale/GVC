using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.FDT
{
    /// <summary>
    /// Rappresents an User
    /// </summary>
    [Serializable]
    public class UtenteFDT
    {

		#region Fields (2) 

        private String username;
        private String[] ruoli;

		#endregion Fields 

		#region Properties (2) 

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        /// <value>The username of the user.</value>
        public String UserName
        {
            get { return username; }
            set { username = value.ToUpper(); }
        }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>The roles.</value>
        public String[] Ruoli
        {
            get { return ruoli; }
            set { ruoli = value; }
        }

		#endregion Properties 

    }
}
