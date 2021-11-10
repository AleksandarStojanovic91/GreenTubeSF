Feature: Registration
	As a user I should be able to register using registration from and following "Register now" link, 
	I also should be able to register using other languages and in case of invalid field values I should see appropriate error messages 
	with propper translation. When clicking input fields i should also see tooltips, with propper translation as well.

@Registration @HappyPath @Smoke @Regression
Scenario Outline: Register at gametwist.com
	As a user I should be able to fill out the registration form and successfully register.
	Given I am on the gametwist home page
	When I click register button
	And I enter unique email '<email>'
	And I enter unique username '<username>'
	And I enter registration password '<password>'
	And I select day '<day>' month '<month>' and '<year>' of birth
	And I click agree with GTC
	And I click recaptcha
	And I click begin adventure button
	Then I should be on a registration confirmation page
	And I should see welcome bonus message
	And I should see confirmation email message

	Examples: 
	| email		      | username | password     | day | month | year |
	| test@email.com  | username | TestPass123! | 20  | 7     | 1991 |

@Registration @HappyPath @Regression
Scenario Outline: Register at gametwist.com through register now link
	As a user I should be able to fill out the registration form and successfully register.
	Given I am on the gametwist home page
	When I click login button
	And I click register now link
	And I enter unique email '<email>'
	And I enter unique username '<username>'
	And I enter registration password '<password>'
	And I select day '<day>' month '<month>' and '<year>' of birth
	And I click agree with GTC
	And I click recaptcha
	And I click begin adventure button
	Then I should be on a registration confirmation page
	And I should see welcome bonus message
	And I should see confirmation email message

	Examples: 
	| email		      | username | password     | day | month | year |
	| test@email.com  | username | TestPass123! | 20  | 7     | 1991 |

@Registration @Tooltips
Scenario Outline: Verify registration form labels and tooltips
	As a user I want to see element tooltips and labels displayed correctly and translated accordingly.
	Given I am on the gametwist home page
	When I change language to '<language>'
	And I click register button
	And I click email input field
	Then I should see an email toltip '<emailTooltip>'
	And I should see email label text '<emailLabel>'
	When I click username input field
	Then I should see a username toltip '<usernameTooltip>'
	And I should see username label text '<usernameLabel>'
	When I click password input field
	Then I should see a password tooltip '<passwordTooltip>'
	And I should see a password tooltip '<passwordTooltip2>'
	And I should see password label text '<passwordLabel>'
	And I should see date label text '<dateLabel>'
	And I should see GTC text '<GTCText>'
	And I should see welcome bonus text '<welcomeBonusText>'
	And begin adventrure button text should be '<buttonText>'

	@Smoke
	Examples: 
	| language | emailTooltip                         | emailLabel | usernameTooltip                | usernameLabel | passwordTooltip                                   | passwordTooltip2                                     | passwordLabel | dateLabel | GTCText | welcomeBonusText | buttonText |
	| EN       | Please enter a valid e-mail address. | E-mail     | Please enter a valid nickname. | Nickname      | Your password must be at least 8 characters long. | At least one number or a special character required. | Password      | Date of birth | I agree with the GTC and data protection guidelines. | 30,000 Twist Welcome Bonus & 15 Free Spins for Book of Ra™ deluxe | BEGIN ADVENTURE |  
	
	@Regression
	Examples:  
	| language | emailTooltip                                | emailLabel | usernameTooltip                    | usernameLabel | passwordTooltip                                      | passwordTooltip2                                      | passwordLabel | dateLabel | GTCText | welcomeBonusText | buttonText |
	| FR       | Merci d'indiquer une adresse e-mail valide. | E-mail     | Merci d'indiquer un pseudo valide. | Pseudo        | Ton mot de passe doit compter au moins 8 caractères. | Utiliser au moins un chiffre ou un caractère spécial. | Mot de passe  | Date de naissance | J'accepte les conditions générales d'utilisation et les directives sur la protection des données. | Bonus de bienvenue : 30 000 Twists & 15 tours gratuits pour Book of Ra™ deluxe | COMMENCER L'AVENTURE | 
	# TODO add more languages

