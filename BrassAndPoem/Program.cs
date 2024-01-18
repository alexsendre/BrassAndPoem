
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Tuba",
        Price = 19.99m,
        Id = 1
    },
    new Product()
    {
        Name = "Trombone",
        Price = 44.99m,
        Id = 1
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 83.99m,
        Id = 1
    },
    new Product()
    {
        Name = "Kvasir's Finest",
        Price = 33.84m,
        Id = 2
    },
    new Product()
    {
        Name = "Fire and Ice",
        Price = 29.99m,
        Id = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poems",
        Id = 2
    }
};

//put your greeting here
Console.WriteLine(@"Welcome to Brass & Poem!
How can we help you today?
");

//implement your loop here
string choice = null;
while (choice != "0")
{
    DisplayMenu();
    choice = Console.ReadLine();

    if (choice == "0")
    {
        Console.WriteLine("\nThanks for stopping by!");
    }
    else if (choice == "1")
    {
        Console.Clear();
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
        Console.Clear();
        AddProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        Console.Clear();
        DeleteProduct(products, productTypes);
    }
    else if (choice == "4")
    {
        Console.Clear();
        UpdateProduct(products, productTypes);
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"Please choose an option:
        0. Exit
        1. Display All Products
        2. Add Product
        3. Delete Product
        4. Update Product");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        string productType = productTypes.FirstOrDefault(type => type.Id == products[i].Id)?.Title;
        Console.WriteLine($"{i + 1}. {products[i].Name} of type {productType} is available for ${products[i].Price}.");
    }
    Console.WriteLine();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\nChoose product to delete:\n");
    for (int i = 0;i < products.Count;i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    if (int.TryParse(Console.ReadLine(), out int choiceIndex))
    {
        string deletedProduct = products[choiceIndex - 1].Name;
        products.RemoveAt(choiceIndex - 1);
        Console.WriteLine($"{deletedProduct} successfully deleted!");
    }
    else
    {
        Console.WriteLine("There was an error deleting your product.");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Product newProduct = new Product();
    Console.WriteLine("\nAdd a new product\n");

    Console.WriteLine("Name of product:");
    string name = Console.ReadLine();
    newProduct.Name = name;

    Console.WriteLine("Enter the price:");
    string price = Console.ReadLine();
    decimal priceConversion = decimal.Parse(price);
    newProduct.Price = priceConversion;

    Console.WriteLine("Choose type of product:");
    for (int i = 0; i < productTypes.Count;i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }
    string selection = Console.ReadLine();
    int selectionConversion = int.Parse(selection);
    newProduct.Id = selectionConversion;

    products.Add(newProduct);

    Console.WriteLine($"{newProduct.Name} has been added!\n");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("\nChoose which product to update:\n");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }

    if (int.TryParse(Console.ReadLine(), out int choiceIndex))
    {
        Product selectedProduct = products[choiceIndex - 1];
        Console.WriteLine($"You chose {selectedProduct.Name}.");

        Console.WriteLine("Enter new name: (press Enter again if no change required)");
        string updatedName = Console.ReadLine();
        if (!string.IsNullOrEmpty(updatedName))
        {
            selectedProduct.Name = updatedName;
        }

        Console.WriteLine("Enter new price: (press Enter again if no change required)");
        string newPrice = Console.ReadLine();
        if (!string.IsNullOrEmpty(newPrice) && decimal.TryParse(newPrice, out decimal updatedPrice))
        {
            selectedProduct.Price = updatedPrice;
        }

        Console.WriteLine("Select new product type: (press Enter if no change required)");
        for (int i = 0;i < productTypes.Count;i++)
        {
            Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
        }
        string response = Console.ReadLine();
        if (!string.IsNullOrEmpty(response) && int.TryParse(response, out int newType))
        {
            selectedProduct.Id = productTypes[newType - 1].Id;
        }

        Console.WriteLine($"{selectedProduct.Name} has been successfully updated!");
    }
    else
    {
        Console.WriteLine("There was an error updating this product.");
    }
}

// don't move or change this!
public partial class Program { }