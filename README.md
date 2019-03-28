# HSQLDB.Net
.Net interafce for HSQLDB Database

## HSQLDB
"[HSQLDB](http://www.hsqldb.org/) _(HyperSQL DataBase) is the leading SQL relational database software written in Java. It offers a small, fast multithreaded and transactional database engine with in-memory and disk-based tables and supports embedded and server modes. It includes a powerful command line SQL tool and simple GUI query tools."_

**The point is that is Java based. There is not much support for using it with .NET. 
A search for "How can I access an HSQL DB from a .NET application?" only comes with ODBC as the solution. We need a suitable .NET wrapper class that can wrapper Java jar fiules.
This repository goes a little way to address this issue.**

## Background
This is only a partial sosolution. The basis of this solution was provided by **JuggerNET** from [CodeMesh](http://codemesh.com/) To further devlop the solution proivided here you will need to install and licence that product. 

## Limitation
The solution is only for Windows forms x64/x86 or .NET Console apps. It is partially a prebuilt solution.
No solution for Xamarin. No solution for .NET Core/.Net Standard.

<hr>
<b>Please note:</b> <i>Codemesh grants a free license to use the Codemesh JuggerNET libraries (netrt.dll and xmogrt.dll) for evaluation purposes only. Codemesh does not maintain this project and makes no warranties as to its suitability for any purpose. Usage of Codemesh’s JuggerNET libraries in a production application requires a license which can be acquired by contacting Codemesh via email at <a href="mailto:info@codemesh.com">info@codemesh.com</a>.  </i>
<hr>

### Getting started
Firstly you wil need a UI for creating HSQLDBs. I use [RazorSQL](https://www.razorsql.com/index.html):
RazorSQL is a desktop application that provides users with the ability to query, edit, browse, and manage databases. To download RazorSQL, click the "Download" link next to the text below that best describes your computer. Please see the links below for installation and uninstallation procedures for the various operating systems supported by RazorSQL
You can get a full trial version of it that lasts 30 days beforeyou have to purchase it.



## The Repository Solution
The provided app is a basic C# .NET Console app that opens an HSQLDB Databse, writes some records to it and then queries for them. First time it runs you need to uncomment one line that creates the table, in Program.cs: 
```
                       //Update(conn, "CREATE TABLE sample_table ( id INTEGER IDENTITY, str_col VARCHAR(256), num_col INTEGER)");
```
Note that when you first connect to an HSQLDB, if the db doesn't exist, it is created. You need to downlaod and install [HSQLDB](http://www.hsqldb.org/) The app needs a path to the HSQLDB.jar  Note that if you are using an existing HSQDB with its own DBMS jar for it you add a reference to it. Nb: Just build and run the x64 solution.

Note that some of the prebuilt code will probably be excluded from the GitHub repository so I will link to this on my blog:

Downaload **generated.zip** from https://davidjones.sportronics.com.au/Other
Download and unzip the folder.
Copy its dotnet folder into the Solution-folder/generated folder. 

Also you may need to tweak the jdbcr10-x64 project post build to find dumpbin on your system.
You can canel those check to simplify things.

_Nb:_ Make sure you unblock the downloaded zip before extracting itrs contents

Similarly, also downlaod and unzip **packages.zip** from the link as above.
Place the packages folder in the Solution-Folder

You may need to tweak the console app project to find dumpbin on your system in the post build events.
You might just commebnt these checks out if you wish.

One last thing. Need to have Java installed. Modify the line in Program.cs:
```
loader.JvmPath = @"C:\Program Files\Java\jdk1.8.0_161\jre\bin\server\jvm.dll";
```
to point your jvm.dll (Make sure its x64) I could code this a bit better.

