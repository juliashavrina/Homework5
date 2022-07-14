/*int[] CreateRandomArray (int size,int minValue, int maxValue) 
{
    int[] newArray = new int[size];
    {
        for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next (100, 1000);
    }
    return newArray;
}
void ShowArray ( int[] array)  
{
    for ( int i = 0; i < array.Length; i++)
    Console.Write(array [i] + " ");

   Console.WriteLine(); 
} 
int FindEvenElements (int[] array)
{   
    int count = 0;
        for ( int i = 0; i < array.Length; i++)
            if (array [i] % 2 ==0) count++;
    return count;
}

Console.Write($"Input size of array: "); 
int size = Convert.ToInt32 (Console.ReadLine ());
Console.Write($"Input min of posible elements: "); 
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write($"Input max of posible elements: "); 
int max = Convert.ToInt32 (Console.ReadLine ());
int[] array = CreateRandomArray (size, min, max);
ShowArray (array);
Console.WriteLine($"The number of even elements in current array :" +  FindEvenElements (array));
*/

/*int[] CreateRandomArray (int size, int minValue, int maxValue) 
{
    int[] newArray = new int[size];
    {
        for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next (minValue, maxValue);
    }
    return newArray;
}
void ShowArray ( int[] array)  
{
    for ( int i = 0; i < array.Length; i++)
    Console.Write(array [i] + " ");

   Console.WriteLine(); 
} 
int FindSumOddPostion (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    sum = sum + array[i];
    return sum;
}

Console.Write($"Input size of array: "); 
int size = Convert.ToInt32 (Console.ReadLine ());
Console.Write($"Input min of posible elements: "); 
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write($"Input max of posible elements: "); 
int max = Convert.ToInt32 (Console.ReadLine ());
int[] array = CreateRandomArray (size, min, max);
ShowArray (array);
Console.WriteLine($"Summa of elements on odd position: " +  FindSumOddPostion(array));
*/

/*double[] CreateRandomArray (int size, int minValue, int maxValue)
{
  double[] newArray = new double[size];

    {
        for (int i = 0; i < size; i++)
        newArray [i] = new Random().NextDouble() + new Random().Next( minValue, maxValue);
        return newArray;
    }
    
}
void ShowArray ( double[] array)  
{
    for ( int i = 0; i < array.Length; i++)
    Console.Write(array [i] + " ");

   Console.WriteLine(); 
} 
double FindDifferenceElements (double[] array)
    
{
    double min = array[0];
    double max = array[0];
    double dif = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i] ;
        if (array[i] > max) max = array[i] ;
        dif = max -min;
    }
    return dif;
}
Console.Write($"Input size of array: "); 
int size = Convert.ToInt32 (Console.ReadLine ());
Console.Write($"Input min of posible elements: "); 
int min = Convert.ToInt32 (Console.ReadLine ());
Console.Write($"Input max of posible elements: "); 
int max = Convert.ToInt32 (Console.ReadLine ());
double[] array = CreateRandomArray (size, min, max);
ShowArray (array);
Console.WriteLine($"Differens between max and min is: " +  FindDifferenceElements(array));
*/


