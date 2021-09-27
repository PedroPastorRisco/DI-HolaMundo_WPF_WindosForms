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
            if (textBox1.Text != "") 
            {
                persona = new clsPersona(textBox1.Text);
                MessageBox.Show($"Hola {persona.Nombre}");
            }
            else
            {
                MessageBox.Show("No deje el campo vacio");

            }

            
            
        }

        
    }
}
