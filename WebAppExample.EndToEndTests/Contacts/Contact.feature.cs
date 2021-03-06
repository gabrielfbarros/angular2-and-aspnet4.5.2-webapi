﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WebAppExample.EndToEndTests.Contacts
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ContactFeature")]
    public partial class ContactFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Contact.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ContactFeature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Adding new contact")]
        public virtual void AddingNewContact()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Adding new contact", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table1.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "08/01/1970"});
#line 4
 testRunner.Given("I want to add a new contact", ((string)(null)), table1, "Given ");
#line 7
 testRunner.When("I call the post method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table2.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "08/01/1970"});
#line 8
 testRunner.Then("the result should be a reponse message with status \'OK\' and content with contact", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Editing a contact")]
        public virtual void EditingAContact()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Editing a contact", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table3.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "08/01/1970"});
#line 13
 testRunner.Given("I have a contact", ((string)(null)), table3, "Given ");
#line 16
 testRunner.And("I edit its name to \'Charles\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("email to \'charles@gmail.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("phone to empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.When("I call the put method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table4.AddRow(new string[] {
                        "Charles",
                        "charles@gmail.com",
                        "carlton st, los angeles, CA",
                        "",
                        "08/01/1970"});
#line 20
 testRunner.Then("the result should be a reponse message with status \'OK\' and content with contact", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deleting a contact")]
        public virtual void DeletingAContact()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting a contact", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table5.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "08/01/1970"});
#line 25
 testRunner.Given("I have a contact", ((string)(null)), table5, "Given ");
#line 28
 testRunner.When("I call the delete method for that contact id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the result should be a reponse message with status \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("with content \'Contact successfully deleted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Getting existing contact")]
        public virtual void GettingExistingContact()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting existing contact", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table6.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "08/01/1970"});
#line 34
 testRunner.Given("I have a contact", ((string)(null)), table6, "Given ");
#line 37
 testRunner.When("I call the get method for for that contact id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table7.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "8/1/1970"});
#line 38
 testRunner.Then("the result should be a reponse message with status \'OK\' and content with contact", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Getting all contacts")]
        public virtual void GettingAllContacts()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Getting all contacts", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table8.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "08/01/1970"});
            table8.AddRow(new string[] {
                        "Will",
                        "will@gmail.com",
                        "",
                        "",
                        ""});
#line 44
 testRunner.Given("I have following contacts", ((string)(null)), table8, "Given ");
#line 48
 testRunner.When("I call the get method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Email",
                        "Address",
                        "Phone",
                        "Birth Date"});
            table9.AddRow(new string[] {
                        "Bob",
                        "bob@gmail.com",
                        "carlton st, los angeles, CA",
                        "55123456",
                        "8/1/1970"});
            table9.AddRow(new string[] {
                        "Will",
                        "will@gmail.com",
                        "",
                        "",
                        ""});
#line 49
 testRunner.Then("the result should be a reponse message with status \'OK\' and content with contacts" +
                    "", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
