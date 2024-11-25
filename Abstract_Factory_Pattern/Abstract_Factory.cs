using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public interface IFood
    {
        string Eat();
    }

    class VegFood : IFood
    {
        public string Eat()
        {
            return "I only eats veg food";
        }
    }

    class MilkFood : IFood
    {
        public string Eat()
        {
            return "Yes eat milky-creamy food ";
        }

    }

    public interface IFastFood
    {
        public string Eat();
    }

    class VegFF : IFastFood //concreate product1
    {

        public string Eat()
        {
            return "yes also eat veg fast food";
        }

    }
    class MilkFF : IFastFood //concreate Product2
    {
        public string Eat()
        {
            return "Yes also eat milky fast food also";
        }

    }

    public interface IChef
    {
        IFood CreateFood();
        IFastFood CreateFastFood();
    }

    // Concrete Factory 1
    class VegChef : IChef
    {
        public IFood CreateFood()
        {
            return new VegFood();
        }

        public IFastFood CreateFastFood()
        {
            return new VegFF();
        }
    }

    // Concrete Factory 2
    class MilkChef : IChef
    {
        public IFood CreateFood()
        {
            return new MilkFood();
        }

        public IFastFood CreateFastFood()
        {
            return new MilkFF();
        }
    }

    class FoodService
    {
        private readonly IFood _food;
        private readonly IFastFood _fastFood;

        public FoodService(IChef chef)
        {
            _fastFood = chef.CreateFastFood();
            _food = chef.CreateFood();
        }

        public void ServeFood()
        {
            Console.WriteLine(_food.Eat());
            Console.WriteLine(_fastFood.Eat());
        }
    }
}
