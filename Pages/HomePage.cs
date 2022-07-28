using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Payback.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region Locators stored in Strings
        private By userName = By.XPath("//span[@class='pb-user-name']");
        private By redeemPointsMenu = By.XPath("//a[@class='pb-title-menu'][normalize-space()='Redeem Points']");
        private By redeemPointsMenu_Option = By.XPath("//ul/li/a[contains(@href,  'catalogue')]");
        private By logOut_Option = By.XPath("//a[@class='pb-logout']");
        #endregion

        #region Methods
        public void AssertHomePage()
        {
            if (UtilityClass.Exists(driver.FindElement(userName)))
            {
                Assert.IsTrue(driver.FindElement(userName).Displayed, "Failed to load Login Homepage");
            }
            else { UtilityClass.TakeScreenShot(driver); Assert.Fail(); }

            }

        public void LogoutofApplication()
        {
            UtilityClass.ScrolltoElement(driver, driver.FindElement(userName));
            if (driver.FindElement(logOut_Option).Displayed)
            {
                driver.FindElement(logOut_Option).Click();
            }
        }
        public void NavigateToRedeemPointsPage()
        {
            UtilityClass.ScrolltoElement(driver, driver.FindElement(redeemPointsMenu));

            if (driver.FindElement(redeemPointsMenu_Option).Displayed)
            {
                driver.FindElement(redeemPointsMenu_Option).Click();
                Thread.Sleep(20000);
            }
        }
        #endregion
    }
}
