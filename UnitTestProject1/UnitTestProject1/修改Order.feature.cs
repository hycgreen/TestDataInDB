﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UnitTestProject1
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("修改訂單")]
    public partial class 修改訂單Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "修改Order.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "修改訂單", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 16
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "OrderID",
                        "CustomerID",
                        "EmployeeID",
                        "OrderDate",
                        "RequiredDate",
                        "ShippedDate",
                        "ShipVia",
                        "Freight",
                        "ShipName",
                        "ShipAddress",
                        "ShipCity",
                        "ShipRegion",
                        "ShipPostalCode",
                        "ShipCountry"});
            table1.AddRow(new string[] {
                        "10248",
                        "VINET",
                        "5",
                        "1996-07-04 00:00:00.000",
                        "1996-08-01 00:00:00.000",
                        "1996-07-16 00:00:00.000",
                        "3",
                        "32.38",
                        "Vins et alcools Chevalier",
                        "59 rue de l\'Abbaye",
                        "Reims",
                        "NULL",
                        "51100",
                        "France"});
#line 17
 testRunner.Given("資料庫Orders資料", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "OrderID",
                        "ProductID",
                        "UnitPrice",
                        "Quantity",
                        "Discount"});
            table2.AddRow(new string[] {
                        "10248",
                        "11",
                        "14.00",
                        "12",
                        "0"});
            table2.AddRow(new string[] {
                        "10248",
                        "72",
                        "34.80",
                        "5",
                        "0"});
            table2.AddRow(new string[] {
                        "10248",
                        "42",
                        "9.80",
                        "10",
                        "0"});
#line 20
 testRunner.And("資料庫Order Details資料", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("我在訂單作業修改訂單資料(整張訂單修改)")]
        public virtual void 我在訂單作業修改訂單資料整張訂單修改()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("我在訂單作業修改訂單資料(整張訂單修改)", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 16
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "OrderID",
                        "CustomerID",
                        "EmployeeID",
                        "OrderDate",
                        "RequiredDate",
                        "ShippedDate",
                        "ShipVia",
                        "Freight",
                        "ShipName",
                        "ShipAddress",
                        "ShipCity",
                        "ShipRegion",
                        "ShipPostalCode",
                        "ShipCountry"});
            table3.AddRow(new string[] {
                        "10248",
                        "VINET",
                        "5",
                        "1996-07-04 00:00:00.000",
                        "1996-08-01 00:00:00.000",
                        "1996-07-16 00:00:00.000",
                        "3",
                        "32.38",
                        "Vins et alcools Chevalier",
                        "59 rue de l\'Abbaye",
                        "Reims",
                        "NULL",
                        "51100",
                        "France"});
#line 28
 testRunner.Given("ViewModel-Orders參數", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "OrderID",
                        "ProductID",
                        "UnitPrice",
                        "Quantity",
                        "Discount"});
            table4.AddRow(new string[] {
                        "10248",
                        "11",
                        "14.00",
                        "15",
                        "0"});
            table4.AddRow(new string[] {
                        "10248",
                        "72",
                        "34.80",
                        "15",
                        "0"});
            table4.AddRow(new string[] {
                        "10248",
                        "42",
                        "9.80",
                        "15",
                        "0"});
#line 31
 testRunner.And("ViewModel-Order Details參數", ((string)(null)), table4, "And ");
#line 36
 testRunner.When("我調用Update", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "OrderID",
                        "CustomerID",
                        "EmployeeID",
                        "OrderDate",
                        "RequiredDate",
                        "ProductID",
                        "UnitPrice",
                        "Quantity",
                        "Discount"});
            table5.AddRow(new string[] {
                        "10248",
                        "VINET",
                        "5",
                        "1996-07-04 00:00:00.000",
                        "1996-08-01 00:00:00.000",
                        "11",
                        "14.00",
                        "15",
                        "0"});
            table5.AddRow(new string[] {
                        "10248",
                        "VINET",
                        "5",
                        "1996-07-04 00:00:00.000",
                        "1996-08-01 00:00:00.000",
                        "42",
                        "9.80",
                        "15",
                        "0"});
            table5.AddRow(new string[] {
                        "10248",
                        "VINET",
                        "5",
                        "1996-07-04 00:00:00.000",
                        "1996-08-01 00:00:00.000",
                        "72",
                        "34.80",
                        "15",
                        "0"});
#line 37
 testRunner.Then("我會得到底下訂單資料", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
