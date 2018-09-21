﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCronberg.PersonNuGetPackage
{
    public static class PersonHelperMethods
    {
        private static Random r = new Random();

        public static string GetRandomMaleName()
        {
            var n = GetMaleNames();
            return n[r.Next(0, n.Count)];
        }

        public static string GetRandomFemaleName()
        {
            var n = GetFemaleNames();
            return n[r.Next(0, n.Count)];
        }


        public static List<Country> GetAllCountries()
        {
            // From http://en.wikipedia.org/wiki/List_of_national_capitals_in_alphabetical_order
            List<Country> lst = new List<Country>() {
                new Country(){ CountryId=1, Name="United Arab Emirates", Captial="Abu Dhabi"},
                new Country(){ CountryId=2, Name="Nigeria", Captial="Abuja"},
                new Country(){ CountryId=3, Name="Ghana", Captial="Accra"},
                new Country(){ CountryId=4, Name="Pitcairn Islands", Captial="Adamstown"},
                new Country(){ CountryId=5, Name="Ethiopia", Captial="Addis Ababa"},
                new Country(){ CountryId=6, Name="Algeria", Captial="Algiers"},
                new Country(){ CountryId=7, Name="Niue", Captial="Alofi"},
                new Country(){ CountryId=8, Name="Jordan", Captial="Amman"},
                new Country(){ CountryId=9, Name="Netherlands", Captial="Amsterdam"},
                new Country(){ CountryId=10, Name="Andorra", Captial="Andorra la Vella"},
                new Country(){ CountryId=11, Name="Turkey", Captial="Ankara"},
                new Country(){ CountryId=12, Name="Madagascar", Captial="Antananarivo"},
                new Country(){ CountryId=13, Name="Samoa", Captial="Apia"},
                new Country(){ CountryId=14, Name="Turkmenistan", Captial="Ashgabat"},
                new Country(){ CountryId=15, Name="Eritrea", Captial="Asmara"},
                new Country(){ CountryId=16, Name="Kazakhstan", Captial="Astana"},
                new Country(){ CountryId=17, Name="Paraguay", Captial="Asunción"},
                new Country(){ CountryId=18, Name="Greece", Captial="Athens"},
                new Country(){ CountryId=19, Name="Cook Islands", Captial="Avarua"},
                new Country(){ CountryId=20, Name="Iraq", Captial="Baghdad"},
                new Country(){ CountryId=21, Name="Azerbaijan", Captial="Baku"},
                new Country(){ CountryId=22, Name="Mali", Captial="Bamako"},
                new Country(){ CountryId=23, Name="Brunei", Captial="Bandar Seri Begawan"},
                new Country(){ CountryId=24, Name="Thailand", Captial="Bangkok"},
                new Country(){ CountryId=25, Name="Central African Republic", Captial="Bangui"},
                new Country(){ CountryId=26, Name="Gambia", Captial="Banjul"},
                new Country(){ CountryId=27, Name="Saint Kitts and Nevis", Captial="Basseterre"},
                new Country(){ CountryId=28, Name="China", Captial="Beijing"},
                new Country(){ CountryId=29, Name="Lebanon", Captial="Beirut"},
                new Country(){ CountryId=30, Name="Serbia", Captial="Belgrade"},
                new Country(){ CountryId=31, Name="Belize", Captial="Belmopan"},
                new Country(){ CountryId=32, Name="Germany", Captial="Berlin"},
                new Country(){ CountryId=33, Name=" Switzerland", Captial="Bern"},
                new Country(){ CountryId=34, Name="Kyrgyzstan", Captial="Bishkek"},
                new Country(){ CountryId=35, Name="Guinea-Bissau", Captial="Bissau"},
                new Country(){ CountryId=36, Name="Colombia", Captial="Bogotá"},
                new Country(){ CountryId=37, Name="Brazil", Captial="Brasília"},
                new Country(){ CountryId=38, Name="Slovakia", Captial="Bratislava"},
                new Country(){ CountryId=39, Name="Republic of the Congo", Captial="Brazzaville"},
                new Country(){ CountryId=40, Name="Barbados", Captial="Bridgetown"},
                new Country(){ CountryId=41, Name="Belgium", Captial="Brussels"},
                new Country(){ CountryId=42, Name="Romania", Captial="Bucharest"},
                new Country(){ CountryId=43, Name="Hungary", Captial="Budapest"},
                new Country(){ CountryId=44, Name="Argentina", Captial="Buenos Aires"},
                new Country(){ CountryId=45, Name="Burundi", Captial="Bujumbura"},
                new Country(){ CountryId=46, Name="Egypt", Captial="Cairo"},
                new Country(){ CountryId=47, Name="Australia", Captial="Canberra"},
                new Country(){ CountryId=48, Name="Venezuela", Captial="Caracas"},
                new Country(){ CountryId=49, Name="Saint Lucia", Captial="Castries"},
                new Country(){ CountryId=50, Name="French Guiana", Captial="Cayenne"},
                new Country(){ CountryId=51, Name="United States Virgin Islands", Captial="Charlotte Amalie"},
                new Country(){ CountryId=52, Name="Moldova", Captial="Chisinau"},
                new Country(){ CountryId=53, Name="Turks and Caicos Islands", Captial="Cockburn Town"},
                new Country(){ CountryId=54, Name="Guinea", Captial="Conakry"},
                new Country(){ CountryId=55, Name="Denmark", Captial="Copenhagen"},
                new Country(){ CountryId=56, Name="Senegal", Captial="Dakar"},
                new Country(){ CountryId=57, Name="Syria", Captial="Damascus"},
                new Country(){ CountryId=58, Name="Bangladesh", Captial="Dhaka"},
                new Country(){ CountryId=59, Name="East Timor (Timor-Leste)", Captial="Dili"},
                new Country(){ CountryId=60, Name="Djibouti", Captial="Djibouti"},
                new Country(){ CountryId=61, Name="Tanzania", Captial="Dodoma (official, legislative)"},
                new Country(){ CountryId=62, Name="Qatar", Captial="Doha"},
                new Country(){ CountryId=63, Name="Isle of Man", Captial="Douglas"},
                new Country(){ CountryId=64, Name="Ireland", Captial="Dublin"},
                new Country(){ CountryId=65, Name="Tajikistan", Captial="Dushanbe"},
                new Country(){ CountryId=66, Name="Tristan da Cunha", Captial="Edinburgh of the Seven Seas"},
                new Country(){ CountryId=67, Name="Sahrawi Arab Democratic Republic [c]", Captial="El Aaiún (declared)"},
                new Country(){ CountryId=68, Name="Akrotiri and Dhekelia", Captial="Episkopi Cantonment"},
                new Country(){ CountryId=69, Name="Christmas Island", Captial="Flying Fish Cove"},
                new Country(){ CountryId=70, Name="Sierra Leone", Captial="Freetown"},
                new Country(){ CountryId=71, Name="Tuvalu", Captial="Funafuti"},
                new Country(){ CountryId=72, Name="Botswana", Captial="Gaborone"},
                new Country(){ CountryId=73, Name="Cayman Islands", Captial="George Town"},
                new Country(){ CountryId=74, Name="Ascension Island", Captial="Georgetown"},
                new Country(){ CountryId=75, Name="Guyana", Captial="Georgetown"},
                new Country(){ CountryId=76, Name="Gibraltar", Captial="Gibraltar"},
                new Country(){ CountryId=77, Name="Guatemala", Captial="Guatemala City"},
                new Country(){ CountryId=78, Name="Saint Barthélemy", Captial="Gustavia"},
                new Country(){ CountryId=79, Name="Guam", Captial="Hagåtña"},
                new Country(){ CountryId=80, Name="Bermuda", Captial="Hamilton"},
                new Country(){ CountryId=81, Name="Easter Island", Captial="Hanga Roa"},
                new Country(){ CountryId=82, Name="Vietnam", Captial="Hanoi"},
                new Country(){ CountryId=83, Name="Zimbabwe", Captial="Harare"},
                new Country(){ CountryId=84, Name="Somaliland", Captial="Hargeisa"},
                new Country(){ CountryId=85, Name="Cuba", Captial="Havana"},
                new Country(){ CountryId=86, Name="Finland", Captial="Helsinki"},
                new Country(){ CountryId=87, Name="Solomon Islands", Captial="Honiara"},
                new Country(){ CountryId=88, Name="Pakistan", Captial="Islamabad"},
                new Country(){ CountryId=89, Name="Indonesia", Captial="Jakarta"},
                new Country(){ CountryId=90, Name="Saint Helena", Captial="Jamestown"},
                new Country(){ CountryId=91, Name="Israel", Captial="Jerusalem (declared, de facto)"},
                new Country(){ CountryId=92, Name="State of Palestine", Captial="Jerusalem (declared)"},
                new Country(){ CountryId=93, Name="South Sudan", Captial="Juba"},
                new Country(){ CountryId=94, Name="Afghanistan", Captial="Kabul"},
                new Country(){ CountryId=95, Name="Uganda", Captial="Kampala"},
                new Country(){ CountryId=96, Name="  Nepal", Captial="Kathmandu"},
                new Country(){ CountryId=97, Name="Sudan", Captial="Khartoum"},
                new Country(){ CountryId=98, Name="Ukraine", Captial="Kiev"},
                new Country(){ CountryId=99, Name="Rwanda", Captial="Kigali"},
                new Country(){ CountryId=100, Name="South Georgia and the South Sandwich Islands", Captial="King Edward Point"},
                new Country(){ CountryId=101, Name="Jamaica", Captial="Kingston"},
                new Country(){ CountryId=102, Name="Norfolk Island", Captial="Kingston"},
                new Country(){ CountryId=103, Name="Saint Vincent and the Grenadines", Captial="Kingstown"},
                new Country(){ CountryId=104, Name="Democratic Republic of the Congo", Captial="Kinshasa"},
                new Country(){ CountryId=105, Name="Malaysia", Captial="Kuala Lumpur (official, legislative and royal)"},
                new Country(){ CountryId=106, Name="Kuwait", Captial="Kuwait City"},
                new Country(){ CountryId=107, Name="Gabon", Captial="Libreville"},
                new Country(){ CountryId=108, Name="Malawi", Captial="Lilongwe"},
                new Country(){ CountryId=109, Name="Peru", Captial="Lima"},
                new Country(){ CountryId=110, Name="Portugal", Captial="Lisbon"},
                new Country(){ CountryId=111, Name="Slovenia", Captial="Ljubljana"},
                new Country(){ CountryId=112, Name="Togo", Captial="Lomé"},
                new Country(){ CountryId=113, Name="United Kingdom", Captial="London"},
                new Country(){ CountryId=114, Name="Angola", Captial="Luanda"},
                new Country(){ CountryId=115, Name="Zambia", Captial="Lusaka"},
                new Country(){ CountryId=116, Name="Luxembourg", Captial="Luxembourg"},
                new Country(){ CountryId=117, Name="Spain", Captial="Madrid"},
                new Country(){ CountryId=118, Name="Marshall Islands", Captial="Majuro"},
                new Country(){ CountryId=119, Name="Equatorial Guinea", Captial="Malabo"},
                new Country(){ CountryId=120, Name="Maldives", Captial="Malé"},
                new Country(){ CountryId=121, Name="Nicaragua", Captial="Managua"},
                new Country(){ CountryId=122, Name="Bahrain", Captial="Manama"},
                new Country(){ CountryId=123, Name="Philippines", Captial="Manila"},
                new Country(){ CountryId=124, Name="Mozambique", Captial="Maputo"},
                new Country(){ CountryId=125, Name="Saint Martin", Captial="Marigot"},
                new Country(){ CountryId=126, Name="Lesotho", Captial="Maseru"},
                new Country(){ CountryId=127, Name="Wallis and Futuna", Captial="Mata-Utu"},
                new Country(){ CountryId=128, Name="Swaziland", Captial="Mbabane (administrative)"},
                new Country(){ CountryId=129, Name="Mexico", Captial="Mexico City"},
                new Country(){ CountryId=130, Name="Belarus", Captial="Minsk"},
                new Country(){ CountryId=131, Name="Somalia", Captial="Mogadishu"},
                new Country(){ CountryId=132, Name="Monaco", Captial="Monaco"},
                new Country(){ CountryId=133, Name="Liberia", Captial="Monrovia"},
                new Country(){ CountryId=134, Name="Uruguay", Captial="Montevideo"},
                new Country(){ CountryId=135, Name="Comoros", Captial="Moroni"},
                new Country(){ CountryId=136, Name="Russia", Captial="Moscow"},
                new Country(){ CountryId=137, Name="Oman", Captial="Muscat"},
                new Country(){ CountryId=138, Name="Kenya", Captial="Nairobi"},
                new Country(){ CountryId=139, Name="Bahamas", Captial="Nassau"},
                new Country(){ CountryId=140, Name="Burma", Captial="Naypyidaw"},
                new Country(){ CountryId=141, Name="Chad", Captial="N'Djamena"},
                new Country(){ CountryId=142, Name="India", Captial="New Delhi"},
                new Country(){ CountryId=143, Name="Palau", Captial="Ngerulmud"},
                new Country(){ CountryId=144, Name="Niger", Captial="Niamey"},
                new Country(){ CountryId=145, Name="Cyprus", Captial="Nicosia"},
                new Country(){ CountryId=146, Name="Northern Cyprus", Captial="Nicosia"},
                new Country(){ CountryId=147, Name="Mauritania", Captial="Nouakchott"},
                new Country(){ CountryId=148, Name="New Caledonia", Captial="Nouméa"},
                new Country(){ CountryId=149, Name="Tonga", Captial="Nukuʻalofa"},
                new Country(){ CountryId=150, Name="Greenland", Captial="Nuuk"},
                new Country(){ CountryId=151, Name="Aruba", Captial="Oranjestad"},
                new Country(){ CountryId=152, Name="Norway", Captial="Oslo"},
                new Country(){ CountryId=153, Name="Canada", Captial="Ottawa"},
                new Country(){ CountryId=154, Name="Burkina Faso", Captial="Ouagadougou"},
                new Country(){ CountryId=155, Name="American Samoa", Captial="Pago Pago"},
                new Country(){ CountryId=156, Name="Federated States of Micronesia", Captial="Palikir"},
                new Country(){ CountryId=157, Name="Panama", Captial="Panama City"},
                new Country(){ CountryId=158, Name="French Polynesia", Captial="Papeete"},
                new Country(){ CountryId=159, Name="Suriname", Captial="Paramaribo"},
                new Country(){ CountryId=160, Name="France", Captial="Paris"},
                new Country(){ CountryId=161, Name="Sint Maarten", Captial="Philipsburg"},
                new Country(){ CountryId=162, Name="Cambodia", Captial="Phnom Penh"},
                new Country(){ CountryId=163, Name="Montserrat", Captial="Plymouth (official)"},
                new Country(){ CountryId=164, Name="Montenegro", Captial="Podgorica (official)"},
                new Country(){ CountryId=165, Name="Mauritius", Captial="Port Louis"},
                new Country(){ CountryId=166, Name="Papua New Guinea", Captial="Port Moresby"},
                new Country(){ CountryId=167, Name="Vanuatu", Captial="Port Vila"},
                new Country(){ CountryId=168, Name="Haiti", Captial="Port-au-Prince"},
                new Country(){ CountryId=169, Name="Trinidad and Tobago", Captial="Port of Spain"},
                new Country(){ CountryId=170, Name="Benin", Captial="Porto-Novo (official)"},
                new Country(){ CountryId=171, Name="Czech Republic", Captial="Prague"},
                new Country(){ CountryId=172, Name="Cape Verde", Captial="Praia"},
                new Country(){ CountryId=173, Name="South Africa", Captial="Pretoria (executive)"},
                new Country(){ CountryId=174, Name="Kosovo[g]", Captial="Pristina"},
                new Country(){ CountryId=175, Name="North Korea", Captial="Pyongyang"},
                new Country(){ CountryId=176, Name="Ecuador", Captial="Quito"},
                new Country(){ CountryId=177, Name="Morocco", Captial="Rabat"},
                new Country(){ CountryId=178, Name="Iceland", Captial="Reykjavík"},
                new Country(){ CountryId=179, Name="Latvia", Captial="Riga"},
                new Country(){ CountryId=180, Name="Saudi Arabia", Captial="Riyadh"},
                new Country(){ CountryId=181, Name="British Virgin Islands", Captial="Road Town"},
                new Country(){ CountryId=182, Name="Italy", Captial="Rome"},
                new Country(){ CountryId=183, Name="Dominica", Captial="Roseau"},
                new Country(){ CountryId=184, Name="Northern Mariana Islands", Captial="Saipan"},
                new Country(){ CountryId=185, Name="Costa Rica", Captial="San José"},
                new Country(){ CountryId=186, Name="Puerto Rico", Captial="San Juan"},
                new Country(){ CountryId=187, Name="San Marino", Captial="San Marino"},
                new Country(){ CountryId=188, Name="El Salvador", Captial="San Salvador"},
                new Country(){ CountryId=189, Name="Yemen", Captial="Sana'a"},
                new Country(){ CountryId=190, Name="Chile", Captial="Santiago (official)"},
                new Country(){ CountryId=191, Name="Dominican Republic", Captial="Santo Domingo"},
                new Country(){ CountryId=192, Name="São Tomé and Príncipe", Captial="São Tomé"},
                new Country(){ CountryId=193, Name="Bosnia and Herzegovina", Captial="Sarajevo"},
                new Country(){ CountryId=194, Name="South Korea", Captial="Seoul"},
                new Country(){ CountryId=195, Name="Singapore", Captial="Singapore"},
                new Country(){ CountryId=196, Name="Macedonia", Captial="Skopje"},
                new Country(){ CountryId=197, Name="Bulgaria", Captial="Sofia"},
                new Country(){ CountryId=198, Name="Sri Lanka", Captial="Sri Jayawardenepura Kotte (official)"},
                new Country(){ CountryId=199, Name="Grenada", Captial="St. George's"},
                new Country(){ CountryId=200, Name="Jersey", Captial="St. Helier"},
                new Country(){ CountryId=201, Name="Antigua and Barbuda", Captial="St. John's"},
                new Country(){ CountryId=202, Name="Guernsey", Captial="St. Peter Port"},
                new Country(){ CountryId=203, Name="Saint Pierre and Miquelon", Captial="St. Pierre"},
                new Country(){ CountryId=204, Name="Falkland Islands", Captial="Stanley"},
                new Country(){ CountryId=205, Name="Nagorno-Karabakh Republic", Captial="Stepanakert"},
                new Country(){ CountryId=206, Name="Sweden", Captial="Stockholm"},
                new Country(){ CountryId=207, Name="Bolivia", Captial="Sucre (constitutional)"},
                new Country(){ CountryId=208, Name="Abkhazia", Captial="Sukhumi"},
                new Country(){ CountryId=209, Name="Fiji", Captial="Suva"},
                new Country(){ CountryId=210, Name="Taiwan", Captial="Taipei"},
                new Country(){ CountryId=211, Name="Estonia", Captial="Tallinn"},
                new Country(){ CountryId=212, Name="Kiribati", Captial="Tarawa Atoll"},
                new Country(){ CountryId=213, Name="Uzbekistan", Captial="Tashkent"},
                new Country(){ CountryId=214, Name="Georgia", Captial="Tbilisi (official)"},
                new Country(){ CountryId=215, Name="Honduras", Captial="Tegucigalpa"},
                new Country(){ CountryId=216, Name="Iran", Captial="Tehran"},
                new Country(){ CountryId=217, Name="Bhutan", Captial="Thimphu"},
                new Country(){ CountryId=218, Name="Albania", Captial="Tirana"},
                new Country(){ CountryId=219, Name="Transnistria", Captial="Tiraspol"},
                new Country(){ CountryId=220, Name="Japan", Captial="Tokyo"},
                new Country(){ CountryId=221, Name="Faroe Islands", Captial="Tórshavn"},
                new Country(){ CountryId=222, Name="Libya", Captial="Tripoli"},
                new Country(){ CountryId=223, Name="South Ossetia", Captial="Tskhinvali"},
                new Country(){ CountryId=224, Name="Tunisia", Captial="Tunis"},
                new Country(){ CountryId=225, Name="Mongolia", Captial="Ulan Bator"},
                new Country(){ CountryId=226, Name="Liechtenstein", Captial="Vaduz"},
                new Country(){ CountryId=227, Name="Malta", Captial="Valletta"},
                new Country(){ CountryId=228, Name="Anguilla", Captial="The Valley"},
                new Country(){ CountryId=229, Name=" Vatican City", Captial="Vatican City"},
                new Country(){ CountryId=230, Name="Seychelles", Captial="Victoria"},
                new Country(){ CountryId=231, Name="Austria", Captial="Vienna"},
                new Country(){ CountryId=232, Name="Laos", Captial="Vientiane"},
                new Country(){ CountryId=233, Name="Lithuania", Captial="Vilnius"},
                new Country(){ CountryId=234, Name="Poland", Captial="Warsaw"},
                new Country(){ CountryId=235, Name="United States", Captial="Washington, D.C."},
                new Country(){ CountryId=236, Name="New Zealand", Captial="Wellington"},
                new Country(){ CountryId=237, Name="Cocos (Keeling) Islands", Captial="West Island"},
                new Country(){ CountryId=238, Name="Curaçao", Captial="Willemstad"},
                new Country(){ CountryId=239, Name="Namibia", Captial="Windhoek"},
                new Country(){ CountryId=240, Name="Ivory Coast", Captial="Yamoussoukro (official)"},
                new Country(){ CountryId=241, Name="Cameroon", Captial="Yaoundé"},
                new Country(){ CountryId=242, Name="Nauru", Captial="Yaren (de facto)"},
                new Country(){ CountryId=243, Name="Armenia", Captial="Yerevan"},
                new Country(){ CountryId=244, Name="Croatia", Captial="Zagreb"}};
            return lst;
        }



        public static List<string> GetMaleNames()
        {
            var names = "Edward Martin;Henry Carter;Jesse Wood;Nicholas Hughes;Billy Coleman;Patrick Price;Jack Ross;Shawn Turner;Phillip Phillips;Harry Hill;Jason Reed;Donald Powell;Christopher Rodriguez;Matthew Thomas;Brian Gray;Paul Campbell;Roger Green;Bobby Alexander;Peter Ward;Steve Jenkins;Martin Barnes;Keith Nelson;Douglas Richardson;Earl Brown;Sean King;Carl Williams;Robert Wright;Eric Rivera;Terry Cox;Ernest Robinson;Roy Morgan;Howard Stewart;Samuel Mitchell;Philip Wilson;George Thompson;Gary Smith;Gregory Lewis;Jeremy Bell;Todd Butler;Dennis Hernandez;Raymond Simmons;Brandon Gonzalez;Jose Clark;Jimmy Roberts;Timothy Russell;Arthur Patterson;Victor Walker;Jerry James;Benjamin Watson;Albert Bryant;Scott Kelly;Juan Washington;Carlos Torres;Johnny Sanders;Lawrence Lee;Joe Morris;Kenneth Edwards;Thomas Harris;Gerald Baker;Andrew Collins;David Lopez;Justin White;Jonathan Miller;Ronald Griffin;Joseph Bennett;Ralph Cooper;Wayne Bailey;Walter Henderson;Daniel Parker;Clarence Anderson;Eugene Allen;Mark Perez;Michael Scott;Harold Evans;Ryan Taylor;Joshua Flores;William Martinez;Russell Cook;Craig Diaz;Fred Garcia;Kevin Long;Louis Gonzales;James Foster;Bruce Jackson;Frank Hall;Aaron Adams;Larry Howard;Jeffrey Jones;Alan Johnson;Adam Young;Charles Davis;Stephen Sanchez;Chris Peterson;Willie Rogers;John Perry;Anthony Moore;Steven Murphy;Richard Ramirez;Randy Brooks";
            return names.Split(';').ToList();
        }

        public static List<string> GetFemaleNames()
        {
            var names = "Alice Nelson;Lois Alexander;Lillian Collins;Melissa Jones;Debra Allen;Janice Rivera;Lori Henderson;Norma Bryant;Karen Wright;Sharon Taylor;Michelle Gonzalez;Marie Flores;Mary Butler;Joyce Evans;Stephanie Roberts;Joan Peterson;Linda Simmons;Teresa Powell;Barbara Baker;Beverly Morgan;Katherine Sanders;Rebecca Thompson;Maria Long;Laura Lewis;Ashley Garcia;Cheryl Adams;Tammy Rogers;Margaret Ross;Brenda James;Marilyn Gray;Amy Turner;Dorothy Edwards;Irene Stewart;Virginia Hill;Phyllis Moore;Paula Cox;Cynthia Sanchez;Carol Smith;Catherine Walker;Christina Barnes;Theresa Foster;Doris Brooks;Jean Campbell;Kelly Hernandez;Ruth Cook;Gloria Cooper;Donna White;Elizabeth Ward;Sara Harris;Diane Thomas;Julie Gonzales;Julia Patterson;Louise Parker;Heather Price;Diana Kelly;Frances Perez;Helen Torres;Rose Washington;Anna Martinez;Angela Johnson;Sandra Williams;Jacqueline Jackson;Amanda Anderson;Judith Wood;Judy Griffin;Deborah Murphy;Andrea Coleman;Ruby Brown;Shirley Bell;Kathryn Reed;Jennifer Green;Pamela Hughes;Annie Young;Janet Scott;Jessica Jenkins;Lisa Mitchell;Betty Carter;Ann Bennett;Wanda Ramirez;Jane Watson;Anne Hall;Emily Wilson;Martha Phillips;Nancy Morris;Tina King;Rachel Perry;Kimberly Howard;Carolyn Robinson;Kathy Martin;Sarah Richardson;Patricia Lopez;Evelyn Russell;Kathleen Clark;Christine Miller;Bonnie Bailey;Denise Davis;Nicole Diaz;Susan Lee;Mildred Rodriguez";
            return names.Split(';').ToList();
        }

        //public static List<Language> GetLanguages()
        //{
        //    string[] onlyInclude = { "da", "se", "fi", "no", "de", "en", "es", "fr", "ru", "it" };
        //    List<Language> lst = new List<Language>();
        //    int i = 0;
        //    foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
        //    {
        //        if (onlyInclude.Contains(ci.TwoLetterISOLanguageName))
        //            lst.Add(new Language() { LanguageId = ++i, Name = ci.EnglishName, Culture = ci.TwoLetterISOLanguageName });
        //    }
        //    return lst.OrderBy(c => c.Name).ToList();
        //}
    }
}