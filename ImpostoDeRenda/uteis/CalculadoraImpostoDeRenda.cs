using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda.uteis
{
    public class CalculadoraImpostoDeRenda
    {
        public double ValorImposto;
        public double CalcularImposto(double renda)
        {
            if (renda <= 2259.20)
            {
                ValorImposto = 0.0;
            }
            else if (renda > 2259.20 && renda <= 2826.65)
            {
                ValorImposto = renda * 0.075;
            }
            else if (renda > 2826.65 && renda <= 3751.05)
            {
                ValorImposto = renda * 0.150;
            }
            else if (renda > 3751.05 && renda <= 4664.68)
            {
                ValorImposto = renda * 0.225;
            }
            else
            {
                ValorImposto = renda * 0.275;
            }

            return ValorImposto;
        }
    }
}