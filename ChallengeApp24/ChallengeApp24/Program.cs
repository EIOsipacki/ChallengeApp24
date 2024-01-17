using ChallengeApp24;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

//HW Dzien 15 nie potrzebuje to
//var employeeNameSurNameAgeSex = new Employee("Adam", "Kowalski", 35, "M");

var supervisor = new Supervisor("Artur", "Malczewski");
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
        //HW Dzien 15 nie potrzebuje to 
        //employee.AddGrade(input);
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}


Console.WriteLine(); 
if (supervisor.GradesLength()>0)
{
    var statistics = supervisor.GetStatistics();
    statistics.WriteLineStatistics();
}
else 
{
    Console.WriteLine("No statistics to show"); 
}
Console.WriteLine();
Console.WriteLine("=============================================");


//HW Dzien 15 nie potrzebuje to 
//try
//{
//    var statistics = employee.GetStatistics();
//    statistics.WriteLineStatistics();
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Exception catched: {ex.Message}");
//}