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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _006_InterfazPersonas
{
    //FUNCIONALIDADES DEL PROGRAMA:
    //
    //- Inserta una persona en una lista (si el dni esta repedido muestra un error)
    //- Muestra todas las personas en un listview
    //- Muestra la persona mas alta
    //- Muestra la persona con menos peso
    //- Busca una persona por DNI (si el dni no coincide muestra un error)
    //- Se inicia en pantalla completa
    //- Cambiado el titulo, imagen programa, fuente, fondos, icono de los botones, ...
    //- Realizado mediante controles de usuario personalizados

    // TODO: Al insertar una persona que se borren todos los campos para evitar insertar muchas seguidas
    // TODO: Controlar al al insertar y no haya nada escrito no de un error
    // TODO: Implementar controles de usuario para cambiar el contenido del stackpanel solamente
    // TODO: Cambiar titulo ventana
    // TODO: Cambiar edad por fecha

    public partial class MainWindow : Window
    {

        public InsertarControl insertar = new InsertarControl();

        private void btnAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (!spFormulario.Children.Contains(InsertarControl.Instance))
            {
                spFormulario.Children.Add(InsertarControl.Instance);
                spFormulario.Children.Remove(MasAltaControl.Instance);
                spFormulario.Children.Remove(ConsultarDNIControl.Instance);
                spFormulario.Children.Remove(MenosPesoControl.Instance);
            }

            //lblPresentacion.Text = "";
            lblPresentacion.Visibility = Visibility.Collapsed;
            grdAnimaciones.Visibility = Visibility.Collapsed;

        }

        private void btnAlta_Click(object sender, RoutedEventArgs e)
        {
            if (!spFormulario.Children.Contains(MasAltaControl.Instance))
            {
                spFormulario.Children.Add(MasAltaControl.Instance);
                spFormulario.Children.Remove(ConsultarDNIControl.Instance);
                spFormulario.Children.Remove(MenosPesoControl.Instance);
                spFormulario.Children.Remove(InsertarControl.Instance);
            }

            lblPresentacion.Text = "";

        }

        private void btnDNI_Click(object sender, RoutedEventArgs e)
        {
            if (!spFormulario.Children.Contains(ConsultarDNIControl.Instance))
            {
                spFormulario.Children.Add(ConsultarDNIControl.Instance);
                spFormulario.Children.Remove(MenosPesoControl.Instance);
                spFormulario.Children.Remove(InsertarControl.Instance);
                spFormulario.Children.Remove(MasAltaControl.Instance);
            }

            lblPresentacion.Text = "";

        }

        private void btnPeso_Click(object sender, RoutedEventArgs e)
        {
            if (!spFormulario.Children.Contains(MenosPesoControl.Instance))
            {
                spFormulario.Children.Add(MenosPesoControl.Instance);
                spFormulario.Children.Remove(InsertarControl.Instance);
                spFormulario.Children.Remove(MasAltaControl.Instance);
                spFormulario.Children.Remove(ConsultarDNIControl.Instance);
            }

            lblPresentacion.Text = "";

        }

        public MainWindow()
        {

            InitializeComponent();

            Loaded += AnimatingControl_Loaded;

        }

        private void AnimatingControl_Loaded(object sender, RoutedEventArgs e)
        {
            Storyboard sb = (this.FindResource("sbAnimateImage") as Storyboard);
            sb.Begin();
        }


        /// <summary>
        /// Metodo que se le llama en el onClick del boton borrar y borra una persona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {



        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {

            lsvListadoPersonas.Items.Clear();

            for (int i = 0; i < clsPersonaController.personas.Count; i++)
            {
                //txtResultado.Inlines.Add(clsPersonaController.personas[i].ToString());
                lsvListadoPersonas.Items.Add(clsPersonaController.personas[i].ToString());

            }

        }

        private void MyImg_Click(object sender, RoutedEventArgs e)
        {

            //MessageBox.Show("QUE BUENA LOCO ME HAS PULSADO");
            LogroVentana win = new LogroVentana();
            win.Show();

        }
    }
}
