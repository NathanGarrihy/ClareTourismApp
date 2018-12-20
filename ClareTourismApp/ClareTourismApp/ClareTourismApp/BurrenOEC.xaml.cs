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
	public partial class BurrenOEC : ContentPage
	{
		public BurrenOEC ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
		}

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(BurrenOEC);

            string OECBurren1 = "ClareTourismApp.Assets.Images.burrenOEC1.jpg";
            burrenOEC1.Source = ImageSource.FromResource(OECBurren1, assembly);

            string OECBurren2 = "ClareTourismApp.Assets.Images.burrenOEC2.jpg";
            burrenOEC2.Source = ImageSource.FromResource(OECBurren2, assembly);

            string OECBurren3 = "ClareTourismApp.Assets.Images.burrenOEC3.jpg";
            burrenOEC3.Source = ImageSource.FromResource(OECBurren3, assembly);

            string largeVisitor = "ClareTourismApp.Assets.Images.burrenOECLarge.jpg";
            burrenOECLarge.Source = ImageSource.FromResource(largeVisitor, assembly);
        }

        }

}