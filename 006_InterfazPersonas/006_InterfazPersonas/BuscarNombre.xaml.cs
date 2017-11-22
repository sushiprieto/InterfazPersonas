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
    /// Lógica de interacción para BuscarNombre.xaml
    /// </summary>
    public partial class BuscarNombre : UserControl
    {

        private static BuscarNombre _instance;

        public static BuscarNombre Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BuscarNombre();
                return _instance;
            }
        }

        public BuscarNombre()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, RoutedEventArgs e)
        {

            string nombre = txbNombre.Text;

            for (int i = 0; i < clsPersonaController.personas.Count; i++)
            {

                

                if (txbNombre.Text.Equals(clsPersonaController.personas[i].nombre))
                {
                    txtNombre.Inlines.Add(clsPersonaController.personas[i].ToString() + "\n");
                }
                else
                {
                    //MessageBox.Show("La persona: " + clsPersonaController.personas[i].nombre + " no esta en la base de datos.");
                    MessageBox.Show("La persona no se encuentra");
                    break;
                }

                
            }

            clsPersonaController.BorrarPersona(nombre);

            //Reseteamos el TextBlock
            txbNombre.Text = "";

        }
    }
}
