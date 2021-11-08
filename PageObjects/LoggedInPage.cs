using GreenTubeSF.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

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
        [FindsBy(How = How.CssSelector, Using = ".c-wheel__btn-close")]
        IWebElement CloseWheelButton { get; set; }

        #endregion Elements

        #region Verifications
        public void VerifyUsername(string text)
        {
            Assert.AreEqual(text, Username.Text);
        }
        public void CloseWheel()
        {
            try
            {
                ClickElement(CloseWheelButton);
                Thread.Sleep(3000);
            }
            catch
            { 
                //Ignore
            }
        }
        #endregion

    }
}