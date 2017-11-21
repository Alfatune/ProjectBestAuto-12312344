using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    class MotorBike : Transport
    {
        protected internal bool carriage;

        protected internal string mName;


        public MotorBike(int Comfort, int AmountWheels, int AmountPlaces, int MaxSpeed, int ServiceCost, int MaxCapcity,
            int Size, int Price, string Color, int Weight, int Tax, string TransportType, int ReleaseIn)
        { }

        public MotorBike()
        {
        }
    }
}