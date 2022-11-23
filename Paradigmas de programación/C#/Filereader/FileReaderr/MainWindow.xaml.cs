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

namespace FileReaderr
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = "No es el botón";
            foreach (string i in FileManager.ReadAllLines())
            {
                if (txtUsuario.Text == i && txtContraseña.Text == i + 1)
                {
                    txtResultado.Text = "Funcionó";
                }
                else
                {
                    txtResultado.Text = "Usuario invalido";
                }
            }
        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = "No es el botón";
            foreach (string c in FileManager.ReadAllLines())
            {
                if (txtUsuario.Text == c)
                {
                    txtResultado.Text = "Usuario no disponible";
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
                else
                {
                    txtResultado.Text = "Usuario Registrado";
                    FileManager.WriteFile(txtUsuario.Text);
                    FileManager.WriteFile(txtContraseña.Text);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                }
            }
        }
    }
}
