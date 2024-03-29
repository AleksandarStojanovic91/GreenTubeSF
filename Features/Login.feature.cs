﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GreenTubeSF.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login")]
    public partial class LoginFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Login", @"	As a user I should be able to Login with valid credentials on the Login form,
	in case of invalid credeentials or in case when I do not enter credentials
	I want to see appropriate error messages, also i should be able to select other languages
	And see appropriate translations.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login to gametwist.com with valid credentials")]
        [NUnit.Framework.CategoryAttribute("Login")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void LoginToGametwist_ComWithValidCredentials()
        {
            string[] tagsOfScenario = new string[] {
                    "Login",
                    "HappyPath",
                    "Smoke",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to gametwist.com with valid credentials", "\t\tAs a user I want to be able to login to gametwist.com using valid credentials.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.When("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And("I enter my username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("I enter my password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("I click submit login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.Then("I should see my profile username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login to gametwist.com with valid credentials through registration\'s page login")]
        [NUnit.Framework.CategoryAttribute("Login")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.CategoryAttribute("RegistartionPageLogin")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void LoginToGametwist_ComWithValidCredentialsThroughRegistrationsPageLogin()
        {
            string[] tagsOfScenario = new string[] {
                    "Login",
                    "HappyPath",
                    "RegistartionPageLogin",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login to gametwist.com with valid credentials through registration\'s page login", "\t\tAs a user I want to be able to login to gametwist.com using valid credentials,\r" +
                    "\n\t\tfrom registration page.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 21
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.When("I click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.And("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("I enter my username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("I enter my password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("I click submit login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then("I should see my profile username", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Translation of Login Form")]
        [NUnit.Framework.CategoryAttribute("Login")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.CategoryAttribute("LanguageTransaltion")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("EN", "Login", "Nickname", "Password", "Log in automatically", "LOG IN", "Forgotten your password?", "You don\'t have an account yet?", "Register now", null)]
        [NUnit.Framework.TestCaseAttribute("FR", "Connexion", "Pseudo", "Mot de passe", "Connexion automatique", "CONNEXION", "Mot de passe oublié ?", "Tu n\'as pas encore de compte ?", "S\'inscrire maintenant", null)]
        public virtual void VerifyTranslationOfLoginForm(string language, string formHeaderText, string usernameLabel, string passwordLabel, string autoLoginText, string loginButtonText, string forgotPasswordText, string dontHaveAccountText, string registerNowText, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Login",
                    "HappyPath",
                    "LanguageTransaltion",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("formHeaderText", formHeaderText);
            argumentsOfScenario.Add("usernameLabel", usernameLabel);
            argumentsOfScenario.Add("passwordLabel", passwordLabel);
            argumentsOfScenario.Add("autoLoginText", autoLoginText);
            argumentsOfScenario.Add("loginButtonText", loginButtonText);
            argumentsOfScenario.Add("forgotPasswordText", forgotPasswordText);
            argumentsOfScenario.Add("dontHaveAccountText", dontHaveAccountText);
            argumentsOfScenario.Add("registerNowText", registerNowText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Translation of Login Form", "\t\tAs a user I want to be able to use other languages when logging in,\r\n\t\tand I wa" +
                    "nt to verify all text values are correct on a login form.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.When(string.Format("I change language to \'{0}\'", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then(string.Format("form header title should be \'{0}\'", formHeaderText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.And(string.Format("username label should be \'{0}\'", usernameLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And(string.Format("password label should be \'{0}\'", passwordLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And(string.Format("auto login text should be \'{0}\'", autoLoginText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And(string.Format("login button text should be \'{0}\'", loginButtonText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And(string.Format("forgot password text should be \'{0}\'", forgotPasswordText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And(string.Format("dont have account text should be \'{0}\'", dontHaveAccountText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And(string.Format("register now text should be \'{0}\'", registerNowText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Try to Login to gametwist.com with invalid credentials using other languages")]
        [NUnit.Framework.CategoryAttribute("Login")]
        [NUnit.Framework.CategoryAttribute("NegativeScenarios")]
        [NUnit.Framework.TestCaseAttribute("null", "NoUsername", "Nickname required", "null", "null", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("NoPassword", "null", "null", "Password required", "null", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("null", "null", "Nickname required", "Password required", "null", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("NonRegistered", "TestPass123!", "null", "null", "Incorrect nickname/password combination.", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("AlexBg91", "WrongPass", "null", "null", "Incorrect nickname/password combination.", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("AlexBg91", "WrongPass", "null", "null", "Incorrect nickname/password combination.", new string[] {
                "Smoke"}, Category="Smoke")]
        public virtual void TryToLoginToGametwist_ComWithInvalidCredentialsUsingOtherLanguages(string username, string password, string usernameErrorMessage, string passwordErrorMessage, string formError, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Login",
                    "NegativeScenarios"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("usernameErrorMessage", usernameErrorMessage);
            argumentsOfScenario.Add("passwordErrorMessage", passwordErrorMessage);
            argumentsOfScenario.Add("formError", formError);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to Login to gametwist.com with invalid credentials using other languages", "\t\tAs a user when I do not enter or I enter invalid credentials \r\n\t\tI should see t" +
                    "he appropriate error messages for the approprioate fields with correct transalti" +
                    "on.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 52
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 55
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
 testRunner.When("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.And(string.Format("I enter username \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And(string.Format("I enter password \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.When("I click submit login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then(string.Format("I should see username error message \'{0}\'", usernameErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.And(string.Format("I should see password error message \'{0}\'", passwordErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And(string.Format("I should see form error \'{0}\'", formError), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Try to Login to gametwist.com with invalid credentials")]
        [NUnit.Framework.CategoryAttribute("Login")]
        [NUnit.Framework.CategoryAttribute("NegativeScenarios")]
        [NUnit.Framework.CategoryAttribute("LanguageTransaltion")]
        [NUnit.Framework.TestCaseAttribute("FR", "null", "NoUsername", "Pseudo manquant", "null", "null", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("FR", "NoPassword", "null", "null", "Mot de passe manquant", "null", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("FR", "null", "null", "Pseudo manquant", "Mot de passe manquant", "null", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("FR", "NonRegistered", "TestPass123!", "null", "null", "Mauvaise combinaison pseudo/mot de passe.", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("FR", "AlexBg91", "WrongPass", "null", "null", "Mauvaise combinaison pseudo/mot de passe.", new string[] {
                "Regression"}, Category="Regression")]
        [NUnit.Framework.TestCaseAttribute("FR", "AlexBg91", "WrongPass", "null", "null", "Mauvaise combinaison pseudo/mot de passe.", new string[] {
                "Smoke"}, Category="Smoke")]
        public virtual void TryToLoginToGametwist_ComWithInvalidCredentials(string language, string username, string password, string usernameErrorMessage, string passwordErrorMessage, string formError, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Login",
                    "NegativeScenarios",
                    "LanguageTransaltion"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("usernameErrorMessage", usernameErrorMessage);
            argumentsOfScenario.Add("passwordErrorMessage", passwordErrorMessage);
            argumentsOfScenario.Add("formError", formError);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to Login to gametwist.com with invalid credentials", "\t\tAs a user when I do not enter or I enter invalid credentials \r\n\t\tI should see t" +
                    "he appropriate error messages for the approprioate fields.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 79
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 82
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 83
 testRunner.When(string.Format("I change language to \'{0}\'", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.And("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And(string.Format("I enter username \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And(string.Format("I enter password \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.When("I click submit login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.Then(string.Format("I should see username error message \'{0}\'", usernameErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.And(string.Format("I should see password error message \'{0}\'", passwordErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And(string.Format("I should see form error \'{0}\'", formError), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
