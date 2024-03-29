﻿using System;
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

            Inicializar();

        }

        private async void Inicializar()
        {

            try
            {

                NavigationPage.SetHasNavigationBar(this, false);

                img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Logotipo_Digio.png");

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            try
            {

                if(!String.IsNullOrWhiteSpace(txt_usuario.Text) && !String.IsNullOrWhiteSpace(txt_senha.Text))
                {

                    if(txt_usuario.Text == "Root" && txt_senha.Text == "Etecjau")
                    {

                        await DisplayAlert("Atenção!", "Iniciando operação de testes.", "OK");

                        App.Current.MainPage = new View.Modules.Outros.Menu();

                    }

                    else
                    {

                        string[] dados_login = { txt_usuario.Text, txt_senha.Text };

                        Correntista correntista_encontrado = await Model.Correntista.Login(dados_login);

                        if(correntista_encontrado != null)
                        {

                            await DisplayAlert("Atenção!", "Login efetuado com sucesso! Seja bem-vindo(a), " + txt_usuario.Text + ".", "OK");

                            App.usuario_logado = correntista_encontrado;

                            correntista_encontrado.dados_contas = await Model.Conta.Search(correntista_encontrado.id);

                            App.conta_atual = correntista_encontrado.dados_contas[0];

                            App.Current.MainPage = new View.Modules.Outros.Menu();

                        }

                        else
                        {

                            throw new Exception("Nenhum usuário encontrado! Verifique se você realmente está cadastrado e tente novamente.");

                        }

                    }

                }

                else
                {

                    throw new Exception("Preencha todos os campos antes de prosseguir.");

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

        private async void btn_senha_Clicked(object sender, EventArgs e)
        {

            try
            {

                if(txt_senha.IsPassword)
                {

                    txt_senha.IsPassword = false;

                    btn_senha.Text = "Ocultar senha";

                }

                else
                {

                    txt_senha.IsPassword = true;

                    btn_senha.Text = "Exibir senha";

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}