
## Overview
In this lab, we will create a class: *Employee*

| | |
| --------- | --------------------------- |
| Exercise Folder | BasicClasses |
| Builds On | None |
| Time to complete | 30 minutes

---
## Instructions

1. Create a new console project in your solution 
1. Create a new class named *Employee* 
    - file name *Employee.cs* 
1. An employee *has*
    - a name
    - an id
    - a salary
    - year to date earnings
    - year to day taxes
1. What type should each of those items be?
1. Define fields for each of the data items
1. Employees get paid.  Since the information required to calculate taxes and track YTD values is in the *Employee*, the employee will perform the calculations
    - define a method ```float Pay()``` in the class.  The method will figure the taxes (assume 7.65%) increase the YTD values and return the *net* pay.

1. Define a constructor for your class that accepts name, id, and salary
1. In *Program.cs* create a couple of employees and pay them. Display their YTD values to verify that they were paid

---
