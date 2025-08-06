
//Employee Management instructions
//You are tasked with building a simple employee management system in C#. Your system will take a string as an input which includes an employee's name and department, like Alice, Sales.

//If an employee's name starts with a letter from A to M, assign them to "Department 1". If it starts with a letter from N to Z, assign them to "Department 2".

//The name should be formatted so the first letter is capitalized and the rest of the name is in lower case. So end result would look like this for Alice, Sales - Alice is assigned to Department 1.

//You should handle any exceptions that occur, such as null input or empty employee names, by using try-catch-finally blocks.

//Write a method named "AssignDepartment" in the EmployeeManagement class to implement this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee data: ");
            
            string employeeData = Console.ReadLine();

            EmployeeManagement manager = new EmployeeManagement();
            string result = manager.AssignDepartment(employeeData);
            Console.WriteLine(result);

        }
    }
}
