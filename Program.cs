using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class Transport
    {
        public int Comfort;
        public int AmountWheels;
        public int AmountPlaces;
        public int MaxSpeed;
        public int ServiceCost;
        public int MaxCapcity;
        public int Size;
        public string Color;
        public int Weight;
        public int Tax;
        public string TransportType;
        public int ReleaseIn;
        public int Price;
        public int FuelCost;
        class Program
        {
        }
        static void Main(string[] args)
        {
            MotorBike MotoBike1 = new MotorBike();
            MotoBike1.mName = "Bike";
            MotoBike1.AmountPlaces = 3;
            MotoBike1.AmountWheels = 3;
            MotoBike1.Color = "Green";
            MotoBike1.FuelCost = 1200;
            MotoBike1.MaxSpeed = 800;
            MotoBike1.Price = 12312;
            MotoBike1.ReleaseIn = 2016;
            MotoBike1.Tax = 1000;
            MotoBike1.MaxCapcity = 1500;
            MotoBike1.TransportType = "pass";
            MotoBike1.Weight = 1233;
            MotoBike1.carriage = true;
            MotoBike1.Size = 400;
            Console.WriteLine(MotoBike1.mName + " " + MotoBike1.AmountPlaces + " " + MotoBike1.AmountWheels + " " + MotoBike1.Color + " " + MotoBike1.FuelCost + " " + MotoBike1.MaxSpeed
                + " " + MotoBike1.Price + " " + MotoBike1.ReleaseIn + " " + MotoBike1.Tax + "" + MotoBike1.Size + " " + MotoBike1.TransportType + " "
                + MotoBike1.MaxCapcity + " " + MotoBike1.Weight + " " + MotoBike1.carriage);

            Scooter scoter1 = new Scooter();
            scoter1.sName = "Bike";
            scoter1.AmountPlaces = 160;
            scoter1.AmountWheels = 6;
            scoter1.Color = "Green";
            scoter1.FuelCost = 1200;
            scoter1.MaxSpeed = 800;
            scoter1.Price = 12312;
            scoter1.ReleaseIn = 2016;
            scoter1.Tax = 1000;
            scoter1.MaxCapcity = 1500;
            scoter1.TransportType = "pass";
            scoter1.Weight = 1233;
            scoter1.Folding = false;
            scoter1.Engine = true;
            scoter1.Size = 400;
            Console.WriteLine(scoter1.sName + " " + scoter1.AmountPlaces + " " + scoter1.AmountWheels + " " + scoter1.Color + " " + scoter1.FuelCost + " " + scoter1.MaxSpeed
                + " " + scoter1.Price + " " + scoter1.ReleaseIn + " " + scoter1.Tax + "" + scoter1.Size + " " + scoter1.TransportType + " " 
                + scoter1.MaxCapcity + " " + scoter1.Weight + " " + scoter1.Folding + " " + scoter1.Engine);

            Bike bike1 = new Bike();
            bike1.bName = "Bike";
            bike1.AmountPlaces = 160;
            bike1.AmountWheels = 6;
            bike1.Color = "Green";
            bike1.FuelCost = 1200;
            bike1.MaxSpeed = 800;
            bike1.Price = 12312;
            bike1.ReleaseIn = 2016;
            bike1.Tax = 1000;
            bike1.MaxCapcity = 1500;
            bike1.TransportType = "pass";
            bike1.Weight = 1233;
            bike1.AmountSpeeds = 4;
            bike1.Amortization = true;
            bike1.Size = 400;
            Console.WriteLine(bike1.bName + " " + bike1.AmountPlaces + " " + bike1.AmountWheels + " " + bike1.Color + " " + bike1.FuelCost + " " + bike1.MaxSpeed
                + " " + bike1.Price + " " + bike1.ReleaseIn + " " + bike1.Tax + "" + bike1.Size + " " + bike1.TransportType + " " + bike1.MaxCapcity + " " + bike1.Weight + " " + bike1.Amortization + " " + bike1.AmountSpeeds);

           

            Plane plane1 = new Plane();
            plane1.pName = "Plane";
            plane1.AmountPlaces = 160;
            plane1.AmountWheels = 6;
            plane1.Color = "Green";
            plane1.FuelCost = 1200;
            plane1.MaxSpeed = 800;
            plane1.Price = 12312;
            plane1.ReleaseIn = 2016;
            plane1.Tax = 1000;
            plane1.MaxCapcity = 1500;
            plane1.TransportType = "pass";
            plane1.Weight = 1233;
            plane1.AmountEngine = 4;
            plane1.AmountWings = 3;
            plane1.Size = 400;
            Console.WriteLine(plane1.pName + " " + plane1.AmountPlaces + " " + plane1.AmountWheels + " " + plane1.Color + " " + plane1.FuelCost + " " + plane1.MaxSpeed
                + " " + plane1.Price + " " + plane1.ReleaseIn + " " + plane1.Tax + "" + plane1.Size + " " + plane1.TransportType + " " + plane1.MaxCapcity + " " + plane1.Weight + " " + plane1.AmountEngine + " " + plane1.AmountWings);

           

            Car car1 = new Car();
            car1.cName = "Car";
            car1.AmountPlaces = 2;
            car1.AmountWheels = 4;
            car1.Color = "Red";
            car1.FuelCost = 400;
            car1.MaxSpeed = 223;
            car1.Price = 15000;
            car1.Size = 300;
            car1.ReleaseIn = 2019;
            car1.Tax = 800;
            car1.MaxCapcity = 100;
            car1.TransportType = "sport";
            car1.Weight = 700;
            car1.AmountDoors = 4;
            car1.locatedHelm = "left";
            Console.WriteLine(car1.cName + " " + car1.AmountPlaces + " " + car1.AmountWheels + " " + car1.Color + " " + car1.FuelCost + " " + car1.MaxSpeed
                + " " + car1.Price + " " + car1.ReleaseIn + " " + car1.Tax + " " + car1.TransportType + " " + car1.MaxCapcity + " " + car1.Weight + " " + car1.AmountDoors + " " + car1.locatedHelm);
            Console.ReadLine();
            int wantPlaces;
            int wantPrice;
            int wantSize;
            int wantMaxSpeed;
            Console.WriteLine("VVedite jelaemuy max skorost`");
            wantMaxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("VVedite jelaemuy razmer transporta`");
            wantSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("VVedite jelaemuy ceny transporta`");
            wantPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("VVedite jelaemoe kol-vo mest`");
            wantPlaces = Convert.ToInt32(Console.ReadLine());

            if (wantMaxSpeed == 40)
            {
                if (wantSize == 50)
                {
                    if (wantPrice == 140)
                    {
                        if (wantPlaces == 1)
                        {
                            bike1.bName = "Bike";
                            bike1.AmountPlaces = 1;
                            bike1.AmountWheels = 6;
                            bike1.Color = "Green";
                            bike1.FuelCost = 1200;
                            bike1.MaxSpeed = 40;
                            bike1.Price = 140;
                            bike1.ReleaseIn = 2016;
                            bike1.Tax = 1000;
                            bike1.MaxCapcity = 1500;
                            bike1.TransportType = "pass";
                            bike1.Weight = 1233;
                            bike1.AmountSpeeds = 4;
                            bike1.Amortization = true;
                            bike1.Size = 50;
                            Console.WriteLine(bike1.bName + " " + bike1.AmountPlaces + " " + bike1.AmountWheels + " " + bike1.Color + " " + bike1.FuelCost + " " + bike1.MaxSpeed
                                + " " + bike1.Price + " " + bike1.ReleaseIn + " " + bike1.Tax + "" + bike1.Size + " " + bike1.TransportType + " " + bike1.MaxCapcity + " " + bike1.Weight + " " + bike1.Amortization + " " + bike1.AmountSpeeds);
                        }
                    }
                }
            }

            if (wantMaxSpeed == 223)
            {
                if (wantSize == 300)
                {
                    if (wantPrice == 15000)
                    {
                        if (wantPlaces == 2)
                        {

                            car1.cName = "Car";
                            car1.AmountPlaces = 2;
                            car1.AmountWheels = 4;
                            car1.Color = "Red";
                            car1.FuelCost = 400;
                            car1.MaxSpeed = 223;
                            car1.Price = 15000;
                            car1.Size = 300;
                            car1.ReleaseIn = 2019;
                            car1.Tax = 800;
                            car1.MaxCapcity = 100;
                            car1.TransportType = "sport";
                            car1.Weight = 700;
                            car1.AmountDoors = 4;
                            car1.locatedHelm = "left";
                            Console.WriteLine(car1.cName + " " + car1.AmountPlaces + " " + car1.AmountWheels + " " + car1.Color + " " + car1.FuelCost + " " + car1.MaxSpeed
                                + " " + car1.Price + " " + car1.ReleaseIn + " " + car1.Tax + " " + car1.TransportType + " " + car1.MaxCapcity + " " + car1.Weight + " " + car1.AmountDoors + " " + car1.locatedHelm);
                            Console.ReadLine();
                            Console.ReadLine();
                        }
                    }
                }
            }

            if (wantMaxSpeed == 800)
            {
                if (wantSize == 400)
                {
                    if (wantPrice == 12312)
                    {
                        if (wantPlaces == 160)
                        {
                            
                            plane1.pName = "Plane";
                            plane1.AmountPlaces = 160;
                            plane1.AmountWheels = 6;
                            plane1.Color = "Green";
                            plane1.FuelCost = 1200;
                            plane1.MaxSpeed = 800;
                            plane1.Price = 12312;
                            plane1.ReleaseIn = 2016;
                            plane1.Tax = 1000;
                            plane1.MaxCapcity = 1500;
                            plane1.TransportType = "pass";
                            plane1.Weight = 1233;
                            plane1.AmountEngine = 4;
                            plane1.AmountWings = 3;
                            plane1.Size = 400;
                            Console.WriteLine(plane1.pName + " " + plane1.AmountPlaces + " " + plane1.AmountWheels + " " + plane1.Color + " " + plane1.FuelCost + " " + plane1.MaxSpeed
                                + " " + plane1.Price + " " + plane1.ReleaseIn + " " + plane1.Tax + "" + plane1.Size + " " + plane1.TransportType + " " + plane1.MaxCapcity + " " + plane1.Weight + " " + plane1.AmountEngine + " " + plane1.AmountWings);

                            Console.ReadLine();
                        }
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}