using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEConverterParameters
{
    public class MostrarMensagemParameters : Windows.UI.Xaml.DependencyObject
    {
        //public string Titulo { get; set; }
        //public string Mensagem { get; set; }

        public static readonly Windows.UI.Xaml.DependencyProperty TituloProperty =
            Windows.UI.Xaml.DependencyProperty.Register(
            "Titulo", typeof(string), typeof(MostrarMensagemParameters), null);

        public string Titulo
        {
            get { return (string)this.GetValue(TituloProperty); }
            set { this.SetValue(TituloProperty, value); }
        }

        public static readonly Windows.UI.Xaml.DependencyProperty MensagemProperty =
            Windows.UI.Xaml.DependencyProperty.Register(
            "Mensagem", typeof(string), typeof(MostrarMensagemParameters), null);

        public string Mensagem
        {
            get { return (string)this.GetValue(MensagemProperty); }
            set { this.SetValue(MensagemProperty, value); }
        }
    }
}
