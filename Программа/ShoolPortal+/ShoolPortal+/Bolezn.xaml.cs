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
    /// Логика взаимодействия для Bolezn.xaml
    /// </summary>
    public partial class Bolezn : Window
    {
        ShoolEntities shool = new ShoolEntities();
        public Bolezn()
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
            cb2.Items.Add("    -");
            cb2.Text = "    -";
            cb2.Items.Add("    Январь");
            cb2.Items.Add("    Февраль");
            cb2.Items.Add("    Март");
            cb2.Items.Add("    Апрель");
            cb2.Items.Add("    Май");
            cb2.Items.Add("    Июнь");
            cb2.Items.Add("    Июль");
            cb2.Items.Add("    Август");
            cb2.Items.Add("    Сентябрь");
            cb2.Items.Add("    Октябрь");
            cb2.Items.Add("    Ноябрь");
            cb2.Items.Add("    Декабрь");
        }

        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            lb1.Text = "";
            bt1.Visibility = Visibility.Hidden;
            cb2.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Visible;
        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            lb1.Text = "";
            bt3.Visibility = Visibility.Hidden;
            dp2.Visibility = Visibility.Hidden;
            dp1.Visibility = Visibility.Hidden;
            none1.Visibility = Visibility.Hidden;
            none2.Visibility = Visibility.Hidden;
            bt4.Visibility = Visibility.Visible;
            bt5.Visibility = Visibility.Visible;
        }

        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            lb1.Text = "Месяц";
            bt1.Visibility = Visibility.Visible;
            cb2.Visibility = Visibility.Visible;
            bt4.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Hidden;
        }

        private void Bt4_Click(object sender, RoutedEventArgs e)
        {
            lb1.Text = "Период";
            bt3.Visibility = Visibility.Visible;
            dp2.Visibility = Visibility.Visible;
            dp1.Visibility = Visibility.Visible;
            none1.Visibility = Visibility.Visible;
            none2.Visibility = Visibility.Visible;
            bt4.Visibility = Visibility.Hidden;
            bt5.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lb1.Text == "Период")
            {
                if (cb1.Text != "-")
                {
                    try
                    {
                        var dateOT = Convert.ToDateTime(dp1.Text);
                        var dateDO = Convert.ToDateTime(dp2.Text);

                        if (dateOT < dateDO)
                        {
                            var dat = dateDO.Subtract(dateOT);
                            string[] gad = Convert.ToString(dat).Split(new char[] { '.' });
                            int chisloraznits = Convert.ToInt32(gad[0]) + 1;

                            var namestud = shool.Students.Single(p => p.Last_name + " " + p.First_name + " " + p.Middle_name == cb1.Text);

                            string[] algebrapropysk = new string[chisloraznits];
                            string[] geometrypropysk = new string[chisloraznits];
                            string[] literaturepropysk = new string[chisloraznits];
                            string[] physivalpropysk = new string[chisloraznits];
                            string[] russianpropysk = new string[chisloraznits];
                            string[] workpropysk = new string[chisloraznits];

                            //Посик пропусков с внесением в массив            
                            int schet = 0;
                            for (var i = dateOT; i <= Convert.ToDateTime(dateDO);)
                            {
                                var j = Convert.ToString(i);
                                string[] splitdate = j.Split(new char[] { ' ' });
                                var j1 = splitdate[0];
                                try
                                {
                                    var kollpropusk = shool.Grades_Students.Single(p => p.Date == j1 && p.id_Student == namestud.id_Student);
                                    string[] splitdate1 = kollpropusk.Date.Split(new char[] { ' ' });
                                    algebrapropysk[schet] = splitdate1[0] + " " + kollpropusk.Algebra;
                                    geometrypropysk[schet] = splitdate1[0] + " " + kollpropusk.Geometry;
                                    literaturepropysk[schet] = splitdate1[0] + " " + kollpropusk.Literature;
                                    physivalpropysk[schet] = splitdate1[0] + " " + kollpropusk.Physical_education;
                                    russianpropysk[schet] = splitdate1[0] + " " + kollpropusk.Russian_language;
                                    workpropysk[schet] = splitdate1[0] + " " + kollpropusk.Work_;
                                    schet = schet + 1;
                                }
                                catch { }
                                dateOT = dateOT.AddDays(1);
                                i = dateOT;
                            }
                            MetodCase.KollBolel(chisloraznits, algebrapropysk, geometrypropysk, literaturepropysk, physivalpropysk, russianpropysk, workpropysk);

                            if (algebrapropysk[0] == null)
                            {
                                algebrapropysk[0] = "0";
                                tb1.Text = algebrapropysk[0];
                            }
                            else
                            {
                                tb1.Text = algebrapropysk[0];
                            }


                        }
                        else
                        {
                            MessageBox.Show("Начальная дата, не может быть меньше конечной даты.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Проверьте правильность заполнения данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Для подсчета пропусков по болезни, необходимо ввести Ф.И.О. студента.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            if (lb1.Text == "Месяц")
            {
                var got = Convert.ToString(DateTime.Now);
                string[] got1 = got.Split(new char[] { ' ' });
                string[] got2 = got1[0].Split(new char[] { '.' });
                var visokosn = DateTime.IsLeapYear(Convert.ToInt32(got2[2]));
                string dateOT = "-";
                string dateDO = "-";

                if (cb2.Text == "    Январь")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.01." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.01." + got2[2]));
                }
                if (cb2.Text == "    Февраль")
                {
                    if (visokosn == true)
                    {
                        dateOT = Convert.ToString(Convert.ToDateTime("01.02." + got2[2]));
                        dateDO = Convert.ToString(Convert.ToDateTime("29.02." + got2[2]));
                    }
                    else
                    {
                        dateOT = Convert.ToString(Convert.ToDateTime("01.02." + got2[2]));
                        dateDO = Convert.ToString(Convert.ToDateTime("28.02." + got2[2]));
                    }
                }
                if (cb2.Text == "    Март")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.03." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.03." + got2[2]));
                }
                if (cb2.Text == "    Апрель")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.04." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("30.04." + got2[2]));
                }
                if (cb2.Text == "    Май")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.05." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.05." + got2[2]));
                }
                if (cb2.Text == "    Июнь")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.06." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("30.06." + got2[2]));
                }
                if (cb2.Text == "    Июль")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.07." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.07." + got2[2]));
                }
                if (cb2.Text == "    Август")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.08." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.08." + got2[2]));
                }
                if (cb2.Text == "    Сентябрь")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.09." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("30.09." + got2[2]));
                }
                if (cb2.Text == "    Октябрь")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.10." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.10." + got2[2]));
                }
                if (cb2.Text == "    Ноябрь")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.11." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("30.11." + got2[2]));
                }
                if (cb2.Text == "    Декабрь")
                {
                    dateOT = Convert.ToString(Convert.ToDateTime("01.12." + got2[2]));
                    dateDO = Convert.ToString(Convert.ToDateTime("31.12." + got2[2]));
                }

                if (cb2.Text != "    -")
                {
                    if (cb1.Text != "-")
                    {
                        var dat = Convert.ToDateTime(dateDO).Subtract(Convert.ToDateTime(dateOT));
                        string[] gad = Convert.ToString(dat).Split(new char[] { '.' });
                        int chisloraznits = Convert.ToInt32(gad[0]) + 1;

                        var namestud = shool.Students.Single(p => p.Last_name + " " + p.First_name + " " + p.Middle_name == cb1.Text);

                        string[] algebrapropysk = new string[chisloraznits];
                        string[] geometrypropysk = new string[chisloraznits];
                        string[] literaturepropysk = new string[chisloraznits];
                        string[] physivalpropysk = new string[chisloraznits];
                        string[] russianpropysk = new string[chisloraznits];
                        string[] workpropysk = new string[chisloraznits];

                        //Посик пропусков с внесением в массив            
                        int schet = 0;
                        for (var i = Convert.ToDateTime(dateOT); i <= Convert.ToDateTime(dateDO);)
                        {
                            var j = Convert.ToString(i);
                            string[] splitdate = j.Split(new char[] { ' ' });
                            var j1 = splitdate[0];
                            try
                            {
                                var kollpropusk = shool.Grades_Students.Single(p => p.Date == j1 && p.id_Student == namestud.id_Student);
                                string[] splitdate1 = kollpropusk.Date.Split(new char[] { ' ' });
                                algebrapropysk[schet] = splitdate1[0] + " " + kollpropusk.Algebra;
                                geometrypropysk[schet] = splitdate1[0] + " " + kollpropusk.Geometry;
                                literaturepropysk[schet] = splitdate1[0] + " " + kollpropusk.Literature;
                                physivalpropysk[schet] = splitdate1[0] + " " + kollpropusk.Physical_education;
                                russianpropysk[schet] = splitdate1[0] + " " + kollpropusk.Russian_language;
                                workpropysk[schet] = splitdate1[0] + " " + kollpropusk.Work_;
                                schet = schet + 1;
                            }
                            catch { }
                            dateOT = Convert.ToString(Convert.ToDateTime(dateOT).AddDays(1));
                            i = Convert.ToDateTime(dateOT);
                        }

                        MetodCase.KollBolel(chisloraznits, algebrapropysk, geometrypropysk, literaturepropysk, physivalpropysk, russianpropysk, workpropysk);

                        if (algebrapropysk[0] == null)
                        {
                            algebrapropysk[0] = "0";
                            tb1.Text = algebrapropysk[0];
                        }
                        else
                        {
                            tb1.Text = algebrapropysk[0];
                        }


                    }
                    else
                    {
                        MessageBox.Show("Для подсчета пропусков по болезни, необходимо ввести Ф.И.О. студента.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать дату для подсчета пропусков по болезни.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
            if (lb1.Text == "")
            {
                MessageBox.Show("Первым делом, необходимо выбрать метод подсчета прогулов.", "Оповещение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
