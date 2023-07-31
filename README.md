# Identity in ASP.NET Core
[source](https://www.youtube.com/watch?v=sogS0DtejVA&ab_channel=FrankLiu)

--- ---

## Dependencies

- Entity Framework Core
- Entity Framework Tools
- Entity Framework SqlServer

--- ---

## User Identity Workflow 

- Sign-up/log-in page
- cookie base authentication/token base authentication
- security context is stored in either cookie or token
- user information is stored in database, credentials needs to be checked against stored data
- After credentials verification, **_security is generated_** which is serialized into either cookie or web token
- cookie/token is stored in both **_server and browser_**
- security context is serialized back and forth b/w browser and **_server_**


--- ---

## ASP.NET Core Basics

- 

--- ---