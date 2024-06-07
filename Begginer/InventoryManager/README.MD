# InventoryManager

his is a simple console program for inventory management. It allows users to view the inventory, add new products, modify existing products, delete products, and exit the program.

## Features

- View the product inventory.
- Add a new product.
- Modify an existing product.
- Delete a product.
- Exit the program.

## Requirements

- .NET SDK

## How to Use

1. Clone the repository or download the files.

2. Navigate to the project directory and run the following command to compile the program:

    ```bash
    dotnet build
    ```

3. Run the program with the following command:

    ```bash
    dotnet run
    ```

## Menu Options

1. **View Inventory**: Displays a list of all products in the inventory.
2. **Add a New Product**: Allows you to add a new product to the inventory by entering its name, quantity, and price.
3. **Modify an Existing Product**: Allows you to modify the name, quantity, and price of an existing product by selecting its ID.
4. **Delete a Product:**: Allows you to delete a product from the inventory by selecting its ID.
5. **Exit**: Exits the program.

## Example Usage

```text
1 - View Inventory
2 - Add a New Product
3 - Modify an Existing Product
4 - Delete a Product
5 - Exit
```

### View Inventory

```text
No products in the list
```

### Add a New Product

```text
Enter a product: Apples
Enter the product quantity: 10
Enter the product price: 0.5
```

### Modify an Existing Product

```text
Select the product ID you want to modify: 123
What do you want to modify?
1 - Name
2 - Quantity
3 - Price
4 - All
5 - Exit
Enter the new product name: Pears
```

### Delete a Product

```text
Select the product ID: 123
Product deleted successfully.
```

### Exit

```text
See you soon
```

## Contribute

Contributions are welcome! Please open an issue or a pull request for any improvements or corrections.
