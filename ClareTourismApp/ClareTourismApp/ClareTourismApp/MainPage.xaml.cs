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

            string smallCliffs = "ClareTourismApp.Assets.Images.CliffsSmall.jpg";
            cliffsSmall.Source = ImageSource.FromResource(smallCliffs, assembly);

            string smallBurren = "ClareTourismApp.Assets.Images.burren1.jpg";
            burrenSmall.Source = ImageSource.FromResource(smallBurren, assembly);

            string smallBunratty = "ClareTourismApp.Assets.Images.bunratty1.jpg";
            bunrattySmall.Source = ImageSource.FromResource(smallBunratty, assembly);

            string smallAilwee = "ClareTourismApp.Assets.Images.ailwee1.jpg";
            ailweeSmall.Source = ImageSource.FromResource(smallAilwee, assembly);

            string smallDoolin = "ClareTourismApp.Assets.Images.doolin1.jpg";
            doolinSmall.Source = ImageSource.FromResource(smallDoolin, assembly);

            string smallCraggaunowen = "ClareTourismApp.Assets.Images.craggaunowen1.jpg";
            craggaunowenSmall.Source = ImageSource.FromResource(smallCraggaunowen, assembly);

            string smallLahinch = "ClareTourismApp.Assets.Images.lahinch1.jpg";
            lahinchSmall.Source = ImageSource.FromResource(smallLahinch, assembly);




        }
    }
}
