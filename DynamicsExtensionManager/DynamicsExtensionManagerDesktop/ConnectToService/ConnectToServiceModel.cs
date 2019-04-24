using System.Collections.ObjectModel;
using The365People.DynamicsExtensionManager.Core;

namespace The365People.DynamicsExtensionManager.Desktop
{
    public class ConnectToServiceModel
    {
        public ObservableCollection<DynamicsService> Services { get; private set; }
        public DynamicsService Service { get; set; }

        public ConnectToServiceModel()
        {
            this.Services = new ObservableCollection<DynamicsService>();
            this.Service = null;
            DynamicsService[] lServices = DynamicsServiceManager.GetServices();
            foreach (DynamicsService lService in lServices)
                this.Services.Add(lService);
        }
    }
}
