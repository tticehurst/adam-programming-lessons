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
using System.Windows.Shapes;

namespace PasswordChecker {
    /// <summary>
    /// Interaction logic for PasswordCorrectWindow.xaml
    /// </summary>
    public partial class PasswordCorrectWindow : Window {
        public PasswordCorrectWindow(string userPassword) {
            InitializeComponent();

            /*
             * Update label with password
             */

            labelPasswordConfirmation.Content = $"{labelPasswordConfirmation.Content} ({userPassword})";
        }
    }
}
