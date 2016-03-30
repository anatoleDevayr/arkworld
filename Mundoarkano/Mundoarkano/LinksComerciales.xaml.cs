using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mundoarkano
{
    public partial class LinksComerciales : ContentPage
    {
        ObservableCollection<Link> links = new ObservableCollection<Link>();

        public LinksComerciales()
        {
            InitializeComponent();
            LinkView.ItemsSource = links;
            links.Add(new Link { nombre = "Google", url = "www.google.com" });
            links.Add(new Link { nombre = "Chau", url = "www.chau.com" });
            links.Add(new Link { nombre = "Hola", url = "www.hola.com" });
            links.Add(new Link { nombre = "Tunein", url = "www.tunein.com" });
            links.Add(new Link { nombre = "Facebook", url = "www.facebook.com" });
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            String url = e.SelectedItem.ToString();
            Uri u = new Uri("http://" + url);
            Xamarin.Forms.Device.OpenUri(u);
        }
    }
}
