using System;
using System.Collections.ObjectModel;
using The365People.DynamicsExtensionManager.Core;
using The365People.WpfLibrary;

namespace The365People.DynamicsExtensionManager.Desktop
{
    public class ConnectToServiceViewModel : ViewModelBase
    {
        public ConnectToServiceModel Model { get; private set; }

        public ObservableCollection<DynamicsService> Services { get { return this.Model.Services; } }
        public DynamicsService Service { get { return this.Model.Service; } set { this.Model.Service = value; } }

        public RelayCommand OkCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }

        public Action<bool> CloseViewAction { get; set; }

        public ConnectToServiceViewModel(ConnectToServiceModel pModel)
        {
            this.Model = pModel;

            this.OkCommand = new RelayCommand(this.ExecuteOk, this.CanExecuteOk);
            this.CancelCommand = new RelayCommand(this.ExecuteCancel, this.CanExecuteCancel);

            this.CloseViewAction = null;
        }

        public void ExecuteOk(object pParameters)
        {
            this.CloseViewAction?.Invoke(true);
        }

        public bool CanExecuteOk(object pParameters)
        {
            return ((this.Model.Service != null) && (this.Model.Service.State == DynamicsServiceState.Running));
        }

        public void ExecuteCancel(object pParameters)
        {
            this.CloseViewAction?.Invoke(false);
        }

        public bool CanExecuteCancel(object pParameters)
        {
            return true;
        }
    }
}
