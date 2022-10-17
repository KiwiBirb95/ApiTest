using DemoLibrary;
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
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for LocationInfo.xaml
    /// </summary>
    public partial class LocationInfo : Window
    {
        public LocationInfo()
        {
            InitializeComponent();
        }

        private async void loadLocationInfo_Click(object sender, RoutedEventArgs e)
        {
            var locationInfo = await LocationProcessor.LoadLocation();

            latitudeText.Text = $"Latitude is {locationInfo.Latitude}";
            longitudeText.Text = $"Longitude is {locationInfo.Longitude}";
            altitudeText.Text = $"Altitude is {locationInfo.Altitude}";
            velocityText.Text = $"Velocity is {locationInfo.Velocity}";
        }
    }
}
