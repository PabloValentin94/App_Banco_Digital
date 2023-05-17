using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.View.Modules;

namespace App_Banco_Digital.View.Modules.Menu
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {

        App propriedades_aplicativo = (App) Application.Current;

        public Menu()
        {

            InitializeComponent();

            img_logo_menu.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Menu.Logo_menu.png");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicio.Inicio)));

        }

        private async void btn_sair_Clicked(object sender, EventArgs e)
        {

            if(await DisplayAlert("Atenção!", "Deseja desvincular sua conta?", "Sim", "Não"))
            {

                this.propriedades_aplicativo.Properties.Remove("logado");

                this.propriedades_aplicativo.MainPage = new NavigationPage(new Login.Login());

            }

        }

    }

}