namespace ClassLibrary2
{
    public class Matem
    {
        public double Faktorial(int n) => n == 0 ? 1 : n * Faktorial(n - 1);
        public double Daraja(double a, double n) => Math.Pow(a, n);
    }
}