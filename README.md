# Introduction 

This is an Azure function project with deployment, Azure DevOps pipeline (YML), environment management and much more - ready to get started in 10 minutes. (Well, maybe not the first time you try ;-), but it really is a quick start.)

It contains all the scaffolding needed to get started with an Azure function project with automated deployment using Azure DevOps. 

It has all been setup for easy configuration and manageability, yet with a powerful and scalable approach. 

What do you get by starting with this project?
- Ready to go Function app project and test project
- Dependency injection
- Configuration management (Local configuration, App settings deployment, KeyVault configuration and all deployment needed to connect the dots)
- Sample unit test with Mock, configuration and dependency injection configuration.
- Azure Infrastructure deployment (IaC - Infrastructure As Code) including Azure function, Azure KeyVault (for storage of secrets), Storage account, Application insights (Logging). 
- A simple and powerful Powershell based deployment structure that allows you to organize your deployment scripts in an awesome way. 

# DevOps Advantages

This project is setup for use in Azure DevOps, having a pipeline setup with build, test and deployment. It can easily be setup with other deployment platforms because of the simple scripted approach used. But the focus here is the advantages of use in Azure DevOps. 

I have done many Azure Integration Services deployments, always using Azure DevOps pipelines for CI / CD. I have seen so many projects using lots of hours setting up the build and deployment using Azure DevOps pipelines in advanced processes, making it unmanageable for everybody except the one person who is the master of the pipelines. It can all be managed so much simpler increasing transparancy and manageability. Some of the advantages of using the AzureDeploymentTemplate approach are:

- Get started easily
- All deployment scripts can be run locally. 
- Simple configuration management, yet powerfull security options. 
- Easily create new environments and manage environment parameters
- Modular and transparent Pipeline configuration using YAML. 

# Getting Started

Setting this up for your own environment requires the following:

- Create service principal in AAD (Azure Active Directory). See [CreateServicePrincipal.md](Documentation/CreateServicePrincipal.md)
- Create resource group in Azure
- Assign permissions to the service principal
- Setup Service connection in Azure DevOps
- Setup your environment file with parameters for your environment. 
- Modify Deploy_Dev stage in azure-pipelines.yml, pointing to your target json environment file and serviceConnection.

## Adding a new environment

Copy an existing environment.json file, like dev.json, to an appropriate name, i.e. test.json
Edit test.json and adjust parameters according to the new environment. 
