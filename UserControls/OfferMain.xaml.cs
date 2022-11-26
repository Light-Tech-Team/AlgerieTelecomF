using AlgerieTelecomF.Views;
using System;
using System.Collections;
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
        Promotion result = new Promotion();
        List<offer> lst = new List<offer>();
        public string Nameofr;
        public string Typeofr;
        public float Costofr;

        public OfferMain(string name)
        {

            InitializeComponent();
            if (name == "Idoom")
            {

                var query = from item in result.varoffers where item.Name.Text == "Idoom" select item;


                itemsoffermain.ItemsSource = query;
            }
            else
            {

            var query1 = from item in result.varoffers where item.Name.Text == "4g" select item;
                itemsoffermain.ItemsSource = query1;
            }
        }
        
        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from item in result.varoffers where item.Ischecked select item;
            
            

                        Nameofr = query.First().Nameo;
                        Typeofr = query.First().Typeo;
                        Costofr = float.Parse(query.First().Price.Text);


        }

        
    }
}
