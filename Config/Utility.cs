using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Payback
{
    public class UtilityClass : ConfigClass
    {

        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {

                case "CHROME":
                    driver = new ChromeDriver(chromeDriverPath);
                    break;

                case "FIREFOX":
                    driver = new FirefoxDriver(geckoDriverPath);
                    break;

                default: throw new ArgumentException("Error");


            }
        }
        public void browserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PAGE_LOAD_TIMEOUT);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
        }

        public void LaunchApp(string url)
        {
            driver.Url = url;
        }
 

        public void CloseBrowser()
        {
            driver.Quit();
        }
        public static void TakeScreenShot(IWebDriver Driver)
        {
            Random rad = new Random();
            string Imgname = "image" + rad.Next(0, 10000) + ".png";
            ((ITakesScreenshot)Driver).GetScreenshot().SaveAsFile(ScreenShotPath + Imgname);
        }
        public string ValidatePageTitle()
        {
            return driver.Title;
        }
        public static void scrolldown(IWebDriver driver)
        {
            IJavaScriptExecutor jsx = (IJavaScriptExecutor)driver;
            jsx.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)", "");
        }

        public static void scrollup(IWebDriver driver)
        {
            IJavaScriptExecutor jsx = (IJavaScriptExecutor)driver;
            jsx.ExecuteScript("window.scrollTo(document.body.scrollHeight, 0)", "");
        }
        public static void ScrolltoElement(IWebDriver driver, IWebElement webElement)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(webElement);
            action.Perform();
        }

        public static void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public static bool Exists(IWebElement webElement)
        {
            try
            {
                if (webElement.Displayed)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception) { return false; }
            
        }

        public static void ScrollTTillElementAndClickJS(IWebDriver driver, IWebElement element)
        {
            try
            {
                if (Exists(element))
                {
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                    executor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
                    executor.ExecuteScript("arguments[0].click();", element);
                    Wait(500);
                }
                else
                {
                    Assert.Fail("Element is not exist");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Problem in scrolling the element" + e);
            }
        }
    }
}
