using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.View.Modules;

namespace App_Banco_Digital.View.Modules.Outros
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {

        public Menu()
        {

            InitializeComponent();

            Inicializar();

        }

        private async void Inicializar()
        {

            try
            {

                NavigationPage.SetHasNavigationBar(this, false);

                img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Logotipo_Digio.png");

                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(View.Modules.Outros.Home)));

                IsPresented = false;

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void Mudar_Pagina(Type tipo)
        {

            try
            {

                if(await DisplayAlert("Atenção!", "A página atual será fechada! Tem certeza de que deseja prosseguir?", "Sim", "Não"))
                {

                    Detail = new NavigationPage((Page)Activator.CreateInstance(tipo));

                    IsPresented = false;

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void btn_home_Clicked(object sender, EventArgs e)
        {

            Mudar_Pagina(typeof(View.Modules.Outros.Home));

        }

        private void btn_chaves_pix_Clicked(object sender, EventArgs e)
        {

            Mudar_Pagina(typeof(View.Modules.ChavePix.CadastroChavePix));

        }

        private async void btn_sair_Clicked(object sender, EventArgs e)
        {

            try
            {

                if(await DisplayAlert("Atenção!", "Deseja desconectar sua conta?", "Sim", "Não"))
                {

                    App.Current.MainPage = new NavigationPage(new LoginCorrentista());

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}