using GreenTubeSF.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace GreenTubeSLN.PageObjects
{
    public class RegistrationConfirmationPage : BasePage
    {
        IWebDriver driver;
        WebDriverWait wdWait;

        public RegistrationConfirmationPage(IWebDriver driver, WebDriverWait wdWait) : base(driver, wdWait)
        {
            this.driver = driver;
            this.wdWait = wdWait;
            PageFactory.InitElements(driver, this);
        }

        #region Elements

        #region Form 
        [FindsBy(How = How.CssSelector, Using = ".c-modal__headline")]
        IWebElement FormHeaderTitle { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-modal__img-wrapper > img")]
        IWebElement Image { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-headline-glow")]
        IWebElement WelcomeBonusText { get; set; }
        [FindsBy(How = How.XPath, Using = "//form/div/div[2]/span")]
        IWebElement CheckEmailText { get; set; }
        [FindsBy(How = How.XPath, Using = "//form//strong")]
        IWebElement ConfirmationEmailText { get; set; }
        [FindsBy(How = How.Name, Using = "email")]
        IWebElement Email { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='email']/../..//li")]
        IWebElement EmailErrorMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = "c-btn--secondary")]
        IWebElement ResendEmailButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//form/div/div[7]/span")]
        IWebElement HaventReceivedEmailText { get; set; }
        [FindsBy(How = How.XPath, Using = "//form/div/div[7]/p")]
        IWebElement HaventReceivedEmailInstructionText { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-bar-status__username")]
        IWebElement ProfileUsername { get; set; }
        #endregion

        #endregion Elements

        //TODO add methods

    }
}