using ChallengeApp24;

var employee = new Employee("Adam", "Kamizelik");
employee.AddGrade("10");
employee.AddGrade('5');
employee.AddGrade(600);
var statistics = employee.GetStatistics();

 Console.WriteLine($"Average: {statistics.Average:N2}, Max: {statistics.Max}, Min: {statistics.Min}");

