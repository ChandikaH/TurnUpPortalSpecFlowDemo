Feature: This test suite contains test scenarios for Time and Material Page

Scenario: A. Create a new Time and Material record with alpha code
	Given I log into Turnup portal
	When I navigate to Time and Material page
	And I create a new Time and Material record 'Code1' 'Mouse' '20'
	Then the record should be saved 'Code1'

Scenario Outline: B. Edit an existing Time and Material record
	Given I log into Turnup portal
	When I navigate to Time and Material page
	And I edit an existing Time and Material record <oldCode> <newCode>
	Then the record should be updated <newCode>

Examples:
	| oldCode | newCode |
	| 'Code1' | 'Code2' |
	| 'Code2' | 'Code3' |

Scenario: C. Delete an existing Time and Material record
	Given I log into Turnup portal
	When I navigate to Time and Material page
	And I delete an existing Time and Material record 'Code3'
	Then the record should be deleted 'Code3'