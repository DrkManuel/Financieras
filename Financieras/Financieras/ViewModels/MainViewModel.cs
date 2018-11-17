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
            this.Interes = new InteresViewModel();
            this.Simple = new SimpleViewModel();
        }

        public InteresViewModel Interes { get; set; }

        public SimpleViewModel Simple { get; set; }
    }
}
