using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

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
            if (text != null)
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

        //TODO add more wrapper methods, screenshots etc...
    }
}
