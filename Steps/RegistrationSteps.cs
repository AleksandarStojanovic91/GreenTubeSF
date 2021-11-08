using GreenTubeSLN.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace GreenTubeSF.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        IWebDriver driver;
        WebDriverWait wdWait;
        HomePage homePage;
        RegistrationPage registrationPage;
        RegistrationConfirmationPage registrationConfirmationPage;

        public RegistrationSteps(IWebDriver driver)
        {
            this.driver = driver;
            homePage = new HomePage(driver, wdWait);
            registrationPage = new RegistrationPage(driver, wdWait);
            registrationConfirmationPage = new RegistrationConfirmationPage(driver, wdWait);
        }

        #region When

        [When(@"I click register button")]
        public void WhenIClickRegisterButton()
        {
            homePage.ClickRegisterHeaderButton();
        }

        [When(@"I enter unique email '(.*)'")]
        public void WhenIEnterUniqueEmail(string email)
        {
            registrationPage.EnterUniqueEmail(email);
        }

        [When(@"I enter unique username '(.*)'")]
        public void WhenIEnterUniqueUsername(string username)
        {
            registrationPage.EnterUniqueUsername(username);
        }

        [When(@"I enter registration password '(.*)'")]
        public void WhenIEnterRegistrationPassword(string password)
        {
            registrationPage.EnterPassword(password);
        }

        [When(@"I select day '(.*)' month '(.*)' and '(.*)' of birth")]
        public void WhenISelectDayMonthAndOfBirth(string day, string month, string year)
        {
            registrationPage.SelectDOB(day, month, year);
        }

        [When(@"I click recaptcha")]
        public void WhenIClickRecaptcha()
        {
            registrationPage.ClickReCaptcha();
        }

        [When(@"I click agree with GTC")]
        public void WhenIClickAgreeWithGTC()
        {
            registrationPage.ClickAgreeWithGTC();
        }

        [When(@"I click begin adventure button")]
        public void WhenIClickBeginAdventureButton()
        {
            registrationPage.ClickBeginAdventure();
        }

        [When(@"I click email input field")]
        public void WhenIClickEmailInputField()
        {
            registrationPage.ClickEmailField();
        }

        [When(@"I click username input field")]
        public void WhenIClickUsernameInputField()
        {
            registrationPage.ClickUsernameField();
        }

        [When(@"I click password input field")]
        public void WhenIClickPasswordInputField()
        {
            registrationPage.ClickPasswordField();
        }


        [When(@"I enter email '(.*)'")]
        public void WhenIEnterEmail(string email)
        {
            registrationPage.EnterEmail(email);
        }

        [When(@"I close cookie popup")]
        public void WhenICloseCookiePopup()
        {
            registrationPage.CloseCookiePopup();
        }

        #endregion

        #region Then
        [Then(@"I should be on a registration confirmation page")]
        public void ThenIShouldBeOnARegistrationConfirmationPage()
        {
            registrationPage.VerifyConfirmationURL();
        }

        [Then(@"I should see welcome bonus message")]
        public void ThenIShouldSeeWelcomeBonusMessage()
        {
            registrationConfirmationPage.VerifyWelcomeBonusMessage();
        }

        [Then(@"I should see confirmation email message")]
        public void ThenIShouldSeeConfirmationEmailMessage()
        {
            registrationConfirmationPage.VerifyEmailConfirmationMessage();
        }

        [Then(@"I should see an email toltip '(.*)'")]
        public void ThenIShouldSeeAnEmailToltip(string emailTooltip)
        {
            registrationPage.VerifyEmailTooltipText(emailTooltip);
        }

        [Then(@"I should see email label text '(.*)'")]
        public void ThenIShouldSeeEmailLabelText(string emailLabel)
        {
            registrationPage.VerifyEmailLabelText(emailLabel);
        }

        [Then(@"I should see a username toltip '(.*)'")]
        public void ThenIShouldSeeAUsernameToltip(string usernameTooltip)
        {
            registrationPage.VerifyUsernameTooltipText(usernameTooltip);
        }

        [Then(@"I should see username label text '(.*)'")]
        public void ThenIShouldSeeUsernameLabelText(string usernameLabel)
        {
            registrationPage.VerifyUsernameLabelText(usernameLabel);
        }
        [Then(@"I should see a password tooltip '(.*)'")]

        public void ThenIShouldSeeAPasswordTooltip(string passwordTooltip)
        {
            registrationPage.VerifyPasswordTooltipText(passwordTooltip);
        }

        [Then(@"I should see password label text '(.*)'")]
        public void ThenIShouldSeePasswordLabelText(string passwordLabel)
        {
            registrationPage.VerifyPasswordLabelText(passwordLabel);
        }

        [Then(@"I should see date label text '(.*)'")]
        public void ThenIShouldSeeDateLabelText(string dateLabel)
        {
            registrationPage.VerifyDateLabelText(dateLabel);
        }

        [Then(@"I should see GTC text '(.*)'")]
        public void ThenIShouldSeeGTCText(string GTCText)
        {
            registrationPage.VerifyGTCText(GTCText);
        }

        [Then(@"I should see welcome bonus text '(.*)'")]
        public void ThenIShouldSeeWelcomeBonusText(string bonusText)
        {
            registrationPage.VerifyWelcomeBonusText(bonusText);
        }

        [Then(@"begin adventrure button text should be '(.*)'")]
        public void ThenBeginAdventrureButtonTextShouldBe(string buttonText)
        {
            registrationPage.VerifyBeginAdventureButtonText(buttonText);
        }

        [Then(@"I should see email error message '(.*)'")]
        public void ThenIShouldSeeEmailErrorMessage(string emailError)
        {
            registrationPage.VerifyEmailErrorMessage(emailError);
        }

        [Then(@"I should see day error message '(.*)'")]
        public void ThenIShouldSeeDayErrorMessage(string dayError)
        {
            registrationPage.VerifyDayErrorMessage(dayError);
        }

        [Then(@"I should see month error message '(.*)'")]
        public void ThenIShouldSeeMonthErrorMessage(string monthError)
        {
            registrationPage.VerifyMonthErrorMessage(monthError);
        }

        [Then(@"I should see year error message '(.*)'")]
        public void ThenIShouldSeeYearErrorMessage(string year)
        {
            registrationPage.VerifyYearErrorMessage(year);
        }

        [Then(@"I should see recaptcha error message '(.*)'")]
        public void ThenIShouldSeeRecaptchaErrorMessage(string captchaError)
        {
            registrationPage.VerifyCaptchaErrorMessage(captchaError);
        }

        [Then(@"I should see GTC error message '(.*)'")]
        public void ThenIShouldSeeGTCErrorMessage(string GTCError)
        {
            registrationPage.VerifyGTCErrorMessage(GTCError);
        }

        [Then(@"I should see date error message '(.*)'")]
        public void ThenIShouldSeeDateErrorMessage(string dateError)
        {
            Console.WriteLine("DATEEEEEEEE: "+dateError);
                
            registrationPage.VerifyDayErrorMessage(dateError);
        }

        [When(@"I enter registration username '(.*)'")]
        public void WhenIEnterRegistrationUsername(string username)
        {
            registrationPage.EnterUsername(username);
        }

        #endregion

    }
}
