using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Talk.Required;

namespace PeelAndSlice.Tests.Examples
{
    [TestClass]
    public class Examples
    {
        [TestMethod]
        public void MoqExample()
        {
            // begin-snippet: mock_example
            var listMock = new Mock<IList>(MockBehavior.Strict);
            listMock.Setup(l => l.Count).Returns(5).AtMost(1);
            IList list = listMock.Object;
            Assert.AreEqual(5, list.Count);
            // end-snippet
        }
    }
    
}
