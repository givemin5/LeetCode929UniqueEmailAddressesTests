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
            var patten = @"^([a-zA-Zd.]+)@([a-zA-Zd]+.com)|([a-zA-Zd.]+)\+[a-zA-Zd.]+@([a-zA-Zd]+.com)$";

            var match = Regex.Match(email, patten);

            var email1 = match.Groups[1].Value.Replace(".", "") + "@" + match.Groups[2].Value;
            var email2 = match.Groups[3].Value.Replace(".", "") + "@" + match.Groups[4].Value;

            if (String.IsNullOrEmpty(email1))
            {
                return email2;
            }

            return email1;
        }
    }
}