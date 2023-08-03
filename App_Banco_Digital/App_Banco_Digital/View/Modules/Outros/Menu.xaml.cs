using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Banco_Digital.View.Modules;

namespace App_Banco_Digital.View.Modules.Outros
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {

        public Menu()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            img_logo.Source = ImageSource.FromResource("App_Banco_Digital.View.Assets.Logotipo_Digio.png");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Outros.Home)));

            IsPresented = false;

        }

    }

}