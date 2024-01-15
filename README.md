# Project
This is a simple net aplication project which implements funcionality for a gym website. All user data is validated and stored in a database connected to the entire application.
## Main Technologies:
*  ASP.NET framework
*  Entity Framework
*  SQL Server
*  Razor Pages
*  Authentication
*  Authorization

## How to deploy our service:
*  First you must click Code option in the top right corner above list of the files. Then you must copy the URL to this repository
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/63004507-0a57-44b1-8161-7127b360a9f8)
*  In the next step you must open your programming enviromental with C# and ASP.NET 8.0 support, we suggest to use VisualStudio or JetBrains Rider
    * In Rider:
        * First select Git options and click Clone
      ![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/beb187d8-82ea-417c-9246-f982920ffcd2)
        * Paste link copied before and select Path on you computer where you want deploy project, click "Trust Project" and wait
      ![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/21fd00a7-b582-421d-8612-a7abb56f358a)
        * Now you must configruate _appsetting.json_. You must change data in underlined instruction, Change blank place to name of ypur SQL Server. Make shure that you dont have any database named _Project_, if you have you must change parameter after _database=_ in underlined code, you must chose new database name.
      ![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/30b781ce-1d76-4ddb-a961-14e92d41bce0)
         * In the next step you must add migration to your project to do this thing in terminal:
               * Make sure that you are in Project folder, if not write: _cd ./your_project_dirrectory_, then make sure that you have installed Entity Framework Core CLI tool                    named dotnet ef, if not: _dotnet tool install --global dotnet-ef_ write it to Terminal
               * Then copy this 4 instruction into Console:

                  dotnet ef migrations add ApplicationDBContextConnection -c ApplicationDBContext 
                  dotnet ef migrations add ApplicationDBContextConnection -c AnotherDBContext
                  dotnet ef database update -c ApplicationDBContext
                  dotnet ef database update -c AnotherDBContext
         * Now launch your Code and enjoy with our service (If you want use VisualStudio, the schema is similar, choose Clone Repository and follow instructions like in Rider)

## About project:
### To check funcionality of the project please use one of the accounts below:
         Basic user:
            Login: Kevin
            Password: Kevin123!
         Admin user:
            Login: JohnAdmin
            Password: John123!
* On the first page, there is a login panel that allows us to log in to a privileged admin account or a regular user account. If we don't have an account, we can click on the link that takes us to the registration page. 
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/cf5fec1e-b757-48e1-b65a-f762ce062f80)

* On the registration page, we provide necessary information to create an account, including a unique username and a password that must meet security requirements. In case any of the previously mentioned conditions are not met or if any other fields are left incomplete, an appropriate message will be displayed, informing about the missing or incorrect information.
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/e0aeabfd-905c-41e6-8eeb-fa198a3b5604)

* After logging in, we are redirected to the main page that welcomes us. On this page, we can view information about our account, check reviews about clubs, or log out. If we are on the administrator's account, we also have the option to go to the page displaying users.
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/87d484b6-c997-4395-b70d-5835b2eb2303)

* In the user panel, we can view information about our account, make changes to it, including changing our password, and delete the entire account.
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/2611a9a7-e5f2-4762-9d53-9d348cc42023)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/eb75cdcf-c2ed-47e3-88a1-c6c11681e3b3)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/c428f14b-4ab5-406a-8800-b24350cb9816)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/63354cfd-dc0b-49c6-9451-10a74c913d80)

* In the club section, we can view clubs and see reviews assigned to specific clubs. We can also add reviews, which involves selecting a rating from 1 to 5 and providing a textual opinion. The administrator does not have access to adding reviews.
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/428845bb-3fd2-4a71-966c-fcffadbc24e1)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/9b8dc4c6-9e18-4712-8654-17e96977afee)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/38c932b8-f18c-4045-b0d8-9efd4da2bcc0)

* In the management panel, available only to the administrator, we can browse all registered users, excluding the administrator account. From this level, the administrator can edit user data or delete users, but cannot edit user passwords. The administrator can also create new users, following the same process as registration, but the administrator does not set a password for the new account; instead, it is set to a default value.
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/e944555b-d126-4b81-814b-9296f7fe74e3)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/67f6675e-0f44-4909-8e40-6382f229c268)
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/120064585/3a72b474-f6a1-4803-b077-e4b30d5bda25)
