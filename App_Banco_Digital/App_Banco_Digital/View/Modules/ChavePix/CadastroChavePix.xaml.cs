using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View.Modules.ChavePix
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroChavePix : ContentPage
    {

        private int tipo_chave_pix;

        public CadastroChavePix()
        {

            InitializeComponent();

        }

        private async void Inicializar()
        {

            try
            {



            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private void Trocar_Valor_Checkbox()
        {

            string valor_chave;

            if(rdbtn_cpf.IsChecked)
            {

                valor_chave = rdbtn_cpf.Value.ToString();

            }

            else
            {

                if(rdbtn_cnpj.IsChecked)
                {

                    valor_chave = rdbtn_cnpj.Value.ToString();

                }

                else
                {

                    if(rdbtn_telefone.IsChecked)
                    {

                        valor_chave = rdbtn_telefone.Value.ToString();

                    }

                    else
                    {

                        if(rdbtn_email.IsChecked)
                        {

                            valor_chave = rdbtn_email.Value.ToString();

                        }

                        else
                        {

                            valor_chave = rdbtn_aleatoria.Value.ToString();

                        }

                    }

                }

            }

            this.tipo_chave_pix = int.Parse(valor_chave);

        }

        private async void rdbtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

            try
            {

                Trocar_Valor_Checkbox();

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_cadastrar_chave_pix_Clicked(object sender, EventArgs e)
        {

            try
            {

                bool[] opcoes_chave = { rdbtn_cpf.IsChecked, rdbtn_cnpj.IsChecked,
                                        rdbtn_telefone.IsChecked, rdbtn_email.IsChecked,
                                        rdbtn_aleatoria.IsChecked };

                int condicao = 0;

                for(int i = 0; i < 5; i++)
                {

                    if(!opcoes_chave[i])
                    {

                        condicao++;

                    }

                }

                if(condicao == 5)
                {

                    await DisplayAlert("Atenção!", "Selecione uma das opções.", "OK");

                }

                else
                {

                    string[] valores_chave_pix = { "CPF", "CNPJ", "Email", "Telefone", "Aleatoria" };

                    string chave_pix = await DisplayPromptAsync("Salvando chave pix.", "Insira abaixo:",
                                                                "Salvar", "Cancelar", "Insira a chave pix",
                                                                20, Keyboard.Text);

                    Model.Chave_Pix dados = new Model.Chave_Pix()
                    {

                        chave = chave_pix,

                        tipo = valores_chave_pix[this.tipo_chave_pix]

                    };

                    if(Convert.ToBoolean(dados.Save()))
                    {

                        await DisplayAlert("Atenção!", "Dados salvos com sucesso.", "OK");

                    }

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}