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
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(52.9717877, -9.4291244), Distance.FromKilometers(5.0)));
        }
    }
}