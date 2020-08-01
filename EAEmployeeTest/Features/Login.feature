Feature: Login
	Validate if the user is able to login

@Regression @positive
Scenario: check login with valid login and password
	Given I have navigated to the application
	Given I see the application Opened
	And I click On LoginLink
	And I Provide Valide credentials
	|UserName|  |Password|
	|Admin|  |password|
	Then I click on Login
	
	Then User navigates to HomePage