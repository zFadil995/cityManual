using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace City_Manual
{
    public class City
    {
        public string name { get; set; }
        public string canton { get; set; }
        public string entity { get; set; }
        public int population { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public Location location { get; set; }
        public string[] panoramas { get; set; }
        public string events { get; set; }
        public Place[] places {get;set;}
        public class Location
        {
            public double latitude { get; set; }
            public double longtitude { get; set; }
            public string source { get; set; }
        }
        public class Place
        {
            public string image { get; set; }
            public string place { get; set; }
        }
    }
    public static class ICity
    {
        public static City chosenCity;
        public static List<City> cities;
        public static void getCities()
        {
            var assembly = typeof(City).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("City_Manual.CityData.txt");
            string cityData = "";
            using (var reader = new StreamReader(stream))
                cityData = reader.ReadToEnd();
            cities = JsonConvert.DeserializeObject<List<City>>(cityData);
        }
    }
}
