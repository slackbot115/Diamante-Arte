using System;

namespace DiamanteArte.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIAMANTE GENERATOR");
            while (true)
            {
                Console.WriteLine("\nDigite um numero impar para gerar o diamante\n0 para sair");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    string teste = "";
                    string espacos = "";
                    int qtEspacos = 0;
                    if(num == 1)
                    {
                        Console.WriteLine("\n X");
                    }
                    else if (num % 2 != 0)
                    {
                        for (int i = 1; i <= num; i++)
                        {
                            if(i == 1)
                            {
                                qtEspacos = num - 1;
                                for (int j = 0; j < qtEspacos; j++)
                                {
                                    espacos += " ";
                                }
                                teste += "X";
                                Console.WriteLine(espacos + "X");
                                espacos = espacos.Substring(0, espacos.Length - 1);
                            }
                            else if(i < (1 + num) / 2)
                            {
                                teste += "XX";
                                Console.WriteLine(espacos + teste);
                                espacos = espacos.Substring(0, espacos.Length - 1);
                            }
                            else if(i == (1 + num) / 2)
                            {
                                teste += "XX";
                                Console.WriteLine(espacos + teste);
                            }
                            else if(i > (1 + num) / 2)
                            {
                                espacos += " ";
                                teste = teste.Substring(0, teste.Length - 2);
                                Console.WriteLine(espacos + teste);
                            }
                            else if(i == num)
                            {
                                espacos = "";
                                qtEspacos = num - 1;
                                for (int j = 0; j < qtEspacos; j++)
                                {
                                    espacos += " ";
                                }
                                Console.WriteLine(espacos + "X");
                            }
                        }
                        Console.WriteLine("\nAperte qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if(num == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite novamente...");
                    }
                }
                catch
                {
                    Console.WriteLine("Ocorreu um erro, tente de novo...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("\nPressione qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}
