using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
using System.Windows.Shapes;

namespace PracticaWpf
{
    /// <summary>
    /// Lógica de interacción para ApartadoC.xaml
    /// </summary>
    public partial class ApartadoC : Window
    {
        public ApartadoC()
        {
            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Nom = "Judit",Cognom = "San Garcia" ,Adreça = "Avinguda meridiana, 153", Població = "08001", DNI = "12345678Z", NHC = 1});
            lvUsers.ItemsSource = items;
        }
    }
}
