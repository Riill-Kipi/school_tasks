// №1
string a = "GGETRA";
int b = a.Length;
if (b % 2 == 1)
{
    int n = b / 2;
    Console.WriteLine(a[n]);
}
else if (b % 2 == 0)
{
    int v = b / 2 - 1;
    Console.Write(a[v]);
    v = v + 1;
    Console.WriteLine(a[v]);
}

// №2

int[,] b = { { 14, 14 }, { 42, 20 }, { 61, 1 }, { 37, 8 }, { 21, 21 }, { 78, 9 } };
string[] c = new string[6];

for (int i = 0; i < b.GetLength(0); i++)
{
    if (b[i, 0] > 36 && b[i, 1] > 6)
    {
        c[i] = "Senior";
    }
    else
    {
        c[i] = "Player";
    }
}

Console.WriteLine(" ");
for (int i = 0; i < c.Length; i++)
{
    Console.Write(" " + c[i] + ",");
}

///////////////////////////////////////////////////////////////////////////////////

Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] mas = new int[a, b];
if (a > 36 & b > 6)
{
    Console.WriteLine("senjor");
}
else
{
    Console.WriteLine("player");
}

 //№3

namespace Nomer_3
{
    class Program
    {
        private static void Main(string[] args)
        {
            string c = "hg73543lhli83524jgy8465";
            char[] a = c.ToCharArray();
            Console.WriteLine(a);
            string eet = "";
            int q = c.Length;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '8')
                {
                    char[] ar;
                    int n = q - i;
                    string txt = Convert.ToString(i);
                    int v = Convert.ToInt32(txt);
                    ar = c.ToCharArray(v, n);
                    for (i = 0; i < ar.Length; i++)
                    {
                        if (ar[i] == '1' || ar[i] == '2' || ar[i] == '3' || ar[i] == '4' || ar[i] == '5' || ar[i] == '6' || ar[i] == '7' || ar[i] == '8' || ar[i] == '9')
                        {
                            eet = eet + Convert.ToString(ar[i]);
                        }

                    }
                    break;
                }
            }
            Console.WriteLine(eet);
        }



    }
}