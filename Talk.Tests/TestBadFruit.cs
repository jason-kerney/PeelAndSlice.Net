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
            loan1.Expect(l => l.GetPeopleOnLoan()).Returns(people);
            var badfruit = new Mock<BadFruit>(MockBehavior.Strict);
            badfruit.Expect(b => b.Save(tom, null));
            badfruit.Expect(b => b.Увеличениенагрузкинаграфа(tom));
            BadFruit.CreateLoans2(badfruit.Object, new Loan[]{loan1.Object}, null);
        }
    }
}