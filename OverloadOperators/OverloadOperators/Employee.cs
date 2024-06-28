using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Employee
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static bool operator ==(Employee employee1, Employee employee2)
            {
            if (employee1.ID == employee2.ID)
            {
                return true;
            }
            else
                return false;
                    
            }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.ID == employee2.ID)
            {
                return false;

            }
            else
                return true;
        }

    }


}
