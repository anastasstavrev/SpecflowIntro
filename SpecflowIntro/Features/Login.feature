Feature: Login
	Check if the login functionality works

@smoke @testtag
Scenario: Logging user as Administrator
	Given I navigate to application
	And I enter username and password
	| UserName | Password |
	| admin    | admin    |
	And I click login
	Then I should see user logged in to the application
