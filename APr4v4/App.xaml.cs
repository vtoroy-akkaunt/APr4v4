using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace APr4v4 {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        static public void show_invalid_input() {
            MessageBox.Show("Неверный ввод.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
