Web Api Versioning using Url Path

Why we need versioning in Api?
Once a Web API service is made public, different client applications start using your Web API services.As the business grows and requirements change, we may have to change the services as well, but the changes to the services should be done in way that does not break any existing client applications.
This is when Web API versioning helps. 

There are many approaches about how should one implement the api versioning. My favorite is putting the versioning in the Url. It has following major benefits over other approaches is that
"you can change the entire relationship of entities in future versions and still continue to support the old clients". 

To Implement Api Versioning you need to add follwing nuget:-
Install-Package Microsoft.AspNet.WebApi.Versioning

