using GreenTubeSF.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace GreenTubeSLN.PageObjects
{
    public class HomePage : BasePage
    {
        IWebDriver driver;
        WebDriverWait wdWait;

        public HomePage(IWebDriver driver, WebDriverWait wdWait) : base(driver, wdWait)
        {
            this.driver = driver;
            this.wdWait = wdWait;
            PageFactory.InitElements(driver, this);
        }

        #region Elements

        #region Header
        [FindsBy(How = How.CssSelector, Using = "a.c-btn--secondary")]
        IWebElement LoginButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.c-btn--primary")]
        IWebElement RegisterButton { get; set; }
        #endregion

        #region Login Form
        [FindsBy(How = How.Id, Using = "username")]
        IWebElement Username { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        IWebElement Password { get; set; }
        [FindsBy(How = How.Id, Using = "autologin")]
        IWebElement AutoLogin { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'js-confirmLoginModal')]")]
        IWebElement SubmitLogin { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-btn.c-btn--ghost")]
        IWebElement CancelButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//header[contains(@class,'c-modal__header')]/div/div/div")]
        IWebElement FormHeaderTitle { get; set; }
        [FindsBy(How = How.CssSelector, Using = "label[for='username']")]
        IWebElement UsernameLabel { get; set; }
        [FindsBy(How = How.CssSelector, Using = "label[for='password']")]
        IWebElement PasswordLabel { get; set; }
        [FindsBy(How = How.CssSelector, Using = "label[for='autologin']")]
        IWebElement AutoLoginLabel { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='password']/../i")]
        IWebElement ShowHidePassword { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='username']/../..//li")]
        IWebElement UsernameErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='password']/../..//li")]
        IWebElement PasswordErrorMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-form-errors > li")]
        IWebElement WrongUsernameOrPasswordMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-icon--question")]
        IWebElement QuestionIcon { get; set; }
        [FindsBy(How = How.CssSelector, Using = "a.o-titled-icon.o-titled-icon--centered")]
        IWebElement ForgotenPasswordLink { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".c-modal__footer span")]
        IWebElement YouDontHaveAnAccountText { get; set; }
        [FindsBy(How = How.XPath, Using = "//footer//a[@href='https://www.gametwist.com/en/registration/']")]
        IWebElement RegisterNowLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//footer[contains(@class,'c-modal__footer')]/div/i")]
        IWebElement EightteenPlusIcon { get; set; }
        [FindsBy(How = How.Id, Using = "email")]
        IWebElement Email { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='email']/../..//li")]
        IWebElement EmailErrorMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'c-btn--primary c-btn--block')]")]
        IWebElement SendButton { get; set; }
        #endregion

        #endregion Elements

        #region Click actions
        public void ClickLoginHeaderButton() 
        {
            ClickElement(LoginButton);
        }
        public void ClickRegisterHeaderButton()
        {
            ClickElement(RegisterButton);
        }
        public void ClickCancelButton()
        {
            ClickElement(CancelButton);
        }
        public void ClickAutoLogin()
        {
            ClickElement(AutoLogin);
        }
        public void ClickForgotennPasswordLink()
        {
            ClickElement(ForgotenPasswordLink);
        }
        public void ClickRegisterNowLink()
        {
            ClickElement(RegisterNowLink);
        }
        public void ClickSendButton()
        {
            ClickElement(SendButton);
        }

        public void ClickSubmitLoginButton()
        {
            ClickElement(SubmitLogin);
        }
        #endregion

        #region Type actions
        public void EnterUsername(string username) 
        {
            TypeText(Username, username);
        }
        public void EnterPassword(string password)
        {
            TypeText(Password, password);
        }
        public void EnterEmail(string email)
        {
            TypeText(Username, email);
        }

        #endregion

        #region Flows
        public void Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickSubmitLoginButton();
        }
        public void ResetPassword(string username, string email)
        {
            ClickForgotennPasswordLink();
            EnterUsername(username);
            EnterEmail(email);
        }
        #endregion

        #region Verifications
        public void VerifyFormHeaderText(string text)
        {
            Assert.AreSame(text, FormHeaderTitle.Text);
        }
        public void VerifyUsernameLabelText(string text)
        {
            Assert.AreSame(text, Username.Text);
        }
        public void VerifyPasswordLabelText(string text)
        {
            Assert.AreSame(text, Password.Text);
        }
        public void VerifyAutoLoginLabelText(string text)
        {
            Assert.AreSame(text, AutoLogin.Text);
        }
        public void VerifyForgottenPasswordText(string text)
        {
            Assert.AreSame(text, ForgotenPasswordLink.Text);
        }
        public void VerifyYouDontHaveAnAcountText(string text)
        {
            Assert.AreSame(text, YouDontHaveAnAccountText.Text);
        }
        public void VerifyRegisterNowText(string text)
        {
            Assert.AreSame(text, RegisterNowLink.Text);
        }
        public void VerifyQuestionIconIsDisplayed()
        {
            Assert.IsTrue(QuestionIcon.Displayed);
        }
        public void VerifyEighteenIconIsDisplayed()
        {
            Assert.IsTrue(EightteenPlusIcon.Displayed);
        }
        public void VerifyUsernameErrorText(string text)
        {
            Assert.AreSame(text, UsernameErrorMessage.Text);
        }
        public void VerifyPasswordErrorText(string text)
        {
            Assert.AreSame(text, PasswordErrorMessage.Text);
        }
        public void VerifyFormErrorText(string text)
        {
            Assert.AreSame(text, WrongUsernameOrPasswordMessage.Text);
        }
        public void VerifyEmailErrorText(string text)
        {
            Assert.AreSame(text, EmailErrorMessage.Text);
        }
        #endregion

    }
}