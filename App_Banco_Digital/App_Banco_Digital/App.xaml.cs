using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;
using App_Banco_Digital.View.Modules.Outros;

namespace App_Banco_Digital
{

    public partial class App : Application
    {

        public static Model.Correntista usuario_logado;

        public static Model.Conta conta_atual;

        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new LoginCorrentista());

            //MainPage = new View.Modules.ChavePix.CadastroChavePix();

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