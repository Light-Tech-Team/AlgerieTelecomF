using AlgerieTelecomF.Views;
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

namespace AlgerieTelecomF.UserControls
{
    /// <summary>
    /// Interaction logic for OfferMain.xaml
    /// </summary>
    public partial class OfferMain : UserControl
    {
        public OfferMain()
        {
            InitializeComponent();
            Promotion result = new Promotion();
            var query = from item in result.varoffers where item.Name.Text == "Idoom" select item;

            itemsoffermain.ItemsSource =query;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {




           
        }
    }
}
