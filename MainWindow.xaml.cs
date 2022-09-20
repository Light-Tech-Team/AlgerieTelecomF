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
using static System.Net.Mime.MediaTypeNames;
using AlgerieTelecomF.Views;

namespace AlgerieTelecomF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();


            }
        }
        bool IsMaximized = false;


        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {

                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1250;
                    this.Height = 810;
                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;

                }
            }

        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void Call(object sender, RoutedEventArgs e)
        {
            Frm.Content = new Inscription();
            var selected = sender as ListViewItem;
            String s = selected.Name;
            switch (s)
            {
                case "Subscribe":
                    Frm.Content = new Inscription();
                    break;
                case "Offre":
                    Frm.Content = new Promotion();
                    break;
               
                case "Client":
                    Frm.Content = new Client();
                    break;


            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
