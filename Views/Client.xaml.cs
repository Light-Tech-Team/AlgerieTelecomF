using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
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
using AlgerieTelecomF.Entity;
using AlgerieTelecomF.Models;
using AlgerieTelecomF.ViewModel;
using Caliburn.Micro;

namespace AlgerieTelecomF.Views
{
  

    public partial class Client : UserControl, INotifyPropertyChanged
    {

        public bool txtchange;
        public event PropertyChangedEventHandler PropertyChanged;
        ClientViewModel viewmodel = new ClientViewModel();
        HistoryViewModel viewmodelh = new HistoryViewModel();
        HistoryModel histmodel = new HistoryModel();
        ClientModelcs model = new ClientModelcs();
        ClientEntity entities = new ClientEntity();
        OffreViewModel ofrvmdl = new OffreViewModel();
        AgreementViewModel agrvmdl = new AgreementViewModel();
        public BindableCollection<AgreementModel> lstagr { get; set; }
        public BindableCollection<OffreModel> lstofr { get; set; }
        public BindableCollection<ClientModelcs> lstphone { get; set; }
        public BindableCollection<HistoryModel> lsthistory { get; set; }
        string Offre;
        string Resident;
        string Agreement;



        public Client()
        {
            
            InitializeComponent();
            txtchange = true;

          model = viewmodel.models();
            DataContext = this;
            

            
          transformdg.DataContext = viewmodelh.listmodels();
           transformdg.ItemsSource = viewmodelh.listmodels();


            lstofr = new BindableCollection<OffreModel>(ofrvmdl.listmodels());

           combo.ItemsSource = lstofr;
            combo.SelectedIndex = 1;
            combo.SelectedItem = 1;

            lstagr = new BindableCollection<AgreementModel>(agrvmdl.listagr());
            lstphone = new BindableCollection<ClientModelcs>(viewmodel.listPhone());

          psnlinfo.DataContext = viewmodel.models();
            comboagr.ItemsSource = lstagr;
           comboagr.DataContext = lstagr;
            combophone.ItemsSource = lstphone;
            combophone.DataContext = lstphone;

            lsthistory = new BindableCollection<HistoryModel>(viewmodelh.listmodels());

            txtresident.DataContext = lsthistory;   

         
        }



        





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = new Button();
            bt = sender as Button;
            if (bt.Name == "edit")
            {
                ok.Visibility = Visibility.Visible;
                TxtChange = false;
            }
            else
            {
                edit.Visibility = Visibility.Visible;
                TxtChange = true;
            }
            bt.Visibility = Visibility.Collapsed;
        }









        public bool TxtChange { get { return txtchange; } set { txtchange = value; OnPropertyChanged("TxtChange"); } }
      public ClientModelcs Model { get { return model; } set { model = value; OnPropertyChanged("Model"); } }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void edit_Copy_Click(object sender, RoutedEventArgs e)
        {
            histmodel.offrenameh = Offre;
            histmodel.agreementname = Agreement;
            histmodel.resident = txtresident.Text;
            viewmodelh.setmodels(histmodel);
            transformdg.ItemsSource = null;
            transformdg.ItemsSource = viewmodelh.listmodels();

        }
        

        private void combo_Selected(object sender, RoutedEventArgs e)
        {
            

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }



    public class zakiConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
           string  FirstName = values[0].ToString();
            string Lastname = values[1].ToString();
           
           



            return FirstName + " " + Lastname  ;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return (value as string).Split(',');
        }
    }
}




