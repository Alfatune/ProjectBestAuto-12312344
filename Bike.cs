using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class Bike : Transport
    {
        protected int AmountSpeeds;
        protected bool Amortization;
        protected string bName;
      

        public Bike(int Comfort, int AmountWheels, int AmountPlaces, int MaxSpeed, int ServiceCost, int MaxCapcity, int Size, string Color, int Weight, int Tax, string TransportType, int ReleaseIn)
        { }

        public Bike()
        {
        }
    }
}