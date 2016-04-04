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
		List<String> salas = new List<String>();
        String prueba = "unaPruebaParaGit";
        String prueba2 = "Prueba modificando yo";
        String nueva = "La prueba nuevba";
        String nuevanueva = "Prueba 4";

        public ReservarSala()
        {
            InitializeComponent();
            dateFechaSala.Format = "D";
			salas.Add("Maracaná");
			salas.Add("Colombes");
			salas.Add("América");
			salas.Add("Olímpica");
			salas.Add("Amsterdam");
			cargarPicker ();
        }

		private void cargarPicker(){
			foreach (string sala in salas)
			{
				pickerSala.Items.Add(sala);
			}
		}

        void OnReservarSalaRS(object sender, EventArgs e)
        {
			String hola = "sssss";
			var email = DependencyService.Get<IEmail> ();
			String destinatario = "";
			if (email != null) {
				
				if (pickerSala.SelectedIndex == 0)
					destinatario = "ramiro.sala85@gmail.com";
					//destinatario = "sala.maracana@arkanosoft.com";
				else if (pickerSala.SelectedIndex == 1)
					destinatario = "sala.colombes@arkanosoft.com";
				else if (pickerSala.SelectedIndex == 2)
					destinatario = "sala.america@arkanosoft.com";
				else if (pickerSala.SelectedIndex == 3)
					destinatario = "sala.olimpica@arkanosoft.com";
				else if (pickerSala.SelectedIndex == 4)
					destinatario = "sala.amsterdam@arkanosoft.com";

				String cuerpo = "El usuario " + App.usuarioActivo + " solicita utilizar sala." + Environment.NewLine + "Fecha: " + 
					dateFechaSala.Date.ToString() + Environment.NewLine + "Sala: " + salas[pickerSala.SelectedIndex];

				email.EnviarMail ("mundoarkano@arkanosoft.com", destinatario, editAsuntoRS.Text, cuerpo);
			}
				
		}
    }
}
