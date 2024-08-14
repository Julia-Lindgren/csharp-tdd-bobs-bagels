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
        public int BasketSize { get; set; } = 2; //Max amount of bagels
        public bool BasketIsFull { get; set; } = false;

        public void AddBagel(string bagel)
        {
            if (!BasketIsFull)
                Bagels.Add(bagel);
                if (Bagels.Count() == BasketSize)
                    BasketIsFull = true;
        }

        public void RemoveBagel(string bagel)
        {
            Bagels.Remove(bagel);
        }

    }
}
