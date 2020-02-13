using Addition;
using System;

namespace _20GRPEDC01BNT101__TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fimAplicacao = false;
            Console.WriteLine("Calculadora em C#\r");
            Console.WriteLine("------------------------\n");

            while (!fimAplicacao)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Por favor, digite um número e pressione Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Valor digitado não é um número. Por favor, digite um valor do tipo número: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Novamente, digite outro número e pressione Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Valor digitado não é um número. Por favor, digite um valor do tipo número: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Agora, escolha qual operação deseja realizar: ");
                Console.WriteLine("\ta - Soma");
                Console.WriteLine("\tb - Subração");
                Console.WriteLine("\tc - Multiplicação");
                Console.WriteLine("\td - Divisão");
                Console.Write("Sua opção é ? ");

                string opp = Console.ReadLine();


                try
                {
                    if (opp == "a")
                    {
                        result = Add.Operartion(cleanNum1, cleanNum2, opp);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resulto num erro.\n");
                        }
                        else Console.WriteLine("O resultado da operação é : {0:0.##}\n", result);
                    }

                    if (opp == "b") 
                    {
                        Console.WriteLine("Você selecionou B");
                        //result = Sub.Operation(cleanNum1, cleanNum2, opp);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resulto num erro.\n");
                        }
                        else Console.WriteLine("O resultado da operação é : {0:0.##}\n", result);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh Não! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("Digite 'n' e logo em seguida, pressione Enter para fechar a aplicação, ou digite qualquer tecla, e pressione Enter para continuar: ");
                if (Console.ReadLine() == "n") fimAplicacao = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
 }

