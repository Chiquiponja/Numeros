using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10];
            double mayor = 0;
            double menor = 999;
            double promedio = 0;
           
            Console.WriteLine("INGRESE 10 NUMEROS ");
            Console.WriteLine(" ");
            for (int i = 0; i < 10; i++)

            {

                double Numero =double.Parse(Console.ReadLine());
                num[i]= Numero;
            }
            Console.WriteLine("Mostrar Numeros ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" NUMEROS " + num[i]);
            }
            Console.WriteLine("Numeros al Reves ");
            Console.WriteLine(" ");
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(" NUMEROS " + num[i] );
            }
            //Numero Mayor
            
            for (int  i = 0;  i <num.Length;  i++)
            {
                if (num[i] > mayor)
                {
                    mayor = num[i];
                }
                
            }
            Console.WriteLine("Numero Mayor : " + mayor);
            Console.WriteLine(" ");
            //Numero Menor
            for (int i = 0; i < 10; i++)
            {
                if (num[i] < menor)
                {
                    menor = num[i];
                }
                
            }
            Console.WriteLine("Numero Menor : " + menor);
            Console.WriteLine(" ");
            Console.WriteLine("Promedio ");
            Console.WriteLine(" ");
            for (int i = 0; i < num.Length; i++)
            {
                promedio += num[i];
                

            }
            Console.WriteLine(promedio/10);
            
        }
    }
}
