using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Fulton_Christopher
{
    // The IAutomobile interface defines a contract for all automobile types.
    // Any class that implements this interface must provide these properties and methods.
    internal interface IAutomobile
    {
        // The current speed of the automobile.
        // Classes implementing this will need to return a numeric speed value.
        public double Speed { get; }

        // The number of wheels the automobile has (e.g., 4 for cars, 18 for trucks).
        public int Wheels { get; }

        // The license plate of the automobile as a string.
        public string LicensePlate { get; }

        // A method to display or return a string description of the automobile.
        // Each implementing class will define how this information is presented.
        public void Stringify();
    }
}
