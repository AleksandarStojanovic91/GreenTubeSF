Feature: Registration
	As a user I should be able to register using registration from and following "Register now" link, 
	I also should be able to register using other languages and in case of invalid field values I should see appropriate error messages 
	with propper translation. When clicking input fields i should also see tooltips, with propper translation as well.

@Registration @HappyPath @Chrome @Firefox @Smoke @Regression
Scenario Outline: Register at gametwist.com
	Given I am on the gametwist home page
	When I click register button
	And I enter unique email '<email>'
	And I enter unique username '<username>'
	And I enter registration password '<password>'
	And I select day '<day>' month '<month>' and '<year>' of birth
	And I click recaptcha
	And I click agree with GTC
	And I click begin adventure button
	Then I should be on a registration confirmation page
	And I should see welcome bonus message
	And I should see confirmation email message

	#NOTE Email and username are being appended with current time millis
	Examples: 
	| email		      | username | password     | day | month | year |
	| test@email.com  | username | TestPass123! | 20  | 07    | 1991 |