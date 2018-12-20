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
	public partial class LahinchInfo : ContentPage
	{
		public LahinchInfo ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(LahinchInfo);

            string infoLahinch1 = "ClareTourismApp.Assets.Images.lahinchInfo1.jpg";
            lahinchInfo1.Source = ImageSource.FromResource(infoLahinch1, assembly);

            string infoLahinch2 = "ClareTourismApp.Assets.Images.lahinchInfo2.jpg";
            lahinchInfo2.Source = ImageSource.FromResource(infoLahinch2, assembly);

            string infoLahinch3 = "ClareTourismApp.Assets.Images.lahinchInfo3.jpg";
            lahinchInfo3.Source = ImageSource.FromResource(infoLahinch3, assembly);

            string largeInfoLahinch = "ClareTourismApp.Assets.Images.lahinchInfoLarge.jpg";
            lahinchInfoLarge.Source = ImageSource.FromResource(largeInfoLahinch, assembly);
        }
    }
}