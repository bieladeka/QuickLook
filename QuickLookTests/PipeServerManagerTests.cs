using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickLook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickLook.Tests
{
    [TestClass()]
    public class PipeServerManagerTests
    {

        [TestMethod()]
        public void PipeServerManager_CleanFileName_FileNameIsCleaned()
        {
            var filename = @"thisIsValid.jpg";
            var result = PipeServerManager.CleanFileName(filename);
            Assert.AreEqual(filename, result);
        }

        [TestMethod()]
        public void PipeServerManager_IsImage_ImageWasVerified()
        {
            Assert.IsTrue(PipeServerManager.IsImage(@"C:\Users\lucia\Desktop\sk-kalendar-2018-12.png"));
        }

        [TestMethod()]
        public void PipeServerManager_OpenTempCopyFile_ImageWasVerified()
        {
            Assert.AreEqual("ImageTransylvania.png", PipeServerManager.OpenTempCopyFile("ImageTransylvania.png"));
        }

        [TestMethod]
        public void GivenANewInstance_MessageProxyControllerManager_ExpectAPositiveAnswer()
        {
            var c = new PipeServerManager();  
            var result = c.IsMessageProxyControllerManager();
            Assert.IsTrue(result);
        }

    }
}