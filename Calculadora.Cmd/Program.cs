using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Cmd
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {


            bool escolheuSair = false;
            while(!escolheuSair) //Enquanto o usuário NÃO(!) Escolher sair Exiba o MENU
            {

                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisao\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                /*
                 *  string opcaoTXT = Console.ReadLine();
                 *  int opcaoInt = int.Parse(opcaoTXT);
                 *  Menu opcao = (Menu)opcaoInt;
                 */

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case Menu.Soma:
                        Soma();
                        break;


                    case Menu.Subtracao:
                        Subtracao();
                        break;

                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;


                    case Menu.Divisao:
                        Divisao();
                        break;


                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    default:
                        Console.WriteLine("Digite um número Valido!");
                        break;


                }
                Console.Clear();

            }

            
        }
        static void Soma() 
        {
            Console.WriteLine("Somando números: ");
            Console.WriteLine("Digite um número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo número");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("A soma entre "+ a + " e " + " é de: " + resultado );
            Console.WriteLine( "Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtraindo números");
            Console.WriteLine("Digite o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("A subtração de " + a + " e " + b + " é de: "+ resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Divisao()
        {
            Console.WriteLine("Dividindo números");
            Console.WriteLine("Digite o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine("A divisão de " + a + " e " + b + " é de: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicando números");
            Console.WriteLine("Digite o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            float resultado = a * b;
            Console.WriteLine("A multiplicação entre " + a + " e " + b + " é de: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }
        static void Potencia()
        {
            Console.WriteLine("Potenciação de números");
            Console.WriteLine("Digite o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número para potência");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)Math.Pow(a, b);
            Console.WriteLine("A Potência de " + a + " elevado a  " + b + " é de: " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        }

        static void Raiz()
        {
            Console.WriteLine("A Raiz quadrada de números");
            Console.WriteLine("Digite um número");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine("A Raiz quadrada  de " + a + " é:  " + resultado);
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();

        } 
       
        }
}
