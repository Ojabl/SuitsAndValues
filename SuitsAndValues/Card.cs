using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuitsAndValues
{
    class Card
    {
        public Suits Suit { get; set; }

        public Values Value { get; set; }

        public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(Values value, Suits suit)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }
}
