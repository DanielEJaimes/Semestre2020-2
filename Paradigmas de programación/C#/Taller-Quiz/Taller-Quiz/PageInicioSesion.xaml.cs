using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Taller_Quiz
{
    /// <summary>
    /// Lógica de interacción para PageInicioSesion.xaml
    /// </summary>
    public partial class PageInicioSesion : Page
    {
        public PageInicioSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Password == "")
            {
                txtUsuario.Text = "";
                txtContraseña.Password = "";
            }
            int i = 1;
            bool a = false;
            while (i < FileManager.ReadAllLines().Length)
            {
                if (FileManager.ReadAllLines()[i] == txtUsuario.Text && FileManager.ReadAllLines()[i + 1] == txtContraseña.Password)
                {
                    a = true;
                    break;
                }
                else
                {
                    i += 1;
                }
            }
            if (a == true)
            {
                MainWindow iniciar_sesion = (MainWindow)Window.GetWindow(this);
                iniciar_sesion.frame_Main.NavigationService.Navigate(new PageBienvenido());
            }
            else
            {
                txtUsuario.Text = "";
                txtContraseña.Password = "";
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            
            int i = 1;
            bool a = true;
            while (i < FileManager.ReadAllLines().Length)
            {
                if (txtUsuario.Text == FileManager.ReadAllLines()[i])
                {
                    MessageBox.Show("Usuario Invalido");
                    txtUsuario.Text = "";
                    txtContraseña.Password = "";
                    a = false;
                    break;
                }
                else
                {
                    if (txtUsuario.Text == "" || txtContraseña.Password == "")
                    {
                        txtUsuario.Text = "";
                        txtContraseña.Password = "";
                        a = false;
                        MessageBox.Show("Usuario Invalido");
                        break;
                    }
                    i += 3;
                }
            }
            
            if (a == true)
            {
                FileManager.WriteFile(txtUsuario.Text);
                FileManager.WriteFile(txtContraseña.Password);
                FileManager.WriteFile("--------------");
                MessageBox.Show("Usuario registrado");
                txtUsuario.Text = "";
                txtContraseña.Password = "";
            }
        }
    }
}
