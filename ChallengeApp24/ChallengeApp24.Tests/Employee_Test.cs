namespace ChallengeApp24.Tests
{

    public class Employee_Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void WhenTwoEmployeeScoreAreAdded_SzhouldReturnSumAsResult()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalczyk", 33); ;
            employee.AddPunkty(1);
            employee.AddPunkty(3);

            // act
            int result = employee.maxResult;

            // assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void WhenEmployeeSetOfScoresHaveNegativeScore_ShouldCorrectSumAsResult()
        {
            var employee = new Employee("Jan", "Kowalczyk", 33); ;
            employee.AddPunkty(1);
            employee.AddPunkty(3);
            employee.AddPunkty(-5);

            // act
            int result = employee.maxResult;

            // assert
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void WhenEmployeeSetOfScoresHaveNullScore_ShouldCorrectSumAsResult()
        {
            var employee = new Employee("Jan", "Kowalczyk", 33); ;
            employee.AddPunkty(1);
            employee.AddPunkty(0);
            employee.AddPunkty(-5);

            // act
            int result = employee.maxResult;

            // assert
            Assert.AreEqual(-4, result);
        }
    }
}