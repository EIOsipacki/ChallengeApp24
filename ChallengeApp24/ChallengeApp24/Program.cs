using ChallengeApp24;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new Employee();
//employee.AddGrade('a');
//employee.AddGrade('b');
//employee.AddGrade('c');
//employee.AddGrade('d');
//employee.AddGrade('e');
//employee.AddGrade('h');

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    else
    {
        employee.AddGrade(input);
    }
}

var statistics = employee.GetStatistics();
statistics.WriteLineStatistics();