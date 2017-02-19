using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoUno.Domain
{
    public class CartaCoringa : Carta
    {
        public override bool Aceita(Carta outra)
        {
            return true;
        }
    }
}
