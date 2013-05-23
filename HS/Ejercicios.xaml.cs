using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace HS
{
    public partial class Ejercicios : PhoneApplicationPage
    {
        public Ejercicios()
        {
            InitializeComponent();
        }

        private void btnBrazos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DesarrolloEjercicio.xaml", UriKind.Relative));
        }
    }
}