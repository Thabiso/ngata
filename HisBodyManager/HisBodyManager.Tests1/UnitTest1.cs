using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HisBodyManager.Tests1
{
    [TestClass]
    public class UserEntitiesTests
    {
        [TestMethod]
        public void User_Test_That_It_Is_Working()
        {

            //using(new TransactionScope())
            var context = new HisBodyManager.DataAccess.hisbodymanagerEntities();
            var list = context.groups.ToList();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 0);
        }


        [TestMethod]
        public void Test_That_UserGroup_IsFullyLoading()
        {
            var context = new HisBodyManager.DataAccess.hisbodymanagerEntities();
            var user = new DataAccess.user
            {
                ChurchId = 1,
                DateCreated = DateTime.Now,
                IsActive = true,
                password = "testPassword",
                username = "testuser"

            };
            context.AddTousers(user);
            var group = context.groups.FirstOrDefault();
            var usergroup = new DataAccess.usergroup
            {
                Groupid = group.Id,
                UserId = user.Id,
                IsActive = true,
            };
            context.usergroups.AddObject(usergroup);
            context.SaveChanges();

            var usergroups = context.usergroups.ToList();
            var usergroupresult = context.usergroups.Where(x => x.Id == usergroup.Id);
            context.DeleteObject(user);
            
            context.groups.DeleteObject(group);
            context.users.DeleteObject(user);
            
            context.usergroups.DeleteObject(usergroup);
            context.SaveChanges();

            Assert.IsNotNull(usergroups.FirstOrDefault().user);
            Assert.IsNotNull(usergroups.FirstOrDefault().group);


        }
    }
}
