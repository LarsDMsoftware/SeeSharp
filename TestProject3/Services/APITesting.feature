Feature: Get Request

# The first example has two steps
Scenario: User makes a HTTP Get Request
Given: the user wants to make a GET Request.
When: the User a HTTP Get request to the url "https://petstore3.swagger.io/api/v3/pet/" with an ID attached at the end
Then: the User waits for a response from the server to get the data requested


Feature: Post Request

# The first example has two steps
Scenario: User makes a HTTP Post Request
Given: the user wants to make a POST Request.
When: the User a HTTP Post request to the url "https://petstore3.swagger.io/api/v3/pet/" with the correct data in the headers
Then: the User waits for a response from the server to verify wether the request failed or succeeded

Feature: Put Request

# The first example has two steps
Scenario: User makes a HTTP Put Request
Given: the user wants to make a Put Request.
When: the User a HTTP Put request to the url "https://petstore3.swagger.io/api/v3/pet/" with the correct data in the headers and an ID attached to the end.
Then: the User waits for a response from the server to verify wether the request failed or succeeded and if successfull, if it was an update or create.

Feature: Delete Request

# The first example has two steps
Scenario: User makes a HTTP Delete Request
Given: the user wants to make a Delete Request.
When: the User a HTTP Delete request to the url "https://petstore3.swagger.io/api/v3/pet/" with the correct data in the headers
Then: the Maker waits for a Breaker to join
