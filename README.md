
# Branden Clauson Hair Salon Organizer

### ***By Branden Clauson***
### A stylist to client organizer

<p>&nbsp<p>

## **Technologies used**

* C#
* .NET 5.0
* dotnet
* MySql
* MySql workbench

<p>&nbsp<p>

## **Description**

#### Program that oranizes inputted Stylists and their clients.


<p>&nbsp<p>

## **Setup/Installation Requirements**
* Clone to folder
* Navagate to directory within your terminal
* Create appsettings.json file within the SalonTracker directory with the code:
 <code> 
 {
  
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=Branden_Clauson;uid=[User Id];pwd=[UserPassword];"
  }
}
</code>

* Run mysql server and open workbench
* Click on administration tab
* Click Data Import/Export
* Click Import from Self-contained file option and input the sql file within the repo
* Under Default Schema to be Imported To, select the New button.
* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
* When finished go back to Navigator and refresh schemas by right-clicking
* Return to the directory in the terminal and input <code> dotnet run <code>


<p>&nbsp<p>

## **Known Bugs**

#### Stles.css not currently functional

## **License**

[MIT](LICENSE.txt)

Copyright (c) 2022 Branden Clauson

<p>&nbsp<p>
