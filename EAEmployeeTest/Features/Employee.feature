Feature: Employee
	Create a new employee and then save it. 
@Regression @positive
Scenario: check login with valid login and password
	Given I have navigated to the application
	Given I see the application Opened
	And I click On loginLink
		
	And I Provide Valide credentials
	| UserName |  | Password |
	| Admin    |  | password |
	Then I click on Login

	And I click On EmployeeLink
	Then I click On CreateNew Button in EmployeeList Page
	And I fill Employee form
	| Name   |  | Salary |  | Duration |  | Grade      |  | Email          |
	| Ragava |  | 1800   |  | 18       |  | 2 |  | rag@gamail.com |  
	Then I click on Create
	
	
	
