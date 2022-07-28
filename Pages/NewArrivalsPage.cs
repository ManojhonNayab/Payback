using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payback.Pages
{
    public class NewArrivalsPage
    {
        private IWebDriver driver;
        public NewArrivalsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region Locators stored in Strings
        private By lifeStyle = By.XPath("//input[@value='Lifestyle']");
        private By lifeStyle_1 = By.XPath("//div[@id='hot-deals-product-list']/div/a[1]");
        private By lifeStyle_1_Btn = By.XPath("//button[@id='redeemBtn']");
        private By lifeStyle_1_ConfirmBtn_ErrorMessage = By.XPath("//div[@id='modal-header']");
        private By ErrorMessage_CloseBtn = By.XPath("//span[@data-dismiss='modal']");
        #endregion

        #region Methods
        public void ProcessNewArrivals()
        {
            driver.FindElement(lifeStyle).Click();
            UtilityClass.Wait(3000);
            driver.FindElement(lifeStyle_1).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(lifeStyle_1_Btn).Click();
        }

        public void VerifyNewArrivals()
        {
            if (driver.FindElement(lifeStyle_1_ConfirmBtn_ErrorMessage).Displayed)
            {
                Console.WriteLine("Due to Lack of Points, unable to process order");
                UtilityClass.TakeScreenShot(driver);
                driver.FindElement(ErrorMessage_CloseBtn).Click();

                driver.SwitchTo().Window(driver.WindowHandles[1]).Close();
                UtilityClass.Wait(2000);
                driver.SwitchTo().Window(driver.WindowHandles[0]);
            }
        }
        #endregion
    }
}
