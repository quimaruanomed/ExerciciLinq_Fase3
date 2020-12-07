using System;
using System.Linq;

namespace ExerciciLinq_FaseIII
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numFaseI = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
           
            int[] ngreader = (from n in numFaseI where n > 5 select n).ToArray(); //Consulta para buscar los valores mayores de 5 en el array numFaseI
            Console.WriteLine("Los numeros mayores de 5 son:");
            foreach (int n in ngreader) //Bucle para imprimir los valores mayores de 5
            {
                Console.WriteLine("{0,1}", n);

            }
            int[] xless = (from x in numFaseI where x < 5 select x).ToArray(); //Consulta para obtener los valores menores de 5 dentro del array numFaseI
            Console.WriteLine("Los numeros menores de 5 son: ");
            foreach (int x in xless) //Bucle para imprimir los valores menores de 5
            {
                Console.WriteLine("{0,1}", x);
            }
           
        }
    }
}