@Registration @Negative
Scenario Outline: Verify field error messages and transaltion
	As a user I want to be shown error messages on invalid or on no input.
	Given I am on the gametwist home page
	When I change language to '<language>'
	And I click register button
	And I click begin adventure button
	Then I should see email error message '<emailErrorMessage>'
	And I should see username error message '<usernameErrorMessage>'
	And I should see password error message '<passwordErrorMessage>'
	And I should see day error message '<dayErrorMessage>'
	And I should see month error message '<monthErrorMessage>'
	And I should see year error message '<yearErrorMessage>'
	And I should see recaptcha error message '<recaptchaErrorMessage>'
	And I should see GTC error message '<gtcErrorMessage>'

	@Smoke
	Examples: 
	| language | emailErrorMessage       | usernameErrorMessage | passwordErrorMessage | dayErrorMessage   | monthErrorMessage   | yearErrorMessage   | recaptchaErrorMessage                                          | gtcErrorMessage                                               |
	| EN       | E-mail address required | Nickname required    | Password required    | Please select day | Please select month | Please select year | The security check is a required field. Please enter the code. | You must agree to our General Terms & Conditions to continue. |

	@Regression
	Examples: 
	| language | emailErrorMessage        | usernameErrorMessage | passwordErrorMessage  | dayErrorMessage          | monthErrorMessage        | yearErrorMessage           | recaptchaErrorMessage                                                       | gtcErrorMessage                                                               |
	| FR       | Adresse e-mail manquante | Pseudo manquant      | Mot de passe manquant | Merci de choisir un jour | Merci de choisir un mois | Merci de choisir une année | Le processus de sécurité est un champ obligatoire. Merci de saisir le code. | Avant de poursuivre, tu dois accepter nos conditions générales d'utilisation. |
#TODO add more languages

@Registration @Negative @Regression
Scenario Outline: Try to Register at gametwist.com with invalid values
	As a user I should be able to fill out the registration form with invalid data 
	and on sumbit I should see appropriate error messages
	Given I am on the gametwist home page
	When I change language to '<language>'
	When I click register button
	And I close cookie popup
	And I enter email '<email>'
	And I enter registration username '<username>'
	And I enter registration password '<password>'
	And I select day '<day>' month '<month>' and '<year>' of birth
	And I click begin adventure button
	Then I should see email error message '<emailErrorMessage>'
	And I should see username error message '<usernameErrorMessage>'
	And I should see password error message '<passwordErrorMessage>'
	And I should see date error message '<dateErrorMessage>'

	Examples: 
	| language | email                    | username       | password     | day | month | year | emailErrorMessage                                 | usernameErrorMessage                                                  | passwordErrorMessage                                                               | dateErrorMessage                                                    |
	| EN       | invalidEmail             | usernameTest   | TestPass123! | 1   | 2     | 1991 | Please enter a valid e-mail address.              | null                                                                  | null                                                                               | null                                                                |
	| EN       | 2char@username.com       | us             | TestPass123! | 1   | 2     | 1991 | null                                              | Your nickname must be between 3 and 13 characters long.               | null                                                                               | null                                                                |
	| EN       | 2char@username.com       | qwe            | TestPass123! | 1   | 2     | 1991 | null                                              | This nickname is already taken. Possible alternatives:                | null                                                                               | null                                                                |
	| EN       | 14char@username.com      | ususususususus | TestPass123! | 1   | 2     | 1991 | null                                              | Your nickname must be between 3 and 13 characters long.               | null                                                                               | null                                                                |
	| EN       | specialchar@username.com | username@      | TestPass123! | 1   | 2     | 1991 | null                                              | Your nickname may not contain Cyrillic letters or special characters. | null                                                                               | null                                                                |
	| EN       | cyrilicchar@username.com | usernameл      | TestPass123! | 1   | 2     | 1991 | null                                              | Your nickname may not contain Cyrillic letters or special characters. | null                                                                               | null                                                                |
	| EN       | mail@mail.com            | usernameTest   | 12345678     | 1   | 2     | 1991 | null                                              | null                                                                  | Your password must contain at least one letter, one number or a special character. | null                                                                |
	| EN       | mail@mail.com            | usernameTest   | qwertyui     | 1   | 2     | 1991 | null                                              | null                                                                  | Your password must contain at least one letter, one number or a special character. | null                                                                |
	| EN       | mail@mail.com            | usernameTest   | @@@@1234     | 1   | 2     | 1991 | null                                              | null                                                                  | Your password must contain at least one letter, one number or a special character. | null                                                                |
	| EN       | mail@mail.com            | usernameTest   | qwe123@      | 1   | 2     | 1991 | null                                              | null                                                                  | Your password must be at least 8 characters long.                                  | null                                                                |
	| EN       | mail@mail.com            | usernameTest   | TestPass123! | 1   | 12    | 2003 | null                                              | null                                                                  | null                                                                               | The minimum legal age required for using our offerings is 18 years. |

@Registration @Negative @Regression
Scenario Outline: Try to Register already registered user
	As a user I shouldnt be able to register using already registered email
	Given I am on the gametwist home page
	When I click register button
	And I close cookie popup
	And I enter email '<email>'
	And I enter registration username '<username>'
	And I enter registration password '<password>'
	And I select day '<day>' month '<month>' and '<year>' of birth
	And I click agree with GTC
	And I click recaptcha
	And I click begin adventure button
	Then I should see email error message '<emailErrorMessage>'

	Examples: 
	| language | email                    | username       | password     | day | month | year | emailErrorMessage                                 |
	| EN       | registered@mail.com      | usernameTest   | TestPass123! | 1   | 2     | 1991 | The e-mail address you entered is already in use. |