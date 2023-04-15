using PROYECTO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PROYECTO.controler;
using System.Xml.Schema;
using Xamarin.Essentials;
using System.ComponentModel.Design;

namespace PROYECTO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FACTURA : ContentPage
    {
        public FACTURA()
        {
            InitializeComponent();
           string   total = "400 LPS";
            txttotal .Text = total.ToString();
            Console.WriteLine("+" + total + "+ ", "OK");
        }

        private async void Generar_Clicked(object sender, EventArgs e)
        {
            var empleado = await App.Database.buscar(Convert.ToInt32(txtcodigo.Text));
            if (empleado == null)
            {
                await DisplayAlert("Advertencia", "Cliente no encontrado", "OK");
                return;

            }
            else if (meses == null)
            { 
                 
            return;
        }
            
            else
            {

                txtcodigo.Text = empleado.codigo.ToString();
                txtnombre.Text = empleado.nombre;
                txtpais.Text = empleado.pais;
                txtdepartamento.Text = empleado.departamento;
                txtmunicipio.Text = empleado.municipio;
                txtresidencia.Text = empleado.residencia;

                
            }
           
            
            Generar.IsVisible = false;
            txtfactura.IsVisible = true;
            txtcodigo.IsVisible = true;
            txtnombre.IsVisible = true;
            txtpais.IsVisible = true;
            txtdepartamento.IsVisible = true;
            txtmunicipio.IsVisible = true;
            txtresidencia.IsVisible = true;
            to.IsVisible=true;
            txttotal.IsVisible = true;
            
            
          

        }

        private void meses_SelectedIndexChanged(object sender, EventArgs e, total total)
        {
           
        }

        private void meses_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

       
    }
}