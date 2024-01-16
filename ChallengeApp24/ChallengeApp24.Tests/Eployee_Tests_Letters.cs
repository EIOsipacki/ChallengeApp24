namespace ChallengeApp24.Tests
{
    internal class Eployee_Tests_Letters
    {
        [Test]
        public void WhenInputLetterGrades_StatisticsShouldBeRight()
        {
            //arrange
            var employee = new Employee("Jan", "Kowalski");
            employee.AddGrade('a');
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('B');
            employee.AddGrade('c');
            employee.AddGrade('C');
            employee.AddGrade('d');
            employee.AddGrade('D');
            employee.AddGrade('e');
            employee.AddGrade('E');
            employee.AddGrade('O');
            employee.AddGrade('z');

            // act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(50, statistics.Average);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(0, statistics.Min);
        }


        [Test]
        public void WhenInputGrades_StatisticsLetterShouldBeRight()
        {
            //arrange
            var employee1 = new Employee();
            var employee2 = new Employee();
            var employee3 = new Employee();
            var employee4 = new Employee();
            var employee5 = new Employee();
            
            employee1.AddGrade(85);
            employee2.AddGrade("65");
            employee3.AddGrade('d');
            employee3.AddGrade(41);
            employee4.AddGrade(20);
            employee5.AddGrade(10.123f);


            // act
            var statistics1 = employee1.GetStatistics();
            var statistics2 = employee2.GetStatistics();
            var statistics3 = employee3.GetStatistics();
            var statistics4 = employee4.GetStatistics();
            var statistics5 = employee5.GetStatistics();

            //assert
            Assert.AreEqual('A', statistics1.AverageLetter);
            Assert.AreEqual('B', statistics2.AverageLetter);
            Assert.AreEqual('C', statistics3.AverageLetter);
            Assert.AreEqual('D', statistics4.AverageLetter);
            Assert.AreEqual('E', statistics5.AverageLetter);

        }



    }
}
