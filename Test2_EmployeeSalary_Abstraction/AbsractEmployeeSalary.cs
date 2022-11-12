﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_EmployeeSalary_Abstraction
{
    abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }



        public abstract void DisplayEmployeeDetails();



        public abstract void TaxCalculation();
        public abstract void DisplaySalaryDetails();



    }
}
