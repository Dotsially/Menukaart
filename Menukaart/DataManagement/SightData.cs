using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.DataManagement
{
  
    using global::Menukaart.DataManagement.DataTypes;
    using System.Collections.Generic;
  

    namespace Menukaart.Model
    {
        public class SightData
        {
            public static List<Sight> SightList { get; } = new List<Sight>();
            public SightData()
            {
                    SightList.Add(new Sight(SightList.Count, 
                                            "Proeflokaal Bregje",
                                            "description",
                                            "inforUrl",
                                            null,
                                            new Location(51.58880586602344, 4.772186348316208)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Restaurant chocolat",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.588693760346985, 4.774793660010751)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Gauchos",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58853681193229, 4.775966499185645)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Cafe restaurant zeezicht",
                                            "description",
                                            "inforUrl",
                                            null,
                                            new Location(51.587583899221336, 4.776652159008432)));

                    SightList.Add(new Sight(SightList.Count,
                                            "'t Zusje Breda",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.59012869211109, 4.773792235800231)));

                    SightList.Add(new Sight(SightList.Count,
                                            "McDonalds breda centrum",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58604798603355, 4.775813127909616)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Restaurant Red Apple",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58340851539009, 4.776927490219306)));

                    SightList.Add(new Sight(SightList.Count,
                                            "'t Hart van Breda",
                                            "description",
                                            "infoUrl",
                                            null, 
                                            new Location(51.587801736941444, 4.7772082021544655)));
                   
                    SightList.Add(new Sight(SightList.Count,
                                            "Restaurant Sirtaki",
                                            "description",
                                            "infoUrl",
                                            null, 
                                            new Location(51.58812225798845, 4.777238547885364)));

                    SightList.Add(new Sight(SightList.Count,
                                            "In Kannen & Kruiken",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58888803177311, 4.778856125836694)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Rhodos Grieks Specialiteiten",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58919071517029, 4.779758309814044)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Con Fuego",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58856488552723, 4.776712915133945)));

                    SightList.Add(new Sight(SightList.Count,
                                            "De Colonie",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58859291205177, 4.776424216261193)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Humphrey's Restaurants",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58963954248478, 4.77660404822756)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Tapasbar Plan B",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58973664707036, 4.776639134950073)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Foodhal Breda",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58950942648919, 4.775308436250771)));

                    SightList.Add(new Sight(SightList.Count,
                                            "La Cubanita",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58971660457123, 4.773869994193707)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Popocatepetl Breda",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58953663027294, 4.774588826208994)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Geisha Lounge",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.5892066755368, 4.773912909537846)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Suikerkist",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.589563293172816, 4.774057748824509)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Eetcafé Publieke Werken",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58902669921447, 4.778966191319752)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Gaudim",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58787016771108, 4.780323389080719)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Turks restaurant Lades",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58714690392391, 4.779143217115772)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Saigon Deli",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58694973837543, 4.777447616791754)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Restaurant Ume Breda",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58547071614979, 4.774149991569626)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Bali James - Indonesisch Restaurant",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.585164064186934, 4.7741982713318505)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Brasserie Houtmarkt",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.586074014539534, 4.7778353467571435)));

                    SightList.Add(new Sight(SightList.Count,
                                            "PuiCk",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58874376365351, 4.779369570312816)));

                    SightList.Add(new Sight(SightList.Count,
                                            "De jongens van zand en klei",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58937368157827, 4.779911376533611)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Bobbi's Bar",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58973696360535, 4.780024029311926)));

                    SightList.Add(new Sight(SightList.Count,
                                            "Mr Moos bar & bistro",
                                            "description",
                                            "infoUrl",
                                            null,
                                            new Location(51.58897706761533, 4.776290394365218)));

                 
            }
        }
    }

}
