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
    public partial class Alimentacion : PhoneApplicationPage
    {
        private string titulo;
        public Alimentacion()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

        }
        private void btnDesayunoSi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Desayuno";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnMedMananaSi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Media Mañana";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnAlmuerzoSi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Almuerzo";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnMedTardeSi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Media Tarde";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnCenaSi_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Cena";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnDesayunoNo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Desayuno";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnMedMananaNo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Media Mañana";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnAlmuerzoNo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Almuerzo";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnMedTardeNo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Media Tarde";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }

        private void btnCenaNo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            titulo = "Cena";
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml?Titulo=" + titulo, UriKind.Relative));
            NavigationService.Navigate(new Uri("/ContenidoAlimentacion.xaml", UriKind.Relative));
        }
    }
}