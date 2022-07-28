using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payback.Pages
{
    public class RechargesPage
    {
        private IWebDriver driver;
        public RechargesPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region By Locators
        private By mobileRecharge = By.XPath("//span[normalize-space()='Mobile Recharge']");
        private By mobileNumber = By.XPath("//input[@id='autocomplete-input']");
        private By amountPlan = By.XPath("//input[@id='amountPlan']");
        private By termsAndConditions = By.XPath("//input[@id='tnc']");
        private By placeOrder = By.XPath("//button[normalize-space()='Place Order']");
        private By confirmOrder = By.XPath("//button[text()='CONFIRM ORDER']");
        #endregion

        #region Methods
        public void ProcessValidRecharge()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            UtilityClass.Wait(2000);
            driver.FindElement(mobileRecharge).Click();
            driver.FindElement(mobileNumber).SendKeys(UtilityClass.loginUsername);
            driver.FindElement(amountPlan).SendKeys("100");
            driver.FindElement(termsAndConditions).Submit();
            UtilityClass.Wait(2000);
        }

        public void ProcessInValidRecharge()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            UtilityClass.Wait(2000);
            driver.FindElement(mobileRecharge).Click();
            driver.FindElement(mobileNumber).SendKeys(" ");
            driver.FindElement(amountPlan).SendKeys("100");
            driver.FindElement(termsAndConditions).Submit();
            UtilityClass.Wait(2000);
        }

        public void VerifyRecharge()
        {
            UtilityClass.TakeScreenShot(driver);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            UtilityClass.Wait(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        #endregion
    }
}
