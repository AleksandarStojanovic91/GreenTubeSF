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

        public LoginSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Given steps
        [Given(@"I am on the gametwist home page")]
        public void GivenIAmOnTheGametwistHomePage()
        {
            driver.Navigate().GoToUrl("https:www.google.com");
        }
        #endregion

        #region When steps
        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            
        }

        [When(@"I enter my username")]
        public void WhenIEnterMyUsername()
        {
            
        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            
        }

        [When(@"I click submit login button")]
        public void WhenIClickSubmitLoginButton()
        {
            
        }
        #endregion

        #region Then steps
        [Then(@"I should see games menu")]
        public void ThenIShouldSeeGamesMenu()
        {
            
        }

        [Then(@"I should see my profile username")]
        public void ThenIShouldSeeMyProfileUsername()
        {
            
        }
        #endregion

    }
}
