using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Employee
    {
        public String name;
        public String surname;
        public int salary;

        public Employee(String pName, String pSurname, int pSalary)
        {
            name = pName;
            surname = pSurname;
            salary = pSalary;
        }

        public void increaseSalary(){
            salary += 20;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Jhon", "Doe", 2000);
           
            Console.WriteLine("The name in object e1 is:" + e1.name);
            Console.WriteLine("The salary in object e1 is:" + e1.salary);
            //increaseSalary(e1);
            e1.increaseSalary();
            Console.WriteLine("The salary (after increase) in object e1 is:" + e1.salary);

            Console.ReadLine();
        }

        public static void increaseSalary(Employee p)
        {
            p.salary += 10;
        }
    }
}
