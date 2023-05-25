using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.View.Modules;

namespace App_Banco_Digital.View.Modules.Abertura
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abertura : ContentPage
    {

        public Abertura()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            img_logo_abertura.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets." +
                                       "Abertura.Logo_abertura.png");

        }

        private async void btn_criar_conta_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Conta.Cadastro_Conta());

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Login.Login());

        }

    }

}