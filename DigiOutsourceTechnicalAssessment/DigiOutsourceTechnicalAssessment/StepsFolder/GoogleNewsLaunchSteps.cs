using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DigiOutsourceTechnicalAssessment.StepsFolder
{
    [Binding]
    public sealed class GoogleNewsLaunchSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I launch google news site")]
        public void GivenILaunchGoogleNewsSite()
        {
           
           

            driver.Url = "http://news.google.com/";
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("loginLink")).Click();
        }

        [Given(@"the news healdlines should be displayed")]
        public void GivenTheNewsHealdlinesShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I print all the news headlines\.")]
        public void ThenIPrintAllTheNewsHeadlines_()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
