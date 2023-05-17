using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;

namespace App_Banco_Digital
{

    public partial class App : Application
    {

        public List<Model.Correntista> lista_local_correntistas = new List<Model.Correntista>()
        {

            new Model.Correntista()
            {

                id_correntista = 1,

                nome = "Pablo",

                cpf = "12345678910",

                data_nascimento = DateTime.Now,

                senha_correntista = "1234",

                ativo = true

            }

        };

        public App()
        {

            InitializeComponent();

            if(!this.Properties.ContainsKey("logado"))
            {

                MainPage = new NavigationPage(new View.Modules.Abertura.Abertura());

            }

            else
            {

                MainPage = new View.Modules.Menu.Menu();

            }

        }

        protected override void OnStart()
        {



        }

        protected override void OnSleep()
        {



        }

        protected override void OnResume()
        {



        }
    }
}
