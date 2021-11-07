using GreenTubeSF.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace GreenTubeSLN.PageObjects
{
    public class RegistrationPage : BasePage
    {
        IWebDriver driver;
        WebDriverWait wdWait;

        public RegistrationPage(IWebDriver driver, WebDriverWait wdWait) : base(driver, wdWait)
        {
            this.driver = driver;
            this.wdWait = wdWait;
            PageFactory.InitElements(driver, this);
        }

        #region Elements

        #region Form 
        [FindsBy(How = How.CssSelector, Using = "a.c-btn--secondary")]
        IWebElement LoginButton { get; set; }
        [FindsBy(How = How.Name, Using = "email")]
        IWebElement Email { get; set; }
        [FindsBy(How = How.Name, Using = "nickname")]
        IWebElement Username { get; set; }
        [FindsBy(How = How.Name, Using = "password")]
        IWebElement Password { get; set; }
        [FindsBy(How = How.Name, Using = "day")]
        IWebElement Day { get; set; }
        [FindsBy(How = How.Name, Using = "month")]
        IWebElement Month { get; set; }
        [FindsBy(How = How.Name, Using = "year")]
        IWebElement Year { get; set; }
        [FindsBy(How = How.Id, Using = "recaptcha-anchor")]
        IWebElement Captcha { get; set; }
        [FindsBy(How = How.Id, Using = "termsAccept")]
        IWebElement GTC { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-btn--primary")]
        IWebElement BeginAdventure { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-modal__headline")]
        IWebElement FormHeaderTitle { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-registration__promo-photo")]
        IWebElement Image { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-registration__promo-headline")]
        IWebElement WelcomeBonusText { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='email']/../label")]
        IWebElement EmailLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='nickname']/../label")]
        IWebElement UsernameLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='password']/../label")]
        IWebElement PasswordLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[@name='day']/../../..//label")]
        IWebElement DOBLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[@name='day']/../../..//i")]
        IWebElement EightenPlusIcon { get; set; }
        [FindsBy(How = How.CssSelector, Using = "[for='termsAccept']")]
        IWebElement GTCText { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='email']/../..//li")]
        IWebElement EmailErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='nickname']/../..//li")]
        IWebElement UsernameErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='password']/../..//li")]
        IWebElement PasswordErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[@name='year']/../../..//ul/li")]
        IWebElement DOBErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//section/div[5]//ul/li")]
        IWebElement CaptchaErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='termsAccept']/../..//ul/li")]
        IWebElement GTCErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='email']/../div")]
        IWebElement EmailTooltip { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='nickname']/../div")]
        IWebElement UsernameTooltip { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='password']/../div")]
        IWebElement PasswordTooltip { get; set; }

        #endregion

        #endregion Elements

        #region Type Actions
        public void EnterUniqueEmail(string email) 
        {
            TypeText(Email, email.Replace("@", CurrentTimeMillis()+"@"));
        }
        public void EnterUniqueUsername(string username)
        {
            TypeText(Username, username+CurrentTimeMillis());
        }
        public void EnterPassword(string password)
        {
            TypeText(Password, password);
        }
        #endregion

        #region Select actions
        public void SelectDOB(string day,string month, string year)
        {
            SelectElementByValue(Day, day);
            SelectElementByValue(Month, month);
            SelectElementByValue(Year, year);
        }
        #endregion

        #region Click actions
        public void ClickReCaptcha()
        {
            //TODO SWITCH TO A NEW FRAME 
            ClickElement(Captcha);
        }
        public void ClickAgreeWithGTC()
        {
            ClickElement(GTC);
        }
        public void ClickBeginAdventure()
        {
            ClickElement(BeginAdventure);
        }
        #endregion

        #region Verifications
        public void VerifyConfirmationURL()
        {
            AssertEquals("https://www.gametwist.com/en/registration/confirmation", driver.Url);
        }
        #endregion

    }
}