using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The365People.DynamicsExtensionManager.Core;
using The365People.WpfLibrary;

namespace The365People.DynamicsExtensionManager.Desktop
{
    public class MainViewModel : ViewModelBase
    {
        public MainModel Model { get; private set; }

        public DynamicsService Service 
        { 
            get { return this.Model.Service; } 
            set { this.Model.Service = value; } 
        }
        public ObservableCollection<DynamicsExtension> Extensions
        {
            get { return this.Model.Extensions; }
        }
        public DynamicsExtension Extension
        { 
            get { return this.Model.Extension; } 
            set { this.Model.Extension = value; }
        }

        public RelayCommand ExitCommand { get; set; }
        public RelayCommand AboutCommand { get; set; }
        public RelayCommand HistoryCommand { get; set; }
        public RelayCommand ConnectToServiceCommand { get; set; }
        public RelayCommand ConnectToFolderCommand { get; set; }
        public RelayCommand DisconnectFromServiceCommand { get; set; }
        public RelayCommand DisconnectFromFolderCommand { get; set; }
        public RelayCommand DetectExtensionsCommand { get; set; }
        public RelayCommand ShowExtensionInformationCommand { get; set; }
        public RelayCommand PublishCommand { get; set; }
        public RelayCommand InstallCommand { get; set; }
        public RelayCommand UninstallCommand { get; set; }
        public RelayCommand UnpublishCommand { get; set; }
        public RelayCommand SynchroniseCommand { get; set; }
        public RelayCommand UpgradeCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }

        public MainViewModel(MainModel pModel)
        {
            this.Model = pModel;

            this.ExitCommand = new RelayCommand(this.ExecuteExit, this.CanExecuteExit);
            this.AboutCommand = new RelayCommand(this.ExecuteAbout, this.CanExecuteAbout);
            this.HistoryCommand = new RelayCommand(this.ExecuteHistory, this.CanExecuteHistory);
            this.ConnectToServiceCommand = new RelayCommand(this.ExecuteConnectToService, this.CanExecuteConnectToService);
            this.ConnectToFolderCommand = new RelayCommand(this.ExecuteConnectToFolder, this.CanExecuteConnectToFolder);
            this.DisconnectFromServiceCommand = new RelayCommand(this.ExecuteDisconnectFromService, this.CanExecuteDisconnectFromService);
            this.DisconnectFromFolderCommand = new RelayCommand(this.ExecuteDisconnectFromFolder, this.CanExecuteDisconnectFromFolder);
            this.DetectExtensionsCommand = new RelayCommand(this.ExecuteDetectExtensions, this.CanExecuteDetectExtensions);
            this.ShowExtensionInformationCommand = new RelayCommand(this.ExecuteShowExtensionInformation, this.CanExecuteShowExtensionInformation);
            this.PublishCommand = new RelayCommand(this.ExecutePublish, this.CanExecutePublish);
            this.InstallCommand = new RelayCommand(this.ExecuteInstall, this.CanExecuteInstall);
            this.UninstallCommand = new RelayCommand(this.ExecuteUninstall, this.CanExecuteUninstall);
            this.UnpublishCommand = new RelayCommand(this.ExecuteUnpublish, this.CanExecuteUnpublish);
            this.SynchroniseCommand = new RelayCommand(this.ExecuteSynchronise, this.CanExecuteSynchronise);
            this.UpgradeCommand = new RelayCommand(this.ExecuteUpgrade, this.CanExecuteUpgrade);
            this.RemoveCommand = new RelayCommand(this.ExecuteRemove, this.CanExecuteRemove);
        }

        public void ExecuteExit(object pParameters)
        {
        }

        public bool CanExecuteExit(object pParameters)
        {
            return true;
        }

        public void ExecuteAbout(object pParameters)
        {
        }

        public bool CanExecuteAbout(object pParameters)
        {
            return true;
        }

        public void ExecuteHistory(object pParameters)
        {
        }

        public bool CanExecuteHistory(object pParameters)
        {
            return true;
        }

        public void ExecuteConnectToService(object pParameters)
        {
        }

        public bool CanExecuteConnectToService(object pParameters)
        {
            return true;
        }

        public void ExecuteConnectToFolder(object pParameters)
        {
        }

        public bool CanExecuteConnectToFolder(object pParameters)
        {
            return true;
        }

        public void ExecuteDisconnectFromService(object pParameters)
        {
        }

        public bool CanExecuteDisconnectFromService(object pParameters)
        {
            return true;
        }

        public void ExecuteDisconnectFromFolder(object pParameters)
        {
        }

        public bool CanExecuteDisconnectFromFolder(object pParameters)
        {
            return true;
        }

        public void ExecuteDetectExtensions(object pParameters)
        {
        }

        public bool CanExecuteDetectExtensions(object pParameters)
        {
            return true;
        }

        public void ExecuteShowExtensionInformation(object pParameters)
        {
        }

        public bool CanExecuteShowExtensionInformation(object pParameters)
        {
            return true;
        }

        public void ExecutePublish(object pParameters)
        {
        }

        public bool CanExecutePublish(object pParameters)
        {
            return true;
        }

        public void ExecuteInstall(object pParameters)
        {
        }

        public bool CanExecuteInstall(object pParameters)
        {
            return true;
        }

        public void ExecuteUninstall(object pParameters)
        {
        }

        public bool CanExecuteUninstall(object pParameters)
        {
            return true;
        }

        public void ExecuteUnpublish(object pParameters)
        {
        }

        public bool CanExecuteUnpublish(object pParameters)
        {
            return true;
        }

        public void ExecuteSynchronise(object pParameters)
        {
        }

        public bool CanExecuteSynchronise(object pParameters)
        {
            return true;
        }

        public void ExecuteUpgrade(object pParameters)
        {
        }

        public bool CanExecuteUpgrade(object pParameters)
        {
            return true;
        }

        public void ExecuteRemove(object pParameters)
        {
        }

        public bool CanExecuteRemove(object pParameters)
        {
            return true;
        }
    }
}
