int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

char[] cyfry = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int sumLetter = 0;

for (int j = 0; j < 10; j++)
{
    sumLetter = 0;
    Console.Write(cyfry[j]);
    Console.Write(" => ");

    for (int i = 0; i < numberInString.Length; i++)
    {
        if (cyfry[j] == letters[i])
        {
            sumLetter++;
        }
    }
    Console.WriteLine(sumLetter);
}