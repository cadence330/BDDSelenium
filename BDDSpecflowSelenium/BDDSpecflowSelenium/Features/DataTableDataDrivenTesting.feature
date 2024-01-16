Feature: DataTable Data Driven Testing

Login with credentials and go to product page.


Scenario: DataTable Data Driven Testing
	Given Launch browser and go to URL
	When Enter email data in field
	| username            |
	| test@gmail.com      |
	| testagain@gmail.com |
