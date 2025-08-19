using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Fulton_Christopher
{
    // The Truck class represents a heavier vehicle that implements the IAutomobile interface.
    // It includes properties for speed, number of wheels, license plate, and weight.
    // Wheel count is determined dynamically based on the truck's weight.
    internal class Truck : IAutomobile
    {
        // Current speed of the Truck (can only be modified inside this class).
        public double Speed { get; private set; }

        // Number of wheels on the Truck.
        // Determined in the constructor depending on the truck's weight.
        public int Wheels { get; private set; }

        // License plate number of the Truck.
        public string LicensePlate { get; private set; }

        // The weight of the Truck (read-only, set at construction).
        public double Weight { get; }

        // Constructor that initializes the Truck with given speed, weight, and license plate.
        // Sets the number of wheels depending on the weight:
        //   - If weight < 400 → 8 wheels
        //   - Otherwise → 12 wheels
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        // Outputs a description of the Truck’s current state (speed, wheels, and plate).
        public void Stringify()
        {
            Console.WriteLine(
                $"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!"
            );
        }

        // Increases the Truck’s speed by 5 units.
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Decreases the Truck’s speed by 5 units.
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
