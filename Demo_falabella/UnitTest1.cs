using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;           
using OpenQA.Selenium.Firefox;   
using OpenQA.Selenium.Chrome;    
using OpenQA.Selenium.IE;

namespace SeleniumBingTests
{
  /// <summary>
  /// Summary description for MySeleniumTests
  /// </summary>
  [TestClass]
  public class MySeleniumTests
  {
    private TestContext testContextInstance;
    private IWebDriver driver;
    private string appURL;

    public MySeleniumTests()
    {
    }

    [TestMethod]
    [TestCategory("chrome")]
    public void DemoTest()
    {
      driver.Navigate().GoToUrl(appURL + "/");
      driver.FindElement(By.XPath("//*[contains(text(), 'Build GitHub projects using Azure Pipelines')]")).Click();
      }

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext
    {
      get
      {
        return testContextInstance;
      }
      set
      {
        testContextInstance = value;
      }
    }

    [TestInitialize()]
    public void SetupTest()
    {
      appURL = "http://localhost:8090";

      string browser = "Firefox";
      switch(browser)
      {
        case "Chrome":
          driver = new ChromeDriver();
          break;
        case "Firefox":
          driver = new FirefoxDriver();
          break;
        case "IE":
          driver = new InternetExplorerDriver();
          break;
        default:
          driver = new ChromeDriver();
          break;
      }

    }

    [TestCleanup()]
    public void MyTestCleanup()
    {
      driver.Quit();
    }
  }
}