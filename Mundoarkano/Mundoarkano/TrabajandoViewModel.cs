using System;

namespace Mundoarkano
{
	public class TrabajandoViewModel: NotifyPropertyChangeBase
	{
		public TrabajandoViewModel ()
		{
			
		}

		private Boolean trab;
		private Boolean btn;

		public Boolean estaTrabajando
		{
			get { return trab; }

			set
			{
				if(trab!=value)
				{
					trab = value;
					OnPropertyChanged();
				}
			}
		}

		public Boolean btnHabilitado
		{
			get { return btn; }

			set
			{
				if(btn!=value)
				{
					btn = value;
					OnPropertyChanged();
				}
			}
		}
	}
}

