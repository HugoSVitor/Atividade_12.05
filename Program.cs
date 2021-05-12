using System;

namespace Atividade_12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomePassageiro = new string[5];
            string[] origemVoo = new string[5];
            string[] destinoVoo = new string[5];
            double[] dataVoo = new double[5];
            int c = 0;

            Console.WriteLine("Insira a senha para acessar o sistema: ");
            int senhaEntrar = int.Parse(Console.ReadLine());

            if (senhaEntrar == 123456)
            {
                Console.WriteLine("Senha ok!");

                int sair = 0;
                int opcaoMenu;
                do
                {
                    Console.WriteLine("O que você deseja fazer?");
                    Console.WriteLine("Cadastrar passagem = 1    Listar passagens = 2    Sair= 0");
                    opcaoMenu = int.Parse(Console.ReadLine());

                    switch (opcaoMenu)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu a opção 1 (Cadastrar passagem)!");
                            
                            string respostaCadastrar;
                            string respostaS = "s";
                            
                            do
                            {
                                Console.WriteLine("Insira o nome do passageiro");
                                nomePassageiro[c] = Console.ReadLine();

                                Console.WriteLine("Insira a origem do voo: ");
                                origemVoo[c] = Console.ReadLine();

                                Console.WriteLine("Insira o destino do voo: ");
                                destinoVoo[c] = Console.ReadLine();

                                Console.WriteLine("Insira a data do voo (dia_mês_ano): ");
                                dataVoo[c] = double.Parse(Console.ReadLine());

                                Console.WriteLine("Você deseja cadastrar outra passagem? (S/N)");
                                Console.WriteLine($"Número máximo de cadastros é de 5! Você ja possui {(c+1)}");
                                respostaCadastrar = Console.ReadLine().ToLower();
                                
                                c++;
                            } while (respostaS == respostaCadastrar);

                        break;

                        case 2:
                            Console.WriteLine("Você escolheu a opção 2 (Listar passagens)!");

                            for (var i = 0; i < c; i++)
                            {
                                Console.WriteLine($"Nome = {nomePassageiro[i]} - Origem do Voo = {origemVoo[i]} - Destino do Voo = {destinoVoo[i]} - Data do Voo = {dataVoo[i]}");
                            }

                            break;
                        case 0:
                            Console.WriteLine("Você escolheu a opção 0 (Sair)!");
                            break;
                        default:
                            break;
                    }

                } while (sair != opcaoMenu);
            }
            else
            {
                Console.WriteLine("Senha inválida!");
            }
        }
    }
}
