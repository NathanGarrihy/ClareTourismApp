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
	public partial class DoolinCave : ContentPage
	{
		public DoolinCave ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(DoolinCave);

            string smallDoolinCave1 = "ClareTourismApp.Assets.Images.doolinCaveSmall1.jpg";
            doolinCaveSmall1.Source = ImageSource.FromResource(smallDoolinCave1, assembly);

            string smallDoolinCave2 = "ClareTourismApp.Assets.Images.doolinCaveSmall2.jpg";
            doolinCaveSmall2.Source = ImageSource.FromResource(smallDoolinCave2, assembly);

            string smallDoolinCave3 = "ClareTourismApp.Assets.Images.doolinCaveSmall3.jpg";
            doolinCaveSmall3.Source = ImageSource.FromResource(smallDoolinCave3, assembly);

            string largeBirds1 = "ClareTourismApp.Assets.Images.doolinCaveLarge.jpg";
            doolinCaveLarge.Source = ImageSource.FromResource(largeBirds1, assembly);
            
        }
    }
}