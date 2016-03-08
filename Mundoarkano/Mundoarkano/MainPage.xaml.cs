using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Mundoarkano
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnIngresar(object sender, EventArgs e)
        {
            if (entryUsuario.Text != "" || entryContrasena.Text != "")
            {
                if (validarUsuario(entryUsuario.Text, entryContrasena.Text))
                {
                    Navigation.PushAsync(new MenuPrincipal());
                }
            }
        }

        bool validarUsuario(String user, String pass)
        {
            //Chequear usuario, si es correcto, el siguiente cóodigo
            Mundoarkano.App.usuarioActivo = user;
            return true;
        }
    }
}
