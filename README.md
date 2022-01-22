# Local Business API
An API that allows users to use data pertaining local businesses.

#### By Jeff Terrell

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)

## Technologies Used
* C#
* .Net5
* ASP.Net Core MVC
* Entity Framework Core
* MySql and MySql Workbench
* LINQ

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)

## Description

A web API that allows a user to request data pertaining to local restaurants and shops. Users can specify the desired information through the use of filters and sorts. Users are also allowed to POST new businesses and UPDATE or DELETE existing businesses.



![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)


## Setup/Installation Requirements
* If needed, download and install .NET 5 here: https://dotnet.microsoft.com/en-us/download/dotnet/5.0
* From a terminal, navigate to a directory of your choosing and use the "Git clone" command to copy the repository from this address (https://github.com/JeffTerrell/LocalBusiness.Solution).
Navigate to the sub directory "LocalBusiness" of the cloned main directory on your local machine.
* From the same directory "LocalBusiness", enter the following commands individually:
  - _dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0_ 
  - _dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2_
  - _dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0_
  - _dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0_
  - _dotnet tool install --global dotnet-ef --version 3.0.0_	
* From the same directory "LocalBusiness", create a new file called .appsettings.json.		
* Open this file with a code editor and add the following:

  ```
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[data_base_name];uid=root;pwd=[password];"
    }
  }
  ```
* Delete the [] surrounding data_base_name and pwd and include correct database name and password.

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)


## Database Setup/Installation Requirements 
After completing the Setup/Installation requirements follow these steps to create the database schema in MySQL Workbench:
* From a terminal in the sub directory "LocalBusiness", enter the following command to build the database:
  - _dotnet ef database update
* Open MySQL Workbench and start/create a local instance with localhost:3306.  
* To view the imported database, click the "Schemas" tab from the Navigator Menu, right click in the pane and select "Refresh All".


![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)


## Run the Application 
  * From a terminal, navigate to the sub directory "LocalBusiness".
  * Enter the following command, "dotnet restore" to create necessary folders and files.
  * Next enter the following command, "dotnet run". This will launch the application in your terminal. Enter "Ctrl c" to exit the application at any point.
  * To access the application, load a web browser and in the URL bar insert the specific URL(s) listed in your terminal (ex: Now listening on: http://localhost:5000).
  * Note: to have create, update, and delete rights, you must register an account and login with these credentials.

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)

## Known Bugs
* None

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/solar.png)


## License

[MIT](https://opensource.org/licenses/MIT)

Please contact Jeff Terrell via email with any issues, questions, or ideas.
<br>
[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/JeffTerrell)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/jeffaterrell)
<br>
<br>
Copyright (c) 2021 Jeff Terrell