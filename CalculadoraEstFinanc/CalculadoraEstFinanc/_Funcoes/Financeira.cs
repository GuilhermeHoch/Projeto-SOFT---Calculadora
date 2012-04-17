
using System;

public class Financeira
{
    //
    // --
    //
    public double calculaJurosSimples(double capital
                                     ,double taxa
                                     ,double tempo)
    {
        /* 
         * Juros Simples
         * 
         * J = C * i * t
         * 
         * J = juros
         * C = capital
         * i = taxa de juros
         * t = tempo de aplicação (mês, bimestre, trimestre, semestre, ano...)
        */

        return (capital * taxa * tempo);
    }

    public double calculaJurosCompostos(double capital
                                       ,double taxa
                                       ,double tempo)
    {
        /*
         * M = C * (1 + i)t
         * M: montante
         * C: capital
         * i: taxa de juros
         * t: tempo de aplicação 
         */

        return (capital * Math.Pow((1 + taxa), tempo));
    }

    public double calculaDescontoRacionalSimples(double capital
                                                ,double taxa
                                                ,double tempo)
    {
        /*
         * Desconto Simples Racional (por dentro): 
         *     O cálculo deste desconto funciona análogo ao cálculo dos juros simples, 
         * substituindo-se o Capital P na fórmula de juros simples pelo Valor Atual A do título.
         *     O cálculo do desconto racional é feito sobre o Valor Atual do título.
         */

        return (capital / (1 + (taxa * tempo))); 
    }

    public double calculaDescontoComercialSimples(double capital
                                                 ,double taxa
                                                 ,double tempo)
    {
        /*
         * Desconto Simples Comercial (por fora): 
         *     O cálculo deste desconto é análogo ao cálculo dos juros simples, substituindo-se 
         * o Capital P na fórmula de juros simples pelo Valor Nominal N do título.
         */
        return (capital * taxa * tempo);
    }

    public double calculaTaxaNominalJuros(double taxa
                                         ,double tempo)
    {
        /*
         * in = i * n
         */

        return ((taxa * tempo) * 100);
    }

    public double calculaTaxaEfetivaJuros(double taxa
                                         ,double tempo)
    {
        /*
         * ie = ( 1 + i )n - 1
         */

        return ((Math.Pow((1 + taxa), tempo)) * 100);
    } 
   
}