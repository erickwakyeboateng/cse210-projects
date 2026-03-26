using System.Collections.Generic;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public double getTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.getTotalCost();
        }

        if (_customer.livesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string getPackingLabel()
    {
        string result = "Packing Label:\n";

        foreach (Product p in _products)
        {
            result += p.getProductInfo() + "\n";
        }

        return result;
    }

    public string getShippingLabel()
    {
        return "Shipping Label:\n" + _customer.getName() + "\n" + _customer.getAddress();
    }
}