using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiOutsourceTechnicalAssessment.Pages
{
    public class GoogleNewsPage
    {
        public IWebDriver webDriver { get; }

        public GoogleNewsPage(IWebDriver webdriver)
        {
            webDriver = webdriver;
        }


    }
}
