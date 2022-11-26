using AlgerieTelecomF.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for offers.xaml
    /// </summary>
    public partial class offers : UserControl
    {
        public bool Ischecked;
        public string Nameo;
        public string Typeo;
       // public float Priceo;


        public offers(string name, string type, float price)
            {

                InitializeComponent();

                Name.Text = name;
                Speed.Text = type;
                Price.Text = price.ToString();
               
            }

          

        private void Brd_Click(object sender, RoutedEventArgs e)
        {
            Nameo = Name.Text;
            Typeo = Speed.Text;
           // Priceo = float.Parse(Price.Text);

            if(chkbx.Visibility == Visibility.Collapsed)
            {
                chkbx.Visibility = Visibility.Visible;
                chkbx.IsChecked = true;
                Ischecked = true;

            }
            else
              {
                chkbx.Visibility = Visibility.Collapsed;
                Ischecked = false;
            }
        }
    }
    }
