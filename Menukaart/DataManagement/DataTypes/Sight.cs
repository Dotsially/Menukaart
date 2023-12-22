using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.DataManagement.DataTypes
{
    
    public class Sight
    {
        //information about sight
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string ExtraInfoURL { get; }
        public Image Image { get; }

        //variables for position
        public Location Location { get; }

        //status of sight
        public bool Visited { get; set; }
        
        

        public Sight(int id, string name, string description, string extraInfoURL, Image image, Location location) 
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ExtraInfoURL = extraInfoURL;
            this.Image = image;
            this.Location = location;
            this.Visited = false;
        }
       
    }
}
