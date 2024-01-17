
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
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }