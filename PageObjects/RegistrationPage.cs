using GreenTubeSF.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

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
        [FindsBy(How = How.CssSelector, Using = "#termsAccept")]
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
        [FindsBy(How = How.XPath, Using = "//select[@name='day']/../../..//ul/li[1]")]
        IWebElement DayErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[@name='month']/../../..//ul/li[2]")]
        IWebElement MonthErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[@name='year']/../../..//ul/li[3]")]
        IWebElement YearErrorMessage { get; set; }
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
        [FindsBy(How = How.CssSelector, Using = ".optanon-alert-box-close.banner-close-button")]
        IWebElement CloseCookie { get; set; }

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
        public void EnterUsername(string username)
        {
            TypeText(Username, username);
        }
        public void EnterPassword(string password)
        {
            TypeText(Password, password);
        }
        public void EnterEmail(string username)
        {
            TypeText(Email, username);
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
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("[title='reCAPTCHA']")));
            ClickElement(Captcha);
            Thread.Sleep(3000);
            driver.SwitchTo().DefaultContent();
            try
            {
                driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[contains(@title,'recaptcha challenge')]")));
            }
            catch(NoSuchElementException e) 
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            if (driver.FindElements(By.CssSelector("#rc-imageselect")).Count > 0)
            {
                throw new Exception("Captcha is ON unable to continue registration");
            }
            else
            {
                driver.SwitchTo().DefaultContent();
            }
        }
        public void ClickAgreeWithGTC()
        {
            GTC.Click();
        }
        public void ClickBeginAdventure()
        {
            ClickElement(BeginAdventure);
        }
        public void ClickEmailField()
        {
            ClickElement(Email);
        }
        public void ClickPasswordField()
        {
            ClickElement(Password);
        }
        public void ClickUsernameField()
        {
            ClickElement(Username);
        }
        public void CloseCookiePopup()
        {
            ClickElement(CloseCookie);
        }
        #endregion

        #region Verifications
        public void VerifyConfirmationURL()
        {
            Thread.Sleep(10000);
            AssertEquals("https://www.gametwist.com/en/registration/confirmation", driver.Url);
        }
        public void VerifyEmailTooltipText(string emailTooltipText) 
        {
            AssertEquals(emailTooltipText, EmailTooltip);
        }
        public void VerifyEmailLabelText(string emailLabelText)
        {
            AssertEquals(emailLabelText, EmailLabel);
        }
        public void VerifyUsernameTooltipText(string usernameTooltipText)
        {
            AssertEquals(usernameTooltipText, UsernameTooltip);
        }
        public void VerifyUsernameLabelText(string usernameLabelText)
        {
            AssertEquals(usernameLabelText, UsernameLabel);
        }
        public void VerifyPasswordTooltipText(string passwordTooltipText)
        {
            if (passwordTooltipText != null && !passwordTooltipText.Equals("null") && !passwordTooltipText.Equals(""))
            {
                Assert.True(PasswordTooltip.Text.Contains(passwordTooltipText));
            }
        }
        public void VerifyPasswordLabelText(string passwordLabelText)
        {
            AssertEquals(passwordLabelText, PasswordLabel);
        }
        public void VerifyDateLabelText(string dateLabelText)
        {
            AssertEquals(dateLabelText, DOBLabel);
        }
        public void VerifyGTCText(string gtcText)
        {
            AssertEquals(gtcText, GTCText);
        }
        public void VerifyWelcomeBonusText(string welcomeBonusText)
        {
            AssertEquals(welcomeBonusText, WelcomeBonusText);
        }
        public void VerifyBeginAdventureButtonText(string beginAdventureText)
        {
            AssertEquals(beginAdventureText, BeginAdventure);
        }
        public void VerifyEmailErrorMessage(string emailError)
        {
            AssertEquals(emailError, EmailErrorMessage);
        }
        public void VerifyDayErrorMessage(string dayError)
        {
            AssertEquals(dayError, DayErrorMessage);
        }
        public void VerifyMonthErrorMessage(string monthError)
        {
            AssertEquals(monthError, MonthErrorMessage);
        }
        public void VerifyYearErrorMessage(string yearError)
        {
            AssertEquals(yearError, YearErrorMessage);
        }
        public void VerifyCaptchaErrorMessage(string captchaError)
        {
            AssertEquals(captchaError, CaptchaErrorMessage);
        }
        public void VerifyGTCErrorMessage(string gtcError)
        {
            AssertEquals(gtcError, GTCErrorMessage);
        }
        #endregion

    }
}