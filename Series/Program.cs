using System;

namespace Series
{
    class Program : DadosSerie
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        AdcionarSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
                Console.WriteLine(' ');
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                var status = serie.retornaStatus();
                if (!status)
                {
                    Console.WriteLine("Status: DÍSPONIVEL");
                }
                else
                {
                    Console.WriteLine("Status: REMOVIDO");
                }
                Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
            }
        }

        private static void AdcionarSeries()
        {
            Console.WriteLine("Adcionar Séries");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Classificacao)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
            }
            Console.Write("Digite a Classificacao entre as opções acima: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Criterios)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Criterios), i));
            }
            Console.Write("Digite o(s) Critérios entre as opções acima: ");
            int entradaCriterios = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        classificacao: (Classificacao)entradaClassificacao,
                                        criterio: (Criterios)entradaCriterios);

            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Classificacao)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Classificacao), i));
            }
            Console.Write("Digite a Classificacao entre as opções acima: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Criterios)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Criterios), i));
            }
            Console.Write("Digite o(s) Critérios entre as opções acima: ");
            int entradaCriterios = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o a Descrição da Série: ");

            string entradaDescricao = Console.ReadLine();
            Serie atualizaSerie = new Serie(id: indiceSerie,
                                      genero: (Genero)entradaGenero,
                                      titulo: entradaTitulo,
                                      ano: entradaAno,
                                      descricao: entradaDescricao,
                                      classificacao: (Classificacao)entradaClassificacao,
                                      criterio: (Criterios)entradaCriterios);
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            string opcaoUsuario2 = ObterOpcaoUsuario2();

            while(opcaoUsuario2.ToUpper() != "X")
            {
                switch (opcaoUsuario2)
                {
                    case "1":
                        Console.WriteLine("Excluindo Série...");
                        repositorio.Exclui(indiceSerie);
                        Console.WriteLine("Série Removida");
                        return;
                    case "2":
                        return;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
            }

        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a sua disposição!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Adcionar Nova Série");
            Console.WriteLine("3- Atualizar Série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar Série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");

            String opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static string ObterOpcaoUsuario2()
        {
            Console.WriteLine();
            Console.WriteLine("Quer mesmo excluir essa série? ");
            Console.WriteLine("1- COMFIRMAR");
            Console.WriteLine("2- CANCELAR");
            Console.WriteLine("X- SAIR");

            String opcaoUsuario2 = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario2; 
        }

    }
}
