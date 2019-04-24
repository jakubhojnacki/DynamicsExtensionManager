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
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : Window
    {
        public AboutViewModel ViewModel { get; private set; }

        public AboutView()
        {
            this.SetViewModel(new AboutViewModel(new AboutModel()));
            InitializeComponent();
        }

        public AboutView(AboutViewModel pViewModel)
        {
            this.SetViewModel(pViewModel);
            InitializeComponent();
        }

        private void SetViewModel(AboutViewModel pViewModel)
        {
            this.ViewModel = pViewModel;
            this.DataContext = this.ViewModel;
        }
    }
}
