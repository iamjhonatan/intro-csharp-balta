using System;
using System.Collections.Generic;
using System.Linq;

namespace intro_csharp_balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            var cidades = new List<string>
            {
                "São Paulo",
                "São Bernardo",
                "Curitiba"
            };

            var filtradas = cidades.Where(x => x.StartsWith("C"));

            foreach (var cidade in filtradas)
            {
                Console.WriteLine(cidade);
            }

            // Dictionary = Map
            var capitais = new Dictionary<string, string>();

            capitais.Add("RN", "Natal");
            capitais.Add("PR", "Curitiba");

            Console.WriteLine(capitais["PR"]);


            // Linq
            var estados = capitais.Keys.Where(x => x.StartsWith("R"));

            foreach (var uf in estados)
            {
                Console.WriteLine(uf);
            }

            Console.Read();
        }
    }
}
