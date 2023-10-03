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

                Model.Correntista dados = new Model.Correntista()
                {

                    nome = txt_nome_correntista.Text,

                    cpf = txt_cpf_correntista.Text,

                    email = txt_email_correntista.Text,

                    data_nascimento = dtpck_data_nascimento_correntista.Date.ToString("yyyy-MM-dd"),

                    senha = txt_senha_correntista.Text

                };

                if(Convert.ToBoolean(await dados.Save()))
                {

                    await DisplayAlert("Atenção!", "Dados salvos com sucesso.", "OK");

                    await Navigation.PopAsync();

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}