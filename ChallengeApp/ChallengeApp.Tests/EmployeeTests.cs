namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectFewScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Adam", "Nowakowski", 36);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(6);
            employee.AddScore(-6);
            employee.AddScore(-4);
            employee.AddScore(2);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(9, result);

        }
    }
}