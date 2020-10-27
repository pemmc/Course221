using System;
using System.Collections.Generic;
using System.Globalization;

using Course221Delegate.Entities;

namespace Course221Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            string specifier = "C";

            CultureInfo cultureIdioma;

            cultureIdioma = CultureInfo.CreateSpecificCulture("pt-BR");

            List<Products> list = new List<Products>();
            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 350.50));
            list.Add(new Products("HD Case", 80.90));

            //PREDICATO...
            //É uma função que recebe um objeto e retorna um bool
            list.RemoveAll(p => p.Price >= 100.0);

            //funciona tb
            //list.RemoveAll(p => p.Price >= 100.0);

            Console.WriteLine("--- LISTA DE PRODUTOS COM VALORES ACIMA DE 100.0---");
            foreach (Products p in list)
            {
                Console.WriteLine( "Nome: "
                    + p.Name
                    + ", Preço R"
                    + p.Price.ToString(specifier, cultureIdioma)
                    );
                 
            }
        }
    }
}


