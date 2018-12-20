using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClareTourismApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bunratty : ContentPage
	{
		public Bunratty ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
		}

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(Bunratty);

            string castleBunratty1 = "ClareTourismApp.Assets.Images.bunrattyCastle1.jpg";
            bunrattyCastle1.Source = ImageSource.FromResource(castleBunratty1, assembly);

            string castleBunratty2 = "ClareTourismApp.Assets.Images.bunrattyCastle2.jpg";
            bunrattyCastle2.Source = ImageSource.FromResource(castleBunratty2, assembly);

            string castleBunratty3 = "ClareTourismApp.Assets.Images.bunrattyCastle3.jpg";
            bunrattyCastle3.Source = ImageSource.FromResource(castleBunratty3, assembly);

            string bunrattyLarge = "ClareTourismApp.Assets.Images.bunrattyCastleLarge.jpg";
            bunrattyCastleLarge.Source = ImageSource.FromResource(bunrattyLarge, assembly);
        }

    }
}