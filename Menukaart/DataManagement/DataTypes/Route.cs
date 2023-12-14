using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.DataManagement.DataTypes
{
 
    internal class Route
    {
        public List<Sight> sights { get; } = new List<Sight>();
        public int sightCount { get { return sights.Count; } }
       
        public void addSight(Sight sight)
        {
            sights.Add(sight);
        }

        public void removeSight(Sight sight)
        {
            sights.Remove(sight);
        }
    }
}
