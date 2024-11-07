namespace Labb4_Generic_Collections;

public class Order
{
    // I denna klass använder vi i stället private fields
    static int orderIdCounter = 1;
    private int _orderId;
    private List<MenuItem> _orderItems;
    private int _tableNumber;

    public Order(List<MenuItem> orderItems, int tableNumber)
    {
        // Automatiskt skapande av id
        _orderId = orderIdCounter;
        orderIdCounter++;
        _orderItems = orderItems;
        _tableNumber = tableNumber;
    }
    // läger till en maträtt i beställningen
    public void AddItem(MenuItem item)
    {
        _orderItems.Add(item);
    }
    
    // Metod för att beräkna totalpriset för alla artiklar i beställningen
    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var item in _orderItems)
        {
            totalPrice += item.Price;
        }
        return totalPrice;
    }

    // ToString-metoden visar detaljerad beställningsinformation
    public override string ToString()
    {
        string orderDetails = $"Order {_orderId} - Bord {_tableNumber}\nMaträtter:\n";
            
        // Lägg till varje maträtt i beställningen
        foreach (var item in _orderItems)
        {
            orderDetails += $"- 1st {item.Name}, Pris: {item.Price:C}\n";
        }

        orderDetails += $"Totalt pris: {CalculateTotalPrice():C}";
        return orderDetails;
    }
}