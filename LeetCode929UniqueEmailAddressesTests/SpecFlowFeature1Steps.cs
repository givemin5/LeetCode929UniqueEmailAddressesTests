using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace LeetCode929UniqueEmailAddressesTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have emails")]
        public void GivenIHaveEmails(Table table)
        {
            var emails = table.Rows.Select(r => r["email"]).ToArray();

            ScenarioContext.Current.Add("emails",emails);
        }
        
        [When(@"I exec NumUniqueEmails")]
        public void WhenIExecNumUniqueEmails()
        {
            var emails = ScenarioContext.Current.Get<string[]>("emails");
            Solution solution = new Solution();
            var actual = solution.NumUniqueEmails(emails);

            ScenarioContext.Current.Add("actual",actual);


        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            int actual = ScenarioContext.Current.Get<int>("actual");

            Assert.AreEqual(expected, actual);
        }
    }
}
