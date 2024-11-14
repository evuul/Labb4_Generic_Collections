namespace Labb4_Generic_Collections;

public class Restaurant
{
    // Skapar lista för meny och kö för beställningar
    private  List<MenuItem> _menu;
    private  Queue<Order> _orders;

    public Restaurant()
    {
        _menu = new List<MenuItem>();
        _orders = new Queue<Order>();
    }

    // Metod för att lägga till en maträtt till menyn
    public void AddToMenu(MenuItem menuItem)
    {
        _menu.Add(menuItem);
        PrintMessage($"Lagt till {menuItem} till menyn.");
    }
    
    // Metod för att visa alla maträtter i menyn
    public void ShowMenu()
    {
        PrintMessage("Visar hela menyn:");
        if (_menu.Count == 0)
        {
            PrintMessage("Menyn är tom.");
        }
        else
        {
            foreach (var item in _menu)
            {
                Console.WriteLine(item); 
            }
        }
    }

    // Metod för att lägga till en beställning i kön
    public void CreateOrder(Order order)
    {
        _orders.Enqueue(order);
        PrintMessage($"Beställning {order} har lagts till i kön.");
    }

    // Metod för att hantera och ta bort den första beställningen i kön
    public void HandleOrder()
    {
        if (_orders.Count > 0)
        {
            var order = _orders.Dequeue();
            PrintMessage($"Beställning {order} är färdig!");
        }
        else
        {
            PrintMessage("Det finns inga beställningar att hantera just nu.");
        }
    }

    // Metod för att visa alla beställningar i kön
    public void ShowOrders()
    {
        PrintMessage("Visar alla beställningar:");
        if (_orders.Count == 0)
        {
            PrintMessage("Det finns inga beställningar i kön.");
        }
        else
        {
            foreach (var order in _orders)
            {
                Console.WriteLine(order);
                Console.WriteLine("--------------");
            }
        }
    }

    // Metod som visar nästa beställning i kön
    public void ShowNextOrder()
    {
        if (_orders.Count > 0)
        {
            var order = _orders.Peek();
            PrintMessage($"Nästa beställning är {order}.");
        }
        else
        {
            PrintMessage("Det finns inga beställningar att visa.");
        }
    }

    // Privat metod för att skriva ut meddelanden
    private void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}