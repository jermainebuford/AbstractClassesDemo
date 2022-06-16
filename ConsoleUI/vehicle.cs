using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class vehicle
    {
        public int Year { get; set; } = 2020;
        public string Make { get; set; } = "default make";
        public string Model { get; set; } = "default model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"this {Model} is virtually in drive");
        }
        
            
    }
}
