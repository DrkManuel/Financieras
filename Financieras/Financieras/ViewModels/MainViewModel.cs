using Financieras.Views;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace Financieras.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Calculadora = new CalculadoraViewModel();
            this.Simple = new SimpleViewModel();
            this.Compuesto = new CompuestoViewModel();
        }

        public CalculadoraViewModel Calculadora { get; set; }

        public SimpleViewModel Simple { get; set; }

        public CompuestoViewModel Compuesto { get; set; }
    }
}
