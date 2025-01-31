using CommunityToolkit.Mvvm.ComponentModel;
using IT_Help.Models;
using IT_Help.Services;

namespace IT_Help.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _CompanyName;

        [ObservableProperty]
        private string _MachineName;

        [ObservableProperty]
        private string _OSVersion;

        [ObservableProperty]
        private string _Hostname;

        private ConfigService _ConfigServcie;
        private ComputerInfo _ComputerInfo;

        public MainViewModel() 
        {
            _ConfigServcie = new ConfigService();
            _ComputerInfo = new ComputerInfo();

            ConfigurationInit();
            LoadMachine();
        }

        private void LoadMachine()
        {
            MachineName = _ComputerInfo.Machinename;
            OSVersion = _ComputerInfo.OSVersion;
            Hostname = _ComputerInfo.Hostname;
        }

        private async void ConfigurationInit()
        {
            await _ConfigServcie.InitConfigFile();
        }
    }
}
