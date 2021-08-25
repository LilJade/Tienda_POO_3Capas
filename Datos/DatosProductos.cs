using System;
using Entidades;

namespace Datos
{
    public class DatosProductos
    {
        //Estos objetos simularan nuestra base de datos
        //Tenemos una tiendita con 5 productos y
        //cada producto tiene su id, nombre, precio, marca y existencias
        EntidadProducto producto1 = new EntidadProducto(1, "Café instantáneo", 0.15, "Listo", 60);
        EntidadProducto producto2 = new EntidadProducto(2, "Jugo de Naranja", 0.45, "Del Valle", 12);
        EntidadProducto producto3 = new EntidadProducto(3, "Salsa de Tomate", 0.60, "Naturas", 30);
        EntidadProducto producto4 = new EntidadProducto(4, "Consomé de Pollo", 0.12, "Continental", 64);
        EntidadProducto producto5 = new EntidadProducto(5, "Churrito", 0.10, "Diana", 100);

        public EntidadProducto buscarProductoPorID(EntidadProducto producto) {

            //Este metodo nos devolverá los datos completos del producto
            //Para saber que producto devolver debemos obtener el id del producto
            //Dependiendo de ese id, así devolveremos el producto correspondiente
            if (producto.Id == 1)
            {
                producto = producto1;

                return producto;
            }
            else if (producto.Id == 2)
            {
                producto = producto2;

                return producto;
            }
            else if (producto.Id == 3)
            {
                producto = producto3;

                return producto;
            }
            else if (producto.Id == 4)
            {
                producto = producto4;

                return producto;
            }
            else if (producto.Id == 5)
            {
                producto = producto5;

                return producto;
            }

            //Si el id que recibimos no se encuentra entre
            //los numeros del 1 al 5, entonces devolveremos un objeto vacio
            //para dar a entender que no tenemos ese producto
            else
            {
                return null;
            }
        }

        //Para vender productos, solo necesitamos el producto a vender
        //asi como la cantidaque venderemos
        public EntidadProducto venderProducto(EntidadProducto producto, int cantidad) {
            //Para simular la venta, solo restaremos la cantidad vendida a las existencias
            //de nuestro producto
            producto.Existencias = (producto.Existencias - cantidad);

            return producto;
        }
    }
}
