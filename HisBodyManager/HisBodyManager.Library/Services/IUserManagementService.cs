using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using HisBodyManager.DataAccess;

namespace HisBodyManager.Library.Services
{
    [ServiceContract()]
    public interface IUserManagementService
    {
        [OperationContract]
        user SaveUser(user user);

        [OperationContract]
        IEnumerable<user> GetAllUsers();

        [OperationContract]
        user GetUser(user user);

        [OperationContract]
        group Savegroup(group group);

        [OperationContract]
        IEnumerable<group> GetGroups();

        [OperationContract]
        group GetGroup(group group);

        [OperationContract]
        usergroup SaveUserGroup(usergroup userGroup);

    }
}
