using Proiect_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proiect_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DestinationPage : ContentPage
    {
        public DestinationPage()
        {
            InitializeComponent();
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var bilet = (Bilet)BindingContext;
            await App.Database.SaveBiletAsync(bilet);
            await Navigation.PopAsync();

        }

        async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}