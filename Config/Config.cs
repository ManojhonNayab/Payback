using OpenQA.Selenium;

namespace Payback
{
    public class ConfigClass
    {

        public static IWebDriver driver;
        public static string chromeDriverPath = @"D:\Kiwi\Payback\Drivers\";
        public static string geckoDriverPath = @"D:\Kiwi\Payback\Drivers\";

        public static string url = "https://www.payback.in/";

        public static string loginUsername = "9885466007";
        public static string loginPassword = "2555";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;

        public static string ScreenShotPath = @"D:\Kiwi\Payback\ScreenShot\";
    }
}