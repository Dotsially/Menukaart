using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.Model
{
    internal class PointOfInterest
    {
        private int ID;

        public string Name;

        public Location Location;

        public string Description;

        public PointOfInterest(string name, Location location) 
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
