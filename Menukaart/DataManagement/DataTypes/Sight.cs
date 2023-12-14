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
        private int id { get; }
        private string name { get; }
        private string description { get; }
        private string extraInfoURL { get; }
        private Image image { get; }
        private float longitude { get; }
        private float latitude { get; }
        private float altitude { get; }
        

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
        }
       
    }
}
