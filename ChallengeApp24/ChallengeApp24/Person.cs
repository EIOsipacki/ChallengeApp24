namespace ChallengeApp24
{
    public abstract class Person
    {
        public Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.SurName = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Sex { get; private set; }



    }
}
