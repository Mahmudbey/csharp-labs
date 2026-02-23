using System;

namespace inheritence_csharp
{
    class Izlanuvchi:Xodim
    {
        public string Fakultet { get; set; }
        public string ilm_rah { get; set; }

        public void FIR()
        {
            string s4 = string.Format("Fakultet:\t{0}\nIlmiy rahbari:\t{1}"
                , Fakultet, ilm_rah);
            Console.WriteLine(s4);
        }
    }
    class Doktorant:Izlanuvchi
    {
        public int Kurs { get; set; }

        public void kurs()
        {
            string s5 = string.Format("Kurs:\t{0}"
                , Kurs);
            Console.WriteLine(s5);
        }
    }
}
