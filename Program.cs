using System.Globalization;

namespace EstruturaIfElse
{
    class program
    {
        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("Bom dia");

            // o bloco só vai ser executado se a condição for verdadeira.

            //estrutura simples
            if (x < 5)
            {
                Console.WriteLine("Boa tarde");
            }


            Console.WriteLine("Boa noite");



            Console.WriteLine("Entre com um numero inteiro:");

            int a = int.Parse(Console.ReadLine());

            //utilizar o % mod 2 que vai pegar o resto da divisão, sendo assim se o resto da divisão de a for par, imprimir a palavra par, caso contrario impar.

            // estrutura condicional composta.

            if (a % 2 == 0)
            {
                Console.WriteLine("Par!");

            }
            else
            {
                Console.WriteLine("Impar!");

            }

            // estrutura de encadeamento

            //estou chamando diversos operadores condinais para verificar as horas e conforme a hora inserida pelo usuario, ira retornar uma mensagem de bom dia, boa tarde e boa noite.


            Console.WriteLine("Qual a hora atual:");

            int horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");

            }
            // O se não garante a exclusão da primeira condição.
            else if (horas < 18)
            {
                Console.WriteLine("Boa tarde!");

            }
            else
            {
                Console.WriteLine("Boa noite!");


            }








        }
    }
}