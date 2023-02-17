namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            //arrange
            var number1 = 1;
            var number2 = 1;

            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Nowak", 30);
            var employee2 = GetEmployee("Tomasz", "Kowalski", 35);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
