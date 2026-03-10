using RGBtoHEXconverter.AppData;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RGBtoHEXconverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ColorConverter _converter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertColorBtn_Click(object sender, RoutedEventArgs e)
        {
            int red = Convert.ToInt32(RedValueTb.Text);
            int green = Convert.ToInt32(GreenValueTb.Text);
            int blue = Convert.ToInt32(BlueValueTb.Text);

            _converter = new ColorConverter(red,green,blue);
        }
    }
}