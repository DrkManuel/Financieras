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
            if (double.IsNaN(VP))
            {
                Resultado = "Ingresa el valor del Valor Presente";
                return;
            }

            if (double.IsNaN(N))
            {
                Resultado = "Ingresa el valor del Número de Periodos";
                return;
            }

            if (double.IsNaN(I))
            {
                Resultado = "Ingresa el valor de la Tasa de Interés";
                return;
            }

            Resultado = "Valor Futuro = " + (VP * (1 + I * N));
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
            if (double.IsNaN(VF))
            {
                Resultado = "Ingresa el valor del Valor Futuro";
                return;
            }

            if (double.IsNaN(N))
            {
                Resultado = "Ingresa el valor del Número de Periodos";
                return;
            }

            if (double.IsNaN(I))
            {
                Resultado = "Ingresa el valor de la Tasa de Interés";
                return;
            }

            if ((1 + N * I) == 0)
            {
                Resultado = "Si la Tasa de Interés o el Número de Periodos es igual a 1, el otro no puede ser igual a -1";
            }
            else
            {
                Resultado = "Valor Presente = " + (VF / (1 + N * I));
            }
        }

        public ICommand CalcularTasaInteres
        {
            get
            {
                return new RelayCommand(CalcularI);
            }
        }

        private void CalcularI()
        {
            if (double.IsNaN(VF))
            {
                Resultado = "Ingresa el valor del Valor Futuro";
                return;
            }

            if (double.IsNaN(VP))
            {
                Resultado = "Ingresa el valor del Valor Presente";
                return;
            }

            if (double.IsNaN(N))
            {
                Resultado = "Ingresa el valor del Número de Periodos";
                return;
            }

            if (VP == 0 || N == 0)
            {
                Resultado = "El Valor Presente o el Número de Periodos no pueden ser 0";
            }
            else
            {
                Resultado = "Tasa de Interés = " + (((VF / VP) - 1) * (1 / N));
            }
        }

        public ICommand CalcularNumeroPeriodos
        {
            get
            {
                return new RelayCommand(CalcularN);
            }
        }

        private void CalcularN()
        {
            if (double.IsNaN(VF))
            {
                Resultado = "Ingresa el valor del Valor Futuro";
                return;
            }

            if (double.IsNaN(VP))
            {
                Resultado = "Ingresa el valor del Valor Presente";
                return;
            }

            if (double.IsNaN(I))
            {
                Resultado = "Ingresa el valor de la Tasa de Interés";
                return;
            }

            if (VP == 0 || I == 0)
            {
                Resultado = "El Valor Presente o la Tasa de Interés no pueden ser 0";
            }
            else
            {
                Resultado = "Número de Periodos = " + (((VF / VP) - 1) * (1 / I));
            }
        }
        #endregion
    }
}
