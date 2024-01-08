using Menukaart.DataManagement.Menukaart.Model;
using Menukaart.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMenukaart.Tests
{
    public class RouteTests
    {
        [Fact]
        public void RouteListPageModelCreateValidRoute()
        {
            RouteListPageModel model = new RouteListPageModel()
            {
                Name = "Coole route",
                Description = "Wauw wat een leuke route door heel breda",
                ImageName = "la_cubanita.jpg",
                SightList = SightData.SightList
            };

            Assert.NotNull(model.SightList);
            Assert.NotEmpty(model.SightList);

        }

        [Fact]
        public void RouteListPageModelCreateValidRouteAndPrintCoordinates()
        {
            RouteListPageModel model = new RouteListPageModel()
            {
                Name = "Coole route",
                Description = "Wauw wat een leuke route door heel breda",
                ImageName = "la_cubanita.jpg",
                SightList = SightData.SightList
            };

            Assert.NotNull(model.SightList);
            Assert.NotEmpty(model.SightList);

            foreach (var sight in model.SightList)
            {
                Debug.WriteLine(sight.Location);
            }
        }
    }
}
