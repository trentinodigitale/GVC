using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using it.dedagroup.GVC.Repository.Common.FDT;

namespace it.dedagroup.GVC.Repository.Common.Services
{
    [ServiceContract]
    public interface IUsers
    {
        /// <summary>
        /// Changes the password for the specified user.
        /// </summary>
        /// <param name="userName">Username.</param>
        /// <param name="newPassword">The new password.</param>
        /// <returns></returns>
        [OperationContract]
        Boolean ChangePassword(String userName, String newPassword);

        /// <summary>
        /// Gets the extended user.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        UtenteFDT GetExtended();

        /// <summary>
        /// Determines whether the client is allowed to access the server.
        /// </summary>
        /// <param name="assemblyVersion">The assembly version.</param>
        /// <returns>
        /// 	<c>true</c> if the client is allowed; otherwise, <c>false</c>.
        /// </returns>
        [OperationContract]
        Boolean IsClientAllowed(String assemblyVersion);
    }
}
