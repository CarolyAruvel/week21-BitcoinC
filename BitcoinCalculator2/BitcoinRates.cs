using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcoinCalculator2
{
    public internal class BitcoinRates
    {
        public bpi bpi { get; set; }
    }

    public class bpi
    {
        public EUR EUR { get; set; }
    }

    public class EUR
    {   
             public string code { get; set; }

             public float rate_float { get; set; }
    }
}
