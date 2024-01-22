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

        public override event GradeAddedDelegate GradeAdded;

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
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    int countLines = 1;
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        Console.WriteLine($"{countLines} stroka = {number}");
                        result.AddGrade(number);
                        line = reader.ReadLine();
                        countLines++;
                    }
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
