using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobsBagels.Main
{
    public class Basket
    {

        public List<String> Bagels { get; set; } = new List<String>();
        public int BasketSize { get; set; } = 5; //Max amount of bagels

        public void AddBagel(string bagel)
        {
            Bagels.Add(bagel);
        }

        public void RemoveBagel(string bagel)
        {
            Bagels.Remove(bagel);
        }

    }
}
