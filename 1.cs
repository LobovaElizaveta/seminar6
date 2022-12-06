int [] massive = {1, -7, 567, 89, 223};
int count = 0;
foreach(int el in massive)
{
   if (el>0)
   {
      count++;
   }
}
Console.WriteLine($"Чисел больше нуля: {count}");