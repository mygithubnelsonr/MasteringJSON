using System;
using System.Collections.Generic;

namespace Geocoding
{
    class Location
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Display_Name { get; set; }
        public List<string> Boundingbox { get; set; }
        public Dictionary<string, string> NameDetails { get; set; }
        public Dictionary<string, string> Address { get; set; }
        public Dictionary<string, string> ExtraTags { get; set; }
        public List<List<string>> PolygonPoints { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string Importance { get; set; }
        //
        public int Place_Id { get; set; }
        public string Licence { get; set; }

        public override string ToString()
        {
            var ls = $"Display Name: {Display_Name}\n" +
                $"Latitude:{new String(' ', 12 - "Latitude:".Length)}{Lat}\n" +
                $"Longitude:{new String(' ', 12 - "Longitude:".Length)}{Lon}\n" +
                $"Bounding Box:\n";

            foreach (var item in Boundingbox)
            {
                ls += $"\t{item},\n";
            }

            ls += "Name Details:";
            foreach (var item in NameDetails)
            {
                ls += $"{item.Key} : {item.Value}\n";
            }

            ls += "Address:";
            foreach (var item in Address)
            {
                ls += $"{item.Key} : {item.Value}\n";
            }

            ls += "Extra Tags:";
            foreach (var item in ExtraTags)
            {
                ls += $"{item.Key} : {item.Value}\n";
            }

            return ls;

        }
    }
}
