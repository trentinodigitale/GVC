using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier.Service
{
    public partial class GVCRUTENTI_RUOLICollection
    {

		#region Methods (1) 


		// Public Methods (1) 

        /// <summary>
        /// Gets the roles for the provided username.
        /// </summary>
        /// <param name="userName">The username.</param>
        /// <returns></returns>
        public String[] GetRolesByUserName(String userName)
        {
            List<String> roles = new List<string>();

            GVCRUTENTI_RUOLI[] items = GetAsArray(String.Format("{0} = '{1}'",
                USERNAMEColumnName,
                userName.ToUpper()), String.Empty);

            if (items != null)
            {
                foreach (GVCRUTENTI_RUOLI item in items)
                {
                    roles.Add(item.RUOLO);
                }
            }
            return roles.ToArray();
        }


		#endregion Methods 

    }
}
