using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowIntro.Steps
{
    [Binding]
    class Logout
    {
        private IWebDriver _driver;

        public Logout(IWebDriver driver)
        {
            _driver = driver;
        }
        [Given(@"I click logout")]
        public void GivenIClickLogout()
        {
            _driver.FindElement(By.XPath("//*[@id=\"cssmenu\"]/ul/li[1]/a")).Click(); 
        }

        [Then(@"I should be logged out")]
        public void ThenIShouldBeLoggedOut()
        {
            var element = _driver.FindElement(By.XPath("/html/body/h2")); 

            Assert.That(element.Text, Is.Not.Null, "Header text not found!!!");
        }

    }
}
