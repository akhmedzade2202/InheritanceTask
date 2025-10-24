//int a = 5;
//int b = 19;
//int cem = 0;
//int hasil = 1;
//for (int i = a; i < b; i++)
//{
//    if (i % 2 == 0)
//    {
//        hasil *= i;
//    }
//    else { cem += i; }
//}
//Console.WriteLine(cem);
//Console.WriteLine(hasil);  


int[] array = { 1, 3, 55, 6, 33 };
int hasil = 1;
foreach (var item in array)
{
    if (item>1 && item<20)
    {
        hasil *= item;
    }
}Console.WriteLine(hasil);