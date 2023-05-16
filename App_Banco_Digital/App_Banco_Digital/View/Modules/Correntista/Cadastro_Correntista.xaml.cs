using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View.Modules.Correntista
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro_Correntista : ContentPage
    {

        public Cadastro_Correntista()
        {

            InitializeComponent();

            img_cadastro_correntista.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets." +
                                              "Correntista.Cadastro_Correntista.jpg");

        }

    }

}