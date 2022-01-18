using System;
using System.Collections.Generic;
using System.Linq;

namespace aula.lista
{
    /**
        Criar um menu com as opções
            1 - Adicionar um novo vagão
            2 - Exibir o último vagão
            3 - Exibir todos os vagões
            4 - Buscar por id dentro do trem
            5 - Buscar por nome dentro do trem
            6 - Buscar por peso dentro do trem
            7 - Atualizar as informações de um vagão
            8 - Excluir um vagão
            0 - Sair
    **/

    public class Menu
    {
        public static void main(ListaLigada gerenciarVagoes) 
        {
            Console.ReadLine();
            
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Adicionar um novo vagão");
            Console.WriteLine("2. Exibir o último vagão");
            Console.WriteLine("3. Exibir todos os vagões");
            Console.WriteLine("4. Buscar por id dentro do trem");
            Console.WriteLine("5. Buscar por nome dentro do trem");
            Console.WriteLine("6. Buscar por peso dentro do trem");
            Console.WriteLine("7. Atualizar as informações de um vagão");
            Console.WriteLine("8. Excluir um vagão");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");
            switch (Console.Read())
            {
                case '1':
                    AdicionarVagao(gerenciarVagoes);
                    break;
                case '2':
                    ExibirUltimoVagao(gerenciarVagoes);
                    break;
                case '3':
                    ExibirTodosVagoes(gerenciarVagoes);
                    break;
                case '4':
                    BuscarExibirPorId(gerenciarVagoes);
                    break;
                case '5':
                    BuscarExibirPorCarga(gerenciarVagoes);
                    break;
                case '6':
                    BuscarExibirPorPeso(gerenciarVagoes);
                    break;
                case '7':
                    AtualizarVagao(gerenciarVagoes);
                    break;
                case '8':
                    RemoverVagao(gerenciarVagoes);
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            main(gerenciarVagoes);  
        }

        public static void AdicionarVagao(ListaLigada gerenciarVagoes)
        {
            Console.Write("Digite o id: ");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a carga: ");
            var carga = Console.ReadLine();

            Console.Write("Digite o peso: ");
            var peso = Convert.ToInt32(Console.ReadLine());

            Vagao vagao = new Vagao() { Id = id, Carga = carga, Peso = peso };

            gerenciarVagoes.InserirVagao(vagao);

            Console.WriteLine("Vagão inserido com sucesso!");
        }

        public static void ExibirUltimoVagao(ListaLigada gerenciarVagoes)
        {
            var ultimoVagao = gerenciarVagoes.getUltimoVagao();

            gerenciarVagoes.ExibirVagao(ultimoVagao);
        }

        public static void ExibirTodosVagoes(ListaLigada gerenciarVagoes)
        {
            var vagoes = gerenciarVagoes.getVagoes();

            vagoes.ForEach(gerenciarVagoes.ExibirVagao);
        }

        public static Vagao BuscarExibirPorId(ListaLigada gerenciarVagoes)
        {
            Console.Write("Escreva o id: ");
            var id = Convert.ToInt32(Console.ReadLine());

            var vagao = gerenciarVagoes.GetById(id);
            gerenciarVagoes.ExibirVagao(vagao);

            return vagao;
        }

        public static Vagao BuscarExibirPorCarga(ListaLigada gerenciarVagoes)
        {
            Console.Write("Escreva o nome da carga: ");
            var carga = Console.ReadLine();

            var vagao = gerenciarVagoes.GetByCarga(carga);
            gerenciarVagoes.ExibirVagao(vagao);

            return vagao;
        }

        public static Vagao BuscarExibirPorPeso(ListaLigada gerenciarVagoes)
        {
            Console.WriteLine("Escreva o peso: ");
            var peso = Convert.ToInt32(Console.ReadLine());

            var vagao = gerenciarVagoes.GetByPeso(peso);
            gerenciarVagoes.ExibirVagao(vagao);

            return vagao;
        }

        public static void AtualizarVagao(ListaLigada gerenciarVagoes) {}

        public static void RemoverVagao(ListaLigada gerenciarVagoes) {}
    }
}