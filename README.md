# ITTicketingSystem
IT Ticketing System


## Summary

An IT Ticketing System is a software tool or platform used by IT (Information Technology) departments to manage and track various types of user requests or issues. The system serves as a centralized hub for handling and resolving incidents, service requests, and problems reported by users or detected by system monitoring.

## Technology
This project uses Windows Forms App (.NET Framework). It is recommended to use Visual Studio for development and install the suggested extensions.

## Preparation

###### 1. Install the IDE and clone this repository
 - Install [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) 
 - Open [ITTicketingSystem](https://github.com/shandyksl/ITTicketingSystem.git)
- CLick on the main branch to clone the repository to your local machine.Most IDEs support Git extensions, so you can use your IDE to clone the repository. Here, [SourceTree](https://www.sourcetreeapp.com/)is recommended.
- Once the repository is cloned, open the project with Visual Studio. Visual Studio will prompt you to install the project's extensions. Click to install.

###### 2. Install SQL Server and SSMS
2.1 Download [SqlServer][Express](https://www.microsoft.com/en-my/sql-server/sql-server-downloads) and SSMS [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16), Install SQL Server and SSMS.    
  

2.2 Create a localhost server:
Click on the Server name and changed to LAPTOP-ULR5FPFS\SQLEXPRESS and Authentication changed to Windows Authentication

2.3 In SSMS, create a database named ITTicketing 
2.4 Copy the contents of [init.sql](./ITTicketing/Database/init.sql) and execute it in the created database.


###### 3. Test running the project locally
- Ensure that the SSMS local server is running.
- Click Run in Visual Studio 2022 to run the project. If there are no prompt errors, it means the project is running successfully