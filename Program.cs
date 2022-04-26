

Console.WriteLine("Домашнее задание. Создать список продуктов.");

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Введите количество продуктов:");
var prodNumber = int.Parse(Console.ReadLine());


List<Product> productList = new List<Product>();


for (int i = 1; i <= prodNumber; i++)
{
    
    Console.WriteLine($"Введите название продукта {i}: ");
    string productName = Console.ReadLine();
    
    Console.WriteLine($"Введите описание продукта {i}: ");
    string productDescription = Console.ReadLine();
    
    Console.WriteLine($"Укажите цену товара в BYN: ");
    double productPrice =double.Parse(Console.ReadLine());

    Console.WriteLine($"Выберете к какой категории относиться данный продукт: \n Питание - 1 \n Хозтовар - 2 \n Спорттовары - 3  {i}: ") ;
    string productCategory = Console.ReadLine();

    Product myProduct;

    switch (productCategory)
    {
        case "1":
            myProduct = new FoodProduct();
            break;
        case "2":
            myProduct = new HouseholdProduct();
            break;
        case "3":
            myProduct = new SportProduct();
            break;
        default: 
            myProduct = new Product();
            break;
    }

    var product = new Product();

    product.Name = productName;
    product.Description = productDescription;
    product.Price = productPrice;
   

    productList.Add(product);

}

foreach (var product in productList)
    Console.WriteLine($"Название продукта: {product.Name}, Описание: {product.Description}, цена: {product.Price} "  );

foreach (var myProduct in productList)
    Console.WriteLine($"Продукт из категории " );



public class Product
{
    public string Name;
    public string Description;
    public double Price;
    

   
  

    




}

public class FoodProduct : Product
{


}


public class HouseholdProduct : Product
{


}





public class SportProduct : Product
{
   public string sport;
 



}


public class Convert
{
    public double USD = 2.67;
    public double EUR = 2.87;

}