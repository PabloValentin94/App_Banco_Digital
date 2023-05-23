using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;

namespace App_Banco_Digital
{

    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new View.Modules.Abertura.Abertura());

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
