using AlgerieTelecomF.Models;
using AlgerieTelecomF.UserControls;
using AlgerieTelecomF.ViewModel;
using Caliburn.Micro;
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


namespace AlgerieTelecomF.Views
{
    /// <summary>
    /// Interaction logic for Inscription.xaml
    /// </summary>
    public partial class Inscription : UserControl
    {
        AgreementViewModel agrvmdl = new AgreementViewModel();
        public BindableCollection<AgreementModel> lstagr { get; set; }

        public Inscription()
        {
            InitializeComponent();
            lstagr = new BindableCollection<AgreementModel>(agrvmdl.listagr());
            lstvwconv.ItemsSource = lstagr;
            lstvwconv.DataContext = lstagr;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void select(object sender, RoutedEventArgs e)
        {
            Selectedgrid.Visibility = Visibility.Collapsed;
            ofrinscription.Visibility = Visibility.Visible;
            grdoffre.Children.Add(new OfferMain());  

            

        }

        private void previous(object sender, RoutedEventArgs e)
        {
            ofrinscription.Visibility = Visibility.Collapsed;
            Selectedgrid.Visibility = Visibility.Visible;
        }

        


        
    }
}
