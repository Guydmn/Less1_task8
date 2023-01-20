// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= a) 
{
int x = count % 2;
   {
    if (x == 0)
       {
        Console.Write(count);
       } 
   }
 count = count + 1;
}