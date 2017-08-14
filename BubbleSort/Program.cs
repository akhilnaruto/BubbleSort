using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
  class Program
  {
    static void Main(string[] args)
    {
      //var testArray = new int[] { 1, 2, 3, 4, 5 };

      var arrayLength = int.Parse(Console.ReadLine());
      var stringArray = Console.ReadLine().Split(' ');
      int[] array = new int[arrayLength];
      for (int i = 0; i < arrayLength; i++)
      {
        array[i] = int.Parse(stringArray[i]);
      }

      var numberOfSteps = PerformBubbleSort(array);
      Console.WriteLine(numberOfSteps);
    }

    private static int PerformBubbleSort(int[] array)
    {
      var numberOfSteps = 0;
      var arrayLength = array.Length;
      for (int i = 0; i < arrayLength-1; i++)
      {
        for (int k = 0; k < arrayLength -1 -i; k++)
        {
           if(array[k] > array[k + 1])
          {
            var temp = array[k];
            array[k] = array[k + 1];
            array[k + 1] = temp;
            numberOfSteps++;
          }
        }
      }
      return numberOfSteps;
    }
  }
}
