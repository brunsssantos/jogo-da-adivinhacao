namespace JogodaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Jogo da Adivinhação");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Escolha o nível de dificuldade: ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Médio (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Digite sua escolha: ");
            string escolhaDificuldade = Console.ReadLine();

            int totalTentativas = 0;

            if (escolhaDificuldade == "1")
                totalTentativas = 10;

            else if (escolhaDificuldade == "2")
                totalTentativas = 5;
            else
                totalTentativas = 3;


            Random geradorDeNumeros = new Random();
            int numeroSecreto = geradorDeNumeros.Next(1, 21);

            for(int tentativa = 1; tentativa <= totalTentativas; tentativa++)
            {
                Console.Clear();

                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Tentativa {tentativa} de {totalTentativas}");
                Console.WriteLine("---------------------------------");

                Console.Write("Digite um número (de 1 a 20) para chutar: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Parabéns, você acertou!");
                    Console.WriteLine("---------------------------------");
                    break;
                }

                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("O número digitado foi maior que o número secreto!");
                    Console.WriteLine("-------------------------------------------------");
                }

                else
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("O número digitado foi menor que o número secreto!");
                    Console.WriteLine("-------------------------------------------------");
                }

                Console.WriteLine("Digite ENTER para continuar");
                Console.ReadLine();
            }

            Console.ReadLine();





        }
    }
}
