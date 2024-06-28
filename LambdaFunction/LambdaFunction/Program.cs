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



            //foreach (string name in employeeList)
            //{
            //    if (name == "Joe")
            //    {
            //        Employee employee = new Employee();
            //        employee.FirstName = name;
            //        newEmployees.Add(employee);
            //    }
            //}

            //string[] fruits = { "apple", "banana", "mango", "orange",
            //          "passionfruit", "grape" };

            //var query =
            //    fruits.Select((fruit, index) =>
            //                      new { index, str = fruit.Substring(0, index) });

            //List<Employee> lambdaEmployees = employeeList.Where(name => name == "Joe").Select(name => new Employee { FirstName = name }).ToList();

            //// Printing the lambdaEmployees list to verify
            //foreach (Employee emp in lambdaEmployees)
            //{
            //    Console.WriteLine(emp.FirstName);
            //    Console.ReadLine();
            //}

            //List<Employee> employeeListID = employeeList.Select(name => new Employee { FirstName = name }).ToList();

            //employeeListID = employeeList.Select((name, index) => new Employee { ID = index }).ToList();
            List<Employee> employeeListID = employeeList.Select((name, index) => new Employee { ID = index, FirstName = name }).ToList();

            foreach (Employee employee in employeeListID)
            {
                Console.WriteLine(employee);
                
            }
            Console.ReadLine();







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
    

