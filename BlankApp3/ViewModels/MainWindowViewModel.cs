using Prism.Mvvm;

namespace BlankApp3.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        private double _currentX = -56.78943554555;
        public double CurrentX
        {
            get { return _currentX; }
            set { SetProperty(ref _currentX, value); }
        }
        public MainWindowViewModel()
        {

        }
    }
}
