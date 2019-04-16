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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for wpfListarCliente.xaml
    /// </summary>
    public partial class wpfListarCliente : Window
    {
        Wpf_AdmClnt wp;
        public wpfListarCliente()
        {
            InitializeComponent();
        }

        public wpfListarCliente(Wpf_AdmClnt wa)
        {
            InitializeComponent();
            wp = wa;
        }

        private void btnPasar_Click_1(object sender, RoutedEventArgs e)
        {
            wp.txt_rut.Text = "1234567890";
            wp.txt_razon_social.Text = "ola que hace";
            wp.txt_nombre.Text = "Juanito Peres";
            wp.txt_email.Text = "juanito.peres@gmail.com";
            wp.txt_direccion.Text = "Nonato coo #825";
            wp.txt_telefono.Text = "985632011";
            wp.txt_actividad.Text = "Ingeniero";
        }
    }
}

