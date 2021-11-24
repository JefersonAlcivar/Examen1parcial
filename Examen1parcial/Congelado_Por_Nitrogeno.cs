using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1parcial
{
    class Congelado_Por_Nitrogeno : Producto_Congelado
    {
        //Propiedades
        public int Tiempo_de_expo_de_nitrogeno { get; set; }
        public int Peso_del_Producto { get; set; }
    }

    public override void Calculo_de_AGUA(Tiempo_de_expo_de_nitrogeno a, Peso_del_Producto g)
    {
        int TotalpAgua;
        TotalpAgua = a.Tiempo_de_expo_de_nitrogeno * a.Peso_del_Producto;
        Console.WriteLine("Tiempo_de_expo_de_nitrogeno\t\tPeso_del_Producto");
        Console.WriteLine("{0}\t\t{1}",
              a.Tiempo_de_expo_de_nitrogeno, a.Peso_del_Producto);
        Console.WriteLine("El calculo de los gramos de sal y litros de agua  = " + TotalpAgua);

    }
}
