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
    /// Логика взаимодействия для Sozdatnumberstud.xaml
    /// </summary>
    public partial class Sozdatnumberstud : Window
    {
        ShoolEntities shool = new ShoolEntities();
        public Sozdatnumberstud()
        {           
            InitializeComponent();
            var max = shool.Students.Max(p => p.id_Student);
            cb1.Items.Add("-");
            cb1.Text = "-";
            for (int i = 1; i <= max; i++)
            {
                var studname = shool.Students.Single(p => p.id_Student == i);
                cb1.Items.Add(studname.Last_name + " " + studname.First_name + " " + studname.Middle_name);
            }
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cb1.Text != "-")
            {
                var name = shool.Students.Single(p => p.Last_name + " " + p.First_name + " " + p.Middle_name == cb1.Text);
                tb1.Text = name.Year_of_admission;
                tb2.Text = name.Group_;
                string idstudent = Convert.ToString(name.id_Student);
                string year_of_admission = name.Year_of_admission;
                string group = name.Group_;
                string[] idcollegstud = new string[1] { "-" };
                MetodCase.GenerationCollegIdStud(idstudent, year_of_admission, group, idcollegstud);
                tb3.Text = idcollegstud[0];
                bt2.Visibility = Visibility.Hidden;
                cb1.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Необходимо вести Ф.И.О. студента.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var proverka = shool.Students.Single(p => p.College_ID_number == tb3.Text);

                MessageBox.Show("Номер уже был сгенерирован.", "Ошибка при создании", MessageBoxButton.OK, MessageBoxImage.Error);
                bt2.Visibility = Visibility.Visible;
                cb1.IsEnabled = true;
            }
            catch
            {
                var name = shool.Students.Single(p => p.Last_name + " " + p.First_name + " " + p.Middle_name == cb1.Text);
                name.College_ID_number = tb3.Text;
                shool.SaveChanges();
                MessageBox.Show("Номер студенческого билета сгенерирован.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();
            }
        }
    }
}
