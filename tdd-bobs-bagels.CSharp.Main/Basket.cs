using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobsBagels.Main
{
    public class Basket
    {
        public List<String> bagels = new List<String>();

        public void AddBagel(string bagel)
        {
            bagels.Add(bagel);
        }

        public void RemoveBagel(string bagel)
        {
            bagels.Remove(bagel);
        }
    }
}
