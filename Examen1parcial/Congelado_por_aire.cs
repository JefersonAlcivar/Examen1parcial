using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1parcial
{
    class Congelado_por_aire : Producto_Congelado
    {
        //Propiedades
        public int Porcoentaje_de_oxigeno { get; set; }
        public int Porcoentaje_de_carbono { get; set; }
        public int Porcoentaje_de_Nitrogeno { get; set; }

    }
    public override void Calculo_de_AI(Porcoentaje_de_oxigeno a, Porcoentaje_de_carbono g, Porcoentaje_de_Nitrogeno s)
    {
        int Totalpor;
        Totalpor = a.Porcoentaje_de_oxigeno * a.Porcoentaje_de_carbono* a.Porcoentaje_de_Nitrogeno;
        Console.WriteLine("Porcoentaje_de_oxigeno\t\tPorcoentaje_de_carbono\t\tPorcoentaje_de_Nitrogeno");
        Console.WriteLine("{0}\t\t{1}\t\t{2}",
              a.Porcoentaje_de_oxigeno, a.Porcoentaje_de_carbono, a.Porcoentaje_de_Nitrogeno);
        Console.WriteLine("El calculo de los porcentaje es  = " + Totalpor);

    }
}

