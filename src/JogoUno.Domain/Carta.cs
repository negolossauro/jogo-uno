using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoUno.Domain
{
    public class Carta
    {
        public CorCarta Cor;

        public int Valor { get; private set; }

        public void ProcessarCarta()
        {

        }

        public virtual bool Aceita(Carta outra)
        {
            if (outra.Cor == this.Cor || outra.Valor == this.Valor)
            {
                return true;
            }
            return false;
        }

        public static Carta CriarCarta(int valor, CorCarta cor)
        {
            Carta carta = new Carta();
            carta.Valor = valor;
            carta.Cor = cor;
            return carta;
        }

        public static Carta CriarCuringa()
        {
            return new CartaCoringa();
        }

        public static Carta CriarCartaMaisQuatro()
        {
            return new CartaMaisQuatro();
        }

        public static Carta CriarCartaMaisDois()
        {
            return new CartaMaisDois();
        }

        public static Carta CriarCartaReversa()
        {
            return new CartaReversa();
        }

        public static Carta CriarCartaBloqueio()
        {
            return new CartaBloqueio();
        }
        
        public static List<Carta> CriarBaralho()
        {
            // TODO: Criar Baralho
            return null;
        }       
    }
}
