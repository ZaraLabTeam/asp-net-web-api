### Creating A Database

The database stores our data. In this case information about
**Products** -> All successfully created products are stored in the 
database, and can be modified or deleted.

For easier and quick access data models must have some unique 
characteristic to be easily distinct and found in the database records. 
This is called the 
**primary key** <!-- .element class="highlight highlight-red" -->
and most often it is the **Id** <!-- .element class="highlight highlight-red" -->
of the model but not necessarily  


### Options

* SQLite
* Microsoft SQL Server

* Code First
* Database First


#### SQLite

SQLite emphasizes economy, efficiency, reliability, independence, 
and simplicity. It is not directly comparable to client/server SQL 
database engines.
* Embedded devices and the internet of things
* Application file format
* Websites

SQLite works great as the database engine for most low to medium 
traffic websites (which is to say, most websites).  
Generally speaking, any site that gets fewer than 
**100K hits/day** <!-- .element class="highlight highlight-red" -->
should work fine with SQLite. 

The SQLite website <!-- .element class="fragment" --> 
(https://www.sqlite.org/) uses SQLite itself, of 
course, and as of this writing (2015) it handles about 400K to 500K
HTTP requests per day


### Microsoft SQL Server

SQL Server is the foundation of Microsoft's data platform, delivering 
mission-critical performance with in-memory technologies and faster
insights on any data, whether on-premises or in the cloud.

\# said
<!-- .element class="fragment text-right" --> 
"`Microsoft`"

* `T-SQL` <!-- .element class="highlight" --> - 
Transact-SQL, an extension of SQL
* `SQL Server` <!-- .element class="highlight" --> - 
the database engine, executes SQL/T-SQL queries
* `SQL Server Agent` <!-- .element class="highlight" --> - DB monitoring
    * executes scheduled tasks
    * sends notifications
* `Distributed Transaction Coordinator (MSDTC)` <!-- .element class="highlight" -->
    * Supports transactions that span multiple between multiple databases
    * Implements 2-phase commits