using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var tpm = TaxPayerManager.Instance;

            var tmp2 = TaxPayerManager.Instance;

            Console.WriteLine(tmp2 == tpm);
            Console.Read();
        }
    }
}
