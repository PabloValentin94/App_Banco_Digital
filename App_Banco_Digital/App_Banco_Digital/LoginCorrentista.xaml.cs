using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginCorrentista : ContentPage
    {

        public LoginCorrentista()
        {

            InitializeComponent();

            img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Logotipo_Digio.png");

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            try
            {



            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}