using BlueOceanIntershipProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueOceanIntershipProject.PageObjects
{
    
    class RegistrationPage
    {
        IWebDriver driver;
        IWebElement clickOnCreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement enterFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        IWebElement enterLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement clickOnCountrycode => driver.FindElement(By.XPath("//div[@class='flag-container']"));
        IWebElement selectUnitedKingdom => driver.FindElement(By.XPath("(//span[text()='United Kingdom'])[1]"));
        IWebElement enterPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='password']"));
        IWebElement enterConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement clickOnCaptcha => driver.FindElement(By.XPath("//*[@id='recaptcha - anchor']/div[1]"));
        IWebElement clickOnRegisterButton => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        IWebElement enterInvalidPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));

        public void EnterInvalidPaswword()
        {
            enterInvalidPassword.SendKeys("yinka1987");
        }

        public void ClickOnRegisterButton()
        {

            clickOnRegisterButton.Click();
        }
        public void ClickOnCaptcha()
        {
            clickOnCaptcha.Click();
            Thread.Sleep(5000);
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
            enterEmailAddress.SendKeys("longman4real@hotmail.com");
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


        public RegistrationPage()
        {
            driver = Hook.driver;
        }
        


    }
}
