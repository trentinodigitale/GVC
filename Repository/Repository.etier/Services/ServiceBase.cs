using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.Services;
using it.dedagroup.GVC.Repository.Common.FDT;
using it.dedagroup.GVC.Repository.Common.Converters;
using it.dedagroup.GVC.Repository.rtier.Service;
using System.Data;
using it.dedagroup.GVC.Repository.Common.Configurations;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.IdentityModel.Tokens;
using System.Security.Principal;

namespace it.dedagroup.GVC.Repository.etier.Services
{
    public class ServiceBase
    {

		#region Fields (3) 

        [ThreadStatic]
        private static it.dedagroup.GVC.Repository.rtier.Service.GVC _gvcDB;
        private String callerIdentity = String.Empty;
        private List<String> callerRoles = new List<String>();

		#endregion Fields 

		#region Constructors (1) 

        public ServiceBase()
        {
            SetCallerPrincipal();
        }

		#endregion Constructors 

		#region Properties (2) 

        /// <summary>
        /// Gets the caller identity (username).
        /// </summary>
        /// <value>The caller identity.</value>
        protected String CallerIdentity
        {
            get
            {
                if (!String.IsNullOrEmpty(callerIdentity))
                {
                    return callerIdentity.ToUpper();
                }
                return callerIdentity;
            }
        }

        public it.dedagroup.GVC.Repository.rtier.Service.GVC GVCDB
        {
            get
            {
                if (_gvcDB == null)
                {
                    try
                    {
                        _gvcDB = new it.dedagroup.GVC.Repository.rtier.Service.GVC();
                    }
                    catch (Exception ex)
                    {
                        bool rethrow = false; 
                        ExceptionPolicy.HandleException(ex, ExceptionsPolicies.EnterpriseTier);
                        if (rethrow)
                        {
                            throw;
                        }
                    }
                    finally
                    {

                    }

                }
                return _gvcDB;
            }
        }

		#endregion Properties 

		#region Methods (9) 


		// Public Methods (3) 

        /// <summary>
        /// Starts a IDbTransaction against the Database
        /// </summary>
        /// <returns>An IDbTransaction</returns>
        public IDbTransaction BeginTransaction()
        {
            return GVCDB.BeginTransaction();
        }

        /// <summary>
        /// Commits an IDbTransaction
        /// </summary>
        public void CommitTransaction()
        {
            GVCDB.CommitTransaction();
        }

        /// <summary>
        /// Rollbacks an IDbTransaction
        /// </summary>
        public void RollbackTransaction()
        {
            GVCDB.RollbackTransaction();
        }



		// Protected Methods (6) 

        /// <summary>
        /// Determines whether the user has the specified role.
        /// </summary>
        /// <param name="role">The role.</param>
        /// <returns>
        /// 	<c>true</c> if the user has the specified role; otherwise, <c>false</c>.
        /// </returns>
        protected Boolean CallerIsInRole(String role)
        {
            return callerRoles.IndexOf(role) != -1;
        }

        /// <summary>
        /// Gets the caller roles.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        protected String[] GetCallerRoles(String userName)
        {
            try
            {
                return GVCDB.GVCRUTENTI_RUOLICollection.GetRolesByUserName(userName);
            }
            catch
            {
                return new String[] { };
            }
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="eventID">The event ID.</param>
        /// <param name="priority">The priority.</param>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        protected void Log(int eventID, int priority, string message, string category)
        {
            try
            {
                LogEntry logEntry = new LogEntry();
                logEntry.EventId = eventID;
                logEntry.Priority = priority;
                logEntry.Message = message;
                logEntry.Categories.Clear();
                logEntry.Categories.Add(category);
                Logger.Write(logEntry);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="category">The category.</param>
        protected void Log(string message, string category)
        {
            Log(0, 0, message, category);
        }

        /// <summary>
        /// Logs a message in the general category.
        /// </summary>
        /// <param name="message">The message.</param>
        protected void Log(string message)
        {
            Log(0, 0, message, LoggingCategories.General);
        }

        /// <summary>
        /// Set the caller principal based on his identity.
        /// </summary>
        /// <returns></returns>
        protected void SetCallerPrincipal()
        {
            try
            {
                System.IdentityModel.Tokens.SamlSecurityToken saml = (System.IdentityModel.Tokens.SamlSecurityToken)
                    System.ServiceModel.OperationContext.Current.IncomingMessageProperties.Security.ProtectionToken.SecurityToken;

                foreach (SamlAttributeStatement statement in saml.Assertion.Statements)
                {
                    String[] callerIdentityItems = statement.SamlSubject.Name.Split('\\');
                    if (callerIdentityItems.Length == 2)
                        callerIdentity = callerIdentityItems[1];
                    else
                        callerIdentity = statement.SamlSubject.Name;
                    break;
                }

                // Log(String.Format("Connected Username is: " + callerIdentity, LoggingCategories.Trace));

                // callerRoles = new List<string>(GetCallerRoles(callerIdentity));

                System.Threading.Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(callerIdentity), callerRoles.ToArray());
            }
            catch (Exception ex)
            {
                ExceptionPolicy.HandleException(ex, ExceptionsPolicies.EnterpriseTier);
                //throw;
            }
        }


		#endregion Methods 

    }
}
