using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoUno.Domain
{
    public class Jogo
    {
        public List<Jogador> Jogadores { get; set; }
        public Jogador JogadorAtual { get; set; }
        public List<Carta> Monte { get; set; }
        public List<Carta> Mercado { get; set; }
        public OperacaoJogo OperacaoAtual { get; set; }

        public void EmbaralharCartas()
        {
            
        }
    }
}
