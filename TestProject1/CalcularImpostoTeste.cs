using ImpostoDeRenda.uteis;

namespace TestProject1
{
    [TestClass]
    public class CalcularImpostoTeste
    {
        [TestMethod]
        public void Faixa1()
        {
            double rendaBruta = 2250.00;
            double imposto;
            imposto = CalculadoraImpostoDeRenda.CalcularImposto(rendaBruta);

            Assert.AreEqual(0.0, imposto);
        }

        [TestMethod]
        public void Faixa2()
        {
            double rendaBruta = 2750.00;
            double imposto;
            imposto = CalculadoraImpostoDeRenda.CalcularImposto(rendaBruta);

            Assert.AreEqual(206.25, imposto);
        }

        [TestMethod]
        public void Faixa3()
        {
            double rendaBruta = 3250.00;
            double imposto;
            imposto = CalculadoraImpostoDeRenda.CalcularImposto(rendaBruta);

            Assert.AreEqual(487.5, imposto);
        }

        [TestMethod]
        public void Faixa4()
        {
            double rendaBruta = 4250.00;
            double imposto;
            imposto = CalculadoraImpostoDeRenda.CalcularImposto(rendaBruta);

            Assert.AreEqual(956.25, imposto);
        }

        [TestMethod]
        public void Faixa5()
        {
            double rendaBruta = 8775.40;
            double imposto;
            imposto = CalculadoraImpostoDeRenda.CalcularImposto(rendaBruta);

            Assert.AreEqual(2413.235, imposto);
        }
    }
}