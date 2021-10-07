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
using System.Text.RegularExpressions;

namespace PasswordChecker {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        /*
         * Validates password against rules
         * Then opens second window
         */

        private bool AreAllChecked(CheckBox[] boxes) {
            foreach (CheckBox box in boxes) {
                if ((bool)!box.IsChecked) return false;
            }

            return true;
        }

        private void ButtonNavigate_Click(object sender, RoutedEventArgs e) {
            /*
             * Navigates to next window if all checkboxes are checked
             */

            CheckBox[] boxes = new CheckBox[] {
                checkboxHasLower,
                checkboxHasUpper,
                checkboxHasNumber,
                checkboxPasswordMatch
            };

            if (AreAllChecked(boxes)) {
                new PasswordCorrectWindow(passwordInputFirst.Password).Show();
            }
        }


        private void PasswordInputFirst_Changed(object sender, RoutedEventArgs e) {
            /*
             * Validates password using regular expressions
             * Checked every time input is changed
             * 
             * IsLower: "[a-z]+"
             * IsUpper: "[A-Z]+"
             * HasNumber: "[\d]+"
             */

            string password = passwordInputFirst.Password;
            checkboxHasLower.IsChecked = Regex.IsMatch(password, @"[a-z]+");
            checkboxHasUpper.IsChecked = Regex.IsMatch(password, @"[A-Z]+");
            checkboxHasNumber.IsChecked = Regex.IsMatch(password, @"[\d]+");
        }

        private void PasswordInputSecond_Changed(object sender, RoutedEventArgs e) {
            /*
             * Updates checkbox if the password match
             * Checks every time input is changed
             */

            if (passwordInputFirst.Password == passwordInputSecond.Password) checkboxPasswordMatch.IsChecked = true;
        }
    }
}
