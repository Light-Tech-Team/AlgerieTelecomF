using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using AlgerieTelecomF.Entity;
using AlgerieTelecomF.Models;
using AlgerieTelecomF.UserControls;
using AlgerieTelecomF.ViewModel;
using Caliburn.Micro;

namespace AlgerieTelecomF.Views
{
    /// <summary>
    /// Interaction logic for Promotion.xaml
    /// </summary>
    public partial class Promotion : UserControl
    {
        List<offers> offer = new List<offers>();
           
         
    OffreViewModel viewmodel = new OffreViewModel();
        float pr=1;
        public List<offers> varoffers;
        
        OffreViewModel ofrvmdl = new OffreViewModel();
        AgreementModel model = new AgreementModel();
        List<AgreementEntity> ent = new List<AgreementEntity>();    
        AgreementViewModel agrvmdl = new AgreementViewModel();
        public BindableCollection<AgreementModel> lstagr { get; set; }
        public Promotion()
        {
            InitializeComponent();

            
            varoffers = GetOffers(pr);
            
          if (varoffers.Count > 0)
               itemsoffer.ItemsSource = varoffers;
            HistoryViewModel viewmodelh = new HistoryViewModel();
            lstagr = new BindableCollection<AgreementModel>(agrvmdl.listagr());
            comboconv.ItemsSource = lstagr;
            comboconv.DataContext = lstagr;

        }
        public List<offers> GetOffers(float i)
        {
              foreach (OffreModel offre in viewmodel.listmodels())
              {
                offer.Add(new offers(offre.Name, offre.Type, offre.Cost*i ));

              }
            return offer;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (BrdAddOfr.Visibility == Visibility.Collapsed)
            
            {
            BrdAddOfr.Visibility = Visibility.Visible;
            }
            else { 

            BrdAddOfr.Visibility = Visibility.Collapsed;
            }
        }

       

       

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if(comboconv.Visibility == Visibility.Visible)  
            comboconv.Visibility=Visibility.Collapsed;
            else {
                comboconv.Visibility=Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //  viewmodel.
               
                viewmodel.addmodel (NameOfr.Text, TypeOfr.Text, (float)float.Parse(CostOfr.Text));
            Console.WriteLine("bbbbbb");
            itemsoffer.ItemsSource = null;
            offer.Clear();
            varoffers = GetOffers(pr);
            itemsoffer.ItemsSource= varoffers;
            BrdAddOfr.Visibility = Visibility.Collapsed;

            Console.WriteLine("ccccccc");
        }

       
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
            {
                Regex regex = new Regex("[^0-9&.]+");
                e.Handled = regex.IsMatch(e.Text);
            }

        private void SelectAgrement(object sender, RoutedEventArgs e)
        {
            ComboBoxItem ItemConv = new ComboBoxItem();

                ItemConv = sender as ComboBoxItem;
            string name = ItemConv.Content.ToString();



           var res = from item in agrvmdl.listagr() where item.Name == name select item.Remise;
            pr = res.First();

            itemsoffer.ItemsSource = null;
            offer.Clear();
            varoffers = GetOffers(pr);
            itemsoffer.ItemsSource = varoffers;


        }
    }
}
