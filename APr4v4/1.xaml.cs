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
    /// Interaction logic for _1.xaml
    /// </summary>
    public partial class _1 : Page {
        public _1() {
            InitializeComponent();
        }

        private void to_calc_Click(object sender, RoutedEventArgs e) {
            try {
                var x_ = Convert.ToDouble(x.Text);
                var y_ = Convert.ToDouble(y.Text);
                var z_ = Convert.ToDouble(z.Text);
                var w_ = Math.Pow(
                    Math.Abs(
                        Math.Cos(x_) - Math.Cos(y_)
                    ),
                    1 + 2 * Math.Pow(Math.Sin(y_), 2)
                ) * (
                    1 + z_ + Math.Pow(z_, 2) / 2 + Math.Pow(z_, 3) / 3 + Math.Pow(z_, 4) / 4
                );
                res.Text = w_.ToString();
            } catch (Exception) {
                App.show_invalid_input();
            }
        }

        private void to_clear_Click(object sender, RoutedEventArgs e) {
            x.Clear(); y.Clear(); z.Clear(); res.Clear();
        }
    }
}
