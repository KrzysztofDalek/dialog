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
using System.Windows.Shapes;

namespace WpfStyle
{
    /// <summary>
    /// Logika interakcji dla klasy Ilosc.xaml
    /// </summary>
    public partial class Ilosc : Window
    {
        public Ilosc()
        {
            InitializeComponent();

            DoubleAnimation animacjaLiczby = new DoubleAnimation();
            animacjaLiczby.From = 1.0;
            animacjaLiczby.To = 0.0;
            animacjaLiczby.Duration = new Duration(TimeSpan.FromSeconds(6));
            animacjaLiczby.RepeatBehavior = RepeatBehavior.Forever;
            animacjaLiczby.AutoReverse = true;
            image.BeginAnimation(Label.OpacityProperty, animacjaLiczby);

        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int val = Convert.ToInt32(e.NewValue);
            string msg = String.Format("Ilość pizz: {0}", val);
            this.textBlock1.Text = msg;
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Wielkosc wielkosc = new Wielkosc();
            wielkosc.Show();
            this.Close();

        }
    }
}
