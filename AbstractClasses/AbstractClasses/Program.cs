using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();            //Instantiating New Employee Object
            employee.firstName = "Sample";
            employee.lastName = "Student";
            IQuittable quitEmployee = new Employee();

            employee.SayName();                            //Invoking Method "Say Name" from Employee Class
            quitEmployee.Quit(employee);


            Console.ReadLine();
        
        
        }
    }
}
