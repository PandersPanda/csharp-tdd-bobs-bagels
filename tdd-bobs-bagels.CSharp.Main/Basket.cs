using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public int capacity = 5;
        public int productCount { get { return _products.Count; } }
        private Dictionary<string, int> _products = new Dictionary<string, int>(); 
        public Basket() { }

        public bool Add(string product, int value)
        {
            if (capacity <= productCount) { return false; }

            _products.Add(product, value);
            return true;
        }

        public bool Remove(string product)
        {
            if (_products.ContainsKey(product))
            {
                _products.Remove(product);
                return true;
            }
            return false;
        }

        public int ChangeCapacity(int c)
        {
            capacity = c;
            return capacity;
        }
    }
}
