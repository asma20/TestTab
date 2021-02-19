using System;

namespace Partie4Exercice5TABEmb
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tab= new string[,] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" }, { "five", "six" } };
  

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {




                    if (j == 1)
                    {
                        Console.WriteLine(tab[i, j]);
                    }

                    else
                    {
                        Console.Write(tab[i, j]);
                    }

                }
            }




        }
    }
}
