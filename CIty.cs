using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {
        //  Get Set Signifies these are properties, names that can refer to values, describe data that can be held inside the object created from the class
        public string Name { get; set; }

        public string Mayor { get; set; }

        public DateTime YearEst { get; set; }

        public List<Building> getAllBuildings = new List<Building>();
        public void AddBuildings(Building building)
        {

            getAllBuildings.Add(building);
        }

    }
}