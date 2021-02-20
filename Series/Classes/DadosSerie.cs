using System;
using System.Collections.Generic;
using System.Text;

namespace Series
{
    public class DadosSerie
    {
        public static void Detalhar()
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

        }
    }
}
