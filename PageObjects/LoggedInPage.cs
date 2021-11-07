using GreenTubeSF.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace GreenTubeSLN.PageObjects
{
    public class LoggedInPage : BasePage
    {
        IWebDriver driver;
        WebDriverWait wdWait;

        public LoggedInPage(IWebDriver driver, WebDriverWait wdWait) : base(driver, wdWait)
        {
            this.driver = driver;
            this.wdWait = wdWait;
            PageFactory.InitElements(driver, this);
        }

        #region Elements

        [FindsBy(How = How.CssSelector, Using = ".c-bar-status__username")]
        IWebElement Username { get; set; }

        #endregion Elements

        #region Verifications
        public void VerifyUsername(string text)
        {
            Assert.AreEqual(text, Username.Text);
        }
        #endregion

    }
}