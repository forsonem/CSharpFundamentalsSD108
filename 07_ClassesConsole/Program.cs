﻿using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesConsole
{
    class Program
    {
        static void Main(string[] args)
        {



            PersonRepository personRepo = new PersonRepository();

            Person person1 = new Person();

            person1.FirstName = "Erick";

            bool result = personRepo.AddPerson2(person1);

         
            




           bool result2 = personRepo.DeletePersonByFirstName("Erick");

            Console.WriteLine(result2);




            Console.ReadKey();



























            //Vehicle firstVehicle = new Vehicle();

            //firstVehicle.Make = "Honda";
            //firstVehicle.Model = "civic";
            //firstVehicle.Year = 2012;
            //firstVehicle.Type = VehicleType.Car;
            //firstVehicle.Mileage = 150000;
            //firstVehicle.Color = "gray";


            //Vehicle secondVehicle = new Vehicle("Chevy", "Silverado", 1994, 980000, "black", VehicleType.Truck);

            //Console.WriteLine(secondVehicle.Make);

            //Console.ReadLine();


            //Person firstPerson = new Person("Garry", "Banks", new DateTime(1991, 08, 24), firstVehicle);

            //Console.WriteLine(firstPerson.FullName);
            //Console.WriteLine(firstPerson.AgeInYears);

            //Console.ReadKey();


        }
    }
}
