using System;

public class Estatistica
{
    public double calculaMediaAritmetica( double n1
                                         ,double n2
                                         ,double n3
                                         ,double n4
                                         ,double n5 )
    {
        return ((n1 + n2 + n3 + n4 + n5) / 5);
    }

    public double calculaMediaPonderada( double n1
                                        ,double n2
                                        ,double n3
                                        ,double n4
                                        ,double n5
                                        ,double p1
                                        ,double p2
                                        ,double p3
                                        ,double p4
                                        ,double p5 )
    {
         return ( ( (n1*p1) + (n2*p2) + (n3*p3) + (n4*p4) + (n5*p5) ) / ( p1 + p2 + p3 + p4 + p5 ) );
    }

    public double calculaMediaHarmonica( double n1
                                        ,double n2
                                        ,double n3
                                        ,double n4
                                        ,double n5 )
    { 
         return ( ( (1/n1) + (1/n2) + (1/n3) + (1/n4) + (1/n5) ) / 5 );
    }

    public double calculaMediaGeometrica( double n1
                                         ,double n2
                                         ,double n3
                                         ,double n4
                                         ,double n5 )
    {
        return (Math.Pow((n1 * n2 * n3 * n4 * n5), 5 ) );
    }

}