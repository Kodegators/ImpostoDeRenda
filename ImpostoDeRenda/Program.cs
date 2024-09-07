using ImpostoDeRenda.uteis;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Sejam Bem vindos ao seu adiantador de tempo na hora de pagar seus impostos, mesmo que seja roubo.");
Console.WriteLine("0 - Sair\n1 - Torre Hanoi:\n2 - Fazer Imposto de Renda:\nO que deseja fazer? ");
int opt;
string Final;
string TiraDisco = "0";
string ColocaDisco = "0";
List<List<int>> TorreFinal = new List<List<int>>();
List<int> TorreWin = new List<int> { 10, 8, 6, 4, 2 };
List<int> Torre1 = new List<int> { 10, 8, 6, 4, 2 };
List<int> Torre2 = new List<int> { };
List<int> Torre3 = new List<int> { };
bool InicioOuFim = true;


do
{
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 0:
            opt = 0;
            break;
        case 1:
            try
            {
                do
                {
                    EscolhaHanoi(InicioOuFim);
                    TorreFinal = TorresHanoi.MetodoConstroiTorre(TiraDisco, ColocaDisco, Torre1, Torre2, Torre3);
                    Final = TorresHanoi.TorresHanoiJogo(TorreFinal, TorreWin);
                } while (Final != "0");
                Console.WriteLine("Você venceu!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Movimento Invalido");
                goto case 1;
            }
            break;
        case 2:
            Console.Clear();
            Console.Write("Informe sua renda => R$ ");
            double renda = double.Parse(Console.ReadLine());
            CalculadoraImpostoDeRenda imposto = new CalculadoraImpostoDeRenda();
            imposto.CalcularImposto(renda);
            Console.WriteLine($"Seu imposto será de: R$ {imposto.ValorImposto.ToString("f2")}");
            break;
        case 3:
            break;

    }
} while (opt != 0);

void EscolhaHanoi(bool inicioOuFim)
{
    if (inicioOuFim)
    {
        Console.Clear();
        Console.WriteLine("Vamos começar!");
        Console.WriteLine("");
        InicioOuFim = false;
        TiraDisco = "1";
        ColocaDisco = "1";

    }
    else
    {
        Console.Write("De qual torre você deseja remover o disco?: ");
        TiraDisco = Console.ReadLine();
        Console.Write("Deseja colocar o disco em qual torre?: ");
        ColocaDisco = Console.ReadLine();
    }
}
