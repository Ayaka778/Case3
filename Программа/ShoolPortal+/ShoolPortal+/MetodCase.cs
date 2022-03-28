using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoolPortal_
{
    class MetodCase
    {
        static Random rand = new Random();
        public static void GenerationOcenok(string[] ocenka)
        {
            string[] vseotmetki = new string[8];
            vseotmetki[0] = "2";
            vseotmetki[1] = "3";
            vseotmetki[2] = "4";
            vseotmetki[3] = "5";
            vseotmetki[4] = "н";
            vseotmetki[5] = "п";
            vseotmetki[6] = "б";
            vseotmetki[7] = "+";            
            for (int i = 0; i <= 5; i++)
            {
                int next = rand.Next(0, 8);
                ocenka[i] = vseotmetki[next];
            }
            return;
        }

        public static void SrednArifm(string[] grades_Algebra, string[] grades_Geometry, string[] grades_Literature, string[] grades_Physical_education, string[] grades_Russian_language, string[] grades_Work_)
        {
            int algebr = grades_Algebra.Length;
            double srendznachalgebr=0;
            int geometr = grades_Geometry.Length;
            double srendznachgeometr = 0;
            int liter = grades_Literature.Length;
            double srendznachaliter = 0;
            int phys = grades_Physical_education.Length;
            double srendznachafizkult = 0;
            int russ = grades_Russian_language.Length;
            double srendznachruss = 0;
            int work = grades_Work_.Length;
            double srendznachwork = 0;          
            //================================================================================================
            for(int i=0; i<= algebr-1; i++)
            {
                srendznachalgebr = Convert.ToDouble(Convert.ToInt32(srendznachalgebr) + Convert.ToInt32(grades_Algebra[i]));
                if(i == algebr-1)
                {
                    srendznachalgebr = srendznachalgebr / algebr;
                    grades_Algebra[0] = Convert.ToString(Math.Round(srendznachalgebr));
                    grades_Algebra[1] = Convert.ToString(Math.Round(srendznachalgebr, 2));
                }
            }
            //================================================================================================
            for (int i = 0; i <= geometr-1; i++)
            {
                srendznachgeometr = Convert.ToDouble(Convert.ToInt32(srendznachgeometr) + Convert.ToInt32(grades_Geometry[i]));
                if (i == geometr-1)
                {
                    srendznachgeometr = srendznachgeometr / geometr;
                    grades_Geometry[0] = Convert.ToString(Math.Round(srendznachgeometr));
                    grades_Geometry[1] = Convert.ToString(Math.Round(srendznachgeometr, 2));
                }
            }
            //================================================================================================
            for (int i = 0; i <= liter-1; i++)
            {
                srendznachaliter = Convert.ToDouble(Convert.ToInt32(srendznachaliter) + Convert.ToInt32(grades_Literature[i]));
                if (i == liter-1)
                {
                    srendznachaliter = srendznachaliter / liter;
                    grades_Literature[0] = Convert.ToString(Math.Round(srendznachaliter));
                    grades_Literature[1] = Convert.ToString(Math.Round(srendznachaliter, 2));
                }
            }
            //================================================================================================
            for (int i = 0; i <= phys-1; i++)
            {
                srendznachafizkult = Convert.ToDouble(Convert.ToInt32(srendznachafizkult) + Convert.ToInt32(grades_Physical_education[i]));
                if (i == phys-1)
                {
                    srendznachafizkult = srendznachafizkult / phys;
                    grades_Physical_education[0] = Convert.ToString(Math.Round(srendznachafizkult));
                    grades_Physical_education[1] = Convert.ToString(Math.Round(srendznachafizkult, 2));
                }
            }
            //================================================================================================
            for (int i = 0; i <= russ-1; i++)
            {
                srendznachruss = Convert.ToDouble(Convert.ToInt32(srendznachruss) + Convert.ToInt32(grades_Russian_language[i]));
                if (i == russ-1)
                {
                    srendznachruss = srendznachruss / russ;
                    grades_Russian_language[0] = Convert.ToString(Math.Round(srendznachruss));
                    grades_Russian_language[1] = Convert.ToString(Math.Round(srendznachruss, 2));

                }
            }
            //================================================================================================
            for (int i = 0; i <= work-1; i++)
            {
                srendznachwork = Convert.ToDouble(Convert.ToInt32(srendznachwork) + Convert.ToInt32(grades_Work_[i]));
                if (i == work-1)
                {
                    srendznachwork = srendznachwork / work;
                    grades_Work_[0] = Convert.ToString(Math.Round(srendznachwork));
                    grades_Work_[1] = Convert.ToString(Math.Round(srendznachwork, 2));
                }
            }
            //================================================================================================
            return;
        }

        public static void KollProgulov(int chisloraznits, string[] algebrapropysk, string[] geometrypropysk, string[] literaturepropysk, string[] physivalpropysk, string[] russianpropysk, string[] workpropyskl)
        {
            int schet = chisloraznits;
            chisloraznits = 0;

            for (var i = 0; i <= schet; i++)
            {
              try
              {
                var algebrapropsksplit = algebrapropysk[i].Split(new char[] { ' ' });
                var geometrypropysplit = geometrypropysk[i].Split(new char[] { ' ' });
                var literaturepsksplit = literaturepropysk[i].Split(new char[] { ' ' });
                var physivalpropysplit = physivalpropysk[i].Split(new char[] { ' ' });
                var russianpropysplit = russianpropysk[i].Split(new char[] { ' ' });
                var workpropysklsplit = workpropyskl[i].Split(new char[] { ' ' });
               
                if (algebrapropsksplit[1] == "п")
                {
                    chisloraznits = chisloraznits + 1;
                }
                if (geometrypropysplit[1] == "п")
                {
                    chisloraznits = chisloraznits + 1;
                }
                if (literaturepsksplit[1] == "п")
                {
                    chisloraznits = chisloraznits + 1;
                }
                if (physivalpropysplit[1] == "п")
                {
                    chisloraznits = chisloraznits + 1;
                }
                if (russianpropysplit[1] == "п")
                {
                    chisloraznits = chisloraznits + 1;
                }
                if (workpropysklsplit[1] == "п")
                {
                    chisloraznits = chisloraznits + 1;
                }
              }
              catch { }
            }
            algebrapropysk[0] = Convert.ToString(chisloraznits);
            return;
        }

        public static void KollBolel(int chisloraznits, string[] algebrapropysk, string[] geometrypropysk, string[] literaturepropysk, string[] physivalpropysk, string[] russianpropysk, string[] workpropyskl)
        {
            int schet = chisloraznits;
            chisloraznits = 0;

            for (var i = 0; i <= schet; i++)
            {
                try
                {
                    var algebrapropsksplit = algebrapropysk[i].Split(new char[] { ' ' });
                    var geometrypropysplit = geometrypropysk[i].Split(new char[] { ' ' });
                    var literaturepsksplit = literaturepropysk[i].Split(new char[] { ' ' });
                    var physivalpropysplit = physivalpropysk[i].Split(new char[] { ' ' });
                    var russianpropysplit = russianpropysk[i].Split(new char[] { ' ' });
                    var workpropysklsplit = workpropyskl[i].Split(new char[] { ' ' });

                    if (algebrapropsksplit[1] == "б")
                    {
                        chisloraznits = chisloraznits + 1;
                    }
                    if (geometrypropysplit[1] == "б")
                    {
                        chisloraznits = chisloraznits + 1;
                    }
                    if (literaturepsksplit[1] == "б")
                    {
                        chisloraznits = chisloraznits + 1;
                    }
                    if (physivalpropysplit[1] == "б")
                    {
                        chisloraznits = chisloraznits + 1;
                    }
                    if (russianpropysplit[1] == "б")
                    {
                        chisloraznits = chisloraznits + 1;
                    }
                    if (workpropysklsplit[1] == "б")
                    {
                        chisloraznits = chisloraznits + 1;
                    }
                }
                catch { }
            }
            algebrapropysk[0] = Convert.ToString(chisloraznits);
            return;
        }

        public static void GenerationCollegIdStud(string idstudent, string year_of_admission,string group, string[] idcollegstud)
        {
            string[] year = year_of_admission.Split(new char[] { '.' });
            string idco11egstud = year[2] + "." + group + "." + idstudent;
            idcollegstud[0] = idco11egstud;
            return ;
        }
    }
}
