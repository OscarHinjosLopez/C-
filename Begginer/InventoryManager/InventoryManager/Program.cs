using System;

namespace InventoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string? productName = null;
            int menuChoice = 0;
            int quantity = 0;
            int productId = 0;
            int indexToModify = -1;
            double price = 0;
            bool exitProgram = false;
            List<string> productList = new List<string>();
            while (!exitProgram)
            {
                Console.WriteLine("1 - View Inventory\n2 - Add a New Product\n3 - Modify an Existing Product\n4 - Remove a Product\n5 - Exit");
                if (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 5)
                {
                    Console.WriteLine("You have not selected a valid option");
                    continue;
                }

                switch (menuChoice)
                {
                    case 1:
                        string[] productArray = productList.ToArray();
                        if (productArray.Length == 0)
                        {
                            Console.WriteLine("There are no products in the list");
                            break;
                        }

                        for (int i = 0; i < productArray.Length; i += 4)
                        {
                            Console.WriteLine($"Id: {productArray[i]} - Product: {productArray[i + 1]} - Quantity: {productArray[i + 2]} - Price: {productArray[i + 3]}");
                        }
                        break;
                    case 2:

                        Console.Write("Enter a product: ");
                        productName = Console.ReadLine().Trim();

                        if (productName.Length == 0)
                        {
                            Console.WriteLine("You have not entered any product.");
                            break;
                        }

                        Console.Write("Enter a product quantity: ");
                        if (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1)
                        {
                            Console.WriteLine("You have not selected a valid quantity");
                            break;
                        }
                        Console.Write("Enter the product price: ");
                        if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
                        {
                            Console.WriteLine("You have not selected a valid product price");
                            break;
                        }

                        productList.Add(rand.Next(1, 1000000001).ToString());
                        productList.Add(productName);
                        productList.Add(quantity.ToString());
                        productList.Add(price.ToString());

                        break;
                    case 3:

                        int modifyChoice = 0;

                        Console.WriteLine("Select the ID of the product you want to modify");
                        if (!int.TryParse(Console.ReadLine(), out productId) || productId < 0 || !productList.Contains(productId.ToString()))
                        {
                            Console.WriteLine("You have not selected a valid ID");
                            break;
                        }

                        for (int i = 0; i < productList.Count; i += 4)
                        {
                            if (productList[i] == productId.ToString())
                            {
                                indexToModify = i;
                                break;
                            }
                        }

                        if (indexToModify == -1)
                        {
                            Console.WriteLine("No product found with the specified ID.");
                            break;
                        }

                        // The product was found, now you can modify it
                        Console.WriteLine("What would you like to modify?");
                        Console.WriteLine("1 - Name");
                        Console.WriteLine("2 - Quantity");
                        Console.WriteLine("3 - Price");
                        Console.WriteLine("4 - All");
                        Console.WriteLine("5 - Exit");

                        if (!int.TryParse(Console.ReadLine(), out modifyChoice) || modifyChoice < 1 || modifyChoice > 5)
                        {
                            Console.WriteLine("You have not selected a valid option");
                            break;
                        }

                        switch (modifyChoice)
                        {
                            case 1:
                                Console.Write("Enter the new product name: ");
                                productList[indexToModify + 1] = Console.ReadLine().Trim();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new product quantity: ");
                                if (!int.TryParse(Console.ReadLine(), out int newQuantity) || newQuantity < 0)
                                {
                                    Console.WriteLine("You have not entered a valid quantity.");
                                    break;
                                }
                                productList[indexToModify + 2] = newQuantity.ToString();
                                break;
                            case 3:
                                Console.Write("Enter the new product price: ");
                                if (!double.TryParse(Console.ReadLine(), out double newPrice) || newPrice < 0)
                                {
                                    Console.WriteLine("You have not entered a valid price.");
                                    break;
                                }
                                productList[indexToModify + 3] = newPrice.ToString();
                                break;
                            case 4:
                                Console.Write("Enter the new product name: ");
                                productList[indexToModify + 1] = Console.ReadLine().Trim();

                                Console.Write("Enter the new product quantity: ");
                                if (!int.TryParse(Console.ReadLine(), out newQuantity) || newQuantity < 0)
                                {
                                    Console.WriteLine("You have not entered a valid quantity.");
                                    break;
                                }
                                productList[indexToModify + 2] = newQuantity.ToString();

                                Console.Write("Enter the new product price: ");
                                if (!double.TryParse(Console.ReadLine(), out newPrice) || newPrice < 0)
                                {
                                    Console.WriteLine("You have not entered a valid price.");
                                    break;
                                }
                                productList[indexToModify + 3] = newPrice.ToString();
                                break;
                            case 5:
                                break;
                        }

                        break;
                    case 4:

                        Console.WriteLine("Select the product ID");
                        if (!int.TryParse(Console.ReadLine(), out productId) || productId < 0 || !productList.Contains(productId.ToString()))
                        {
                            Console.WriteLine("You have not selected a valid ID");
                            break;
                        }

                        for (int i = 0; i < productList.Count; i += 4)
                        {
                            if (productList[i] == productId.ToString())
                            {
                                indexToModify = i;
                                break;
                            }
                        }

                        // Verify if the product was found
                        if (indexToModify == -1)
                        {
                            Console.WriteLine("No product found with the specified ID.");
                            break;
                        }

                        productList.RemoveAt(indexToModify);
                        productList.RemoveAt(indexToModify);
                        productList.RemoveAt(indexToModify);
                        productList.RemoveAt(indexToModify);
                        Console.WriteLine("Product successfully removed.");
                        break;
                    case 5:
                        Console.WriteLine("Goodbye");
                        exitProgram = true;
                        break;
                }
            }
        }
    }
}
