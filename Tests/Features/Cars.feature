Feature: Cars
Simple test to ensure commands and queries are working

Link to a feature: [Startup]($projectname$/Features/Startup.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

Scenario: Retrieve data from an endpoint
	Given i have 2 cars in the garage
	When i want to list the cars i have
	Then the result should be 2