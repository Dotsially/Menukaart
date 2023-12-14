using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Menukaart.DataManagement.DataTypes
{
    [Table("datalink")]
    public class Datalink
    {
        [Column("session_id")]
        public int session_id { get; }
        [Column("sight_id")]
        public int sight_id { get; }
    }
}
