namespace ChallengeApp24
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surName)
        {
            this.Name = name;
            this.SurName = surName;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public void AddGrade(string grade)
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
        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(int grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        //public void AddGrade(char grade)
        //{
        //    string value = grade.ToString();
        //    this.AddGrade(value);
        //}

        public void AddGrade(char grade)
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
                    // break nie potrzebny jak używamy throw
                    //break;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (this.grades.Count > 0)
            {
                statistics.Average = 0;
                statistics.Min = float.MaxValue;
                statistics.Max = float.MinValue;
                foreach (var grade in this.grades)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average /= this.grades.Count;

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }
            }
            else
            {
                throw new Exception("No statistics to show");
                //Console.WriteLine("List Grades is Empty");
            }
            return statistics;
        }
    }
}
