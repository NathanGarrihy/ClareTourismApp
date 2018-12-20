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
	public partial class AilweeCaveBirds : ContentPage
	{
		public AilweeCaveBirds ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(AilweeCaveBirds);

            string birdsAilwee1 = "ClareTourismApp.Assets.Images.ailweeBirds1.jpg";
            ailweeBirds1.Source = ImageSource.FromResource(birdsAilwee1, assembly);

            string birdsAilwee2 = "ClareTourismApp.Assets.Images.ailweeBirds2.jpg";
            ailweeBirds2.Source = ImageSource.FromResource(birdsAilwee2, assembly);

            string birdsAilwee3 = "ClareTourismApp.Assets.Images.ailweeBirds3.jpg";
            ailweeBirds3.Source = ImageSource.FromResource(birdsAilwee3, assembly);

            string largeBirds1 = "ClareTourismApp.Assets.Images.ailweeBirdsLarge.jpg";
            ailweeBirdsLarge1.Source = ImageSource.FromResource(largeBirds1, assembly);

            string largeBirds2 = "ClareTourismApp.Assets.Images.ailweeBirdsLarge2.jpg";
            ailweeBirdsLarge2.Source = ImageSource.FromResource(largeBirds2, assembly);


        }
    }
}