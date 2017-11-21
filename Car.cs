using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class Car : Transport
    {
        protected string locatedHelm;
        protected int AmountDoors;
        protected string cName;


        public Car(int Comfort, int AmountWheels, int AmountPlaces, int MaxSpeed, int ServiceCost, int MaxCapcity, int Size, string Color, int Weight, int Tax, string TransportType, int ReleaseIn, int Price)
        { }

        public Car()
        {
        }
    }
}
