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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Page> pages = new List<Page> { new _1(), new _2(), new _3() };
        public MainWindow() {
            InitializeComponent();
        }
        private void open_page(int page_index) {
            // всё на проекте можно сделать лучше, но задачи такой не стояло
            the_frame.Navigate(pages[page_index]);
        }

        private void Button_Click(object sender, RoutedEventArgs e) { open_page(0); }

        private void Button_Click_1(object sender, RoutedEventArgs e) { open_page(1); }

        private void Button_Click_2(object sender, RoutedEventArgs e) { open_page(2); }
    }
}
