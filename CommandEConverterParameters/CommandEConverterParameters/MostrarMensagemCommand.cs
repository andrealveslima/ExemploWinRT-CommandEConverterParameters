using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEConverterParameters
{
    public class MostrarMensagemCommand : System.Windows.Input.ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            MostrarMensagemParameters mostrarMensagemParameters = parameter as MostrarMensagemParameters;

            if (mostrarMensagemParameters != null)
                await new Windows.UI.Popups.MessageDialog(mostrarMensagemParameters.Mensagem, mostrarMensagemParameters.Titulo).ShowAsync();
        }
    }
}
