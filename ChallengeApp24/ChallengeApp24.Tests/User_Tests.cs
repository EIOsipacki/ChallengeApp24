namespace ChallengeApp24.Tests
{
    public class User_Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void WhenTwoNumbersAreAdded_SzhouldReturnSum()
        {
            // arrange
            int age1 = 10;
            int age2 = 3;

            // act
            int result = age1 + age2;

            // assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "adad123");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            //assert
              Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenUserCollectThreeSetOfPoints_ShouldCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "adad123");
            user.AddScore(5);
            user.AddScore(2);
            user.AddScore(1);

            // act
            var result = user.Result;

            //assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void WhenUserCollectHaveNegativePoint_ShouldCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "adad123");
            user.AddScore(5);
            user.AddScore(-6);

            // act
            var result = user.Result;

            //assert
            Assert.AreEqual(-1, result);
        }
    }
}