using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FajlkezelesSzamok
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] tomb = new int[50];
      int i = 0;
      #region Fájlbeolvasás
      // 1. feladat adatok beolvasása
      StreamReader file = new StreamReader("szamok.txt");

      while (!file.EndOfStream)
      {
        //Console.WriteLine(file.ReadLine());
        string sor = file.ReadLine(); // !!!szöveg
        // szöveg átalakítása számmá -> Convert
        tomb[i] = Convert.ToInt32(sor);
        i++;
      }


      file.Close(); 
      #endregion

      #region Minimum és Maximum keresés
      int min = tomb[0], max = tomb[0];

      for (i = 1; i < tomb.Length; i++)
      {
        if (min > tomb[i])
        {
          min = tomb[i];
        }

        if (max < tomb[i])
        {
          max = tomb[i];
        }

      }

      Console.WriteLine("Minimum: " + min);
      Console.WriteLine("Maximum: " + max); 
      #endregion

      Console.ReadKey();
    }
  }
}
