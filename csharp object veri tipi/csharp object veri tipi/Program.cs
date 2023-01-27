using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_object_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object veri tipi tüm veri tiplerini gören ve tutan veri tipidir. (fazla yer kapladığı için kullanılmaz.)
            object isim = "Okan";
            object sayı = "55";
            object ondalık = "5.55";
            object dogru = "true";
            Console.WriteLine(isim);
            Console.WriteLine(sayı);
            Console.WriteLine(ondalık);
            Console.WriteLine(dogru);
            Console.ReadLine();
        }
    }
}
