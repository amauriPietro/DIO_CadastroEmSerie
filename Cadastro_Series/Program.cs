// See https://aka.ms/new-console-template for more information

namespace Cadastro_Series
{
    class Program
    {
        static SerieRepositorio repo = new SerieRepositorio();
        public static void Main(string[] args)
        {
            while (true)
            {
                var opt = ObterOpcao();
                if (opt.ToUpper() == "X")
                    break;
                switch (opt)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        AdicionarSerie();
                        break;
                    case "3":
                        AtualizaSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    default:
                        Console.WriteLine("Comando não reconhecido.");
                        break;
                }
            }
        }

        private static string ObterOpcao()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - listar series");
            Console.WriteLine("2 - adicionar serie");
            Console.WriteLine("3 - atualizar serie");
            Console.WriteLine("4 - excluir series");
            Console.WriteLine("5 - visualizar serie");
            Console.WriteLine("X - sair");
            string opt = Console.ReadLine();
            return opt;
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Lista de series: ");
            foreach (var item in repo.lista)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void VisualizarSerie()
        {
            Console.Write("ID a ser visualizado: ");
            int RequiredID = int.Parse(Console.ReadLine());
            Console.WriteLine(repo.RetornaPorID(RequiredID).ToString());
        }

        private static void AdicionarSerie()
        {
            repo.Insere(LerSerie());
        }

        private static Serie LerSerie()
        {
            Console.WriteLine("Genero: ");
            int gen = int.Parse(Console.ReadLine());
            Console.WriteLine("Titulo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Descricao: ");
            string desc = Console.ReadLine();
            Console.WriteLine("Ano de lancamento: ");
            int ano = int.Parse(Console.ReadLine());
            Serie serie = new Serie(repo.proximoID(), (Genero)gen, titulo, desc, ano);
            return serie;
        }

        private static void AtualizaSerie()
        {
            Console.WriteLine("Id a ser atualizado: ");
            int RequiredID = int.Parse(Console.ReadLine());
            repo.Atualiza(RequiredID, LerSerie());
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Id a ser excluido: ");
            int RequiredID = int.Parse(Console.ReadLine());
            repo.Exclui(RequiredID);
        }
    }
};

