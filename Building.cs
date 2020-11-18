using System;

namespace Planner
{
    public class Building
    {
        // Private Fields, have no get/set
        private string _designer = "Kelley Crittenden";

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        // Public Properties
        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        // Building Constructor
        // Name of constructor is the same name of the class
        public Building(string address)
        {
            _address = address;

        }
        // Public Methods
        // set to public void, does not return a value
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            _owner = buyer;
        }
        public void Design(string designer)
        {
            _designer = designer;
        }

        public void DisplayBuilding()
        {
            Console.WriteLine(_address);
            Console.WriteLine("------------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine();
        }
    }
}