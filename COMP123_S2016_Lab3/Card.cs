using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lab3
{
    class Card
    {
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++
        public int Face { get; set; }

        public string Suit { get; set; }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters face and suit
         * to instantiate a Card object
         * </summary>
         * 
         * @constructor Card 
         * @param {int} face
         * @param {string} suit
         */
        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
