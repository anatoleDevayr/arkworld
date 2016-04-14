using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundoarkano
{
    public class TrabKioscoModel : NotifyPropertyChangeBase
    {
        private Boolean pickerCantidad;
        private Boolean editText;
        private Boolean btnComprar;
        private Boolean trabajando;

		public TrabKioscoModel ()
		{
			
		}

		public Boolean pickerCantidadHabilitado
		{
			get { return pickerCantidad; }

			set
			{
				if(pickerCantidad!=value)
				{
					pickerCantidad = value;
					OnPropertyChanged();
				}
			}
		}

        public Boolean editTextHabilitado
        {
            get { return editText; }

            set
            {
                if (editText != value)
                {
                    editText = value;
                    OnPropertyChanged();
                }
            }
        }

        public Boolean btnComprarHabilitado
        {
            get { return btnComprar; }

            set
            {
                if (btnComprar != value)
                {
                    btnComprar = value;
                    OnPropertyChanged();
                }
            }
        }

        public Boolean estaTrabajando
        {
            get { return trabajando; }

            set
            {
                if (trabajando != value)
                {
                    trabajando = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
