using System;
using Entidades;
using Datos;

namespace Negocios
{
    public class NegociosProductos
    {
        //Con este objeto haremos las consultas/peticiones a la capa de datos
        DatosProductos datos = new DatosProductos();

        //Este metodo nos permite validar que al buscar un objeto por ID
        //el ID sea un numero entre 1 y 5, para evitar errores
        public EntidadProducto negocio_buscarProductoPorID(EntidadProducto producto) {

            //Validamos que el numero del ID esté entre 1 y 5
            if (producto.Id < 1 || producto.Id > 5)
            {
                //Si no se cumple, retornamos un null para mostrar el error
                return null;
            }
            else
            {
                //Si todo está correcto ejecutamos el metodo para buscar el producto
                //en la capa de datos. El resultado que nos devuelva la capa de 
                //datos lo almacenaremos en la misma variable, para que se rellenen
                //los demas datos que nos faltan
                producto = datos.buscarProductoPorID(producto);

                //Si el producto resulta estar vacio, quiere decir que no se encontró
                //ningun producto con ese id
                if (producto == null)
                {
                    return null;
                }
                //En el caso contrario, se retornará el objeto con todos 
                //los datos del producto en cuestion
                else
                {
                    return producto;
                }
            }
        }

        //Este metodo nos simulará la compra que realizara el usuario
        //y nos imprimirá en pantalla una pequeña facturita
        public EntidadProducto venderProducto(EntidadProducto producto, int cantidad) {

            //Validamos que el usuario no compre más de las unidades que tenemos
            if (cantidad > producto.Existencias)
            {
                Console.WriteLine("Lo sentimos! No puedes comprar más de " + producto.Existencias + " unidades.");
                return null;
            }
            else
            {
                //Solicitamos a la capa de datos que nos realice la venta del producto
                producto = datos.venderProducto(producto, cantidad);
                //Imprimimos la factura
                Console.WriteLine("Se vendieron " + cantidad + " unidades de " + producto.Nombre + "." +
                "\nTotal: $" + TotalVenta(producto.Precio, cantidad).ToString("00.00"));

                return producto;
            }
        }

        //Este metodo nos permite calcular el total de la venta
        public double TotalVenta(double precio, int cantidad) {
            double total;
            total = precio * cantidad;

            return total;
        }
    }
}
