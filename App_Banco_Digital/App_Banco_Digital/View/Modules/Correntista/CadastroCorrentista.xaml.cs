using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.View.Modules.Correntista
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCorrentista : ContentPage
    {

        public CadastroCorrentista()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            dtpck_data_nascimento_correntista.Date = DateTime.Now.Date;

        }

        private async void btn_cadastrar_correntista_Clicked(object sender, EventArgs e)
        {

            try
            {

                Model.Correntista model = new Model.Correntista()
                {

                    nome = txt_nome_correntista.Text,

                    cpf = txt_cpf_correntista.Text.Replace(".", "").Replace("-", ""),

                    data_nascimento = dtpck_data_nascimento_correntista.Date,

                    senha_correntista = txt_senha_correntista.Text

                };

                Model.Correntista retorno = await Data_Service_Correntista.SaveAsyncCorrentista(model);

                if(retorno.id_correntista != null)
                {

                    await DisplayAlert("Atenção!", "Cadastro efetuado com sucesso.", "OK");

                    await Navigation.PopAsync();

                }

                else
                {

                    throw new Exception("Não foi possível efetuar o cadastro! Tente novamente.");

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}