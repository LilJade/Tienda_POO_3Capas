using System;
using Entidades;
using Negocios;

namespace Vistas
{
    class Tienda
    {
        static void Main(string[] args)
        {
            //Declaramos los objetos de las clases
            //El usuario ingresará el ID del objeto producto
            EntidadProducto producto = new EntidadProducto();
            //Luego, con la capa de negocios se consultará la capa de datos para
            //buscar el objeto con el ID solicitado y retornar
            //todos los datos del producto.
            NegociosProductos negocio = new NegociosProductos();

            //Preguntamos al usuario que producto desea comprar
            //El numero que ingrese será el ID del producto
            Console.WriteLine("¿Qué producto desea comprar?" +
                "\n1 - Café instantáneo." +
                "\n2 - Jugo de Naranja." +
                "\n3 - Salsa de Tomate." +
                "\n4 - Consomé de Pollo." +
                "\n5 - Churrito.");
            //Almacenamos la respuesta del usuario en nuestro objeto Producto
            producto.Id = int.Parse(Console.ReadLine());

            //Solicitamos a la capa de Negocios que busque nuestro producto
            //y le enviamos el id del producto que queremos
            producto = negocio.negocio_buscarProductoPorID(producto);

            //Si el producto que me devuelve es NULL, entonces
            //el id no es valido y por ende no tenemos ese producto
            if (producto == null)
            {
                Console.WriteLine("Ese producto no lo tenemos! Lo sentimos :(");
            }
            //Si el producto no es NULL, entonces mostramos toda la 
            //informacion del producto, la cual nos la devuelve la capa
            //de datos.
            else
            {
                Console.WriteLine("Datos del producto que va comprar: " +
                    "\nNombre: " + producto.Nombre + "." +
                    "\nPrecio: " + producto.Precio.ToString("00.00") + "." +
                    "\nMarca: " + producto.Marca + "." +
                    "\nExistencias: " + producto.Existencias + ".");

                //Ahora que sabemos que producto va a comprar el usuario
                //podemos preguntarle cuantos quiere y completar la venta
                Console.WriteLine("¿Cuántas unidades va comprar?");
                int cantidad = int.Parse(Console.ReadLine());

                //Mostramos cuantas unidades comprará el usuario y de que producto
                Console.WriteLine("Va a comprar " + cantidad + " unidades de " + producto.Nombre + ".");
                Console.WriteLine("Procesando...");

                //Solicitamos a la capa de negocio que nos realice la venta
                producto = negocio.venderProducto(producto, cantidad);

                //Si la venta se realiza exitosamente, mostramos cuantas
                //unidades nos quedan en existencia
                if (producto != null)
                {
                    Console.WriteLine("Ahora quedan " + producto.Existencias + " existencias de este producto.");
                }
            }
        }
    }
}
