using _006_InterfazPersonas.Controllers;
using _006_InterfazPersonas.Models;
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
    /// Lógica de interacción para MenosPeso.xaml
    /// </summary>
    public partial class MenosPesoControl : UserControl
    {

        private static MenosPesoControl _instance;

        public static MenosPesoControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MenosPesoControl();
                return _instance;
            }
        }

        public MenosPesoControl()
        {
            InitializeComponent();
        }

        private void btnMenosPeso_Click(object sender, RoutedEventArgs e)
        {

            double peso = Double.MaxValue;

            clsPersona persona = new clsPersona();

            for (int i = 0; i < clsPersonaController.personas.Count; i++)
            {
                if (peso > clsPersonaController.personas[i].peso)
                {
                    peso = clsPersonaController.personas[i].peso;
                    persona = clsPersonaController.personas[i];
                }
            }

            txbMenosPeso.Text = persona.ToString();

        }
    }
}
