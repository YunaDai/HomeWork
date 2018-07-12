using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Homework2
{
    public class ShoppingCart
    {    
        public string AddProduct(int[] id,int[] quantity) 
        {            
            var products = GetProducts();
            var result = "";       
            var totalPrice = 0;         

            var res = from x in products
                      where id.Contains(x.ID)
                      orderby id.Contains(x.ID)
                      select x;
            
            for(var i = 0; i < id.Length; i++)
            {               
                foreach( var r in res)
                {
                    if (r.ID == id[i])
                    {
                        result += "在「" + r.Store+ "」買了「" + r.Name +"」*"+quantity[i]+"，";
                        totalPrice += r.Price * quantity[i];
                    }
                }
            }

            result += "共花了" + totalPrice + "元";          
            return result;
        }
        private List<Product> GetProducts()
        {
            List<Product> p = new List<Product>();
            p.Add(new Product { ID = 1, Name = "二手蘋果手機", Price = 8700, Store = "XX商店" });
            p.Add(new Product { ID = 2, Name = "C# cookbook", Price = 568, Store = "XX商店" });
            p.Add(new Product { ID = 3, Name = "hp 筆電", Price = 16888, Store = "XX商店" });
            p.Add(new Product { ID = 4, Name = "哈利波特影集", Price = 2250, Store = "OO商店" });
            p.Add(new Product { ID = 5, Name = "無間道三部曲", Price = 1090, Store = "OO商店" });
            return p;
        }   
    }
}
