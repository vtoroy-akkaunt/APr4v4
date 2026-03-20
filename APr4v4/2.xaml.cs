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
            Formulas.Function2 f = fx_shx.IsChecked.GetValueOrDefault()
            ? Formulas.Function2.sh_x
            : (fx_x2.IsChecked.GetValueOrDefault()
                ? Formulas.Function2.x2
                : Formulas.Function2.ex
            );
            try
            {
                var x_ = Convert.ToDouble(x.Text);
                var y_ = Convert.ToDouble(y.Text);
                res.Text = Formulas.calc_2(x_, y_, f).ToString();
            } catch (Exception) {
                App.show_invalid_input();
            }
        }

        private void to_clear_Click(object sender, RoutedEventArgs e) {
            x.Clear(); y.Clear(); res.Clear();
        }
    }
}
