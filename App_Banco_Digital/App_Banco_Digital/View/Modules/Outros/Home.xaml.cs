using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Banco_Digital.View.Modules.Outros
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        public Home()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            //btn_menu.IconImageSource = ImageSource.FromResource("App_Banco_Digital.View.Assets.Usuario.png");

        }

    }

}