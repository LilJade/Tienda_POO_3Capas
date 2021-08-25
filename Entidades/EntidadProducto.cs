using System;

namespace Entidades
{
    public class EntidadProducto
    {
        private int id;
        private string nombre;
        private double precio;
        private string marca;
        private int existencias;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Existencias { get => existencias; set => existencias = value; }

        public EntidadProducto() { }

        public EntidadProducto(int id, string nombre, double precio, string marca, int existencias)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.existencias = existencias;
        }
    }
}
