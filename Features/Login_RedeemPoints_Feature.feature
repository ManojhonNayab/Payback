Feature: Login_RedeemPoints_Feature
	To Verify Login and RedeemPointsPage Functionality

@LoginFunctionality @Smoke
Scenario: Login to PayBack Application
	Given Login into application with valid MobileNumber and valid PIN
	Then Verify Login HomePage is displayed
	#Then Logout of Application
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to Products Page
	Then Process an order of Product
	Then Verify Product Order
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to EVouchers Page
	When Process an order of EVoucher
	Then Verify Evoucher Order
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to Recharges Page
	When Process an Valid Recharge
	Then Verify the Recharge
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to NewArriavals Page
	Then Process an NewArriavals
	Then Verify the NewArriavals
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to PayBackPlus Page
	Then Process an PayBackPlus
	Then Verify the PayBackPlus
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to Partners Page
	Then Process an Partners
	Then Verify the Partners
	When Navigate to RedeemPoints Module
	Then Verify the RedeemPoints Page is displayed
	And Navigate to Recharges Page
	When Process an Null Recharge
	Then Verify the Recharge

