using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1parcial
{
    class Congelado_Por_agua : Producto_Congelado
    {
        public int Cantidad_de_gramos_sal { get; set; }
        public int Litros_de_agua { get; set; }
    }
    public override void Calculo_de_AGUA(Cantidad_de_gramos_sal a, Litros_de_agua g)
    {
        int TotalpAgua;
        TotalpAgua = a.Cantidad_gramos_de_sal * a.Litros_de_agua;
        Console.WriteLine("Cantidad_gramos_de_sal\t\tLitros_de_agua");
        Console.WriteLine("{0}\t\t{1}",
              a.Cantidad_gramos_de_sal, a.Litros_de_agua);
        Console.WriteLine("El calculo de los gramos de sal y litros de agua  = " + TotalpAgua);

    }

    
}
