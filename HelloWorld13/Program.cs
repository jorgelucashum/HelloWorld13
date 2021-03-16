using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld13
{
    class Program
    {
        // properties: São definições de métodos encapsulados, porém expondo uma sintaxe similiar à de atributos e não de métodos.
        static void Main(string[] args)
        {
            Produto p1 = new Produto("TV", 500.00, 10);

            p1.Nome = "TV 4K"; // usando  o método 'set' em forma de propertie.

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);



            Console.ReadLine();
        }
    }
}
