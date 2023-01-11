using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberofwords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um texto: ");
            var texto = Console.ReadLine();

            var words = texto.Split(' ');
            var totalWords = new List<string>();   

            foreach (string word in words)
            {

                totalWords.Add(word);
            }
            Console.WriteLine(totalWords.Count);

        }
    }
}
