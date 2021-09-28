using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesNew
{
    public enum VehicleType { Car, Truck, SUV, Minivan, Coupe, Boat }
    public class Vehicle
    {
        //accessModifier  type   propertyName  {get;set;}
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string  Color { get; set; }
        public double Mileage { get; set; }

        public VehicleType Type { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType type)
        {
            Make = make;
            Year = year;
            Model = model;
            Color = color;
            Mileage = mileage;
            Type = type;

        }


    }
    public class Person
    {
        public int _field;
        //age
        //height
        //gender
        //weight
        //DateOfBirth
        //firstName
        //LastName

       

        public string FirstName { get; set; }


        private string _firstName;

        public string GetFirstName()
        {
            return _firstName;
        }
        public void SetFirstName(string value)
        {
            _firstName = value;
        }

    }
}
