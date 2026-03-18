int[] a = { 1, 2, 3, 4 };
int[] num = { 5, 6, 7, 89 };
ArrSize(ref a, num);
static void ArrSize(ref int[] a, params int[] num)
{
    int[] newArr = new int[a.Length + num.Length];
    for (int i = 0; i < a.Length; i++)
    {
        newArr[i] = a[i];
    }
    for (int i = 0; i < num.Length; i++)
    {
        newArr[a.Length + i] = num[i];
    }
    a = newArr;
    for (int i = 0; i < newArr.Length; i++)
    {
        Console.WriteLine(newArr[i]);
    }
}
