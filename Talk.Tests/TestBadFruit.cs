using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Talk.Required;

namespace Talk.Tests
{
    [TestClass]
    public class TestBadFruit
    {
        [TestMethod]
        public void Test()
        {
            var tom = new Person("tom");
            List<Person> people = new List<Person>() {tom};
            var loan1 = new Mock<Loan>(MockBehavior.Strict);
            loan1.Expect(l => l.GetPeopleOnLoan()).Returns(people).AtMost(1);
            var loan2 = new Mock<Loan>(MockBehavior.Strict);
            loan2.Expect(l => l.GetPeopleOnLoan()).Returns(people).AtMost(1);
            var loan3 = new Mock<Loan>(MockBehavior.Strict);
            loan3.Expect(l => l.GetPeopleOnLoan()).Returns(people).AtMost(1);
            var badfruit = new Mock<BadFruit>(MockBehavior.Strict);
            badfruit.Expect(b => b.Save(tom, null)).AtMost(1);
            badfruit.Expect(b => b.Увеличениенагрузкинаграфа(tom)).AtMost(3);
            BadFruit.CreateLoans2(badfruit.Object, new Loan[]{loan1.Object, loan2.Object, loan3.Object}, null);
        }
    }
}