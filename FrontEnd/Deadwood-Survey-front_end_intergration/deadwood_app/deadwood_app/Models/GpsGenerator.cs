using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;

namespace deadwood_app.Models
{
    class GpsGenerator
    {
        Position position;
        public double lat { get; set; }
        public double lon { get; set; }

        public GpsGenerator()
        {
            Generate();
        }
        private async void Generate()
        {
            var locatorObj = CrossGeolocator.Current;
            position = await locatorObj.GetPositionAsync(TimeSpan.FromSeconds(10));
        }

        public Position GetPosition()
        {
            return position;
        }

        public double GetLongitude()
        {
            // Console.WriteLine("LOCATION: " + position.Longitude + " " + position.Latitude);
            return position.Longitude;
        }

        public double GetLatitude()
        {
            return position.Latitude;
        }
    }
}
