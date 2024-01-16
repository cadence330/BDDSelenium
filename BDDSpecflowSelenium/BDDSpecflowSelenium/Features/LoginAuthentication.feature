Feature: User can enter credentials and begin shopping under their account information

Scenario: User can login with their credentials
	Given Launch browser and go to URL
	When Enter Username and Password login
	When User can click login button and go to product page
	Then Verify user is on products page

