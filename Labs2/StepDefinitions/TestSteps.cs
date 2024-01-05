using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Labs2.StepDefinitions
{
    [Binding]
    public sealed class TestSteps
    {
        IWebDriver driver;

        [Given("Launch the driver and click on the link (.*)")]
        public void GivenLaunchTheDriverAndClickOnTheLink(string URL)
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(URL);

            Thread.Sleep(2000);
        }

        [Given("Click on the button Bank Manager Login")]
        public void GivenClickOnTheButtonBankManagerLogin()
        {
            driver.FindElement(By.XPath(".//*[text()='Bank Manager Login']")).Click();
            Thread.Sleep(2000);
        }

        [Given("Click on the button Customers")]
        public void GivenClickOnTheButtonCustomers()
        {
            driver.FindElement(By.XPath(".//*[@ng-class='btnClass3']")).Click();
            Thread.Sleep(2000);
        }

        [Then("Enter the (.*) in the search bar")]
        public void ThenEnterTheInTheSearchBar(string name)
        {
            driver.FindElement(By.XPath(".//*[@placeholder='Search Customer']")).SendKeys(name);
            Thread.Sleep(2000);
        }
        [When("I check if (.*) is in the list")]
        public void WhenICheckIfIsInTheList(string name)
        {
            IList<IWebElement> NameInList = driver.FindElements(By.CssSelector("tbody tr td:nth-child(1)"));

            Assert.AreEqual(name, NameInList.First().Text, "The item was not found in the list.");
            Thread.Sleep(2000);
        }
    }
}
