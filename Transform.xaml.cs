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
    /// Interaction logic for Transform.xaml
    /// </summary>
    public partial class Transform : UserControl
    {
        public Transform()
        {
            InitializeComponent();
            List<Transformmodel> listtr = new List<Transformmodel>();
            var converter = new BrushConverter();
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("#FF0B71E9"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("red"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("purple"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("brown"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("green"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("blue"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("black"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("orange"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("#FF0B71E9"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("red"), caracter = "Z", name = "Zakaria Basbas" });
            listtr.Add(new Transformmodel { Idc = 1, Idl = 1, Cstreet = "Benbadis", Nstreet = "Atota", Date = 09092022, bgcolor = (Brush)converter.ConvertFromString("purple"), caracter = "Z", name = "Zakaria Basbas" });


            transformdg.ItemsSource = listtr;
        }
        public class Transformmodel
        {


            public string caracter { get; set; }
            public string name { get; set; }
            public int Idc { get; set; }
            public int Idl { get; set; }
            public string Cstreet { get; set; }
            public string Nstreet { get; set; }
            public int Date { get; set; }
            public Brush bgcolor { get; set; }


        }
    }
}
