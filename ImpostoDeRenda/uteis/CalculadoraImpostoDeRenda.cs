using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda.uteis
{
    public class CalculadoraImpostoDeRenda
    {
        public static double CalcularImposto(double renda)
        {
            double imposto = 0.0;

            if (renda <= 2259.20)
            {
                imposto = 0.0;
            }
            else if (renda > 2259.20 && renda <= 2826.65)
            {
                imposto = renda * 0.075;
            }
            else if (renda > 2826.65 && renda <= 3751.05)
            {
                imposto = renda * 0.150;
            }
            else if (renda > 3751.05 && renda <= 4664.68)
            {
                imposto = renda * 0.225;
            }
            else
            {
                imposto = renda * 0.275;
            }

            return imposto;
        }
    }
}