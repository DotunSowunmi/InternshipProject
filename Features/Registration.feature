Feature: Registration
	In order to use giftrete website
	I should be able to register

@mytag
Scenario: Registration
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
	#And I click on Captcha
	And I click on register button
	#Then I should be registered
