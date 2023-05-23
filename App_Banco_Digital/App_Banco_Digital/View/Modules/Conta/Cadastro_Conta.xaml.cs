using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.View.Modules.Conta
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_Conta : ContentPage
    {

        Random gerador_numeros = new Random();

        string[] tipos_conta = {"Selecione o tipo da sua conta bancária", "Conta Corrente"};

        public Cadastro_Conta()
        {

            InitializeComponent();

            img_banner_cadastro_conta.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets." +
                                               "Conta.Banner_cadastro_conta.jpg");

            pck_tipo_conta.ItemsSource = this.tipos_conta;

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void btn_cadastrar_conta_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Conta dados = new Model.Conta()
                {

                    numero = gerador_numeros.Next(1, 100),

                    tipo = pck_tipo_conta.SelectedItem.ToString(),

                    senha_conta = txt_senha_conta.Text,

                    ativa = true

                };

                dados.fk_correntista = dados.numero;

                await Data_Service_Conta.RegisterAsync(dados);

                if(dados.id_conta != null)
                {

                    await Navigation.PopAsync();

                }

                else
                {

                    await DisplayAlert("Atenção!", "Erro ao tentar efetuar o cadastro! Tente novamente.", "OK");

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}