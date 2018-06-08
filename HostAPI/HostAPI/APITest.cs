using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HostAPI
{
    [TestClass]
   public  class APITest
    {
        [TestMethod]
        public void APITest_InputConsole_RunsAppSuccessfully()
        {
            IInvokingClass c1 = new InvokingClass("Console");
            Assert.IsTrue(c1.InvokeProperApplication());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void APITest_UnknownApplication_ThrowsException()
        {
            IInvokingClass c1 = new InvokingClass("UnknownApp");
            Assert.IsTrue(c1.InvokeProperApplication());
        }
    }
}
