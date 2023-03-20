using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocio;
using CapaDeDatos;

namespace CapaDeUsuario
{
    class Program
    {
        static void Main(string[] args)
        {

            Producto p1;
            Persistencia datos;
            int nroPro, cant;
            String descripcion;
            Double precio;

            Console.WriteLine(" *** ALTA DE PRODUCTO ***\n ");

            Console.WriteLine("Nro Producto: ");
            nroPro = int.Parse(Console.ReadLine());

            Console.WriteLine("Descripcion: ");
            descripcion = Console.ReadLine();

            Console.WriteLine("Cantidad: ");
            cant = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio Unitario");
            precio = double.Parse(Console.ReadLine());

            //Guardo el producto
            p1 = new Producto(nroPro, descripcion, cant, precio);
            //Grabo el nuevo producto en el archivo
            datos = new Persistencia();
            datos.grabarProducto(p1);

            Console.WriteLine("Se agrego el producto a la base\n ");
            Console.WriteLine("*** Lista de Productos *** \n");
            datos.leerProducto();
            Console.WriteLine("-------------------------------------------\n");
            Console.Read();

        }
    }
}
