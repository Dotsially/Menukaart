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
            static SightData()
            {
                SightList.Add(new Sight(SightList.Count,
                                        "Proeflokaal Bregje",
                                        "Proeflokaal Bregje is een restaurant gevestigd aan de haven van Breda, bekend om zijn 3-gangen keuzemenu van maandag tot donderdag voor €19,50 en van vrijdag tot zondag voor €21,50. Het restaurant heeft een gastvrije sfeer en biedt een breed scala aan gerechten, waaronder salades, hamburgers en goed gestoofd varkensvlees. Ze hebben ook een speciaal verwenarrangement voor december, waarbij je begint met een Peachtree Woo Woo cocktail en daarna geniet van een 3-gangen menu naar keuze.\r\nProeflokaal Bregje wordt geprezen voor zijn lekker en goed bereide gerechten, zijn uitstekende dienst en de speciale ervaring die ze bieden. Ze hebben ook faciliteiten voor groepen en speciale aanvragen, en zijn toegankelijk voor rolstoelgebruikers.\r\n",
                                        "https://proeflokaalbregje.nl/",
                                        new Image { Source = "proeflokaal_bergje.jpg" },
                                        new Location(51.58880586602344, 4.772186348316208)));

                SightList.Add(new Sight(SightList.Count,
                                        "Restaurant Chocolat",
                                        "Restaurant Chocolat is een creatief Frans restaurant dat bekend staat om zijn wereldkeuken. Het restaurant is gevuld met trendy meubilair en chocoladetinten, wat het een sexy plek maakt. De chef, Dorus Clement, speelt met een rijk smakenpalet en introduceert graag smaakmakers als vadouvan en yuzu in gerechten die Franse flair hebben.\r\nRestaurant Chocolat biedt zijn gasten de mogelijkheid om de Franse keuken te proberen, met goed bereide gerechten zoals Bouillabaisse, lekkere oesters en goed gekookte vis. Het wordt ook aanbevolen voor zijn vriendelijke personeel en de goede bediening. Het restaurant heeft een modern decor en is een Michelin-uitgekozen restaurant.\r\n",
                                        "http://www.restaurant-chocolat.nl/",
                                        new Image { Source = "restaurant_chocolat.png" },
                                        new Location(51.588693760346985, 4.774793660010751)));

                SightList.Add(new Sight(SightList.Count,
                                        "Gauchos",
                                        "Gauchos Grill in Breda is een restaurant dat bekend staat om zijn perfect gemarineerde spareribs. Ze bieden een All-you-can-eat concept waarbij je zoveel spareribs kunt eten als je wilt, geserveerd met een barbecuesaus. Het restaurant heeft een grote reputatie en heeft bestaan sinds 36 jaar, wat te danken is aan de hoge kwaliteiten van de producten en de absolute toewijding aan de verzorging van de gasten.\r\nDaarnaast biedt Gauchos Grill ook andere vlees- en vissoorten, wat het een verscheidenheid aan gerechten en smaken mogelijk maakt. Het restaurant heeft een gemoedelijke sfeer en is een populaire keuze voor zowel individuele bezoekers als groepen.\r\n",
                                        "http://www.gauchosgrill.nl/",
                                        new Image { Source = "gauchos.jpg" },
                                        new Location(51.58853681193229, 4.775966499185645)));

                SightList.Add(new Sight(SightList.Count,
                                        "Cafe Restaurant Zeezicht",
                                        "Cafe Restaurant Zeezicht in Breda is een gemoedelijke bar waar je na een bezoek aan de Sint Antoniuskathedraal een rustpauze kunt nemen. Ze bieden perfect zubereide salades, goede bitterballen en smakelijke nachochips. Ze hebben ook een breed scala aan bieren, wijn en whiskey om te proberen.\r\nHet personeel van Cafe Restaurant Zeezicht is geduldig en altijd bereid om vragen over de speisekaart te beantwoorden. Ze hebben een moderne sfeer en het restaurant heeft gemiddelde prijzen.\r\n",
                                        "https://www.zeezichtbreda.com/",
                                        new Image { Source = "cafe_restaurant_zeezicht.jpg" },
                                        new Location(51.587583899221336, 4.776652159008432)));

                SightList.Add(new Sight(SightList.Count,
                                        "'t Zusje Breda",
                                        "'t Zusje is een gezellig en sfeervol restaurant in het hart van Breda. Het restaurant is bekend om zijn uitgebreide keuze aan gerechten, waaronder lokaal geproduceerde producten en een selectie aan wijnen en bieren. De atmosfeer is ontspannen en ontvangend, waardoor het een perfecte plek is voor zowel zakelijke als persoonlijke ontmoetingen. De ambiance wordt verder verrijkt door de warme en hartelijke service van het personeel, die altijd hun best doen om hun gasten te laten voelen dat ze gewaardeerd worden.\r\nHet restaurant heeft een sterke reputatie voor zijn culinaire kwaliteit en creatieve presentatie van gerechten. De keuken is gevarieerd, met een accent op lokale ingrediënten en een innovatieve benadering van klassieke recepten. Daarnaast biedt het restaurant een uitgebreide wijnlijst, met een breed scala aan wijnen om aan te passen aan elke smaak en budget. De locatie in het centrum van Breda maakt 't Zusje ook een ideaal uitgangspunt voor diegenen die de stad verkennen, met tal van andere lokale winkels en eetgelegenheden in de buurt.\r\n",
                                        "https://zusje.nl/",
                                        new Image { Source = "t_zusje_breda.jpg" },
                                        new Location(51.59012869211109, 4.773792235800231)));

                SightList.Add(new Sight(SightList.Count,
                                        "McDonalds Centrum Breda",
                                        "De McDonald’s in Breda Centrum is een moderne winkelcentrum dat de stad Breda rijk is. Het centrum is ontworpen om de winkelervaring aangenaam en boeiend te maken, met een breed scala aan winkels en restaurants. Het centrum biedt een mix van grote internationale merken en lokale winkels, waardoor het een uitgebreide winkelervaring biedt voor de bewoners van Breda en de omgeving. Het McDonald's Centrum in Breda is niet alleen een plek om te winkelen en te eten, maar biedt ook een plek voor ontspanning en ontmoeting voor de gemeenschap. Het centrum is ook een populaire ontmoetingsplaats voor scholen en gemeenschapsorganisaties, wat het centrum een belangrijk onderdeel maakt van de sociale structuur van Breda.",
                                        "https://mcdonaldsrestaurant.nl/breda-centrum",
                                        new Image { Source = "mcdonalds_centrum_breda.jpg" },
                                        new Location(51.58604798603355, 4.775813127909616)));

                SightList.Add(new Sight(SightList.Count,
                                        "Restaurant Red Apple",
                                        "Red Apple is gevestigd aan het Van Coothplein in de binnenstad van Breda. Het plein heette vroeger het Wapenplein en ligt bij de Ginnekenpoort; één van de drie stadspoorten van Breda. Verschillende enthousiaste ondernemers hebben het plein tot een zeer gezellig en bourgondisch horecaplein gemaakt. Vanaf medio augustus 2016 maakt Red Apple hier deel van uit.\r\n“Een restaurant waar je goed kan eten voor een betaalbare prijs, zonder het gevoel te hebben je te moeten haasten. Gewoon gezellig tafelen en genieten van elkaars gezelschap en het eten. En natuurlijk uitstekende service!” Dit heeft het echtpaar Puhui Jin en Long Quan voor ogen bij het openen van hun nieuwe restaurant Red Apple. Beiden hebben een horeca achtergrond en besloten een nieuwe uitdaging aan te gaan.\r\n",
                                        "http://www.restaurantredapple.nl/",
                                        new Image { Source = "restaurant_red_apple.jpg" },
                                        new Location(51.58340851539009, 4.776927490219306)));

                SightList.Add(new Sight(SightList.Count,
                                        "'t Hart van Breda",
                                        "Restaurant 't Hart van Breda is een levendig en Bourgondisch café in Breda, bekend om zijn toegankelijke lunchkaart, ongeëvenaarde nacho's en verfrissende cocktails. Het restaurant heeft een groot terras waar je zowel in de zomer als winter kunt genieten. De neonletters van 't Hart van Breda zijn een herkenningspunt voor iedereen in Breda. In het restaurant kun je genieten van een breed scala aan gerechten, waaronder internationale keuze, goed bereide nacho's, smakelijk vlees, en bijzonder goede tapas. Het restaurant biedt ook een selectie aan bier en wijn aan.\r\n't Hart van Breda staat bekend om zijn vriendelijke en prompt bediening, waardoor klanten een entspannende ervaring hebben. Het restaurant heeft een gemoedelijke atmosfeer en heeft hoge beoordelingen ontvangen van klanten.\r\n",
                                        "https://www.hartvanbreda.nl/",
                                        new Image { Source = "t_hart_van_breda.jpg" },
                                        new Location(51.587801736941444, 4.7772082021544655)));

                SightList.Add(new Sight(SightList.Count,
                                        "In Kannen & Kruiken",
                                        "Restaurant In Kannen & Kruiken in Breda is een gezellige plek waar je heerlijke koffie, ontbijt, lunch en een lekkere borrel kunt genieten. Het restaurant biedt zowel binnen als buiten gelegenheid, met een groene stadstuin waar je je gemakkelijk kunt ontspannen. Het team van het restaurant werkt samen met lokale leveranciers om de beste drankjes en gerechten te leveren. Ze bieden veel vegetarische en veganistische opties en zijn aandachtig voor allergieën, waardoor iedereen van de lekkere maaltijden kan genieten.",
                                        "http://inkannenenkruikenbreda.nl/",
                                        new Image { Source = "in_kannen_en_kruiken.jpg" },
                                        new Location(51.58888803177311, 4.778856125836694)));

                SightList.Add(new Sight(SightList.Count,
                                        "Rhodos Grieks Specialiteiten",
                                        "Restaurant Rhodos Grieks Specialiteiten in Breda, een van de top 10 restaurants in de stad, is een plek waar je nieuwe smaken van de Griekse en Middellandse keuken kunt proeven. Het restaurant is bekend om zijn lekker bereide Gyros, Kebabs en Tapas. Een bijzonder aanbevolen dish is de Coupe Dänemark. Het restaurant heeft ook een uitgebreide wijnkeuze, en het biedt ook een schatplichtige koffie.\r\nHet restaurant heeft een gemoedelijke atmosfeer en een creatief personeel. Het biedt een snelle bediening en democratische prijzen.\r\n",
                                        "http://www.rhodos-restaurant.nl/",
                                        new Image { Source = "rhodos_griekse_specialiteiten.jpg" },
                                        new Location(51.58919071517029, 4.779758309814044)));

                SightList.Add(new Sight(SightList.Count,
                                        "Con Fuego",
                                        "Een restaurant voor iedereen...\r\n...maar, om heel eerlijk te zijn, vooral voor vleesliefhebbers. Al zeggen ze het zelf, Con Fuego serveert de mooiste steaks van Breda. Natuurlijk staan er nog andere gerechten op de kaart, maar het is het vlees dat hun het meest na aan het hart ligt. \r\n\r\nEen plek voor iedereen die houdt van goed gezelschap, mooie wijnen en mooie ingrediënten die zonder poespas, maar met veel vakmanschap en ervaring worden bereid.  \r\n",
                                        "http://www.restaurantconfuego.nl/",
                                        new Image { Source = "con_fuego.png" },
                                        new Location(51.58856488552723, 4.776712915133945)));

                SightList.Add(new Sight(SightList.Count,
                                        "De Colonie",
                                        "Restaurant, Paviljoen De Colonie is samen met hotel De Klok gevestigd in het monumentale pand aan de Grote Markt in Breda. Het restaurant heeft een unieke ligging met uitzicht op de markt en de Grote Kerk van Breda. Zij ontvangen u graag in deze tijdloze, unieke ambiance om u te laten genieten van gulle gastvrijheid en smakelijke culinaire creaties. U zult zich bij hen snel thuis voelen omdat De Colonie bekend staat om haar persoonlijke en gastvrije aanpak waarbij u als gast centraal staat.\r\nU bent van harte welkom voor een ontbijt, snelle of uitgebreide lunch, een heerlijk diner of een gezellige borrel met vrienden of zakenrelaties. Maar ook als u eens iets anders wilt, zit u bij De Colonie goed.\r\n",
                                        "https://breda.colonie.nl/",
                                        new Image { Source = "de_colonie.jpg" },
                                        new Location(51.58859291205177, 4.776424216261193)));

                SightList.Add(new Sight(SightList.Count,
                                        "Humphrey's Restaurants",
                                        "In het centrum van Breda, op de hoek van de Catharinastraat en het Kasteelplein, bevindt zich Humphrey’s Breda. Dit restaurant ligt op een steenworp afstand van de Grote Markt en heeft een prachtig uitzicht op de beroemde Onze Lieve-Vrouwekerk.\r\nKenmerkend voor het restaurant in Breda is de hoge ruimte met daarin zijn prachtige vide. Door zijn vele knusse hoekjes is deze eetgelegenheid uitermate geschikt voor een gezellig intiem diner, maar bestaat er ook de mogelijkheid om met een groot gezelschap te tafelen. Het restaurant heeft een stijlvol eigentijds interieur dat is geïnspireerd op de klassieke Parijse grand cafés en brasseries met houten vloerdelen, warm tapijt, veel kleur, comfortabele stoelen en banken en sfeervolle verlichting. De aanwezigheid van veel groen roept een ‘parkgevoel’ op wat zorgt voor een unieke beleving.\r\nIn de zomermaanden beschikt het restaurant over een terras midden op het Kasteelplein waar het op een mooie zomeravond goed toeven is.\r\n\r\n",
                                        "https://www.humphreys.nl/restaurants/humphreys-breda",
                                        new Image { Source = "humphreys_restaurants.jpg" },
                                        new Location(51.58963954248478, 4.77660404822756)));

                SightList.Add(new Sight(SightList.Count,
                                        "Tapasbar Plan B",
                                        "Tapasbar? Nee een Hapasbar! Uniek en een in zijn soort probeert Plan B een alternatief te verzorgen. Om de hoek van de grote markt, aan het Kasteelplein ligt de gezellige zaak. Knus, warm en vooral ongedwongen, dat is de sfeer die ze uitstralen.",
                                        "http://www.tapasbarplanb.nl/",
                                        new Image { Source = "tapasbar_plan_b.jpg" },
                                        new Location(51.58973664707036, 4.776639134950073)));

                SightList.Add(new Sight(SightList.Count,
                                        "Foodhall Breda",
                                        "Foodhall Breda is een ontmoetingsplek en een echte ‘place-to-be’, waar je met vrienden, familie of collega’s kunt eten, borrelen en socializen. Een sfeervolle, dynamische uitgaansgelegenheid zonder het formele karakter van een restaurant. Een plek waar je in een easy-going, ontspannen sfeer kunt genieten van al het lekkers dat onze keukens en de bar/cocktailbar te bieden hebben!\r\nFoodhall Breda heeft iets voor ieder budget en gelegenheid. En natuurlijk voor iedere smaak. Onder één dak vind je 12 keukens met een grote variatie aan gerechten en drankjes uit de verschillende windstreken.\r\n",
                                        "http://www.foodhallbreda.nl/",
                                        new Image { Source = "foodhall_breda.jpg" },
                                        new Location(51.58950942648919, 4.775308436250771)));

                SightList.Add(new Sight(SightList.Count,
                                        "La Cubanita",
                                        "La Cubanita is een tapasrestaurant volgens een vaste formule met ruim 50 vestigingen door heel Nederland. Deze formule wordt bewaakt, ondersteund en uitgediept door de franchiseorganisatie. La Cubanita staat voor zwoele salsaklanken, spannende cocktails en heerlijke tapas. In een unieke Cubaanse omgeving kun je genieten van de mooie dingen des levens. Het motto van La Cubanita is niet voor niets: La vida es un carnaval!",
                                        "http://www.lacubanita.nl/tapas-breda",
                                        new Image { Source = "la_cubanita.jpg" },
                                        new Location(51.58971660457123, 4.773869994193707)));

                SightList.Add(new Sight(SightList.Count,
                                        "Popocatepetl Breda",
                                        "Een avondje POPO wordt gekenmerkt door de uitbundige en levendige sfeer. POPO is vernoemd naar de vulkaan Popocatepetl bij Mexico City. Het betekent letterlijk ‘daar waar de aarde heet wordt’.\r\nPOPO staat bekend om haar enthousiaste bediening, goede cocktails en heerlijke Mexicaanse gerechten. Alles wordt dagelijks vers en met liefde bereid.\r\n",
                                        "http://www.popobreda.nl/",
                                        new Image { Source = "popocatepetl_breda.jpg" },
                                        new Location(51.58953663027294, 4.774588826208994)));

                SightList.Add(new Sight(SightList.Count,
                                        "Geisha Lounge",
                                        "Een bezoek aan Geisha Lounge staat garant voor 'smaak', 'beleving' & 'spanning'. Traditionele Japanse keuken vermengd met een vleugje getuigenis. De warme gerechten worden à la carte bereid en de sushi wordt bereid met de meest verse en natuurlijke ingrediënten. Behalve de basisingrediënten worden vrijwel alle sauzen volgens ons eigen recept bereid. Dit zorgt voor een exclusieve smaak waar alleen bij Geisha Lounge van genoten kan worden. Daarnaast bieden ze een uitgebreide cocktailkaart aan, van echte klassieke cocktails tot exotische originele creaties.\r\nDe sushirechten bij Geisha Lounge worden vaak omschreven als revolutionair en verrassend. Variatie, veelzijdigheid en heerlijke smaak zijn dan ook de uitgangspunten voor deze specialiteiten. Met smaaksensaties als de ‘rib-eye crabmeat roll’ of de verrassende ‘mango tempura garnalen roll’ wordt uw diner een onvergetelijke ervaring. Hoewel er voor het diner en de lunch een 'sushi & grill all you can eat'-concept wordt gehanteerd, krijgen de afzonderlijke gerechten wel een à la carte-aanpak die in een hoog tempo wordt geserveerd.\r\n",
                                        "http://www.geishalounge.nl/",
                                        new Image { Source = "geisha_lounge.jpg" },
                                        new Location(51.5892066755368, 4.773912909537846)));

                SightList.Add(new Sight(SightList.Count,
                                        "Suikerkist",
                                        "Het restaurant Suikerkist in Breda is een bijzonder plekje waar gastronomie en sfeer samenkomen. De sfeer is warm en uitnodigend, met een interieur dat zowel traditioneel als modern is. De decoratie is een mix van oude en nieuwe elementen, wat een unieke en opwindende ervaring oplevert. De keuken van Suikerkist is bekend om zijn creatieve en innovatieve gerechten, die de zintuigen aanspreken met hun uiterst smakelijke en visueel aantrekkelijke presentatie. De gasten kunnen hier genieten van een diner dat zowel hun ogen als hun smaakpapillen verruikt.\r\nSuikerkist is niet alleen een restaurant, maar ook een plek om te ontspannen en te genieten van de ambiance. De geluiden van de keuken, de zachte muziek in de achtergrond en de warme en vriendelijke service dragen bij aan een ervaring die verder gaat dan het eten zelf. Het restaurant heeft een rustige atmosfeer, perfect voor een romantisch diner of een ontspannen diner na een lange dag. De gasten kunnen hier genieten van een diner dat niet alleen hun maag, maar ook hun geest en zintuigen vult. Het restaurant Suikerkist in Breda is een ontmoetingsplaats voor zowel de ogen als de geest, waar gasten een onvergetelijke ervaring kunnen genieten.\r\n",
                                        "http://www.suikerkist.nl/",
                                        new Image { Source = "suikerkist.jpg" },
                                        new Location(51.589563293172816, 4.774057748824509)));

                SightList.Add(new Sight(SightList.Count,
                                        "Eetcafé Publieke Werken",
                                        "Al 22 jaar is Café Publieke Werken een begrip in Breda. De ongedwongen sfeer, oprechte gastvrijheid en het lekker eten & drinken maken ‘PW’ tot een café waar iedereen zich thuis voelt. Na de verbouwing in augustus 2015 staan er maar liefst 15 bieren op tap en is er nog veel meer keuze op fles! Wanneer kom jij deze proeven?",
                                        "http://www.cafepubliekewerken.com/",
                                        new Image { Source = "eetcafe_publieke_werken.jpg" },
                                        new Location(51.58902669921447, 4.778966191319752)));

                SightList.Add(new Sight(SightList.Count,
                                        "Gaudim",
                                        "Catalaans eten en drinken, dat is genieten. Van mooie gerechten, eerlijke ingrediënten en pure smaken. Van ‘alles tussen berg en zee, ‘muntanya y mar’, zoals de Catalanen dat zeggen. En ook van een ongedwongen sfeer, goed gezelschap, echte gastronomie en vakmanschap. Catalaans genieten, dat is Gaudím.",
                                        "http://www.gaudim.nl/",
                                        new Image { Source = "gaudim.jpg" },
                                        new Location(51.58787016771108, 4.780323389080719)));

                SightList.Add(new Sight(SightList.Count,
                                        "Turks restaurant Lades",
                                        "Het Turks restaurant Lades in Breda is een bijzonder plekje waar de smaak van het Oosten wordt gecombineerd met de lokale cultuur. Het restaurant biedt een unieke dining ervaring met zijn authentieke Turkse gerechten, vervaardigd met hoogwaardige ingrediënten. De sfeer in het restaurant is warm en welkom, met een zachte lichting en traditionele Turkse decoratie. De menukaart is uitgebreid en variabel, met een selectie van verschillende gerechten die de smaak van de Oost-Europese en Midden-Oosterse keuken weerspiegelen. Het restaurant heeft een uitgebreide wijn- en drankkaart, waardoor het een perfecte plek is voor zowel eten als drinken.\r\nLades is niet alleen bekend om zijn gastronomische kwaliteiten, maar ook om zijn uitstekende service. Het personeel is vriendelijk en professioneel, en ze nemen zich de tijd om zorgvuldig aan de klant te voldoen. De locatie van het restaurant in het hart van Breda maakt het ook een ideale plek voor zowel lokale bewoners als toeristen die de smaak van het Oosten willen proeven. Het restaurant biedt een ontspannende en plezierige ervaring, met een sfeer die je herinnert aan een traditioneel Turkse huis.\r\n",
                                        "http://www.restaurantlades.nl/",
                                        new Image { Source = "turks_restaurant_lades.jpg" },
                                        new Location(51.58714690392391, 4.779143217115772)));

                SightList.Add(new Sight(SightList.Count,
                                        "Restaurant Ume Breda",
                                        "Restaurant Ume Breda in Breda is een ontmoetingsplaats voor zowel lokale als internationale gasten. Het restaurant biedt een sfeer van comfort en luxe, met een uitgebreide menu dat zowel traditionele als moderne Breda-kokkunst combineert. De decoratie van het restaurant is zorgvuldig ontworpen om een gevoel van warmte en gemoedsrust te creëren, met een combinatie van moderne en klassieke elementen die de aandacht trekken. De smaakvolle maaltijden, gekoppeld aan een uitgebreide wijnlijst, maken van Restaurant Ume Breda een onvergetelijke dining-ervaring.\r\nHet restaurant heeft een uitstekende reputatie en heeft talloze prijzen gewonnen voor zijn culinaire prestaties. Het personeel is vriendelijk en aandachtig, en zorgt ervoor dat elke gast zich op zijn gemak voelt. De locatie in het hart van Breda maakt het een ideale keuze voor zowel zakelijke als privé-evenementen. Restaurant Ume Breda is meer dan gewoon een restaurant; het is een ervaring die de zintuigen aanspreekt en een herinnering creëert die lang in het geheugen blijft.\r\n",
                                        "http://www.restaurantume.nl/",
                                        new Image { Source = "restaurant_ume_breda.png" },
                                        new Location(51.58547071614979, 4.774149991569626)));

                SightList.Add(new Sight(SightList.Count,
                                        "Bali James - Indonesisch Restaurant",
                                        "Bali James is een Indonesisch restaurant in Breda, gespecialiseerd in het serveren van authentieke Indonesische gerechten. Het restaurant biedt een breed scala aan gerechten, waaronder een indrukwekkende rijsttafel die samengesteld is om een grote variëteit in smaken in volle harmonie bij elkaar te brengen. Alles wordt ambachtelijk bereid met authentieke verse kruiden en ingrediënten, wat een arbeidsintensieve maar gewaardeerde toevoeging is aan de smaakbeleving.\r\nDaarnaast biedt Bali James ook cateringdiensten aan, wat het uitstekend geschikt maakt voor grote groepen mensen. Sinds 1978 verzorgt het restaurant de catering aan gezelschappen van 20 tot 2000 personen. Voor klanten die onderweg zijn, biedt het restaurant de mogelijkheid om maaltijden mee te nemen.\r\n",
                                        "http://www.restaurantbali.com/",
                                        new Image { Source = "bali_james_indonesisch_restaurant.jpg" },
                                        new Location(51.585164064186934, 4.7741982713318505)));

                SightList.Add(new Sight(SightList.Count,
                                        "Brasserie Houtmarkt",
                                        "Brasserie Houtmarkt in Breda is een bekende brouwerij en bierbar die een breed scala aan bieren aanbiedt. De brouwerij heeft een onderscheidende, authentieke sfeer met een rijke geschiedenis. Het biedt een rustige, ontspannende omgeving waar bezoekers hun eigen tijd kunnen doorbrengen, terwijl ze genieten van een vers bier en eventueel een hapje van het brouwersgerecht. De Brasserie Houtmarkt is niet alleen een plek om te drinken, maar ook een plek om te ontmoeten en te genieten van de lokale gemeenschap.\r\nDe Brasserie Houtmarkt staat bekend om zijn hoogwaardige bieren en het biedt een breed scala aan bierstijlen. Ze zijn beroemd voor hun krachtige Belgische en Duits stijl bieren, maar ze hebben ook een selectie van lichtere, fruitige bieren die perfect zijn voor een lichte ontspanning of als een lichte maaltijd. De brouwerij is ook bekend om haar brouwersgerechten, die worden bereid met lokale en seizoensgebonden ingrediënten. De Brasserie Houtmarkt is een populaire keuze voor zowel lokale bewoners als toeristen die op zoek zijn naar een authentieke bierbar ervaring.\r\n",
                                        "http://www.brasseriehoutmarkt.nl/",
                                        new Image { Source = "brasserie_houtmarkt.jpg" },
                                        new Location(51.586074014539534, 4.7778353467571435)));

                SightList.Add(new Sight(SightList.Count,
                                        "PuiCk",
                                        "Bij PuiCk staat alles in het teken van genieten en beleven.  \r\nDe eetzaak, gesitueerd in de Veemarktstraat (trouwens de mooiste straat van centrum Breda) met haar diversiteit aan winkels, richt zich als familie bedrijf op creativiteit qua interieur, eten, drinken en sfeer. Ze hebben een huiskamer gecreëerd met jaren 70 design stoelen en lampen, wat planten, een gezellige bar en lekkere zitjes waardoor je doet vergeten dat je midden in de Bredase binnenstad zit. \r\n",
                                        "http://www.puick.nl/",
                                        new Image { Source = "puick.jpg" },
                                        new Location(51.58874376365351, 4.779369570312816)));

                SightList.Add(new Sight(SightList.Count,
                                        "De Jongens van Zand & Klei",
                                        "Restaurant De Jongens van Zand & Klei, gevestigd aan de Veemarktstraat 76 in Breda, heeft een rijke geschiedenis van 120 jaar aardappelervaring. Het restaurant is bekend om zijn lekkerste en meest smaakvolle aardappelgerechten, die worden bereid door de 'jongens' die de aardappels zelf verbouwen. De aardappel speelt de hoofdrol in het menu, dat zowel regionaal als klassiek en soms een beetje exotisch is.\r\nDe Jongens van Zand & Klei biedt een menu dat niet ingewikkeld is, maar toch anders is. Er zijn verschillende toppings beschikbaar voor hun crunchy potatobasket, en ze hebben ook een aardappeltosti op het menu. De aardappel is dus de ster in het restaurant, en de gasten kunnen ervan genieten.\r\n",
                                        "http://www.zandenklei.nl/",
                                        new Image { Source = "de_jongens_van_zand_en_klei.jpg" },
                                        new Location(51.58937368157827, 4.779911376533611)));

                SightList.Add(new Sight(SightList.Count,
                                        "Bobbi's Bar",
                                        "Bobbi's Bar in Breda is een gewaardeerde plek voor ontspanning en ontmoeting. Het restaurant biedt een uitgebreid menu dat zowel lokale als internationale gerechten omvat. De sfeer is ontspannen en vriendelijk, en de service is altijd van hoge kwaliteit. Het interieur van het restaurant is gezellig en warm, met een moderne decorstijl die zowel jong als oud aanspreekt.\r\nHet menu van Bobbi's Bar is een combinatie van traditionele en moderne keuken, met een sterke nadruk op lokale ingrediënten. De gerechten zijn zorgvuldig bereid en leveren een combinatie van smaken die zowel zicht als proef aanspreken. Het restaurant is ook bekend om zijn uitgebreide wijnlijst, die zowel kenners als nieuwe drinkers kan overtuigen.\r\n",
                                        "http://www.bobbisbar.nl/",
                                        new Image { Source = "bobbis_bar.jpg" },
                                        new Location(51.58973696360535, 4.780024029311926)));

                SightList.Add(new Sight(SightList.Count,
                                        "Mr Moos bar & bistro",
                                        "Restaurant Mr. Moos Bar & Bistro is een populaire plek in Breda, bekend om zijn uitzonderlijke uitzicht op de Grote Kerk. Dit restaurant trekt veel klanten aan met zijn lekker smakende hamburgers, bijzonder goed geserveerd carpaccio en uitstekende salades. Bovendien wordt hier een uitstekend bereid tiramisu geserveerd. De klanten van Mr. Moos Bar & Bistro waardeeren ook de warme en vriendelijke sfeer en het uitstekende servicepersoneel. De klanten komen vaak terug vanwege de spectaculaire atmosfeer.",
                                        "http://www.mrmoos.nl/",
                                        new Image { Source = "mr_moos_bar_en_bistro.png" },
                                        new Location(51.58897706761533, 4.776290394365218)));
            }
        }
    }
}