using static TakealotShoppingCart.Models.CartHelper;

namespace TakealotShoppingCart.Models
{
  public class CartHelper
  {
    private readonly Cart _cart;

    public CartHelper()
    {
      _cart = new Cart();
    }

    public void AddProduct(string productKey)
    {
      if (!Products.Dictionary.ContainsKey(productKey))
      {
        throw new ArgumentException($"Product with name {productKey} doesn't exist.", nameof(productKey));
      }

      if (!_cart.Products.ContainsKey(Products.Dictionary[productKey]))
      {
        _cart.Products.Add(Products.Dictionary[productKey], 0);
      }

      _cart.Products[Products.Dictionary[productKey]] += 1;

      CalculateTotal();
    }

    public void RemoveProduct()
    {
      // TODO
    }

    public Cart GetCart()
    {
      return _cart;
    }

    public Cart Checkout()
    {
      _cart.Status = CartStatus.PendingPayment;
      return GetCart();
    }

    private void CalculateTotal()
    {
      _cart.TotalAmountInCart = 0;
      foreach (var cartProduct in _cart.Products)
      {
        _cart.TotalAmountInCart += cartProduct.Key.GetPrice(cartProduct.Value);
      }
    }
  }

  public class Cart
  {
    public Cart()
    {
      Products = new Dictionary<Product, int>();
      Status = CartStatus.New;
    }

    public Dictionary<Product, int> Products { get; set; }
    public decimal TotalAmountInCart { get; set; }
    public CartStatus Status { get; set; }
  }

  public enum CartStatus
  {
    New,
    PendingPayment,
    Paid
  }
}