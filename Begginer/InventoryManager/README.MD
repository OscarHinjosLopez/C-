# InventoryManager

Este es un programa de consola simple para la gestión de inventario. Permite a los usuarios ver el inventario, agregar nuevos productos, modificar productos existentes, eliminar productos y salir del programa.

## Características

- Ver el inventario de productos.
- Añadir un nuevo producto.
- Modificar un producto existente.
- Eliminar un producto.
- Salir del programa.

## Requisitos

- .NET SDK

## Cómo usar

1. Clona el repositorio o descarga los archivos.

2. Navega al directorio del proyecto y ejecuta el siguiente comando para compilar el programa:

    ```bash
    dotnet build
    ```

3. Ejecuta el programa con el siguiente comando:

    ```bash
    dotnet run
    ```

## Menú de opciones

1. **Ver inventario**: Muestra una lista de todos los productos en el inventario.
2. **Añadir un nuevo producto**: Permite agregar un nuevo producto al inventario ingresando su nombre, cantidad y precio.
3. **Modificar un producto existente**: Permite modificar el nombre, cantidad y precio de un producto existente seleccionando su ID.
4. **Eliminar un producto**: Permite eliminar un producto del inventario seleccionando su ID.
5. **Salir**: Sale del programa.

## Ejemplo de uso

```text
1 - Ver inventario
2 - Añadir un nuevo producto
3 - Modificar un producto existente
4 - Eliminar un producto
5 - Salir
```

### Ver inventario

```text
No hay productos en la lista
```

### Añadir un nuevo producto

```text
Ingrese un producto: Manzanas
Ingrese una cantidad del producto: 10
Ingrese el precio del producto: 0.5
```

### Modificar un producto existente

```text
Seleccione el ID del producto que desea modificar: 123
¿Qué deseas modificar?
1 - Nombre
2 - Cantidad
3 - Precio
4 - Todo
5 - Salir
Ingrese el nuevo nombre del producto: Peras
```

### Eliminar un producto

```text
Seleccione el Id del producto: 123
Producto eliminado correctamente.
```

### Salir

```text
Hasta pronto
```

## Contribuir

¡Las contribuciones son bienvenidas! Por favor, abre un issue o un pull request para cualquier mejora o corrección.
