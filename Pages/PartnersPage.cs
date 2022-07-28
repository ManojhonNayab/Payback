using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payback.Pages
{
    public class PartnersPage
    {
        private IWebDriver driver;
        public PartnersPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region Locators stored in Strings
        private By naaptol = By.XPath("//a[@data-title='Naaptol']");
        #endregion

        #region Methods
        public void ProcessPartners(IWebDriver driver)
        {
            UtilityClass.scrolldown(driver);
            UtilityClass.scrollup(driver);
            UtilityClass.ScrollTTillElementAndClickJS(driver, driver.FindElement(naaptol));
            UtilityClass.Wait(3000);

        }

        public void VerifyPartners(IWebDriver driver)
        {
            UtilityClass.TakeScreenShot(driver);
        }
        #endregion
    }
}
