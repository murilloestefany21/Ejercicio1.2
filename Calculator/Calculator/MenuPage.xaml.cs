using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPag : ContentPage
    {
        public MenuPag()
        {
            InitializeComponent();
        }

        private async void btnApp1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void btnApp2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.BindingPage());
        }
    }
}