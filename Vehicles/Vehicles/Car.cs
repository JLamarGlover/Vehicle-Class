using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }

        public void Brake()
        {
            Console.WriteLine("Braking");
        }
    }
}
