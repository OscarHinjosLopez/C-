using System;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {   
            Random rand = new Random();
            string? nombreProducto = null;
            int eleccionMenu = 0;
            int cantidad = 0;
            int idProducto = 0;
            int indiceProductoModificar = -1; 
            double precio = 0;
            bool salirPrograma = false;
            List<string> listaProductos = new List<string>();
            while (!salirPrograma) {
                Console.WriteLine("1 - Ver inventario\n2 - Añadir un nuevo producto\n3 - Modificar un producto existente\n4 - Eliminar un producto\n5 - Salir ");
                if(!int.TryParse(Console.ReadLine() , out eleccionMenu) || eleccionMenu < 1 || eleccionMenu > 5)
                {
                    Console.WriteLine("No ha seleccionado una opcion valida");
                    continue;
                }

                switch (eleccionMenu)
                {
                    case 1:
                        string[] arrayProductos = listaProductos.ToArray();
                        if(arrayProductos.Length == 0 )
                        {
                            Console.WriteLine("No hay productos en la lista");
                            break;
                        }

                        for (int i = 0; i < arrayProductos.Length; i+= 4)
                        {
                            Console.WriteLine($"Id: {arrayProductos[i]} - Producto: {arrayProductos[i+1]} - Cantidad: {arrayProductos[i+2]} - Precio: {arrayProductos[i+3]}");
                        }
                        break;
                    case 2:

                        Console.Write("Ingrese un producto : ");
                        nombreProducto = Console.ReadLine().Trim();
                        
                        if(nombreProducto.Length == 0)
                        {
                            Console.WriteLine("No ha escrito ningun producto.");
                            break ;
                        }

                        Console.Write("Ingrese una cantidad del producto: ");
                        if(!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 1){
                            Console.WriteLine("No ha escogido una cantidad valida");
                            break;
                        }
                        Console.Write("Ingrese el precio del producto: ");
                        if (!double.TryParse(Console.ReadLine(), out precio) || precio < 0)
                        {
                            Console.WriteLine("No ha escogido un  producto valido");
                        }

                        listaProductos.Add(rand.Next(1, 1000000001).ToString());
                        listaProductos.Add(nombreProducto);
                        listaProductos.Add(cantidad.ToString());
                        listaProductos.Add(precio.ToString());

                        break;
                    case 3:
                        
                        int eleccionModificar = 0;
                        
                        Console.WriteLine("Seleccione el ID del producto que desea modificar");
                        if(!int.TryParse(Console.ReadLine(), out idProducto) || idProducto < 0 || !listaProductos.Contains(idProducto.ToString()) )
                        {
                            Console.WriteLine("No seleccionaste un id valido");
                            break;
                        }

                        for (int i = 0; i < listaProductos.Count ; i+= 4)
                        {
                            if (listaProductos[i] == idProducto.ToString()){
                                indiceProductoModificar = i;
                                break;
                            }
                        }

                        if(indiceProductoModificar == -1)
                        {
                            Console.WriteLine("No se encontró un producto con el ID especificado.");
                            break;
                        }

                        // El producto fue encontrado, ahora puedes modificarlo
                        Console.WriteLine("¿Qué deseas modificar?");
                        Console.WriteLine("1 - Nombre");
                        Console.WriteLine("2 - Cantidad");
                        Console.WriteLine("3 - Precio");
                        Console.WriteLine("4 - Todo");
                        Console.WriteLine("5 - Salir");

                        if (!int.TryParse(Console.ReadLine(), out eleccionModificar) || eleccionModificar < 1 || eleccionModificar > 5)
                        {
                            Console.WriteLine("No ha seleccionado una opción válida");
                            break;
                        }

                        switch (eleccionModificar)
                        {
                            case 1:
                                Console.Write("Ingrese el nuevo nombre del producto: ");
                                listaProductos[indiceProductoModificar + 1] = Console.ReadLine().Trim();
                                break;
                            case 2:
                                Console.WriteLine("Ingrese la nueva cantidad del producto: ");
                                if(!int.TryParse(Console.ReadLine(), out int nuevaCantidad) || nuevaCantidad < 0)
                                {
                                    Console.WriteLine("No ha ingresado una cantidad válida.");
                                    break;
                                }
                                listaProductos[indiceProductoModificar + 2] = nuevaCantidad.ToString();
                                break;
                            case 3:
                                Console.Write("Ingrese el nuevo precio del producto: ");
                                if(!double.TryParse(Console.ReadLine(), out double nuevoPrecio) || nuevoPrecio < 0)
                                {
                                    Console.WriteLine("No ha ingresado un precio válido.");
                                    break;
                                }
                                listaProductos[indiceProductoModificar + 3] = nuevoPrecio.ToString();
                                break;
                            case 4:
                                Console.Write("Ingrese el nuevo nombre del producto: ");
                                listaProductos[indiceProductoModificar + 1] = Console.ReadLine().Trim();

                                Console.Write("Ingrese la nueva cantidad del producto: ");
                                if (!int.TryParse(Console.ReadLine(), out nuevaCantidad) || nuevaCantidad < 0)
                                {
                                    Console.WriteLine("No ha ingresado una cantidad válida.");
                                    break;
                                }
                                listaProductos[indiceProductoModificar + 2] = nuevaCantidad.ToString();

                                Console.Write("Ingrese el nuevo precio del producto: ");
                                if (!double.TryParse(Console.ReadLine(), out nuevoPrecio) || nuevoPrecio < 0)
                                {
                                    Console.WriteLine("No ha ingresado un precio válido.");
                                    break;
                                }
                                listaProductos[indiceProductoModificar + 3] = nuevoPrecio.ToString();
                                break;
                            case 5:
                                break;
                        }       

                        break;
                    case 4:

                        Console.WriteLine("Seleccione el Id del producto");
                        if(!int.TryParse(Console.ReadLine(), out idProducto) || idProducto < 0 || !listaProductos.Contains(idProducto.ToString()))
                        {
                            Console.WriteLine("No seleccionaste un id valido");
                            break;
                        }

                        for (int i = 0; i < listaProductos.Count; i+= 4)
                        {
                            if (listaProductos[i] == idProducto.ToString())
                                indiceProductoModificar = i;
                                break;
                        }

                        // Verificar si se encontró el producto
                        if (indiceProductoModificar == -1)
                        {
                            Console.WriteLine("No se encontró un producto con el ID especificado.");
                            break;
                        }

                        listaProductos.RemoveAt(indiceProductoModificar);
                        listaProductos.RemoveAt(indiceProductoModificar);
                        listaProductos.RemoveAt(indiceProductoModificar);
                        listaProductos.RemoveAt(indiceProductoModificar);
                        Console.WriteLine("Producto eliminado correctamente.");
                        break;
                    case 5:
                        Console.WriteLine("Hasta pronto");
                        salirPrograma = true;
                        break ;
                }
            }
            
        }
    }
}