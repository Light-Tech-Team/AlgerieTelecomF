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
        HistoryViewModel viewmodelh = new HistoryViewModel();
        HistoryModel histmodel = new HistoryModel();
        ClientViewModel viewmodelc = new ClientViewModel();
        ClientModelcs clntmodel = new ClientModelcs();
        Promotion result = new Promotion();
        OfferMain ofrmain = new OfferMain("Idoom");
        string s;

        public Inscription()
        {
            InitializeComponent();
            lstagr = new BindableCollection<AgreementModel>(agrvmdl.GetAgreement());
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
            grdoffre.Children.Add(ofrmain);




        }

        private void previous(object sender, RoutedEventArgs e)
        {
            ofrinscription.Visibility = Visibility.Collapsed;
            Selectedgrid.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // - Set Model ( History - Client )
            Clients.firstName = FirstName.Text +""+ LastName.Text;
           
            Clients.email = Email.Text;
            Clients.phone = int.Parse(Phone.Text);
            Clients.birthDay = Convert.ToDateTime(Birthday.Text);
            Clients.cardId = int.Parse(Idcard.Text);
            Clients.cardDate = Convert.ToDateTime(Datereleasecard.Text);
            History.offrenameh = ofrmain.Nameofr;
            History.offretypeh = ofrmain.Typeofr;
           History.principaleline = int.Parse(lblphone.Content.ToString());
            History.resident = Resident.Text;

            viewmodelc.setClient();
            viewmodelh.setHistory(histmodel);

            MessageBox.Show("Client Added Succesfly");

        }

        private void conv_Click_1(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;

            History.agreementname = button.Content.ToString();

        }

        private void Service_Line(object sender, RoutedEventArgs e)
        {

            CheckBox checkBox = sender as CheckBox;
               
            
            if(s == null)
            { 
            s = checkBox.Content.ToString();
            }

            else
            {
                s = s + "," + checkBox.Content.ToString(); 
            }
          /*  histmodel.serviceline = s;  
            Console.WriteLine(histmodel.serviceline);*/

        }
    }
    }

