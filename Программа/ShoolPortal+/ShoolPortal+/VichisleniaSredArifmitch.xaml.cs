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
    /// Логика взаимодействия для VichisleniaSredArifmitch.xaml
    /// </summary>
    public partial class VichisleniaSredArifmitch : Window
    {
        ShoolEntities shool = new ShoolEntities();
        public VichisleniaSredArifmitch()
        {
            InitializeComponent();

            var max = shool.Students.Max(p => p.id_Student);
            cb1.Items.Add("-");
            cb1.Text = "-";
            for (int i =1; i<=max; i++)
            {        
                var studname = shool.Students.Single(p => p.id_Student == i);
                cb1.Items.Add(studname.Last_name + " " + studname.First_name + " " + studname.Middle_name);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          if(cb1.Text != "-")
          { 
            var name_student = shool.Students.Single(p => p.Last_name + " " + p.First_name + " " + p.Middle_name == cb1.Text);
            //Запись всех оценок по Алгебре в массив
            var grades_student_1 = shool.Grades_Students.Where(p => p.id_Student == name_student.id_Student && p.Algebra !="н" && p.Algebra != "п" && p.Algebra != "+" && p.Algebra != "б");
            var grades_student_max = grades_student_1.Max(p => p.id);
            var count_student = grades_student_1.Count(p => p.id_Student == name_student.id_Student);
            string[] grades_Algebra = new string[count_student];      
            for (int i = 0, f = 0; i<= grades_student_max && f <= count_student;i++)
            {
                try
                {
                    var massiv = grades_student_1.Single(p => p.id == i);
                    if (massiv != null)
                    {
                        grades_Algebra[f] = massiv.Algebra;
                        f++;
                    }
                }
                catch
                {
                }
            }
            //Запись всех оценок по Геометрии в массив
            var grades_student_2 = shool.Grades_Students.Where(p => p.id_Student == name_student.id_Student && p.Geometry != "н" && p.Geometry != "п" && p.Geometry != "+" && p.Geometry != "б");
            var grades_student_max2 = grades_student_2.Max(p => p.id);
            var count_student2 = grades_student_2.Count(p => p.id_Student == name_student.id_Student);
            string[] grades_Geometry = new string[count_student2];
            for (int i = 0, f = 0; i <= grades_student_max2 && f <= count_student2; i++)
            {
                try
                {
                    var massiv = grades_student_2.Single(p => p.id == i);
                    if (massiv != null)
                    {
                        grades_Geometry[f] = massiv.Geometry;
                        f++;
                    }
                }
                catch
                {
                }
            }
            //Запись всех оценок по Литературы в массив
            var grades_student_3 = shool.Grades_Students.Where(p => p.id_Student == name_student.id_Student && p.Literature != "н" && p.Literature != "п" && p.Literature != "+" && p.Literature != "б");
            var grades_student_max3 = grades_student_3.Max(p => p.id);
            var count_student3 = grades_student_3.Count(p => p.id_Student == name_student.id_Student);
            string[] grades_Literature = new string[count_student3];
            for (int i = 0, f = 0; i <= grades_student_max3 && f <= count_student3; i++)
            {
                try
                {
                    var massiv = grades_student_3.Single(p => p.id == i);
                    if (massiv != null)
                    {
                        grades_Literature[f] = massiv.Literature;
                        f++;
                    }
                }
                catch
                {
                }
            }
            //Запись всех оценок по Физкультуры в массив
            var grades_student_4 = shool.Grades_Students.Where(p => p.id_Student == name_student.id_Student && p.Physical_education != "н" && p.Physical_education != "п" && p.Physical_education != "+" && p.Physical_education != "б");
            var grades_student_max4 = grades_student_4.Max(p => p.id);
            var count_student4 = grades_student_4.Count(p => p.id_Student == name_student.id_Student);
            string[] grades_Physical_education = new string[count_student4];
            for (int i = 0, f = 0; i <= grades_student_max4 && f <= count_student4; i++)
            {
                try
                {
                    var massiv = grades_student_4.Single(p => p.id == i);
                    if (massiv != null)
                    {
                        grades_Physical_education[f] = massiv.Physical_education;
                        f++;
                    }
                }
                catch
                {
                }
            }
            //Запись всех оценок по Русскому языку в массив
            var grades_student_5 = shool.Grades_Students.Where(p => p.id_Student == name_student.id_Student && p.Russian_language != "н" && p.Russian_language != "п" && p.Russian_language != "+" && p.Russian_language != "б");
            var grades_student_max5 = grades_student_5.Max(p => p.id);
            var count_student5 = grades_student_5.Count(p => p.id_Student == name_student.id_Student);
            string[] grades_Russian_language = new string[count_student5];
            for (int i = 0, f = 0; i <= grades_student_max5 && f <= count_student5; i++)
            {
                try
                {
                    var massiv = grades_student_5.Single(p => p.id == i);
                    if (massiv != null)
                    {
                        grades_Russian_language[f] = massiv.Russian_language;
                        f++;
                    }
                }
                catch
                {
                }
            }
            //Запись всех оценок по Трудам в массив
            var grades_student_6 = shool.Grades_Students.Where(p => p.id_Student == name_student.id_Student && p.Work_ != "н" && p.Work_ != "п" && p.Work_ != "+" && p.Work_ != "б");
            var grades_student_max6 = grades_student_6.Max(p => p.id);
            var count_student6 = grades_student_6.Count(p => p.id_Student == name_student.id_Student);
            string[] grades_Work_ = new string[count_student6];
            for (int i = 0, f = 0; i <= grades_student_max6 && f <= count_student6; i++)
            {
                try
                {
                    var massiv = grades_student_6.Single(p => p.id == i);
                    if (massiv != null)
                    {
                        grades_Work_[f] = massiv.Work_;
                        f++;
                    }
                }
                catch
                {
                }
            }

            MetodCase.SrednArifm(grades_Algebra,grades_Geometry,grades_Literature,grades_Physical_education,grades_Russian_language,grades_Work_);

            tb1.Text = grades_Algebra[0];
            tb2.Text = grades_Geometry[0];
            tb3.Text = grades_Literature[0];
            tb4.Text = grades_Physical_education[0];
            tb5.Text = grades_Russian_language[0];
            tb6.Text = grades_Work_[0];

            tb1_Copy.Text = "("+grades_Algebra[1]+")";
            tb2_Copy.Text = "(" + grades_Geometry[1] + ")";
            tb3_Copy.Text = "(" + grades_Literature[1] + ")";
            tb4_Copy.Text = "(" + grades_Physical_education[1] + ")";
            tb5_Copy.Text = "(" + grades_Russian_language[1] + ")";
            tb6_Copy.Text = "(" + grades_Work_[1] + ")";
            }
          else
          {
                MessageBox.Show("Выберите Ф.И.О. Студента", "Ошибка при выборе Ф.И.О.", MessageBoxButton.OK, MessageBoxImage.Error);
          }
        }
    }
}
