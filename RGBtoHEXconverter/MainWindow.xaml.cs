
using RGBtoHEXconverter.AppData;
using System.Windows;

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

            HEXColorTb.Text = _converter.RGBtoHEX();
            OutputColorCs.Background = new System.Windows.Media.SolidColorBrush((System.Windows.Media.Color)
                System.Windows.Media.ColorConverter.ConvertFromString(HEXColorTb.Text));
        }

        private void CopyColorBtn_Click(object sender, RoutedEventArgs e)
        {
            //Добавляем Сконвертированный цвет в буфер для обмена быстрой вставки
            Clipboard.SetText(HEXColorTb.Text);

            
        }
    }
}