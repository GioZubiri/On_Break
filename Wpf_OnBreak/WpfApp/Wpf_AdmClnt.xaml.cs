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
    /// Lógica de interacción para Wpf_AdmClnt.xaml
    /// </summary>
    public partial class Wpf_AdmClnt : Window
    {
        public Wpf_AdmClnt()
        {
            InitializeComponent();
            cb_tipo.SelectedIndex = 0;
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPregunta_Click(object sender, RoutedEventArgs e)
        {
            wpfListarCliente list = new wpfListarCliente(this);
            list.Show();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            txt_actividad.Clear();
            txt_direccion.Clear();
            txt_email.Clear();
            txt_nombre.Clear();
            txt_razon_social.Clear();
            txt_rut.Clear();
            txt_telefono.Clear();
            cb_tipo.SelectedIndex = 0;
        }
    }
}
