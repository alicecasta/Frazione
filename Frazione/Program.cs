using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Frazione frazione = new Frazione(4,6);
            Console.WriteLine(frazione.ToString());
            Console.ReadLine();
        }
    }
}
