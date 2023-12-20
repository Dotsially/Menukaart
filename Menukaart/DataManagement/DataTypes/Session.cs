using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Menukaart.DataManagement.DataTypes
{
    [Table(Constants.SessionTable)]
    public class Session
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int id { get; set; }
        [Column("date")]
        public DateTime date { get; set; }
        [Column("time")]
        public int time { get; set; }
        [Column("distance")]
        public int distance { get; set; }

        [Ignore]
        public HashSet<int> sightIdList{ get; set; }

        public Session()
        {
            date = DateTime.Now;
            time = 0;
            distance = 0;
            sightIdList = new HashSet<int>();
        }
        public void AddSight(int id)
        {
            sightIdList.Add(id);
        }

        public void RemoveSight(int id)
        {
            sightIdList.Remove(id);
        }
    }
}
