using GreenTubeSLN.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace GreenTubeSF.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        IWebDriver driver;
        WebDriverWait wdWait;
        HomePage homePage;
        LoggedInPage loggedInPage;

        public LoginSteps(IWebDriver driver)
        {
            this.driver = driver;
            homePage = new HomePage(driver, wdWait);
            loggedInPage = new LoggedInPage(driver, wdWait);
        }

        #region Given steps
        [Given(@"I am on the gametwist home page")]
        public void GivenIAmOnTheGametwistHomePage()
        {
            driver.Navigate().GoToUrl("https://www.gametwist.com/en/");
        }
        #endregion

        #region When steps
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            homePage.ClickLoginHeaderButton();
        }

        [When(@"I change language to '(.*)'")]
        public void WhenIChangeLanguageTo(string language)
        {
            homePage.SelectLanguage(language);
        }

        [When(@"I enter my username")]
        public void WhenIEnterMyUsername()
        {
            homePage.EnterUsername("AlexBg91");
        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            homePage.EnterPassword("TestPass123!");
        }

        [When(@"I click submit login button")]
        public void WhenIClickSubmitLoginButton()
        {
            homePage.ClickSubmitLoginButton();
        }

        [When(@"I enter username '(.*)'")]
        public void WhenIEnterUsername(string username)
        {
            homePage.EnterUsername(username);
        }

        [When(@"I enter password '(.*)'")]
        public void WhenIEnterPassword(string password)
        {
            homePage.EnterPassword(password);
        }
        #endregion

        #region Then steps
        [Then(@"I should see my profile username")]
        public void ThenIShouldSeeMyProfileUsername()
        {
            loggedInPage.CloseWheel();
            loggedInPage.VerifyUsername("AlexBg91");
        }

        [Then(@"I should see username error message '(.*)'")]
        public void ThenIShouldSeeUsernameErrorMessage(string usernameErrorMessage)
        {
            homePage.VerifyUsernameErrorText(usernameErrorMessage);
        }

        [Then(@"I should see password error message '(.*)'")]
        public void ThenIShouldSeePasswordErrorMessage(string passwordErrorMessage)
        {
            homePage.VerifyPasswordErrorText(passwordErrorMessage);
        }

        [Then(@"I should see form error '(.*)'")]
        public void ThenIShouldSeeFormError(string formErrorMessage)
        {
            homePage.VerifyFormErrorText(formErrorMessage);
        }

        [Then(@"form header title should be '(.*)'")]
        public void ThenFormHeaderTitleShouldBe(string text)
        {
            homePage.VerifyFormHeaderText(text);
        }

        [Then(@"username label should be '(.*)'")]
        public void ThenUsernameLabelShouldBe(string text)
        {
            homePage.VerifyUsernameLabelText(text);
        }

        [Then(@"password label should be '(.*)'")]
        public void ThenPasswordLabelShouldBe(string text)
        {
            homePage.VerifyPasswordLabelText(text);
        }

        [Then(@"auto login text should be '(.*)'")]
        public void ThenAutoLoginTextShouldBe(string text)
        {
            homePage.VerifyAutoLoginLabelText(text);
        }

        [Then(@"login button text should be '(.*)'")]
        public void ThenLoginButtonTextShouldBe(string text)
        {
            homePage.VerifySubmitLoginButtonText(text);
        }

        [Then(@"forgot password text should be '(.*)'")]
        public void ThenForgotPasswordTextShouldBe(string text)
        {
            homePage.VerifyForgottenPasswordText(text);
        }

        [Then(@"dont have account text should be '(.*)'")]
        public void ThenDontHaveAccountTextShouldBeAsPasEncoreDeCompte(string text)
        {
            homePage.VerifyYouDontHaveAnAcountText(text);
        }

        [Then(@"register now text should be '(.*)'")]
        public void ThenRegisterNowTextShouldBeInscrireMaintenant(string text)
        {
            homePage.VerifyRegisterNowText(text);
        }

        [When(@"I click register now link")]
        public void WhenIClickRegisterNowLink()
        {
            homePage.ClickRegisterNowLink();
        }
        #endregion

    }
}
