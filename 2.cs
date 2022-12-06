int [] massive = GetArray(0, 100);
Console.WriteLine($"[{String.Join(", ", massive)}]");

Console.WriteLine($"Упорядоченный массив: [{String.Join(", ", RigthMass(massive))}]");

int [] GetArray(int minEl, int maxEl)
{
   int [] array = new int [6];
   for(int i = 0; i<array.Length; i++)
   {
      array[i] = new Random().Next(minEl, maxEl+1);
   }
   return array;
}


int [] RigthMass(int [] array)
{
   int temp;
   for(int i =0; i<array.Length-1; i++)
   {
      for (int j =i+1; j<array.Length;j++)
      {
         if(array[j]<array[i])
         {
            temp = array[i];
            array[i] = array[j];
            array[j]=temp;
         }
      }
   }
   return array;
}