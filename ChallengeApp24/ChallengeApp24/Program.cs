using ChallengeApp24;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");


//var employee = new EmployeeInMemory("Artur", "Malczewski");
var employee = new EmployeeInFile("Artur", "Malczewski");
employee.SayHello();
Console.WriteLine();

employee.GradeAdded += EmployeeGradeAdded;
//employee.GradeAdded += EmployeeGradeAdded;


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

//employee.GradeAdded -= EmployeeGradeAdded;

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
//if (employee.GradesLength() > 0)
if (employee.GradesLength() == true)
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
    //Console.WriteLine("Lista ocen jest pusta. Nie ma statystyk do pokazu");
}

Console.WriteLine();
Console.WriteLine("=============================================");
