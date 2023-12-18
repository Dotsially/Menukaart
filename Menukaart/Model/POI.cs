using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.Model
{
    internal class POI
    {
        public string Name;

        public Location Location;

        public POI(string name, Location location) 
        {
            this.Name = name;
            this.Location = location;
        }
    }
}
