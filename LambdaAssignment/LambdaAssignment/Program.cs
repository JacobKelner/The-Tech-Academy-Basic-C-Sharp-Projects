using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//instantiate employee object 
            List<Employee> newList = new List<Employee> {//creates new list from Employee
                new Employee() {Id = 1, FirstName = "Joe", LastName = "Frazier"},//instantiate object, and give values to properties (Id, FirstName and LastName)
                new Employee(){Id =2, FirstName = "Floyd", LastName = "Mayweather"},//instantiate object, and give values to properties
                new Employee(){Id= 3, FirstName = "Muhammad", LastName = "Ali"},//instantiate object, and give values to properties
                new Employee(){Id = 4, FirstName =  "Mike", LastName =  "Tyson"},//instantiate object, and give values to properties
                new Employee(){Id = 5, FirstName = "Joe", LastName =  "Frazier"},//instantiate object, and give values to properties
                new Employee(){Id = 6, FirstName = "Manny", LastName = "Pacquiao"},//instantiate object, and give values to properties
                new Employee(){Id = 7, FirstName = "George", LastName = "Forman"},//instantiate object, and give values to properties
                new Employee(){Id = 8, FirstName = "Sugar", LastName = "Robinson"},//instantiate object, and give values to properties
                new Employee(){Id = 9, FirstName =  "Larry", LastName = "Holmes"},//instantiate object, and give values to properties
                new Employee(){Id = 10, FirstName = "Pernell", LastName =  "Whitaker" }//instantiate object, and give values to properties
            };
            List<Employee> newList2 = new List<Employee>();//creates new list from employee
            foreach (Employee boxer in newList)//foreach loop, finding value in 'newList'
            {
                if ( boxer.FirstName == "Joe")//if FirstName equals Joe, execute below code
                {
                    newList2.Add(boxer);//add value 'boxer' to 'newList2'
                }
                
            }
            List<Employee> joeList = newList.Where(x => x.FirstName == "Joe").ToList();//creates new list from Employee. Finds values from newList, if property FirstName equals Joe, add to list 'joeList'
            List<Employee> joeList2 = newList.Where(x => x.Id > 5).ToList();//creates a new list from Employee. Finds values from newList, if property Id is greater than 5, add to list 'joeList2'
            Console.ReadLine();//ensures console remains open 
        }
    }
}
