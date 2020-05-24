Feature: Registration
	In order to use giftrete website
	I should be able to register

@mytag
Scenario: Valid Registration
	Given I navigate to giftrete
	When I click on create account
	And I enter the First Name
	And I enter the Last Name
	And I enter email address
	And I click country code
	And I select United Kingdom 
	And I enter phone number
	And I enter password
	And I enter confirm password	
	And I click on register button
    Then "Thank you for signing up! You may now login" message should be displayed


	Scenario: Invalid Registration
	   Given I navigate to giftrete
	    When I click on create account
	     And I enter the First Name
	     And I enter the Last Name
	     And I enter email address
	     And I click country code
	     And I select United Kingdom 
	     And I enter phone number
	     And I enter password
	     And I enter Invalid confirm password
	     And I click on register button
	     Then the mesage "The Confirm Password field does not match the Password field." should be displayed

		 Scenario: Registration Privacy Policy
	       Given I navigate to giftrete
		   When I clicked on the privacy policy
		   Then Privacy policy page should display

		 
