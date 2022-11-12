// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Test2_EmployeeSalary_Abstraction;



Salary objSalary = new Salary();
Console.WriteLine("Enter Employee Details.....");
Console.WriteLine("Enter Employee Id");
objSalary.EmployeeId = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Employee Name");
objSalary.EmployeeName = Console.ReadLine();

Console.WriteLine("Enter Employee Salary");
objSalary.EmployeeSalary = int.Parse(Console.ReadLine());

objSalary.DisplayEmployeeDetails();
objSalary.TaxCalculation();
objSalary.DisplaySalaryDetails();



   

