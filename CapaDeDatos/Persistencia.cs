using System.IO;
using System;
using CapaDeNegocio;

namespace CapaDeDatos
{
    public class Persistencia
    {
        private string file;


        static void Main(string[] args)
        {
        }

        public Persistencia()
        {
            this.file = " ";
        }

        public void grabarProducto(Producto p)
        {
            StreamWriter file = new StreamWriter("C:\\productos.txt", append: true);
            file.WriteLine(p.Nro + "\t" + p.Des + "\t" + p.Cant + "\t" + p.Pu + "\n");
            file.Close();
        }

        public void leerProducto()
        {
            String line;
            try
            {
                StreamReader file = new StreamReader("C:\\productos.txt");
                //Read the first line of text
                line = file.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = file.ReadLine();
                }
                //close the file
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
