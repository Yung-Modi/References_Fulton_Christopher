using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Fulton_Christopher
{
    // The Sedan class represents a car that implements the IAutomobile interface.
    // It provides details like speed, number of wheels, license plate,
    // and methods for changing speed and describing itself.
    internal class Sedan : IAutomobile
    {
        // Current speed of the Sedan (can only be modified inside this class).
        public double Speed { get; private set; }

        // Number of wheels the Sedan has (always 4).
        public int Wheels { get; private set; }

        // License plate number of the Sedan.
        public string LicensePlate { get; private set; }

        // Constructor to initialize a new Sedan with a given speed.
        // Wheels are always set to 4 and License Plate is fixed.
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-05";
        }

        // Outputs a description of the Sedan’s current state (speed, wheels, and plate).
        public void Stringify()
        {
            Console.WriteLine(
                $"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}."
            );
        }

        // Increases the Sedan’s speed by 5 units.
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Decreases the Sedan’s speed by 5 units.
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
