namespace ChallengeApp24.Tests
{
    public class Employee_Tests
    {
        [Test]
        public void WhenInputGradesToEmployeeStatisticsMaxIsMaxFromGrades()
        {
            //arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade(12.334f);
            employee.AddGrade(0);
            employee.AddGrade(-90.897f);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(12.334f, statistics.Max);
        }
        [Test]
        public void WhenInputGradesToEmployeeStatisticsMinIsMinFromGrades()
        {
            //arrange
            var employee = new Employee("Jerzy", "Malec");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void WhenInputGradesToEmployeeStatisticsAverageIsAverageFromGrades()
        {
            //arrange
            var employee = new Employee("Ola", "Kwasinska");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(3.333, Math.Round(statistics.Average, 3));
        }
    }
}