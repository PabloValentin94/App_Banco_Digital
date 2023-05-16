using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.Service;
using App_Banco_Digital.View.Modules;

namespace App_Banco_Digital.View.Modules.Login
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        App propriedades_aplicacao;

        public Login()
        {

            InitializeComponent();

            this.propriedades_aplicacao = (App) Application.Current;

            NavigationPage.SetHasNavigationBar(this, false);

            img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Login.Logo.png");

        }

        private async void btn_entrar_Clicked(object sender, EventArgs e)
        {

            try
            {

                actInd_buscando_usuarios.IsRunning = true;

                List<Model.Correntista> lista_correntistas = await Data_Service_Correntista.GetListAsync();

                if(lista_correntistas.Count > 0)
                {

                    if(lista_correntistas.Any(i => (i.nome == txt_usuario.Text && i.senha_correntista == txt_senha.Text)))
                    {

                        if(chbox_persistencia.IsChecked == true)
                        {

                            this.propriedades_aplicacao.Properties.Add("logado", true);

                            this.propriedades_aplicacao.MainPage = new NavigationPage(new Inicio.Inicio());

                        }

                        await DisplayAlert("Aviso!", "Login efetuado com sucesso. Seja bem-vindo(a)!", "OK");

                        await Navigation.PushAsync(new Inicio.Inicio());

                    }

                    else
                    {

                        await DisplayAlert("Aviso!", "Falha no login! Tente novamente.", "OK");

                    }

                }

                else
                {

                    await DisplayAlert("Atenção!", "Nenhum usuário existente no sistema.", "OK");

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

            finally
            {

                actInd_buscando_usuarios.IsRunning = false;

            }

        }

        private async void btn_redirecionar_cadastro_conta_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Correntista.Cadastro_Correntista());

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_mostrar_ocultar_senha_Clicked(object sender, EventArgs e)
        {

            try
            {

                if (txt_senha.IsPassword)
                {

                    txt_senha.IsPassword = false;

                    btn_mostrar_ocultar_senha.Text = "Ocultar senha";

                }

                else
                {

                    txt_senha.IsPassword = true;

                    btn_mostrar_ocultar_senha.Text = "Exibir senha";

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}