using TakealotShoppingCart.Models;

namespace TakealotShoppingCart.Tests
{
  public class Tests
  {
    [Test]
    public void Add_ProductA_To_Cart()
    {
      // Mock/Arrange
      var productKey = "A";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKey);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(50, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_ProductA_3times_To_Cart_To_Get_A_Discount()
    {
      // Mock/Arrange
      var productKey = "A";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKey);
      cartHelper.AddProduct(productKey);
      cartHelper.AddProduct(productKey);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(130, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_ProductB_To_Cart()
    {
      // Mock/Arrange
      var productKey = "B";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKey);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(30, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_ProductB_2times_To_Cart_To_Get_A_Discount()
    {
      // Mock/Arrange
      var productKeyB = "B";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKeyB);
      cartHelper.AddProduct(productKeyB);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(45, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_ProductC_To_Cart()
    {
      // Mock/Arrange
      var productKey = "C";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKey);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(20, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_ProductD_To_Cart()
    {
      // Mock/Arrange
      var productKey = "D";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKey);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(15, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_All_Products_Single_Quantity_To_Cart()
    {
      // Mock/Arrange
      var productKeyA = "A";
      var productKeyB = "B";
      var productKeyC = "C";
      var productKeyD = "D";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKeyA);
      cartHelper.AddProduct(productKeyB);
      cartHelper.AddProduct(productKeyC);
      cartHelper.AddProduct(productKeyD);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(115, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }

    [Test]
    public void Add_All_Products_Single_And_Multiple_Quantities_To_Cart_With_Discount()
    {
      // Mock/Arrange
      var productKeyA = "A";
      var productKeyB = "B";
      var productKeyC = "C";
      var productKeyD = "D";

      //ACT
      var cartHelper = new CartHelper();
      cartHelper.AddProduct(productKeyA);
      cartHelper.AddProduct(productKeyA);
      cartHelper.AddProduct(productKeyA);
      cartHelper.AddProduct(productKeyB);
      cartHelper.AddProduct(productKeyB);
      cartHelper.AddProduct(productKeyC);
      cartHelper.AddProduct(productKeyD);
      cartHelper.AddProduct(productKeyD);

      var cart = cartHelper.GetCart();

      // Assert
      Assert.IsNotEmpty(cart.Products);
      Assert.AreEqual(225, cart.TotalAmountInCart);
      Assert.AreEqual(CartStatus.New, cart.Status);
    }
  }
}