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
    [NUnit.Framework.DescriptionAttribute("Registration")]
    public partial class RegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Registration.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Registration", @"	As a user I should be able to register using registration from and following ""Register now"" link, 
	I also should be able to register using other languages and in case of invalid field values I should see appropriate error messages 
	with propper translation. When clicking input fields i should also see tooltips, with propper translation as well.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Register at gametwist.com")]
        [NUnit.Framework.CategoryAttribute("Registration")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("test@email.com", "username", "TestPass123!", "20", "7", "1991", null)]
        public virtual void RegisterAtGametwist_Com(string email, string username, string password, string day, string month, string year, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Registration",
                    "HappyPath",
                    "Smoke",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("day", day);
            argumentsOfScenario.Add("month", month);
            argumentsOfScenario.Add("year", year);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register at gametwist.com", "\tAs a user I should be able to fill out the registration form and successfully re" +
                    "gister.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
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
#line 9
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When("I click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And(string.Format("I enter unique email \'{0}\'", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("I enter unique username \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("I enter registration password \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("I select day \'{0}\' month \'{1}\' and \'{2}\' of birth", day, month, year), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("I click agree with GTC", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("I click recaptcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("I click begin adventure button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("I should be on a registration confirmation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.And("I should see welcome bonus message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("I should see confirmation email message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register at gametwist.com through register now link")]
        [NUnit.Framework.CategoryAttribute("Registration")]
        [NUnit.Framework.CategoryAttribute("HappyPath")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("test@email.com", "username", "TestPass123!", "20", "7", "1991", null)]
        public virtual void RegisterAtGametwist_ComThroughRegisterNowLink(string email, string username, string password, string day, string month, string year, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Registration",
                    "HappyPath",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("day", day);
            argumentsOfScenario.Add("month", month);
            argumentsOfScenario.Add("year", year);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register at gametwist.com through register now link", "\tAs a user I should be able to fill out the registration form and successfully re" +
                    "gister.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 27
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
#line 29
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 30
 testRunner.When("I click login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("I click register now link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("I enter unique email \'{0}\'", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And(string.Format("I enter unique username \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And(string.Format("I enter registration password \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And(string.Format("I select day \'{0}\' month \'{1}\' and \'{2}\' of birth", day, month, year), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("I click agree with GTC", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("I click recaptcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("I click begin adventure button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then("I should be on a registration confirmation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.And("I should see welcome bonus message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("I should see confirmation email message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify registration form labels and tooltips")]
        [NUnit.Framework.CategoryAttribute("Registration")]
        [NUnit.Framework.CategoryAttribute("Tooltips")]
        [NUnit.Framework.TestCaseAttribute("EN", "Please enter a valid e-mail address.", "E-mail", "Please enter a valid nickname.", "Nickname", "Your password must be at least 8 characters long.", "At least one number or a special character required.", "Password", "Date of birth", "I agree with the GTC and data protection guidelines.", "30,000 Twist Welcome Bonus & 15 Free Spins for Book of Ra™ deluxe", "BEGIN ADVENTURE", new string[] {
                "Smoke"}, Category="Smoke")]
        [NUnit.Framework.TestCaseAttribute("FR", "Merci d\'indiquer une adresse e-mail valide.", "E-mail", "Merci d\'indiquer un pseudo valide.", "Pseudo", "Ton mot de passe doit compter au moins 8 caractères.", "Utiliser au moins un chiffre ou un caractère spécial.", "Mot de passe", "Date de naissance", "J\'accepte les conditions générales d\'utilisation et les directives sur la protect" +
            "ion des données.", "Bonus de bienvenue : 30 000 Twists & 15 tours gratuits pour Book of Ra™ deluxe", "COMMENCER L\'AVENTURE", new string[] {
                "Regression"}, Category="Regression")]
        public virtual void VerifyRegistrationFormLabelsAndTooltips(string language, string emailTooltip, string emailLabel, string usernameTooltip, string usernameLabel, string passwordTooltip, string passwordTooltip2, string passwordLabel, string dateLabel, string gTCText, string welcomeBonusText, string buttonText, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Registration",
                    "Tooltips"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("emailTooltip", emailTooltip);
            argumentsOfScenario.Add("emailLabel", emailLabel);
            argumentsOfScenario.Add("usernameTooltip", usernameTooltip);
            argumentsOfScenario.Add("usernameLabel", usernameLabel);
            argumentsOfScenario.Add("passwordTooltip", passwordTooltip);
            argumentsOfScenario.Add("passwordTooltip2", passwordTooltip2);
            argumentsOfScenario.Add("passwordLabel", passwordLabel);
            argumentsOfScenario.Add("dateLabel", dateLabel);
            argumentsOfScenario.Add("GTCText", gTCText);
            argumentsOfScenario.Add("welcomeBonusText", welcomeBonusText);
            argumentsOfScenario.Add("buttonText", buttonText);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify registration form labels and tooltips", "\tAs a user I want to see element tooltips and labels displayed correctly and tran" +
                    "slated accordingly.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 48
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
#line 50
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 51
 testRunner.When(string.Format("I change language to \'{0}\'", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.And("I click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("I click email input field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.Then(string.Format("I should see an email toltip \'{0}\'", emailTooltip), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.And(string.Format("I should see email label text \'{0}\'", emailLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.When("I click username input field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then(string.Format("I should see a username toltip \'{0}\'", usernameTooltip), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.And(string.Format("I should see username label text \'{0}\'", usernameLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.When("I click password input field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then(string.Format("I should see a password tooltip \'{0}\'", passwordTooltip), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.And(string.Format("I should see a password tooltip \'{0}\'", passwordTooltip2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And(string.Format("I should see password label text \'{0}\'", passwordLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And(string.Format("I should see date label text \'{0}\'", dateLabel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And(string.Format("I should see GTC text \'{0}\'", gTCText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And(string.Format("I should see welcome bonus text \'{0}\'", welcomeBonusText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And(string.Format("begin adventrure button text should be \'{0}\'", buttonText), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify field error messages and transaltion")]
        [NUnit.Framework.CategoryAttribute("Registration")]
        [NUnit.Framework.CategoryAttribute("Negative")]
        [NUnit.Framework.TestCaseAttribute("EN", "E-mail address required", "Nickname required", "Password required", "Please select day", "Please select month", "Please select year", "The security check is a required field. Please enter the code.", "You must agree to our General Terms & Conditions to continue.", new string[] {
                "Smoke"}, Category="Smoke")]
        [NUnit.Framework.TestCaseAttribute("FR", "Adresse e-mail manquante", "Pseudo manquant", "Mot de passe manquant", "Merci de choisir un jour", "Merci de choisir un mois", "Merci de choisir une année", "Le processus de sécurité est un champ obligatoire. Merci de saisir le code.", "Avant de poursuivre, tu dois accepter nos conditions générales d\'utilisation.", new string[] {
                "Regression"}, Category="Regression")]
        public virtual void VerifyFieldErrorMessagesAndTransaltion(string language, string emailErrorMessage, string usernameErrorMessage, string passwordErrorMessage, string dayErrorMessage, string monthErrorMessage, string yearErrorMessage, string recaptchaErrorMessage, string gtcErrorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Registration",
                    "Negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("emailErrorMessage", emailErrorMessage);
            argumentsOfScenario.Add("usernameErrorMessage", usernameErrorMessage);
            argumentsOfScenario.Add("passwordErrorMessage", passwordErrorMessage);
            argumentsOfScenario.Add("dayErrorMessage", dayErrorMessage);
            argumentsOfScenario.Add("monthErrorMessage", monthErrorMessage);
            argumentsOfScenario.Add("yearErrorMessage", yearErrorMessage);
            argumentsOfScenario.Add("recaptchaErrorMessage", recaptchaErrorMessage);
            argumentsOfScenario.Add("gtcErrorMessage", gtcErrorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify field error messages and transaltion", "\tAs a user I want to be shown error messages on invalid or on no input.", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 80
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
 testRunner.And("I click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("I click begin adventure button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.Then(string.Format("I should see email error message \'{0}\'", emailErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.And(string.Format("I should see username error message \'{0}\'", usernameErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And(string.Format("I should see password error message \'{0}\'", passwordErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And(string.Format("I should see day error message \'{0}\'", dayErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And(string.Format("I should see month error message \'{0}\'", monthErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And(string.Format("I should see year error message \'{0}\'", yearErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.And(string.Format("I should see recaptcha error message \'{0}\'", recaptchaErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And(string.Format("I should see GTC error message \'{0}\'", gtcErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Try to Register at gametwist.com with invalid values")]
        [NUnit.Framework.CategoryAttribute("Registration")]
        [NUnit.Framework.CategoryAttribute("Negative")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("EN", "invalidEmail", "usernameTest", "TestPass123!", "1", "2", "1991", "Please enter a valid e-mail address.", "null", "null", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "2char@username.com", "us", "TestPass123!", "1", "2", "1991", "null", "Your nickname must be between 3 and 13 characters long.", "null", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "2char@username.com", "qwe", "TestPass123!", "1", "2", "1991", "null", "This nickname is already taken. Possible alternatives:", "null", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "14char@username.com", "ususususususus", "TestPass123!", "1", "2", "1991", "null", "Your nickname must be between 3 and 13 characters long.", "null", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "specialchar@username.com", "username@", "TestPass123!", "1", "2", "1991", "null", "Your nickname may not contain Cyrillic letters or special characters.", "null", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "cyrilicchar@username.com", "usernameл", "TestPass123!", "1", "2", "1991", "null", "Your nickname may not contain Cyrillic letters or special characters.", "null", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "mail@mail.com", "usernameTest", "12345678", "1", "2", "1991", "null", "null", "Your password must contain at least one letter, one number or a special character" +
            ".", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "mail@mail.com", "usernameTest", "qwertyui", "1", "2", "1991", "null", "null", "Your password must contain at least one letter, one number or a special character" +
            ".", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "mail@mail.com", "usernameTest", "@@@@1234", "1", "2", "1991", "null", "null", "Your password must contain at least one letter, one number or a special character" +
            ".", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "mail@mail.com", "usernameTest", "qwe123@", "1", "2", "1991", "null", "null", "Your password must be at least 8 characters long.", "null", null)]
        [NUnit.Framework.TestCaseAttribute("EN", "mail@mail.com", "usernameTest", "TestPass123!", "1", "12", "2003", "null", "null", "null", "The minimum legal age required for using our offerings is 18 years.", null)]
        public virtual void TryToRegisterAtGametwist_ComWithInvalidValues(string language, string email, string username, string password, string day, string month, string year, string emailErrorMessage, string usernameErrorMessage, string passwordErrorMessage, string dateErrorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Registration",
                    "Negative",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("day", day);
            argumentsOfScenario.Add("month", month);
            argumentsOfScenario.Add("year", year);
            argumentsOfScenario.Add("emailErrorMessage", emailErrorMessage);
            argumentsOfScenario.Add("usernameErrorMessage", usernameErrorMessage);
            argumentsOfScenario.Add("passwordErrorMessage", passwordErrorMessage);
            argumentsOfScenario.Add("dateErrorMessage", dateErrorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to Register at gametwist.com with invalid values", "\tAs a user I should be able to fill out the registration form with invalid data \r" +
                    "\n\tand on sumbit I should see appropriate error messages", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 107
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
#line 110
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 111
 testRunner.When(string.Format("I change language to \'{0}\'", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.When("I click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.And("I close cookie popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And(string.Format("I enter email \'{0}\'", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And(string.Format("I enter registration username \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And(string.Format("I enter registration password \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And(string.Format("I select day \'{0}\' month \'{1}\' and \'{2}\' of birth", day, month, year), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.And("I click begin adventure button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.Then(string.Format("I should see email error message \'{0}\'", emailErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 120
 testRunner.And(string.Format("I should see username error message \'{0}\'", usernameErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And(string.Format("I should see password error message \'{0}\'", passwordErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And(string.Format("I should see date error message \'{0}\'", dateErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Try to Register already registered user")]
        [NUnit.Framework.CategoryAttribute("Registration")]
        [NUnit.Framework.CategoryAttribute("Negative")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("EN", "registered@mail.com", "usernameTest", "TestPass123!", "1", "2", "1991", "The e-mail address you entered is already in use.", null)]
        public virtual void TryToRegisterAlreadyRegisteredUser(string language, string email, string username, string password, string day, string month, string year, string emailErrorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Registration",
                    "Negative",
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("language", language);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("day", day);
            argumentsOfScenario.Add("month", month);
            argumentsOfScenario.Add("year", year);
            argumentsOfScenario.Add("emailErrorMessage", emailErrorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Try to Register already registered user", "\tAs a user I shouldnt be able to register using already registered email", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 139
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
#line 141
 testRunner.Given("I am on the gametwist home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 142
 testRunner.When("I click register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 143
 testRunner.And("I close cookie popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.And(string.Format("I enter email \'{0}\'", email), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.And(string.Format("I enter registration username \'{0}\'", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 146
 testRunner.And(string.Format("I enter registration password \'{0}\'", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 147
 testRunner.And(string.Format("I select day \'{0}\' month \'{1}\' and \'{2}\' of birth", day, month, year), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 148
 testRunner.And("I click agree with GTC", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.And("I click recaptcha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 150
 testRunner.And("I click begin adventure button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.Then(string.Format("I should see email error message \'{0}\'", emailErrorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
