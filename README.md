# Project
This is a simple net aplication project which implements funcionality for a gym website. Our website is transparent and intuitive, making it easy for users to navigate. It incorporates essential features and add-ons to provide customers with the best possible experience. The site includes all the necessary functionalities and extras to ensure optimal user satisfaction. All user data is validated and stored in a database connected to the entire application.
## Main Technologies:
*  ASP.NET framework
*  Entity Framework
*  SQL Server
*  Razor Pages
*  Authentication
*  Authorization

## How to deploy our service:
*  First you must click Code option in the top right corner above list of the files. Then you must copy the URL to this Repo
![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/63004507-0a57-44b1-8161-7127b360a9f8)
*  In the next step you must open your programming enviromental with C# and ASP.NET 8.0 support, we suggest to use VisualStudio or JetBrains Rider
    * In Rider:
        * First select Git options and click Clone
      ![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/beb187d8-82ea-417c-9246-f982920ffcd2)
        * Paste link copied before and select Path on you computer where you want deploy project, click "Trust Project" and wait
      ![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/21fd00a7-b582-421d-8612-a7abb56f358a)
        * Now you must configruate _appsetting.json_. You must change data in underlined instruction, Change blank place to name of ypur SQL Server.
      ![image](https://github.com/maciejsachajdak/ASP.NET-Project/assets/119767371/30b781ce-1d76-4ddb-a961-14e92d41bce0)
         * In the next step you must add migration to your project to do this thing in terminal:
               * Make sure that you are in Project folder, if not write: _cd ./your_project_dirrectory_, than make sure that you have installed Entity Framework Core CLI tool                    named dotnet ef, if not: _dotnet tool install --global dotnet-ef_ write it to Terminal
               * Then copy this 4 instruction into Console:

                  dotnet ef migrations add ApplicationDBContextConnection -c ApplicationDBContext 
                  dotnet ef migrations add ApplicationDBContextConnection -c AnotherDBContext
                  dotnet ef database update -c ApplicationDBContext
                  dotnet ef database update -c AnotherDBContext

## About project:
* On the homepage, there is a login panel that allows us to log in to a privileged admin account or a regular user account. If we don't have an account, we can click on the link that takes us to the registration page.

* On the registration page, we provide necessary information to create an account, including a unique username and a password that must meet security requirements. In case any of the previously mentioned conditions are not met or if any other fields are left incomplete, an appropriate message will be displayed, informing about the missing or incorrect information.

* After logging in, we are redirected to the main page that welcomes us. On this page, we can view information about our account, check reviews about clubs, or log out. If we are on the administrator's account, we also have the option to go to the page displaying users.

* In the user panel, we can view information about our account, make changes to it, including changing our password, and delete the entire account.

* In the section dedicated to reviews, we can view clubs and see reviews assigned to specific clubs. We can also add reviews, which involves selecting a rating from 1 to 5 and providing a textual opinion. The administrator does not have access to adding reviews.

* In the management panel, available only to the administrator, we can browse all registered users, excluding the administrator account. From this level, the administrator can edit user data or delete users, but cannot edit user passwords. The administrator can also create new users, following the same process as registration, but the administrator does not set a password for the new account; instead, it is set to a default value.

## To check funcionality of the project please use one of the accounts below:
* Basic user:
   * Login: _Kevin_
   * Password: _Kevin123!_
* Admin user:
   * Login: _JohnAdmin_
   * Password: _John123!_
