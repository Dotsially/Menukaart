using Menukaart.DataManagement.DataTypes;
using Menukaart.DataManagement.Menukaart.Model;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestMenukaart.Tests
{
    public class SightDataTests
    {
        [Fact]
        public void SightDataListIsNotNull()
        {
            Assert.NotNull(SightData.SightList);
        }

        [Fact]
        public void SightDataListIsNotEmpty()
        {
            Assert.True(SightData.SightList.Count > 0);
        }

        [Fact]
        public void SightDataListSightsValuesAreNotNull()
        {
            List<Sight> sights;
            sights = SightData.SightList;

            foreach (Sight s in sights)
            {
                Assert.NotNull(s);
                Assert.NotNull(s.Name); 
                Assert.NotNull(s.Description);
                Assert.NotNull(s.ExtraInfoURL);
                Assert.NotNull(s.Image);
                Assert.NotNull(s.Location);
            }
        }

        [Fact]
        public void SightDataListSightsImageSourceExists()
        {
            List<Sight> sights;
            sights = SightData.SightList;
            var imageFolder = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "Menukaart", "Resources", "Images");

            foreach (Sight s in sights)
            {
                var fileName = Path.GetFileName(s.Image.Source.ToString().Replace("File: ", ""));
                var filePath = Path.Combine(imageFolder, fileName);

                Assert.True(File.Exists(filePath)); 
            }
        }
    }
}
