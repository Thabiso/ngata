using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HisBodyManager.Tests.DataAccess
{
    [TestClass]
    public class UserEntitiesTests
    {
        [TestMethod]
        public void User_Test_That_It_Is_Working()
        {
            var context = new HisBodyManager.DataAccess.hisbodymanagerEntities();
            var list = context.groups.ToList();

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count>0);


        }
    }
}
