using Menukaart.DataManagement.DataTypes;
namespace Menukaart.DataManagement
{
    namespace Menukaart.Model
    {
        public class SightData
        {
            public static List<Sight> SightList { get; } = new List<Sight>();
            static SightData()
            {
                SightList.Add(new Sight(SightList.Count,
                                        "Proeflokaal Bregje",
                                        "Proeflokaal Bregje is a restaurant located at the harbor of Breda, known for its 3-course choice menu from Monday to Thursday for €19.50 and from Friday to Sunday for €21.50. The restaurant has a welcoming atmosphere and offers a wide range of dishes, including salads, burgers, and well-stewed pork. They also have a special treat package for December, starting with a Peachtree Woo Woo cocktail followed by a 3-course menu of your choice.\r\nProeflokaal Bregje is praised for its tasty and well-prepared dishes, excellent service, and the special experience they provide. They also have facilities for groups and special requests and are wheelchair accessible.\r\n",
                                        "https://proeflokaalbregje.nl/",
                                        new Image { Source = "proeflokaal_bergje.jpg" },
                                        new Location(51.58880586602344, 4.772186348316208)));

                SightList.Add(new Sight(SightList.Count,
                                        "Restaurant Chocolat",
                                        "Restaurant Chocolat is a creative French restaurant known for its global cuisine. The restaurant is filled with trendy furniture and chocolate tones, creating a stylish atmosphere. Chef Dorus Clement plays with a rich palette of flavors and enjoys introducing unique elements like vadouvan and yuzu into dishes that exude French flair.\r\nRestaurant Chocolat offers its guests the opportunity to experience French cuisine, with well-prepared dishes such as Bouillabaisse, delicious oysters, and perfectly cooked fish. It is also recommended for its friendly staff and excellent service. The restaurant features a modern decor and holds the distinction of being a Michelin-selected establishment.\r\n",
                                        "http://www.restaurant-chocolat.nl/",
                                        new Image { Source = "restaurant_chocolat.png" },
                                        new Location(51.588693760346985, 4.774793660010751)));

                SightList.Add(new Sight(SightList.Count,
                                        "Gauchos",
                                        "Gauchos Grill in Breda is a restaurant known for its perfectly marinated spare ribs. They offer an All-you-can-eat concept where you can eat as many spare ribs as you want, served with barbecue sauce. The restaurant has a great reputation and has been around for 36 years, thanks to the high quality of products and absolute dedication to guest care.\r\nIn addition, Gauchos Grill also offers other meat and fish options, providing a variety of dishes and flavors. The restaurant has a cozy atmosphere and is a popular choice for both individual visitors and groups.\r\n",
                                        "http://www.gauchosgrill.nl/",
                                        new Image { Source = "gauchos.jpg" },
                                        new Location(51.58853681193229, 4.775966499185645)));

                SightList.Add(new Sight(SightList.Count,
                                        "Cafe Restaurant Zeezicht",
                                        "Cafe Restaurant Zeezicht in Breda is a cozy bar where you can take a break after visiting the Sint Antoniuskathedraal. They offer perfectly prepared salads, good bitterballen, and tasty nachos. They also have a wide range of beers, wines, and whiskies to try.\r\nThe staff at Cafe Restaurant Zeezicht is patient and always willing to answer questions about the menu. They have a modern atmosphere, and the restaurant has average prices.\r\n",
                                        "https://www.zeezichtbreda.com/",
                                        new Image { Source = "cafe_restaurant_zeezicht.jpg" },
                                        new Location(51.587583899221336, 4.776652159008432)));

                SightList.Add(new Sight(SightList.Count,
                                        "'t Zusje Breda",
                                        "'t Zusje is a cozy and atmospheric restaurant in the heart of Breda. The restaurant is known for its extensive selection of dishes, including locally sourced products and a variety of wines and beers. The atmosphere is relaxed and welcoming, making it a perfect place for both business and personal gatherings. The ambiance is further enriched by the warm and cordial service of the staff, who always strive to make their guests feel appreciated.\r\nThe restaurant has a strong reputation for its culinary quality and creative presentation of dishes. The cuisine is diverse, with an emphasis on local ingredients and an innovative approach to classic recipes. In addition, the restaurant offers an extensive wine list, with a wide range of wines to suit every taste and budget. The central location in Breda also makes 't Zusje an ideal starting point for those exploring the city, with numerous other local shops and eateries nearby.\r\n",
                                        "https://zusje.nl/",
                                        new Image { Source = "t_zusje_breda.jpg" },
                                        new Location(51.59012869211109, 4.773792235800231)));

                SightList.Add(new Sight(SightList.Count,
                                        "McDonalds Centrum Breda",
                                        "McDonald’s in Breda Centrum is a modern shopping center in the city of Breda. The center is designed to make the shopping experience enjoyable and engaging, with a wide range of shops and restaurants. The center offers a mix of large international brands and local stores, providing a comprehensive shopping experience for the residents of Breda and the surrounding area. McDonald's Centrum in Breda is not just a place to shop and eat but also provides a space for relaxation and community gatherings. The center is also a popular meeting place for schools and community organizations, making it an important part of the social structure of Breda.",
                                        "https://mcdonaldsrestaurant.nl/breda-centrum",
                                        new Image { Source = "mcdonalds_centrum_breda.jpg" },
                                        new Location(51.58604798603355, 4.775813127909616)));

                SightList.Add(new Sight(SightList.Count,
                                        "Restaurant Red Apple",
                                        "Red Apple is located at Van Coothplein in the city center of Breda. The square was formerly called Wapenplein and is near the Ginnekenpoort, one of the three city gates of Breda. Several enthusiastic entrepreneurs have made the square a very cozy and Burgundian hospitality square. Since mid-August 2016, Red Apple has been part of this.\r\n“A restaurant where you can eat well at an affordable price, without feeling rushed. Just enjoy a cozy meal and each other's company and food. And of course, excellent service!” This is the vision of the couple Puhui Jin and Long Quan when opening their new restaurant Red Apple. Both have a background in hospitality and decided to take on a new challenge.\r\n",
                                        "http://www.restaurantredapple.nl/",
                                        new Image { Source = "restaurant_red_apple.jpg" },
                                        new Location(51.58340851539009, 4.776927490219306)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "'t Hart van Breda",
                                        "Restaurant 't Hart van Breda is a lively and Burgundian café in Breda, known for its accessible lunch menu, unmatched nachos, and refreshing cocktails.The restaurant has a large terrace where you can enjoy yourself both in summer and winter.The neon letters of 't Hart van Breda are a landmark for everyone in Breda. In the restaurant, you can enjoy a wide range of dishes, including international choices, well-prepared nachos, tasty meat, and exceptionally good tapas. The restaurant also offers a selection of beer and wine.\r\n't Hart van Breda is known for its friendly and prompt service, providing customers with a relaxing experience.The restaurant has a cozy atmosphere and has received high ratings from customers.\r\n",
                                        "https://www.hartvanbreda.nl/",
                                        new Image { Source = "t_hart_van_breda.jpg" },
                                        new Location(51.587801736941444, 4.7772082021544655)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "In Kannen & Kruiken",
                                        "Restaurant In Kannen & Kruiken in Breda is a cozy place where you can enjoy delicious coffee, breakfast, lunch, and a nice drink. The restaurant offers both indoor and outdoor seating, with a green city garden where you can easily relax. The restaurant's team collaborates with local suppliers to provide the best drinks and dishes. They offer many vegetarian and vegan options and are attentive to allergies, allowing everyone to enjoy the tasty meals.",
                                        "http://inkannenenkruikenbreda.nl/",
                                        new Image { Source = "in_kannen_en_kruiken.jpg" },
                                        new Location(51.58888803177311, 4.778856125836694)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "Rhodos Grieks Specialiteiten",
                                        "Restaurant Rhodos Grieks Specialiteiten in Breda, one of the top 10 restaurants in the city, is a place where you can taste new flavors of Greek and Mediterranean cuisine. The restaurant is known for its well-prepared Gyros, Kebabs, and Tapas. A highly recommended dish is the Coupe Dänemark. The restaurant also has an extensive wine selection and offers a tribute coffee.\r\nThe restaurant has a cozy atmosphere and creative staff. It provides fast service and democratic prices.\r\n",
                                        "http://www.rhodos-restaurant.nl/",
                                        new Image { Source = "rhodos_griekse_specialiteiten.jpg" },
                                        new Location(51.58919071517029, 4.779758309814044)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "Con Fuego",
                                        "A restaurant for everyone...\r\n...but, to be very honest, especially for meat lovers. Even though they say it themselves, Con Fuego serves the finest steaks in Breda. Of course, there are other dishes on the menu, but it's the meat that they hold most dear.\r\n\r\nA place for anyone who loves good company, fine wines, and beautiful ingredients prepared without fuss but with a lot of craftsmanship and experience. \r\n",
                                        "http://www.restaurantconfuego.nl/",
                                        new Image { Source = "con_fuego.png" },
                                        new Location(51.58856488552723, 4.776712915133945)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "De Colonie",
                                        "Restaurant, Paviljoen De Colonie is located together with hotel De Klok in the monumental building on the Grote Markt in Breda. The restaurant has a unique location with a view of the market and the Grote Kerk of Breda. They welcome you in this timeless, unique ambiance to let you enjoy generous hospitality and tasty culinary creations. You will quickly feel at home with them because De Colonie is known for its personal and hospitable approach, where you as a guest are central.\r\nYou are welcome for breakfast, a quick or extensive lunch, a delicious dinner, or a cozy drink with friends or business relations. But also, if you want something different, De Colonie is the right place for you.\r\n",
                                        "https://breda.colonie.nl/",
                                        new Image { Source = "de_colonie.jpg" },
                                        new Location(51.58859291205177, 4.776424216261193)));

                SightList.Add(new Sight(SightList.Count,
                                        "Humphrey's Restaurants",
                                        "In the center of Breda, on the corner of Catharinastraat and Kasteelplein, you will find Humphrey’s Breda. This restaurant is a stone's throw away from the Grote Markt and has a beautiful view of the famous Onze Lieve-Vrouwekerk.\r\nCharacteristic for the restaurant in Breda is the high space with its beautiful mezzanine. With its many cozy corners, this dining establishment is ideal for a cozy intimate dinner, but there is also the possibility to dine with a large group. The restaurant has a stylish contemporary interior inspired by the classic Parisian grand cafes and brasseries with wooden floorboards, warm carpet, lots of color, comfortable chairs and benches, and atmospheric lighting. The presence of a lot of green creates a 'park feeling', providing a unique experience.\r\nIn the summer months, the restaurant has a terrace in the middle of Kasteelplein where it is good to stay on a beautiful summer evening.\r\n\r\n",
                                        "https://www.humphreys.nl/restaurants/humphreys-breda",
                                        new Image { Source = "humphreys_restaurants.jpg" },
                                        new Location(51.58963954248478, 4.77660404822756)));

                SightList.Add(new Sight(SightList.Count,
                                        "Tapasbar Plan B",
                                        "Tapas bar? No, a Hapas bar! Unique and one of its kind, Plan B tries to provide an alternative. Around the corner from the Grote Markt, on Kasteelplein, is the cozy place. Cozy, warm, and especially relaxed, that is the atmosphere they radiate.",
                                        "http://www.tapasbarplanb.nl/",
                                        new Image { Source = "tapasbar_plan_b.jpg" },
                                        new Location(51.58973664707036, 4.776639134950073)));

                SightList.Add(new Sight(SightList.Count,
                                        "Foodhall Breda",
                                        "Foodhall Breda is a meeting place and a real 'place-to-be,' where you can eat, drink, and socialize with friends, family, or colleagues. A cozy, dynamic nightlife venue without the formal character of a restaurant. A place where you can enjoy all the goodies that our kitchens and the bar/cocktail bar have to offer in an easy-going, relaxed atmosphere!\r\nFoodhall Breda has something for every budget and occasion. And, of course, for every taste. Under one roof, you will find 12 kitchens with a wide variety of dishes and drinks from different regions.\r\n",
                                        "http://www.foodhallbreda.nl/",
                                        new Image { Source = "foodhall_breda.jpg" },
                                        new Location(51.58950942648919, 4.775308436250771)));


                SightList.Add(new Sight(SightList.Count,
                                        "La Cubanita",
                                        "La Cubanita is a tapas restaurant according to a fixed formula with more than 50 locations throughout the Netherlands. This formula is guarded, supported, and deepened by the franchise organization. La Cubanita stands for sultry salsa sounds, exciting cocktails, and delicious tapas. In a unique Cuban environment, you can enjoy the beautiful things in life. The motto of La Cubanita is not for nothing: La vida es un carnaval!",
                                        "http://www.lacubanita.nl/tapas-breda",
                                        new Image { Source = "la_cubanita.jpg" },
                                        new Location(51.58971660457123, 4.773869994193707)));

                SightList.Add(new Sight(SightList.Count,
                                        "Popocatepetl Breda",
                                        "An evening at POPO is characterized by the exuberant and lively atmosphere. POPO is named after the Popocatepetl volcano near Mexico City. It literally means 'where the earth becomes hot.'\r\nPOPO is known for its enthusiastic service, good cocktails, and delicious Mexican dishes. Everything is prepared fresh daily with love.\r\n",
                                        "http://www.popobreda.nl/",
                                        new Image { Source = "popocatepetl_breda.jpg" },
                                        new Location(51.58953663027294, 4.774588826208994)));

                SightList.Add(new Sight(SightList.Count,
                                        "Geisha Lounge",
                                        "A visit to Geisha Lounge guarantees 'taste', 'experience' & 'excitement'. Traditional Japanese cuisine mixed with a touch of testimony. The warm dishes are prepared à la carte, and the sushi is made with the freshest and most natural ingredients. In addition to the basic ingredients, almost all sauces are prepared according to our own recipe. This ensures an exclusive taste that can only be enjoyed at Geisha Lounge. In addition, they offer an extensive cocktail menu, from real classic cocktails to exotic original creations.\r\nThe sushi dishes at Geisha Lounge are often described as revolutionary and surprising. Variation, versatility, and delicious taste are the principles for these specialties. With taste sensations like the 'rib-eye crabmeat roll' or the surprising 'mango tempura shrimp roll,' your dinner becomes an unforgettable experience. Although a 'sushi & grill all you can eat' concept is used for dinner and lunch, the individual dishes are served in an à la carte approach that is served at a high pace.\r\n",
                                        "http://www.geishalounge.nl/",
                                        new Image { Source = "geisha_lounge.jpg" },
                                        new Location(51.5892066755368, 4.773912909537846)));

                SightList.Add(new Sight(SightList.Count,
                                        "Suikerkist",
                                        "The restaurant Suikerkist in Breda is a special place where gastronomy and atmosphere come together. The atmosphere is warm and inviting, with an interior that is both traditional and modern. The decoration is a mix of old and new elements, creating a unique and exciting experience. The kitchen of Suikerkist is known for its creative and innovative dishes that appeal to the senses with their extremely tasty and visually appealing presentation. Guests can enjoy a dinner here that delights both their eyes and taste buds.\r\nSuikerkist is not just a restaurant but also a place to relax and enjoy the ambiance. The sounds of the kitchen, the soft music in the background, and the warm and friendly service contribute to an experience that goes beyond the food itself. The restaurant has a quiet atmosphere, perfect for a romantic dinner or a relaxed meal after a long day. Guests can enjoy a dinner that fills not only their stomach but also their mind and senses. The restaurant Suikerkist in Breda is a meeting place for both the eyes and the spirit, where guests can enjoy an unforgettable experience.\r\n",
                                        "http://www.suikerkist.nl/",
                                        new Image { Source = "suikerkist.jpg" },
                                        new Location(51.589563293172816, 4.774057748824509)));

                SightList.Add(new Sight(SightList.Count,
                                        "Eetcafé Publieke Werken",
                                        "For 22 years, Café Publieke Werken has been a household name in Breda. The casual atmosphere, sincere hospitality, and good food & drinks make 'PW' a café where everyone feels at home. After the renovation in August 2015, there are no less than 15 beers on tap, and there is even more choice in bottles! When will you come and taste them?",
                                        "http://www.cafepubliekewerken.com/",
                                        new Image { Source = "eetcafe_publieke_werken.jpg" },
                                        new Location(51.58902669921447, 4.778966191319752)));

                SightList.Add(new Sight(SightList.Count,
                                        "Gaudim",
                                        "Catalan food and drink, that is enjoyment. Of beautiful dishes, honest ingredients, and pure flavors. Of 'everything between mountain and sea, 'muntanya y mar,' as the Catalans say. And also of a relaxed atmosphere, good company, real gastronomy, and craftsmanship. Catalan enjoyment, that is Gaudím.",
                                        "http://www.gaudim.nl/",
                                        new Image { Source = "gaudim.jpg" },
                                        new Location(51.58787016771108, 4.780323389080719)));

                SightList.Add(new Sight(SightList.Count,
                                        "Turks restaurant Lades",
                                        "The Turkish restaurant Lades in Breda is a special place where the taste of the East is combined with local culture. The restaurant offers a unique dining experience with its authentic Turkish dishes, made with high-quality ingredients. The atmosphere in the restaurant is warm and welcoming, with soft lighting and traditional Turkish decoration. The menu is extensive and varied, with a selection of different dishes reflecting the taste of Eastern European and Middle Eastern cuisine. The restaurant has an extensive wine and drink menu, making it a perfect place for both eating and drinking.\r\nLades is not only known for its gastronomic qualities but also for its excellent service. The staff is friendly and professional, taking the time to cater to the customer carefully. The location of the restaurant in the heart of Breda makes it an ideal place for both local residents and tourists who want to taste the flavors of the East. The restaurant offers a relaxing and enjoyable experience, with an atmosphere that reminds you of a traditional Turkish house.\r\n",
                                        "http://www.restaurantlades.nl/",
                                        new Image { Source = "turks_restaurant_lades.jpg" },
                                        new Location(51.58714690392391, 4.779143217115772)));

                SightList.Add(new Sight(SightList.Count,
                                        "Restaurant Ume Breda",
                                        "Restaurant Ume Breda in Breda is a meeting place for both local and international guests. The restaurant offers an atmosphere of comfort and luxury, with an extensive menu that combines both traditional and modern Breda cuisine. The decoration of the restaurant is carefully designed to create a sense of warmth and tranquility, witha combination of modern and classic elements that capture attention.The tasteful meals, paired with an extensive wine list, make Restaurant Ume Breda an unforgettable dining experience.\r\nThe restaurant has an excellent reputation and has won numerous awards for its culinary achievements.The staff is friendly and attentive, ensuring that every guest feels comfortable.The location in the heart of Breda makes it an ideal choice for both business and private events.Restaurant Ume Breda is more than just a restaurant; it is an experience that appeals to the senses and creates a memory that lasts long in the mind.\r\n",
                        "http://www.restaurantume.nl/",
                        new Image { Source = "restaurant_ume_breda.png" },
                        new Location(51.58547071614979, 4.774149991569626)));

                SightList.Add(new Sight(SightList.Count,
                                        "Bali James - Indonesisch Restaurant",
                                        "Bali James is an Indonesian restaurant in Breda, specializing in serving authentic Indonesian dishes. The restaurant offers a wide range of dishes, including an impressive rice table composed to bring a great variety of flavors in full harmony. Everything is crafted with authentic fresh herbs and ingredients, which is a labor-intensive but appreciated addition to the taste experience.\r\nAdditionally, Bali James also offers catering services, making it excellent for large groups of people. Since 1978, the restaurant has been catering to groups of 20 to 2000 people. For customers on the go, the restaurant offers the option to take meals away.\r\n",
                                        "http://www.restaurantbali.com/",
                                        new Image { Source = "bali_james_indonesisch_restaurant.jpg" },
                                        new Location(51.585164064186934, 4.7741982713318505)));

                SightList.Add(new Sight(SightList.Count,
                                        "Brasserie Houtmarkt",
                                        "Brasserie Houtmarkt in Breda is a well-known brewery and beer bar offering a wide range of beers. The brewery has a distinctive, authentic atmosphere with a rich history. It provides a calm, relaxing environment where visitors can spend their own time while enjoying a fresh beer and possibly a snack from the brewer's dish. Brasserie Houtmarkt is not just a place to drink but also a place to meet and enjoy the local community.\r\nBrasserie Houtmarkt is known for its high-quality beers and offers a wide range of beer styles. They are famous for their powerful Belgian and German-style beers, but they also have a selection of lighter, fruity beers that are perfect for light relaxation or as a light meal. The brewery is also known for its brewer's dishes, prepared with local and seasonal ingredients. Brasserie Houtmarkt is a popular choice for both local residents and tourists looking for an authentic beer bar experience.\r\n",
                                        "http://www.brasseriehoutmarkt.nl/",
                                        new Image { Source = "brasserie_houtmarkt.jpg" },
                                        new Location(51.586074014539534, 4.7778353467571435)));
                
                SightList.Add(new Sight(SightList.Count, 
                                        "PuiCk",
                                        "At PuiCk, everything revolves around enjoying and experiencing. The eatery, located in Veemarktstraat (by the way, the most beautiful street in the center of Breda) with its variety of shops, focuses as a family business on creativity in terms of interior, food, drink, and atmosphere. They have created a living room with 1970s design chairs and lamps, some plants, a cozy bar, and comfortable seating, making you forget that you are in the middle of downtown Breda.\r\n",
                                        "http://www.puick.nl/",
                                        new Image { Source = "puick.jpg" },
                                        new Location(51.58874376365351, 4.779369570312816)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "De Jongens van Zand & Klei",
                                        "Restaurant De Jongens van Zand & Klei, located at Veemarktstraat 76 in Breda, has a rich history of 120 years of potato experience. The restaurant is known for its tastiest and most flavorful potato dishes, prepared by the 'boys' who grow the potatoes themselves. The potato plays the leading role in the menu, which is both regional and classic and sometimes a bit exotic.\r\nDe Jongens van Zand & Klei offers a menu that is not complicated but still different. There are various toppings available for their crunchy potato basket, and they also have a potato toastie on the menu. The potato is the star in the restaurant, and guests can enjoy it.\r\n",
                                        "http://www.zandenklei.nl/",
                                        new Image { Source = "de_jongens_van_zand_en_klei.jpg" },
                                        new Location(51.58937368157827, 4.779911376533611)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "Bobbi's Bar",
                                        "Bobbi's Bar in Breda is a valued place for relaxation and meeting. The restaurant offers an extensive menu that includes both local and international dishes. The atmosphere is relaxed and friendly, and the service is always of high quality. The interior of the restaurant is cozy and warm, with a modern decor style that appeals to both young and old.\r\nBobbi's Bar's menu is a combination of traditional and modern cuisine, with a strong emphasis on local ingredients. The dishes are carefully prepared and deliver a combination of flavors that appeal to both sight and taste. The restaurant is also known for its extensive wine list, which can convince both connoisseurs and new drinkers.\r\n",
                                        "http://www.bobbisbar.nl/",
                                        new Image { Source = "bobbis_bar.jpg" },
                                        new Location(51.58973696360535, 4.780024029311926)));
                
                SightList.Add(new Sight(SightList.Count,
                                        "Mr Moos bar & bistro",
                                        "Restaurant Mr. Moos Bar & Bistro is a popular spot in Breda, known for its exceptional view of the Grote Kerk. This restaurant attracts many customers with its delicious-tasting burgers, exceptionally served carpaccio, and excellent salads. Additionally, an excellently prepared tiramisu is served here. The customers of Mr. Moos Bar & Bistro also appreciate the warm and friendly atmosphere and the excellent service staff. Customers often return because of the spectacular atmosphere.",
                                        "http://www.mrmoos.nl/",
                                        new Image { Source = "mr_moos_bar_en_bistro.png" },
                                        new Location(51.58897706761533, 4.776290394365218)));
            }
        }
    }
}