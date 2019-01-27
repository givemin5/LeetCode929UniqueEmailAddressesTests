using System;
using System.Collections;
using System.Collections.Generic;
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
        private string patten = @"^([a-zA-Z\d.]+)(\+[+a-zA-Z\d.]+)?@([a-zA-Z\d.]+.com)$";



        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> seen = new HashSet<string>();
            foreach (var email in emails)
            {
                var s = CheckUniqueEmail(email);
                if (!String.IsNullOrEmpty(s))
                {
                    seen.Add(s);
                }
            }
            return seen.Count;
        }


        public string CheckUniqueEmail(string email)
        {
            var match = System.Text.RegularExpressions.Regex.Match(email, patten);

            var email1 = match.Groups[1].Value.Replace(".", "") + "@" + match.Groups[3].Value;

            if (!String.IsNullOrEmpty(match.Groups[1].Value))
            {
                return email1;
            }
            return "";
        }
    }
}