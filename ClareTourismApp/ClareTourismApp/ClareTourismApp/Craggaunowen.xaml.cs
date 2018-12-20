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
	public partial class Craggaunowen : ContentPage
	{
		public Craggaunowen ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
		}

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(Craggaunowen);

            string craggaunowenPic1 = "ClareTourismApp.Assets.Images.craggaunowen1.jpg";
            craggaunowen1.Source = ImageSource.FromResource(craggaunowenPic1, assembly);

            string craggaunowenPic2 = "ClareTourismApp.Assets.Images.craggaunowen2.jpg";
            craggaunowen2.Source = ImageSource.FromResource(craggaunowenPic2, assembly);

            string craggaunowenPic3 = "ClareTourismApp.Assets.Images.craggaunowen3.jpg";
            craggaunowen3.Source = ImageSource.FromResource(craggaunowenPic3, assembly);

            string largeCraggaunowen = "ClareTourismApp.Assets.Images.craggaunowenLarge.jpg";
            craggaunowenLarge.Source = ImageSource.FromResource(largeCraggaunowen, assembly);

            string largeCraggaunowen2 = "ClareTourismApp.Assets.Images.craggaunowenLarge2.jpg";
            craggaunowenLarge2.Source = ImageSource.FromResource(largeCraggaunowen2, assembly);
        }
    }
}