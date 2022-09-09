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
 * ---A) Add a Search function making it possible to search for products in presented list
 * B) Highlight the searched item in presented list.*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography;
using Checkpoint2;
using static Checkpoint2.Product;

// Greeting message in Green
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------           WELCOME!           ------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------------------------------");
Console.ResetColor();
Console.WriteLine("");

// Initiate product list
List<Product> productList = new List<Product>();

Main(productList);

static void Main(List<Product> productList)
{  
    while (true)
    {
        // Print instructions to user
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.ResetColor();
        Console.WriteLine("If you would like to ADD PRODUCTS, enter 'A' or 'ADD'");
        Console.WriteLine("If you would like to SEARCH for a specific product, enter 'S' or 'SEARCH'");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Or enter 'Q' in order to QUIT the program");
        Console.ResetColor();
        Console.WriteLine("");

        // Save user's input
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        string input = Console.ReadLine();
        Console.ResetColor();

        // Quit if user types 'Q', 'quit' or 'exit'
        if (input.ToLower().Trim() == "q" || input.ToLower().Trim() == "quit" || input.ToLower().Trim() == "exit")
        {
            break;
        }
        //  Launch the AddProducts method if user types 'a' or 'add'
        else if (input.ToLower().Trim() == "a" || input.ToLower().Trim() == "add")
        {
            AddProducts(productList);
        }
        //  Launch Search method if user types 'y' or 'yes'
        else if (input.ToLower().Trim() == "s" || input.ToLower().Trim() == "search")
        {            
            Search(productList);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input you entered is not valid.");
            Console.ResetColor();
            Console.WriteLine("");
        }
    }
}

