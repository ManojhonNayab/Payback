using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Payback.Pages
{
    public class ProductsPage
    {
        private IWebDriver driver;
        public ProductsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region By Locators
        private By products_1                           = By.XPath("//div[@class='productdeals']/section/div/div/div[1]");
        private By products_1_ConfirmBtn                = By.XPath("//button[@id='redeemBtn']");
        private By products_1_ConfirmBtn_ErrorMessage   = By.XPath("//div[@id='modal-header']");
        private By ErrorMessage_CloseBtn                = By.XPath("//span[@data-dismiss='modal']");
        #endregion

        #region Methods
        public void ProcessProductPageOrder()
        {
            driver.FindElement(products_1).Click();
            UtilityClass.Wait(3000);

            driver.FindElement(products_1_ConfirmBtn).Click();
            UtilityClass.Wait(3000);
        }

        public void VerifyOrder()
        {
            if (driver.FindElement(products_1_ConfirmBtn_ErrorMessage).Displayed)
            {
                Console.WriteLine("Due to Lack of Points, unable to process order");
                UtilityClass.TakeScreenShot(driver);
                driver.FindElement(ErrorMessage_CloseBtn).Click();
            }
        }

        #endregion
    }
}
