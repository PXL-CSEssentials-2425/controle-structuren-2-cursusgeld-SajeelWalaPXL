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

namespace ControleStructuren2_Cursusgeld
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
        private const float fee = 1.5f;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(yearTextbox.Text, out int year);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                numericTextbox.Visibility = Visibility.Visible;

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int.TryParse(yearTextbox.Text, out int year);
            int.TryParse(numberTextbox.Text, out int number);
            double.TryParse(totalFeeTextbox.Text, out double totalFee);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                leapTextbox.Visibility = Visibility.Visible;
                totalFeeTextbox.Text = (number * fee) + fee.ToString("F2");

            }
            else
            {

                leapTextbox.Visibility = Visibility.Visible;
                leapTextbox.Text = "Is geen schrikkeljaar";
                totalFeeTextbox.Text = (number * fee).ToString("F2");

            }



        }
        private void YearTextbox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            numericTextbox.Visibility = Visibility.Hidden;
            leapTextbox.Visibility = Visibility.Hidden;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}