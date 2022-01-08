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
    public partial class MyRoutesPage : ContentPage
    {
        public MyRoutesPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listaPrincipala.ItemsSource = await App.Database.GetBileteAsync();
        }

        /*async private void listaPrincipala_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new BoardingPassPage());
            }
        }*/

        async private void CheckIn_Clicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoardingPassPage());
        }

        async private void AddButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DestinationPage
            {
                BindingContext = new Bilet()
            });
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {

        }

        
    }
}