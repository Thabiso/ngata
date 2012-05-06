using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HisBodyManager.Server.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service=new ServiceReference1.UserManagementServiceClient();
            service.Savegroup(new ServiceReference1.group{
            Name="Admin",IsActive=true});
        }
    }
}
