using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode929UniqueEmailAddressesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var email = "alice@leetcode.com";

            //act
            var solution = new Solution();
            var actual = solution.NumUniqueEmail(email);

            //assert
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}