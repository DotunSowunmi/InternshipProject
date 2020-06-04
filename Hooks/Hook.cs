using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BlueOceanIntershipProject.Hooks
{
    [Binding]
    public class Hook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Dispose();
        }
        
        public void Screenshot()
        {
            
            
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("C:\\Users\\dotun\\source\repos\\BlueOceanIntershipProject\\TestData\\Test.jpg");

        }
    }
}
