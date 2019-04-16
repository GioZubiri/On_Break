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
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace WpfApp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_AdmClnt_Click(object sender, RoutedEventArgs e)
        {
            Wpf_AdmClnt vista_amd_clnt = new Wpf_AdmClnt();
            vista_amd_clnt.Show();
        }

        private void btn_LstClnt_Click(object sender, RoutedEventArgs e)
        {
            wpfListarCliente vista_lista_clnt = new wpfListarCliente();
            vista_lista_clnt.Show();
        }
    }
}
