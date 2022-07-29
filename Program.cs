string [] arr = new string [] {"бабочка","жук","оса","кузнечик","тля"};
int count = 0;
Console.WriteLine("Первый массив");
for(int i = 0; i<arr.Length; i++)
{
    if(arr[i].Length<=3)
    {
      count = i-1;      
    }
    Console.Write(arr[i]+" ");
}
Console.WriteLine(" ");
string [] arr2 = new string [count];
Console.WriteLine("Второй массив");
for(int i = 0; i<arr.Length; i++)
{
    if(arr[i].Length<=3)
    {
      arr2[count-1]=arr[i];
      Console.Write(arr2[count-1] + " ");
      count--;      
    }
}