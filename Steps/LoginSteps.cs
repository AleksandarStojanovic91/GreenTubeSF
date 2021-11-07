using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GreenTubeSF.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am on the gametwist home page")]
        public void GivenIAmOnTheGametwistHomePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter my username")]
        public void WhenIEnterMyUsername()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click submit login button")]
        public void WhenIClickSubmitLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see games menu")]
        public void ThenIShouldSeeGamesMenu()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see my profile username")]
        public void ThenIShouldSeeMyProfileUsername()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
