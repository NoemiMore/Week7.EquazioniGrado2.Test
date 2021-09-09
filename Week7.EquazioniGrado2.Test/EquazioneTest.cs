using System;
using Week7.EquazioniGrado2.Core;
using Xunit;

namespace Week7.EquazioniGrado2.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange: predisposizione del test
            Equation equazione = new Equation();

            //ACT: chiata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 2);

            //Assert: verifica del risultato
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]);// alternativa Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato[1]);
        }

        [Fact]
        public void TestCase2()
        {
            //ARRANGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]);// altrenativa Assert.True(result[0] == 2);
            Assert.Equal(3, risultato[1]);
        }
        [Fact]
        public void TestCase3() 
        {
            //ARRANGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, 2, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato.Length == 1);
            Assert.Equal(-1, risultato[0]);// altrenativa Assert.True(result[0] == -1);            
        }

        [Fact]
        public void TestCase4() 
        {
            //ARRANGE: predisposizione del test
            Equation equazione = new Equation();
            //ACT: chiamata alla funzionalità da testare
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -3, 10);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.Null(risultato);
        }
    }
}


