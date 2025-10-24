int[] array = { 1, 3, 55, 6, 33 };
int hasil = 1;
foreach (var item in array)
{
    if (item > 1 && item < 20)
    {
        hasil *= item;
    }
}
Console.WriteLine(hasil);


