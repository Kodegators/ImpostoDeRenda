using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda.uteis
{
    public class TorresHanoi
    {
        public static string TorresHanoiJogo(List<List<int>> TorreFinal, List<int> TorreWin)
        {

            List<int> torre1 = new List<int>(TorreFinal[0]);
            List<int> torre2 = new List<int>(TorreFinal[1]);
            List<int> torre3 = new List<int>(TorreFinal[2]);
            var disc = '-';
            int maxWidth = 10;
            Console.WriteLine("  1             2            3");


            for (int i = 5; i >= 0; i--)
            {
                if (torre1.Count == 0)
                {
                        int t1 = torre1.ElementAtOrDefault(i);
                        int t2 = torre2.ElementAtOrDefault(i);
                        int t3 = torre3.ElementAtOrDefault(i);
                        string torre1Discs = new string(' ', (maxWidth - t1) / 2) + new string(disc, t1) + new string(' ', (maxWidth - t1 + 1) / 2);
                        string torre2Discs = new string(' ', (maxWidth - t2) / 2) + new string(disc, t2) + new string(' ', (maxWidth - t2 + 1) / 2);
                        string torre3Discs = new string(' ', (maxWidth - t3) / 2) + new string(disc, t3) + new string(' ', (maxWidth - t3 + 1) / 2);
                        Console.WriteLine($"{torre1Discs}   {torre2Discs}   {torre3Discs}");
                   
                }
                else
                {
                    int t1 = torre1.ElementAtOrDefault(i);
                    int t2 = torre2.ElementAtOrDefault(i);
                    int t3 = torre3.ElementAtOrDefault(i);
                    string torre1Discs = new string(' ', (maxWidth - t1) / 2) + new string(disc, t1) + new string(' ', (maxWidth - t1 + 1) / 2);
                    string torre2Discs = new string(' ', (maxWidth - t2) / 2) + new string(disc, t2) + new string(' ', (maxWidth - t2 + 1) / 2);
                    string torre3Discs = new string(' ', (maxWidth - t3) / 2) + new string(disc, t3) + new string(' ', (maxWidth - t3 + 1) / 2);
                    Console.WriteLine($"{torre1Discs}   {torre2Discs}   {torre3Discs}");
                }
            }
            if (torre2.SequenceEqual(TorreWin) || torre3.SequenceEqual(TorreWin))
                return "0";
            return "1";
        }

        public static List<List<int>> MetodoConstroiTorre(string tira, string coloca, List<int> torre1, List<int> torre2, List<int> torre3)
        {
            
            List<List<int>> TorreFinal = new List<List<int>>();
            int Remvd = 0;
            switch (tira)
            {
                case "1":
                    Remvd = torre1[torre1.Count - 1];
                    torre1.Remove(torre1[torre1.Count - 1]);
                    break;
                case "2":
                    Remvd = torre2[torre2.Count - 1];
                    torre2.Remove(torre2[torre2.Count - 1]);
                    break;
                case "3":
                    Remvd = torre3[torre3.Count - 1];
                    torre3.Remove(torre3[torre3.Count - 1]);
                    break;
                default:
                    throw new ArithmeticException("Movimento Invalido");
            }

            switch (coloca)
            {
                case "1":
                    if (torre1.Count == 0)
                    {
                        torre1.Add(Remvd);
                    }
                    else if (torre1[torre1.Count - 1] > Remvd)
                    {
                        torre1.Add(Remvd);
                    }
                    else
                    {
                        if (tira == "2")
                        {
                            goto case "2";
                        }
                        else
                        {
                            goto case "3";
                        }
                        throw new ArithmeticException("Movimento Invalido");
                    }
                    break;
                case "2":
                    if (torre2.Count == 0)
                    {
                        torre2.Add(Remvd);
                    }
                    else if (torre2[torre2.Count - 1] > Remvd)
                    {
                        torre2.Add(Remvd);
                    }
                    else
                    {
                        if (tira == "1")
                        {
                            goto case "1";
                        }
                        else
                        {
                            goto case "3";
                        }
                        throw new ArithmeticException("Movimento Invalido");
                    }
                    break;
                case "3":
                    if (torre3.Count == 0)
                    {
                        torre3.Add(Remvd);
                    }
                    else if (torre3[torre3.Count - 1] > Remvd)
                    {
                        torre3.Add(Remvd);
                    }
                    else
                    {
                        if (tira == "1")
                        {
                            goto case "1";
                        }
                        else
                        {
                            goto case "2";
                        }
                        throw new ArithmeticException("Movimento Invalido");
                    }
                    break;
                default:
                    if (tira == "1")
                        torre1.Add(Remvd);
                    else if (tira == "2")
                    {
                        torre2.Add(Remvd);
                    }
                    else if (tira == "3")
                    {
                        torre3.Add(Remvd);
                    }
                    throw new ArithmeticException("Movimento Invalido");
                        
            }
            TorreFinal.Add(torre1);
            TorreFinal.Add(torre2);
            TorreFinal.Add(torre3);
            return TorreFinal;
        }   
    }
}



