using demo10.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace demo10.Modele
{
    public class Product
    {
        public string Function(string name)
        {
            return"Prodct is "+name;
        }
        public string Function(string name, int price)
        {

            return "Prodct is " + name + " price is " + price;
        }
        public string Function(string name, int price , int qty)
        {
            int result = price * qty;

            return "Prodct is " + name + " price is " + price+" Qty is ; "+qty+" total result is "+result;
        }




        //bonas 

        public string name { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
        static List<Product> Productslst = new List<Product>();
        public void AddProducts(string Name, int Price, int Qty)
        {
            Productslst.Add(new Product { name = Name, price = Price, qty = Qty });
        }

        public  void GetProduct()
        {

            Console.WriteLine(" -----------All prodct ------------");
            foreach (Product cutmar in Productslst)
            {
                Console.WriteLine("Name: "+ cutmar.name +"   "+cutmar.price+"  KD "+" Qty:  "
                    +cutmar.qty+ "  "+" total:  "+ (cutmar.price* cutmar.qty));
            }
        }
    } }
  