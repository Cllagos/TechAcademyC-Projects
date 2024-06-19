using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employeeList = new List<string>() { "Joe", "Carlos", "Jim", "Dale", "Brandon", "Joe", "Kyle", "Erik", "Aaron", "Pete" };
            List<Employee> newEmployees = new List<Employee>();
            Employee employee = new Employee();

            foreach (string i in employeeList)
            {
                for (int j = 0; j < employeeList.Count(); j++)
                {
                    if (i == "Joe")
                    {
                        newEmployees[j].FirstName = i;
                    }

                }
            }

            List<Employee> lambdaEmployees = employeeList.Where(name => name == "Joe").Select(name => new Employee { FirstName = name }).ToList();

            // Printing the lambdaEmployees list to verify
            foreach (Employee emp in lambdaEmployees)
            {
                Console.WriteLine(emp.FirstName);
            }


            //        List<string> employeeList = new List<string>() { "Joe", "Carlos", "Jim", "Dale", "Brandon", "Joe", "Kyle", "Erik", "Aaron", "Pete" };
            //        List<Employee> newEmployees = new List<Employee>();

            //        // Creating a new Employee object and initializing its employeeList
            //        Employee employee = new Employee();
            //        employee.FirstName = "Joe"; // Setting the FirstName property of the Employee object
            //        employee.employeeList = employeeList; // Setting the employeeList property of the Employee object

            //        // Adding the employee object to the newEmployees list
            //        newEmployees.Add(employee);

            //        // Accessing the employeeList property of the first employee in newEmployees
            //        foreach (string name in newEmployees[0].employeeList)
            //        {
            //            Console.WriteLine(name);
            //        }
            //    }
            //}

            //public class Employee
            //{
            //    public string FirstName { get; set; }
            //    public List<string> employeeList { get; set; } // List property for employee names

            //    public Employee()
            //    {
            //        employeeList = new List<string>(); // Initializing the list in the constructor
            //    }
            //}
        }

    }
}
    

