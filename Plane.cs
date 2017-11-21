using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class Plane : Transport
    {
        protected internal string pName;
        protected internal int AmountEngine;
        protected internal int AmountWings;

        public Plane(int Comfort, int AmountWheels, int AmountPlaces, int MaxSpeed, 
            int ServiceCost, int MaxCapcity, int Size, string Color, int Weight, int Tax, string TransportType, int ReleaseIn,int Price)
        { }

        public Plane()
        {
        }
    }
}
