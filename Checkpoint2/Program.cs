/* ###Intro
 * Write a console app which starts by asking the user for: 
 * 1. Category
 * 2. Product Name
 * 3. Price
 * 
 * 
 * -----------------  DONE -----------------
 * 
 * ##Level 1-3
 * ---Your application needs at least 2 classes.
 * ---Use these classes when you add items to a list. 
 * ---You should be able to add items to the list(s) until you write "q" (for quit).
 * ---Present a list with all items added.
 * ---Summarize price when presenting list.   
 * ---The list should be sorted from low price to high and a sum at the bottom.
 * ---Make it possible to add more products after presenting the list.
 * ---Add Error handling to your console app.
 * 
 * 
 * -----------------  TODO -----------------
 * 
 * Refactor your code using "Linq" if possible.
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
 * 
 * ##Level 4 (Extra)
 * A) Add a Search function making it possible to search for products in presented list
 * B) Highlight the searched item in presented list.*/


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Checkpoint2;
using static Checkpoint2.Product;

// Greeting message in Green
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("------------------           WELCOME!           ------------------");
Console.WriteLine("------------------------------------------------------------------");
Console.ResetColor();
Console.WriteLine("");
Console.WriteLine("");

Main();

static void Main()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("");

    Console.WriteLine("Please enter the appropriate information when prompted.");
    Console.WriteLine("Or enter 'q' in order to quit the program");
    Console.WriteLine("");
    Console.ResetColor();

    // Initiate product list
    List<Product> productList = new List<Product>();

    // Run AddProducts method
    AddProducts(productList);

    // Usage instructions
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("If you would like to add more products, enter 'y' or 'yes'");
    Console.WriteLine("If you would like to for a specific product, enter 's' or 'search'");
    Console.WriteLine("Or enter 'q' in order to quit the program");
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("");
    Console.ResetColor();


    while (true)
    {
        // Save user's input
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        string input = Console.ReadLine();
        Console.ResetColor();

        // Quit if user types 'q', 'quit' or 'exit'
        if (input.ToLower().Trim() == "q" || input.ToLower().Trim() == "quit" || input.ToLower().Trim() == "exit")
        {
            break;
        }
        //  Relaunch the AddProducts method if user types 'y' or 'yes'
        else if (input.ToLower().Trim() == "y" || input.ToLower().Trim() == "yes")
        {
            AddProducts(productList);
            Main();
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine("If you would like to Add more products, enter 'y' or 'yes'");
            //Console.WriteLine("If you would like to Search for a specific product, enter 's' or 'search'");
            //Console.WriteLine("Or enter 'q' in order to Quit the program");
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------------------------------------");
            //Console.ResetColor();
        }
        //  Launch Search method if user types 'y' or 'yes'
        else if (input.ToLower().Trim() == "s" || input.ToLower().Trim() == "search")
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Enter the Product Name of the product you would like to view:");
            Console.WriteLine("Or enter 'q' in order to Quit the program");
            Console.WriteLine("");
            Search(productList);
            Main();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input you entered is not valid.");
            Console.ResetColor();
            Console.WriteLine("");
            Main();
            //Console.WriteLine("If you would like to add more products, enter 'y' or 'yes'");
            //Console.WriteLine("If you would like to for a specific product, enter 's' or 'search'");
            //Console.WriteLine("Or enter 'q' in order to Quit the program");
        }
    }

    
}

