using ChallengeApp24;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");


//var employee = new EmployeeInMemory("Artur", "Malczewski");
var employee = new EmployeeInFile("Artur", "Malczewski");
employee.SayHello();
Console.WriteLine();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

Console.WriteLine();
if (employee.GradesLength())
{
    Console.WriteLine();
    Console.WriteLine("Zawartość pliku Grade.txt: ");
    var statistics = employee.GetStatistics();
    Console.WriteLine();
    Console.WriteLine();
    statistics.WriteLineStatistics();
}
else
{
    Console.WriteLine("Plik nie istnieje. Nie ma statystyk do pokazu");
}

Console.WriteLine();
Console.WriteLine("=============================================");
