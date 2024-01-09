
using SQLite;

namespace Menukaart.DataManagement.DataTypes
{
    [Table(Constants.DatalinkTable)]
    public class Datalink
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("id")]
        public int id { get; set; }

        [Column("session_id")]
        public int session_id { get; set; }
        [Column("sight_id")]
        public int sight_id { get; set; }
        [Ignore]
        public List<Sight> sights { get; set; }

        public override string ToString()
        {
            return "From session: " + session_id + "\t sight: " + sight_id;
        }
    }
}
