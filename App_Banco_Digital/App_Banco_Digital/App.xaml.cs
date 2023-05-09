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

            MainPage = new View.Login.Pages.Login();

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
