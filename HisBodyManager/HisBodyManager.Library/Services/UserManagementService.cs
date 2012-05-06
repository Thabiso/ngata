using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HisBodyManager.DataAccess;

namespace HisBodyManager.Library.Services
{
    public class UserManagementService : IUserManagementService
    {
        public DataAccess.user SaveUser(DataAccess.user user)
        {
            hisbodymanagerEntities context = new hisbodymanagerEntities();

            if (user.Id > 0)
            {
                context.users.Attach(user);
                context.SaveChanges();
            }
            else
            {
                context.users.AddObject(user);
                context.SaveChanges();
            }

            return user;

        }

        public IEnumerable<DataAccess.user> GetAllUsers()
        {
            hisbodymanagerEntities context = new hisbodymanagerEntities();
            return context.users.Where(x => x.IsActive);
        }

        public DataAccess.user GetUser(DataAccess.user user)
        {
            hisbodymanagerEntities context = new hisbodymanagerEntities();
            return context.users.FirstOrDefault(x => x.Id == user.Id);
        }

        public DataAccess.group Savegroup(DataAccess.group group)
        {
            var context = new hisbodymanagerEntities();

            if (group.Id > 0)
            {
                context.groups.Attach(group);
                context.SaveChanges();
            }
            else
            {
                context.AddTogroups(group);
                context.SaveChanges();
            }

            return group;
        }

        public IEnumerable<DataAccess.group> GetGroups()
        {
            var context = new hisbodymanagerEntities();

            return context.groups.Where(x => x.IsActive);
        }

        public DataAccess.group GetGroup(DataAccess.group group)
        {
            var context = new hisbodymanagerEntities();

            return context.groups.FirstOrDefault(x => x.Id == group.Id);
        }

        public DataAccess.usergroup SaveUserGroup(DataAccess.usergroup userGroup)
        {
            var context = new hisbodymanagerEntities();

            if (userGroup.Id > 0)
            {
                context.usergroups.Attach(userGroup);
                context.SaveChanges();
            }
            else
            {
                context.usergroups.AddObject(userGroup);
                context.SaveChanges();
            }
            return userGroup;
        }
    }
}
