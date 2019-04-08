//David
//April 8, 2019
//Methods

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

namespace _312576methodMaddness
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            double x;
            double.TryParse(txtInput.Text, out x);

            double answer = 0;
            if((bool)rbmmToInches.IsChecked)
            {
                answer = convertToInches(x);
            }
            if((bool)rbinchesTomm.IsChecked)
            {
                answer = convertTomm(x);
            }
            if((bool)rbFartoCelc.IsChecked)
            {
                answer = convertToCelcuis(x);
            }
            if ((bool)rbCtoF.IsChecked)
            {
                answer = convertTofar(x);
            }
            if ((bool)FeetToMEters.IsChecked)
            {
                answer = convertmeters(x);
            }
            lblOutput.Content = answer.ToString();
        }//end button click
        // to get what is below do a /// three slashes
        /// <summary>
        /// converts mm to inches
        /// </summary>
        /// <param name="mm">the distance in mm</param>
        /// <returns>the distance in inches</returns>
        public double convertTomm(double Inch)
        {
            return Inch * 25.4;
        }//end convertToMM

        public double convertToCelcuis(double far)
        {
            return (far - 32) * 5 / 9;
        }
        public double convertTofar(double celc)
        {
            return (celc * 9 / 5) + 32;
        }//× 9/5) + 32
        public double convertmeters(double feet)
        {
            return feet / 3.281;
        }
        public double convertToInches(double mm)
        {
            return mm/25.4;
        }//end convertToInches
    }//end class
}//end namespace
