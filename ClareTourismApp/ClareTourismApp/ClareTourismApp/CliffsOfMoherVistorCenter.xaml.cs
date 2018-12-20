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
	public partial class CliffsOhMoherVistorCenter : ContentPage
	{
		public CliffsOhMoherVistorCenter ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
		}

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(CliffsOhMoherVistorCenter);

            string Vcliffs1 = "ClareTourismApp.Assets.Images.cliffsVisitor1.jpg";
            cliffsV1.Source = ImageSource.FromResource(Vcliffs1, assembly);

            string Vcliffs2 = "ClareTourismApp.Assets.Images.cliffsVisitor2.jpg";
            cliffsV2.Source = ImageSource.FromResource(Vcliffs2, assembly);

            string Vcliffs3 = "ClareTourismApp.Assets.Images.cliffsVisitor3.jpg";
            cliffsV3.Source = ImageSource.FromResource(Vcliffs3, assembly);

            string largeVisitor = "ClareTourismApp.Assets.Images.visitorCenter.jpg";
            visitorCenter.Source = ImageSource.FromResource(largeVisitor, assembly);

        }
    }
}