using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace The365People.DynamicsExtensionManager.Desktop
{
    /// <summary>
    /// Interaction logic for ConnectToServiceView.xaml
    /// </summary>
    public partial class ConnectToServiceView : Window
    {
        public ConnectToServiceViewModel ViewModel { get; private set; }

        public ConnectToServiceView()
        {
            this.SetViewModel(new ConnectToServiceViewModel(new ConnectToServiceModel()));
            this.InitializeComponent();
        }

        public ConnectToServiceView(ConnectToServiceViewModel pViewModel)
        {
            this.SetViewModel(pViewModel);
            this.InitializeComponent();
        }

        private void SetViewModel(ConnectToServiceViewModel pViewModel)
        {
            this.ViewModel = pViewModel;
            this.ViewModel.CloseViewAction = this.CloseView;
            this.DataContext = this.ViewModel;
        }

        private void CloseView(bool pDialogResult)
        {
            this.DialogResult = pDialogResult;
            this.Close();
        }
    }
}
