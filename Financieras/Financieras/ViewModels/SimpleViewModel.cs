using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Financieras.ViewModels
{
    public class SimpleViewModel : INotifyPropertyChanged
    {
        public SimpleViewModel()
        {

        }

        #region Properties
        public double VP { get; set; }

        public double VF { get; set; }

        public double N { get; set; }

        public double I { get; set; }

        private string resultado = "";

        public string Resultado
        {
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Resultado"));
                }
            }
            get
            {
                return resultado;
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Commands
        public ICommand CalcularValorFuturo
        {
            get
            {
                return new RelayCommand(CalcularVF);
            }
        }

        private void CalcularVF()
        {
            Resultado = "Hola";
        }

        public ICommand CalcularValorPresente
        {
            get
            {
                return new RelayCommand(CalcularVP);
            }
        }

        private void CalcularVP()
        {
            Resultado = "Hola 2";
        }

        public ICommand CalcularTazaImpuesto
        {
            get
            {
                return new RelayCommand(CalcularI);
            }
        }

        private void CalcularI()
        {
            throw new NotImplementedException();
        }

        public ICommand CalcularPeriodoTiempo
        {
            get
            {
                return new RelayCommand(CalcularN);
            }
        }

        private void CalcularN()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
