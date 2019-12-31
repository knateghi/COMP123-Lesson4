using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    public class Card
    {
        //public properties========================
        public int Face { get; set; }
        public string Suit { get; set; }

        public Card(int face,string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
