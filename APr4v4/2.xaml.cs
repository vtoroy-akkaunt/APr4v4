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

namespace APr4v4 {
    /// <summary>
    /// Interaction logic for _2.xaml
    /// </summary>
    public partial class _2 : Page {
        public _2() {
            InitializeComponent();
        }

        private void to_calc_Click(object sender, RoutedEventArgs e) {
            Func<double, double> f = fx_shx.IsChecked.GetValueOrDefault()
                ? new Func<double, double>(x => Math.Sinh(x))
                : (fx_x2.IsChecked.GetValueOrDefault()
                    ? new Func<double, double>(x => x * x)
                    : new Func<double, double>(x => Math.Pow(Math.E, x))
                );
            try {
                var x_ = Convert.ToDouble(x.Text);
                var y_ = Convert.ToDouble(y.Text);
                var w_ = x_ == y_ ? 0.5 + Math.Pow(y_ + f(x_), 3) : (
                    Math.Atan(f(x_)) + Math.Pow(f(x_) - y_, 3) * (x_ > y_ ? 1 : -1) // очевидно
                );
                res.Text = w_.ToString();
            } catch (Exception) {
                App.show_invalid_input();
            }
        }

        private void to_clear_Click(object sender, RoutedEventArgs e) {
            x.Clear(); y.Clear(); res.Clear();
        }
    }
}
