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
    /// Interaction logic for HistoryView.xaml
    /// </summary>
    public partial class HistoryView : Window
    {
        public HistoryViewModel ViewModel { get; private set; }

        public HistoryView()
        {
            this.SetViewModel(new HistoryViewModel(new HistoryModel()));
            this.InitializeComponent();
        }

        public HistoryView(HistoryViewModel pViewModel)
        {
            this.SetViewModel(pViewModel);
            this.InitializeComponent();
        }

        private void SetViewModel(HistoryViewModel pViewModel)
        {
            this.ViewModel = pViewModel;
            this.DataContext = this.ViewModel;
        }
    }
}
