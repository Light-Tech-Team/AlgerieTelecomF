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
using AlgerieTelecomF.UserControls;
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
        public BindableCollection<int> lstphone { get; set; }
        public BindableCollection<HistoryModel> lsthistory { get; set; }

        OfferMain ofrmain = new OfferMain("Idoom");

        string Offre;
        string Resident;
        string Agreement;
        int phone;



        public Client()
        {
            
            InitializeComponent();
            txtchange = true;

       //   model = viewmodel.GetClient(int.Parse(TxtIdClient.Text));
            

            
           transformdg.ItemsSource = viewmodelh.GetHistory(phone);


            lstofr = new BindableCollection<OffreModel>(ofrvmdl.GetAllOffer());

           combo.ItemsSource = lstofr;
           
            lstagr = new BindableCollection<AgreementModel>(agrvmdl.GetAgreement());
           // lstphone = new BindableCollection<int>(viewmodelh.GetNumber(int.Parse(TxtIdClient.Text)));

            psnlinfo.DataContext = viewmodel.GetClient(int.Parse(TxtIdClient.Text));
            comboagr.ItemsSource = lstagr;
            comboagr.DataContext = lstagr;
            combophone.ItemsSource = viewmodelh.GetNumber();
            

            lsthistory = new BindableCollection<HistoryModel>(viewmodelh.GetHistory(phone));

            txtresident.DataContext = lsthistory;
           

           
        }



        





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = new Button();
            bt = sender as Button;
            if (bt.Name == "edit")
            {
                ok.Visibility = Visibility.Visible;
               

                FullName.IsReadOnly = false;
                Idcard.IsReadOnly = false;
                Datereleasecard.IsReadOnly = false;
                Mail.IsReadOnly = false;
                phonee.IsReadOnly = false;
                birthday.IsReadOnly = false;

            }
            else
            {
                edit.Visibility = Visibility.Visible;

                FullName.IsReadOnly = true;
                Idcard.IsReadOnly = true;
                Datereleasecard.IsReadOnly = true;
                Mail.IsReadOnly = true;
                phonee.IsReadOnly = true;
                birthday.IsReadOnly = true;
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
           History.resident = txtresident.Text;
            viewmodelh.setHistory(histmodel);
           transformdg.ItemsSource = null;
            transformdg.ItemsSource = viewmodelh.GetHistory(phone);

        }
        

        private void combo_Selected(object sender, RoutedEventArgs e)
        {
            

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Line(object sender, RoutedEventArgs e)
        {

            viewmodel.DeleteNumber(phone);

        }

        private void Cession_Line(object sender, RoutedEventArgs e)
        {
            if (CessionBorder.Visibility == Visibility.Collapsed)
            {
                CessionBorder.Visibility = Visibility.Visible;
            }
            else 
            {
                CessionBorder.Visibility = Visibility.Collapsed;

            }
        }

        private void CessionBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
               


            }
        }

        private void Next(object sender, RoutedEventArgs e)
        {

            prsnlinfo.Visibility = Visibility.Collapsed;
            selectgrid.Visibility = Visibility.Visible;
        }

        private void Previous(object sender, RoutedEventArgs e)
        {
            selectgrid.Visibility = Visibility.Collapsed;
            prsnlinfo.Visibility = Visibility.Visible;
        }

        private void combo_Selected_1(object sender, RoutedEventArgs e)
        {
            ComboBox cmbxitm = new ComboBox();
            cmbxitm = sender as ComboBox;

           var s =(OffreModel)cmbxitm.SelectedValue;
            histmodel.Offrenameh = s.Name;
            histmodel.Offretypeh = s.Type;
        }

        private void comboagr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmbxitm = new ComboBox();
            cmbxitm = sender as ComboBox;

            var s = (AgreementModel)cmbxitm.SelectedValue;
            histmodel.Agreementname = s.Name;
           
        }

        private void combophone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmbxitm = new ComboBox();
            cmbxitm = sender as ComboBox;

            var s = (int)cmbxitm.SelectedValue;
            menuphone.Header = s;
            History.principaleline = s;
            phone = s;
        }

        private void idoombtn_Click(object sender, RoutedEventArgs e)
        {
            selectgrid.Visibility = Visibility.Collapsed;
            offregrid.Visibility = Visibility.Visible;
            lstvwconv.ItemsSource = lstagr;
            grdoffre.Children.Add(ofrmain);

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




