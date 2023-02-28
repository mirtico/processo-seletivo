using System;

namespace processo_seletivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO 02
            //Console.Write("Informe um número: ");
            //int numero = int.Parse(Console.ReadLine());

            //int a = 0, b = 1, c = 1;

            //while (c < numero)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;
            //}

            //if (c == numero)
            //{
            //    Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
            //}
            //else
            //{
            //    Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
            //}

            //Console.Readkey();

            //EXERCICIO 03
            //    double[] faturamentoDiario = new double[] { 22174.1664, 24537.6698, 26139.6134, 0, 0 , 26742.6612, 0 , 42889.2258, 46251.174, 11191.4722, 
            //        0, 0, 3847.4823, 373.7838, 2659.7563, 48924.2448,  18419.2614, 0,0 ,35240.1826, 43829.1667, 18235.6852, 4355.0662,13327.1025,0,0,25681.8318, 1718.1221, 13220.495,  8414.61};

            //    double maiorFaturamento = 0;
            //    double menorFaturamento = double.MaxValue;
            //    double somaFaturamento = 0;
            //    double numeroDiasFaturamentoMaiorMedia = 0;

            //    for (int i = 0; i < faturamentoDiario.Length; i++)
            //    {
            //        if (faturamentoDiario[i] < menorFaturamento && faturamentoDiario[i] != 0)
            //        {
            //            menorFaturamento = faturamentoDiario[i];
            //        }
            //    }
            //    if (menorFaturamento == int.MaxValue)
            //    {
            //        Console.WriteLine("Não houve faturamento em nenhum dia do mês, excluindo valores iguais a zero.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("O menor valor de faturamento diário, excluindo valores iguais a zero, foi: " + menorFaturamento);
            //    }

            //    for (int i = 0; i < faturamentoDiario.Length; i++)
            //    {
            //        if (faturamentoDiario[i] > maiorFaturamento && faturamentoDiario[i] != 0)
            //        {
            //            maiorFaturamento = faturamentoDiario[i];
            //        }
            //    }

            //    if (maiorFaturamento == 0)
            //    {
            //        Console.WriteLine("Não houve faturamento em nenhum dia do mês, excluindo valores iguais a zero.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("O maior valor de faturamento diário, excluindo valores iguais a zero, foi: " + maiorFaturamento);
            //    }

            //    for (int i = 0; i < faturamentoDiario.Length; i++)
            //    {
            //        if (faturamentoDiario[i] != 0)
            //        {
            //            somaFaturamento += faturamentoDiario[i];
            //        }
            //    }

            //    double mediaMensal = (double)somaFaturamento / (faturamentoDiario.Length - Array.IndexOf(faturamentoDiario, 0));

            //    for (int i = 0; i < faturamentoDiario.Length; i++)
            //    {
            //        if (faturamentoDiario[i] > mediaMensal && faturamentoDiario[i] != 0)
            //        {
            //            numeroDiasFaturamentoMaiorMedia++;
            //        }
            //    }

            //    Console.WriteLine("O número de dias no mês em que o valor de faturamento diário foi superior à média mensal, excluindo valores iguais a zero, foi: " + numeroDiasFaturamentoMaiorMedia);
            //    Console.Readkey();

            //EXERCICIO 04
            
            //double sp = 67836.43;
            //double rj = 36678.66;
            //double mg = 29229.88;
            //double es = 27165.48;
            //double outros = 19849.53;

            
            //double total = sp + rj + mg + es + outros;

            
            //double percentual_sp = (sp / total) * 100;
            //double percentual_rj = (rj / total) * 100;
            //double percentual_mg = (mg / total) * 100;
            //double percentual_es = (es / total) * 100;
            //double percentual_outros = (outros / total) * 100;

           
            //Console.WriteLine("Percentual de representação do faturamento mensal por estado:");
            //Console.WriteLine($"SP: {percentual_sp:F2}%");
            //Console.WriteLine($"RJ: {percentual_rj:F2}%");
            //Console.WriteLine($"MG: {percentual_mg:F2}%");
            //Console.WriteLine($"ES: {percentual_es:F2}%");
            //Console.WriteLine($"Outros: {percentual_outros:F2}%");

            //Console.ReadKey();


            // EXERCICIO 05
            //string str = "exemplo de string"; 

            //char[] charArray = str.ToCharArray();


            //int i = 0;
            //int j = charArray.Length - 1;
            //while (i < j)
            //{
            //    char temp = charArray[i];
            //    charArray[i] = charArray[j];
            //    charArray[j] = temp;
            //    i++;
            //    j--;
            //}


            //string reversedStr = new string(charArray);


            //Console.WriteLine("String Original: {0}", str);
            //Console.WriteLine("String Invertida: {0}", reversedStr);

            //Console.ReadKey();
        }
    }
}
