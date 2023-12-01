namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
    // Interface representing a beverage
    public interface IBeverage
    {
        string GetDescription(); // Method to get the description of the beverage
        decimal GetCost();       // Method to get the cost of the beverage
    }

    // Concrete components implementing the IBeverage interface
    public class HouseBlend : IBeverage
    {
        public string GetDescription()
        {
            return "House Blend Coffee";
        }

        public decimal GetCost()
        {
            return 1.80M;
        }
    }

    public class DarkRoast : IBeverage
    {
        public string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public decimal GetCost()
        {
            return 2.20M;
        }
    }

    public class Decaf : IBeverage
    {
        public string GetDescription()
        {
            return "Decaf Coffee";
        }

        public decimal GetCost()
        {
            return 2.00M;
        }
    }

    public class Expresso : IBeverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public decimal GetCost()
        {
            return 2.90M;
        }
    }

    // Interface for decorating the condiments
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage beverage;

        // Constructor taking an IBeverage object to decorate
        public CondimentDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        // Abstract methods to be implemented by concrete decorators
        public abstract string GetDescription();
        public abstract decimal GetCost();
    }

    // Concrete decorators adding specific condiments to the beverage
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Steamed Milk";
        }

        public override decimal GetCost()
        {
            return beverage.GetCost() + 0.30M;
        }
    }

    public class Mocha : CondimentDecorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override decimal GetCost()
        {
            return beverage.GetCost() + 0.60M;
        }
    }

    public class Soy : CondimentDecorator
    {
        public Soy(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override decimal GetCost()
        {
            return beverage.GetCost() + 0.45M;
        }
    }

    public class WhippedCream : CondimentDecorator
    {
        public WhippedCream(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override decimal GetCost()
        {
            return beverage.GetCost() + 0.30M;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a beverage according to customer
            IBeverage beverage = new DarkRoast();

            
            beverage = new Mocha(beverage);
            beverage = new WhippedCream(beverage);

            // Final product
            Console.WriteLine("Beverage: " + beverage.GetDescription());
            Console.WriteLine("Cost: $" + beverage.GetCost());
        }
    }
}