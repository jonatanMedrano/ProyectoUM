using System;

namespace CapaDeNegocio
{
    public class Producto
    {
        private int nro;
        private String des;
        private int cant;
        private Double pu;

        static void Main(string[] args)
        {
        }


            public Producto(int n, String d, int c, Double p)
        {
            this.nro = n;
            this.des = d;
            this.cant = c;
            this.pu = p;
        }

        public Producto()
        {
            this.nro = 0;
            this.des = " ";
            this.cant = 0;
            this.pu = 0.0;
        }

        public int Nro
        {
            set { nro = value; }
            get { return this.nro; }
        }

        public String Des
        {
            set { des = value; }
            get { return this.des; }
        }

        public int Cant
        {
            set { cant = value; }
            get { return this.cant; }
        }

        public Double Pu
        {
            set { pu = value; }
            get { return this.pu; }
        }

    }
}
    

