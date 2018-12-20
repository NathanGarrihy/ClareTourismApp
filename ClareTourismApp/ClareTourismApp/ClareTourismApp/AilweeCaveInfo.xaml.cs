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
	public partial class AilweeCaveInfo : ContentPage
	{
		public AilweeCaveInfo ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(AilweeCaveInfo);

            string caveAilwee1 = "ClareTourismApp.Assets.Images.ailweeCave1.jpg";
            ailweeCave1.Source = ImageSource.FromResource(caveAilwee1, assembly);

            string caveAilwee2 = "ClareTourismApp.Assets.Images.ailweeCave2.jpg";
            ailweeCave2.Source = ImageSource.FromResource(caveAilwee2, assembly);

            string caveAilwee3 = "ClareTourismApp.Assets.Images.ailweeCave3.jpg";
            ailweeCave3.Source = ImageSource.FromResource(caveAilwee3, assembly);

            string largeAilwee = "ClareTourismApp.Assets.Images.ailweeCaveLarge.jpg";
            ailweeCaveLarge.Source = ImageSource.FromResource(largeAilwee, assembly);

        }
    }
}