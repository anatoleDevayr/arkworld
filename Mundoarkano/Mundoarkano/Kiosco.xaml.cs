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
        public Kiosco()
        {
            InitializeComponent();
			pickerCantidad.Opacity = 1;
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

        private void enviarEmail()
        {

        }
    }
}
