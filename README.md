# Local Business API
<a href="https://github.com/JeffTerrell">
  <img src="https://avatars.githubusercontent.com/u/30218292?v=4" width="100px", height="100px">
</a>
<br>

#### By Jeff Terrell

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## Table of Contents
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#🖊️-description">Description</a>
    * <a href="#🐞-known-bugs">Known Bugs</a>
    * <a href="#🧰-built-with">Built With</a>
* <a href="#📘-getting-started">Getting Started</a>
    * <a href="#✔️-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#🤝-contributors">Auxiliary</a>
    * <a href="#🤝-contributors">Contributors</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    * <a href="#🌟-acknowledgements">Acknowledgements</a>

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## 🌐 About the Project

### 🖊️Description
A web API that allows a user to request data pertaining to local restaurants and shops. Users can specify the desired information through the use of filters and sorts. Users are also allowed to POST new businesses and UPDATE or DELETE existing businesses.

### 🧰Technologies Used
* C#
* .Net5
* ASP.Net Core MVC
* Entity Framework Core
* MySql and MySql Workbench
* LINQ

### 🐞Known Bugs
* None 

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

## 📘 Instructions


### ✔️Prequisites

#### Install .NET Core
* For macOS users (Mojave or newer):
  * [Click here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-2.2.106-macos-x64-installer)
* For Windows users (Windows10 x64 or newer):
  * _[Click here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-2.2.203-windows-x64-installer)_

#### Install dotnet script
* From a terminal enter the following command: dotnet tool install -g dotnet-script

#### Install MySQL Workbench
* [Click here](https://dev.mysql.com/downloads/workbench/) to download a compatible version

#### Install Postman (optional)
* [Click here](https://www.postman.com/downloads/) to download

#### Install a Code Editor (optional)
* To view or edit code, a code editor is needed. Any editor will work, below are two free recommendations:
  * _[Click here](https://code.visualstudio.com/Download) to download Visual Studio Code (heavy, feature rich)_
  * _[Click here](https://www.geany.org/download/releases/) to download Geany (lightweight, fast)_

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/cloudy.png)

### Setup/Installation Requirements
* From a terminal, navigate to a directory of your choosing and use the "Git clone" command to copy the repository from this address (https://github.com/JeffTerrell/LocalBusiness.Solution).
* Navigate to the sub directory "LocalBusiness" of the cloned main directory on your local machine.
* From the same directory "LocalBusiness", enter the following command:
  - _dotnet restore_ 	
* From the same directory "LocalBusiness", create a new file called .appsettings.json.		
* Open this file with a code editor and add the following:

  ```
  {
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[data_base_name];uid=root;pwd=[password];"
    }
  }
  ```
* Delete the [ ] surrounding data_base_name and pwd and include correct database name and password.

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/cloudy.png)

### Database Setup/Installation Requirements 
After completing the Setup/Installation requirements follow these steps to create the database schema in MySQL Workbench:
* From a terminal in the sub directory "LocalBusiness", enter the following command to build the database:
  - _dotnet ef database update_
* Open MySQL Workbench and start/create a local instance with localhost:3306.  
* To view the imported database, click the "Schemas" tab from the Navigator Menu, right click in the pane and select "Refresh All".

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/cloudy.png)

### Run the API 
  * From a terminal, navigate to the sub directory "LocalBusiness".
  * Enter the following command, "dotnet restore" to create necessary folders and files.
  * Next enter the following command, "dotnet run". This will launch the application in your terminal. Enter "Ctrl c" to exit the application at any point.
  * To access the API, load Postman or load a web browser and in the URL bar insert the specific URL(s) listed in your terminal (ex: Now listening on: http://localhost:5000/index.html).

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)

# API Documentation

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/aqua.png)


## License

[MIT](https://opensource.org/licenses/MIT)

Please contact Jeff Terrell via email with any issues, questions, or ideas.
<br>
[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/JeffTerrell)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/jeffaterrell)
<br>
<br>
Copyright (c) 2021 Jeff Terrell