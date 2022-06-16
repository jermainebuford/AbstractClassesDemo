using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : vehicle
    {
        public Motorcycle ()
        {

        }

        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($" this motorcycle is in drive");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
