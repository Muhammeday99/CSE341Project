# Project Tracking System for Automation Companies
## 5M Macro Developers

- Muhammed Salih Yılmaz
- İlkan Mert Okul
- Muhammet Fikret Atar
- Mert Can Beşirli
- Muhammed Eyüp

## What is it?

Project Tracking System is exactly what its name suggests. It is a helper program for companies (mainly automation companies) that needs their stuff shown to them in an orderly manner. They must track what is going on in their company financially to function properly, and take actions accordingly.

5M Macro's Project Tracking System focuses on everything financial. Our software's services does not know what is going on in the project's background. We can summary the application as follows:

- Progress for work
- Paying fees to various clients
- Work done by company employees

A company uses this software will easily track their process by using features of this software mentioned above.

## Main Functions of the Program

#### Entity Cards

An entity card is an accounting term. En ERP and Accounting Programs, just like 5M Macro's Project Tracking System, an entity card is used to represent the company or organization using the system to represent another person or legal entity, whom there is a customer-creditor relationship exist, to keep track of their records.

We are holding some data such as type, kind, name, code, email, phone etcetera... User of the system enters these variables and the data is sent to the database, where it can be accessed after the fact.

#### Expense Definition

Every company has its own expenses, say phone bills, electricity bills, car expenses, renting fees, wages of the personnel and so on. If a company is serious about its future, it must hold these expenses somewhere. What we have, is just for that.

#### Project Definition

Since R&D companies' main work stuff is creating projects for other firms, they have to maintain and track what new projects they are doing at the moment. With this feature of 5M Macro's Project Tracking System, the firm can have a broad understanding of its projects.

#### Currency Definition

R&D firms work usually with other countries as well; not everyone uses TRY. Adding new currency to use it in other parts of the program, is therefore essential.

#### Invoice Entry

Projects have expenses, and must be maintained. "What did we use in this project and how much did it cost" is a very basic question that needs to be answered correcty. Thus we have invoice entry.

## What have we done while developing the program?

- First of all, we started to do market research. What could we do to further develop this application so that it could fit our customer's needs and other potential customers. Due to that, we had done some meetings with a contact man, who happens to be a developer, in a Automation Company. He helped us gain knowledge about the backend stuff and led us the starting way.
- Later in the following days, our front end squad gave the initial UI of the web application, so that our backend staff would be able to work in it, without thinking too much.
- We had some repetative coding parts finished before we started the Object Oriented part of the program.
- We decided that we couldn't finish the whole app in time due to the sheer size; and came to the conclusion that it would be wise to finish the very basic parts needed. This would help us open the way to develop the program further, if there happens to be free time.
- While front end staff was working behind the scenes, without too much coding that is being sent to the main branch, backend staff was working on hte frontlines.
- The database was firstly Microsoft's own database, but it was not a free to use one. We had to change it due to our financial status.
- Database kept growing each day, when we added new implementations to the program.
- As the time comes to the 2nd presentation, our project was nearly finished, and we only had to do some bug fixes.
- Lastly, as of end of January, our program was at the place that we expected.
- Along the ways, obviously we had done our backlogs, gave each person a jobs etc.

## What is the future of the software?

We would like to sell the application to as many users and firms as possible. This is the main reason why we decided to the the program as it is right now: To be able to develop it further.

## What design did we use?

- Creational Patterns

  - Prototype: We used some base objects to use in our many webform’s codebehind. This really helped us to maintain our code and easily reuse same methods from our objects to control and manipulate software and its data.

- Behavioral Patterns
 
   - Null Object: When user inputs have no or invalid value, we set up those values to a default value before user does something to check if they are valid or not.

## What architecture did we use?

Mainly, our project is based on "Client-Server" architecture model. Because our software is designed to provide functions and datas from server, to many clients.

But we used some other architecture models too. One of them is Pipe-And-Filter and it helped us through to maintain security. Our software’s users need to enter a password to log in. With this model, we transform the entered password to a crypted form to save at our database.

## What tools did we use in development stages?

Mainly Visual Studio and some basic helper programs. We chose **C# / asp.net** as the main language and **HTML/CSS** for the frontend, and lastly **Javascript** for scripting.

 ## Requirements
 - ASP.NET
 - C#
 - JavaScript

 ## A great system for :
 - Company project system
 - Company website with multiple user or contributors
 - Companies need to tracking projects

 ## Use Case Diagram for First Presentation
 ![usecase](https://user-images.githubusercontent.com/43350594/101244626-b1ffb480-3718-11eb-8a59-98520c8562c4.png)
 
 ## Login Screen Page
 ![loginscreen](https://user-images.githubusercontent.com/43350594/101244874-00618300-371a-11eb-8d52-7957da811e0a.png)
 
 ## Homepage Page(The net image will change later !)
 ![homepagepic](https://user-images.githubusercontent.com/43350594/101244943-8aa9e700-371a-11eb-8f29-90de09ed0632.png)
