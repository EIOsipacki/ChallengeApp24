namespace ChallengeApp24
{
    public class User
    {
        private List<int> score = new List<int>();
        public static string GameName = "Diablo";

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        public User(string login)
        {
            this.Login = login;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
