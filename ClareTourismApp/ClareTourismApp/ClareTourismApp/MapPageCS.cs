using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ClareTourismApp
{
    class CliffsOfMoherInfoCS : ContentPage
    {
        public CliffsOfMoherInfoCS()
        {
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                WidthRequest = App.ScreenWidth / 3,
                HeightRequest = App.ScreenHeight / 3
            };

            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(52.9717877, -9.4291244),
                Label = "The Cliffs Of Moher",
                Address = "Cliffs Of Moher, Lislorkan North, Liscannor, Co. Clare",
                Id = "CliffsOfMoher",
                Url = "https://www.cliffsofmoher.ie/"
            };

            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.9717877, -9.4291244), Distance.FromMeters(5.0)));

            Content = customMap;
        }
    }
}
