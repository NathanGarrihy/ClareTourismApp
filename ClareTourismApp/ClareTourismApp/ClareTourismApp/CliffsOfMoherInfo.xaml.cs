﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClareTourismApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CliffsOfMoherInfo : ContentPage
	{
		public CliffsOfMoherInfo ()
		{
			InitializeComponent ();
            SetUpImagesOnPage();
		}

        private void SetUpImagesOnPage()
        {
            var assembly = typeof(CliffsOfMoherInfo);

            string cliffspic1 = "ClareTourismApp.Assets.Images.cliffsInfo1.jpg";
            cliffs1.Source = ImageSource.FromResource(cliffspic1, assembly);

            string cliffspic2 = "ClareTourismApp.Assets.Images.cliffsInfo2.jpg";
            cliffs2.Source = ImageSource.FromResource(cliffspic2, assembly);

            string cliffspic3 = "ClareTourismApp.Assets.Images.cliffsInfo3.jpg";
            cliffs3.Source = ImageSource.FromResource(cliffspic3, assembly);
        }
	}
}