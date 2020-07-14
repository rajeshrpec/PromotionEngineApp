using system;
using System.Collections.Generic;

namespace PromotionEngine
{
    static void Main(string[] args)
    {
    
        List<Product> products =new List<Product>();
        ProductService productService = new ProductService();

        console.WriteLine("Total no of Orders");
        int NoOfOrders = convert.ToInt32(console.readLine());
        
        for (int i = 0; i < NoOfOrders; i++)
        {
            console.WriteLine("Please provide the type of product: A or B or C or D");
            string productType=console.readLine();
            Product product=new Product();
            product.Id=productType;
            products.Add(product);
        }
        
        int totalPrice= productService.GetTotalPrice(products);
        console.WriteLine(totalPrice);
        console.readLine();
    }
    
 }
