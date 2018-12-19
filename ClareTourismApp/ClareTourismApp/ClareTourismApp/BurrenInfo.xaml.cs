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
	public partial class BurrenInfo : ContentPage
	{
        public BurrenInfo()
        {
            InitializeComponent();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(BurrenInfo);

            string burrenpic1 = "ClareTourismApp.Assets.Images.burrenInfo1.jpg";
            burren1.Source = ImageSource.FromResource(burrenpic1, assembly);

            string burrenpic2 = "ClareTourismApp.Assets.Images.burrenInfo2.jpg";
            burren2.Source = ImageSource.FromResource(burrenpic2, assembly);

            string burrenpic3 = "ClareTourismApp.Assets.Images.burrenInfo3.jpg";
            burren3.Source = ImageSource.FromResource(burrenpic3, assembly);

            string walksBurren = "ClareTourismApp.Assets.Images.burrenWalks.jpg";
            burrenWalk.Source = ImageSource.FromResource(walksBurren, assembly);
        }
    }
}