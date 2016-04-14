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
        private TrabReservaModel estado;
		List<String> salas = new List<String>();

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
            this.estado = new TrabReservaModel();
        }

		private void cargarPicker(){
			foreach (string sala in salas)
			{
				pickerSala.Items.Add(sala);
			}
		}

        async void OnReservarSalaRS(object sender, EventArgs e)
        {
			var email = DependencyService.Get<IEmail> ();
			String destinatario = "";
			if (email != null) {

                estado.estaTrabajando = true;
                estado.btnReservaHabilitado = false;
                estado.datePickerHabilitado = false;
                estado.editTextHabilitado = false;
                estado.pickerSalaHabilitado = false;

                dateFechaSala.IsEnabled = estado.datePickerHabilitado;
                pickerSala.IsEnabled = estado.pickerSalaHabilitado;
                editAsuntoRS.IsEnabled = estado.editTextHabilitado;
                btnEnviarReservaRS.IsEnabled = estado.btnReservaHabilitado;
				reloj.IsRunning = estado.estaTrabajando;
                

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
                
                await Task.Delay(500);
				email.EnviarMail ("mundoarkano@arkanosoft.com", destinatario, editAsuntoRS.Text, cuerpo);
			}

            await DisplayAlert("OK", "La reserva fue realizada exitosamente", "OK");
            estado.estaTrabajando = false;
            estado.btnReservaHabilitado = true;
            estado.datePickerHabilitado = true;
            estado.editTextHabilitado = true;
            estado.pickerSalaHabilitado = true;

            dateFechaSala.IsEnabled = estado.datePickerHabilitado;
            pickerSala.IsEnabled = estado.pickerSalaHabilitado;
            editAsuntoRS.IsEnabled = estado.editTextHabilitado;
            btnEnviarReservaRS.IsEnabled = estado.btnReservaHabilitado;
            reloj.IsRunning = estado.estaTrabajando;
		}
    }
}
