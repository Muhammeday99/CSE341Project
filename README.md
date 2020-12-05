# Project-Tracking-System-for-Automation-Companies
## 5M Macro Developers

* __Muhammed Salih Yılmaz__
* __İlkan Mert Okul__
* __Muhammet Fikret Atar__
* __Mert Can Beşirli__
* __Muhammed Eyüp__

## Backlog
* __User --> adminUser, standardUser__

* __User (admin or standard) always requires email and password.__

* __When the program is prepared for the first time, the first admin will be added to the database directly.__

### Admin User Menu's
* __Add new account__

* __The added user is admin or not?__

* __Show List User__

* __Change the user's email or password__

### Standard User Menu's
* __Change Password__

* __Send notification message to admin(Not done yet!)__

### Entity Card
(All of the information of other companies or persons with whom the company that will use the system has a creditor relationship)
* __entityKind: legal entity OR person__

* __entityType (client OR supplier)__

* __entityName__

* __entityCode__

* __Adress__

* __entityEmail__

* __entityPhoneNumber__

* __entityFaxNumber__

* __taxOffice__

* __taxNumber__

* __bankAccountNumber__

* __relatedPerson__

* __Description__

* __paymentTerm__

### Create New Current Card
* __When the button is pressed, all these fields above will appear blank. Below will be the SAVE button.__

### SAVE CURRENT CARD
* __When this button is pressed in the create card section, it will send all of them to the database.__

### CURRENT CARD LIST
* __List the Saved Current Cards. When clicking on each account, an extra window will open and only information about that account will be displayed. There is no edit permission, but there is an edit button.__

### DELETE CURRENT CARD
* __It will delete the current card printed on it from the database.__

### EDIT CURRENT CARD
* __It will open permission to edit the current card printed on it. It will save below.__

### ADD BILL

#### Add New Bill
* __Bill Number__

* __Billing Date__

* __Entity Code__

* __Description__

* __Payment Date__

* __Currency Code – TRY, EUR, USD__

* __Amount__

* __KDV(Standart accepted %18)__

* __Total Amount__

* __It will send and add it to the database when you click save, in the same way as in the Current Card.__

#### List Bill
* __The same as the Current Card should appear on the main screen with all invoices listed. At the top right there will be the add new invoice button.__

#### Edit Bill
* __As with the Current Card, it will open the editing permission when pressed. It will save below.__

#### Delete Bill
* __It will delete the printed bill from the database.__

#### Search Bill(Not Priority present!)
* __The search button will search and list something as you type in the menu, which appears as if adding an bill.__

### PROJECT DESCRIPTION
* __Project Code__

* __Project Name__

* __Customer Code__

* __Order Code__

* __Billing Number__

* __Starting Date__

* __Ending Date__

* __Currency Code – TRY, EUR, USD__

* __Price__

* __KDV__

* __Labor costs__

* __Total Amount__

* __Project Manager(Check project active or not)__

* __Description__

#### List Project
* __The same as the Current Card should appear on the main screen with all invoices listed. At the top right there will be the add new bill button.__

#### Edit Project
* __As with the Current Card, it will open the permission to edit when pressed. It will save below.__

#### Delete Project
* __It will delete the printed bill from the database.__

#### Search Project(Not priority present!)
* __The search button will search and list something as you type in the menu, which appears as if adding an bill.__

#### Print

#### Account Card

### EXCHANGE RATE DEFINITION
* __Currency Code – TRY, EUR, USD__

* __Date__

* __Exchange rate__

#### Add Currency

#### List Currency

#### Delete Currency

 ## Requirements
* __ASP.NET__
* __C#__
* __JavaScript__

 ## A great system for :
* __Company project system__
* __Company website with multiple user or contributors__
* __Companies need to tracking projects__

 ## Use Case Diagram for First Presentation
 ![usecase](https://user-images.githubusercontent.com/43350594/101244626-b1ffb480-3718-11eb-8a59-98520c8562c4.png)
 
 ## Login Screen Page
 ![loginscreen](https://user-images.githubusercontent.com/43350594/101244874-00618300-371a-11eb-8d52-7957da811e0a.png)
 
 ## Homepage Page(The net image will change later !)
 ![homepagepic](https://user-images.githubusercontent.com/43350594/101244943-8aa9e700-371a-11eb-8f29-90de09ed0632.png)

 
