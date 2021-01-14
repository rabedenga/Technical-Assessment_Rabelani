using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiOutsourceTechnicalAssessment.Pages
{
    public class BetwayPage
    {
        public IWebDriver webDriver { get; }
        public BetwayPage(IWebDriver webdriver )
        {
            webDriver = webdriver;
        }
        public IWebElement lnkSignUp => webDriver.FindElement(By.LinkText("Sign Up"));
        public IWebElement txtMobileNumber => webDriver.FindElement(By.Name("Template.TemplateFieldModels[1].Value"));
        public IWebElement txtPassword => webDriver.FindElement(By.Name("Template.TemplateFieldModels[2].Value"));
        public IWebElement txtFirstName => webDriver.FindElement(By.Name("Template.TemplateFieldModels[4].Value"));
        public IWebElement txtLastName => webDriver.FindElement(By.Name("Template.TemplateFieldModels[5].Value"));
        public IWebElement txtEmailaddress => webDriver.FindElement(By.Name("Template.TemplateFieldModels[6].Value"));
        public IWebElement btnNext => webDriver.FindElement(By.CssSelector(".btn-default"));

        public void ClickSignUp() => lnkSignUp.Click();

        public void register(String mobileNumber, String password, String firstName, String lastName, String emailAddress)
        {
            txtMobileNumber.SendKeys(mobileNumber);
            txtPassword.SendKeys(password);
            txtFirstName.SendKeys(firstName);
            txtLastName.SendKeys(lastName);
            txtEmailaddress.SendKeys(emailAddress);
        }

        public void ClickNextButton() => btnNext.Click();
    }
}
