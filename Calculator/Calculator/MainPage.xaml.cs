using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        Models.Operaciones operations = new Models.Operaciones();
        public Decimal n1;
        public Decimal n2;
        public Decimal result;
        public MainPage()
        {
            InitializeComponent();  
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = operations.addition(n1, n2);

            await Navigation.PushAsync(new SecondPage(result));

            //await DisplayAlert("Suma", Convert.ToString(n1 + n2), "OK");
        }

        private async void btnsubstraction_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = operations.substraction(n1, n2);

            await Navigation.PushAsync(new SecondPage(result));
        }

        private async void btnmultiplication_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = operations.multiplication(n1, n2);

            await Navigation.PushAsync(new SecondPage(result));
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            n1 = Convert.ToDecimal(num1.Text);
            n2 = Convert.ToDecimal(num2.Text);

            result = operations.division(n1, n2);

            await Navigation.PushAsync(new SecondPage(result));
        }
    }
}
