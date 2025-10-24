//int[] array = { 1, 3, 5, 0 };

//int maxEded = 0;

//foreach (var item in array)
//{
//    if (item % 2 == 0)
//    {
//        if (item > maxEded)
//        {
//            maxEded = item;
//        }

//    }

//}
//if (maxEded == 0)
//{
//    Console.WriteLine("Cut eded yoxdur");
//}
//else
//{
//    Console.WriteLine(maxEded);
//}


//int[] array = { 1, 2, 3, 4, 5 };
//int sum = array.Sum();
//Console.WriteLine(sum/array.Length);

//int a = 17;
//int b = 25;

//bool result = (a % 9 == 0) || (b % 9 == 0);

//Console.WriteLine(result);


int[] array = { 1, 2, 3, 4, 5, 6 };
int maxArray = array.Max();
int minArray = array.Min();
int dec = maxArray - minArray;

Console.WriteLine(dec);


Console.WriteLine(array.Max() - array.Min());
