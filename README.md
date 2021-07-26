# Carv1

### prerequisites

• Visual studio 2017 or superior.
• Sql Server 2012 or superior.
• Web browser with lastest updates.

## In order to execute the project, 

1) Clone project in your local drive.
2) Create new database in any instance of Sql Server database.
3) Modify the connectionString located in "DataLayer > AppContext" with the information related to database created before. (This project uses CodeFirst approach)
4) Open Package manager console in visualStudio
5) Excecute next command: Update-Database
6) Clean and rebuild the whole project
7) Open following url: http://localhost:55957/swagger/index.html
