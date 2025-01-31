using IT_Help.ViewModels;
using System.Windows;

namespace IT_Help
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel = new MainViewModel();
        }
    }
}