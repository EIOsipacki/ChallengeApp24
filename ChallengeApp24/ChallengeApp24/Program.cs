
// -------------- EXECISES FROM DZIEN6
//using ChallengeApp24;
//User user1 = new User("Adam", "2342423");
//User user2 = new User("Monika", "PAS123");
//User user3 = new User("Zuzia", "1234qwer");
//User user4 = new User("Anna", "112111");
//User user5 = new User("Damian", "asdfqwer");

//var name = user1.Login;
//user1.AddScore(5);
//user1.AddScore(2);
//var result = user1.Result;
//Console.WriteLine(result);
//    //static
//var gName = User.GameName;
//var pi = Math.PI;
//---------------------------END EXECISES FROM DZIEN6

using ChallengeApp24;
Employee employee1 = new Employee("Jan", "Kowalczyk", 33);
Employee employee2 = new Employee("Sylwia", "Nowak", 28);
Employee employee3 = new Employee("Grzegorz", "Mocko", 38);

employee1.AddPunkty(1);
employee2.AddPunkty(3);
employee3.AddPunkty(2);

employee1.AddPunkty(2);
employee2.AddPunkty(2);
employee3.AddPunkty(2);

employee1.AddPunkty(3);
employee2.AddPunkty(8);
employee3.AddPunkty(1);

employee1.AddPunkty(2);
employee2.AddPunkty(3);
employee3.AddPunkty(4);

employee1.AddPunkty(8);
employee2.AddPunkty(1);
employee3.AddPunkty(7);

List<Employee> employees = new List<Employee>()
{
  employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach (var item in employees)
{
    if (item.SumaPunkty >= maxResult)
    {
        employeeWithMaxResult = item;
        maxResult = item.SumaPunkty;
    }
}
Console.WriteLine($"ODPOWIEDZ: Pracownik z najwiekszą liczbą ocen rownej {maxResult} ma : {employeeWithMaxResult.Name} {employeeWithMaxResult.Nazwisko}, {employeeWithMaxResult.Wiek} lat ");


