using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Payback.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region By Locators
        private By loginLink            = By.XPath("//a[normalize-space()='Login']");
        private By payBackLogo          = By.XPath("//img[@alt='PAYBACK']");
        private By loginPageText        = By.XPath("//h1[normalize-space()='LOGIN']");
        private By mobileNumber_Field   = By.Id("pb-card-number");
        private By pin_Field            = By.Id("pb-pin-number");
        private By loginButton          = By.XPath("//button[normalize-space()='LOGIN']");
        #endregion

        #region Methods
        public void LoginApplication(string MobileNumber, string PIN)
        {
            Assert.IsTrue(driver.FindElement(payBackLogo).Displayed, "Failed to load the URL");

            driver.FindElement(loginLink).Click();
            Thread.Sleep(10000);
            Assert.IsTrue(driver.FindElement(loginPageText).Displayed, "Failed to load the Login Page");

            driver.FindElement(mobileNumber_Field).SendKeys(MobileNumber);
            Thread.Sleep(1000);
            driver.FindElement(pin_Field).SendKeys(PIN);
            Thread.Sleep(20000);
            driver.FindElement(loginButton).Click();
            Thread.Sleep(35000);
        }
        #endregion
    }
}
