using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mundoarkano
{
	public abstract class NotifyPropertyChangeBase: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

