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
    public class MainModel
    {
        public DynamicsService Service { get; set; }
        public ObservableCollection<DynamicsExtension> Extensions { get; set; }
        public DynamicsExtension Extension { get; set; }

        public MainModel()
        {
            this.Service = null;
            this.Extensions = new ObservableCollection<DynamicsExtension>();
            this.Extension = null;
        }
    }
}
