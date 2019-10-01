using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos1
{
    class FalsaPosicao
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

        static public int FazerFalsaPosocao()
        {
            int i = 0;
            double e;
            double test;
            double Xa, Xb, Xm;
            Console.WriteLine("Informe Xa\n");
            Xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe Xb\n");
            Xb = double.Parse(Console.ReadLine());
            Console.WriteLine("O erro\n");
            e = double.Parse(Console.ReadLine());
            if (F(Xa) * F(Xb) > 0)
            {
                Console.WriteLine("O intervalo da Funçao não ocorre Zero da Função");
                Console.ReadKey();
                return 1;
            }
            do
            {

                Xm = ((Xb * F(Xa)) - (Xa*F(Xb))) / (F(Xa) - F(Xb));
                Console.WriteLine("Xa :" + Xa + " Fa :" + F(Xa) + "  Xb + " + Xb + " Fb :" + F(Xb) + " Xm :" + Xm + " FXm:" + F(Xm) + "  interação :" + i);
                if (F(Xa) * F(Xm) < 0)
                    Xb = Xm;
                else
                    Xa = Xm;
                i++;
                test = Math.Abs(F(Xm));

            } while (test > e);
            Console.WriteLine("Xa :" + Xa + " Fa :" + F(Xa) + "  Xb + " + Xb + " Fb :" + F(Xb) + " Xm :" + Xm + " FXm:" + F(Xm) + "  interação :" + i);
            Console.ReadKey();
            return 0;



        }
    }
}
