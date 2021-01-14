using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DigiOutsourceTechnicalAssessment.StepsFolder
{
    [Binding]
    public sealed class BetwayLaunchSteps
    {

        Pages.BetwayPage betwayPage = null;

        [Given(@"I launch betway site")]
        public void GivenILaunchBetwaySite()
        {
            OpenQA.Selenium.IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.betway.co.za");
            betwayPage = new Pages.BetwayPage(webDriver);
        }

        [Given(@"click on signup button")]
        public void GivenClickOnSignupButton()
        {
            betwayPage.ClickSignUp();
        }

        [Given(@"fill in the following details")]
        public void GivenFillInTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            betwayPage.register((string)data.mobileNumber, (string)data.password, (string)data.firstName, (string)data.lastName, (string)data.emailAddress);
        }

        [Given(@"click Next Button")]
        public void GivenClickNextButton()
        {
            betwayPage.ClickNextButton();
        }

        [Given(@"complete the registration form")]
        public void GivenCompleteTheRegistrationForm(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all the fields should be filled")]
        public void ThenAllTheFieldsShouldBeFilled()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
