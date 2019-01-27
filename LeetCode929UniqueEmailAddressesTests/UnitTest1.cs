using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode929UniqueEmailAddressesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetUniqueEmail_alice_leetcode_com_ShouldBe_Same()
        {
            //arrange
            var email = "alice@leetcode.com";

            //act
            var solution = new Solution();
            var actual = solution.GetUniqueEmail(email);

            //assert
            var expected = "alice@leetcode.com";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUniqueEmail_If_AddTag()
        {
            //arrange
            var email = "test.email+alex@leetcode.com";

            //act
            var solution = new Solution();
            var actual = solution.GetUniqueEmail(email);

            //assert
            var expected = "testemail@leetcode.com";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumUniqueEmailsMutiEmailCheck1()
        {
            //arrange
            var emails = new string[] { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };

            //act
            var solution = new Solution();
            var actual = solution.NumUniqueEmails(emails);

            //assert
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NumUniqueEmailsMutiEmailCheck2()
        {
            //arrange
            var emails = new string[] { "fg.r.u.uzj+o.pw@kziczvh.com", "r.cyo.g+d.h+b.ja@tgsg.z.com", "fg.r.u.uzj+o.f.d@kziczvh.com", "r.cyo.g+ng.r.iq@tgsg.z.com", "fg.r.u.uzj+lp.k@kziczvh.com", "r.cyo.g+n.h.e+n.g@tgsg.z.com", "fg.r.u.uzj+k+p.j@kziczvh.com", "fg.r.u.uzj+w.y+b@kziczvh.com", "r.cyo.g+x+d.c+f.t@tgsg.z.com", "r.cyo.g+x+t.y.l.i@tgsg.z.com", "r.cyo.g+brxxi@tgsg.z.com", "r.cyo.g+z+dr.k.u@tgsg.z.com", "r.cyo.g+d+l.c.n+g@tgsg.z.com", "fg.r.u.uzj+vq.o@kziczvh.com", "fg.r.u.uzj+uzq@kziczvh.com", "fg.r.u.uzj+mvz@kziczvh.com", "fg.r.u.uzj+taj@kziczvh.com", "fg.r.u.uzj+fek@kziczvh.com" };

            //act
            var solution = new Solution();
            var actual = solution.NumUniqueEmails(emails);

            //assert
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetUniqueEmail_MutiAddTag()
        {
            //arrange
            var email = "r.cyo.g+d.h+b.ja@tgsg.z.com";

            //act
            var solution = new Solution();
            var actual = solution.GetUniqueEmail(email);

            //assert
            var expected = "rcyog@tgsg.z.com";
            Assert.AreEqual(expected, actual); ;
        }
    }
}