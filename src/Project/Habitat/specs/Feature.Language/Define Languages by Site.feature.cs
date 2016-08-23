﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Language.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DefineLanguagesBySiteFeature : Xunit.IClassFixture<DefineLanguagesBySiteFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Define Languages by Site.feature"
#line hidden
        
        public DefineLanguagesBySiteFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Define Languages by Site", "\tAs an editor \r\n\tI want to be able to define the supported languages on a per sit" +
                    "e basis \r\n\tso that different sites can have different languages", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(DefineLanguagesBySiteFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC1_Set one language on the site")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void DefineLanguagesBySite_UC1_SetOneLanguageOnTheSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC1_Set one language on the site", new string[] {
                        "NeedImplementation"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "Field"});
            table1.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "Supported Languages"});
#line 9
 testRunner.Given("<en> is Selected on the following item", ((string)(null)), table1, "Given ");
#line 12
 testRunner.When("User opens Habitat website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("there is no Globe icon in the Main menu on the top of the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC2_No specific languages are defined on the site")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void DefineLanguagesBySite_UC2_NoSpecificLanguagesAreDefinedOnTheSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC2_No specific languages are defined on the site", new string[] {
                        "NeedImplementation"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("Admin user is logged into Content Editor application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/ar-AE"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/da"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/de-AT"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/en"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/fr-BE"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/ja-JP"});
            table2.AddRow(new string[] {
                        "/sitecore/system/Languages/ru-RU"});
#line 19
 testRunner.And("Following languages defined in Sitecore", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "Field"});
            table3.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "Supported Languages"});
#line 28
 testRunner.When("Admin opens following item", ((string)(null)), table3, "When ");
#line 31
 testRunner.And("Admin clicks <Deselect all> link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("Admin saves changes on item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("User opens Habitat website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("User clicks Globe icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item name"});
            table4.AddRow(new string[] {
                        "English"});
            table4.AddRow(new string[] {
                        "dansk"});
            table4.AddRow(new string[] {
                        "français (Belgique)"});
            table4.AddRow(new string[] {
                        "Deutsch (Österreich)"});
            table4.AddRow(new string[] {
                        "日本語 (日本)"});
            table4.AddRow(new string[] {
                        "(العربية (الإمارات العربية المتحدة"});
            table4.AddRow(new string[] {
                        "русский (Россия)"});
#line 35
 testRunner.Then("following items available in the list", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC3_Check that language with country code appears in the" +
            " list")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void DefineLanguagesBySite_UC3_CheckThatLanguageWithCountryCodeAppearsInTheList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC3_Check that language with country code appears in the" +
                    " list", new string[] {
                        "NeedImplementation"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("Admin user is logged into Content Editor application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/ar-AE"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/da"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/de-AT"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/en"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/fr-BE"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/ja-JP"});
            table5.AddRow(new string[] {
                        "/sitecore/system/Languages/ru-RU"});
#line 49
 testRunner.And("Following languages defined in Sitecore", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "Field"});
            table6.AddRow(new string[] {
                        "/sitecore/content/Habitat",
                        "Supported Languages"});
#line 58
 testRunner.When("Admin opens following item", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language"});
            table7.AddRow(new string[] {
                        "de-AT"});
            table7.AddRow(new string[] {
                        "fr-BE"});
#line 61
 testRunner.And("Admin clicks following items in the <All> list", ((string)(null)), table7, "And ");
#line 65
 testRunner.And("Admin saves changes on item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("User opens Habitat website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("User clicks Globe icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item name"});
            table8.AddRow(new string[] {
                        "français (Belgique)"});
            table8.AddRow(new string[] {
                        "Deutsch (Österreich)"});
#line 68
 testRunner.Then("following items available in the list", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Define Languages by Site")]
        [Xunit.TraitAttribute("Description", "Define Languages by Site_UC4_Switch between languages on the site")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void DefineLanguagesBySite_UC4_SwitchBetweenLanguagesOnTheSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Define Languages by Site_UC4_Switch between languages on the site", new string[] {
                        "NeedImplementation"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
 testRunner.Given("Habitat website is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
 testRunner.When("User clicks Globe icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.And("User selects DANSK from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.Then("site language is switched to danish", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DefineLanguagesBySiteFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DefineLanguagesBySiteFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
