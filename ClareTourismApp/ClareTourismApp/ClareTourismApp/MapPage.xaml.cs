using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ClareTourismApp
{
	public partial class MapPage : ContentPage
	{
		public MapPage ()
		{
			InitializeComponent ();

            var pin = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(52.9717877, -9.4291244),
                Label = "Cliffs Of Moher",
                Address = "Cliffs Of Moher, Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.9717877, -9.4291244), Distance.FromKilometers(50.0)));
            //  Perfect Zoom in distance fromKilomiters Calculated by finding Clare total size (km squared) and finding square root

            var pin1 = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(52.9968, -9.0374),
                Label = "The Burren National Park",
                Address = "2 Church St, Knockaunroe, Corofin, Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin1 };
            customMap.Pins.Add(pin1);

            var pin2 = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(52.696660, -8.812033),
                Label = "Bunratty Castle",
                Address = "Bunratty West, Bunratty, Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin2 };
            customMap.Pins.Add(pin2);

            var pin3 = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(53.0891, -9.1465), // not done
                Label = "Ailwee Cave",
                Address = "Ballycahill, Ballyvaughan, Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin3 };
            customMap.Pins.Add(pin3);

            var pin4 = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(53.015970, -9.377620),
                Label = "Doolin",
                Address = "Doolin, Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin4 };
            customMap.Pins.Add(pin4);

            var pin5 = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(52.8111, -8.7936), 
                Label = "Craggaunowen",
                Address = "Craggaunowen , Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin5 };
            customMap.Pins.Add(pin5);

            var pin6 = new CustomPin
            {
                Type = Xamarin.Forms.Maps.PinType.Place,
                Position = new Xamarin.Forms.Maps.Position(52.9335, -9.3441), 
                Label = "Lahinch",
                Address = "Lahinch , Co. Clare"
            };
            customMap.CustomPins = new List<CustomPin> { pin6 };
            customMap.Pins.Add(pin6);
        }
    }
}