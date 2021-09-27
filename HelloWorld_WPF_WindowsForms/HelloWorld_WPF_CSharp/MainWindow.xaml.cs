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
using MisClases;


namespace HelloWorld_WPF_CSharp
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
        /// <summary>
        /// Evento asociado al click del botón "saludar" que muestra un mensaje de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clsPersona persona;
            

            if (!String.IsNullOrEmpty(txtNombre.Text)) 
            {
                persona = new clsPersona(txtNombre.Text);
                MessageBox.Show($"Hola {persona.Nombre},eres un crack");
            }
            else
            {
                MessageBox.Show("No dejes el campo vacio que mi mama se enfada");
            }

            
            
        }

        
    }
}
