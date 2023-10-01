using System;
using System.Threading;
using System.Timers;

namespace Lista_6
{
    /**
    * *1) Considere que um corredor profissional precisa de um programa para gerenciar os tempos (em horas) das maratonas que ele participou. O programa deve apresentar o seguinte menu para o usuário:
    *Menu:
    * 1) Inserir um tempo no início da lista
    * 2) Inserir um tempo no final da lista
    * 3) Inserir um tempo numa posição específica da lista
    * 4) Remover o primeiro tempo da lista (Imprimir o tempo removido)
    * 5) Remover o último tempo da lista (Imprimir o tempo removido)
    * 6) Remover um tempo de uma posição específica na lista (O usuário deve informar a posição do tempo a ser removido. Imprimir o tempo removido)
    * 7) Remover um tempo específico da lista (O usuário deve informar o tempo a ser removido) Adicione na classe Lista um método para remover um elemento específico: int RemoverItem(int x)
    * 8) Pesquisar quantas vezes um determinado tempo consta na lista (O usuário deve informar o tempo a ser pesquisado) Adicione na classe Lista um método que retorne o número de elementos com o valor especificado: int Contar(int x)
    * 9) Mostrar todos os tempos da lista
    * 10) Encerrar o programa 
    * 
    * O programa deverá ler a opção informada pelo usuário e executar a operação selecionada.
    * Em seguida o programa deverá apresentar novamente o menu, depois ler e executar a operação selecionada.
    * Esse processo deverá ser repetido até que o usuário digite a opção de encerrar o programa
    */
    class main
    {
        static Lista list = new Lista(50);
        private static System.Timers.Timer aTimer;

        static int menu()
        {
            Console.WriteLine("1)Inserir um tempo no início da lista "+
                            "\n2)Inserir um tempo no final da lista" +
                            "\n3)Inserir um tempo numa posição específica da lista" +
                            "\n4)Remover o primeiro tempo da lista" +
                            "\n5)Remover o último tempo da lista" +
                            "\n6)Remover um tempo de uma posição específica" +
                            "\n7)Remover um tempo específico da lista" +
                            "\n8)Pesquisar quantas vezes um determinado tempo consta na lista" +
                            "\n9)Mostrar todos os tempos da lista " +
                            "\n10)Encerrar o programa"
            );

            Console.Write("\n\nOpção: ");

            return int.Parse(Console.ReadLine());
        }
     

        static void Main(string[] args)
        {
            int opcao = -1, tempo;

            do
            {
                opcao = menu();

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.Write("Tempo: ");
                        list.insereNoInicio(int.Parse(Console.ReadLine()));
                        Console.Clear();
                        Console.WriteLine("Valor inserido com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 2:
                        Console.Write("Tempo: ");
                        list.insereNoFinal(int.Parse(Console.ReadLine()));
                        Console.Clear();
                        Console.WriteLine("Valor inserido com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 3:
                        Console.Write("Tempo: ");
                        tempo = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Posição: ");
                        int posicao = int.Parse(Console.ReadLine());
                        list.inserirPosicaoEspecifica(tempo,posicao);
                        Console.WriteLine($"Valor inserido na posição {posicao} com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 4:
                        tempo = list.removePrimeiraPosicao();
                        Console.WriteLine($"Tempo {tempo} removido com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 5:
                        tempo = list.removeUltimaPosicao();
                        Console.WriteLine($"Tempo {tempo} removido com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 6:
                        Console.Write("Posição: ");
                        posicao = int.Parse(Console.ReadLine());
                        tempo = list.removePosicaoEspecifica(posicao);
                        Console.WriteLine($"Tempo {tempo} removido da posição {posicao} com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 7:
                        Console.Write("Informe o tempo que deseja remover: ");
                        tempo = int.Parse(Console.ReadLine());
                        posicao = list.buscaPosicao(tempo);
                        list.removePosicaoEspecifica(posicao);
                        Console.WriteLine($"Tempo {tempo} removido da posição {posicao} com sucesso!");
                        Thread.Sleep(1500);
                        break;
                    case 8:
                        Console.Write("Informe o tempo desejado: ");
                        tempo = int.Parse(Console.ReadLine());
                        int evidencias = list.contaEvidencia(tempo);
                        Console.WriteLine($"Tempo {tempo} aparece {evidencias} vezes na lista!");
                        Thread.Sleep(1500);
                        break;
                    case 9:
                        list.exibeListaToda();
                        Console.WriteLine("\nPressione qualquer tecla para sair...");
                        break;
                    case 10:
                        Console.WriteLine("Obrigado, volte sempre!");
                        Thread.Sleep(3000);
                        opcao = -1;
                        break;
                }

                Console.Clear();
            } while (opcao != -1);

        }
    }
}
