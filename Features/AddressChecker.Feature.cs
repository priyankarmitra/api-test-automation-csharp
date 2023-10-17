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
namespace VerivoxTestApiProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Find the cities and streets for a given postcode")]
    public partial class FindTheCitiesAndStreetsForAGivenPostcodeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AddressChecker.Feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Features", "Find the cities and streets for a given postcode", "  AS a Verivox developer\r\n  I WANT TO find city and street names for a particular" +
                    " German postcode\r\n  SO THAT I can help customers select their address details mo" +
                    "re easily", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Find the cities for a given postcode")]
        [NUnit.Framework.CategoryAttribute("automated")]
        [NUnit.Framework.CategoryAttribute("scenario1")]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "10409", "Berlin", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "07629", "Hermsdorf, Reichenbach, Schleifreisen, St. Gangloff", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "77716", "Fischerbach, Haslach im Kinzigtal, Hofstetten", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "99974", "Mühlhausen, Unstruttal", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "22333", "", "404", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/INVALID/cities", "10585", "", "404", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "117863", "", "404", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "0", "", "404", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "NE3$12", "", "404", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "@#@##@", "", "404", null)]
        public virtual void FindTheCitiesForAGivenPostcode(string endpoint, string postcode, string cityList, string httpStatus, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "automated",
                    "scenario1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Endpoint", endpoint);
            argumentsOfScenario.Add("Postcode", postcode);
            argumentsOfScenario.Add("CityList", cityList);
            argumentsOfScenario.Add("HttpStatus", httpStatus);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find the cities for a given postcode", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
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
    testRunner.Given(string.Format("the address checking service endpoint: \"{0}\"", endpoint), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
    testRunner.When(string.Format("I request the cities for postcode \"{0}\"", postcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
    testRunner.Then(string.Format("I should receive a response with \"{0}\"", cityList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
    testRunner.And("No JSON data is returned for HTTP error status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.And(string.Format("The response {0} status code should match", httpStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find the streets for a given postcode and city")]
        [NUnit.Framework.CategoryAttribute("automated")]
        [NUnit.Framework.CategoryAttribute("scenario2")]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "10409", "Berlin", "29", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "77716", "Fischerbach", "34", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "77716", "Haslach", "121", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "77716", "Hofstetten", "40", "200", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "10585", "Stuttgart", "0", "404", null)]
        [NUnit.Framework.TestCaseAttribute("/geo/latestv2/cities", "Berlin", "10409", "0", "404", null)]
        public virtual void FindTheStreetsForAGivenPostcodeAndCity(string endpoint, string postcode, string cityList, string noOfStreets, string httpStatus, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "automated",
                    "scenario2"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Endpoint", endpoint);
            argumentsOfScenario.Add("Postcode", postcode);
            argumentsOfScenario.Add("CityList", cityList);
            argumentsOfScenario.Add("NoOfStreets", noOfStreets);
            argumentsOfScenario.Add("HttpStatus", httpStatus);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find the streets for a given postcode and city", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 31
    testRunner.Given(string.Format("the address checking service endpoint: \"{0}\"", endpoint), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
    testRunner.When(string.Format("I request the streets for \"{0}\" with postcode \"{1}\"", cityList, postcode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
    testRunner.Then(string.Format("I should receive a response with a list of streets for \"{0}\"", cityList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
    testRunner.And(string.Format("The response should contain {0} streets", noOfStreets), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
    testRunner.And("The street names with special characters and dashes displayed correctly", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
    testRunner.And(string.Format("The response {0} status code should match", httpStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
