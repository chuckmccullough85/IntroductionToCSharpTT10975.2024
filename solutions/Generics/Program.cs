﻿using Locations;
using Payroll;

Employee e1 = new Employee("Hank Hill", 1001, 100);
Employee e2 = new Employee("Luann Platter", 1002, 126);
Employee e3 = new Employee("Luann Platter", 1002, 126);

try
{
    var bad = new Employee("Rusty Shackleford", 666, -6);
}
catch(Exception e)
{
    Console.WriteLine(e);
}


if (e2.Equals(e3)) Console.WriteLine("e2 is equal to e3");

e1.HomeAddress = new Address("123 Tom Landry dr", null, "Arlen", "TX", "76123");

Console.WriteLine(e1);
Console.WriteLine(e2);

e1.Pay();
e2.Pay();
e1.Pay();

Console.WriteLine("------- Payday! -----------");
Console.WriteLine(e1);
Console.WriteLine(e2);
Console.WriteLine(e3);

var acme = new Organization("Acme Exposives", "123-111");
acme.Hire(e1);
acme.Hire(e2);
acme.Hire(e3);
Console.WriteLine("--- Acme payday! ---");
acme.Pay();
Console.WriteLine(e1);
Console.WriteLine(e2);
Console.WriteLine(e3);
