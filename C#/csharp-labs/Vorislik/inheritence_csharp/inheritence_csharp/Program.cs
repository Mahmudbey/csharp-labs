using System;

namespace inheritence_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Odam o1 = new Odam();
            //o1.Fam = "Bozorov";
            //o1.Ism = "Aziz";
            //o1.Yosh = 22;
            //o1.FIY();
            ////o1.Lavozim = "O'qituvchi";
            ////o1.Maosh = 4950000;
            ////o1.LM();

            //Odam o2 = new Xodim();
            //o2.Fam = "Doniyorov";
            //o2.Ism = "Bobur";
            //o2.Yosh = 25;
            //o2.FIY();
            ////o2.Lavozim = "O'qituvchi";
            ////o2.Maosh = 4950000;
            ////o2.LM();

            //Xodim o3 = new Xodim();
            //o3.Fam = "Fozilov";
            //o3.Ism = "Sherzod";
            //o3.Yosh = 27;
            //o3.Lavozim = "O'qituvchi";
            //o3.Maosh = 4950000;
            //o3.FIY();
            //o3.LM();

            //Rahbar o4 = new Rahbar();
            //o4.Fam = "Adilov";
            //o4.Ism = "Anvar";
            //o4.Yosh = 30;
            //o4.FIY();
            //o4.Lavozim = "Dekan";
            //o4.Maosh = 6950000;
            //o4.LM();
            //o4.Rahbarligi = "Fakultet dekani";
            //o4.Bulim = "Amaliy mat va IT";
            //o4.RB();

            Izlanuvchi o5 = new Izlanuvchi();
            o5.Fam = "Begulov";
            o5.Ism = "O'tkir";
            o5.Yosh = 27;
            o5.FIY();
            o5.Lavozim = "Tadqiqotchi";
            o5.Maosh = 4950000;
            o5.LM();
            o5.Fakultet = "Amaliy mat va IT";
            o5.ilm_rah = "Xaydarov Abdugappor";
            o5.FIR();

            Doktorant o6 = new Doktorant();
            o6.Fam = "Begulov";
            o6.Ism = "O'tkir";
            o6.Yosh = 27;
            o6.FIY();
            o6.Lavozim = "Tadqiqotchi";
            o6.Maosh = 4950000;
            o6.LM();
            o6.Fakultet = "Amaliy mat va IT";
            o6.ilm_rah = "Xaydarov Abdugappor";
            o6.FIR();
            o6.Kurs = 1;
            o6.kurs();
        }
    }

     class Odam
    {
        public string Fam { get; set; }
        public string Ism { get; set; }
        public int Yosh { get; set; }

        public void FIY()
        {
            string s1 = string.Format("\nFamiliya:\t{0}\nIsm:\t{1}\nYosh:\t{2}"
                , Fam, Ism, Yosh);
            Console.WriteLine(s1);
        }
    }
     class Xodim:Odam
     {
         public string Lavozim { get; set; }
         public double Maosh { get; set; }

         public void LM()
         {
             string s2 = string.Format("Lavozim:\t{0}\nMaosh:\t{1}"
                 , Lavozim, Maosh);
             Console.WriteLine(s2);
         }
     }
     class Rahbar : Xodim
     {
         public string Rahbarligi { get; set; }
         public string Bulim { get; set; }

         public void RB()
         {
             string s3 = string.Format("Lavozim:\t{0}\nBo'lim:\t{1}"
                 , Rahbarligi, Bulim);
             Console.WriteLine(s3);
         }
     }
}
