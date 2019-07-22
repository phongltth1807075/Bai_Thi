using System;
using System.ComponentModel.DataAnnotations;
using ConsoleApp1.entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People
            {
                Name = "Marry",
                Gender = "Male",
                Age = 25,
            };
            Console.WriteLine(people);
            people.Age = 35;
            Console.WriteLine("Person details(apter incrementing age):Name="+ people.Name+", Gender="+people.Gender+", Age="+people.Age);
        }
    }
}