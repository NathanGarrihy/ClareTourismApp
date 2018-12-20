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
	public partial class DoolinInfo : ContentPage
	{
		public DoolinInfo ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
        }

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(DoolinInfo);

            string smallDoolin1 = "ClareTourismApp.Assets.Images.doolinSmall1.jpg";
            doolinSmall1.Source = ImageSource.FromResource(smallDoolin1, assembly);

            string smallDoolin2 = "ClareTourismApp.Assets.Images.doolinSmall2.jpg";
            doolinSmall2.Source = ImageSource.FromResource(smallDoolin2, assembly);

            string smallDoolin3 = "ClareTourismApp.Assets.Images.doolinSmall3.jpg";
            doolinSmall3.Source = ImageSource.FromResource(smallDoolin3, assembly);

            string largeDoolin1 = "ClareTourismApp.Assets.Images.doolinLarge1.jpg";
            doolinLarge1.Source = ImageSource.FromResource(largeDoolin1, assembly);

            string largeDoolin2 = "ClareTourismApp.Assets.Images.doolinLarge2.jpg";
            doolinLarge2.Source = ImageSource.FromResource(largeDoolin2, assembly);

        }
    }
}