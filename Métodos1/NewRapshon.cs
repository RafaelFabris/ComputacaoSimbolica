﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos1
{
    class NewRapshon
    {
        static public double F(double x)
        {
            double y;
            double pow, const1, const2;
            pow = 1 - (Math.Pow(1 + x, -48));
            const1 = 4754.28;
            const2 = 50000;
            y = ((const1 * pow) / x) - const2;
            return y;
        }
        static public double G(double x)
        {
            double y;
            double pow, const1, const2;
            pow = Math.Pow(1 + x, -49);
            const1 = 4754.28;
            const2 = 228205.44;
            y = ((const2 * x * pow) - const1 + (const1 * pow)) / Math.Pow(x , 2);
            return y;
        }
        static public int FazerNew()
        {
            double erro = 0.1, x;
            Console.WriteLine("Escreva X: \n");
            x = double.Parse(Console.ReadLine());

            while (Math.Abs(F(x)) > erro)
            {
                Console.WriteLine("Valor de X;" + x);
                Console.WriteLine("  Funcao de x: " + F(x));
                x = x - (F(x)/ G(x));
            }

            Console.WriteLine("Valor de x: " + x + " \n Funcao de X: " + F(x));
            Console.ReadKey();
            return 0;
        }

    }
}
