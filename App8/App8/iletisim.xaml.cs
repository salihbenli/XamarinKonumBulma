using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class iletisim : ContentPage
    {
        public iletisim()
        {
            InitializeComponent();
			 Title = "Konum Ayarları";
        }

        public async void Btn_Kyt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        public async void Btn_Kyt_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mapsGo());
        }
    }
}