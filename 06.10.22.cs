//13
//string a = Console.ReadLine();
//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write(a[i] + " ");
//}
//for (int i = 0; i < a.Length; i++)
//{
//    if (i < a.Length - 1)
//    {
//        Console.Write(a[i]);
//        Console.WriteLine(a[i + 1] + " ");
//    }

//}
//Console.WriteLine();
//for (int i = 0; i < 1; i++)
//{
//    Console.Write(a[i]);
//    Console.WriteLine(a.Substring(a.Length - 1));
//    Console.WriteLine(" " + a);
//}


06
int[] array = new int[10];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 3);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}
Console.WriteLine();
Console.WriteLine("Какое число хотите удалить?");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == n)
    {
        Console.Write("");
    }
    else
    {
        Console.Write(array[i]);
    }
}
Console.WriteLine("");
foreach (int i in array)
{
    if (i == n)
    {
        continue;
    }
    Console.Write(i);
}
Console.WriteLine("");
int m = 0;
while (m < array.Length)
{
    if (array[m] == n)
    {
        Console.Write("");
    }
    else
    {
        Console.Write(array[m]);
    }
    m++;
}