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
    /// Lógica de interacción para PageBienvenido.xaml
    /// </summary>
    public partial class PageBienvenido : Page
    {
        public PageBienvenido()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow iniciar_sesion = (MainWindow)Window.GetWindow(this);
            iniciar_sesion.frame_Main.NavigationService.Navigate(new PageInicioSesion());
        }
    }
}
