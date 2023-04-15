using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PROYECTO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class paginainicio : ContentPage
    {
        public paginainicio()
        {
            InitializeComponent();
        }

        private async void AgregarCliente_Clicked(object sender, EventArgs e)
        {
            var page = new MainPage();
            await Navigation.PushAsync(page);
            
        }

        private async void FACTURAR_Clicked(object sender, EventArgs e)
        {
            var page = new FACTURA();
            await Navigation.PushAsync(page);
        }
    }
}