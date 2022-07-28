using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payback.Pages
{
    public class PaybackPlusPage
    {
        private IWebDriver driver;
        public PaybackPlusPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region Locators stored in Strings
        private By payback_1 = By.XPath("//a[@data-title='The man company']");
        #endregion

        #region Methods
        public void ProcessPaybackPlus()
        {
            UtilityClass.scrolldown(driver);
            UtilityClass.scrollup(driver);
            UtilityClass.ScrollTTillElementAndClickJS(driver, driver.FindElement(payback_1));
            UtilityClass.Wait(3000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        public void VerifyPaybackPlus()
        {
            UtilityClass.TakeScreenShot(driver);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            UtilityClass.Wait(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        #endregion
    }
}
