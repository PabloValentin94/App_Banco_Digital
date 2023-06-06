using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.View.Modules.Correntista
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_Correntista : ContentPage
    {

        public Cadastro_Correntista()
        {

            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);

            img_banner_cadastro_correntista.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets." +
                                                                              "Correntista.Banner_Cadastro_Correntista.jpg");

        }

        private async void btn_cadastrar_correntista_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Correntista correntista = new Model.Correntista()
                {

                    nome = txt_nome_completo_correntista.Text,

                    cpf = txt_cpf_correntista.Text,

                    data_nascimento = dtpck_data_nascimento_correntista.Date,

                    senha_correntista = txt_senha_correntista.Text,

                    ativo = true

                };

                var retorno = await Data_Service_Correntista.RegisterAsync(correntista);

                if(retorno != null)
                {

                    await DisplayAlert("Atenção!", "Correntista cadastrado com sucesso.", "OK");

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