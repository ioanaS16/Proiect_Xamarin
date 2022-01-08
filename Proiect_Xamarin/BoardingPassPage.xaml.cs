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
    public partial class BoardingPassPage : ContentPage
    {
        public BoardingPassPage()
        {
            InitializeComponent();
        }


        private async void btnOK_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(editorID.Text))
            {
                var zborID = await App.Database.GetBileteAsync(int.Parse(editorID.Text));
                if (zborID != null)
                {
                    labelDecolare.Text = zborID.ID_aeroport_decolare;
                    labelAterizare.Text = zborID.ID_aeroport_aterizare;
                    labelData.Text = zborID.Data.ToString();
                    labelPret.Text = zborID.Pret.ToString();
                }
                else
                {
                    await DisplayAlert("Eroare", "Numarul zborului este incorect", "OK");
                }
            }
            else
            {
                await DisplayAlert("Eroare", "Introduceti numarul zborului", "OK");
            }
        }

        async void BoardingPassButton_Clicked(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(editorLoc.Text) || string.IsNullOrEmpty(editorPoarta.Text) || string.IsNullOrEmpty(editorTerminal.Text))
            {
                await DisplayAlert("Completare obligatorie", "Completati cu datele primite pe email!", "OK");
            }

            else 
            {
                BoardingPass bp = new BoardingPass()
                {
                    ID_zbor = Convert.ToInt32(editorID.Text),
                    Loc = editorLoc.Text,
                    Poarta = editorPoarta.Text,
                    Terminal = Convert.ToInt32(editorTerminal.Text)

                };

                await App.Database.SaveBoardingPassAsync(bp);
                await DisplayAlert("Succes", "Check-in-ul s-a realizat cu succes!", "OK");

                FinalBoardingPassPage page = new FinalBoardingPassPage();
                page.BindingContext = bp;
                await Navigation.PushAsync(page);
            }
           
            

        }
    }
}