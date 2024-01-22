namespace ChallengeApp24
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            //WriteMessage delegat;
            //delegat = WrieMessageInConsole;
            //delegat += WrieMessageInConsole2;
            //delegat(" Moj tekst");

            //delegat -= WrieMessageInConsole;


        }

        //public delegate void WriteMessage(string message);

        // public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        //private void WrieMessageInConsole(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //private void WrieMessageInConsole2(string message)
        //{
        //    Console.WriteLine(message.ToUpper());
        //}

        public override void SayHello()
        {
            Console.WriteLine("Hi !!!");
            base.SayHello();
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
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
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            
            return statistics;
        }

        public int GradesLength()
        {
            return grades.Count;
        }
    }
}
