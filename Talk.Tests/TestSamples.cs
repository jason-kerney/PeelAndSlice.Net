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
            loan1.Setup(l => l.IsOverDue()).Returns(true).AtMost(2);
            loan1.Setup(l => l.GetAmount()).Returns(51).AtMost(2);
            loan1.Setup(l => l.SaveStatus("Escalated", null)).AtMost(1);

            var loan2 = new Mock<Loan>(MockBehavior.Strict);
            loan2.Setup(l => l.IsOverDue()).Returns(true).AtMost(1);
            loan2.Setup(l => l.GetAmount()).Returns(6000).AtMost(1);
            loan2.Setup(l => l.SaveStatus("Critical", null)).AtMost(1);

            new SimpleSlice().EscalateProblems(new Loan[] { loan1.Object, loan2.Object}, null);
        }
    }
}