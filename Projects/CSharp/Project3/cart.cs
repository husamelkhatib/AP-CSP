namespace project3 {
public class cart {
  private List<product> products = new List<product>();

  public void AddProduct(Product product) {
    products.Add(product);
  }

  public void RemoveProduct(int productId) {
    var product = products.FirstOrDefault(p => p.Id == productId); //FirstOrDefault returns the first element of a collection or the first element that satisfies a condition
    if (product != null) {
      products.Remove(product); 
    }
  }

  public decimal GetTotalPrice() {
    return products.Sum(product => product.Price);
  }

  public IEnumerable<product> GetProducts() { // IEnumerable is better in this case than an array because I can iterate through the collection
    return products;
  }
}
  }