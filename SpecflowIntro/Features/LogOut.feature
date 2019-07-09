Feature: LogOut
	Check if the logout functionality works

@mytag
Scenario: Logging out as Administrator
	Given I navigate to application
	And I enter username and password
	| UserName | Password |
	| admin    | admin    |
	And I click login
	And I click logout
	Then I should be logged out
