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

namespace ShoolPortal_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShoolEntities school = new ShoolEntities();
        public MainWindow()
        {
            InitializeComponent();
            dg1.ItemsSource = school.Students.ToList();
            dg2.ItemsSource = school.Grades_Students.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string datenow = Convert.ToString(DateTime.Today);
                string[] year = datenow.Split(new char[] { ' ' });
                var datenow111 = year[0];
                var proverka = school.Grades_Students.Single(p => p.Date == datenow111 && p.id_Student == 1);
                MessageBox.Show("В базе, уже сгенерировано 10 строчек с датой, для повторного использования, необходимо время.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                var maxdate = school.Grades_Students.Max(p => p.id);
                string[] ocenka = new string[6];
                string datenow = Convert.ToString(DateTime.Today);
                string[] splitdate = datenow.Split(new char[] { ' ' });
                var date = Convert.ToDateTime(splitdate[0]);
                for (int i = 1; i <= 10; i++)
                {
                    for (int f = 1; f <= school.Students.Max(p => p.id_Student); f++)
                    {
                        maxdate = maxdate + 1;
                        MetodCase.GenerationOcenok(ocenka);
                        Grades_Students grades = new Grades_Students { id = maxdate, Date = splitdate[0], id_Student = f, Algebra = ocenka[0], Geometry = ocenka[1], Literature = ocenka[2], Physical_education = ocenka[3], Russian_language = ocenka[4], Work_ = ocenka[5] };
                        school.Grades_Students.Add(grades);
                        school.SaveChanges();
                    }
                    date = date.AddDays(1);
                    string[] datesplit = Convert.ToString(date).Split(new char[] { ' ' });
                    splitdate[0] = Convert.ToString(datesplit[0]);
                }
                ShoolEntities school2 = new ShoolEntities();
                dg2.ItemsSource = school2.Grades_Students.ToList();
                dg1.Visibility = Visibility.Hidden;
                dg2.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShoolEntities school1 = new ShoolEntities();
            dg1.ItemsSource = school1.Students.ToList();
            dg1.Visibility = Visibility.Visible;
            dg2.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ShoolEntities school2 = new ShoolEntities();
            dg2.ItemsSource = school2.Grades_Students.ToList();
            dg1.Visibility = Visibility.Hidden;
            dg2.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Vichislen vichislen = new Vichislen();
            vichislen.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sozdatnumberstud sozdatnumberstud = new Sozdatnumberstud();
            sozdatnumberstud.ShowDialog();
        }
    }
}
