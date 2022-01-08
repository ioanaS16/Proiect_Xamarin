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
    public partial class MyClientsPage : ContentPage
    {
        public MyClientsPage()
        {
            InitializeComponent();
        }

       /* protected override async void OnAppearing()
        {
            base.OnAppearing();
            listaClienti.ItemsSource = await App.Database.GetClientAsync();
        }*/

        private async void btnShow_Clicked(object sender, EventArgs e)
        {
            listaClienti.ItemsSource = await App.Database.GetClientAsync();
        }
    }
}