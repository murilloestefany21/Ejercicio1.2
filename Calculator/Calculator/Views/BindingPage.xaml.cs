using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingPage : ContentPage
    {
        public BindingPage()
        {
            InitializeComponent();
        }

        private async void btnbinding_Clicked(object sender, EventArgs e)
        {
            var personas = new Models.Personas
            {
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo = txtcorreo.Text
            };

            var secondPage = new Views.ResultPage1();
            secondPage.BindingContext = personas;
            await Navigation.PushAsync(secondPage);
        }
    }
}