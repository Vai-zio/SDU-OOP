using System.Diagnostics;

class Program
{
    static void Main()
    {
        FoodItem dih = new FoodItem("Dih",9.99,new DateTime(2029,12,31,15,15,15));
        NonFoodItem metaldih = new NonFoodItem("Metaldih",19.9,new string[] {"Aluminium","Dih","Nuts and Bolts"});
        Console.WriteLine(dih);
        Console.WriteLine(metaldih);
    }

    abstract class Item
    {
        protected string Name { get; private set; }
        protected double Price { get; private set; }
        
        protected Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class FoodItem : Item
    {
        protected DateTime ExpiresAt { get; private set; }

        public FoodItem(string name, double price, DateTime expiresAt) : base(name, price)
        {
            ExpiresAt = expiresAt;
        }

        public override string ToString()
        {
            return " | Name: "+Name+" | Price: "+Price+"$"+" | Expiration Date: "+ExpiresAt+" |";
        }
    }
    
    class NonFoodItem : Item
    {
        public string[] Materials { get; private set; }

        public NonFoodItem(string name, double price, string[] materials) : base(name, price)
        {
            Materials = materials;
        }
        
        public override string ToString()
        { 
            string matList = string.Join(", ", Materials);
            return " | Name: "+Name+" | Price: "+Price+"$" + " | Materials: "+matList+" |";
        }
    }
}