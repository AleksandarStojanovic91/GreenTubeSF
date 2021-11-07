using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace GreenTubeSF.PageObjects
{
    public class BasePage
    {
        IWebDriver driver;
        WebDriverWait wdWait;
        int waitTime = 30;

        public BasePage(IWebDriver driver, WebDriverWait wdWait)
        {
            this.driver = driver;
            this.wdWait = wdWait;
            PageFactory.InitElements(driver, this);
        }

        public void ClickElement(IWebElement element)
        {
            Thread.Sleep(300);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            wdWait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            try
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(element).Build().Perform();
                element.Click();
            }
            catch (StaleElementReferenceException)
            {
                element.Click();
            }
        }

        public void TypeText(IWebElement element, string text)
        {
            if (text != null && !text.Equals("null"))
            {
                wdWait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
                wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

                try
                {
                    element.Clear();
                    element.SendKeys(text);
                }
                catch (StaleElementReferenceException)
                {
                    element.Clear();
                    element.SendKeys(text);
                }
            }
        }

        public void SelectElementByValue(IWebElement element, string value)
        {
            wdWait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            try
            {
                SelectElement select = new SelectElement(element);
                select.SelectByValue(value);
            }
            catch (StaleElementReferenceException)
            {
                SelectElement select = new SelectElement(element);
                select.SelectByValue(value);
            }
        }

        public void AssertEquals(string expected, IWebElement element) 
        {
            if (expected != null && !expected.Equals("null")) 
            {
                wdWait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
                wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                Assert.AreEqual(expected, element.Text);
            }
        }

        public void AssertEquals(string expected, string actual)
        {
            if (expected != null && !expected.Equals("null"))
            {
                Assert.AreEqual(expected, actual);
            }
        }

        public string CurrentTimeMillis() 
        {
            DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (DateTime.UtcNow - Jan1st1970).TotalMilliseconds.ToString();
        }

        //TODO add more wrapper methods, screenshots etc...
    }
}
