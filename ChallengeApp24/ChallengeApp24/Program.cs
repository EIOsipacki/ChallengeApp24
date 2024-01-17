using ChallengeApp24;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();


var employeeNameSurNameAgeSex = new Employee("Adam", "Kowalski", 35, "M");
Console.WriteLine($"Parametry: name + surname + age + sex = {employeeNameSurNameAgeSex.Name} {employeeNameSurNameAgeSex.SurName} / {employeeNameSurNameAgeSex.Age} / {employeeNameSurNameAgeSex.Sex} /");
var employeeNameSurName = new Employee("Adam", "Kowalski");
Console.WriteLine($"Parametry: name + surname = {employeeNameSurName.Name} {employeeNameSurName.SurName}/ {employeeNameSurName.Age} / {employeeNameSurName.Sex} /");
var employeeNameSurNameAge = new Employee("Adam", "Kowalski", 35);
Console.WriteLine($"Parametry: name + surname + age = {employeeNameSurNameAge.Name} {employeeNameSurNameAge.SurName} / {employeeNameSurNameAge.Age} / {employeeNameSurNameAge.Sex} /");
var employeeNameSurNameSex = new Employee("Adam", "Kowalski", "M");
Console.WriteLine($"Parametry: name + surname + sex = {employeeNameSurNameSex.Name} {employeeNameSurNameSex.SurName} / {employeeNameSurNameSex.Age} / {employeeNameSurNameSex.Sex} /");
var employee = new Employee();
Console.WriteLine($"Bez parametrów = {employee.Name} {employee.SurName} / {employee.Age} / {employee.Sex} /");
Console.WriteLine("");
Console.WriteLine("");
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


try
{
    var statistics = employee.GetStatistics();
    statistics.WriteLineStatistics();
}
catch (Exception ex)
{
    Console.WriteLine($"Exception catched: {ex.Message}");
}