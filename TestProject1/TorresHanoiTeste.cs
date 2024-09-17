using ImpostoDeRenda.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class TorresHanoiTeste
    {
        [TestMethod]
        public void TorresHanoiWin()
        {
            var torreInicial = new List<List<int>>()
            {
                new List<int>{ 3, 2, 1 },
                new List<int>(),
                new List<int>()
            };

            var torreEsperada = new List<int> { 3, 2, 1 };

            var torreFinal = TorresHanoi.MetodoConstroiTorre("1", "3", torreInicial[0], torreInicial[1], torreInicial[2]);
            torreFinal = TorresHanoi.MetodoConstroiTorre("1", "2", torreFinal[0], torreFinal[1], torreFinal[2]);
            torreFinal = TorresHanoi.MetodoConstroiTorre("3", "2", torreFinal[0], torreFinal[1], torreFinal[2]);
            torreFinal = TorresHanoi.MetodoConstroiTorre("1", "3", torreFinal[0], torreFinal[1], torreFinal[2]);
            torreFinal = TorresHanoi.MetodoConstroiTorre("2", "1", torreFinal[0], torreFinal[1], torreFinal[2]);
            torreFinal = TorresHanoi.MetodoConstroiTorre("2", "3", torreFinal[0], torreFinal[1], torreFinal[2]);
            torreFinal = TorresHanoi.MetodoConstroiTorre("1", "3", torreFinal[0], torreFinal[1], torreFinal[2]);

            var resultado = TorresHanoi.TorresHanoiJogo(torreFinal, torreEsperada);

            Assert.AreEqual("0", resultado);
        }
    }
}