using _006_InterfazPersonas.Controllers;
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

namespace _006_InterfazPersonas
{
    /// <summary>
    /// Lógica de interacción para ConsultarDNIControl.xaml
    /// </summary>
    public partial class ConsultarDNIControl : UserControl
    {

        private static ConsultarDNIControl _instance;

        public static ConsultarDNIControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConsultarDNIControl();
                return _instance;
            }
        }

        public ConsultarDNIControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndni_Click(object sender, RoutedEventArgs e)
        {

            string dni = txbdni.Text.ToString();
       
            txtdni.Text = clsPersonaController.ConsultarDNI(dni);

            //Reseteamos el TextBlock
            txbdni.Text = "";

        }
    }
}
