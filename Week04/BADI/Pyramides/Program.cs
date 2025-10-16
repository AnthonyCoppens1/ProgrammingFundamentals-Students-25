using System;

namespace Pyramides
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
      1.
      *
      * *
      * * *
      * * * *

      2.
      * * * *
      * * *
      * *
      *

      3.
            *
          * *
        * * *
      * * * *

      4.
      * * * *
        * * *
          * *
            *
      
      */


      //1
      Console.WriteLine("PYRAMIDE 1");
      for (int i = 1; i <= 4; i++)
      {
        for (int j = 0; j < i; j++)
        {
          Console.Write("* ");
        }
        Console.WriteLine();
      }


      //2
      Console.WriteLine("\nPyramide 2");
      for (int i = 0; i < 4; i++)
      {
        for (int j = 4; j > i; j--)
        {
          Console.Write("* ");
        }
        Console.WriteLine();
      }

      //pyramide 3
      Console.WriteLine("\nPyramide 3");
      for (int i = 1; i <= 4; i++)
      {
        for (int j = 4; j > i; j--)
        {
          Console.Write("  ");
        }
        for (int k = 0; k < i; k++)
        {
          Console.Write("* ");
        }
        Console.WriteLine();
      }

      //pyramide 4
      Console.WriteLine("\nPyramide 4");
      for (int i = 1; i <= 4; i++)
      {
        for (int j = 1; j < i; j++)
        {
          Console.Write("  ");
        }
        for (int k = 4; k >= i; k--)
        {
          Console.Write("* ");
        }
        Console.WriteLine();
      }
            
            
    }
  }
}