using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View.Modules.Outros
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        public Home()
        {

            InitializeComponent();

            Inicializar();

        }

        private void Inicializar()
        {

            // NavigationPage.SetHasNavigationBar(this, false);

            btn_menu.IconImageSource = ImageSource.FromResource("App_Banco_Digital.View.Assets.Usuario.png");

            imgbtn_pagar.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Pagar.png");

            imgbtn_pix.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Pix.png");

            imgbtn_trasnferir.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Transferir.png");

            imgbtn_cobrar.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Cobrar.png");

        }

        private async void btn_menu_Clicked(object sender, EventArgs e)
        {

            await DisplayAlert("Atenção!", "Você está conectado.", "OK");

        }

        private void imgbtn_pagar_Clicked(object sender, EventArgs e)
        {



        }

        private void imgbtn_pix_Clicked(object sender, EventArgs e)
        {

        }

        private void imgbtn_trasnferir_Clicked(object sender, EventArgs e)
        {



        }

        private void imgbtn_cobrar_Clicked(object sender, EventArgs e)
        {



        }

    }

}