using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : vehicle
    {
        public Car ()
        {

        }

        public bool Hastrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"this car is in drive");
        }

        
    }
}
