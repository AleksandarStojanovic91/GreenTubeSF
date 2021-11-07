Feature: Login
	User Login

@Login @HappyPath @Chrome @Firefox
Scenario: Login to gametwist.com
	Given I am on the gametwist home page
	When I click login button
	And I enter my username
	And I enter my password
	When I click submit login button
	Then I should see my profile username