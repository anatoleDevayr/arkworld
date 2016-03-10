using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mundoarkano
{
    public partial class SubMenuMundoArk : ContentPage
    {
        public SubMenuMundoArk()
        {
            InitializeComponent();
        }

        void OnClickCeroDos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kiosco());
        }

        void OnClickUnoCero(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IncidentesInternos());
        }

        void OnClickUnoDos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReservarSala());
        }

        void OnClickDosDos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LinksComunes());
        }


    }
}
