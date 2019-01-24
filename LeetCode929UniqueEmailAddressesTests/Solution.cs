using System;
using System.Text.RegularExpressions;

namespace LeetCode929UniqueEmailAddressesTests
{
    internal class Solution
    {
        public Solution()
        {
        }
        public string CheckUniqueEmail(string email)
        {
            var patten = "^[a-zA-Zd]+@[a-zA-Zd]+.com$";

            var match = Regex.Match(email, patten);

            return match.Groups[0]?.Value ?? "";
        }
    }
}