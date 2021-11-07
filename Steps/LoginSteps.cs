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
        #endregion

        #region Then steps
        [Then(@"I should see my profile username")]
        public void ThenIShouldSeeMyProfileUsername()
        {
            loggedInPage.VerifyUsername("AlexBg91");
        }
        #endregion

    }
}
