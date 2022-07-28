using Payback.Pages;
using System.Threading;
using TechTalk.SpecFlow;

namespace Payback
{
    public class ApplicationHooks : UtilityClass

    {

        public LoginPage loginPage;
        public HomePage homePage;
        public RedeemPointsPage redeemPointsPage;
        public ProductsPage productsPage;
        public EvouchersPage evouchersPage;
        public RechargesPage rechargesPage;
        public NewArrivalsPage newArrivalsPage;
        public PaybackPlusPage paybackPlusPage;
        public PartnersPage partnersPage;



        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            browserMaximize();
            LaunchApp(url);

            Thread.Sleep(5000);

            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            redeemPointsPage = new RedeemPointsPage(driver);
            productsPage = new ProductsPage(driver);
            evouchersPage = new EvouchersPage(driver);
            rechargesPage = new RechargesPage(driver);
            newArrivalsPage = new NewArrivalsPage(driver);
            paybackPlusPage = new PaybackPlusPage(driver);
            partnersPage = new PartnersPage(driver);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
    }
}