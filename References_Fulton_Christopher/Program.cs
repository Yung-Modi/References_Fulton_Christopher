namespace References_Fulton_Christopher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Sedan object with initial speed set to 0
            Sedan myFirstSedan = new Sedan(0);

            // Assign the Sedan object to an IAutomobile interface reference
            // This shows polymorphism: the Sedan can be treated as an IAutomobile
            IAutomobile myAutomobile = myFirstSedan;

            // Create another Sedan object, also with speed 0
            Sedan myOtherSedan = new Sedan(0);

            // Increase the speed of the first Sedan
            myFirstSedan.IncreaseSpeed();

            // Print the speed of the first Sedan directly
            Console.WriteLine(myFirstSedan.Speed);

            // Print the speed of the first Sedan via the IAutomobile reference
            // Should be the same value as above since they reference the same object
            Console.WriteLine(myAutomobile.Speed);

            // Check if the first Sedan is equal to the IAutomobile reference
            // This will be true since both point to the same Sedan instance
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            // Increase the speed of the second Sedan (different object)
            myOtherSedan.IncreaseSpeed();

            // Print the speed of the first Sedan (should be unchanged from before)
            Console.WriteLine(myFirstSedan.Speed);

            // Print the speed of the second Sedan (should be 1 if IncreaseSpeed adds +1)
            Console.WriteLine(myOtherSedan.Speed);

            // Compare the two Sedan objects for equality
            // This will likely be false since they are different instances
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            // Create a Truck object with initial speed 50, capacity 500, and a name
            Truck myTruck = new Truck(50, 500, "MyTruck");

            // Call the Stringify() method on each vehicle
            // Presumably this prints or returns a string description of the object
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}

