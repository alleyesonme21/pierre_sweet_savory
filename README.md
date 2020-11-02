# Pierre's Sweet and Savory Treats

Created: 10/23/2020
 By Johnny Duverseau

# Description

This backend application is for Pierre's Sweet and Savory Bakery Treats. The application has user authentication, allows users to log in and log out, allows logged in users to crete, update, and delete information, and allows all users the ability to read the website. 

## Specifications

1. When a user visits the splash page, he or she will see a list of all the treats and all of the available flavors and the combinations of treats and flavors. 

2. When a user loads the web application, he or she will see a splash page where they can log in or log out.

3. When a user logs in, he or she can create, update or delete information. 

4. All users have read functionality, but only users that are looged in can create, update or deleter information. 


## Setup/Installation Requirements
_To set up and install, follow the instructions to clone the repository._ 

### To clone: 
- Visit GitHub and clone the repository 
- Open your terminal 
- Type “git clone” in the terminal, paste the GitHub URL, and press enter
- Type “code .” and the folder will open in your VScode
- Type “dotnet restore” and press enter 
- Type” dotnet  build” and press enter
- Type “dotnet run” in GitBash and your program will run 
 ## Database Setup
To set up the database, follow the instructions below. 

### To set up: 

_Create an appsettings.json file and add the code in the image below; don’t forget to change your password_

```
 {
 "ConnectionStrings": 
  {
     "DefaultConnection": "Server=localhost;Port=3306;database=SweetAndSavory;uid=root;pwd=password;"
  }
 }
 ```

- Open your terminal and type “dotnet restore”
- dotnet build 
- dotnet ef migrations add Initial
- dotnet ef database update
-dotnet ef migrations add addIdentity
- dotnet ef database update 
- Then, type “dotnet run” 

## Support and contact details
- Discord: duverseaujohnny21 #2298
- Email: duverseaujohnny21@gmail.com
## Technologies Used
- Visual Studio Code
- C#
- .Net
_ Mvc
- Asp.NetCore
## License
Copyright (c) 2020 Johnny Duverseau

This software is licensed under the MIT license.