namespace project3 {
public class product {
  public int Id { get; set; }
  public string Name { get; set; }
  public decimal Price { get; set; }

  public product(int id, string name, decimal price) {
    Id = id;
    Name = name;
    Price = price;
  }
}

  }