# Create Azure Service principal

**Prerequisites:**

You need Owner permissions to an Azure Resource Group. 

You need to have permissions to create 'App registrations' in your AAD (Azure Active Directory Tenant). This is allowed by default, but might have been restricted in your AAD tenant. See [Delegate app registration permissions in Azure Active Directory](https://docs.microsoft.com/en-us/azure/active-directory/roles/delegate-app-roles) for further details.

**Open portal.azure.com.**

Sign in using your credentials. 

Ensure that you are in the right directory. 

![01-SelectDirecotry](Images/01-SelectDirecotry.png)

From the search resources bar search for 'AAD' and select Azure Active Directory. 

![02-SearchAad](Images/02-SearchAad.png)

Go to 'App registrations' and select 'New registration'

![03-NewRegistration](Images/03-NewRegistration.png)

<br/>

Fill in the form according to the environment to be configured.

|Name|Sample value|
|-|-|
|Name|Provide a meaningfull name here|
|Supported account types|Accounts in this organizational directory only|
|Redirect URI|Not necessary for service connection|

<br/>

![04-ServicePrincipalRegistrationForm](Images/04-ServicePrincipalRegistrationForm.png)

Open your newly created App registration from the App registrations page. 

Copy the 'Application (client) ID', you will need this later. 

Todo: Complete this guide

Go to Certificates & secrets and click 'New client secret' to create a secret. Copy the secret, you will need this later. 

Now you have created the App registration to be used for the service connection. 

[Back to Readme](../Readme.md)
