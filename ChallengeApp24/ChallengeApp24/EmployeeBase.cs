namespace ChallengeApp24
{
    abstract class EmployeeBase : IEmployee
    {
        //****
        // w klasie bazowej tylko implementacja parametrow Name SurName
        // sami metody beda w klasie dzidziczonej po Bazowej
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello , I am {Name} {SurName}");
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        //****
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
        
    }
}
