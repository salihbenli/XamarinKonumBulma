using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDatabaseTutorial;
using SQLite;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {       
        Xamarin.Essentials.Location loca;            
        public Page1()
        {
            InitializeComponent(); 
			 Title = "Konum Bulma ve Kaydetme";
        }

        public async void btn(object sender, EventArgs e)
        {          
            GetLocation(); 
        }
        public async void GetLocation()
        {

            loca = await Geolocation.GetLastKnownLocationAsync();

            if (loca == null)
            {
                loca = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                }); ;
            }
            loc.Text = "enlem;  " + loca.Latitude.ToString() + "  boylam:   " + loca.Longitude.ToString();

            if (!string.IsNullOrWhiteSpace(nameEntry.Text)) 
            { 
                await App.Database.SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                  
                    enlem = loca.Latitude,
                    boylam = loca.Longitude,
                 });
                nameEntry.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPeopleAsync();
        }         
    }
}