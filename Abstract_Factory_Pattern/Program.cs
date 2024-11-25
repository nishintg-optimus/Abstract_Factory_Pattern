/*
 * Abstract factory design pattern provides an interface for creating families of 
 * related or dependent objects without specifying their concrete classes.
 */

using Abstract_Factory_Pattern;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a chef (Veg/Milk):");
        string choice = Console.ReadLine();

        IChef chef;
        switch (choice)
        {
            case "Veg":
                chef = new VegChef();
                break;
            case "Milk":
                chef = new MilkChef();
                break;
            default:
                throw new ArgumentException("Invalid choice");
        }

        FoodService foodService = new FoodService(chef);
        foodService.ServeFood();
    }
}



