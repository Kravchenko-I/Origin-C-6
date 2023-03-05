// Задача 39: Напишите программу , которая перевернет
// одномерный массив(последний элемент будет на первом 
// месте,а первый - на последнем и т.д.)
// [123456]->[54321]
// [6736]->[6376]

Console.Clear();

int[]array = GetArray(10,0,10);
Console.WriteLine(String.Join(" ",array));



int[] GetArray(int size, int minValue,int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size;i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
    }
    return res;
}