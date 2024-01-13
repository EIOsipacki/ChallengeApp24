
namespace ChallengeApp24.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenWhantsToEqualTwoReferenceVariables_SzhouldReturnFalse()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act


            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        [Test]
        public void WhenWhantsToEqualTwoTheSameInteger_SzhouldReturnTrue()
        {
            // arrange
            int n1 = 1;
            int n2 = 1;

            // act

            // assert
            Assert.AreEqual(n1, n2);
        }

        [Test]
        public void WhenWhantsToEqualTwoTheSameFloat_SzhouldReturnTrue()
        {
            // arrange
            float n1 = 1.023f;
            float n2 = 1.023f;

            // act

            // assert
            Assert.AreEqual(n1, n2);
        }

        [Test]
        public void WhenWhantsToEqualTwoTheSameString_SzhouldReturnTrue()
        {
            // arrange
            string n1 = "1.023f";
            string n2 = "1.023f";

            // act

            // assert
            Assert.AreEqual(n1, n2);
        }

        private User GetUser(string username)
        {
            return new User(username);
        }


    }
}
