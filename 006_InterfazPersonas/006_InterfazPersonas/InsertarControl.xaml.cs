
using _006_InterfazPersonas.Controllers;
using _006_InterfazPersonas.Models;
using System;
using System.Collections;
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
    /// Lógica de interacción para InsertarControl.xaml
    /// </summary>
    public partial class InsertarControl : UserControl
    {

        string sexo;

        private static InsertarControl _instance;

        public static InsertarControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InsertarControl();
                return _instance;
            }
        }

        public InsertarControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            //Comprobamos que los campos no esten vacios
            if (txbDni.Text.Equals("") || txbNombre.Text.Equals("") || txbApellidos.Text.Equals("") || txbPeso.Text.Equals("") || txbAltura.Text.Equals(""))
            {

                MessageBox.Show("No puede haber campos vacios");

            }
            else
            {

                //Recogemos todos los valores de los campos
                string dni = txbDni.Text;
                string nombre = txbNombre.Text;
                string apellidos = txbApellidos.Text;

                if (rbHombre.IsChecked == true)
                    sexo = "Hombre";
                else if (rbMujer.IsChecked == true)
                    sexo = "Mujer";

                double peso = double.Parse(txbPeso.Text);
                double altura = double.Parse(txbAltura.Text);
                string fecha = dpFecha.Text;

                //Aqui comprobamos que no se inserte un DNI repetido
                if (clsPersonaController.personas.Count <= 0)
                {

                    //Insertamos la persona
                    clsPersona p = new clsPersona(dni, nombre, apellidos, fecha, sexo, peso, altura);
                    clsPersonaController.InsertarPersona(p);

                    //Mostramos mensaje de confirmacion
                    MessageBox.Show("Insertado correctamente.");

                    //Reseteamos los campos
                    txbDni.Text = "";
                    txbNombre.Text = "";
                    txbApellidos.Text = "";
                    txbAltura.Text = "";
                    txbPeso.Text = "";
                    dpFecha.SelectedDate = null;

                }
                else
                {

                    Boolean valido = true;

                    for (int i = 0; i < clsPersonaController.personas.Count; i++)
                    {

                        if (dni.Equals(clsPersonaController.personas[i].dni))
                        {

                            valido = false;
                            break;

                        }

                    }

                    //Si el DNI es valido lo insertamos, sino no
                    if (valido)
                    {

                        clsPersona p = new clsPersona(dni, nombre, apellidos, fecha, sexo, peso, altura);
                        clsPersonaController.InsertarPersona(p);

                        MessageBox.Show("Insertado correctamente.");

                        //Reseteamos los campos
                        txbDni.Text = "";
                        txbNombre.Text = "";
                        txbApellidos.Text = "";
                        txbAltura.Text = "";
                        txbPeso.Text = "";
                        dpFecha.SelectedDate = null;

                    }
                    else
                    {

                        MessageBox.Show("El DNI está repetido, pruebe con otro.");

                    }

                }

            }

        }

    }
}
