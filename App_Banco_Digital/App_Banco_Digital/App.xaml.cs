﻿using System;
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

            MainPage = new LoginCorrentista();

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
