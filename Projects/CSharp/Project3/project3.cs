using System;
namespace project3 {
  class project3 {
  public static void main(string[] args) {
    var products = new List<product>
       {
         new product(1, "Laptop", 999.99), 
         new product(2, "Smartphone", 499.99), 
         // put all of your products here in the format above
       };

    var Cart = new cart();
    var TransactionProcessor = new transactionProcessor();

    Cart.AddProduct(products[0]); // Adding laptop
    Cart.AddProduct(products[1]); // Adding smartphone
    // Add the rest of the products in the same format as above\

    Console.WriteLine("Cart contents:");
    foreach (var product in Cart.GetProducts()) {
      Console.WriteLine(product.Name + " $" + product.Price);
    }
    var total = Cart.GetTotalPrice();
    Console.WriteLine("Total: $" + total);
    if (TransactionProcessor.ProcessPayment(total)) {
      Console.WriteLine("Payment Successful.");
      } else {
      Console.WriteLine("Payment Failed.");
      }
    }
  }
}
}