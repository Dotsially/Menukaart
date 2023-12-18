using Menukaart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menukaart.ViewModel
{
    internal class MapPageViewModel
    {
        public List<POI> poiList = new List<POI>();

        public MapPageViewModel()
        {
            poiList.Add(new POI("Proeflokaal Bregje", new Location(51.58880586602344, 4.772186348316208)));
            poiList.Add(new POI("Restaurant chocolat", new Location(51.588693760346985, 4.774793660010751)));
            poiList.Add(new POI("Gauchos", new Location(51.58853681193229, 4.775966499185645)));
            poiList.Add(new POI("Cafe restaurant zeezicht", new Location(51.587583899221336, 4.776652159008432)));
            poiList.Add(new POI("'t Zusje Breda", new Location(51.59012869211109, 4.773792235800231)));
            poiList.Add(new POI("McDonalds breda centrum", new Location(51.58604798603355, 4.775813127909616)));
            poiList.Add(new POI("Restaurant Red Apple", new Location(51.58340851539009, 4.776927490219306)));
            poiList.Add(new POI("'t Hart van Breda", new Location(51.587801736941444, 4.7772082021544655)));
            poiList.Add(new POI("Restaurant Sirtaki", new Location(51.58812225798845, 4.777238547885364)));
            poiList.Add(new POI("In Kannen & Kruiken", new Location(51.58888803177311, 4.778856125836694)));
            poiList.Add(new POI("Rhodos Grieks Specialiteiten", new Location(51.58919071517029, 4.779758309814044)));
            poiList.Add(new POI("Con Fuego", new Location(51.58856488552723, 4.776712915133945)));
            poiList.Add(new POI("De Colonie", new Location(51.58859291205177, 4.776424216261193)));
            poiList.Add(new POI("Humphrey's Restaurants", new Location(51.58963954248478, 4.77660404822756)));
            poiList.Add(new POI("Tapasbar Plan B", new Location(51.58973664707036, 4.776639134950073)));
            poiList.Add(new POI("Foodhal Breda", new Location(51.58950942648919, 4.775308436250771)));
            poiList.Add(new POI("La Cubanita", new Location(51.58971660457123, 4.773869994193707)));
            poiList.Add(new POI("Popocatepetl Breda", new Location(51.58953663027294, 4.774588826208994)));
            poiList.Add(new POI("Geisha Lounge", new Location(51.5892066755368, 4.773912909537846)));
            poiList.Add(new POI("Suikerkist", new Location(51.589563293172816, 4.774057748824509)));
            poiList.Add(new POI("Eetcafé Publieke Werken", new Location(51.58902669921447, 4.778966191319752)));
            poiList.Add(new POI("Gaudim", new Location(51.58787016771108, 4.780323389080719)));
            poiList.Add(new POI("Turks restaurant Lades", new Location(51.58714690392391, 4.779143217115772)));
            poiList.Add(new POI("Saigon Deli", new Location(51.58694973837543, 4.777447616791754)));
            poiList.Add(new POI("Restaurant Ume Breda", new Location(51.58547071614979, 4.774149991569626)));
            poiList.Add(new POI("Bali James - Indonesisch Restaurant", new Location(51.585164064186934, 4.7741982713318505)));
            poiList.Add(new POI("Brasserie Houtmarkt", new Location(51.586074014539534, 4.7778353467571435)));
            poiList.Add(new POI("PuiCk", new Location(51.58874376365351, 4.779369570312816)));
            poiList.Add(new POI("De jongens van zand en klei", new Location(51.58937368157827, 4.779911376533611)));
            poiList.Add(new POI("Bobbi's Bar", new Location(51.58973696360535, 4.780024029311926)));
            poiList.Add(new POI("Mr Moos bar & bistro", new Location(51.58897706761533, 4.776290394365218)));
        }
    }
    }
