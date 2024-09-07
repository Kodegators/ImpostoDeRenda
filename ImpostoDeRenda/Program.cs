using ImpostoDeRenda.uteis;

Console.WriteLine("Sejam Bem vindos ao seu adiantador de tempo na hora de pagar seus impostos, mesmo que seja roubo.");
Console.WriteLine("0 - Sair\n1 - Fazer Imposto de Renda\n2 - Torre Hanoi O que deseja fazer?: ");
int opt;
do
{
    opt = int.Parse(Console.ReadLine());
    switch (opt)
    {
        case 0:
            opt = 0;
            break;

        case 1:
            Console.Clear();
            Console.Write("Informe sua renda => R$ ");
            double renda = double.Parse(Console.ReadLine());
            CalculadoraImpostoDeRenda imposto = new CalculadoraImpostoDeRenda();
            imposto.CalcularImposto(renda);
            Console.WriteLine($"Seu imposto será de: R$ {imposto.ValorImposto.ToString("f2")}");
            break;

        case 2:
            break;

        case 3:
            break;

    }
} while (opt != 0);