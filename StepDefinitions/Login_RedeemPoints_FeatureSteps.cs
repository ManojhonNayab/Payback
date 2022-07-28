using Payback.Pages;
using System;
using TechTalk.SpecFlow;

namespace Payback.StepDefinitions
{
    [Binding]
    public class Login_RedeemPoints_FeatureSteps : ApplicationHooks
    {
    
        [Given(@"Login into application with valid MobileNumber and valid PIN")]
        public void ThenLoginIntoApplicationWithValidMobileNumberAndValidPIN()
        {
           loginPage.LoginApplication(loginUsername, loginPassword);
        }
        
        [Then(@"Verify Login HomePage is displayed")]
        public void ThenVerifyLoginHomePageIsDisplayed()
        {
            homePage.AssertHomePage();
        }

        [Then(@"Logout of Application")]
        public void ThenLogoutOfApplication()
        {
            homePage.LogoutofApplication();
        }


        [When(@"Navigate to RedeemPoints Module")]
        public void WhenNavigateToRedeemPointsModule()
        {
            homePage.NavigateToRedeemPointsPage();
        }

        [Then(@"Verify the RedeemPoints Page is displayed")]
        public void ThenVerifyTheRedeemPointsPageIsDisplayed()
        {
            redeemPointsPage.AssertRedeemPointsPage();
        }

        [Then(@"Navigate to (.*) Page")]
        public void ThenNavigateToProductsPage(string module)
        {
            redeemPointsPage.ClickOnModule(module);
        }

        [Then(@"Process an order of Product")]
        public void ThenProcessAnOrderOfProduct()
        {
            productsPage.ProcessProductPageOrder();
        }
        [Then(@"Verify Product Order")]
        public void ThenVerifyProductOrder()
        {
            productsPage.VerifyOrder();
        }
      
        [When(@"Process an order of EVoucher")]
        public void WhenProcessAnOrderOfEVoucher()
        {
            evouchersPage.ProcessEVoucherOrder();
        }

        [Then(@"Verify Evoucher Order")]
        public void ThenVerifyEvoucherOrder()
        {
            evouchersPage.VerifyEVoucher();
        }

        [When(@"Process an Valid Recharge")]
        public void WhenProcessAnRecharge()
        {
            rechargesPage.ProcessValidRecharge();
        }

        [When(@"Process an Null Recharge")]
        public void WhenProcessAnNullRecharge()
        {
            rechargesPage.ProcessInValidRecharge();
        }

        [Then(@"Verify the Recharge")]
        public void ThenVerifyTheRecharge()
        {
            rechargesPage.VerifyRecharge();
        }
        [Then(@"Process an NewArriavals")]
        public void ThenProcessAnNewArriavals()
        {
            newArrivalsPage.ProcessNewArrivals();
        }

        [Then(@"Verify the NewArriavals")]
        public void ThenVerifyTheNewArriavals()
        {
            newArrivalsPage.VerifyNewArrivals();
        }

        [Then(@"Process an PayBackPlus")]
        public void ThenProcessAnPayBackPlus()
        {
            paybackPlusPage.ProcessPaybackPlus();
        }

        [Then(@"Verify the PayBackPlus")]
        public void ThenVerifyThePayBackPlus()
        {
            paybackPlusPage.VerifyPaybackPlus();
        }


        [Then(@"Process an Partners")]
        public void ThenProcessAnPartners()
        {
            
        }

        [Then(@"Verify the Partners")]
        public void ThenVerifyThePartners()
        {
           
        }

    }
}
