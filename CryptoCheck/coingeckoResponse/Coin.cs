using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;

namespace CryptoCheck.coingeckoResponse
{
    public class Coin
    {
        public int market_cap_rank { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string symbol { get; set; }
        public double current_price { get; set; }
        public double price_change_percentage_24h { get; set; }
        public double market_cap_change_24h { get; set; }
        public double market_cap { get; set; }
    }       
}
        