using System;

namespace Calculadora {
    internal class Program {
        static void Main(string[] args) {

            double PriNum, SegNum, Result;
            int Operacao;

            Console.WriteLine("\nCalculadora\n");

            Console.WriteLine("\nDigite o primeiro número: ");
            PriNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            SegNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha uma operação:\n1 - Soma.\n2 - Subtração.\n3 - Multiplicação.\n4 - Divisão.");
            Operacao = Convert.ToInt32(Console.ReadLine());


            switch (Operacao) {
                case 1:
                    Result = PriNum + SegNum;
                    Console.WriteLine("Resultado: " + Result);
                    break;
                case 2:
                    Result = PriNum - SegNum;
                    Console.WriteLine("Resultado: " + Result);
                    break;
                case 3:
                    Result = PriNum * SegNum;
                    Console.WriteLine("Resultado: " + Result);
                    break;
                case 4:
                    Result = PriNum / SegNum;
                    Console.WriteLine("\nResultado: " + Result + ".\n");
                    break;
                default:
                    Console.WriteLine("escolha uma opção válida.");
                    break;
            }
        }
    }
}
