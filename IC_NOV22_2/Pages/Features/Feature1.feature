Feature: TMFeature

As a Trunup portal user
I would like to create edit time and material records
So that I can manage employees time and materials successfully short summary of the feature


Scenario: Create time and material record with valid details
	Given I logged into the TurnUp portal successsfully
	When  I navigate to the Time and Material page 
	And   I create to Tiime and Material Page
	Then  The record should be created successfully
	
Scenario Outline: Edit created material record with valid details
	Given I logged into the TurnUp portal successsfully
	When I navigate to the Time and Material page
	And I update '<Description>' in last created record
	Then The record should have updated '<Description>' successfully

Examples: 
| Description   | 
| Time          | 
| Material      | 
| Record edited | 