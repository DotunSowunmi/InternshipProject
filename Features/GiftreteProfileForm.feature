Feature: GiftreteProfileForm
	In order to manage my Giftrete account detail
	I want to be able to edit my personal information
@mytag
Scenario: View Giftrete Profile Form
	Given I navigate to Giftrete website
    When I click on sign in 
	And I enter valid email address
	And I enter valid password
	And I click on sign in button
	And I click on account detail tab
    And  I click on the edit details
	And I click title drop down
	And I select title from dropdown box
	And I edit First Name
	And I edit Last Name
	And I edit date of birth
	And I edit email address
	And i click on Phone country code icon
	And I select new country code
	And I edit Phone number
	And I edit about text box
	And I click to select Yes or No for community activity emails
	And I click on submit button
	#Then my personal information should be edited successfully
	Then success notification box should be displayed
