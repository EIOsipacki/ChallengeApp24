string name = "Ewa";
int age = 33;
//Man, man, woman, Woman
string gender = "Woman";


if (gender == "Woman" || gender == "woman")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        if (name == "Ewa" && age == 30)
        {
            Console.WriteLine("Ewa, lat 30");
        }
    }
}
else
if (gender == "Man" || gender == "man")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
    }
}