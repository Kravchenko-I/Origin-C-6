// Задача 39: Напишите программу , которая перевернет
// одномерный массив(последний элемент будет на первом 
// месте,а первый - на последнем и т.д.)
// [123456]->[54321]
// [6736]->[6376]

Console.Clear();

int[]array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ",array));
// ReverseArray1(array);
// Console.WriteLine(String.Join(" ", array));
int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(" ",reversArray));



int[] GetArray(int size, int minValue,int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size;i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
}

void ReverseArray1(int[] inArray)
{   
    int length = inArray.Length;
    for (int i = 0; i < inArray.Length / 2; i++)
    {
         int k = inArray[i];
         inArray[i] = inArray[inArray.Length -1 - i];
         inArray[inArray.Length -1 -i] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] res = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        res[i] =inArray[inArray.Length -1 -i];
    }
    return res;
}