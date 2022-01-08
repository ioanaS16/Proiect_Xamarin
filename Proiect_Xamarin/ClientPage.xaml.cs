using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Proiect_Xamarin.Models;
using System.Globalization;

namespace Proiect_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientPage : ContentPage
    {
        public ClientPage()
        {
            InitializeComponent();
        }

        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entry_ID.Text) || !string.IsNullOrEmpty(entry_nume.Text) || !string.IsNullOrEmpty(entry_prenume.Text) || !string.IsNullOrEmpty(entry_email.Text) || !string.IsNullOrEmpty(entry_parola.Text))
            {
                /*var dataNast = DateTime.ParseExact(entry_data.Text, "DD-MM-YYYY HH:MM:SS:TT", CultureInfo.InvariantCulture);

                if (!DateTime.TryParse(entry_data.Text, out dataNast))
                {
                    await DisplayAlert("Eroare", "Ati introdus data nasterii gresit!", "OK");
                }*/

                /*Client client = new Client()
                 {
                     ID = int.Parse(entry_ID.Text),
                     Nume = entry_nume.Text,
                     Prenume = entry_prenume.Text,
                     Email = entry_email.Text,
                     Parola = entry_parola.Text
                 };*/
                var client = (Client)BindingContext;
                await App.Database.SaveClientAsync(client);
                await DisplayAlert("Informare", "Datele au fost preluate!",client.ID.ToString(), "OK");
                await Navigation.PopAsync();
                }
            else
                {
                    await DisplayAlert("Eroare", "Completati toate campurile!", "OK");
                }
            
        }

        private async void btnView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyClientsPage
            {
                BindingContext = new Client()
            });
        }
    }
}