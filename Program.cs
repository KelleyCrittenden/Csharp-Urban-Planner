using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //create several building 
            //building is the type  fiveOneTwoEight is the variable and new building is creating a instance of it 
            Building fiveOneTwoEight = new Building("512 8th Avenue");
            Building fiveOneTwoSix = new Building("812 15th Avenue");
            Building fiveOneTwoFour = new Building("310 10th Avenue");
            //give each building width, height, stories 
            //fiveOneTwoEight is a variable and width is a property 
            fiveOneTwoEight.Width = 200;
            fiveOneTwoEight.Depth = 300;
            fiveOneTwoEight.Stories = 20;
            fiveOneTwoSix.Width = 1000;
            fiveOneTwoSix.Depth = 2000;
            fiveOneTwoSix.Stories = 200;
            fiveOneTwoFour.Width = 400;
            fiveOneTwoFour.Depth = 200;
            fiveOneTwoFour.Stories = 40;
            // Construct each building 
            //fiveOneTwoEight is the variable and Design is the method. We add the dot to connect the two
            fiveOneTwoEight.Design("Lacey");
            fiveOneTwoEight.Construct();
            fiveOneTwoEight.Purchase("Faith");
            fiveOneTwoSix.Design("Rose");
            fiveOneTwoSix.Construct();
            fiveOneTwoSix.Purchase("Adam");
            fiveOneTwoFour.Design("Erik");
            fiveOneTwoFour.Construct();
            fiveOneTwoFour.Purchase("Tasha");
            //displays the buildings
            fiveOneTwoEight.DisplayBuilding();
            fiveOneTwoSix.DisplayBuilding();
            fiveOneTwoFour.DisplayBuilding();
            Console.WriteLine("---- Megalopolis City -----");
            Console.WriteLine();
            //we are creating a new City
            City megalopolis = new City();
            //adding building to the city
            megalopolis.AddBuildings(fiveOneTwoEight);
            megalopolis.AddBuildings(fiveOneTwoSix);
            megalopolis.AddBuildings(fiveOneTwoFour);
            //looping through the buildings and displaying the buildings
            foreach (Building building in megalopolis.getAllBuildings)
            {
                building.DisplayBuilding();
            }
        }
    }
}