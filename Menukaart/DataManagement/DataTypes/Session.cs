using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Menukaart.DataManagement.DataTypes
{
    [Table("session")]
    public class Session
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int id { get; }
        [Column("date")]
        public DateTime date { get; set; }
        [Column("time")]
        public int time { get; set; }
        [Column("distance")]
        public int distance { get; set; }
    }
}
