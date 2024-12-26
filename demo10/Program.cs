
//product 
//3 function
//1 par name >> product name :Ipone 
//2name price >> Ipone 300 
//3 name price qty
//>> ipone 300kd 1500kd 
//calss min program 
//console.ReadLine 

using demo10.Modele;
using System;

Product products = new Product();
Console.WriteLine("enter the name of prodect ");
products.name=( Console.ReadLine());
Console.WriteLine("enter the price of prodect ");
products.price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the qty of prodect ");
products.qty = Convert.ToInt32(Console.ReadLine());




products.AddProducts(products.name,products. price,products. qty);

//Console.WriteLine(products.name, +products.price, products.qty, (products.price * products.qty));
            
 products.GetProduct();

Product prd = new Product();
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("number of prodect");
for (int i = 1; i <= count; i++)
{
    Console.WriteLine("Enter your product  ");
    string Pname = Console.ReadLine();

    Console.WriteLine("Enter price ");
    int Pprice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Qty ");
    int Pqty = Convert.ToInt32(Console.ReadLine());


    prd.AddProducts(Pname, Pprice, Pqty);

}
products.GetProduct();

    