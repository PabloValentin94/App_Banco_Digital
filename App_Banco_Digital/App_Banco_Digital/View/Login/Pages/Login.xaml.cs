using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.Service;

namespace App_Banco_Digital.View.Login.Pages
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {

        public Login()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Login.Assets.Images.Logo.png");

        }

        private async void btn_entrar_Clicked(object sender, EventArgs e)
        {

            List<Model.Correntista> lista_correntistas = await Data_Service_Correntista.GetListAsync();

            //Console.WriteLine(lista_correntistas.Count);

            if(lista_correntistas.Any(i => (i.nome == txt_usuario.Text && i.senha_correntista == txt_senha.Text)))
            {

                await DisplayAlert("Aviso!", "Login efetuado com sucesso!", "OK");

                /*for(int i = 0; i < lista_correntistas.Count; i++)
                {

                    Console.WriteLine(lista_correntistas[i].nome);

                }*/

            }

            else
            {

                await DisplayAlert("Aviso!", "Falha no login! Tente novamente.", "OK");

            }

        }

        private void btn_redirecionar_cadastro_conta_Clicked(object sender, EventArgs e)
        {



        }

        private void btn_mostrar_ocultar_senha_Clicked(object sender, EventArgs e)
        {

            if(txt_senha.IsPassword)
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

    }

}