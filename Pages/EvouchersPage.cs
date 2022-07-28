using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payback.Pages
{
    public class EvouchersPage
    {
        private IWebDriver driver;
        public EvouchersPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region By Locators
        private By evoucher_1 = By.XPath("//div[@class='tilegridview']/div/section/div/div/div/div/div[2]/a[contains(text(),'Redeem')][1]");
        private By evouvher_1_PlaceOrder = By.XPath("//button[normalize-space()='Place order']");
        private By evoucher_LoginField = By.XPath("//input[@placeholder='PAYBACK Card No. / Linked Mobile No.']");
        private By evoucher_PINField = By.XPath("//input[@name='pin']");
        private By evoucher_NxtBtn = By.XPath("//button[normalize-space()='Next']");
        private By evoucher_SubmitBtn = By.XPath("//button[normalize-space()='Submit']");
        private By evoucher_EnterOTP = By.XPath("//input[@placeholder='Enter OTP']");
        #endregion

        #region Methods
        public void ProcessEVoucherOrder()
        {
            driver.FindElement(evoucher_1).Click();
            UtilityClass.Wait(2000);

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(evouvher_1_PlaceOrder).Click();
            UtilityClass.Wait(2000);

            if (UtilityClass.Exists(driver.FindElement(evoucher_LoginField)))
            {
                driver.FindElement(evoucher_LoginField).SendKeys(ConfigClass.loginUsername);
                UtilityClass.Wait(1500);
                driver.FindElement(evoucher_NxtBtn).Click();

                if (UtilityClass.Exists(driver.FindElement(evoucher_PINField)))
                {
                    driver.FindElement(evoucher_PINField).SendKeys(ConfigClass.loginPassword);
                    UtilityClass.Wait(20000);
                    driver.FindElement(evoucher_SubmitBtn).Click();
                    UtilityClass.Wait(6000);
                    driver.FindElement(evouvher_1_PlaceOrder).Click();
                    UtilityClass.Wait(3000);
                }
            }
        }
        public void VerifyEVoucher()
        {
            if (UtilityClass.Exists(driver.FindElement(evoucher_EnterOTP))) 
                Console.WriteLine("Waiting for OTP");
                UtilityClass.TakeScreenShot(driver);
            driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
            UtilityClass.Wait(2000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        #endregion
    }
}
