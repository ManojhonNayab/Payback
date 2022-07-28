using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Payback.Pages
{
    public class RedeemPointsPage
    {
        private IWebDriver driver;
        public RedeemPointsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        #region By Locators
        private By redeemPage_Text = By.XPath("//span[normalize-space()='REDEEM POINTS FOR ANY REWARD CATEGORY BELOW']");
        private By products_Module = By.XPath("//img[contains(@data-src,'/content/dam/payback/home/rewardslogo/partners_tile_onhover.png')]");
        private By eVouchers_Module = By.XPath("//img[contains(@data-src,'/content/dam/payback/home/rewardslogo/e-voucher_tile.png')]");
        private By recharges_Module = By.CssSelector("img[data-src='/content/dam/payback/home/herobanner/recharges_196x82.webp']");
        private By newArriavals_Module = By.XPath("//a[@href='/rewards/newarrivals']//img[@class=' lazyloaded']");
        private By payBackPlus_Module = By.XPath("//img[@data-src='/content/dam/payback/home/rewardslogo/pbplus_tile.png']");
        private By partners_Module = By.XPath("//img[@data-src='/content/dam/payback/home/rewardslogo/partners_tile.png']");
        #endregion

        #region Methods
        public void AssertRedeemPointsPage()
        {
            if (UtilityClass.Exists(driver.FindElement(redeemPage_Text)))
            {
                Assert.IsTrue(driver.FindElement(redeemPage_Text).Displayed, "Failed to load Redeem Points Page");
            }
            else { UtilityClass.TakeScreenShot(driver); Assert.Fail(); }
        }

        public void ClickOnModule(string module)
        {
            switch (module.ToLower())
            {
                case "products":
                    driver.FindElement(products_Module).Click();
                    break;
                case "evouchers":
                    driver.FindElement(eVouchers_Module).Click();
                    break;
                case "recharges":
                    driver.FindElement(recharges_Module).Click();
                    break;
                case "newarrivals":
                    driver.FindElement(newArriavals_Module).Click();
                    break;
                case "paybackplus":
                    driver.FindElement(payBackPlus_Module).Click();
                    break;
                case "partners":
                    driver.FindElement(partners_Module).Click();
                    break;
                default:
                    Console.WriteLine("Invalid module entry");
                    break;
            }
            Thread.Sleep(5000);
        }
        #endregion
    }
}
