using ChallengeApp24;

var employee = new Employee("Adam", "Kamizelik");
employee.AddGrade("10");
employee.AddGrade('5');
employee.AddGrade(600);
//var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWhithDoWhile();
var statistics4 = employee.GetStatisticsWhithWhile();

//Console.WriteLine($"Average: {statistics.Average:N2}, Max: {statistics.Max}, Min: {statistics.Min}");
Console.WriteLine($"1: Average: {statistics1.Average:N2}, Max: {statistics1.Max}, Min: {statistics1.Min}");
Console.WriteLine($"2: Average: {statistics2.Average:N2}, Max: {statistics2.Max}, Min: {statistics2.Min}");
Console.WriteLine($"3: Average: {statistics3.Average:N2}, Max: {statistics3.Max}, Min: {statistics3.Min}");
Console.WriteLine($"4: Average: {statistics4.Average:N2}, Max: {statistics4.Max}, Min: {statistics4.Min}");

