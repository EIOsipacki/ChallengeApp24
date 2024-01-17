namespace ChallengeApp24
{
    internal class Supervisor : IEmployee
    {
        public Supervisor(string name, string surName)
        {
            this.Name = name;
            this.SurName = surName;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }

        private List<float> grades = new List<float>();

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

        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(int grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public void AddGrade(char grade)
        {
            string value = grade.ToString();
            this.AddGrade(value);
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "+5":
                case "5+":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                case "+1":
                case "1+":
                    this.grades.Add(5);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

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
            return statistics;
        }

        public int GradesLength()
        {
            return grades.Count;
        }
    }
}
