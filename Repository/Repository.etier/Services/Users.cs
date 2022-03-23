using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.deltadator.GVC.Repository.etier;
using it.dedagroup.GVC.Repository.Common.Configurations;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace it.dedagroup.GVC.Repository.etier.Services
{
    public class Users : ServiceBase, IUsers
    {

		#region Methods (3) 


		// Public Methods (3) 

        /// <summary>
        /// Changes the password for the specified user.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="newPassword">The new password.</param>
        /// <returns></returns>
        public Boolean ChangePassword(String userName, String newPassword)
        {
            try
            {
                ADHelper.SetUserPassword(userName, newPassword);
                return true;
            }
            catch (Exception msex)
            {
                String messLog =
                        String.Format("Exception in Method: {0}. Parameters: {1}, {2}",
                                            "ChangePassword",
                                            userName,
                                            "[Removed]");

                Log(messLog, LoggingCategories.General);

                ExceptionPolicy.HandleException(msex, ExceptionsPolicies.EnterpriseTier);
                throw;
            }
        }

        /// <summary>
        /// Gets the extended user.
        /// </summary>
        /// <returns></returns>
        public UtenteFDT GetExtended()
        {
         
            UtenteFDT user = new UtenteFDT();

            try
            {
                user.UserName = CallerIdentity;
                if (String.IsNullOrEmpty(user.UserName))
                    throw new System.Security.Authentication.AuthenticationException();

                user.Ruoli = GetCallerRoles(user.UserName);
            }
            catch (Exception msex)
            {
                String messLog =
                        String.Format("Exception in Method: {0}.",
                                            "GetExtended");

                Log(messLog, LoggingCategories.General);

                ExceptionPolicy.HandleException(msex, ExceptionsPolicies.EnterpriseTier);
                throw;
            }
            return user;
        }

        /// <summary>
        /// Determines whether the client is allowed to access the server.
        /// </summary>
        /// <param name="assemblyVersion">The assembly version.</param>
        /// <returns>
        /// 	<c>true</c> if the client is allowed; otherwise, <c>false</c>.
        /// </returns>
        public Boolean IsClientAllowed(String assemblyVersion)
        {
            if (Match("1.6.0.*", assemblyVersion))
                return true;
            else
                return false;

        }


        private static bool Match(String wildCards, String stringToMatch)
        {
            if (wildCards == null)
                return false;
            if (stringToMatch == null)
                return false;
            if (wildCards.Length == 0) return stringToMatch.Length == 0;
            if (stringToMatch.Length == 0 && wildCards[0] != '*') return false;
            if (wildCards[0] == '*' && wildCards.Length > 1)
                for (int index = 0; index < stringToMatch.Length; index++)
                {
                    if (Match(wildCards.Substring(1), stringToMatch.Substring(index)))
                        return true;
                }
            else if (wildCards[0] == '*')
                return true;
            else if (wildCards[0] == stringToMatch[0])
                return Match(wildCards.Substring(1), stringToMatch.Substring(1));
            return false;
        }


        #endregion Methods 

    }
}
