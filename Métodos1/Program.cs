using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos1
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {
            String sair;
            
            sair = "s";
            do
            {
                Console.WriteLine("Selecione Método :\n 1-- Método de Bissecção\n 2-- Método de Falsa Posição\n 3-- Método MIL\n 4-- Método de NewRapshon");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Bisseccao.FazerBisseccao();
                            break;
                        }
                    case 2:
                        {
                            FalsaPosicao.FazerFalsaPosocao();
                            break;
                        }
                    case 3:
                        {
                            Mil.FazerMil();
                            break;
                        }
                    case 4:
                        {
                            NewRapshon.FazerNew();
                            break;
                        }
                    default:
                        break;
                }

                Console.WriteLine("Deseja sair ? s/n");
                sair = Console.ReadLine();

            } while (sair == "n");

        }
    }
}
