using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode929UniqueEmailAddressesTests
{
    internal class Solution
    {
        private string patten = @"^([a-zA-Z\d.]+)(\+[+a-zA-Z\d.]+)?@([a-zA-Z\d.]+.com)$";
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> seen = new HashSet<string>();
            foreach (var email in emails)
            {
                var uniqueEmail = GetUniqueEmail(email);
                if (!String.IsNullOrEmpty(uniqueEmail))
                {
                    seen.Add(uniqueEmail);
                };
            }
            return seen.Count;
        }


        public string GetUniqueEmail(string email)
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