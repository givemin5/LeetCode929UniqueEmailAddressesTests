using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode929UniqueEmailAddressesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckUniqueEmailTest()
        {
            //arrange
            var email = "alice@leetcode.com";

            //act
            var solution = new Solution();
            var actual = solution.CheckUniqueEmail(email);

            //assert
            var expected = "alice@leetcode.com";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckUniqueEmailTest2()
        {
            //arrange
            var email = "test.email+alex@leetcode.com";

            //act
            var solution = new Solution();
            var actual = solution.CheckUniqueEmail(email);

            //assert
            var expected = "testemail@leetcode.com";
            Assert.AreEqual(expected, actual);
        }
    }
}