using System;
using System.Collections.Generic;
using LocalDatabaseTutorial;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mapsGo : ContentPage
    {
        
        public static List<Person> locat = new List<Person>();
        public static Person selectedLocation = new Person();
   
       public mapsGo()
        {
            InitializeComponent();
            
            Title = "Konum Seçimi";

            SetLocations();
    
        }

        private void SetLocations()
        {
            _pickerLocation.BindingContext = locat;
        }

        public async void btnkonumge(object sender, EventArgs e) 
        
        {
            Person selectedLocation = (Person)_pickerLocation.SelectedItem;
            await Map.OpenAsync(selectedLocation.enlem,selectedLocation.boylam, new MapLaunchOptions {Name="test" });
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            _pickerLocation.ItemsSource = await App.Database.GetPeopleAsync();
        }
    }
}
