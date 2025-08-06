using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.Exercise2
{
    internal class EmployeeManagement
    {
        public string AssignDepartment(string employeeData)
        {
            try
            {
                if (string.IsNullOrEmpty(employeeData))
                {
                    throw new InvalidDataException();
                }
                string[] details = employeeData.Trim().Split(',');
                string employeeName = details[0].Trim();

                if (string.IsNullOrEmpty(employeeName))
                {
                    throw new ArgumentException();
                }
                employeeName = char.ToUpper(employeeName[0]) + employeeName.Substring(1).ToLowerInvariant();

                string department = (employeeName.ToUpper()[0] >= 'A' && employeeName.ToUpper()[0] <= 'M' ? "Department 1" : "Department 2");

                return $"{employeeName} is assigned to {department}";

            }
            catch (ArgumentException)
            {
                return "Employee name invalid";
            }
            catch (InvalidDataException)
            {
                return "Employee data empty";
            }


        }
    }
}
