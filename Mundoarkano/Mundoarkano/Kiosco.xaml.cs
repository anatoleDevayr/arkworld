using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mundoarkano
{
    public partial class Kiosco : ContentPage
    {
        private TrabKioscoModel estado;
        private List<String> cantidad;

        public Kiosco()
        {
            InitializeComponent();
            this.estado = new TrabKioscoModel();
            this.cantidad = new List<String>();
            this.cantidad.Add("1");
            this.cantidad.Add("2");
            this.cantidad.Add("3");
            this.cantidad.Add("4");
            this.cantidad.Add("5");
            this.cantidad.Add("6");
            this.cantidad.Add("7");
            this.cantidad.Add("8");
            this.cantidad.Add("9");
            this.cantidad.Add("10");
            this.cargarPicker();
        }

        private void cargarPicker()
        {
            foreach (String c in cantidad)
            {
                pickerCantidad.Items.Add(c);
            }
        }

        void OnComprarK(object sender, EventArgs e)
        {
            if (ChequeoDatos())
            {
                enviarEmail();
            }
        }

        private bool ChequeoDatos()
        {
            if (entryProductoK.Text == "")
            {
                DisplayAlert("Error", "Ingrese el producto que desea comprar", "OK");
                return false;
            }
            else if (pickerCantidad.SelectedIndex == -1)
            {
                DisplayAlert("Error", "Seleccione la cantidad que desea comprar", "OK");
                return false;
            }
            return true;
        }

        private async void enviarEmail()
        {
            var email = DependencyService.Get<IEmail>();
            if (email != null)
            {

                estado.estaTrabajando = true;
                estado.btnComprarHabilitado = false;
                estado.editTextHabilitado = false;
                estado.pickerCantidadHabilitado = false;

                entryProductoK.IsEnabled = estado.editTextHabilitado;
                pickerCantidad.IsEnabled = estado.pickerCantidadHabilitado;
                btnComprarK.IsEnabled = estado.btnComprarHabilitado;
                reloj.IsRunning = estado.estaTrabajando;

                String cuerpo = "El usuario " + App.usuarioActivo + " compró " + cantidad[pickerCantidad.SelectedIndex] +
                                " unidades del producto " + entryProductoK.Text.ToString();
                await Task.Delay(500);
                email.EnviarMail("mundoarkano@arkanosoft.com", "ramiro.sala85@gmail.com", "Compra en Kiosco", cuerpo);
            }

            await DisplayAlert("OK", "La compra fue realizada exitosamente", "OK");
            estado.estaTrabajando = false;
            estado.btnComprarHabilitado = true;
            estado.editTextHabilitado = true;
            estado.pickerCantidadHabilitado = true;

            entryProductoK.IsEnabled = estado.editTextHabilitado;
            pickerCantidad.IsEnabled = estado.pickerCantidadHabilitado;
            btnComprarK.IsEnabled = estado.btnComprarHabilitado;
            reloj.IsRunning = estado.estaTrabajando;
        }
    }
}
