﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person           // Inheriting Base Class "Person"
    {

        public override void SayName()          //Inherited method from Base Class "Person"
        {
            {
                Console.WriteLine(firstName + " " + lastName);
            }

        }


    }
}
