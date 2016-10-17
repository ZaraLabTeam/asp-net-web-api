<!-- .element class="text-left" -->
### Creating A Database

The database stores our data. In this case information about
**Products** <!-- .element class="text-success" -->  
All successfully created products are stored in the 
database, and can be modified or deleted.

For easier and quick access data models must have some unique 
characteristic to be easily distinct and found in the database records. 
This is called the 
**primary key** <!-- .element class="text-danger" -->
and most often it is the **Id** <!-- .element class="text-danger" -->
of the model but not necessarily  


### Options

* SQLite
* Microsoft SQL Server

* Database First
* Code First


<!-- .element class="text-left" -->
### SQLite

*economy* <!-- .element class="label label-info" -->
*efficiency* <!-- .element class="label label-primary" -->
*reliability* <!-- .element class="label label-success" -->
*independence* <!-- .element class="label label-warning" -->
*simplicity* <!-- .element class="label label-danger" -->  
  
* Embedded devices and the internet of things
* Application file format
* Websites

SQLite works great as the database engine for most low to medium 
traffic websites (which is to say, most websites).  
Generally speaking, any site that gets fewer than 
**100K hits/day** <!-- .element class="highlight highlight-red" -->
should work fine with SQLite. 

<q class="fragment">The SQLite website
(https://www.sqlite.org/) uses SQLite itself, of 
course, and as of 2015 it handles about 400K to 500K
HTTP requests per day</q>

Notes:
SQLite emphasizes economy, efficiency, reliability, independence, 
and simplicity. It is not directly comparable to client/server SQL 
database engines.


<!-- .element class="text-left" -->
### Microsoft SQL Server

<q>SQL Server is the foundation of Microsoft's data platform, delivering 
mission-critical performance with in-memory technologies and faster
insights on any data, whether on-premises or in the cloud.</q>

\# said
<!-- .element class="fragment" style="text-align: right" --> 
"*Microsoft*" <!-- .element class="text-info" -->

*scalability* <!-- .element class="label label-info" -->
*concurrency* <!-- .element class="label label-primary" -->
*centralization* <!-- .element class="label label-success" -->
*control* <!-- .element class="label label-danger" -->

* **SQL** <!-- .element class="text-info" --> - 
*Structured Query Language*

* **T-SQL** <!-- .element class="text-info" --> -
Transact-SQL, an extension of SQL

* **SQL Server** <!-- .element class="text-info" --> - 
the database engine, executes SQL/T-SQL queries


<!-- .element class="text-left" -->
### Database First

This is a database modeling technique which involves creating the
database either by manipulating E/R Diagrams inside a **workbench** or
**management studio** and/or by defining the database layout using SQL.

Then importing the database to our project in **Visual Studio** 

*If we already have an existing database we are likely to use this
approach*


<!-- .element class="text-right" -->
### Code First

This is a database modeling technique that creates the database schema 
programmatically 
<!-- .element class="text-left" -->

It allows us to create a database by defining it in a familiar language 
and minimal knowledge of SQL. The interaction with the database is
done through an ORM Service/Framework
<!-- .element class="text-left" -->

\# **ORM** 
<!-- .element class="text-info" --> - Object-Relational Mapping