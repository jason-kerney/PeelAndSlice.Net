using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Talk.Required;

namespace Talk.Tests
{
    [TestClass]
    public class TestSamples
    {
        [TestMethod]
        public void TestSimplePeel()
        {
        }

        [TestMethod]
        public void TestSimpleSlice()
        {
            var loan1 = new Mock<Loan>(MockBehavior.Strict);

            loan1.Setup(l => l.IsOverDue()).Returns(true);
            loan1.Setup(l => l.GetAmount()).Returns(5);

            new SimpleSlice().EscalateProblems(new Loan[] { loan1.Object }, null);
        }
    }
}