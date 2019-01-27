using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode929UniqueEmailAddressesTests
{
    internal class Solution
    {
        public Solution()
        {
        }
        public bool IsUniqueEmail(string email)
        {
            return Regex.IsMatch(email, patten);
        }
        private string patten = @"^([a-zA-Z\d.]+)@([a-zA-Z\d.]+.com)|([a-zA-Z\d.]+)\+[+a-zA-Z\d.]+@([a-zA-Z\d.]+.com)$";



        public int NumUniqueEmails(string[] emails)
        {
            int num = 0;
            var result = emails.Select(x => CheckUniqueEmail(x))
                .Where(x=>!String.IsNullOrEmpty(x))
                .Distinct();

            return result.Count();
        }


        public string CheckUniqueEmail(string email)
        {
            var match = System.Text.RegularExpressions.Regex.Match(email, patten);

            var email1 = match.Groups[1].Value.Replace(".", "") + "@" + match.Groups[2].Value;
            var email2 = match.Groups[3].Value.Replace(".", "") + "@" + match.Groups[4].Value;

            if (!String.IsNullOrEmpty(match.Groups[1].Value))
            {
                return email1;
            }

            if (!String.IsNullOrEmpty(match.Groups[3].Value))
            {
                return email2;
            }

            return "";
        }
    }
}