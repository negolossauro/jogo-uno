using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JogoUno.Domain.Tests
{
    [TestClass]
    public class CartaTest
    {
        [TestMethod]
        public void Aceita_CartaCorIgualValorDiferente_True()
        {
            Carta carta1 = Carta.CriarCarta(5, CorCarta.Azul);
            Carta carta2 = Carta.CriarCarta(9, CorCarta.Azul);
            bool aceitou = carta1.Aceita(carta2);

            Assert.AreEqual(true, aceitou);
        }

        [TestMethod]
        public void Aceita_CartaValorIgualCorDiferente_True()
        {
            Carta carta1 = Carta.CriarCarta(5, CorCarta.Azul);
            Carta carta2 = Carta.CriarCarta(5, CorCarta.Verde);
            bool aceitou = carta1.Aceita(carta2);

            Assert.AreEqual(true, aceitou);
        }

        [TestMethod]
        public void Aceita_CartaCorDiferenteValorDiferente_False()
        {
            Carta carta1 = Carta.CriarCarta(5, CorCarta.Verde);
            Carta carta2 = Carta.CriarCarta(9, CorCarta.Azul);
            bool aceitou = carta1.Aceita(carta2);

            Assert.AreEqual(false, aceitou);
        }

        [TestMethod]
        public void Aceita_Coringa_True()
        {
            Carta c = Carta.CriarCarta(1, CorCarta.Amarelo);
            CartaCoringa coringa = new CartaCoringa();
            bool aceitou = coringa.Aceita(c);

            Assert.AreEqual(true, aceitou);
        }
    }
}
