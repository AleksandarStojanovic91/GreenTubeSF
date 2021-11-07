Feature: Login
	As a user I should be able to Login with valid credentials on the Login form,
	in case of invalid credeentials or in case when I do not enter credentials
	I want to see appropriate error messages, also i should be able to select other languages
	And see appropriate translations.

@Login @HappyPath @Smoke @Regression
Scenario: Login to gametwist.com with valid credentials
		As a user I want to be able to login to gametwist.com using valid credentials.
	Given I am on the gametwist home page
	When I click login button
	And I enter my username
	And I enter my password
	And I click submit login button
	Then I should see my profile username

@Login @HappyPath @RegistartionPageLogin @Regression
Scenario: Login to gametwist.com with valid credentials through registration's page login
		As a user I want to be able to login to gametwist.com using valid credentials,
		from registration page.
	Given I am on the gametwist home page
	When I click register button
	And I click login button
	And I enter my username
	And I enter my password
	And I click submit login button
	Then I should see my profile username

@Login @HappyPath @LanguageTransaltion @Regression
Scenario Outline: Verify Translation of Login Form
		As a user I want to be able to use other languages when logging in,
		and I want to verify all text values are correct on a login form.
	Given I am on the gametwist home page
	When I change language to '<language>'
	And I click login button
	Then form header title should be '<formHeaderText>'
	And username label should be '<usernameLabel>'
	And password label should be '<passwordLabel>'
	And auto login text should be '<autoLoginText>'
	And login button text should be '<loginButtonText>'
	And forgot password text should be '<forgotPasswordText>'
	And dont have account text should be '<dontHaveAccountText>'
	And register now text should be '<registerNowText>'

	Examples: 
	| language | formHeaderText | usernameLabel | passwordLabel | autoLoginText         | loginButtonText | forgotPasswordText    | dontHaveAccountText            | registerNowText       |
	| FR       | Connexion      | Pseudo        | Mot de passe  | Connexion automatique | CONNEXION       | Mot de passe oublié ? | Tu n'as pas encore de compte ? | S'inscrire maintenant |
	#TODO add more langauges

@Login @NegativeScenarios
Scenario Outline: Try to Login to gametwist.com with invalid credentials using other languages
		As a user when I do not enter or I enter invalid credentials 
		I should see the appropriate error messages for the approprioate fields with correct transaltion.
	Given I am on the gametwist home page
	When I click login button
	And I enter username '<username>'
	And I enter password '<password>'
	When I click submit login button
	Then I should see username error message '<usernameErrorMessage>'
	And I should see password error message '<passwordErrorMessage>'
	And I should see form error '<formError>'

	@Regression
	Examples: 
	| username      | password     | usernameErrorMessage | passwordErrorMessage | formError							   |
	| null          | NoUsername   | Nickname required    | null                 | null									   |
	| NoPassword	| null		   | null			      | Password required    | null									   |
	| null        	| null         | Nickname required    | Password required    | null								       |
	| NonRegistered | TestPass123! | null                 | null                 | Incorrect nickname/password combination.|
	| AlexBg91      | WrongPass    | null                 |	null			     | Incorrect nickname/password combination.|

	@Smoke
	Examples: 
	| username      | password     | usernameErrorMessage | passwordErrorMessage | formError							   |
	| AlexBg91      | WrongPass    | null                 |	null			     | Incorrect nickname/password combination.|

@Login @NegativeScenarios @LanguageTransaltion
Scenario Outline: Try to Login to gametwist.com with invalid credentials
		As a user when I do not enter or I enter invalid credentials 
		I should see the appropriate error messages for the approprioate fields.
	Given I am on the gametwist home page
	When I change language to '<language>'
	And I click login button
	And I enter username '<username>'
	And I enter password '<password>'
	When I click submit login button
	Then I should see username error message '<usernameErrorMessage>'
	And I should see password error message '<passwordErrorMessage>'
	And I should see form error '<formError>'

	@Regression
	Examples: 
	| language | username      | password     | usernameErrorMessage | passwordErrorMessage     | formError                                 |
	| FR       | null          | NoUsername   | Pseudo manquant      | null                     | null                                      |
	| FR       | NoPassword    | null         | null                 | Mot de passe manquant    | null                                      |
	| FR       | null          | null         | Pseudo manquant      | Mot de passe manquant    | null                                      |
	| FR       | NonRegistered | TestPass123! | null                 | null                     | Mauvaise combinaison pseudo/mot de passe. |
	| FR       | AlexBg91      | WrongPass    | null                 | null			            | Mauvaise combinaison pseudo/mot de passe. |

	@Smoke
	Examples: 
	| language | username      | password     | usernameErrorMessage | passwordErrorMessage     | formError                                 |
	| FR       | AlexBg91      | WrongPass    | null                 | null			            | Mauvaise combinaison pseudo/mot de passe. |
