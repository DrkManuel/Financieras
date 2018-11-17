using Financieras.Services;
using Financieras.Views;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Financieras.ViewModels
{
    public class InteresViewModel
    {
        public InteresViewModel()
        {
            
        }

        public ICommand SimpleCommand
        {
            get
            {
                return new RelayCommand(GoToSimple);
            }
        }

        private async void GoToSimple()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SimplePage());
        }

        public ICommand CompuestoCommand
        {
            get
            {
                return new RelayCommand(GoToCompuesto);
            }
        }

        private async void GoToCompuesto()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CompuestoPage());
        }
    }
}
