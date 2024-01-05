Feature: Test

Scenario: TestBankManager
	Given Launch the driver and click on the link https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login
	And Click on the button Bank Manager Login
	And Click on the button Customers
	Then Enter the Albus in the search bar
	When I check if Albus is in the list