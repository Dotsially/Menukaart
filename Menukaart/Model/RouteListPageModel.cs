using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.DataManagement.DataTypes;

namespace Menukaart.Model
{
    public class RouteListPageModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ImageSource ImageSource { get; set; }
        public List<Sight> SightList { get; set; }
    }

}
