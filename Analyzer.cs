using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Analyzer 
    {
        protected bool AccessCar;
        protected bool AccessBike;
        protected bool AccessPlane;
        protected bool AccessMotorBike;
        protected bool AccessScooter;


        public void Check(Person z)
        {
            Console.WriteLine($"{z.Name}, you are suitable for the following vehicles:");
            if (z.MedReference == true & z.DriverLicense == true & z.Age > 18 & z.Age < 80)
            {
                this.AccessCar = true;
            }
            if (z.MedReference == true & z.DriverLicense == true & z.Age > 18 & z.Age < 60)
            {
                this.AccessPlane = true;
            }
            if (z.MedReference == true & z.DriverLicense == true & z.Age > 16 & z.Age < 80)
            {
                this.AccessMotorBike = true;
            }
            if ((z.MedReference == true || z.MedReference == false) & (z.DriverLicense == true || z.DriverLicense == false) & (z.Age > 5 & z.Age < 75))
            {
                this.AccessBike = true;
            }
            if ((z.MedReference == true || z.MedReference == false) & (z.DriverLicense == true || z.DriverLicense == false) & (z.Age > 4 & z.Age < 75))
            {
                this.AccessScooter = true;
            }
        }
        public void Info()
        {
            if (this.AccessCar == true)
            {
                Console.WriteLine("Car");
            }
            if (this.AccessPlane == true)
            {
                Console.WriteLine("Plane");
            }
            if (this.AccessMotorBike == true)
            {
                Console.WriteLine("MotorBike");
            }
            if (this.AccessBike == true)
            {
                Console.WriteLine("Bike");
            }
            if (this.AccessScooter == true)
            {
                Console.WriteLine("Scooter");
            }

        }

    }
}
