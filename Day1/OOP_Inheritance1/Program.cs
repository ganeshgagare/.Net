using System.IO.Pipes;

namespace OOP_Inheritance1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance1
            Person person = new Person();
            person.first_name = "john";
            person.last_name = "Doe";
            //Console.WriteLine(person);
            //Console.WriteLine("Name:{0},{1}", person.first_name, person.last_name);

            #endregion




            #region Inheritance2
            Employee employee = new Employee();
            employee.employee_id = 1001;
            Console.WriteLine("ID: {2}, Name : {0} {1} {2}", person.first_name, person.last_name, employee.employee_id);

            #endregion
        }
    }
}
