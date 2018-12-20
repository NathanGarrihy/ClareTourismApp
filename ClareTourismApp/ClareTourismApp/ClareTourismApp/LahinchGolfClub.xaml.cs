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
	public partial class LahinchGolfClub : ContentPage
	{
		public LahinchGolfClub ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(LahinchGolfClub);

            string GCSmall1 = "ClareTourismApp.Assets.Images.lahinchGCsmall1.jpg";
            lahinchGCsmall1.Source = ImageSource.FromResource(GCSmall1, assembly);

            string GCSmall2 = "ClareTourismApp.Assets.Images.lahinchGCsmall2.jpg";
            lahinchGCsmall2.Source = ImageSource.FromResource(GCSmall2, assembly);

            string GCSmall3 = "ClareTourismApp.Assets.Images.lahinchGCsmall3.jpg";
            lahinchGCsmall3.Source = ImageSource.FromResource(GCSmall3, assembly);

            string GCLarge1 = "ClareTourismApp.Assets.Images.lahinchGCLarge1.jpg";
            lahinchGCLarge1.Source = ImageSource.FromResource(GCLarge1, assembly);

            string GCLarge2 = "ClareTourismApp.Assets.Images.lahinchGCLarge2.jpg";
            lahinchGCLarge2.Source = ImageSource.FromResource(GCLarge2, assembly);

            string GCLarge3 = "ClareTourismApp.Assets.Images.lahinchGCLarge3.jpg";
            lahinchGCLarge3.Source = ImageSource.FromResource(GCLarge3, assembly);

            string GCLarge4 = "ClareTourismApp.Assets.Images.lahinchGCLarge4.jpg";
            lahinchGCLarge4.Source = ImageSource.FromResource(GCLarge4, assembly);

        }
    }
}