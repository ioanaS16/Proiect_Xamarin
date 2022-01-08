using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proiect_Xamarin.Models;

namespace Proiect_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        
        public LogInPage()
        {
            InitializeComponent();
        }

        private async void btnSgnIN_Clicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(entID.Text) || !string.IsNullOrEmpty(entParola.Text))
            {
                var client = await App.Database.GetClientAsync(int.Parse(entID.Text));
                await Navigation.PushAsync(new MyRoutesPage());
                /*if (client != null)
                 {
                     await Navigation.PushAsync(new MyRoutesPage());
                 }
                 else
                 {
                     await DisplayAlert("Eroare", "ID invalid! Incearca din nou sau inregistreaza-te!", "OK");
                 }*/


            }
             else
             {
                await DisplayAlert("Eroare", "Completati toate campurile!", "OK");
             }

        }

           
        private async void btnSgnUP_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ClientPage
            {
                BindingContext = new Client()
            });
        }
        
    }
}