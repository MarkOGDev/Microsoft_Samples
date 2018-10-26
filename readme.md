# Microsoft Samples 

*Created by MarkOGDev*
 
 
## Azure Functions


* [Azure.Functions.HttpTrigger.Demo](/Azure.Functions/HttpTrigger.Demo/readme.md)
* [Azure.Functions.TableBindings.Demo](/Azure.Functions/TableBindings.Demo/readme.md)


 

## Tools 

* [Postman App](https://www.getpostman.com/) - Manually Test / View you function responses.


## Automation

* [Azure DevOps Documentation](https://docs.microsoft.com/en-us/azure/devops/)


[![Build Status](https://dev.azure.com/markogdev/Microsoft.Samples/_apis/build/status/Microsoft.Samples)](https://dev.azure.com/markogdev/Microsoft.Samples/_build/latest?definitionId=2)





https://docs.microsoft.com/en-us/azure/devops/pipelines/build/repository?view=vsts
we can deploy an individual project in this solution by createing a build in Azure portal, NOT uisng Yaml.
YAML builds don't support tagging sources.

Tagging sources let you point to a project to create artifact.

then publish the artifact tothe function app.

