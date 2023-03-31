
namespace TakealotShoppingCart.Models
{
  public class Product
  {
    public string Name { get; set; }

    private readonly decimal _price;

    private readonly int _specialCount;

    private readonly decimal _specialPrice;

    private readonly bool _hasSpecialPrice;

    public Product(string name, decimal price, int specialCount, decimal specialPrice)
    {
      if (string.IsNullOrWhiteSpace(name))
      {
        throw new ArgumentNullException("Name can't be empty.", nameof(name));
      }

      if (price <= 0)
      {
        throw new ArgumentNullException("Price must be a positive number.", nameof(price));
      }

      if (specialPrice <= 0)
      {
        throw new ArgumentNullException("Special price must be a positive number.", nameof(specialPrice));
      }

      if (specialCount <= 1)
      {
        throw new ArgumentNullException("Special price count must be larger than 1.", nameof(specialCount));
      }

      Name = name;
      _price = price;
      _specialPrice = specialPrice;
      _specialCount = specialCount;
      _hasSpecialPrice = true;
    }

    public Product(string name, decimal price)
    {
      if (string.IsNullOrWhiteSpace(name))
      {
        throw new ArgumentNullException("Name can't be empty.", nameof(name));
      }

      if (price <= 0)
      {
        throw new ArgumentNullException("Price must be a positive number.", nameof(price));
      }

      Name = name;
      _price = price;
      _hasSpecialPrice = false;
    }

    public decimal GetPrice(int count)
    {
      if (!_hasSpecialPrice)
      {
        return count * _price;
      }

      return ((count / _specialCount) * _specialPrice) + ((count % _specialCount) * _price);
    }
  }
}
