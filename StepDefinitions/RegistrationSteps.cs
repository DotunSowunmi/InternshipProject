using BlueOceanIntershipProject.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BlueOceanIntershipProject.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }


        [When(@"I clicked on the privacy policy")]
        public void WhenIClickedOnThePrivacyPolicy()
        {
            registrationPage.PrivacyPolicy();
        }

        [Then(@"Privacy policy page should display")]
        public void ThenPrivacyPolicyPageShouldDisplay()
        {
            Assert.True(registrationPage.IsPrivacyHomePageElementDisplayed());
        }

        [When(@"I enter Invalid confirm password")]
        public void WhenIEnterInvalidConfirmPassword()
        {
            registrationPage.EnterInvalidPaswword();
        }

        [Then(@"the mesage ""(.*)"" should be displayed")]
        public void ThenTheMesageShouldBeDisplayed(string errorMessage)
        {
             Assert.AreEqual(errorMessage, registrationPage.GetTextForConfirmedPasswordErrorMessage());
        }


        [Given(@"I navigate to giftrete")]
        public void GivenINavigateToGiftrete()
        {
            registrationPage.NavigateToGiftreteWebsite();
        }
        
        [When(@"I click on create account")]
        public void WhenIClickOnCreateAccount()
        {
            registrationPage.ClickOnCreateAccount(); 
        }
        
        [When(@"I enter the First Name")]
        public void WhenIEnterTheFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter the Last Name")]
        public void WhenIEnterTheLastName()
        {
            registrationPage.EnterLastName();
        }
        
        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }

        [When(@"I click country code")]
        public void WhenIClickCountryCode()
        {
            registrationPage.ClickOnCountryCode();
        }

        [When(@"I select United Kingdom")]
        public void WhenISelectUnitedKingdom()
        {
            registrationPage.SelectUnitedKingdom();
        }




        [When(@"I enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I enter confirm password")]
        public void WhenIEnterConfirmPassword()
        {
            registrationPage.EnterconfirmPassword();
        }

        
        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            registrationPage.ClickOnRegisterButton();
        }

        [Then(@"""(.*)"" message should be displayed")]
        public void ThenMessageShouldBeDisplayed(string registrationSuccessMessage)
        {
            Assert.AreEqual(registrationSuccessMessage, registrationPage.GetTextForRegistrationSuccessMessage());
        }

    }
}
