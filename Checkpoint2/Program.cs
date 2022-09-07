/* ###Intro
 * Write a console app which starts by asking the user for: 
 * 1. Category
 * 2. Product Name
 * 3. Price
 * 
 * 
 * ##Level 1-3
 * ---Your application needs at least 2 classes.
 * ---Use these classes when you add items to a list. 
 * ---You should be able to add items to the list(s) until you write "q" (for quit).
 * ---Present a list with all items added.
 * ---Summarize price when presenting list.   
 * ---The list should be sorted from low price to high and a sum at the bottom.
 * Make it possible to add more products after presenting the list.
 * Add Error handling to your console app.
 * Refactor your code using "Linq" if possible.
 * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
 * 
 * ##Level 4 (Extra)
 * A) Add a Search function making it possible to search for products in presented list
 * B) Highlight the searched item in presented list.*/


using System;
using System.Reflection;
using Checkpoint2;

static void Main()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("");
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("");

    Console.WriteLine("Welcome, please enter the appropriate information when prompted.");
    Console.WriteLine("Or enter 'q' in order to quit the program");
    Console.ResetColor();

    // Initiate product list
    List<Product> productList = new List<Product>();

    // Run AddProducts method
    AddProducts(productList);
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

            string inputCategory = Console.ReadLine();

            // Quit and display results if user types 'q'
            if (inputCategory.ToLower().Trim() == "q")
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

                    string inputBrand = Console.ReadLine();

                    // Quit and display results if user types 'q'
                    if (inputBrand.ToLower().Trim() == "q")
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

                    string inputModel = Console.ReadLine();

                    // Quit and display results if user types 'q'
                    if (inputModel.ToLower().Trim() == "q")
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

                    string inputBrand = Console.ReadLine();

                    // Quit and display results if user types 'q'
                    if (inputBrand.ToLower().Trim() == "q")
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

                    string inputResolution = Console.ReadLine();

                    // Quit and display results if user types 'q'
                    if (inputResolution.ToLower().Trim() == "q")
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

            string inputName = Console.ReadLine();

            // Quit and display results if user types 'q'
            if (inputName.ToLower().Trim() == "q")
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

            string inputPrice = Console.ReadLine();

            int priceValue = 0;

            // Quit and display results if user types 'q'
            if (inputPrice.ToLower().Trim() == "q")
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

        }
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