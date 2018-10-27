namespace Financieras.ViewModels
{
    public class MainViewModel
    {
        public InteresViewModel Interes { get; set; }

        public MainViewModel()
        {
            this.Interes = new InteresViewModel();
        }
    }
}
