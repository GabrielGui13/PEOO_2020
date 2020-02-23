using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do mês:");
            string mes = Console.ReadLine();
            string tri = "0";

            switch (mes) {
                case "1": mes = "Janeiro"; tri = "Primeiro"; break;
                case "2": mes = "Fevereiro"; tri = "Primeiro"; break;
                case "3": mes = "Março"; tri = "Primeiro"; break;
                case "4": mes = "Abril"; tri = "Segundo"; break;
                case "5": mes = "Maio"; tri = "Segundo"; break;
                case "6": mes = "Junho"; tri = "Segundo"; break;
                case "7": mes = "Julho"; tri = "Terceiro"; break;
                case "8": mes = "Agosto"; tri = "Terceiro"; break;
                case "9": mes = "Setembro"; tri = "Terceiro"; break;
                case "10": mes = "Outubro"; tri = "Quarto"; break;
                case "11": mes = "Novembro"; tri = "Quarto"; break;
                case "12": mes = "Dezembro"; tri = "Quarto"; break;
            }
            Console.WriteLine($"O mês de {mes} é do {tri} trimestre do ano");
            Console.ReadKey();
        }
    }
}
