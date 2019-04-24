using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The365People.DynamicsExtensionManager.Core;
using The365People.WpfLibrary;

namespace The365People.DynamicsExtensionManager.Desktop
{
    public class MainViewModel : ViewModelBase
    {
        private App Application { get { return (App)System.Windows.Application.Current; } }
        public MainModel Model { get; private set; }

        public DynamicsService Service { get { return this.Model.Service; } set { this.Model.Service = value; this.TriggerPropertyChanged("Service"); this.TriggerPropertyChanged("ServiceText"); } }
        public DynamicsFolder Folder { get { return this.Model.Folder; } set { this.Model.Folder = value; this.TriggerPropertyChanged("Folder"); this.TriggerPropertyChanged("FolderText"); } }
        public ObservableCollection<DynamicsExtension> Extensions { get { return this.Model.Extensions; } }
        public ObservableCollection<DynamicsExtension> SelectedExtensions { get { return this.Model.SelectedExtensions; } }
        public DynamicsExtension Extension { get { return this.Model.Extension; } set { this.Model.Extension = value; } }

        public string ServiceText { get { return this.Service != null ? this.Service.ToString() : "(Not Connected)"; } }
        public string FolderText { get { return this.Folder != null ? this.Folder.ToString() : "(Not Connected)"; } }
        public string ExtensionText { get { return "(Not Selected)"; } }

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
            this.Application.Shutdown();
        }

        public bool CanExecuteExit(object pParameters)
        {
            return true;
        }

        public void ExecuteAbout(object pParameters)
        {
            AboutView lAboutView = new AboutView();
            lAboutView.ShowDialog();
        }

        public bool CanExecuteAbout(object pParameters)
        {
            return true;
        }

        public void ExecuteHistory(object pParameters)
        {
            HistoryView lHistoryView = new HistoryView();
            lHistoryView.ShowDialog();
        }

        public bool CanExecuteHistory(object pParameters)
        {
            return true;
        }

        public void ExecuteConnectToService(object pParameters)
        {
            ConnectToServiceModel lConnectToServiceModel = new ConnectToServiceModel();
            ConnectToServiceView lConnectToServiceView = new ConnectToServiceView(new ConnectToServiceViewModel(lConnectToServiceModel));
            if (lConnectToServiceView.ShowDialog().Value)
                this.Service = lConnectToServiceModel.Service;
        }

        public bool CanExecuteConnectToService(object pParameters)
        {
            return true;
        }

        public void ExecuteConnectToFolder(object pParameters)
        {
            FolderBrowserDialog lDialog = new FolderBrowserDialog();
            if (lDialog.ShowDialog() == DialogResult.OK)
                this.Folder = new DynamicsFolder(lDialog.SelectedPath);
            lDialog.Dispose();
        }

        public bool CanExecuteConnectToFolder(object pParameters)
        {
            return true;
        }

        public void ExecuteDisconnectFromService(object pParameters)
        {
            this.Service = null;
        }

        public bool CanExecuteDisconnectFromService(object pParameters)
        {
            return this.Service != null;
        }

        public void ExecuteDisconnectFromFolder(object pParameters)
        {
            this.Folder = null;
        }

        public bool CanExecuteDisconnectFromFolder(object pParameters)
        {
            return this.Folder != null;
        }

        public void ExecuteDetectExtensions(object pParameters)
        {
        }

        public bool CanExecuteDetectExtensions(object pParameters)
        {
            return ((this.Service != null) || (this.Folder != null));
        }

        public void ExecuteShowExtensionInformation(object pParameters)
        {
        }

        public bool CanExecuteShowExtensionInformation(object pParameters)
        {
            return this.Extension != null;
        }

        public void ExecutePublish(object pParameters)
        {
        }

        public bool CanExecutePublish(object pParameters)
        {
            return this.SelectedExtensions != null;
        }

        public void ExecuteInstall(object pParameters)
        {
        }

        public bool CanExecuteInstall(object pParameters)
        {
            return this.SelectedExtensions != null;
        }

        public void ExecuteUninstall(object pParameters)
        {
        }

        public bool CanExecuteUninstall(object pParameters)
        {
            return this.SelectedExtensions != null;
        }

        public void ExecuteUnpublish(object pParameters)
        {
        }

        public bool CanExecuteUnpublish(object pParameters)
        {
            return this.SelectedExtensions != null;
        }

        public void ExecuteSynchronise(object pParameters)
        {
        }

        public bool CanExecuteSynchronise(object pParameters)
        {
            return this.SelectedExtensions != null;
        }

        public void ExecuteUpgrade(object pParameters)
        {
        }

        public bool CanExecuteUpgrade(object pParameters)
        {
            return this.SelectedExtensions != null;
        }

        public void ExecuteRemove(object pParameters)
        {
        }

        public bool CanExecuteRemove(object pParameters)
        {
            return this.SelectedExtensions != null;
        }
    }
}
