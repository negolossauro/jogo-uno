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

        public static Carta CriarCartaMaisDois(CorCarta cor)
        {
            Carta carta = new CartaMaisDois();
            carta.Cor = cor;
            return carta;
        }

        public static Carta CriarCartaReversa(CorCarta cor)
        {
            Carta carta = new CartaReversa();
            carta.Cor = cor;
            return carta;
        }

        public static Carta CriarCartaBloqueio(CorCarta cor)
        {
            Carta carta = new CartaBloqueio();
            carta.Cor = cor;
            return carta;
        }
        
        public static List<Carta> CriarBaralho()
        {
            List<Carta> baralho = new List<Carta>();

            baralho.Add(CriarCarta(0, CorCarta.Azul));
            baralho.Add(CriarCarta(0, CorCarta.Vermelho));
            baralho.Add(CriarCarta(0, CorCarta.Amarelo));
            baralho.Add(CriarCarta(0, CorCarta.Verde));

            baralho.Add(CriarCarta(1, CorCarta.Amarelo));
            baralho.Add(CriarCarta(1, CorCarta.Azul));
            baralho.Add(CriarCarta(1, CorCarta.Vermelho));
            baralho.Add(CriarCarta(1, CorCarta.Verde));

            baralho.Add(CriarCarta(2, CorCarta.Amarelo));
            baralho.Add(CriarCarta(2, CorCarta.Azul));
            baralho.Add(CriarCarta(2, CorCarta.Vermelho));
            baralho.Add(CriarCarta(2, CorCarta.Verde));

            baralho.Add(CriarCarta(3, CorCarta.Amarelo));
            baralho.Add(CriarCarta(3, CorCarta.Azul));
            baralho.Add(CriarCarta(3, CorCarta.Vermelho));
            baralho.Add(CriarCarta(3, CorCarta.Verde));

            baralho.Add(CriarCarta(4, CorCarta.Amarelo));
            baralho.Add(CriarCarta(4, CorCarta.Azul));
            baralho.Add(CriarCarta(4, CorCarta.Vermelho));
            baralho.Add(CriarCarta(4, CorCarta.Verde));

            baralho.Add(CriarCarta(5, CorCarta.Amarelo));
            baralho.Add(CriarCarta(5, CorCarta.Azul));
            baralho.Add(CriarCarta(5, CorCarta.Vermelho));
            baralho.Add(CriarCarta(5, CorCarta.Verde));

            baralho.Add(CriarCarta(6, CorCarta.Amarelo));
            baralho.Add(CriarCarta(6, CorCarta.Azul));
            baralho.Add(CriarCarta(6, CorCarta.Vermelho));
            baralho.Add(CriarCarta(6, CorCarta.Verde));

            baralho.Add(CriarCarta(7, CorCarta.Amarelo));
            baralho.Add(CriarCarta(7, CorCarta.Azul));
            baralho.Add(CriarCarta(7, CorCarta.Vermelho));
            baralho.Add(CriarCarta(7, CorCarta.Verde));

            baralho.Add(CriarCarta(8, CorCarta.Amarelo));
            baralho.Add(CriarCarta(8, CorCarta.Azul));
            baralho.Add(CriarCarta(8, CorCarta.Vermelho));   
            baralho.Add(CriarCarta(8, CorCarta.Verde));

            baralho.Add(CriarCarta(9, CorCarta.Amarelo));
            baralho.Add(CriarCarta(9, CorCarta.Azul));
            baralho.Add(CriarCarta(9, CorCarta.Vermelho));
            baralho.Add(CriarCarta(9, CorCarta.Verde));

            baralho.Add(CriarCartaBloqueio(CorCarta.Amarelo));
            baralho.Add(CriarCartaBloqueio(CorCarta.Azul));
            baralho.Add(CriarCartaBloqueio(CorCarta.Vermelho));
            baralho.Add(CriarCartaBloqueio(CorCarta.Verde));

            baralho.Add(CriarCartaMaisDois(CorCarta.Amarelo));
            baralho.Add(CriarCartaMaisDois(CorCarta.Azul));
            baralho.Add(CriarCartaMaisDois(CorCarta.Vermelho));
            baralho.Add(CriarCartaMaisDois(CorCarta.Verde));

            baralho.Add(CriarCartaReversa(CorCarta.Amarelo));
            baralho.Add(CriarCartaReversa(CorCarta.Azul));
            baralho.Add(CriarCartaReversa(CorCarta.Vermelho));
            baralho.Add(CriarCartaReversa(CorCarta.Verde));

            baralho.Add(CriarCuringa());

            baralho.Add(CriarCartaMaisQuatro());


            return baralho;
        }       
    }
}
