using BlueOceanIntershipProject.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueOceanIntershipProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
        }


        [Given(@"I navigate to Giftrete website")]
        public void GivenINavigateToGiftreteWebsite()
        {
            loginPage.NavigateToGiftreteWebsite();
        }

        [When(@"I click on sign in")]
        public void WhenIClickOnSignIn()
        {
            loginPage.ClickOnSignIn();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            loginPage.EnterEmailAddress();
        }

        [When(@"I enter my valid password")]
        public void WhenIEnterMyValidPassword()
        {
            loginPage.EnterValidPassword();
        }

        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            loginPage.ClickOnSigninButton();
        }


        [Then(@"the user homepage should be displayed")]
        public void ThenTheUserHomepageShouldBeDisplayed()
        {
            Thread.Sleep(5000);
            Assert.True(loginPage.IsUserHomePageDisplayed());
        }

        [When(@"I enter my Invalid password")]
        public void WhenIEnterMyInvalidPassword()
        {
            loginPage.EnterInvalidPassword();
        }

       

        [Then(@"the message ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string errorMessage)
        {
            Thread.Sleep(5000);
            Assert.AreEqual(errorMessage, loginPage.GetTextErrorMessageElement());
        }


    }
}
