// See https://aka.ms/new-console-template for more information
//using static TestDLL.Matem;
//using  TestDLL;
using ClassLibrary2;
using static System.Console;

Matem m = new Matem();
Console.WriteLine("{0}\t{1}"
, m.Daraja(4, 2), m.Faktorial(5));
double a = m.Daraja(7, 3);
a = double.MaxValue + 1;
try
{
    if (a < double.MaxValue)
        WriteLine("Good");

}
catch (ArgumentOutOfRangeException)
{
    WriteLine("The number is out of double type range");
}
catch(Exception c)
{
    WriteLine(c.Message);
}
int k = 0;
string s = null;
try
{
    int i = 1 / k;
}
catch(Exception c)
{
    WriteLine(c.Message);
}
try
{
    WriteLine(s.Length);
}
catch(Exception c)
{
    WriteLine(c.Message);
}
finally
{
    WriteLine("Something else");
}