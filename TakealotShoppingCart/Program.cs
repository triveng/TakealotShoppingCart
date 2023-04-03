using TakealotShoppingCart.Models;

var cart = new CartHelper();
int input;

while (true)
{
  Console.WriteLine("Please choose one of the options: ");
  Console.WriteLine("1. Add Product 'A' in the cart");
  Console.WriteLine("2. Add Product 'B' in the cart");
  Console.WriteLine("3. Add Product 'C' in the cart");
  Console.WriteLine("4. Add Product 'D' in the cart");
  Console.WriteLine("5. Checkout & print receipt");
  Console.WriteLine("6. Quit");
  Console.WriteLine("");

  while (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 6)
  {
    Console.WriteLine("Invalid input value! Input must be a number from 1 to 6.");
    Console.WriteLine("");
  }

  if (input == 1)
  {
    cart.AddProduct("A");
  }

  if (input == 2)
  {
    cart.AddProduct("B");
  }

  if (input == 3)
  {
    cart.AddProduct("C");
  }

  if (input == 4)
  {
    cart.AddProduct("D");
  }

  if (input == 5)
  {
    var total = cart.Checkout();
    Console.WriteLine($"The total price of your cart is: {total}");
    break;
  }

  if (input == 6)
  {
    break;
  }
}