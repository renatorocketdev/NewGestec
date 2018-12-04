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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace newGestec
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation newAnimation = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(1)));
            LogoLogin.BeginAnimation(OpacityProperty, newAnimation);
            ConteinerPrincipal.BeginAnimation(OpacityProperty, newAnimation);
            BtnLogar.BeginAnimation(OpacityProperty, newAnimation);
        }

        private void TbRegistrar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
