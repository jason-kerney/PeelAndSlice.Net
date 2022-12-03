using Microsoft.VisualStudio.TestTools.UnitTesting;
using Talk.Required;

namespace Talk.Tests
{
    [TestClass]
    public class TestBadFruit
    {
        [TestMethod]
        public void Test()
        {
            new BadFruit().CreateLoans2(new Loan[]{});
        }
    }
}