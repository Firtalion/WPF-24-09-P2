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

namespace WPF_24_09_P2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            client client = new client();
            client.Nom = "Olivier";
            client.Prénom = "Mael";
            client.Adresse = "18 rue bidon";
            client.Localite = "ville bidon";
            client.Telephone = 45296426;

        }
        public class client
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Prénom { get; set; }
            public string Adresse { get; set; }
            public string Localite { get; set; }
            public int Telephone { get; set; }


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }
    }
}
