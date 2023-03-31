
namespace TakealotShoppingCart.Models
{
  public static class Products
  {
    public static Dictionary<string, Product> Dictionary = new Dictionary<string, Product>
    {
      { "A", new Product("A", 50, 3, 130) },
      { "B", new Product("B", 30, 2, 45) },
      { "C", new Product("C", 20) },
      { "D", new Product("D", 15) },
    };
  }
}
