using System.Collections.Generic;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void addProduct(Product product)
    {
        products.Add(product);
    }

    public double getTotalCost()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.getTotalCost();
        }

        if (customer.livesInUSA())
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

        foreach (Product p in products)
        {
            result += p.getProductInfo() + "\n";
        }

        return result;
    }

    public string getShippingLabel()
    {
        return "Shipping Label:\n" + customer.getName() + "\n" + customer.getAddress();
    }
}