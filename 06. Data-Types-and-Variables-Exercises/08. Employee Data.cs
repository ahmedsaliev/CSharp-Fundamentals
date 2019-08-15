using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            Int64 personalIDNumber = 8306112507;
            Int32 employeeNumber = 27563571;

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalIDNumber);
            Console.WriteLine("Unique Employee number: {0}", employeeNumber);
        }
    }
}
