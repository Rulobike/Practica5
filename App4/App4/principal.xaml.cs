using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Info(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Formulario());
        }

        private void Calculadora(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new calculadora());
        }
    }
}
