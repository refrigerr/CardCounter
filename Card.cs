using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCounter
{

    internal class Card
    {
        private readonly int number;
        private readonly string type;
        public Card(int number, string type)
        {
            this.number = number;
            this.type = type;
        }
        public int getNumber() { return number; }
        public string getType()  { return type; } 
    
    }
    
}
