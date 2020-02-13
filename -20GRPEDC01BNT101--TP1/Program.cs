using Addition;
using Division;
using Multiplication;
using Subtration;
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
                Console.WriteLine("\t1 - Soma");
                Console.WriteLine("\t2 - Subração");
                Console.WriteLine("\t3 - Multiplicação");
                Console.WriteLine("\t4 - Divisão");
                Console.Write("Sua opção é ? ");

                string opp = Console.ReadLine();


                try
                {
                    if (opp == "1")
                    {
                        Console.WriteLine("Você usou a class Addtion");
                        result = Add.Operartion(cleanNum1, cleanNum2, opp);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resultou num erro.\n");
                        }
                        else Console.WriteLine("O resultado da operação é : {0:0.##}\n", result);
                    }

                    if (opp == "2")
                    {
                        Console.WriteLine("Você usou a class Subtration");
                        result = Sub.Operation(cleanNum1, cleanNum2, opp);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resultou num erro.\n");
                        }
                        else Console.WriteLine("O resultado da operação é : {0:0.##}\n", result);
                    }

                    if (opp == "3")
                    {
                        Console.WriteLine("Você selecionou a class Division");
                        result = Mut.Operation(cleanNum1, cleanNum2, opp);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resulto num erro.\n");
                        }
                        else Console.WriteLine("O resultado da operação é : {0:0.##}\n", result);
                    }
                    
                    if (opp == "4")
                    {
                        Console.WriteLine("Você selecionou a class Division");
                        result = Div.Operation(cleanNum1, cleanNum2, opp);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Esta operação resulto num erro.\n");
                        }
                        else Console.WriteLine("O resultado da operação é : {0:0.##}\n", result);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh Não! uma exceção ocorreu na operação.\n - Detalhes: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("Digite 's' e logo em seguida, pressione Enter para fechar a aplicação, ou digite qualquer tecla, e pressione Enter para continuar: ");
                if (Console.ReadLine() == "s") fimAplicacao = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
 }

