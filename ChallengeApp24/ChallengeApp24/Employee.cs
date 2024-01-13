namespace ChallengeApp24
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public int Age { get; private set; }

        public int maxResult
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddPunkty(int punkty)
        {
            this.score.Add(punkty);
        }
    }
}
