using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using GreenTubeSLN.SeleniumCore;
using OpenQA.Selenium;
using System;
using System.Configuration;
using TechTalk.SpecFlow;

namespace GreenTubeSF.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        IWebDriver driver;
        DriverManager driverManager;

        private readonly IObjectContainer container;

        private static ScenarioContext _scenarioContext;
        private static FeatureContext _featureContext;
        private static ExtentReports _extentReports;
        private static ExtentHtmlReporter _extentHtmlReporter;
        private static ExtentTest _feature;
        private static ExtentTest _scenario;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            string path = ConfigurationManager.AppSettings.Get("TEST_RESULTS");
            _extentHtmlReporter = new ExtentHtmlReporter(@path);
            _extentReports = new ExtentReports();
            _extentReports.AttachReporter(_extentHtmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeatureStart(FeatureContext featureContext) 
        {
            if (null != featureContext) 
            {
                _feature = _extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title,
                    featureContext.FeatureInfo.Description);
            }
        }

        [BeforeScenario]
        public static void BeforeScenarioStart(ScenarioContext scenarioContext)
        {
            if (null != scenarioContext)
            {
                _scenarioContext = scenarioContext;
                _scenario = _feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title,
                    scenarioContext.ScenarioInfo.Description);
            }
        }

        [AfterStep]
        public static void AfterEachStep(ScenarioContext scenarioContext)
        {
            ScenarioBlock scenarioBlock = _scenarioContext.CurrentScenarioBlock;

            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail
                            (_scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                    }
                    break;
                case ScenarioBlock.When:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail
                            (_scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                    }
                    break;
                case ScenarioBlock.Then:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail
                            (_scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                    }
                    break;
                default:
                    if (_scenarioContext.TestError != null)
                    {
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text).Fail
                            (_scenarioContext.TestError.Message + "\n" + _scenarioContext.TestError.StackTrace);
                    }
                    else
                    {
                        _scenario.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
                    }
                    break;
            }
        }

        [AfterTestRun]
        public static void AfterTestRun() 
        {
            _extentReports.Flush();
        }

        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driverManager = DriverManagerFactory.GetDriverManager(ConfigurationManager.AppSettings.Get("BROWSER"));
            driver = driverManager.GetWebDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver = container.Resolve<IWebDriver>();

            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
