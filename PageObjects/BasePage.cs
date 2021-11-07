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

        public void AssertEquals(string expected, IWebElement element) 
        {
            if (expected != null && !expected.Equals("null")) 
            {
                wdWait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
                wdWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                Console.WriteLine("expected: " + expected + " Actual: " + element.Text);
                Assert.AreEqual(expected, element.Text);
            }
        }

        //TODO add more wrapper methods, screenshots etc...
    }
}
