
namespace TakealotShoppingCart.Models
{
  public class Cart
  {
    private readonly Dictionary<string, int> productCountByName;

    public Cart()
    {
      productCountByName = new Dictionary<string, int>();
    }

    public void AddProduct(string productName)
    {
      if (!Products.Dictionary.ContainsKey(productName))
      {
        throw new ArgumentException($"Product with name {productName} doesn't exist.", nameof(productName));
      }

      if (!productCountByName.ContainsKey(productName))
      {
        productCountByName.Add(productName, 0);
      }

      productCountByName[productName] += 1;
    }

    public decimal Checkout()
    {
      decimal totalPrice = 0;

      if (productCountByName.Count == 0)
      {
        throw new ArgumentNullException("The cart must contain at least one product", nameof(productCountByName));
      }

      foreach (var productNameCountPair in productCountByName)
      {
        var product = Products.Dictionary[productNameCountPair.Key];
        var subtotal = product.GetPrice(productNameCountPair.Value);
        totalPrice += subtotal;
        Console.WriteLine($"The number of Product {productNameCountPair.Key} is: {productNameCountPair.Value}");
        Console.WriteLine($"The subtotal of Product {productNameCountPair.Key} is: {subtotal}");
        Console.WriteLine("");
      }

      return totalPrice;
    }
  }
}
