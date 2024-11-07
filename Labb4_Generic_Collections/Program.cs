namespace Labb4_Generic_Collections;

class Program
{
    static void Main(string[] args)
    {
        var restaurant = new Restaurant();
        
        // skapar upp mina maträtter
        MenuItem Pizza = new MenuItem(1, "Pizza", 99);
        MenuItem Pasta = new MenuItem(2, "Pasta", 89);
        MenuItem Sallad = new MenuItem(3, "Sallad", 79);
        MenuItem Kebab = new MenuItem(4, "Kebab", 69);
        MenuItem KebabPizza = new MenuItem(5, "KebabPizza", 119);
        MenuItem Vesuvio = new MenuItem(6, "Vesuvio", 109);
        MenuItem Hawaii = new MenuItem(7, "Hawaii", 99);
        MenuItem Margherita = new MenuItem(8, "Margherita", 89);
        
        
        // lägger in maträtterna i menyn
        restaurant.AddToMenu(new MenuItem(1, "Pizza", 99));
        restaurant.AddToMenu(new MenuItem(2, "Pasta", 89));
        restaurant.AddToMenu(new MenuItem(3, "Sallad", 79));
        restaurant.AddToMenu(new MenuItem(4, "Kebab", 69));
        restaurant.AddToMenu(new MenuItem(5, "KebabPizza", 119));
        restaurant.AddToMenu(new MenuItem(6, "Vesuvio", 109));
        restaurant.AddToMenu(new MenuItem(7, "Hawaii", 99));
        restaurant.AddToMenu(new MenuItem(8, "Margherita", 89));

        Console.WriteLine("--------------");
        restaurant.ShowMenu();
        Console.WriteLine("--------------");

        // skapar mina beställningar
        var order1 = new Order(new List<MenuItem>(), 1);
        order1.AddItem(Pizza);
        order1.AddItem(Pasta);
        order1.AddItem(Sallad);
        restaurant.CreateOrder(order1);
        Console.WriteLine("--------------");

        
        var order2 = new Order(new List<MenuItem>(), 2);
        order2.AddItem(Kebab);
        order2.AddItem(KebabPizza);
        order2.AddItem(Vesuvio);
        restaurant.CreateOrder(order2);
        Console.WriteLine("--------------");

        
        var order3 = new Order(new List<MenuItem>(), 3);
        order3.AddItem(Hawaii);
        order3.AddItem(Margherita);
        restaurant.CreateOrder(order3);
        Console.WriteLine("--------------");

        
        // Visar alla aktuella ordrar
        restaurant.ShowOrders();
        Console.WriteLine("--------------");

        
        // visa nästa order
        restaurant.ShowNextOrder();
        Console.WriteLine("--------------");

        
        // lägg till en ny order
        var order4 = new Order(new List<MenuItem>(), 4);
        order4.AddItem(Pizza);
        order4.AddItem(Kebab);
        restaurant.CreateOrder(order4);
        Console.WriteLine("--------------");

        
        // visa ordrar i kön
        restaurant.ShowOrders();
        Console.WriteLine("--------------");
        
        // hantera två orders
        restaurant.HandleOrder();
        Console.WriteLine("--------------");
        
        restaurant.HandleOrder();
        Console.WriteLine("--------------");
        
        restaurant.ShowOrders();
        Console.WriteLine("--------------");
        
        restaurant.ShowNextOrder();
        Console.WriteLine("--------------");
        
        restaurant.HandleOrder();
        Console.WriteLine("--------------");
        
        restaurant.ShowOrders();
        Console.WriteLine("--------------");

        restaurant.HandleOrder();
        Console.WriteLine("--------------");
        
        restaurant.ShowOrders();
        Console.WriteLine("--------------");
    }
}