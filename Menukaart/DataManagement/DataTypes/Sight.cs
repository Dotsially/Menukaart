using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.DataManagement.DataTypes
{
    
    public class Sight
    {
        //information about sight
        public int id { get; }
        public string name { get; }
        public string description { get; }
        public string extraInfoURL { get; }
        public Image image { get; }

        //variables for position
        public float longitude { get; }
        public float latitude { get; }
        public float altitude { get; }

        //status of sight
        public bool visited { get; set; }
        
        

        public Sight(int id, string name, string description, string extraInfoURL, Image image, float longitude, float latitude, float altitude) 
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.extraInfoURL = extraInfoURL;
            this.image = image;
            this.longitude = longitude;
            this.latitude = latitude;
            this.altitude = altitude;
            this.visited = false;
        }
       
    }
}
