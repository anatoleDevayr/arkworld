using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Mundoarkano
{
    public partial class ReservarSala : ContentPage
    {
        public ReservarSala()
        {
            InitializeComponent();
            dateFechaSala.Format = "D";
        }

        void OnReservarSalaRS(object sender, EventArgs e)
        {
            DisplayAlert("Prueba", dateFechaSala.Date.Year.ToString(), "OK");
        }
    }
}
