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

namespace WpfStyle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation animacjaLiczby = new DoubleAnimation();
            animacjaLiczby.From = 180;
            animacjaLiczby.To = 280;
            animacjaLiczby.Duration = new Duration(TimeSpan.FromSeconds(2));
            animacjaLiczby.RepeatBehavior = RepeatBehavior.Forever;
            animacjaLiczby.AutoReverse = true;
            image.BeginAnimation(Label.HeightProperty, animacjaLiczby);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rodzaj rodzaj = new Rodzaj();
            rodzaj.Show();
            this.Close();

        }
    }
}
