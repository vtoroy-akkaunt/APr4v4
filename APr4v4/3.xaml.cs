using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace APr4v4 {
    /// <summary>
    /// Interaction logic for _3.xaml
    /// </summary>
    public partial class _3 : Page {
        bool allow_moar = false;
        public _3() {
            InitializeComponent();
            the_chart.ChartAreas.Add(new ChartArea("Main"));
            var currentSeries = new Series("Результат") {
                IsValueShownAsLabel = true
            };
            the_chart.Series.Add(currentSeries);
        }

        private void to_calc_Click(object sender, RoutedEventArgs e) {
            Series currentSeries = the_chart.Series.FirstOrDefault();
            currentSeries.ChartType = SeriesChartType.Line;
            currentSeries.Points.Clear();
            try {
                double a   = Convert.ToDouble(a_  .Text);
                double b   = Convert.ToDouble(b_  .Text);
                double x_0 = Convert.ToDouble(x_0_.Text);
                double x_k = Convert.ToDouble(x_k_.Text);
                double dx  = Convert.ToDouble(dx_ .Text);
                if (x_k <= x_0) {
                    App.show_invalid_input("x_k должен быть больше x_0");
                    return;
                }
                if (dx <= 0) {
                    App.show_invalid_input("dx должен быть больше 0");
                    return;
                }
                if ((x_k - x_0) / dx > 200 && !allow_moar) {
                    MessageBox.Show("Много точек получится. Нажмите \"Вычислить\" ещё раз, чтобы таки всё это дело нарисовать.");
                    allow_moar = true;
                    return;
                }
                for (double x = x_0; x < Convert.ToDouble(x_k_.Text); x += Convert.ToDouble(dx_.Text)) {
                    double y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                    currentSeries.Points.AddXY(x, Math.Round(y, 2));
                    res_.Text += $"{x} {y:0.00}\n";
                }
                allow_moar = false;
            } catch (Exception) {
                App.show_invalid_input();
            }
        }

        private void to_clear_Click(object sender, RoutedEventArgs e) {
            a_.Clear(); b_.Clear(); x_0_.Clear(); x_k_.Clear(); dx_.Clear(); res_.Clear();
        }
    }
}
