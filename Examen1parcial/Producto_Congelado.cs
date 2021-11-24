using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1parcial
{
    class Producto_Congelado
    {
//propiedades 
    public int Nombre_de_produto { get; set; }
    public int tipo_congelacion { get; set; }
    }
    
    public void Mostrar_Productos_congelados(List<Producto_Congelado> Lista)
    {
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("Nombre_de_produto\t\tipo_congelacion");
       
        {
            Console.WriteLine("{0}\t\t{1}",
                   Producto_Congelado.Nombre_de_produto, Producto_Congelado.tipo_congelacion );
        }

    }
}