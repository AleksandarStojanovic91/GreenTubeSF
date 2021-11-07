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
        #endregion

    }
}
