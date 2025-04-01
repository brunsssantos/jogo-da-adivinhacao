namespace JogodaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalTentativas = DefinirTentativas(ExibirMenu());
            int numeroSecreto = GerarNumeroSecreto();
            Jogar(totalTentativas, numeroSecreto);

        }   

        static int DefinirTentativas(string escolhaDificuldade)
            {
                int totalTentativas = 0;

                if (escolhaDificuldade == "1")
                    return 10;

                else if (escolhaDificuldade == "2")
                    return 5;
            else
                return 3;
            }

        static int GerarNumeroSecreto()
        {
            Random geradorDeNumeros = new Random();
            int numeroSecreto = geradorDeNumeros.Next(1, 21);
            return numeroSecreto;
        }

        static void Jogar(int totalTentativas, int numeroSecreto)
            {
                int[] numerosDigitados = new int[totalTentativas];
                int contadorHistorico = 0;

                for (int tentativa = 1; tentativa <= totalTentativas; tentativa++)
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"Tentativa {tentativa} de {totalTentativas}");
                    Console.WriteLine("---------------------------------");

                    if (contadorHistorico > 0)
                    {
                        Console.WriteLine("Números digitados:");
                        for (int contador = 0; contador < contadorHistorico; contador++)
                        {
                            Console.Write(numerosDigitados[contador] + " ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------");

                    }

                    Console.Write("Digite um número (de 1 a 20) para chutar: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());
                    numerosDigitados[contadorHistorico] = numeroDigitado;
                    contadorHistorico++;

                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine("---------------------------------");
                        Console.ReadLine();
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
       
            }


        static string ExibirMenu()
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

            string EscolhaDificuldade = Console.ReadLine();

            return EscolhaDificuldade;
        }

    }
}
