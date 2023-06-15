using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.View;
using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginCorrentista : ContentPage
    {

        public LoginCorrentista()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Logotipo_Digio.png");

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            try
            {

                if(!String.IsNullOrEmpty(txt_usuario.Text) && !String.IsNullOrEmpty(txt_senha.Text))
                {

                    string[] dados_login = {txt_usuario.Text, txt_senha.Text};

                    List<Correntista> correntista_encontrado = await Data_Service_Correntista.LoginAsyncCorrentista(dados_login);

                    if(correntista_encontrado.Count > 0)
                    {

                        await DisplayAlert("Atenção!", "Login efetuado com sucesso.", "OK");

                        App.Current.MainPage = new NavigationPage(new View.Modules.Outros.Home());

                    }

                    else
                    {

                        await DisplayAlert("Atenção!", "Nenhum usuário encontrado! Verifique " +
                                           "se você realmente está cadastrado e tente novamente.", "OK");

                    }

                }

                else
                {

                    await DisplayAlert("Atenção!", "Preencha todos os campos antes de prosseguir.", "OK");

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_cadastrar_correntista_Clicked(object sender, EventArgs e)
        {

            try
            {

                txt_usuario.Text = "";

                txt_senha.Text = "";

                await Navigation.PushAsync(new View.Modules.Correntista.CadastroCorrentista());

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}