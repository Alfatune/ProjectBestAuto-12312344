using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person : Transport
    {
        protected string name;
        protected int age;
        protected string medReference;
        protected string driverLicense;

        public Person()
        {
            this.name = (Console.ReadLine());
            this.age = int.Parse(Console.ReadLine());
            this.medReference = Console.ReadLine();
            this.driverLicense = Console.ReadLine();
        }


        public string Name
        { get { return name; } }
        public int  Age
        { get { return age; } }
        public string MedReference
        { get { return medReference; } }
        public string DriverLicense
        { get { return driverLicense; } }

        //public Client()
        //{
        //    //    Console.WriteLine("AmountPlaces");
        //    //    this.AmountPlaces = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("AmountWheels");
        //    //    this.AmountWheels = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("Color");
        //    //    this.Color = (Console.ReadLine());
        //    //    Console.WriteLine("MaxCapcity");
        //    //    this.MaxCapcity = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("MaxSpeed");
        //    //    this.MaxSpeed = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("Price");
        //    //    this.Price = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("ServiceCost");
        //    //    this.ServiceCost = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("Tax");
        //    //    this.Tax = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("TransportType");
        //    //    this.TransportType = (Console.ReadLine());
        //    //    Console.WriteLine("Weight");
        //    //    this.Weight = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("ReleaseIn");
        //    //    this.ReleaseIn = int.Parse(Console.ReadLine());
        //    //    Console.WriteLine("FuelCost");
        //    //    this.FuelCost = int.Parse(Console.ReadLine());

        //    //}
        //    //public void CHECK(Car car, Plane plane, Bike bike, MotorBike motorbike, Scooter scooter)
        //    //{ int c=0;

        //    //    { }
        //    //    if (this.Price >= car.Price)
        //    //    { c++; }
        //    //    if(this.AmountPlaces == car.AmountPlaces)
        //    //    { c++; }
        //    //    if (this. AmountWheels == car.AmountWheels)
        //    //    { c++; }
        //    //    if (this.Color == car.Color)
        //    //    { c++; }
        //    //    if (this.MaxCapcity >= car.MaxCapcity)   //json
        //    //    { c++; }
        //    //    if (this.MaxSpeed >= car.MaxSpeed)
        //    //    { c++; }
        //    //    if (this.ServiceCost <= car.ServiceCost)
        //    //    { c++; }
        //    //    if (this.Tax <= car.Tax)
        //    //    {c++; }
        //    //    if (this.TransportType == car.TransportType)
        //    //    { c++; }
        //    //    if (this.Weight <= car.Weight)
        //    //    { c++; }
        //    //    if (this.ReleaseIn >= car.ReleaseIn)
        //    //    { c++; }
        //    //    if (this.FuelCost >= car.FuelCost)
        //    //    { c++; }
        //    //    Console.WriteLine(c);
        //    //    Console.ReadLine();
        //    //    int p = 0;
        //    //    { }
        //    //    if (this.Price >= plane.Price)
        //    //    { p++; }
        //    //    if (this.AmountPlaces == plane.AmountPlaces)
        //    //    { p++; }
        //    //    if (this.AmountWheels == plane.AmountWheels)
        //    //    { p++; }
        //    //    if (this.Color == plane.Color)
        //    //    {p++; }
        //    //    if (this.MaxCapcity >= plane.MaxCapcity)
        //    //    { p++; }
        //    //    if (this.MaxSpeed >= plane.MaxSpeed)
        //    //    { p++; }
        //    //    if (this.ServiceCost <= plane.ServiceCost)
        //    //    { p++; }
        //    //    if (this.Tax <= plane.Tax)
        //    //    { p++; }
        //    //    if (this.TransportType == plane.TransportType)
        //    //    { p++; }
        //    //    if (this.Weight <= plane.Weight)
        //    //    {p++; }
        //    //    if (this.ReleaseIn >= plane.ReleaseIn)
        //    //    { p++; }
        //    //    if (this.FuelCost >= plane.FuelCost)
        //    //    {p++; }
        //    //    Console.WriteLine(p);
        //    //    Console.ReadLine();
        //    //    int m = 0;
        //    //    { }
        //    //    if (this.Price >= motorbike.Price)
        //    //    { m++; }
        //    //    if (this.AmountPlaces == motorbike.AmountPlaces)
        //    //    { m++; }
        //    //    if (this.AmountWheels == motorbike.AmountWheels)
        //    //    { m++; }
        //    //    if (this.Color == motorbike.Color)
        //    //    { m++; }
        //    //    if (this.MaxCapcity >= motorbike.MaxCapcity)
        //    //    { m++; }
        //    //    if (this.MaxSpeed >= motorbike.MaxSpeed)
        //    //    { m++; }
        //    //    if (this.ServiceCost <= motorbike.ServiceCost)
        //    //    { m++; }
        //    //    if (this.Tax <= motorbike.Tax)
        //    //    { m++; }
        //    //    if (this.TransportType == motorbike.TransportType)
        //    //    { m++; }
        //    //    if (this.Weight <= motorbike.Weight)
        //    //    { m++; }
        //    //    if (this.ReleaseIn >= motorbike.ReleaseIn)
        //    //    { m++; }
        //    //    if (this.FuelCost >= motorbike.FuelCost)
        //    //    { m++; }
        //    //    Console.WriteLine(p);
        //    //    Console.ReadLine();
        //    //    int  b = 0;
        //    //    { }
        //    //    if (this.Price >= bike.Price)
        //    //    { b++; }
        //    //    if (this.AmountPlaces == bike.AmountPlaces)
        //    //    { b++; }
        //    //    if (this.AmountWheels == bike.AmountWheels)
        //    //    { b++; }
        //    //    if (this.Color == bike.Color)
        //    //    { b++; }
        //    //    if (this.MaxCapcity >= bike.MaxCapcity)
        //    //    { b++; }
        //    //    if (this.MaxSpeed >= bike.MaxSpeed)
        //    //    { b++; }
        //    //    if (this.ServiceCost <= bike.ServiceCost)
        //    //    { b++; }
        //    //    if (this.Tax <= bike.Tax)
        //    //    { b++; }
        //    //    if (this.TransportType == bike.TransportType)
        //    //    { b++; }
        //    //    if (this.Weight <= bike.Weight)
        //    //    {b++; }
        //    //    if (this.ReleaseIn >= bike.ReleaseIn)
        //    //    { b++; }
        //    //    if (this.FuelCost >= bike.FuelCost)
        //    //    { b++; }
        //    //    int s = 0;
        //    //    { }
        //    //    if (this.Price >= scooter.Price)
        //    //    { s++; }
        //    //    if (this.AmountPlaces == scooter.AmountPlaces)
        //    //    { s++; }
        //    //    if (this.AmountWheels == scooter.AmountWheels)
        //    //    { s++; }
        //    //    if (this.Color == scooter.Color)
        //    //    {s++; }
        //    //    if (this.MaxCapcity >= scooter.MaxCapcity)
        //    //    { s++; }
        //    //    if (this.MaxSpeed >= scooter.MaxSpeed)
        //    //    {s++; }
        //    //    if (this.ServiceCost <= scooter.ServiceCost)
        //    //    { s++; }
        //    //    if (this.Tax <= scooter.Tax)
        //    //    { s++; }
        //    //    if (this.TransportType == scooter.TransportType)
        //    //    { s++; }
        //    //    if (this.Weight <= scooter.Weight)
        //    //    {s++; }
        //    //    if (this.ReleaseIn >= scooter.ReleaseIn)
        //    //    { s++; }
        //    //    if (this.FuelCost >= scooter.FuelCost)
        //    //    { s++; }

        //    //    int[] massivchik228=  { c, b, m, s, p };

        //    //    int max=0;
        //    //    for (int i = 0; i < 4; i++)
        //    //    { if (massivchik228[i] > max)
        //    //        { max = massivchik228[i];

        //    //        }

        //    //    }
        //    //    if (c == max)
        //    //    { car.Info(); }
        //    //    if (p == max)
        //    //    { plane.Info(); }
        //    //    if (s == max)
        //    //    { scooter.Info(); }
        //    //    if (m == max)
        //    //    { motorbike.Info(); }
        //    //    if (b == max)
        //    //    { bike.Info(); }
        //    //    Console.WriteLine(p);
        //    //    Console.ReadLine();
        //    //    Console.WriteLine(max);
        //    Console.ReadLine();

        //}

    }
}
