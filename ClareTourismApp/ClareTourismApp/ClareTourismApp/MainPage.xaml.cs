using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClareTourismApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetupImagesOnMainPage();
        }

        private void Cliffsbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CliffsOfMoher());
        }

        private void Burrenbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Burren());
        }

        private void Bunrattybtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bunratty());
        }

        private void AilweeCavebtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AilweeCave());
        }

        private void Doolinbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Doolin());
        }

        private void Craggaunowenbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Craggaunowen());
        }

        private void Lahinchbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Lahinch());
        }

        private void SetupImagesOnMainPage()
        {
            //  get the assembly
            var assembly = typeof(MainPage);

            string strFilename = "ClareTourismApp.Assets.Images.CliffsSmall.jpg";

            cliffsSmall.Source = ImageSource.FromResource(strFilename, assembly);

        }
    }
}
