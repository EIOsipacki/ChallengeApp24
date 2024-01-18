namespace ChallengeApp24
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        private int countLines;
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(int grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(char grade)
        {
            string value = grade.ToString();
            this.AddGrade(value);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float value))
            {
                this.AddGrade(value);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0;
            result.Max = float.MinValue;
            result.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                countLines = 1;
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        Console.WriteLine($"{countLines} stroka = {number}");
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        line = reader.ReadLine();
                        countLines++;

                    }
                    result.Average /= (countLines - 1);
                }
                switch (result.Average)
                {
                    case var average when average >= 80:
                        result.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        result.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        result.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        result.AverageLetter = 'D';
                        break;
                    default:
                        result.AverageLetter = 'E';
                        break;
                }
            }
            return result;
        }

        public bool GradesLength()
        {
            return File.Exists(fileName);
        }
    }
}
