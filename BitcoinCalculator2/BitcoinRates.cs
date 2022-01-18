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
    public class BPI
    {
        public USD USD { get; set; }
    }

    public class USD
    {
        public string code { get; set; }

        public float rate_float { get; set; }
    }

    public class BPi
    {
        public GPB GPB { get; set; }
    }
    public class GPB
    {
        public string code { get; set; }

        public float rate_float { get; set; }
    }
    
}
