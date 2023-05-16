using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital
{

    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();

            if(this.Properties.ContainsKey("logado"))
            {

                MainPage = new NavigationPage(new View.Modules.Inicio.Inicio());

            }

            else
            {

                MainPage = new NavigationPage(new View.Modules.Login.Login());

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
