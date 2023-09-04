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

        private async void Inicializar()
        {

            try
            {

                // NavigationPage.SetHasNavigationBar(this, false);

                string caminho_fixo = "App_Banco_Digital.View.Assets.";

                btn_menu.IconImageSource = ImageSource.FromResource(caminho_fixo + "Usuario.png");

                imgbtn_pagar.Source = ImageSource.FromResource(caminho_fixo + "Pagar.png");

                imgbtn_pix.Source = ImageSource.FromResource(caminho_fixo + "Pix.png");

                imgbtn_trasnferir.Source = ImageSource.FromResource(caminho_fixo + "Transferir.png");

                imgbtn_cobrar.Source = ImageSource.FromResource(caminho_fixo + "Cobrar.png");

                img_banner.Source = ImageSource.FromResource(caminho_fixo + "Cartao.png");

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_menu_Clicked(object sender, EventArgs e)
        {

            try
            {

                await DisplayAlert("Atenção!", "Você está conectado.", "OK");

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void imgbtn_pagar_Clicked(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void imgbtn_pix_Clicked(object sender, EventArgs e)
        {

        }

        private async void imgbtn_trasnferir_Clicked(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void imgbtn_cobrar_Clicked(object sender, EventArgs e)
        {

            try
            {



            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}