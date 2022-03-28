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
using System.Windows.Shapes;

namespace ShoolPortal_
{
    /// <summary>
    /// Логика взаимодействия для Vichislen.xaml
    /// </summary>
    public partial class Vichislen : Window
    {
        public Vichislen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Progul progul = new Progul();
            progul.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            VichisleniaSredArifmitch vichislenia = new VichisleniaSredArifmitch();
            vichislenia.ShowDialog();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Bolezn bolezn  = new Bolezn();
            bolezn.ShowDialog();
        }
    }
}