static void AddProducts(List<Product> productList)
{
    bool quit = false;

    string category = "";
    string productName = "";
    int price = 0;
    string brand = "";
    string mod_res = "";

    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------------------------------------------");
    Console.WriteLine("");

    Console.WriteLine("Please enter the Products's Category:");
    Console.WriteLine("1. Car");
    Console.WriteLine("2. TV");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Or enter 'Q' in order to quit the program");
    Console.ResetColor();
    Console.WriteLine("");

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    string inputCategory = Console.ReadLine();
    Console.ResetColor();

    // Prompt user to enter category if missing
    while (category == "" && quit == false)
    {
        // Quit and display results if user types 'Q', 'quit' or 'exit'
        if (inputCategory.ToLower().Trim() == "q" || inputCategory.ToLower().Trim() == "quit" || inputCategory.ToLower().Trim() == "exit")
        {
            quit = true;
            
            // Print 
            if (productList.Count() != 0)
            {
                PrintList(productList);
            }
            
            break;
        }

        // Clean up and interpret user input
        else if (inputCategory.ToLower().Trim() == "car" || inputCategory.ToLower().Trim() == "1" || inputCategory.ToLower().Trim() == "1. car")
        {
            // Set product's category from user input
            category = "Car";

            // Prompt user to enter brand if missing
            while (brand == "" && quit == false)
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Please enter the Cars's Brand:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Or enter 'Q' in order to quit to main menu");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string inputBrand = Console.ReadLine();
                Console.ResetColor();

                // Quit and display results if user types 'Q', 'quit' or 'exit'
                if (inputBrand.ToLower().Trim() == "q" || inputBrand.ToLower().Trim() == "quit" || inputBrand.ToLower().Trim() == "exit")
                {
                    quit = true;
                    break;
                }                    

                // Set product's brand from user input
                else
                {
                    brand = inputBrand;
                }
            }
            while (mod_res == "" && quit == false)
            {
                // Prompt user to enter model if missing
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Please enter the Cars's Model:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Or enter 'Q' in order to quit to main menu");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string inputModel = Console.ReadLine();
                Console.ResetColor();

                // Quit and display results if user types 'Q', 'quit' or 'exit'
                if (inputModel.ToLower().Trim() == "q" || inputModel.ToLower().Trim() == "quit" || inputModel.ToLower().Trim() == "exit")
                {
                    quit = true;
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
            // Prompt user to enter brand if missing
            while (brand == "" && quit == false)
            {
                // Set product's category from user input
                category = "TV";

                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Please enter the TV's Brand:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Or enter 'Q' in order to quit to main menu");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string inputBrand = Console.ReadLine();
                Console.ResetColor();

                // Quit and display results if user types 'Q', 'quit' or 'exit'
                if (inputBrand.ToLower().Trim() == "q" || inputBrand.ToLower().Trim() == "quit" || inputBrand.ToLower().Trim() == "exit")
                {
                    quit = true;
                    break;
                }

                // Set product's brand from user input
                else
                {
                    brand = inputBrand;
                }
            }            

            // Prompt user to enter resolution if missing
            while (mod_res == "" && quit == false)
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Please enter the TV's Resolution (1k, 2k, 4k, 8k):");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Or enter 'Q' in order to quit to main menu");
                Console.ResetColor();
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string inputResolution = Console.ReadLine();
                Console.ResetColor();

                // Quit and display results if user types 'Q', 'quit' or 'exit'
                if (inputResolution.ToLower().Trim() == "q" || inputResolution.ToLower().Trim() == "quit" || inputResolution.ToLower().Trim() == "exit")
                {
                    quit = true;
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
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The entered category is not valid.");
            Console.ResetColor();
            Console.WriteLine("");
        }
    }

    

    while (productName == "" && quit == false)
    {
        // Prompt user to enter product name if missing
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("Please enter the Product Name:     ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Or enter 'Q' in order to quit to main menu");
        Console.ResetColor();
        Console.WriteLine("");


        Console.ForegroundColor = ConsoleColor.DarkBlue;
        string inputName = Console.ReadLine();
        Console.ResetColor();

        // Quit and display results if user types 'Q', 'quit' or 'exit'
        if (inputName.ToLower().Trim() == "q" || inputName.ToLower().Trim() == "quit" || inputName.ToLower().Trim() == "exit")
        {
            quit = true;
            break;
        }

        // Set product's ´name from user input
        else
        {
            productName = inputName;
        }
    }

    

    while (price <= 0 && quit == false)
    {
        // Prompt user to enter price if missing
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Please enter the Price:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Or enter 'Q' in order to QUIT to main menu");
        Console.ResetColor();
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        string inputPrice = Console.ReadLine();
        Console.ResetColor();

        int priceValue = 0;

        // Quit and display results if user types 'Q', 'quit' or 'exit'
        if (inputPrice.ToLower().Trim() == "q" || inputPrice.ToLower().Trim() == "quit" || inputPrice.ToLower().Trim() == "exit")
        {
            quit = true;
            break;
        }

        // Convert user input from string to int
        else if (Int32.TryParse(inputPrice, out priceValue))
        {

            // Check if user's price is a negative number and if so print error
            if (priceValue < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
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
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
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
        Console.WriteLine("------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("               *** PRODUCT ADDED ***");
        Console.WriteLine("");
        Console.ResetColor();
        Console.WriteLine("Add another product or quit and view results by typing 'Q'");
        Console.WriteLine("");

    }      
}


static void PrintList(List<Product> productList)
{
    // Initiate sorted list
    List<Product> sortedProductList = productList.OrderBy(Product => Product.price).ToList();

    var sum = 0;

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("------------------------------------------------------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------------------------------------------");    
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Category:".PadRight(15) + "Product Name:".PadRight(15) + "Price:".PadRight(15) + "Brand:".PadRight(15) + "Model/Resolution:");
    Console.ResetColor();

    // Add products from product list to sorted list
    foreach (Product product in sortedProductList)
    {
        if (product.search == true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(product.category.name.ToUpper().PadRight(15) + product.productName.ToUpper().PadRight(15) + product.price.ToString().PadRight(15) + product.category.brand.ToUpper().PadRight(15) + product.category.mod_res.ToUpper());
            Console.ResetColor();

            // Add product price to sum
            sum += product.price;
        }
        else
        {
            Console.WriteLine(product.category.name.ToUpper().PadRight(15) + product.productName.ToUpper().PadRight(15) + product.price.ToString().PadRight(15) + product.category.brand.ToUpper().PadRight(15) + product.category.mod_res.ToUpper());

            // Add product price to sum
            sum += product.price;
        }
        
    }

    // Print summarized price
    Console.WriteLine("");
    Console.WriteLine($"Total Summarized Price: ${sum}".PadRight(20));
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ResetColor();
}

static void Search(List<Product> productList)
{    
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------------------------------------------");
    Console.WriteLine("");

    Console.WriteLine("Enter the Product Name of the product you would like to view:");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Or enter 'Q' in order to QUIT to main menu");
    Console.ResetColor();
    Console.WriteLine("");

    // Save user's input
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    string input = Console.ReadLine();
    Console.ResetColor();

    // Quit if user types 'Q', 'quit' or 'exit'
    if (input.ToLower().Trim() == "q" || input.ToLower().Trim() == "quit" || input.ToLower().Trim() == "exit")
    {
        return;
    }
     
    // Search for products and add to searchResult list
    List<Product> searchResult =
        (from product in productList
            where product.productName.ToLower().Trim() == input.ToLower().Trim()
            select product).ToList();

    // Print results from search in console
    foreach (Product p in searchResult)
    {
        Console.WriteLine($"P:  {p.productName}");

        foreach (Product product in productList)
        {
            Console.WriteLine($"Product:  {product.productName}");

            if (p.productName == product.productName)
            {
                product.search = true;
                Console.WriteLine("Search == True");
            }
        }
    }
    // Call PrintList() with products
    PrintList(productList);
}