static void AddProducts(List<Product> productList)
{

    while (true)
    {
        string category = "";
        string productName = "";
        int price = 0;
        string brand = "";
        string mod_res = "";

        // Prompt user to enter category if missing
        if (category == "")
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Please enter the Products's Category:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. TV");
            Console.WriteLine("Or enter 'q' in order to quit the program");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string inputCategory = Console.ReadLine();
            Console.ResetColor();

            // Quit and display results if user types 'q', 'quit' or 'exit'
            if (inputCategory.ToLower().Trim() == "q" || inputCategory.ToLower().Trim() == "quit" || inputCategory.ToLower().Trim() == "exit")
            {
                break;
            }

            // Clean up and interpret user input
            else if (inputCategory.ToLower().Trim() == "car" || inputCategory.ToLower().Trim() == "1" || inputCategory.ToLower().Trim() == "1. car")
            {
                // Set product's category from user input
                category = "Car";

                // Prompt user to enter brand if missing
                if (brand == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter the Cars's Brand:");
                    Console.WriteLine("Or enter 'q' in order to quit the program");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string inputBrand = Console.ReadLine();
                    Console.ResetColor();

                    // Quit and display results if user types 'q', 'quit' or 'exit'
                    if (inputBrand.ToLower().Trim() == "q" || inputBrand.ToLower().Trim() == "quit" || inputBrand.ToLower().Trim() == "exit")
                    {
                        break;
                    }                    

                    // Set product's brand from user input
                    else
                    {
                        brand = inputBrand;
                    }
                }

                // Prompt user to enter model if missing
                if (mod_res == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter the Cars's Model:");
                    Console.WriteLine("Or enter 'q' in order to quit the program");
                    Console.WriteLine("");
                    
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string inputModel = Console.ReadLine();
                    Console.ResetColor();

                    // Quit and display results if user types 'q', 'quit' or 'exit'
                    if (inputModel.ToLower().Trim() == "q" || inputModel.ToLower().Trim() == "quit" || inputModel.ToLower().Trim() == "exit")
                    {
                        break;
                    }                    

                    // Set product's model from user input
                    else
                    {
                        mod_res = inputModel;
                    }
                }
            }

            // Clean up and interpret user input
            else if (inputCategory.ToLower().Trim() == "tv" || inputCategory.ToLower().Trim() == "2" || inputCategory.ToLower().Trim() == "2. tv")
            {

                // Set product's category from user input
                category = "TV";

                // Prompt user to enter brand if missing
                if (brand == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter the TV's Brand:");
                    Console.WriteLine("Or enter 'q' in order to quit the program");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string inputBrand = Console.ReadLine();
                    Console.ResetColor();

                    // Quit and display results if user types 'q', 'quit' or 'exit'
                    if (inputBrand.ToLower().Trim() == "q" || inputBrand.ToLower().Trim() == "quit" || inputBrand.ToLower().Trim() == "exit")
                    {
                        break;
                    }

                    // Set product's brand from user input
                    else
                    {
                        brand = inputBrand;
                    }

                }

                // Prompt user to enter resolution if missing
                if (mod_res == "")
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter the TV's Resolution (1k, 2k, 4k, 8k):");
                    Console.WriteLine("Or enter 'q' in order to quit the program");
                    Console.WriteLine("");
                    
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    string inputResolution = Console.ReadLine();
                    Console.ResetColor();

                    // Quit and display results if user types 'q', 'quit' or 'exit'
                    if (inputResolution.ToLower().Trim() == "q" || inputResolution.ToLower().Trim() == "quit" || inputResolution.ToLower().Trim() == "exit")
                    {
                        break;
                    }

                    // Set product's resolution from user input
                    else
                    {
                        mod_res = inputResolution;
                    }
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The entered category is not valid.");
                Console.ResetColor();
                Console.WriteLine("");
            }
        }

        // Prompt user to enter product name if missing
        if (productName == "")
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Please enter the Product Name:");
            Console.WriteLine("Or enter 'q' in order to quit the program");
            Console.WriteLine("");

            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string inputName = Console.ReadLine();
            Console.ResetColor();

            // Quit and display results if user types 'q', 'quit' or 'exit'
            if (inputName.ToLower().Trim() == "q" || inputName.ToLower().Trim() == "quit" || inputName.ToLower().Trim() == "exit")
            {
                break;
            }

            // Set product's ´name from user input
            else
            {
                productName = inputName;
            }
        }

        // Prompt user to enter price if missing
        if (price == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Please enter the Price:");
            Console.WriteLine("Or enter 'q' in order to quit the program");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string inputPrice = Console.ReadLine();
            Console.ResetColor();

            int priceValue = 0;

            // Quit and display results if user types 'q', 'quit' or 'exit'
            if (inputPrice.ToLower().Trim() == "q" || inputPrice.ToLower().Trim() == "quit" || inputPrice.ToLower().Trim() == "exit")
            {
                break;
            }

            // Convert user input from string to int
            else if (Int32.TryParse(inputPrice, out priceValue))
            {

                // Check if user's price is a negative number and if so print error
                if (priceValue < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Price cannot be a negative number");
                    Console.ResetColor();
                    Console.WriteLine("");
                }

                // Set product's price from user input if it's positive
                else if (priceValue > 0)
                {
                    price = priceValue;
                }
            }

            // Print error if input is not a number
            else
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Price must be a number");
                Console.ResetColor();
                Console.WriteLine("");
            }
        }

        // Add product to product list if has all values set
        if (productName != "" && price != 0 && category != "" && brand != "" && mod_res != "")
        {
            productList.Add(new Product(productName, price, new Product.Category(category, brand, mod_res)));

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*** PRODUCT ADDED ***");
            Console.ResetColor();
            Console.WriteLine("Add another product or quit and view results by typing 'q'");
            Console.WriteLine("");

        }
    }
    // Initiate sorted list
    List<Product> sortedProductList = productList.OrderBy(Product => Product.price).ToList();

    var sum = 0;

    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------");

    Console.WriteLine("Category:".PadRight(15) + "Product Name:".PadRight(15) + "Price:".PadRight(15) + "Brand:".PadRight(15) + "Model/Resolution:");

    // Add products from product list to sorted list
    foreach (Product product in sortedProductList)
    {
        Console.WriteLine(product.category.name.PadRight(15) + product.productName.PadRight(15) + product.price.ToString().PadRight(15) + product.category.brand.PadRight(15) + product.category.mod_res);

        // Add product price to sum
        sum += product.price;
    }

    // Print summarized price
    Console.WriteLine($"Total Summarized Price:".PadRight(20) + sum);
    Console.WriteLine("");
}


static void Search(List<Product> productList)
{
    // Save user's input
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    string input = Console.ReadLine();
    Console.ResetColor();

    // Search for products and add to searchResult list
    List<Product> searchResult =
        (from product in productList
            where product.productName.ToLower().Trim() == input.ToLower().Trim()
            select product).ToList();

    // Print error message if no results where found
    if (searchResult.Count == 0)
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your search did not return any results");
        Console.ResetColor();
        Console.WriteLine("");
    }
    else
    {
        // Print results from search in console
        foreach (Product product in searchResult)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------------------");

            Console.WriteLine("Category:".PadRight(15) + "Product Name:".PadRight(15) + "Price:".PadRight(15) + "Brand:".PadRight(15) + "Model/Resolution:");

            Console.WriteLine(product.category.name.PadRight(15) + product.productName.PadRight(15) + product.price.ToString().PadRight(15) + product.category.brand.PadRight(15) + product.category.mod_res);
        }
        Console.WriteLine("");
    }
}