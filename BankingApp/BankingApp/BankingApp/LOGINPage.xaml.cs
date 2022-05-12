using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LOGINPage : ContentPage
    {
        public LOGINPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(5000);

            await Navigation.PushAsync(new DetailsPage());
        }


        public void BankingApp_Clicked(object sender, EventArgs e)
        {


           


        }

        private void ROMOTE_Clicked(object sender, EventArgs e)
        {

        }

        private void BuyPrePaid_Clicked(object sender, EventArgs e)
        {

        }
      
        private void BuyElectricity_Clicked(object sender, EventArgs e)
        {

        }

        private void PayBeneficiary_Clicked(object sender, EventArgs e)
        {

        }

        private void TransferMoney_Clicked(object sender, EventArgs e)
        {

        }

        private void TrackMoney_Clicked(object sender, EventArgs e)
        {

        }




    }
}