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
                
                res.Text = Formulas.calc_1(x_, y_, z_).ToString();
            } catch (Exception) {
                App.show_invalid_input();
            }
        }

        private void to_clear_Click(object sender, RoutedEventArgs e) {
            x.Clear(); y.Clear(); z.Clear(); res.Clear();
        }
    }
}
