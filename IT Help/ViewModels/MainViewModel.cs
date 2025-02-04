using CommunityToolkit.Mvvm.ComponentModel;
using IT_Help.Models;
using IT_Help.Services;
using System.Collections.ObjectModel;
using System.IO;

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

        [ObservableProperty]
        private ObservableCollection<DriveInfo> _Drives;

        private ConfigService _ConfigServcie;
        private ComputerInfo _ComputerInfo;

        public MainViewModel() 
        {
            _ConfigServcie = new ConfigService();
            _ComputerInfo = new ComputerInfo();

            LoadAsync();
        }

        private async void LoadAsync()
        {
            await ConfigurationInit();
            await LoadConfig();
            await LoadMachine();
            await LoadDrives();
        }

        private async Task LoadConfig()
        {
            AppConfig? config = await _ConfigServcie.GetConfig();
            CompanyName = config.CompanyName; 
        }

        private Task LoadMachine()
        {
            MachineName = _ComputerInfo.Machinename;
            OSVersion = _ComputerInfo.OSVersion;
            Hostname = _ComputerInfo.Hostname;

            return Task.CompletedTask;
        }

        private Task LoadDrives()
        {
            var drives = new ObservableCollection<DriveInfo>();

            foreach(var drive in  _ComputerInfo.Drives)
                drives.Add(drive);

            Drives = drives;

            return Task.CompletedTask;
        }


        private async Task ConfigurationInit()
        {
            await _ConfigServcie.InitConfigFile();
        }
    }
}
