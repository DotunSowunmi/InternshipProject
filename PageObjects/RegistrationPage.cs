using BlueOceanIntershipProject.Hooks;
using BlueOceanIntershipProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueOceanIntershipProject.PageObjects
{
    
    class RegistrationPage
    {
        IWebDriver driver;
        Waits wait = new Waits();
        public RegistrationPage()
        {
            driver = Hook.driver;
        }

        IWebElement clickOnCreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement enterFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        IWebElement enterLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement clickOnCountrycode => driver.FindElement(By.XPath("//div[@class='flag-container']"));
        IWebElement selectUnitedKingdom => driver.FindElement(By.XPath("(//span[text()='United Kingdom'])[1]"));
        IWebElement enterPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='password']"));
        IWebElement enterConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement clickOnRegisterButton => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        IWebElement enterInvalidPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement privacyPolicy => driver.FindElement(By.XPath("/html/body/footer/div/div/article[1]/li[2]/a"));
        IWebElement privacyHomePageElement => driver.FindElement(By.XPath("/html/body/section[2]/div[1]/h1"));
        IWebElement confirmedPasswordErrorMessage => driver.FindElement(By.XPath("//*[@id='dng_msg']/p"));
        IWebElement RegistrationSuccessMessage => driver.FindElement(By.XPath("//*[@id='suc_msg']"));

        public string GetTextForRegistrationSuccessMessage()
        {
            Thread.Sleep(500);
            return RegistrationSuccessMessage.Text;
        }


        public string GetTextForConfirmedPasswordErrorMessage()
        {
            return confirmedPasswordErrorMessage.Text;
        }


        public bool IsPrivacyHomePageElementDisplayed()
        {
            Thread.Sleep(5000);
            return privacyHomePageElement.Displayed;
        }
        public void PrivacyPolicy()
        {
            privacyPolicy.Click();
        }

        public void EnterInvalidPaswword()
        {
            enterInvalidPassword.SendKeys("yinka1987");
        }

        public void ClickOnRegisterButton()
        {

            clickOnRegisterButton.Click();
        }
        
        public void EnterconfirmPassword()
        {
            enterConfirmPassword.SendKeys("P455w0rd");
        }
        public void EnterPassword()
        {
            enterPassword.SendKeys("P455w0rd");
        }
        public void EnterPhoneNumber()
        {
            enterPhoneNumber.SendKeys("07951541117");
        }

        public void ClickOnCountryCode()
        {
            clickOnCountrycode.Click();
        }

        public void SelectUnitedKingdom()
        {
            selectUnitedKingdom.Click();
        }
        public void EnterEmailAddress()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            enterEmailAddress.SendKeys("longman4real" + randomInt + "@hotmail.com");
        }
        public void EnterLastName()
        {
            enterLastName.SendKeys("Sowunmi");
        }
        public void EnterFirstName()
        {
            enterFirstName.SendKeys("Dotun");
        }

        public void ClickOnCreateAccount()
        {
            clickOnCreateAccount.Click();
        }

        public void NavigateToGiftreteWebsite()
        {
            driver.Navigate().GoToUrl("http://www.qa.giftrete.com/");
        }


       


    }
}
