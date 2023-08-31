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

        private async void btn_cadastrar_chave_pix_Clicked(object sender, EventArgs e)
        {

            try
            {



            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}