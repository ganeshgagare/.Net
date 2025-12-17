using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance1
{
    internal class Person
    {
        public string first_name;
        public string last_name;
    }
    internal class Employee : Person
    {
        public int employee_id;
    }
}
