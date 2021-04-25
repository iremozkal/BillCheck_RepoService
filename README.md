## MVC_BILLCHECK_REPOSERVICE

Creating Employee Bill Form with Entity Framework Code First using Mappings.  
DATA Layer includes entity and dto models.  
DAL Layer includes  context, migrations, mappings and repository operations that runs crud functions and other helpers to get the data from database.  
BUSINESS Layer includes services that helps the communication between DAL and UI layers.  
UI Layer includes the form page that you can list the employees and add/update/delete them.

### Technologies  

+ Asp.Net Web Application with .Net Framework 4.5 
+ Entity Framework 6.4.4
+ Visual Studio 2012

### Usage

on DAL Layer,

```python
PM> enable-migrations	# creates the Configuration.cs file for migrations.
PM> update-database 	# updates the database when code changes.
```
