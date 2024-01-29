using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escolha da operação que o usuário deseja fazer
            
            Console.WriteLine("Qual operação deseja realizar:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subitração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");


            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            //Operações e Métodos para realizar o cálculo e logo após o resultado
            
            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }


                case 2:
                    {
                        resultado = Subitracao(num1, num2);
                        break;
                    }


                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }


                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Número inválido, digite outro numero.");
                    break;
            }

            Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, resultado);


            Console.ReadLine();
        }








        public static int Adicao(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Subitracao(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Divisao(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }

}
