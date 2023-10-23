// See https://aka.ms/new-console-template for more information
//int?[] numbers = new int?[7];
int[] numbers = new int[7];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + ", ");
}
//int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
int[] numbers2 = { 1,2,3,4,5,6,7};
foreach (int x in numbers2)
{
    Console.Write(x + ", ");
}
Console.WriteLine();
numbers2[3] = 100;
foreach (int x in numbers2)
{
    Console.Write(x + ", ");
}
Console.WriteLine();
// numbers2[8] = 100; // IndexOutOfRangeException
Console.WriteLine(numbers2.Length);
Array.Sort(numbers2);
foreach (int x in numbers2)
{
    Console.Write(x + ", ");
}
Console.WriteLine();
Array.Reverse(numbers2);
foreach (int x in numbers2)
{
    Console.Write(x + ", ");
}
Console.WriteLine();
Console.WriteLine(numbers2.Contains(6));
Console.WriteLine(Array.IndexOf(numbers2, 9));
Console.WriteLine(Array.MaxLength);
Array.Fill(numbers, 1);
int[] numbers3 = MultiplyValues(numbers2, 5);
foreach (int x in numbers3)
{
    Console.Write(x + ", ");
}
Console.WriteLine();
//int[,] map = new int[2, 3];
int[,] map = { { 1,2},{3,4 },{ 5,6} };
foreach (int x in map)
{
    Console.Write(x + ",");
}
Console.WriteLine(map.Rank);
for(int i = 0; i < map.GetLength(0); i++)
{
    for (int j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(map[i,j] + ",");
    }
    Console.WriteLine();
}
// jagged Array
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[4];
jaggedArray[2] = new int[2];
jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
jaggedArray[1] = new int[] { 0, 2, 4, 6 };
jaggedArray[2] = new int[] { 11, 22 };
int[][] jaggedArray2 = new int[][]
{
new int[] { 1, 3, 5, 7, 9 },
new int[] { 0, 2, 4, 6 },
new int[] { 11, 22 }
};
jaggedArray2[0][1] = 77;
foreach (int[] x in jaggedArray)
{
    foreach (int y in x)
    {
        Console.WriteLine(y);
    }
}

int[] arr1 = { 1, 2, 3, 4, 5 };
int[] arr2 = arr1; // reference ukazují na stejné místo
arr2[2] = 100;
Console.WriteLine(arr1[2]); // 100

int[] MultiplyValues(int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= value;
    }
    return arr;
}

void MultiplyValues2(ref int[] arr, int value)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= value;
    }
}