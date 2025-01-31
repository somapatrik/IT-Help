using IT_Help.Models;
using System.Windows;

namespace IT_Help
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var ci = new ComputerInfo();
        }
    }
}