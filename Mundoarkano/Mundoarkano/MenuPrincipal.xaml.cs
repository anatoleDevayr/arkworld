using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mundoarkano
{
    public partial class MenuPrincipal : ContentPage
    {
        private class Menu
        {
            public string imagen { get; set; }
            public string nombre { get; set; }

            public override string ToString()
            {
                return nombre;
            }
        }

        ObservableCollection<Menu> menus = new ObservableCollection<Menu>();

        public MenuPrincipal()
        {
            InitializeComponent();
            listView.ItemsSource = menus;
            menus.Add(new Menu { imagen = "logoarkano.jpg", nombre = "MUNDO ARKANO" });
            menus.Add(new Menu { imagen = "logoarkano.jpg", nombre = "ADMINISTRACIÓN" });
            menus.Add(new Menu { imagen = "logoarkano.jpg", nombre = "TALENTOS" });
            menus.Add(new Menu { imagen = "logoarkano.jpg", nombre = "PROYECTOS" });
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            if (e.SelectedItem.ToString() == "MUNDO ARKANO")
                Navigation.PushAsync(new Kiosco());
            else if (e.SelectedItem.ToString() == "ADMINISTRACIÓN")
                Navigation.PushAsync(new ReservarSala());
            else if (e.SelectedItem.ToString() == "TALENTOS")
                Navigation.PushAsync(new LinksComunes());
        }

        void OnRecienteUnoMP(object sender, EventArgs e)
        {

        }

        void OnRecienteDosMP(object sender, EventArgs e)
        {

        }

        void OnRecienteTresMP(object sender, EventArgs e)
        {

        }

    }
}
