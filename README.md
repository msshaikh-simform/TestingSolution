# Unit Testing Prototype
This prototype written in c# language includes example of Unit testing, XUnit and NUnit.

## Project Abstract
This project have the ability to demonstrate the flow of how the different types of unit testing can be configured and consumed as per our requirements.

## Project Covered Topics
 - Unit testing using Microsoft.VisualStudio.TestTools.UnitTesting
 - Unit testing using NUnit.Framework
 - Unit testing using XUnit

## Project Main Service -- testable unit
 - BankAccount: It has 3 operations such as Credit, Debit and balance inquiry.
 

## Getting started
For cloning the project into local machine you need to perform following steps:
 - Open the solution file (.sln)
 - Open up the View -> Text Explorer (CTRL + E, T)
 - There'll be 3 different types of project for unit testing pickup any one which do you want and run the test case.
 
 Note: Make sure that application should be running in order to start you testing :laughing:! That's a lame joke i know.

### Project-Setup Prerequisites  
 - Visual Studio 2019
 - .NET Core 3.1 (https://dotnet.microsoft.com/en-us/download/dotnet/3.1)

### Technology Prerequisites  
 - C#


### Run Project in Development enviorment
 - Clone the repository in your local enviorment.
 - Rebuild the project so all the dependant packages will be installed.
 - If you are using visual studio then you can directly run the project.
 

### Dependancies

#### Nuget Packages
Below are the dependant packages consumed
 - coverlet.collector
 - Microsoft.NET.Test.Sdk
 - MSTest.TestAdapter
 - MSTest.TestFramework
 - NUnit
 - NUnit3TestAdapter
 - xunit
 - xunit.runner.visualstudio


### Database
N/A


### Project Architecture
Below are different projects available in solution:
 - TestingSolution: It contains the basic bank related services which will be testable unit
 - TestingSolution.UnitTest: It contains the logic for perform unit testing with Microsoft.VisualStudio.TestTools.UnitTesting's Unit Testing
 - TestingSolution.nUnit: It contains the logic for perform unit testing with NUnit
 - TestingSolution.xUnit: It contains the logic for perform unit testing with XUnit


### Deployment
N/A


### Deployement prerequistes
N/A


### Deployement Steps
N/A


## License
N/A


## Future Scope to cover
 N/A

 #blazor #blazordemo #blazorserverapp #blazorexample #blazorauth #blazorauthentication #blazorcustomauthentication
