using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View.Modules.Conta
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_Conta : ContentPage
    {

        string[] tipos_conta = {"Conta Corrente"};

        public Cadastro_Conta()
        {

            InitializeComponent();

            img_banner_cadastro_conta.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets." +
                                               "Conta.Banner_cadastro_conta.jpg");

            pck_tipo_conta.ItemsSource = this.tipos_conta;

            NavigationPage.SetHasNavigationBar(this, false);

        }

    }

}