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

namespace AlgerieTelecomF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
        
    {
        string state;
        public Login()
        {
            InitializeComponent();
        }

        private void Border_DragEnter(object sender, MouseButtonEventArgs e)
        {
            lgwd.DragMove();

        }

        private void exit(object sender, RoutedEventArgs e)
        {
            lgwd.Close();
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbxitm = new ComboBoxItem();
            cbxitm = sender as ComboBoxItem;

            state = cbxitm.Content.ToString();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch(state)
            {
                case "Administrator":
                    new MainWindow();
                    break;

                case "Agent":
                    break;





            }
        }
    }
}
