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
    public partial class Inicio : PhoneApplicationPage
    {
        public Inicio()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //CustomMessageBox messageBox = new CustomMessageBox()
            //{
            //    Title = "Recordatorio",
            //    Caption = "Programar Windows Phone",
            //    Message = "Realizar ejemplo del control CustomMessageBox",
            //    Content = stackPanel,
            //    LeftButtonContent = "Aceptar",
            //    RightButtonContent = "Cancelar",
            //    IsFullScreen = (bool)FullScreenCheckBox.IsChecked
            //};
            NavigationService.Navigate(new Uri("/Menu.xaml", UriKind.Relative));
        }
    }
}