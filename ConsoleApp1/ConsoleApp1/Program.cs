

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int count = 0;
foreach (var item in array)
{
    if (item % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);



int a = 5;
int b = 19;
int cem = 0;
int hasil = 1;
for (int i = a; i < b; i++)
{
    if (i % 2 == 0)
    {
        hasil *= i;
    }
    else { cem += i; }
}
Console.WriteLine(cem);
Console.WriteLine(hasil);