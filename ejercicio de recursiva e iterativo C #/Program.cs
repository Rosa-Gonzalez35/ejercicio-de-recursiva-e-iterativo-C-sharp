﻿using System;
using System.Collections.Generic;
using System;
using System.Text;
namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, RESUL;
            string linea;
            Console.Write("digite un numero: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            I = 1;
            while ((I<= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} ={2}", NUM, I, RESUL);
                I = I + 1;
            }
            Console.Write("pulse una tecla: "); Console.ReadLine();
        }
    }
}

