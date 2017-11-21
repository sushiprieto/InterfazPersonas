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
    /// Lógica de interacción para MasAlta.xaml
    /// </summary>
    public partial class MasAltaControl : UserControl
    {

        private static MasAltaControl _instance;

        public static MasAltaControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MasAltaControl();
                return _instance;
            }
        }

        public MasAltaControl()
        {
            InitializeComponent();
        }

        private void btnMasAlta_Click(object sender, RoutedEventArgs e)
        {

            txbMasAlta.Text = clsPersonaController.OrdenarAltura();

        }
    }
}
