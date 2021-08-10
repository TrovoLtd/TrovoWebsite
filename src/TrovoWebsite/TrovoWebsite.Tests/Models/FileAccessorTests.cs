using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrovoWebsite.Models;

namespace TrovoWebsite.Tests.Models
{
    [TestClass]
    public class FileAccessorTests
    {
        [TestMethod]
        public void TestMethod1()
        {

            FileAccessor fileAccessor = new FileAccessor();

            string result = fileAccessor.Access(@"..\..\TestContent\TestContent.md");

            Assert.AreEqual("Here is some test content.", result);

        }
    }
}
