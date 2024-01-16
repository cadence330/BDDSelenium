Feature: Examples DataDriven Testing

Login with credentials and go to product page.


Scenario Outline: Data Driven Testing
	Given Launch browser and go to URL
	When Enter <username> and <password>
	When User can click login button and go to product page
	Then Verify user is on products page
	Examples:
	| username           | password     |
	| rahulshettyacademy | learning     |
	| testUsername       | testPassword |
	| 1234Username       | 1234Password |
